using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;
using QLBH;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBanHangOnline
{
    public partial class frmUserform : Form
    {

        internal string connectionString =
      $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
      $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
      $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        public frmUserform()
        {
            DotNetEnv.Env.Load();
            InitializeComponent();
        }

        private void LoadProductData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, ProductName, Stock FROM tbl_product";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    int rowsAffected = dataAdapter.Fill(dataTable);

                    if (rowsAffected > 0)
                    {
                        dgvHIenThi.DataSource = dataTable;
                        cbxSanPham.DataSource = dataTable;
                        cbxSanPham.DisplayMember = "ProductName";
                        cbxSanPham.ValueMember = "ProductID";


                    }
                    else
                    {
                        dgvHIenThi.DataSource = null;
                        MessageBox.Show("Không tìm thấy sản phẩm nào trong cơ sở dữ liệu!");
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
            frmLogin frmLogin = new frmLogin();
            MessageBox.Show("Đăng xuất thành công!");
            frmLogin.Show();
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbxSanPham.SelectedValue == null)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn!");
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
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string getStockQuery = "SELECT Stock FROM tbl_product WHERE ProductID = @ProductID";
                SqlCommand getStockCmd = new SqlCommand(getStockQuery, conn);
                getStockCmd.Parameters.AddWithValue("@ProductID", productId);

                try
                {
                    conn.Open();
                    int currentStock = Convert.ToInt32(getStockCmd.ExecuteScalar());

                    if (requestedStock > currentStock)
                    {
                        MessageBox.Show("Số lượng yêu cầu vượt quá số lượng trong kho!");
                        return;
                    }

                    string updateStockQuery = "UPDATE tbl_product SET Stock = Stock - @RequestedStock WHERE ProductID = @ProductID";
                    SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn);
                    updateStockCmd.Parameters.AddWithValue("@RequestedStock", requestedStock);
                    updateStockCmd.Parameters.AddWithValue("@ProductID", productId);

                    int result = updateStockCmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Mua sản phẩm thành công!");
                        LoadProductData(); // Tải lại dữ liệu sau khi mua

                        // Hiển thị nút đánh giá sau khi mua sản phẩm
                        btnDanhGia.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật số lượng sản phẩm!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện giao dịch: " + ex.Message);
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            if (cbxSanPham.SelectedValue == null)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn để đánh giá!");
                return;
            }

            int productId = Convert.ToInt32(cbxSanPham.SelectedValue); // Lấy ProductID từ combobox
            frmDanhGia frm = new frmDanhGia(productId); // Truyền productId vào constructor
            frm.ShowDialog(); // Hiển thị form đánh giá
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
