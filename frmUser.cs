using Microsoft.VisualBasic.ApplicationServices;
using QuanLyBanHangOnline;
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
    public partial class frmUser : Form
    {
        string connectionString = $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
                           $"Database={Environment.GetEnvironmentVariable("DB_DATABASE")};" +
                          $"Integrated Security={Environment.GetEnvironmentVariable("DB_INTEGRATED_SECURITY")};";

        private readonly int userId;

        public frmUser(int userId)
        {
            InitializeComponent();
            this.userId = userId;

        }
        public frmUser()
        {
            InitializeComponent();

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmUserform f = new frmUserform(userId);
            f.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            frmProduct f = new frmProduct(this.userId);
            f.Show();
        }


    }
}
