namespace QuanLyBanHangOnline
{
    partial class frmAdminform
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
            dgvHienThi = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            SuspendLayout();
            // 
            // dgvHienThi
            // 
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThi.Location = new Point(12, 176);
            dgvHienThi.Margin = new Padding(3, 4, 3, 4);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersWidth = 51;
            dgvHienThi.RowTemplate.Height = 24;
            dgvHienThi.Size = new Size(528, 373);
            dgvHienThi.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(599, 208);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(599, 269);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(599, 325);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 29);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Xoá";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 73);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 16);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 5;
            label2.Text = "Giá Sản Phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 73);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Số Lượng";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(166, 70);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 27);
            txtProductName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(500, 16);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 27);
            txtPrice.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(500, 73);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 27);
            txtStock.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(166, 6);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 9);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 10;
            label4.Text = "Id";
            // 
            // frmAdminform
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 562);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvHienThi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdminform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmAdminform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private TextBox txtId;
        private Label label4;
    }
}