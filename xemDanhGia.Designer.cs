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
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhGia).BeginInit();
            SuspendLayout();
            // 
            // dgvDanhGia
            // 
            dgvDanhGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDanhGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhGia.Location = new Point(12, 12);
            dgvDanhGia.Name = "dgvDanhGia";
            dgvDanhGia.RowHeadersWidth = 51;
            dgvDanhGia.RowTemplate.Height = 29;
            dgvDanhGia.Size = new Size(595, 188);
            dgvDanhGia.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(108, 261);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(394, 261);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Huỷ";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // xemDanhGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 349);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(dgvDanhGia);
            Name = "xemDanhGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "xemDanhGia";
            ((System.ComponentModel.ISupportInitialize)dgvDanhGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDanhGia;
        private Button btnXoa;
        private Button btnSua;
    }
}