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
using System.Xml.Linq;

namespace QLBH
{
    public partial class frmDanhGia : Form
    {


        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                                 $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                                $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        private int productId;
        public frmDanhGia(int productId)
        {
            InitializeComponent();
            this.productId = productId;
        }

        private void btnGuidanhgia_Click(object sender, EventArgs e)
        {
            string comment = txtComment.Text;
            int rating = cbxRating.SelectedIndex + 1; // CbxRating có thể là ComboBox với các giá trị 1 đến 5

            if (rating == 0)
            {
                MessageBox.Show("Vui lòng chọn mức đánh giá");
                return;
            }

            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Vui lòng nhập nhận xét");
                return;
            }

            // Lưu đánh giá vào cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string insertReviewQuery = "INSERT INTO tbl_review (ProductID, Rating, Comment) VALUES (@ProductID, @Rating, @Comment)";
                SqlCommand insertReviewCmd = new SqlCommand(insertReviewQuery, conn);
                insertReviewCmd.Parameters.AddWithValue("@ProductID", productId);
                insertReviewCmd.Parameters.AddWithValue("@Rating", rating);
                insertReviewCmd.Parameters.AddWithValue("@Comment", comment);

                try
                {
                    conn.Open();
                    int result = insertReviewCmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Đánh giá của bạn đã được gửi thành công");
                        this.Close(); // Đóng form sau khi gửi đánh giá
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi gửi đánh giá");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void frmDanhGia_Load(object sender, EventArgs e)
        {
            lblProductName.Text = "Đánh giá sản phẩm ID: " + productId;
        }
    }
}
