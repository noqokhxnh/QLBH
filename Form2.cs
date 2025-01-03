

﻿namespace QuanLyBanHangOnline

{
    using QLBH;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using static QuanLyBanHangOnline.frmUserform;

    public partial class frmUserform : Form
    {
        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                          $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                          $"User Id={Environment.GetEnvironmentVariable("DB_USER")};" +
                          $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")};";

        List<CartItem> cartItems = new List<CartItem>();

        public frmUserform()
        {
            DotNetEnv.Env.Load();
            InitializeComponent();

        }


        public class CartItem
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int Stock { get; set; }
            public decimal Price { get; set; }

        }


        private void LoadProductData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, ProductName, Stock, Price FROM tbl_product";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    int rowsAffected = dataAdapter.Fill(dataTable);

                    if (rowsAffected > 0)
                    {
                        dgvHIenThi.DataSource = dataTable;
                        dgvHIenThi.Columns["Price"].DefaultCellStyle.Format = "###,### VND";
                        cbxSanPham.DataSource = dataTable;
                        cbxSanPham.DisplayMember = "ProductName";
                        cbxSanPham.ValueMember = "ProductID";

                    }
                    else
                    {
                        dgvHIenThi.DataSource = null;
                        MessageBox.Show("Không tìm thấy sản phẩm nào trong cơ sở dữ liệu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void frmUserform_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void btbLogout_Click(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbxSanPham.SelectedValue == null)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn");
                return;
            }

            int productId;
            if (!int.TryParse(cbxSanPham.SelectedValue?.ToString(), out productId))
            {
                MessageBox.Show("Lỗi khi lấy thông tin sản phẩm! Kiểm tra lại dữ liệu.");
                return;
            }

            int requestedStock;
            if (!int.TryParse(txtsoluong.Text, out requestedStock) || requestedStock <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }

            // Lấy thông tin sản phẩm từ cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string getProductQuery = "SELECT ProductName, Price FROM tbl_product WHERE ProductID = @ProductID";
                SqlCommand getProductCmd = new SqlCommand(getProductQuery, conn);
                getProductCmd.Parameters.AddWithValue("@ProductID", productId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = getProductCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string productName = reader["ProductName"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);

                        // Thêm sản phẩm vào giỏ hàng
                        CartItem newItem = new CartItem
                        {
                            ProductID = productId,
                            ProductName = productName,
                            Stock = requestedStock,
                            Price = price
                        };

                        cartItems.Add(newItem);
                        MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm trong cơ sở dữ liệu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm sản phẩm vào giỏ hàng: " + ex.Message);
                }
            }
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            if (cbxSanPham.SelectedValue == null)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn để đánh giá");
                return;
            }

            int productId = Convert.ToInt32(cbxSanPham.SelectedValue);
            frmDanhGia frm = new frmDanhGia(productId);
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            MessageBox.Show("Đăng xuất thành công");
            frmLogin.Show();
            this.Close();
        }

        private void GioHang_Click(object sender, EventArgs e)
        {
            GioHang f = new GioHang(cartItems);
            f.OnClose += GioHangForm_OnClose;
            f.ShowDialog();
            
        }

        private void GioHangForm_OnClose()
        {
            
            LoadProductData();
        }

    }
}
