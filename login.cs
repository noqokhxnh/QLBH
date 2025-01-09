﻿namespace QuanLyBanHangOnline
{
    using QLBH;
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;

        public partial class frmLogin : Form
    {
                internal string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
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
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide(); if (role == "Admin")
                        {
                            AdminForm f = new AdminForm(userId); f.Show();
                        }
                        else if (role == "user")
                        {
                            frmUserform userForm = new frmUserform(userId);
                            userForm.Show();
                        }
                        else
                        {
                            frmProduct f = new frmProduct(userId);
                            f.Show();
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
            this.Hide();
        }
    }
}
