<<<<<<< HEAD
﻿namespace QLBH
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
            btnThem.Location = new Point(659, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 20);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Giảm Giá";
            // 
            // dgvMaGiamGia
            // 
            dgvMaGiamGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaGiamGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMaGiamGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaGiamGia.Location = new Point(12, 134);
            dgvMaGiamGia.Name = "dgvMaGiamGia";
            dgvMaGiamGia.RowHeadersWidth = 51;
            dgvMaGiamGia.RowTemplate.Height = 29;
            dgvMaGiamGia.Size = new Size(751, 313);
            dgvMaGiamGia.TabIndex = 2;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(176, 20);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(659, 80);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtGiam
            // 
            txtGiam.Location = new Point(176, 70);
            txtGiam.Name = "txtGiam";
            txtGiam.Size = new Size(125, 27);
            txtGiam.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 70);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 5;
            label2.Text = "Phần trăm ưu đãi";
            // 
            // GiamGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 459);
            Controls.Add(txtGiam);
            Controls.Add(label2);
            Controls.Add(btnXoa);
            Controls.Add(txtCode);
            Controls.Add(dgvMaGiamGia);
            Controls.Add(label1);
            Controls.Add(btnThem);
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
=======
﻿namespace QLBH
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
            btnThem.Location = new Point(659, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 20);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Giảm Giá";
            // 
            // dgvMaGiamGia
            // 
            dgvMaGiamGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaGiamGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMaGiamGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaGiamGia.Location = new Point(12, 134);
            dgvMaGiamGia.Name = "dgvMaGiamGia";
            dgvMaGiamGia.RowHeadersWidth = 51;
            dgvMaGiamGia.RowTemplate.Height = 29;
            dgvMaGiamGia.Size = new Size(751, 313);
            dgvMaGiamGia.TabIndex = 2;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(176, 20);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(659, 80);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtGiam
            // 
            txtGiam.Location = new Point(176, 70);
            txtGiam.Name = "txtGiam";
            txtGiam.Size = new Size(125, 27);
            txtGiam.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 70);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 5;
            label2.Text = "Phần trăm ưu đãi";
            // 
            // GiamGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 459);
            Controls.Add(txtGiam);
            Controls.Add(label2);
            Controls.Add(btnXoa);
            Controls.Add(txtCode);
            Controls.Add(dgvMaGiamGia);
            Controls.Add(label1);
            Controls.Add(btnThem);
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
>>>>>>> 822f9efd09c46cf0066c65cd36de169c35c51c7e
}