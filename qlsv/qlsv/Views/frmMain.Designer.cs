namespace qlsv.views
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QlUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inforToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InforStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InforteacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InforProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTeacherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.inforToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.StudentProjectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(573, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginToolStripMenuItem,
            this.QlUserToolStripMenuItem,
            this.LogoutToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.SystemToolStripMenuItem.Text = "Hệ Thống";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.LoginToolStripMenuItem.Text = "Đăng nhập";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // QlUserToolStripMenuItem
            // 
            this.QlUserToolStripMenuItem.Name = "QlUserToolStripMenuItem";
            this.QlUserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.QlUserToolStripMenuItem.Text = "Quản lý người dùng";
            this.QlUserToolStripMenuItem.Click += new System.EventHandler(this.QlUserToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.LogoutToolStripMenuItem.Text = "Đăng xuất";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // inforToolStripMenuItem
            // 
            this.inforToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InforStudentToolStripMenuItem,
            this.InforteacherToolStripMenuItem,
            this.InforProjectToolStripMenuItem});
            this.inforToolStripMenuItem.Name = "inforToolStripMenuItem";
            this.inforToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.inforToolStripMenuItem.Text = "Thông tin";
            // 
            // InforStudentToolStripMenuItem
            // 
            this.InforStudentToolStripMenuItem.Name = "InforStudentToolStripMenuItem";
            this.InforStudentToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.InforStudentToolStripMenuItem.Text = "Sinh viên";
            this.InforStudentToolStripMenuItem.Click += new System.EventHandler(this.InforStudentToolStripMenuItem_Click);
            // 
            // InforteacherToolStripMenuItem
            // 
            this.InforteacherToolStripMenuItem.Name = "InforteacherToolStripMenuItem";
            this.InforteacherToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.InforteacherToolStripMenuItem.Text = "Giảng viên";
            this.InforteacherToolStripMenuItem.Click += new System.EventHandler(this.InforteacherToolStripMenuItem_Click);
            // 
            // InforProjectToolStripMenuItem
            // 
            this.InforProjectToolStripMenuItem.Name = "InforProjectToolStripMenuItem";
            this.InforProjectToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.InforProjectToolStripMenuItem.Text = "Đồ án";
            this.InforProjectToolStripMenuItem.Click += new System.EventHandler(this.InforProjectToolStripMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchStudentToolStripMenuItem1,
            this.SearchTeacherToolStripMenuItem1,
            this.SearchProjectToolStripMenuItem1});
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.SearchToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // SearchStudentToolStripMenuItem1
            // 
            this.SearchStudentToolStripMenuItem1.Name = "SearchStudentToolStripMenuItem1";
            this.SearchStudentToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.SearchStudentToolStripMenuItem1.Text = "Sinh viên";
            this.SearchStudentToolStripMenuItem1.Click += new System.EventHandler(this.SearchStudentToolStripMenuItem1_Click);
            // 
            // SearchTeacherToolStripMenuItem1
            // 
            this.SearchTeacherToolStripMenuItem1.Name = "SearchTeacherToolStripMenuItem1";
            this.SearchTeacherToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.SearchTeacherToolStripMenuItem1.Text = "Giảng viên";
            this.SearchTeacherToolStripMenuItem1.Click += new System.EventHandler(this.SearchTeacherToolStripMenuItem1_Click);
            // 
            // SearchProjectToolStripMenuItem1
            // 
            this.SearchProjectToolStripMenuItem1.Name = "SearchProjectToolStripMenuItem1";
            this.SearchProjectToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.SearchProjectToolStripMenuItem1.Text = "Đồ án";
            this.SearchProjectToolStripMenuItem1.Click += new System.EventHandler(this.SearchProjectToolStripMenuItem1_Click);
            // 
            // StudentProjectToolStripMenuItem
            // 
            this.StudentProjectToolStripMenuItem.Name = "StudentProjectToolStripMenuItem";
            this.StudentProjectToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.StudentProjectToolStripMenuItem.Text = "Đồ án sinh viên";
            this.StudentProjectToolStripMenuItem.Click += new System.EventHandler(this.StudentProjectToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::qlsv.Properties.Resources.Capture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 374);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quả lý đồ án sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QlUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inforToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InforStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InforteacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InforProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SearchTeacherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SearchProjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem StudentProjectToolStripMenuItem;
    }
}



