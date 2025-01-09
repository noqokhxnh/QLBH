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

namespace QLBH
{
    public partial class RoleRequests : Form
    {

        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                          $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                          $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        private readonly int userId;

        public RoleRequests(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }


        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT r.RequestId, u.Username, r.RequestedRole, r.Status, r.CreatedAt
            FROM tbl_role_requests r
            JOIN tbl_user u ON r.UserId = u.UserId
            WHERE r.Status = 'Pending'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    dgvRoleRequests.DataSource = dataTable;
                    dgvRoleRequests.Columns["RequestId"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải yêu cầu phân quyền: {ex.Message}");
                }
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvRoleRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu.");
                return;
            }

            int requestId = Convert.ToInt32(dgvRoleRequests.SelectedRows[0].Cells["RequestId"].Value);
            int userId = Convert.ToInt32(dgvRoleRequests.SelectedRows[0].Cells["UserId"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string approveQuery = @"
            UPDATE tbl_role_requests
            SET Status = 'Approved'
            WHERE RequestId = @RequestId;

            UPDATE tbl_user
            SET Role = 'Seller'
            WHERE UserId = @UserId;";

                SqlCommand cmd = new SqlCommand(approveQuery, conn);
                cmd.Parameters.AddWithValue("@RequestId", requestId);
                cmd.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yêu cầu đã được chấp thuận.");
                    LoadData(); // Refresh dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi chấp thuận yêu cầu: {ex.Message}");
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvRoleRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu.");
                return;
            }

            int requestId = Convert.ToInt32(dgvRoleRequests.SelectedRows[0].Cells["RequestId"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string rejectQuery = @"
            UPDATE tbl_role_requests
            SET Status = 'Rejected'
            WHERE RequestId = @RequestId";

                SqlCommand cmd = new SqlCommand(rejectQuery, conn);
                cmd.Parameters.AddWithValue("@RequestId", requestId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yêu cầu đã bị từ chối.");
                    LoadData(); // Refresh dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi từ chối yêu cầu: {ex.Message}");
                }
            }
        }
    }
}
