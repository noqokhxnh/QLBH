﻿using System;
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
using QuanLyBanHangOnline;
namespace QLBH
{
    public partial class frmsignup : Form
    {


        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                               $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                              $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";



        public frmsignup()
        {
            InitializeComponent();
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK  );
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra tài khoản đã tồn tại
                string checkQuery = "SELECT COUNT(*) FROM tbl_user WHERE Username = @username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại.", "Lỗi", MessageBoxButtons.OK  );
                        return;
                    }
                }

        


                // Thêm tài khoản mới

                string insertQuery = "INSERT INTO tbl_user (Username, Password, Role) VALUES (@username, @password, @role)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);
                    insertCmd.Parameters.AddWithValue("@role", "user"); // Role mặc định là "user"

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK );
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại.");
                    }
                }
            }
        }
    }
    }

