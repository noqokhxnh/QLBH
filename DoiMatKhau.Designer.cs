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
            btnAccept.Location = new Point(189, 269);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Xác nhận";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 64);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 2;
            label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 122);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 186);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 4;
            label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(254, 61);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(125, 27);
            txtOldPass.TabIndex = 1;
            txtOldPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(254, 122);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(125, 27);
            txtNewPass.TabIndex = 2;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtComfirmPass
            // 
            txtComfirmPass.Location = new Point(254, 186);
            txtComfirmPass.Name = "txtComfirmPass";
            txtComfirmPass.Size = new Size(125, 27);
            txtComfirmPass.TabIndex = 3;
            txtComfirmPass.UseSystemPasswordChar = true;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 360);
            Controls.Add(txtComfirmPass);
            Controls.Add(txtNewPass);
            Controls.Add(txtOldPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAccept);
            Name = "DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoiMatKhau";
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