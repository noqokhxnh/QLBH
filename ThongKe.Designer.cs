namespace QLBH
{
    partial class frmThongKe
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
            dgvThongKe = new DataGridView();
            lblTongdoanhThu = new Label();
            lblSoLuongban = new Label();
            btnXuat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // dgvThongKe
            // 
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(34, 17);
            dgvThongKe.Margin = new Padding(4, 4, 4, 4);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.RowTemplate.Height = 29;
            dgvThongKe.Size = new Size(1108, 449);
            dgvThongKe.TabIndex = 0;
            // 
            // lblTongdoanhThu
            // 
            lblTongdoanhThu.AutoSize = true;
            lblTongdoanhThu.Location = new Point(34, 500);
            lblTongdoanhThu.Margin = new Padding(4, 0, 4, 0);
            lblTongdoanhThu.Name = "lblTongdoanhThu";
            lblTongdoanhThu.Size = new Size(170, 28);
            lblTongdoanhThu.TabIndex = 1;
            lblTongdoanhThu.Text = "Tổng Doanh Thu";
            // 
            // lblSoLuongban
            // 
            lblSoLuongban.AutoSize = true;
            lblSoLuongban.Location = new Point(34, 561);
            lblSoLuongban.Margin = new Padding(4, 0, 4, 0);
            lblSoLuongban.Name = "lblSoLuongban";
            lblSoLuongban.Size = new Size(143, 28);
            lblSoLuongban.TabIndex = 2;
            lblSoLuongban.Text = "Số Lượng Bán";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(927, 512);
            btnXuat.Margin = new Padding(4, 4, 4, 4);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(164, 41);
            btnXuat.TabIndex = 3;
            btnXuat.Text = "Xuất Báo Cáo";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // frmThongKe
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 630);
            Controls.Add(btnXuat);
            Controls.Add(lblSoLuongban);
            Controls.Add(lblTongdoanhThu);
            Controls.Add(dgvThongKe);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThongKe";
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvThongKe;
        private Label lblTongdoanhThu;
        private Label lblSoLuongban;
        private Button btnXuat;
    }
}