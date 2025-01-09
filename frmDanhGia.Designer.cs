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
            btnGuidanhgia.Location = new Point(54, 280);
            btnGuidanhgia.Margin = new Padding(4);
            btnGuidanhgia.Name = "btnGuidanhgia";
            btnGuidanhgia.Size = new Size(230, 41);
            btnGuidanhgia.TabIndex = 0;
            btnGuidanhgia.Text = "Gửi Đánh Giá";
            btnGuidanhgia.UseVisualStyleBackColor = true;
            btnGuidanhgia.Click += btnGuidanhgia_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(54, 50);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(144, 28);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Tên Sản Phẩm";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(54, 122);
            lblRating.Margin = new Padding(4, 0, 4, 0);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(74, 28);
            lblRating.TabIndex = 2;
            lblRating.Text = "Rating";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Location = new Point(54, 200);
            lblComment.Margin = new Padding(4, 0, 4, 0);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(103, 28);
            lblComment.TabIndex = 3;
            lblComment.Text = "Comment";
            // 
            // cbxRating
            // 
            cbxRating.FormattingEnabled = true;
            cbxRating.Items.AddRange(new object[] { "1*", "2*", "3*", "4*", "5*" });
            cbxRating.Location = new Point(218, 122);
            cbxRating.Margin = new Padding(4);
            cbxRating.Name = "cbxRating";
            cbxRating.Size = new Size(224, 36);
            cbxRating.TabIndex = 4;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(218, 196);
            txtComment.Margin = new Padding(4);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(224, 34);
            txtComment.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(406, 280);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 41);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmDanhGia
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 433);
            Controls.Add(btnCancel);
            Controls.Add(txtComment);
            Controls.Add(cbxRating);
            Controls.Add(lblComment);
            Controls.Add(lblRating);
            Controls.Add(lblProductName);
            Controls.Add(btnGuidanhgia);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmDanhGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đánh Giá Sản Phẩm";
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