namespace QLBH
{
    partial class xemDanhGia
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
            dgvDanhGia = new DataGridView();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhGia).BeginInit();
            SuspendLayout();
            // 
            // dgvDanhGia
            // 
            dgvDanhGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDanhGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhGia.Location = new Point(18, 17);
            dgvDanhGia.Margin = new Padding(4);
            dgvDanhGia.Name = "dgvDanhGia";
            dgvDanhGia.RowHeadersWidth = 51;
            dgvDanhGia.RowTemplate.Height = 29;
            dgvDanhGia.Size = new Size(612, 364);
            dgvDanhGia.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(235, 411);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(141, 41);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // xemDanhGia
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 489);
            Controls.Add(btnXoa);
            Controls.Add(dgvDanhGia);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "xemDanhGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xem Đánh Giá";
            ((System.ComponentModel.ISupportInitialize)dgvDanhGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDanhGia;
        private Button btnXoa;
    }
}