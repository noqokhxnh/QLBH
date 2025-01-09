namespace QLBH
{
    partial class GiamGia
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
            btnThem = new Button();
            label1 = new Label();
            dgvMaGiamGia = new DataGridView();
            txtCode = new TextBox();
            btnXoa = new Button();
            txtGiam = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMaGiamGia).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(988, 22);
            btnThem.Margin = new Padding(4, 4, 4, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(141, 41);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 1;
            label1.Text = "Mã Giảm Giá";
            // 
            // dgvMaGiamGia
            // 
            dgvMaGiamGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaGiamGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMaGiamGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaGiamGia.Location = new Point(18, 188);
            dgvMaGiamGia.Margin = new Padding(4, 4, 4, 4);
            dgvMaGiamGia.Name = "dgvMaGiamGia";
            dgvMaGiamGia.RowHeadersWidth = 51;
            dgvMaGiamGia.RowTemplate.Height = 29;
            dgvMaGiamGia.Size = new Size(1126, 438);
            dgvMaGiamGia.TabIndex = 2;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(264, 28);
            txtCode.Margin = new Padding(4, 4, 4, 4);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(186, 34);
            txtCode.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(988, 112);
            btnXoa.Margin = new Padding(4, 4, 4, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(141, 41);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtGiam
            // 
            txtGiam.Location = new Point(264, 98);
            txtGiam.Margin = new Padding(4, 4, 4, 4);
            txtGiam.Name = "txtGiam";
            txtGiam.Size = new Size(186, 34);
            txtGiam.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 5;
            label2.Text = "Phần trăm ưu đãi";
            // 
            // GiamGia
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 643);
            Controls.Add(txtGiam);
            Controls.Add(label2);
            Controls.Add(btnXoa);
            Controls.Add(txtCode);
            Controls.Add(dgvMaGiamGia);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "GiamGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GiamGia";
            Load += GiamGia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaGiamGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Label label1;
        private DataGridView dgvMaGiamGia;
        private TextBox txtCode;
        private Button btnXoa;
        private TextBox txtGiam;
        private Label label2;
    }
}