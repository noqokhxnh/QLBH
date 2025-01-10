namespace QLBH
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
                string query = "SELECT ProductId, ProductName, Stock, Price FROM tbl_giohang\r\n";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt);
                    dgvCart.DataSource = dt;
                    dgvCart.Columns["ProductID"].Visible = false;

                    UpdateTotalPrice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi ", ex.Message);

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
                    MessageBox.Show($"Lỗi ", ex.Message);

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

                    string updateStockQuery = @"
                    UPDATE p 
                    SET p.Stock = p.Stock - g.Stock 
                    FROM tbl_product p 
                    JOIN tbl_giohang g ON p.ProductName = g.ProductName";

                    SqlCommand updateCmd = new SqlCommand(updateStockQuery, conn, transaction);
                    updateCmd.ExecuteNonQuery();

                    string deletequery = @"DELETE FROM tbl_giohang";
                    SqlCommand deletecmd = new SqlCommand(deletequery, conn, transaction);
                    deletecmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show($"Thanh toán thành công! Tổng tiền: {txtTien.Text}");
                    LoadGioHang();
                    OnClose?.Invoke();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Lỗi ",ex.Message);
                }
            }
        }

        private void GioHang_FormClosing(object sender, FormClosingEventArgs e)
        {

            OnClose?.Invoke();
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
                    MessageBox.Show("Lỗi : " + ex.Message);
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
                    MessageBox.Show($"Lỗi", ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs ex)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
            
                int productId = Convert.ToInt32(dgvCart.SelectedRows[0].Cells["ProductId"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này khỏi giỏ hàng?",
                                                      "Xác nhận", MessageBoxButtons.YesNo  );

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM tbl_giohang WHERE ProductId = @ProductId";

                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ProductId", productId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Đã xóa sản phẩm khỏi giỏ hàng.");
                            LoadGioHang(); 
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Lỗi  ", e.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
            }
        }
    }
}
