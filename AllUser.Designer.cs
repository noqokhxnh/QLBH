namespace QLBH
{
    partial class AllUser
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
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            SuspendLayout();
            // 
            // dgvHienThi
            // 
            dgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHienThi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThi.Location = new Point(2, 2);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersWidth = 51;
            dgvHienThi.RowTemplate.Height = 29;
            dgvHienThi.Size = new Size(868, 262);
            dgvHienThi.TabIndex = 0;
            // 
            // AllUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 261);
            Controls.Add(dgvHienThi);
            Name = "AllUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllUser";
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHienThi;
    }
}