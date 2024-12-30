namespace QLBH
{
    partial class frmDanhGia
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
            btnGuidanhgia = new Button();
            lblProductName = new Label();
            lblRating = new Label();
            lblComment = new Label();
            cbxRating = new ComboBox();
            txtComment = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnGuidanhgia
            // 
            btnGuidanhgia.Location = new Point(36, 200);
            btnGuidanhgia.Name = "btnGuidanhgia";
            btnGuidanhgia.Size = new Size(153, 29);
            btnGuidanhgia.TabIndex = 0;
            btnGuidanhgia.Text = "Gửi Đánh Giá";
            btnGuidanhgia.UseVisualStyleBackColor = true;
            btnGuidanhgia.Click += btnGuidanhgia_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(36, 36);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(101, 20);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Tên Sản Phẩm";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(36, 87);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(52, 20);
            lblRating.TabIndex = 2;
            lblRating.Text = "Rating";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Location = new Point(36, 143);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(74, 20);
            lblComment.TabIndex = 3;
            lblComment.Text = "Comment";
            // 
            // cbxRating
            // 
            cbxRating.FormattingEnabled = true;
            cbxRating.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbxRating.Location = new Point(145, 87);
            cbxRating.Name = "cbxRating";
            cbxRating.Size = new Size(151, 28);
            cbxRating.TabIndex = 4;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(145, 140);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(151, 27);
            txtComment.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(271, 200);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmDanhGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 309);
            Controls.Add(btnCancel);
            Controls.Add(txtComment);
            Controls.Add(cbxRating);
            Controls.Add(lblComment);
            Controls.Add(lblRating);
            Controls.Add(lblProductName);
            Controls.Add(btnGuidanhgia);
            Name = "frmDanhGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDanhGia";
            Load += frmDanhGia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuidanhgia;
        private Label lblProductName;
        private Label lblRating;
        private Label lblComment;
        private ComboBox cbxRating;
        private TextBox txtComment;
        private Button btnCancel;
    }
}