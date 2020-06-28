namespace qlsv.views
{
    partial class frmAddDa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDa));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.lblNganh = new System.Windows.Forms.Label();
            this.cbTheloai = new System.Windows.Forms.ComboBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.lbltheloai = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtFNameProject = new System.Windows.Forms.TextBox();
            this.txtMDA = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblMda = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(525, 302);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 64;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(391, 303);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 26);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbNganh
            // 
            this.cbNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(422, 86);
            this.cbNganh.Margin = new System.Windows.Forms.Padding(4);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(160, 24);
            this.cbNganh.TabIndex = 61;
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Location = new System.Drawing.Point(331, 92);
            this.lblNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(50, 17);
            this.lblNganh.TabIndex = 60;
            this.lblNganh.Text = "Ngành";
            // 
            // cbTheloai
            // 
            this.cbTheloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheloai.FormattingEnabled = true;
            this.cbTheloai.Location = new System.Drawing.Point(132, 137);
            this.cbTheloai.Margin = new System.Windows.Forms.Padding(4);
            this.cbTheloai.Name = "cbTheloai";
            this.cbTheloai.Size = new System.Drawing.Size(160, 24);
            this.cbTheloai.TabIndex = 59;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(422, 39);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(160, 24);
            this.cbKhoa.TabIndex = 58;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged_1);
            // 
            // lbltheloai
            // 
            this.lbltheloai.AutoSize = true;
            this.lbltheloai.Location = new System.Drawing.Point(23, 140);
            this.lbltheloai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltheloai.Name = "lbltheloai";
            this.lbltheloai.Size = new System.Drawing.Size(59, 17);
            this.lbltheloai.TabIndex = 56;
            this.lbltheloai.Text = "Thể loại";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(331, 39);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(41, 17);
            this.lblKhoa.TabIndex = 55;
            this.lblKhoa.Text = "Khoa";
            // 
            // txtFNameProject
            // 
            this.txtFNameProject.Location = new System.Drawing.Point(132, 89);
            this.txtFNameProject.Margin = new System.Windows.Forms.Padding(4);
            this.txtFNameProject.Name = "txtFNameProject";
            this.txtFNameProject.Size = new System.Drawing.Size(160, 22);
            this.txtFNameProject.TabIndex = 53;
            // 
            // txtMDA
            // 
            this.txtMDA.Location = new System.Drawing.Point(132, 39);
            this.txtMDA.Margin = new System.Windows.Forms.Padding(4);
            this.txtMDA.Name = "txtMDA";
            this.txtMDA.Size = new System.Drawing.Size(160, 22);
            this.txtMDA.TabIndex = 52;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(23, 89);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(73, 17);
            this.lblFullname.TabIndex = 51;
            this.lblFullname.Text = "Tên đồ án";
            this.lblFullname.Click += new System.EventHandler(this.lblFullname_Click);
            // 
            // lblMda
            // 
            this.lblMda.AutoSize = true;
            this.lblMda.Location = new System.Drawing.Point(23, 39);
            this.lblMda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMda.Name = "lblMda";
            this.lblMda.Size = new System.Drawing.Size(50, 17);
            this.lblMda.TabIndex = 50;
            this.lblMda.Text = "Mã ĐA";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNganh);
            this.groupBox1.Controls.Add(this.lblNganh);
            this.groupBox1.Controls.Add(this.cbTheloai);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.lbltheloai);
            this.groupBox1.Controls.Add(this.lblKhoa);
            this.groupBox1.Controls.Add(this.txtFNameProject);
            this.groupBox1.Controls.Add(this.txtMDA);
            this.groupBox1.Controls.Add(this.lblFullname);
            this.groupBox1.Controls.Add(this.lblMda);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(613, 185);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(138, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 46);
            this.label1.TabIndex = 66;
            this.label1.Text = "THÔNG TIN ĐỒ ÁN";
            // 
            // frmAddDa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(637, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddDa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đồ án";
            this.Load += new System.EventHandler(this.frmAddDa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.ComboBox cbTheloai;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label lbltheloai;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtFNameProject;
        private System.Windows.Forms.TextBox txtMDA;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblMda;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}