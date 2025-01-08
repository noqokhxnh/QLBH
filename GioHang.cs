<<<<<<< HEAD
﻿namespace QLBH
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

        public partial class GioHang : Form
    {
        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                           $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                          $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";



        public event Action OnClose;

                private readonly int userId;

                public GioHang()
        {
            InitializeComponent();
        }

                private void LoadGioHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tbl_giohang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt);
                    dgvCart.DataSource = dt;

                    if (!dgvCart.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                        btnDelete.Name = "Delete";
                        btnDelete.Text = "Xóa";
                        btnDelete.UseColumnTextForButtonValue = true;
                        dgvCart.Columns.Add(btnDelete);
                    }

                    UpdateTotalPrice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải giỏ hàng: " + ex.Message);
                }
            }
        }

                private void UpdateTotalPrice()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(Price * Stock) FROM tbl_giohang";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    decimal totalPrice = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                    txtTien.Text = $"{totalPrice:#,0} VND";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tính tổng tiền: " + ex.Message);
                }
            }
        }

                private void GioHang_Load(object sender, EventArgs e)
        {
            LoadGioHang();
        }

                private void btnThanhToan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                string insertHistoryQuery = @"
                              INSERT INTO tbl_order_history (ProductName, Stock, Price)
                              SELECT ProductName, Stock, Price FROM tbl_giohang";
                SqlCommand historyCmd = new SqlCommand(insertHistoryQuery, conn, transaction);
                historyCmd.ExecuteNonQuery();
                try
                {
                    // Cập nhật số lượng trong kho
                    string updateStockQuery = @"
                    UPDATE p 
                    SET p.Stock = p.Stock - g.Stock 
                    FROM tbl_product p 
                    JOIN tbl_giohang g ON p.ProductName = g.ProductName";

                    SqlCommand updateCmd = new SqlCommand(updateStockQuery, conn, transaction);
                    updateCmd.ExecuteNonQuery();

                    // Xóa giỏ hàng
                    string clearCartQuery = "DELETE FROM tbl_giohang";
                    SqlCommand clearCmd = new SqlCommand(clearCartQuery, conn, transaction);
                    clearCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show($"Thanh toán thành công! Tổng tiền: {txtTien.Text}");
                    LoadGioHang();
                    OnClose?.Invoke();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}");
                }
            }
        }

                private void GioHang_FormClosing(object sender, FormClosingEventArgs e)
        {

            OnClose?.Invoke();
        }

                private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int ProductId = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["ProductId"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM tbl_giohang WHERE ProductId = @ProductId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductId", ProductId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadGioHang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
                    }
                }
            }
        }

                private decimal CalculateTotalPrice()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(Price * Stock) FROM tbl_giohang";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tính tổng tiền: " + ex.Message);
                    return 0;
                }
            }
        }

                private void btnApDung_Click(object sender, EventArgs e)
        {
            string maGiamGia = txtGiamGia.Text.Trim();

            if (string.IsNullOrEmpty(maGiamGia))
            {
                MessageBox.Show("Vui lòng nhập mã giảm giá.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT GiamGia FROM tbl_magiamgia WHERE MaGiamGia = @MaGiamGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiamGia", maGiamGia);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        float giamGia = Convert.ToSingle(result);
                        if (giamGia > 0 && giamGia <= 100)
                        {
                            decimal currentPrice = CalculateTotalPrice();
                            decimal discountAmount = currentPrice * (decimal)(giamGia / 100);
                            decimal finalPrice = currentPrice - discountAmount;

                            txtTien.Text = $"{finalPrice:#,0} VND";
                            MessageBox.Show($"Áp dụng mã giảm giá thành công!\n" +
                                            $"Giảm {giamGia}%: {discountAmount:#,0} VND\n" +
                                            $"Tổng tiền sau giảm: {finalPrice:#,0} VND");
                        }
                        else
                        {
                            MessageBox.Show("Mã giảm giá không hợp lệ.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã giảm giá không tồn tại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi áp dụng mã giảm giá: {ex.Message}");
                }
            }
        }
    }
}
=======
﻿namespace QLBH
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

        public partial class GioHang : Form
    {
                internal string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                                 $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                                $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

                public event Action OnClose;

                private readonly int userId;

                public GioHang()
        {
            InitializeComponent();
        }

                private void LoadGioHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tbl_giohang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt);
                    dgvCart.DataSource = dt;

                    if (!dgvCart.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                        btnDelete.Name = "Delete";
                        btnDelete.Text = "Xóa";
                        btnDelete.UseColumnTextForButtonValue = true;
                        dgvCart.Columns.Add(btnDelete);
                    }

                    UpdateTotalPrice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải giỏ hàng: " + ex.Message);
                }
            }
        }

                private void UpdateTotalPrice()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(Price * Stock) FROM tbl_giohang";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    decimal totalPrice = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                    txtTien.Text = $"{totalPrice:#,0} VND";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tính tổng tiền: " + ex.Message);
                }
            }
        }

                private void GioHang_Load(object sender, EventArgs e)
        {
            LoadGioHang();
        }

                private void btnThanhToan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                string insertHistoryQuery = @"
                              INSERT INTO tbl_order_history (ProductName, Stock, Price)
                              SELECT ProductName, Stock, Price FROM tbl_giohang";
                SqlCommand historyCmd = new SqlCommand(insertHistoryQuery, conn, transaction);
                historyCmd.ExecuteNonQuery();
                try
                {
                    // Cập nhật số lượng trong kho
                    string updateStockQuery = @"
                    UPDATE p 
                    SET p.Stock = p.Stock - g.Stock 
                    FROM tbl_product p 
                    JOIN tbl_giohang g ON p.ProductName = g.ProductName";

                    SqlCommand updateCmd = new SqlCommand(updateStockQuery, conn, transaction);
                    updateCmd.ExecuteNonQuery();

                    // Xóa giỏ hàng
                    string clearCartQuery = "DELETE FROM tbl_giohang";
                    SqlCommand clearCmd = new SqlCommand(clearCartQuery, conn, transaction);
                    clearCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show($"Thanh toán thành công! Tổng tiền: {txtTien.Text}");
                    LoadGioHang();
                    OnClose?.Invoke();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}");
                }
            }
        }

                private void GioHang_FormClosing(object sender, FormClosingEventArgs e)
        {

            OnClose?.Invoke();
        }

                private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int ProductId = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["ProductId"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM tbl_giohang WHERE ProductId = @ProductId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductId", ProductId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadGioHang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
                    }
                }
            }
        }

                private decimal CalculateTotalPrice()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(Price * Stock) FROM tbl_giohang";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tính tổng tiền: " + ex.Message);
                    return 0;
                }
            }
        }

                private void btnApDung_Click(object sender, EventArgs e)
        {
            string maGiamGia = txtGiamGia.Text.Trim();

            if (string.IsNullOrEmpty(maGiamGia))
            {
                MessageBox.Show("Vui lòng nhập mã giảm giá.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT GiamGia FROM tbl_magiamgia WHERE MaGiamGia = @MaGiamGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiamGia", maGiamGia);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        float giamGia = Convert.ToSingle(result);
                        if (giamGia > 0 && giamGia <= 100)
                        {
                            decimal currentPrice = CalculateTotalPrice();
                            decimal discountAmount = currentPrice * (decimal)(giamGia / 100);
                            decimal finalPrice = currentPrice - discountAmount;

                            txtTien.Text = $"{finalPrice:#,0} VND";
                            MessageBox.Show($"Áp dụng mã giảm giá thành công!\n" +
                                            $"Giảm {giamGia}%: {discountAmount:#,0} VND\n" +
                                            $"Tổng tiền sau giảm: {finalPrice:#,0} VND");
                        }
                        else
                        {
                            MessageBox.Show("Mã giảm giá không hợp lệ.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã giảm giá không tồn tại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi áp dụng mã giảm giá: {ex.Message}");
                }
            }
        }
    }
}
>>>>>>> 822f9efd09c46cf0066c65cd36de169c35c51c7e
