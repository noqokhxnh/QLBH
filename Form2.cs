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
using Microsoft.Extensions.Configuration;
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
                        dgvHIenThi.DataSource = dataTable;
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
    }
}
