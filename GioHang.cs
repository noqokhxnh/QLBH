using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public GioHang(List<CartItem> cartItems)
        {
            InitializeComponent();
            this.cartItems = cartItems;
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            dgvCart.DataSource = cartItems;
        }
    }
}
