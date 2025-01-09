namespace QLBH
{
    partial class DoiMatKhau
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
            btnAccept = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtOldPass = new TextBox();
            txtNewPass = new TextBox();
            txtComfirmPass = new TextBox();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(284, 377);
            btnAccept.Margin = new Padding(4);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(141, 41);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Xác nhận";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 2;
            label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 171);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 260);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(230, 28);
            label3.TabIndex = 4;
            label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(381, 85);
            txtOldPass.Margin = new Padding(4);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(186, 34);
            txtOldPass.TabIndex = 1;
            txtOldPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(381, 171);
            txtNewPass.Margin = new Padding(4);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(186, 34);
            txtNewPass.TabIndex = 2;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtComfirmPass
            // 
            txtComfirmPass.Location = new Point(381, 260);
            txtComfirmPass.Margin = new Padding(4);
            txtComfirmPass.Name = "txtComfirmPass";
            txtComfirmPass.Size = new Size(186, 34);
            txtComfirmPass.TabIndex = 3;
            txtComfirmPass.UseSystemPasswordChar = true;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 504);
            Controls.Add(txtComfirmPass);
            Controls.Add(txtNewPass);
            Controls.Add(txtOldPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAccept);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccept;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOldPass;
        private TextBox txtNewPass;
        private TextBox txtComfirmPass;
    }
}