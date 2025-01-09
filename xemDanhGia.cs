namespace QLBH
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class xemDanhGia : Form
    {
        internal string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                       $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                      $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        private int productId;

        public xemDanhGia(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            LoadReviewData();
        }

        private void LoadReviewData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT reviewID, ProductId, Rating, Comment FROM tbl_review";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@ProductID", productId);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    dataAdapter.Fill(dataTable);
                    dgvDanhGia.DataSource = dataTable;

                }
                
               catch (Exception ex)
                {
                    MessageBox.Show("Loi!", ex.Message);

                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhGia.SelectedRows.Count > 0)
            {
                int reviewId = Convert.ToInt32(dgvDanhGia.SelectedRows[0].Cells["reviewID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string deleteQuery = "DELETE FROM tbl_review WHERE reviewID = @reviewID";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@reviewID", reviewId);

                    try
                    {
                        conn.Open();
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Đánh giá đã được xóa thành công");
                        LoadReviewData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa đánh giá: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đánh giá để xóa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}