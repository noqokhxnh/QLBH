using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmAdmin : Form
    {


        private readonly int userId;
        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                         $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                         $"User Id={Environment.GetEnvironmentVariable("DB_USER")};" +
                         $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")};";




        public frmAdmin(int userId)
        {
            InitializeComponent();
              this.userId = userId;
          
        }
        
        private void phânQuyềnNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Requests f = new Requests(this.userId);
            f.Show();
        }
    }
}
