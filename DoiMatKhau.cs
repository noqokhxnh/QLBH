namespace QLBH
{
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class DoiMatKhau : Form
    {
        internal string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                 $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        private readonly int userId;

        public DoiMatKhau(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            String oldPass = txtOldPass.Text.Trim();
            String newPass = txtNewPass.Text.Trim();
            String comfirmPass = txtComfirmPass.Text.Trim();

            if (String.IsNullOrEmpty(oldPass) || String.IsNullOrEmpty(newPass) || String.IsNullOrEmpty(comfirmPass))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPass != comfirmPass)
            {
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
            }
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();
                    string query = @"UPDATE tbl_user SET Password = @newPass WHERE UserId = @userId AND Password = @oldPass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newPass", newPass);
                        cmd.Parameters.AddWithValue("@oldPass", oldPass);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu cũ không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi", ex.Message);
            }

        }
    }
}

