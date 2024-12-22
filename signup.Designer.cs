namespace QLBH
{
    partial class frmSignup
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
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnDangKi = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 67);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 127);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(207, 69);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(125, 27);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(207, 127);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(125, 27);
            txtpassword.TabIndex = 3;
            // 
            // btnDangKi
            // 
            btnDangKi.Location = new Point(179, 190);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(94, 29);
            btnDangKi.TabIndex = 4;
            btnDangKi.Text = "Đăng Kí";
            btnDangKi.UseVisualStyleBackColor = true;
            btnDangKi.Click += btnDangKi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 9);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 5;
            label3.Text = "Đăng Kí Tài Khoản";
            // 
            // frmSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 293);
            Controls.Add(label3);
            Controls.Add(btnDangKi);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Kí";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnDangKi;
        private Label label3;
    }
}