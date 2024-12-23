using QLBH;
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

namespace QuanLyBanHangOnline
{
    public partial class frmLogin : Form
    {

        internal string connectionString =
    $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
    $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
    $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";
        public frmLogin()
        {
            DotNetEnv.Env.Load();
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
            string dbDatabase = Environment.GetEnvironmentVariable("DB_DATABASE");
            string dbSecurity = Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY");

            //MessageBox.Show($"Server: {dbServer}, Database: {dbDatabase}, Integrated Security: {dbSecurity}",
            //                "Thông tin kết nối", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Role FROM tbl_user WHERE Username = @username AND Password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    var role = cmd.ExecuteScalar();

                    if (role != null)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        if (role.ToString().Trim() == "Admin")
                        {
                            frmAdminform adminForm = new frmAdminform();
                            adminForm.Show();
                        }
                        else
                        {
                            frmUserform userForm = new frmUserform();
                            userForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            frmsignup Signupform = new frmsignup();
            Signupform.Show();
        }
    }
}
