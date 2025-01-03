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
    public partial class GiamGia : Form
    {


        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                                 $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                                $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        public GiamGia()
        {
            InitializeComponent();
            DotNetEnv.Env.Load();
        }

        private void GiamGia_Load(object sender, EventArgs e)
        {
            LoadMaGiamGia();
        }

        private void LoadMaGiamGia()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "SELECT MaGiamGia, GiamGia FROM tbl_magiamgia";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                try
                {
                    conn.Open();
                    int rowsAffected = dataAdapter.Fill(dataTable);

                    if (rowsAffected > 0)
                    {
                        dgvMaGiamGia.DataSource = dataTable;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        public void ThemMa(string ma, float giam)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "Insert into tbl_magiamgia (MaGiamGia, GiamGia) values (@MaGiamGia, @GiamGia)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaGiamGia", ma);
                cmd.Parameters.AddWithValue("@GiamGia", giam);
                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm mã giảm giá thành công");
                        LoadMaGiamGia();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm mã ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. Vui lòng thử lại");
                    Console.WriteLine(ex.ToString());
                }


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maGiamGia = txtCode.Text.Trim();
            string giamGiastr = txtGiam.Text.Trim();
            if (string.IsNullOrEmpty(maGiamGia) || string.IsNullOrEmpty(giamGiastr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mã giảm giá và giá trị giảm.");
                return;
            }

            if (float.TryParse(giamGiastr, out float giamGia))
            {
                if (giamGia < 0 || giamGia > 100)
                {
                    MessageBox.Show("Giảm giá phải nằm trong khoảng từ 0 đến 100%");
                    return;
                }
                ThemMa(maGiamGia, giamGia);
            }
            else
            {
                MessageBox.Show("Giá trị giảm phải là một số hợp lệ.");
            }

        }

        private void Delete(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tbl_magiamgia WHERE MaGiamGia = @maGiamGia";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maGiamGia", ma);


                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa Mã thành công");
                        LoadMaGiamGia();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa mã này.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. Vui lòng thử lại");
                    Console.WriteLine(ex.ToString());
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMaGiamGia.SelectedRows.Count > 0 && dgvMaGiamGia.SelectedRows[0].Cells["maGiamGia"] != null)
            {
                string ma = dgvMaGiamGia.SelectedRows[0].Cells["MaGiamGia"].Value.ToString();
                Delete(ma);
            }
            else
            {
                MessageBox.Show("Chọn một mã để xoá");
            }
        }
    }
}


