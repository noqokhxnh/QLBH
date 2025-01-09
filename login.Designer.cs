namespace QuanLyBanHangOnline
{
    partial class frmLogin
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
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnDangki = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(380, 513);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(154, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 371);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 428);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Location = new Point(521, 367);
            txtUsername.Margin = new Padding(4, 6, 4, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(345, 34);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(521, 424);
            txtPassword.Margin = new Padding(4, 6, 4, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(345, 34);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnDangki
            // 
            btnDangki.Location = new Point(667, 513);
            btnDangki.Margin = new Padding(4, 5, 4, 5);
            btnDangki.Name = "btnDangki";
            btnDangki.Size = new Size(142, 40);
            btnDangki.TabIndex = 3;
            btnDangki.Text = "Đăng kí";
            btnDangki.UseVisualStyleBackColor = true;
            btnDangki.Click += btnDangki_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(546, 23);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 62);
            label4.TabIndex = 5;
            label4.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = QLBH.Properties.Resources.user_regular2;
            pictureBox1.Location = new Point(492, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 616);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnDangki);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private Button btnDangki;
        private Label label4;
        private PictureBox pictureBox1;
    }
}

