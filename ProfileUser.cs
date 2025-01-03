using Microsoft.VisualBasic.ApplicationServices;
using QuanLyBanHangOnline;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLBH
{
    public partial class ProfileUser : Form
    {

        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                                 $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                                $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";
        private int CustomerId;
        public ProfileUser(int CustomerId)
        {
            DotNetEnv.Env.Load();
            InitializeComponent();
            this.CustomerId = CustomerId;
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Name, Phone, Address FROM tbl_customer WHERE CustomerId = @CustomerId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", CustomerId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["Name"].ToString();
                                txtPhone.Text = reader["Phone"].ToString();
                                txtDiaChi.Text = reader["Address"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin người dùng: " + ex.Message,
                                  "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {


            string Name = txtName.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Address = txtDiaChi.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"SELECT COUNT(*) FROM tbl_customer WHERE CustomerId = {CustomerId}";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        if (count == 0)
                        {
                            // CustomerId không tồn tại, thực hiện INSERT
                            string insertQuery = @"INSERT INTO tbl_customer (CustomerId, Name, Phone, Address) 
                                         VALUES (@CustomerId, @Name, @Phone, @Address)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                                insertCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@Phone", int.Parse(txtPhone.Text.Trim()));
                                insertCmd.Parameters.AddWithValue("@Address", txtDiaChi.Text.Trim());
                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm thông tin thành công!");
                            }
                        }
                        else
                        {
                            // CustomerId đã tồn tại, thực hiện UPDATE
                            string updateQuery = @"UPDATE tbl_customer 
                                         SET Name = @Name, Phone = @Phone, Address = @Address 
                                         WHERE CustomerId = @CustomerId";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                                updateCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@Phone", int.Parse(txtPhone.Text.Trim()));
                                updateCmd.Parameters.AddWithValue("@Address", txtDiaChi.Text.Trim());
                                updateCmd.ExecuteNonQuery();
                                MessageBox.Show("Cập nhật thông tin thành công!");
                            }
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}\nCustomerId: {CustomerId}");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmUserform f = new frmUserform();
            f.Show();
            this.Close();
        }
    }
}

