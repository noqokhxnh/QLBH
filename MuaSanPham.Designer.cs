namespace QuanLyBanHangOnline
{
    partial class frmUserform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserform));
            dgvHIenThi = new DataGridView();
            btnThem = new Button();
            cbxSanPham = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtsoluong = new TextBox();
            btnDanhGia = new Button();
            menuStrip1 = new MenuStrip();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            GioHang = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            phânQuyềnToolStripMenuItem = new ToolStripMenuItem();
            yêuCầuPhânQuyềnBánHàngToolStripMenuItem = new ToolStripMenuItem();
            lable4 = new Label();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHIenThi).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHIenThi
            // 
            dgvHIenThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHIenThi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHIenThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHIenThi.Location = new Point(13, 275);
            dgvHIenThi.Margin = new Padding(4, 6, 4, 6);
            dgvHIenThi.Name = "dgvHIenThi";
            dgvHIenThi.RowHeadersWidth = 51;
            dgvHIenThi.RowTemplate.Height = 24;
            dgvHIenThi.Size = new Size(1083, 516);
            dgvHIenThi.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Image = QLBH.Properties.Resources.bx_cart_add;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(1114, 275);
            btnThem.Margin = new Padding(4, 6, 4, 6);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(262, 41);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm vào giỏ hàng";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cbxSanPham
            // 
            cbxSanPham.FormattingEnabled = true;
            cbxSanPham.Location = new Point(277, 57);
            cbxSanPham.Margin = new Padding(4, 6, 4, 6);
            cbxSanPham.Name = "cbxSanPham";
            cbxSanPham.Size = new Size(338, 36);
            cbxSanPham.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 3;
            label1.Text = "Chọn sản phẩm";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 4;
            label2.Text = "Số Lượng";
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(277, 118);
            txtsoluong.Margin = new Padding(4, 6, 4, 6);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(148, 34);
            txtsoluong.TabIndex = 5;
            // 
            // btnDanhGia
            // 
            btnDanhGia.Image = QLBH.Properties.Resources.bxs_comment_detail;
            btnDanhGia.ImageAlign = ContentAlignment.MiddleLeft;
            btnDanhGia.Location = new Point(1114, 344);
            btnDanhGia.Margin = new Padding(4);
            btnDanhGia.Name = "btnDanhGia";
            btnDanhGia.Size = new Size(262, 41);
            btnDanhGia.TabIndex = 7;
            btnDanhGia.Text = "Đánh giá sản phẩm";
            btnDanhGia.UseVisualStyleBackColor = true;
            btnDanhGia.Click += btnDanhGia_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, quảnLýSảnPhẩmToolStripMenuItem, phânQuyềnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1389, 38);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(118, 32);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Image = QLBH.Properties.Resources.user_regular;
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            thôngTinCáNhânToolStripMenuItem.Size = new Size(345, 32);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Image = QLBH.Properties.Resources.key_solid;
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(345, 32);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = QLBH.Properties.Resources.arrow_right_from_bracket_solid;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            đăngXuấtToolStripMenuItem.Size = new Size(345, 32);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GioHang, toolStripMenuItem1 });
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(201, 32);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            // 
            // GioHang
            // 
            GioHang.AccessibleName = "GioHang";
            GioHang.Image = QLBH.Properties.Resources.cart_shopping_solid;
            GioHang.Name = "GioHang";
            GioHang.Size = new Size(280, 32);
            GioHang.Text = "Giỏ Hàng";
            GioHang.Click += GioHang_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = QLBH.Properties.Resources.comment_regular;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(280, 32);
            toolStripMenuItem1.Text = "Đánh giá sản phẩm";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            phânQuyềnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yêuCầuPhânQuyềnBánHàngToolStripMenuItem });
            phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            phânQuyềnToolStripMenuItem.Size = new Size(140, 32);
            phânQuyềnToolStripMenuItem.Text = "Phân Quyền";
            // 
            // yêuCầuPhânQuyềnBánHàngToolStripMenuItem
            // 
            yêuCầuPhânQuyềnBánHàngToolStripMenuItem.Image = QLBH.Properties.Resources.person_solid;
            yêuCầuPhânQuyềnBánHàngToolStripMenuItem.Name = "yêuCầuPhânQuyềnBánHàngToolStripMenuItem";
            yêuCầuPhânQuyềnBánHàngToolStripMenuItem.Size = new Size(381, 32);
            yêuCầuPhânQuyềnBánHàngToolStripMenuItem.Text = "Yêu cầu phân quyền bán hàng";
            yêuCầuPhânQuyềnBánHàngToolStripMenuItem.Click += yêuCầuPhânQuyềnBánHàngToolStripMenuItem_Click;
            // 
            // lable4
            // 
            lable4.AutoSize = true;
            lable4.Location = new Point(13, 209);
            lable4.Margin = new Padding(4, 0, 4, 0);
            lable4.Name = "lable4";
            lable4.Size = new Size(201, 28);
            lable4.TabIndex = 10;
            lable4.Text = "Tim Kiếm Sản Phẩm";
            lable4.Click += lable4_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(277, 209);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(352, 34);
            txtTimKiem.TabIndex = 11;
            // 
            // btnTim
            // 
            btnTim.Image = QLBH.Properties.Resources.bx_search;
            btnTim.ImageAlign = ContentAlignment.MiddleLeft;
            btnTim.Location = new Point(722, 209);
            btnTim.Margin = new Padding(4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(141, 41);
            btnTim.TabIndex = 12;
            btnTim.Text = "Tìm Kiếm";
            btnTim.TextAlign = ContentAlignment.MiddleRight;
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // frmUserform
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 787);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(lable4);
            Controls.Add(btnDanhGia);
            Controls.Add(txtsoluong);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxSanPham);
            Controls.Add(btnThem);
            Controls.Add(dgvHIenThi);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 6, 4, 6);
            Name = "frmUserform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mua hàng";
            WindowState = FormWindowState.Maximized;
            Load += frmUserform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHIenThi).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHIenThi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbxSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoluong;
        private Button btnDanhGia;
        private MenuStrip menuStrip1;   
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem GioHang;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private ToolStripMenuItem yêuCầuPhânQuyềnBánHàngToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private Label lable4;
        private TextBox txtTimKiem;
        private Button btnTim;
    }
}