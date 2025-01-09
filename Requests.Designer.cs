namespace QLBH
{
    partial class Requests
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

        private void InitializeComponent()
        {
            pnlDetails = new Panel();
            dgvRequests = new DataGridView();
            lblUserId = new Label();
            txtUserId = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnApprove = new Button();
            btnReject = new Button();
            pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(dgvRequests);
            pnlDetails.Controls.Add(lblUserId);
            pnlDetails.Controls.Add(txtUserId);
            pnlDetails.Controls.Add(lblUsername);
            pnlDetails.Controls.Add(txtUsername);
            pnlDetails.Controls.Add(btnApprove);
            pnlDetails.Controls.Add(btnReject);
            pnlDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pnlDetails.Location = new Point(0, 0);
            pnlDetails.Margin = new Padding(4, 5, 4, 5);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Padding = new Padding(13, 15, 13, 15);
            pnlDetails.Size = new Size(791, 552);
            pnlDetails.TabIndex = 1;
            // 
            // dgvRequests
            // 
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRequests.ColumnHeadersHeight = 29;
            dgvRequests.Location = new Point(0, 230);
            dgvRequests.Margin = new Padding(4, 5, 4, 5);
            dgvRequests.MultiSelect = false;
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(791, 322);
            dgvRequests.TabIndex = 0;
            dgvRequests.CellContentClick += dgvRequests_CellClick;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(27, 31);
            lblUserId.Margin = new Padding(4, 0, 4, 0);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(161, 28);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "ID Người Dùng:";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(196, 33);
            txtUserId.Margin = new Padding(4, 5, 4, 5);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(265, 34);
            txtUserId.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(27, 77);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(163, 28);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Tên Đăng Nhập:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(196, 71);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(265, 34);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // btnApprove
            // 
            btnApprove.Location = new Point(160, 185);
            btnApprove.Margin = new Padding(4, 5, 4, 5);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(133, 35);
            btnApprove.TabIndex = 6;
            btnApprove.Text = "Chấp Nhận";
            btnApprove.Click += btnApprove_Click_1;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(307, 185);
            btnReject.Margin = new Padding(4, 5, 4, 5);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(133, 35);
            btnReject.TabIndex = 7;
            btnReject.Text = "Từ Chối";
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 546);
            Controls.Add(pnlDetails);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Requests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Yêu Cầu Nâng Cấp Seller";
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private DataGridView dgvRequests;
    }
}