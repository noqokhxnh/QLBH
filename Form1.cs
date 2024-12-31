namespace QuanLyBanHangOnline
{   using Microsoft.Extensions.Configuration;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

        public partial class frmAdminform : Form
    {
        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                 $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                 $"User Id={Environment.GetEnvironmentVariable("DB_USER")};" +
                 $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")};" +
                 $"Trusted_Connection=true;";

        public frmAdminform()
        {
            DotNetEnv.Env.Load();
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
                        LoadProductData(); 
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm sản phẩm!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. Vui lòng thử lại!");
                    Console.WriteLine(ex.ToString());
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
                        LoadProductData(); 
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa sản phẩm!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. Vui lòng thử lại!");
                    Console.WriteLine(ex.ToString());
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
                        LoadProductData(); 
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sản phẩm!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. Vui lòng thử lại!");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

                private void SearchProduct(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, ProductName, Price, Stock FROM tbl_product " +
                               "WHERE ProductName LIKE @Keyword";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    int rowsAffected = dataAdapter.Fill(dataTable);

                    if (rowsAffected > 0)
                    {
                        dgvHienThi.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm nào phù hợp.");
                        dgvHienThi.DataSource = null;
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
            string productName = txtProductName.Text.Trim();

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ!");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Số lượng sản phẩm không hợp lệ!");
                return;
            }

            AddProduct(productName, price, stock);
        }

                private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0 && dgvHienThi.SelectedRows[0].Cells["ProductID"] != null)
            {
                int productId = Convert.ToInt32(dgvHienThi.SelectedRows[0].Cells["ProductID"].Value);
                string productName = txtProductName.Text.Trim();
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
            if (dgvHienThi.SelectedRows.Count > 0 && dgvHienThi.SelectedRows[0].Cells["ProductID"] != null)
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
        }

                private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txtFind.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            SearchProduct(keyword);
        }

                private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvHienThi.Rows[e.RowIndex];

     
                txtId.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
            }
        }

                private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            MessageBox.Show("Đăng xuất thành công!");
            frmLogin.Show();
            this.Close();
        }

                private void xemThôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
