namespace QLBH
{
    using ClosedXML.Excel;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;

    public partial class frmThongKe : Form
    {
         string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                   $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                  $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        public frmThongKe()
        {
            InitializeComponent();
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                p.ProductName,
                p.Price,
                SUM(CASE WHEN gh.Stock IS NULL THEN 0 ELSE gh.Stock END) as TongDaBan,
                SUM(CASE WHEN gh.Stock IS NULL THEN 0 ELSE gh.Stock * p.Price END) as TongDoanhThu
            FROM tbl_product p
            LEFT JOIN tbl_order_history gh ON p.ProductName = gh.ProductName
            GROUP BY p.ProductName, p.Price
            ORDER BY TongDaBan DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    dgvThongKe.DataSource = dt;


                    dgvThongKe.Columns["Price"].DefaultCellStyle.Format = "N0";
                    dgvThongKe.Columns["TongDoanhThu"].DefaultCellStyle.Format = "N0";

                 
                    decimal totalRevenue = dt.AsEnumerable().Sum(row => Convert.ToDecimal(row["TongDoanhThu"]));
                    int totalProductsSold = dt.AsEnumerable().Sum(row => row.Field<int>("TongDaBan"));

                    lblTongdoanhThu.Text = $"Tổng doanh thu: {totalRevenue:N0} VND";
                    lblSoLuongban.Text = $"Tổng sản phẩm đã bán: {totalProductsSold}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi ", ex.Message);

                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FileName = $"ThongKeSanPham_{DateTime.Now:HHmmss_ddMMyyyy}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        DataTable dataTable = (DataTable)dgvThongKe.DataSource;
                        var worksheet = workbook.Worksheets.Add(dataTable, "ThongKe");
                        var column = worksheet.Column("D");
                        column.Style.NumberFormat.Format = "#,##0 \"VND\"";
                        workbook.SaveAs(saveFileDialog.FileName);
                    }
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Lỗi ", ex.Message);

                }
            }
        }

       
    }
    }
