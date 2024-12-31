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
            dgvHIenThi = new DataGridView();
            btnThem = new Button();
            cbxSanPham = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtsoluong = new TextBox();
            btnDanhGia = new Button();
            menuStrip1 = new MenuStrip();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmĐãMuaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvHIenThi).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHIenThi
            // 
            dgvHIenThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHIenThi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHIenThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHIenThi.Location = new Point(12, 225);
            dgvHIenThi.Margin = new Padding(3, 4, 3, 4);
            dgvHIenThi.Name = "dgvHIenThi";
            dgvHIenThi.RowHeadersWidth = 51;
            dgvHIenThi.RowTemplate.Height = 24;
            dgvHIenThi.Size = new Size(681, 322);
            dgvHIenThi.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(699, 225);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(175, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm vào giỏ hàng";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cbxSanPham
            // 
            cbxSanPham.FormattingEnabled = true;
            cbxSanPham.Location = new Point(188, 89);
            cbxSanPham.Margin = new Padding(3, 4, 3, 4);
            cbxSanPham.Name = "cbxSanPham";
            cbxSanPham.Size = new Size(121, 28);
            cbxSanPham.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 3;
            label1.Text = "Chọn sản phẩm";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 158);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Số Lượng";
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(188, 151);
            txtsoluong.Margin = new Padding(3, 4, 3, 4);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(100, 27);
            txtsoluong.TabIndex = 5;
            // 
            // btnDanhGia
            // 
            btnDanhGia.Location = new Point(699, 275);
            btnDanhGia.Name = "btnDanhGia";
            btnDanhGia.Size = new Size(175, 29);
            btnDanhGia.TabIndex = 7;
            btnDanhGia.Text = "Đánh giá sản phẩm";
            btnDanhGia.UseVisualStyleBackColor = true;
            btnDanhGia.Click += btnDanhGia_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, quảnLýSảnPhẩmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1214, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(88, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(228, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.A;
            đăngXuấtToolStripMenuItem.Size = new Size(228, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sảnPhẩmĐãMuaToolStripMenuItem, toolStripMenuItem1 });
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(144, 24);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            // 
            // sảnPhẩmĐãMuaToolStripMenuItem
            // 
            sảnPhẩmĐãMuaToolStripMenuItem.Name = "sảnPhẩmĐãMuaToolStripMenuItem";
            sảnPhẩmĐãMuaToolStripMenuItem.Size = new Size(224, 26);
            sảnPhẩmĐãMuaToolStripMenuItem.Text = "Sản phẩm đã mua";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(224, 26);
            toolStripMenuItem1.Text = "Đánh giá sản phẩm";
            // 
            // frmUserform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 562);
            Controls.Add(btnDanhGia);
            Controls.Add(txtsoluong);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxSanPham);
            Controls.Add(btnThem);
            Controls.Add(dgvHIenThi);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUserform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
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
        private ToolStripMenuItem sảnPhẩmĐãMuaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}