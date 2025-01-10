namespace QuanLyBanHangOnline
{
    using QLBH;
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;

        public partial class frmLogin : Form
    {
                string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                     $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                    $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

                public frmLogin()
        {
            DotNetEnv.Env.Load();
            InitializeComponent();
        }

                private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserId, Role FROM tbl_user WHERE Username = @username AND Password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(reader.GetOrdinal("UserId"));
                        string role = reader["Role"].ToString().Trim();
                        MessageBox.Show("Đăng nhập thành công" );
                        this.Hide();
                        if (role == "Admin")
                        {
                            AdminForm f = new AdminForm(userId);
                            f.Show();
                        }
                        else if (role == "user")
                        {
                            frmUserform f = new frmUserform(userId);
                            f.Show();
                        }
                        else
                        {
                            frmProduct f = new frmProduct(userId);
                            f.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng." );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message );
            }
        }

                private void btnDangki_Click(object sender, EventArgs e)
        {
            
            frmsignup f = new frmsignup();
            
            f.Show();
            

        }
    }
}
