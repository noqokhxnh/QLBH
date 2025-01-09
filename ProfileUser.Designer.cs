namespace QLBH
{
    partial class ProfileUser
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
            btnSave = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtDiaChi = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(134, 234);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(290, 234);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Quay Lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 66);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 107);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 4;
            label2.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 5;
            label3.Text = "Địa Chỉ";
            // 
            // txtName
            // 
            txtName.Location = new Point(201, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(201, 107);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(201, 155);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(250, 27);
            txtDiaChi.TabIndex = 3;
            // 
            // ProfileUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 305);
            Controls.Add(txtDiaChi);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Name = "ProfileUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtDiaChi;
    }
}