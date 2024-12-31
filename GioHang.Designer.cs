namespace QLBH
{
    partial class GioHang
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
            dgvCart = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnThanhToan = new Button();
            txtGiamGia = new TextBox();
            txtTien = new TextBox();
            btnApDung = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(12, 12);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.Height = 29;
            dgvCart.Size = new Size(776, 292);
            dgvCart.TabIndex = 0;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 314);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Tổng số tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 317);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập mã giảm giá";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(484, 408);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(566, 314);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(125, 27);
            txtGiamGia.TabIndex = 2;
            // 
            // txtTien
            // 
            txtTien.Location = new Point(123, 310);
            txtTien.Name = "txtTien";
            txtTien.ReadOnly = true;
            txtTien.Size = new Size(125, 27);
            txtTien.TabIndex = 1;
            // 
            // btnApDung
            // 
            btnApDung.Location = new Point(711, 314);
            btnApDung.Name = "btnApDung";
            btnApDung.Size = new Size(94, 29);
            btnApDung.TabIndex = 3;
            btnApDung.Text = "Áp dụng";
            btnApDung.UseVisualStyleBackColor = true;
            btnApDung.Click += btnApDung_Click;
            // 
            // GioHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 450);
            Controls.Add(btnApDung);
            Controls.Add(txtTien);
            Controls.Add(txtGiamGia);
            Controls.Add(btnThanhToan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCart);
            Name = "GioHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GioHang";
            Load += GioHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCart;
        private Label label1;
        private Label label2;
        private Button btnThanhToan;
        private TextBox txtGiamGia;
        private TextBox txtTien;
        private Button btnApDung;
    }
}