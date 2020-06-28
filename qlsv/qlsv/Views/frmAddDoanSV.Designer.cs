namespace qlsv.views
{
    partial class frmAddDoanSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDoanSV));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMSV = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblTheloai = new System.Windows.Forms.Label();
            this.lblMGV = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblMada = new System.Windows.Forms.Label();
            this.lblTendoan = new System.Windows.Forms.Label();
            this.lblTiendo = new System.Windows.Forms.Label();
            this.lblDatefrom = new System.Windows.Forms.Label();
            this.cbTheloai = new System.Windows.Forms.ComboBox();
            this.cbMaSV = new System.Windows.Forms.ComboBox();
            this.cbMagv = new System.Windows.Forms.ComboBox();
            this.cbMada = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtTendoan = new System.Windows.Forms.TextBox();
            this.txtMADASV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chBCuoiky = new System.Windows.Forms.CheckBox();
            this.chBTiendo3 = new System.Windows.Forms.CheckBox();
            this.chBGiuaky = new System.Windows.Forms.CheckBox();
            this.chBTiendo1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(907, 481);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 70;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(769, 481);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Location = new System.Drawing.Point(337, 43);
            this.lblMSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(49, 17);
            this.lblMSV.TabIndex = 75;
            this.lblMSV.Text = "Mã SV";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(337, 87);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(69, 17);
            this.lblFullname.TabIndex = 76;
            this.lblFullname.Text = "Họ và tên";
            // 
            // lblTheloai
            // 
            this.lblTheloai.AutoSize = true;
            this.lblTheloai.Location = new System.Drawing.Point(21, 187);
            this.lblTheloai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheloai.Name = "lblTheloai";
            this.lblTheloai.Size = new System.Drawing.Size(59, 17);
            this.lblTheloai.TabIndex = 77;
            this.lblTheloai.Text = "Thể loại";
            // 
            // lblMGV
            // 
            this.lblMGV.AutoSize = true;
            this.lblMGV.Location = new System.Drawing.Point(337, 138);
            this.lblMGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMGV.Name = "lblMGV";
            this.lblMGV.Size = new System.Drawing.Size(51, 17);
            this.lblMGV.TabIndex = 78;
            this.lblMGV.Text = "Mã GV";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Location = new System.Drawing.Point(337, 187);
            this.lblTenGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(57, 17);
            this.lblTenGV.TabIndex = 79;
            this.lblTenGV.Text = "Tên GV";
            // 
            // lblMada
            // 
            this.lblMada.AutoSize = true;
            this.lblMada.Location = new System.Drawing.Point(21, 87);
            this.lblMada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMada.Name = "lblMada";
            this.lblMada.Size = new System.Drawing.Size(50, 17);
            this.lblMada.TabIndex = 80;
            this.lblMada.Text = "Mã ĐA";
            // 
            // lblTendoan
            // 
            this.lblTendoan.AutoSize = true;
            this.lblTendoan.Location = new System.Drawing.Point(21, 138);
            this.lblTendoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTendoan.Name = "lblTendoan";
            this.lblTendoan.Size = new System.Drawing.Size(76, 17);
            this.lblTendoan.TabIndex = 81;
            this.lblTendoan.Text = "Tên Đồ Án";
            // 
            // lblTiendo
            // 
            this.lblTiendo.AutoSize = true;
            this.lblTiendo.Location = new System.Drawing.Point(63, 41);
            this.lblTiendo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiendo.Name = "lblTiendo";
            this.lblTiendo.Size = new System.Drawing.Size(0, 17);
            this.lblTiendo.TabIndex = 82;
            // 
            // lblDatefrom
            // 
            this.lblDatefrom.AutoSize = true;
            this.lblDatefrom.Location = new System.Drawing.Point(21, 233);
            this.lblDatefrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatefrom.Name = "lblDatefrom";
            this.lblDatefrom.Size = new System.Drawing.Size(93, 17);
            this.lblDatefrom.TabIndex = 84;
            this.lblDatefrom.Text = "Ngày bắt đầu";
            // 
            // cbTheloai
            // 
            this.cbTheloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheloai.FormattingEnabled = true;
            this.cbTheloai.Location = new System.Drawing.Point(136, 180);
            this.cbTheloai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTheloai.Name = "cbTheloai";
            this.cbTheloai.Size = new System.Drawing.Size(139, 24);
            this.cbTheloai.TabIndex = 85;
            // 
            // cbMaSV
            // 
            this.cbMaSV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaSV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaSV.FormattingEnabled = true;
            this.cbMaSV.Location = new System.Drawing.Point(445, 36);
            this.cbMaSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaSV.Name = "cbMaSV";
            this.cbMaSV.Size = new System.Drawing.Size(159, 24);
            this.cbMaSV.TabIndex = 86;
            this.cbMaSV.SelectedIndexChanged += new System.EventHandler(this.cbMaSV_SelectedIndexChanged);
            // 
            // cbMagv
            // 
            this.cbMagv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMagv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMagv.FormattingEnabled = true;
            this.cbMagv.Location = new System.Drawing.Point(445, 138);
            this.cbMagv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMagv.Name = "cbMagv";
            this.cbMagv.Size = new System.Drawing.Size(159, 24);
            this.cbMagv.TabIndex = 87;
            this.cbMagv.SelectedIndexChanged += new System.EventHandler(this.cbMagv_SelectedIndexChanged);
            // 
            // cbMada
            // 
            this.cbMada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMada.FormattingEnabled = true;
            this.cbMada.Location = new System.Drawing.Point(136, 82);
            this.cbMada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMada.Name = "cbMada";
            this.cbMada.Size = new System.Drawing.Size(139, 24);
            this.cbMada.TabIndex = 88;
            this.cbMada.SelectedIndexChanged += new System.EventHandler(this.cbMada_SelectedIndexChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(136, 228);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(139, 22);
            this.dateFrom.TabIndex = 89;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(445, 87);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(159, 22);
            this.txtTenSV.TabIndex = 90;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(445, 187);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.ReadOnly = true;
            this.txtTenGV.Size = new System.Drawing.Size(159, 22);
            this.txtTenGV.TabIndex = 91;
            // 
            // txtTendoan
            // 
            this.txtTendoan.Location = new System.Drawing.Point(136, 135);
            this.txtTendoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTendoan.Name = "txtTendoan";
            this.txtTendoan.ReadOnly = true;
            this.txtTendoan.Size = new System.Drawing.Size(139, 22);
            this.txtTendoan.TabIndex = 92;
            // 
            // txtMADASV
            // 
            this.txtMADASV.Location = new System.Drawing.Point(136, 39);
            this.txtMADASV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMADASV.Name = "txtMADASV";
            this.txtMADASV.Size = new System.Drawing.Size(139, 22);
            this.txtMADASV.TabIndex = 94;
            this.txtMADASV.TextChanged += new System.EventHandler(this.txtMADASV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Mã ĐASV";
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(445, 228);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(159, 22);
            this.dateTo.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 95;
            this.label2.Text = "Ngày kết thúc";
            // 
            // chBCuoiky
            // 
            this.chBCuoiky.AutoSize = true;
            this.chBCuoiky.Location = new System.Drawing.Point(27, 123);
            this.chBCuoiky.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBCuoiky.Name = "chBCuoiky";
            this.chBCuoiky.Size = new System.Drawing.Size(130, 21);
            this.chBCuoiky.TabIndex = 100;
            this.chBCuoiky.Text = "Báo cáo cuối kỳ";
            this.chBCuoiky.UseVisualStyleBackColor = true;
            // 
            // chBTiendo3
            // 
            this.chBTiendo3.AutoSize = true;
            this.chBTiendo3.Location = new System.Drawing.Point(27, 95);
            this.chBTiendo3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBTiendo3.Name = "chBTiendo3";
            this.chBTiendo3.Size = new System.Drawing.Size(117, 21);
            this.chBTiendo3.TabIndex = 99;
            this.chBTiendo3.Text = "Báo cáo lần 3";
            this.chBTiendo3.UseVisualStyleBackColor = true;
            // 
            // chBGiuaky
            // 
            this.chBGiuaky.AutoSize = true;
            this.chBGiuaky.Location = new System.Drawing.Point(27, 66);
            this.chBGiuaky.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBGiuaky.Name = "chBGiuaky";
            this.chBGiuaky.Size = new System.Drawing.Size(131, 21);
            this.chBGiuaky.TabIndex = 98;
            this.chBGiuaky.Text = "Báo cáo giữa kỳ";
            this.chBGiuaky.UseVisualStyleBackColor = true;
            // 
            // chBTiendo1
            // 
            this.chBTiendo1.AutoSize = true;
            this.chBTiendo1.Location = new System.Drawing.Point(27, 37);
            this.chBTiendo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBTiendo1.Name = "chBTiendo1";
            this.chBTiendo1.Size = new System.Drawing.Size(117, 21);
            this.chBTiendo1.TabIndex = 97;
            this.chBTiendo1.Text = "Báo cáo lần 1";
            this.chBTiendo1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 101;
            this.label3.Text = "Link đồ án";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(91, 162);
            this.txtLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(185, 22);
            this.txtLink.TabIndex = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTiendo);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Controls.Add(this.chBTiendo1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chBGiuaky);
            this.groupBox1.Controls.Add(this.chBCuoiky);
            this.groupBox1.Controls.Add(this.chBTiendo3);
            this.groupBox1.Location = new System.Drawing.Point(664, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(283, 241);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiến độ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dateTo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMADASV);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTendoan);
            this.groupBox2.Controls.Add(this.txtTenGV);
            this.groupBox2.Controls.Add(this.txtTenSV);
            this.groupBox2.Controls.Add(this.dateFrom);
            this.groupBox2.Controls.Add(this.cbMada);
            this.groupBox2.Controls.Add(this.cbMagv);
            this.groupBox2.Controls.Add(this.cbMaSV);
            this.groupBox2.Controls.Add(this.cbTheloai);
            this.groupBox2.Controls.Add(this.lblDatefrom);
            this.groupBox2.Controls.Add(this.lblTendoan);
            this.groupBox2.Controls.Add(this.lblMada);
            this.groupBox2.Controls.Add(this.lblTenGV);
            this.groupBox2.Controls.Add(this.lblMGV);
            this.groupBox2.Controls.Add(this.lblTheloai);
            this.groupBox2.Controls.Add(this.lblFullname);
            this.groupBox2.Controls.Add(this.lblMSV);
            this.groupBox2.Location = new System.Drawing.Point(24, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(983, 290);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(160, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(730, 55);
            this.label4.TabIndex = 104;
            this.label4.Text = "THÔNG TIN ĐỒ ÁN SINH VIÊN";
            // 
            // frmAddDoanSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1047, 533);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddDoanSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đồ án của sinh viên";
            this.Load += new System.EventHandler(this.frmAddDoanSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTendoan;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.ComboBox cbMada;
        private System.Windows.Forms.ComboBox cbMagv;
        private System.Windows.Forms.ComboBox cbMaSV;
        private System.Windows.Forms.ComboBox cbTheloai;
        private System.Windows.Forms.Label lblDatefrom;
        private System.Windows.Forms.Label lblTiendo;
        private System.Windows.Forms.Label lblTendoan;
        private System.Windows.Forms.Label lblMada;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblMGV;
        private System.Windows.Forms.Label lblTheloai;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblMSV;
        private System.Windows.Forms.TextBox txtMADASV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBCuoiky;
        private System.Windows.Forms.CheckBox chBTiendo3;
        private System.Windows.Forms.CheckBox chBGiuaky;
        private System.Windows.Forms.CheckBox chBTiendo1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
    }
}