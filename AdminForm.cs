﻿using System;
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
    public partial class AdminForm : Form
    {
        private readonly int userId;

        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void yêuCầuPhânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Requests f = new Requests(this.userId);
            f.ShowDialog();
        }
    }
}
