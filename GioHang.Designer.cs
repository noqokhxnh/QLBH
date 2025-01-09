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
            dgvCart.Location = new Point(18, 17);
            dgvCart.Margin = new Padding(4, 4, 4, 4);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.Height = 29;
            dgvCart.Size = new Size(1164, 409);
            dgvCart.TabIndex = 0;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 440);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 1;
            label1.Text = "Tổng số tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(640, 444);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 2;
            label2.Text = "Nhập mã giảm giá";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(726, 571);
            btnThanhToan.Margin = new Padding(4, 4, 4, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(141, 41);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(849, 440);
            txtGiamGia.Margin = new Padding(4, 4, 4, 4);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(186, 34);
            txtGiamGia.TabIndex = 2;
            // 
            // txtTien
            // 
            txtTien.Location = new Point(184, 434);
            txtTien.Margin = new Padding(4, 4, 4, 4);
            txtTien.Name = "txtTien";
            txtTien.ReadOnly = true;
            txtTien.Size = new Size(186, 34);
            txtTien.TabIndex = 1;
            // 
            // btnApDung
            // 
            btnApDung.Location = new Point(1066, 440);
            btnApDung.Margin = new Padding(4, 4, 4, 4);
            btnApDung.Name = "btnApDung";
            btnApDung.Size = new Size(141, 41);
            btnApDung.TabIndex = 3;
            btnApDung.Text = "Áp dụng";
            btnApDung.UseVisualStyleBackColor = true;
            btnApDung.Click += btnApDung_Click;
            // 
            // GioHang
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 630);
            Controls.Add(btnApDung);
            Controls.Add(txtTien);
            Controls.Add(txtGiamGia);
            Controls.Add(btnThanhToan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCart);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
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