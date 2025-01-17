﻿namespace QLBH
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class Requests : Form
    {
        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                  $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                 $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        private readonly int userId;

        public Requests(int userId)
        {
            InitializeComponent();
            this.Load += frmManageSellerRequests_Load;
            this.dgvRequests.CellClick += dgvRequests_CellClick;
            this.btnApprove.Click += btnApprove_Click;
            this.btnReject.Click += btnReject_Click;

            this.userId = userId;
        }

        public int getuserId()
        {
            return this.userId;
        }

        private void frmManageSellerRequests_Load(object sender, EventArgs e)
        {

            LoadRequests();
        }

        private void LoadRequests()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @" SELECT r.RequestId, r.UserId, u.Username
                                FROM tbl_role_request r 
                                JOIN tbl_user u ON r.UserId = u.UserId";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn); DataTable dt = new DataTable(); try
                {
                    conn.Open(); adapter.Fill(dt);
                    dgvRequests.DataSource = dt;
                    dgvRequests.Columns["RequestId"].Visible = false;
                    dgvRequests.Columns["Userid"].Visible = false;
                }
                catch (Exception ex) { MessageBox.Show($"Lỗi ", ex.Message); }
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {   
               
            if (string.IsNullOrEmpty(txtUserId.Text))
            { 
                MessageBox.Show("Vui lòng chọn một yêu cầu để xử lý.");
                return;
            }
            int selectedUserId = Convert.ToInt32(txtUserId.Text);
            int requestId = Convert.ToInt32(dgvRequests.SelectedRows[0].Cells["RequestId"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string ụpdatequery = @"UPDATE tbl_user SET Role = 'Seller' WHERE UserId = @UserId;";
                string deletequery = "DELETE FROM tbl_role_request WHERE RequestId = @RequestId;";

                SqlCommand updateCmd = new SqlCommand(ụpdatequery, conn);
                SqlCommand deleteCmd = new SqlCommand(deletequery, conn);

                updateCmd.Parameters.AddWithValue("@UserId", selectedUserId); 
                deleteCmd.Parameters.AddWithValue("@RequestId", requestId);
                SqlTransaction transaction;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    updateCmd.Transaction = transaction;
                    deleteCmd.Transaction = transaction;

                    updateCmd.ExecuteNonQuery();
                    deleteCmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Yêu cầu đã được chấp thuận.");
                    LoadRequests();
                    ClearDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi ", ex.Message);
                }
            }
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserId.Text)) 
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu để xử lý."); 
                return; 
            }
            int requestId = Convert.ToInt32(dgvRequests.SelectedRows[0].Cells["RequestId"].Value);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"DELETE FROM tbl_role_request WHERE RequestId = @RequestId;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RequestId", requestId);
                try
                {
                    conn.Open(); cmd.ExecuteNonQuery();
                    MessageBox.Show("Yêu cầu đã bị từ chối.");
                    LoadRequests();
                    ClearDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi ", ex.Message);
                }
            }
        }


        private void ClearDetails()
        {
            txtUserId.Clear();
            txtUsername.Clear();

           
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRequests.Rows[e.RowIndex]; txtUserId.Text = row.Cells["UserId"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click_1(object sender, EventArgs e)
        {

        }
    }
}
