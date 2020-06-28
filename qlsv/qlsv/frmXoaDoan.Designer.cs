namespace qlsv
{
    partial class frmXoaDoan
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.lblNganh = new System.Windows.Forms.Label();
            this.cbTheloai = new System.Windows.Forms.ComboBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.lbltheloai = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtMDA = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblMda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(400, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 64;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbNganh
            // 
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(400, 80);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(121, 21);
            this.cbNganh.TabIndex = 61;
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Location = new System.Drawing.Point(349, 83);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(39, 13);
            this.lblNganh.TabIndex = 60;
            this.lblNganh.Text = "Ngành";
            // 
            // cbTheloai
            // 
            this.cbTheloai.FormattingEnabled = true;
            this.cbTheloai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbTheloai.Location = new System.Drawing.Point(119, 109);
            this.cbTheloai.Name = "cbTheloai";
            this.cbTheloai.Size = new System.Drawing.Size(121, 21);
            this.cbTheloai.TabIndex = 59;
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(400, 30);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbKhoa.TabIndex = 58;
            // 
            // lbltheloai
            // 
            this.lbltheloai.AutoSize = true;
            this.lbltheloai.Location = new System.Drawing.Point(28, 109);
            this.lbltheloai.Name = "lbltheloai";
            this.lbltheloai.Size = new System.Drawing.Size(45, 13);
            this.lbltheloai.TabIndex = 56;
            this.lbltheloai.Text = "Thể loại";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(356, 30);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 55;
            this.lblKhoa.Text = "Khoa";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(110, 67);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 53;
            // 
            // txtMDA
            // 
            this.txtMDA.Location = new System.Drawing.Point(110, 27);
            this.txtMDA.Name = "txtMDA";
            this.txtMDA.Size = new System.Drawing.Size(100, 20);
            this.txtMDA.TabIndex = 52;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(28, 67);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(57, 13);
            this.lblFullname.TabIndex = 51;
            this.lblFullname.Text = "Tên đồ án";
            // 
            // lblMda
            // 
            this.lblMda.AutoSize = true;
            this.lblMda.Location = new System.Drawing.Point(28, 30);
            this.lblMda.Name = "lblMda";
            this.lblMda.Size = new System.Drawing.Size(40, 13);
            this.lblMda.TabIndex = 50;
            this.lblMda.Text = "Mã ĐA";
            // 
            // frmXoaDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbNganh);
            this.Controls.Add(this.lblNganh);
            this.Controls.Add(this.cbTheloai);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.lbltheloai);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtMDA);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblMda);
            this.Name = "frmXoaDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa thông tin đồ án";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.ComboBox cbTheloai;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label lbltheloai;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtMDA;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblMda;
    }
}