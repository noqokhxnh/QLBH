namespace QLBH
{
    partial class RoleRequests
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
            btnReject = new Button();
            btnApprove = new Button();
            dgvRoleRequests = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRoleRequests).BeginInit();
            SuspendLayout();
            // 
            // btnReject
            // 
            btnReject.Location = new Point(397, 338);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(94, 29);
            btnReject.TabIndex = 7;
            btnReject.Text = "Từ chối";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // btnApprove
            // 
            btnApprove.Location = new Point(21, 338);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(94, 29);
            btnApprove.TabIndex = 6;
            btnApprove.Text = "Đồng Ý";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // dgvRoleRequests
            // 
            dgvRoleRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoleRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRoleRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoleRequests.Location = new Point(21, 12);
            dgvRoleRequests.Name = "dgvRoleRequests";
            dgvRoleRequests.RowHeadersWidth = 51;
            dgvRoleRequests.RowTemplate.Height = 29;
            dgvRoleRequests.Size = new Size(470, 292);
            dgvRoleRequests.TabIndex = 5;
            // 
            // RoleRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(dgvRoleRequests);
            Name = "RoleRequests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoleRequests";
            ((System.ComponentModel.ISupportInitialize)dgvRoleRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReject;
        private Button btnApprove;
        private DataGridView dgvRoleRequests;
    }
}