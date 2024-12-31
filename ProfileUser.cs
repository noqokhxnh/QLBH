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
    public partial class ProfileUser : Form
    {
        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                 $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                 $"User Id={Environment.GetEnvironmentVariable("DB_USER")};" +
                 $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")};" +
                 $"Trusted_Connection=true;";
        public ProfileUser()
        {
            DotNetEnv.Env.Load();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

            }
        }
    }
}
