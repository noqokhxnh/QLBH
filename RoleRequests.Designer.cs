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
            btnReject.Location = new Point(596, 473);
            btnReject.Margin = new Padding(4, 4, 4, 4);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(141, 41);
            btnReject.TabIndex = 7;
            btnReject.Text = "Từ chối";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // btnApprove
            // 
            btnApprove.Location = new Point(32, 473);
            btnApprove.Margin = new Padding(4, 4, 4, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(141, 41);
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
            dgvRoleRequests.Location = new Point(32, 17);
            dgvRoleRequests.Margin = new Padding(4, 4, 4, 4);
            dgvRoleRequests.Name = "dgvRoleRequests";
            dgvRoleRequests.RowHeadersWidth = 51;
            dgvRoleRequests.RowTemplate.Height = 29;
            dgvRoleRequests.Size = new Size(705, 409);
            dgvRoleRequests.TabIndex = 5;
            // 
            // RoleRequests
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 630);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(dgvRoleRequests);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
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