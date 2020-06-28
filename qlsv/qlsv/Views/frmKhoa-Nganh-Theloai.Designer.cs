namespace qlsv.views
{
    partial class frmKhoa_Nganh_Theloai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa_Nganh_Theloai));
            this.lblTheloai = new System.Windows.Forms.Label();
            this.cbTheloai = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDSDA = new System.Windows.Forms.Button();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblNganh = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTheloai
            // 
            this.lblTheloai.AutoSize = true;
            this.lblTheloai.Location = new System.Drawing.Point(47, 204);
            this.lblTheloai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheloai.Name = "lblTheloai";
            this.lblTheloai.Size = new System.Drawing.Size(59, 17);
            this.lblTheloai.TabIndex = 21;
            this.lblTheloai.Text = "Thể loại";
            // 
            // cbTheloai
            // 
            this.cbTheloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheloai.FormattingEnabled = true;
            this.cbTheloai.Location = new System.Drawing.Point(119, 204);
            this.cbTheloai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTheloai.Name = "cbTheloai";
            this.cbTheloai.Size = new System.Drawing.Size(168, 24);
            this.cbTheloai.TabIndex = 20;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(417, 270);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 19;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDSDA
            // 
            this.btnDSDA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDSDA.BackgroundImage")));
            this.btnDSDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDSDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSDA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDSDA.Location = new System.Drawing.Point(208, 270);
            this.btnDSDA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDSDA.Name = "btnDSDA";
            this.btnDSDA.Size = new System.Drawing.Size(171, 30);
            this.btnDSDA.TabIndex = 18;
            this.btnDSDA.UseVisualStyleBackColor = true;
            this.btnDSDA.Click += new System.EventHandler(this.btnDSDA_Click);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(47, 112);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(45, 17);
            this.lblKhoa.TabIndex = 17;
            this.lblKhoa.Text = "Khoa:";
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Location = new System.Drawing.Point(47, 156);
            this.lblNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(54, 17);
            this.lblNganh.TabIndex = 16;
            this.lblNganh.Text = "Ngành:";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(119, 105);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(168, 24);
            this.cbKhoa.TabIndex = 15;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // cbNganh
            // 
            this.cbNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(119, 156);
            this.cbNganh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(168, 24);
            this.cbNganh.TabIndex = 14;
            this.cbNganh.SelectedIndexChanged += new System.EventHandler(this.cbNganh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(189, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 44);
            this.label1.TabIndex = 22;
            this.label1.Text = "ĐỒ ÁN";
            // 
            // frmKhoa_Nganh_Theloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(533, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTheloai);
            this.Controls.Add(this.cbTheloai);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDSDA);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblNganh);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.cbNganh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKhoa_Nganh_Theloai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin đồ án";
            this.Load += new System.EventHandler(this.frmKhoa_Nganh_Theloai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTheloai;
        private System.Windows.Forms.ComboBox cbTheloai;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDSDA;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.Label label1;
    }
}