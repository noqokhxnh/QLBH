namespace QuanLyBanHangOnline
{   using Microsoft.Extensions.Configuration;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class frmAdminform : Form
    {
       internal string connectionString = 
    $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
    $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
    $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        public frmAdminform()
        {
            InitializeComponent();
        }

        private void LoadProductData()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "SELECT ProductID, ProductName, Price, Stock FROM tbl_product";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();

                try
                {

                    conn.Open();
                    int rowsAffected = dataAdapter.Fill(dataTable);

                    if (rowsAffected > 0)
                    {
                        dgvHienThi.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void frmAdminform_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }


        private void AddProduct(string productName, decimal price, int stock)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tbl_product (ProductName, Price, Stock) VALUES (@ProductName, @Price, @Stock)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Stock", stock);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!");
                        LoadProductData(); // Tải lại dữ liệu sau khi thêm
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm sản phẩm!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void EditProduct(int productId, string productName, decimal price, int stock)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE tbl_product SET ProductName = @ProductName, Price = @Price, Stock = @Stock WHERE ProductID = @ProductID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Stock", stock);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa sản phẩm thành công!");
                        LoadProductData(); // Tải lại dữ liệu sau khi sửa
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa sản phẩm!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }


        private void DeleteProduct(int productId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tbl_product WHERE ProductID = @ProductID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        LoadProductData(); // Tải lại dữ liệu sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sản phẩm!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int stock = Convert.ToInt32(txtStock.Text);

            AddProduct(productName, price, stock);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dgvHienThi.SelectedRows[0].Cells["ProductID"].Value);
                string productName = txtProductName.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);
                int stock = Convert.ToInt32(txtStock.Text);

                EditProduct(productId, productName, price, stock);
            }
            else
            {
                MessageBox.Show("Hãy chọn một sản phẩm để sửa!");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dgvHienThi.SelectedRows[0].Cells["ProductID"].Value);
                DeleteProduct(productId);
            }
            else
            {
                MessageBox.Show("Hãy chọn một sản phẩm để xóa!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            MessageBox.Show("Đăng xuất thành công!");
            frmLogin.Show();
            this.Close();
        }
    }
}
