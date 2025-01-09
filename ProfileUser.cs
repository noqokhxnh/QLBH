namespace QLBH
{
    using QuanLyBanHangOnline;
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;

        public partial class ProfileUser : Form
    {
                internal string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                           $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                          $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

                private int CustomerId;

                private int UserId;

                public ProfileUser(int userID)
        {
            DotNetEnv.Env.Load();
            InitializeComponent();
            this.UserId = userID;
            LoadUserProfile();
        }

                public ProfileUser()
        {
            InitializeComponent();
        }

                private void LoadUserProfile()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Name, Phone, Address FROM tbl_customer WHERE UserId = @UserId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                        cmd.Parameters.AddWithValue("@UserId", UserId);

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

                    string query = "SELECT COUNT(*) FROM tbl_customer WHERE UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                        cmd.Parameters.AddWithValue("@UserId", UserId);

                        int count = (int)cmd.ExecuteScalar();
                        if (count == 0)
                        {
                            // Nếu thông tin chưa tồn tại, thực hiện INSERT
                            string insertQuery = @"INSERT INTO tbl_customer ( UserId, Name, Phone, Address) 
                                           VALUES ( @UserId, @Name, @Phone, @Address) ";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                                insertCmd.Parameters.AddWithValue("@UserId", UserId);
                                insertCmd.Parameters.AddWithValue("@Name", Name);
                                insertCmd.Parameters.AddWithValue("@Phone", Phone);
                                insertCmd.Parameters.AddWithValue("@Address", Address);
                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm thông tin thành công!");
                            }
                        }
                        else
                        {
                            // Nếu thông tin đã tồn tại, thực hiện UPDATE
                            string updateQuery = @"UPDATE tbl_customer 
                                           SET Name = @Name, Phone = @Phone, Address = @Address 
                                           WHERE UserId = @UserId";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                                updateCmd.Parameters.AddWithValue("@UserId", UserId);
                                updateCmd.Parameters.AddWithValue("@Name", Name);
                                updateCmd.Parameters.AddWithValue("@Phone", Phone);
                                updateCmd.Parameters.AddWithValue("@Address", Address);
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
                MessageBox.Show($"Lỗi: {ex.Message}\nCustomerId: {CustomerId}, UserId: {UserId}");
            }
        }

                private void btnBack_Click(object sender, EventArgs e)
        {
            frmUserform f = new frmUserform(this.CustomerId);
            f.Show();
            this.Close();
        }
    }
}
