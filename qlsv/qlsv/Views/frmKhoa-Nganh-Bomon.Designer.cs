namespace qlsv.views
{
    partial class frmKhoa_Nganh_Bomon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa_Nganh_Bomon));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDSGV = new System.Windows.Forms.Button();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblNganh = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.lblBomon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(379, 262);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDSGV
            // 
            this.btnDSGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDSGV.BackgroundImage")));
            this.btnDSGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDSGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSGV.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDSGV.Location = new System.Drawing.Point(161, 257);
            this.btnDSGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDSGV.Name = "btnDSGV";
            this.btnDSGV.Size = new System.Drawing.Size(198, 37);
            this.btnDSGV.TabIndex = 10;
            this.btnDSGV.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDSGV.UseVisualStyleBackColor = true;
            this.btnDSGV.Click += new System.EventHandler(this.btnDSGV_Click);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(40, 127);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(45, 17);
            this.lblKhoa.TabIndex = 9;
            this.lblKhoa.Text = "Khoa:";
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Location = new System.Drawing.Point(40, 190);
            this.lblNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(54, 17);
            this.lblNganh.TabIndex = 8;
            this.lblNganh.Text = "Ngành:";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(121, 127);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(135, 24);
            this.cbKhoa.TabIndex = 7;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // cbNganh
            // 
            this.cbNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(121, 182);
            this.cbNganh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(168, 24);
            this.cbNganh.TabIndex = 6;
            // 
            // lblBomon
            // 
            this.lblBomon.AutoSize = true;
            this.lblBomon.Location = new System.Drawing.Point(631, 111);
            this.lblBomon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBomon.Name = "lblBomon";
            this.lblBomon.Size = new System.Drawing.Size(0, 17);
            this.lblBomon.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(125, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "GIẢNG VIÊN";
            // 
            // frmKhoa_Nganh_Bomon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(509, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBomon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDSGV);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblNganh);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.cbNganh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKhoa_Nganh_Bomon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Giảng viên";
            this.Load += new System.EventHandler(this.frmKhoa_Nganh_Bomon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDSGV;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.Label lblBomon;
        private System.Windows.Forms.Label label1;
    }
}