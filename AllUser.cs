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
    public partial class AllUser : Form
    {

        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                        $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                       $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        public AllUser()
        {
            InitializeComponent();
            LoadData();
        }



        public void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @" SELECT Name, Phone, Address FROM tbl_customer";
                      
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dgvHienThi.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
