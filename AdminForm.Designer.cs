namespace QLBH
{
    partial class AdminForm
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            phânQuyềnToolStripMenuItem = new ToolStripMenuItem();
            yêuCầuPhânQuyềnToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            thôngTinNgườiDùngToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, phânQuyềnToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            phânQuyềnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yêuCầuPhânQuyềnToolStripMenuItem });
            phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            phânQuyềnToolStripMenuItem.Size = new Size(101, 24);
            phânQuyềnToolStripMenuItem.Text = "Phân Quyền";
            // 
            // yêuCầuPhânQuyềnToolStripMenuItem
            // 
            yêuCầuPhânQuyềnToolStripMenuItem.Name = "yêuCầuPhânQuyềnToolStripMenuItem";
            yêuCầuPhânQuyềnToolStripMenuItem.Size = new Size(257, 26);
            yêuCầuPhânQuyềnToolStripMenuItem.Text = "Xem yêu cầu phân quyền";
            yêuCầuPhânQuyềnToolStripMenuItem.Click += yêuCầuPhânQuyềnToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinNgườiDùngToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // thôngTinNgườiDùngToolStripMenuItem
            // 
            thôngTinNgườiDùngToolStripMenuItem.Name = "thôngTinNgườiDùngToolStripMenuItem";
            thôngTinNgườiDùngToolStripMenuItem.Size = new Size(236, 26);
            thôngTinNgườiDùngToolStripMenuItem.Text = "Thông tin người dùng";
            thôngTinNgườiDùngToolStripMenuItem.Click += thôngTinNgườiDùngToolStripMenuItem_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private ToolStripMenuItem yêuCầuPhânQuyềnToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem thôngTinNgườiDùngToolStripMenuItem;
    }
}