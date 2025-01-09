namespace QuanLyBanHangOnline
{
    partial class frmProduct
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
            dgvHienThi = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            label5 = new Label();
            txtFind = new TextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thôngTinSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            thốngKêSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            xemĐánhGiáToolStripMenuItem = new ToolStripMenuItem();
            thêmMãGiảmGiáToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHienThi
            // 
            dgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHienThi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThi.Location = new Point(12, 176);
            dgvHienThi.Margin = new Padding(3, 4, 3, 4);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersWidth = 51;
            dgvHienThi.RowTemplate.Height = 24;
            dgvHienThi.Size = new Size(783, 373);
            dgvHienThi.TabIndex = 0;
            dgvHienThi.CellClick += dgvHienThi_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(801, 176);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(801, 237);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(801, 293);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 29);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Xoá";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 71);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 71);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 5;
            label2.Text = "Giá Sản Phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 131);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Số Lượng";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(149, 68);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(142, 27);
            txtProductName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(487, 71);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(88, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(356, 131);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(88, 27);
            txtStock.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(647, 76);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 12;
            label5.Text = "Tìm kiếm theo tên";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(784, 76);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(125, 27);
            txtFind.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(935, 76);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, thôngTinSảnPhẩmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1117, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(232, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            đăngXuấtToolStripMenuItem.Size = new Size(232, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thôngTinSảnPhẩmToolStripMenuItem
            // 
            thôngTinSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêSảnPhẩmToolStripMenuItem, xemĐánhGiáToolStripMenuItem, thêmMãGiảmGiáToolStripMenuItem });
            thôngTinSảnPhẩmToolStripMenuItem.Name = "thôngTinSảnPhẩmToolStripMenuItem";
            thôngTinSảnPhẩmToolStripMenuItem.Size = new Size(154, 24);
            thôngTinSảnPhẩmToolStripMenuItem.Text = "Thông tin sản phẩm";
            // 
            // thốngKêSảnPhẩmToolStripMenuItem
            // 
            thốngKêSảnPhẩmToolStripMenuItem.Name = "thốngKêSảnPhẩmToolStripMenuItem";
            thốngKêSảnPhẩmToolStripMenuItem.Size = new Size(221, 26);
            thốngKêSảnPhẩmToolStripMenuItem.Text = "Thống kê sản phẩm";
            thốngKêSảnPhẩmToolStripMenuItem.Click += thốngKêSảnPhẩmToolStripMenuItem_Click;
            // 
            // xemĐánhGiáToolStripMenuItem
            // 
            xemĐánhGiáToolStripMenuItem.Name = "xemĐánhGiáToolStripMenuItem";
            xemĐánhGiáToolStripMenuItem.Size = new Size(221, 26);
            xemĐánhGiáToolStripMenuItem.Text = "Xem đánh giá";
            xemĐánhGiáToolStripMenuItem.Click += xemĐánhGiáToolStripMenuItem_Click;
            // 
            // thêmMãGiảmGiáToolStripMenuItem
            // 
            thêmMãGiảmGiáToolStripMenuItem.Name = "thêmMãGiảmGiáToolStripMenuItem";
            thêmMãGiảmGiáToolStripMenuItem.Size = new Size(221, 26);
            thêmMãGiảmGiáToolStripMenuItem.Text = "Thêm mã giảm giá";
            thêmMãGiảmGiáToolStripMenuItem.Click += thêmMãGiảmGiáToolStripMenuItem_Click;
            // 
            // frmProduct
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 562);
            Controls.Add(button1);
            Controls.Add(txtFind);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvHienThi);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSanPham";
            Load += frmAdminform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private Label label5;
        private TextBox txtFind;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem thôngTinSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem thốngKêSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem xemĐánhGiáToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thêmMãGiảmGiáToolStripMenuItem;
    }
}