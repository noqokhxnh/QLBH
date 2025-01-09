namespace QLBH
{
    partial class frmsignup
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
            label2 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btndangki = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 179);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(288, 102);
            txtusername.Margin = new Padding(4);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(186, 34);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(288, 179);
            txtpassword.Margin = new Padding(4);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(186, 34);
            txtpassword.TabIndex = 3;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // btndangki
            // 
            btndangki.Location = new Point(240, 272);
            btndangki.Margin = new Padding(4);
            btndangki.Name = "btndangki";
            btndangki.Size = new Size(141, 41);
            btndangki.TabIndex = 4;
            btndangki.Text = "Đăng Kí";
            btndangki.UseVisualStyleBackColor = true;
            btndangki.Click += btndangki_Click;
            // 
            // frmsignup
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 402);
            Controls.Add(btndangki);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmsignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Kí";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btndangki;
    }
}