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
using static QuanLyBanHangOnline.frmUserform;

namespace QLBH
{
    public partial class GioHang : Form
    {
        private List<CartItem> cartItems;
        private string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                                          $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                                          $"User Id={Environment.GetEnvironmentVariable("DB_USER")};" +
                                          $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")};" +
                                          $"Trusted_Connection=true;";
        public event Action OnClose;
        public GioHang(List<CartItem> cartItems)
        {
            InitializeComponent();
            this.cartItems = cartItems;
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            dgvCart.DataSource = cartItems;
            if (!dgvCart.Columns.Contains("Delete"))
            {
                dgvCart.AutoGenerateColumns = false;
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.Text = "Xóa";
                btnDelete.UseColumnTextForButtonValue = true;
                dgvCart.Columns.Add(btnDelete);
            }
            decimal totalPrice = 0;
            foreach (var item in cartItems)
            {
                totalPrice += item.Price * item.Stock;
            }
            txtTien.Text = totalPrice.ToString("#,0") + " VND";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;
            foreach (var item in cartItems)
            {
                totalPrice += item.Price * item.Stock;
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (var item in cartItems)
                    {

                        string updateStockQuery = "UPDATE tbl_product SET Stock = Stock - @Stock WHERE ProductID = @ProductID";
                        SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn);
                        updateStockCmd.Parameters.AddWithValue("@Stock", item.Stock);
                        updateStockCmd.Parameters.AddWithValue("@ProductID", item.ProductID);
                        updateStockCmd.ExecuteNonQuery();


                    }

                    MessageBox.Show("Đã thanh toán! Tổng tiền: " + txtTien.Text);
                    // Xóa giỏ hàng sau khi thanh toán
                    cartItems.Clear();
                    dgvCart.DataSource = null;
                    txtTien.Clear(); // Xóa số tiền hiển thị



                    OnClose?.Invoke();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thanh toán: " + ex.Message);
                }



            }

        }
        private void GioHang_FormClosing(object sender, FormClosingEventArgs e)
        {

            OnClose?.Invoke();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Lấy sản phẩm cần xóa từ giỏ hàng
                var itemToRemove = cartItems[e.RowIndex];

                // Xóa sản phẩm khỏi danh sách giỏ hàng
                cartItems.Remove(itemToRemove);

                // Cập nhật lại DataGridView
                dgvCart.DataSource = null;
                dgvCart.DataSource = cartItems;
              
                

            // Cập nhật lại tổng số tiền
                decimal totalPrice = 0;
                foreach (var item in cartItems)
                {
                    totalPrice += item.Price * item.Stock;
                }
                txtTien.Text = totalPrice.ToString("#,0") + " VND";
            }
        }
    }
}
