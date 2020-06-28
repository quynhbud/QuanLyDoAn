using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlsv.Models;
using qlsv.Controllers;
using System.Data.Entity.Migrations;

namespace qlsv.views
{

    public partial class frmChitietsv : Form
    {
        DBDOANWINEntities3 getsv = new DBDOANWINEntities3();
        string masv;
        public frmChitietsv(string Masv)
        {
            masv = Masv;
            InitializeComponent();
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmChitietsv_Load(object sender, EventArgs e)
        {
            int quyenhan = frmLogin.CHECK;
            if (quyenhan == 1)
                Enablebtn();
            if (quyenhan == 2)
                Disablebtn();
            var result1 = from a in getsv.Khoas select new { a.Ten_khoa };
            this.cbKhoa.DataSource = result1.ToList();
            this.cbKhoa.ValueMember = "Ten_khoa";

            this.txtMSSV.Text = masv.Trim();
            var db = this.txtMSSV.Text;
            var result = from a in getsv.QLSVs where a.Ma_SV == db select new { a.Ma_SV, a.Ten_SV, a.Ngay_sinh, a.Gioi_tinh, a.Dia_chi, a.SĐT, a.Email, Lop = a.Lop1.Lop1, Nganh=a.Lop1.Nganh.Chuyen_nganh, Khoa= a.Lop1.Nganh.Khoa.Ten_khoa } ;
            foreach (var row in result)
            {
                this.txtFullName.Text = row.Ten_SV;
                this.cbLop.Text = row.Lop;
                this.cbKhoa.Text = row.Khoa;
                this.cbNganh.Text = row.Nganh;
                this.cbSex.Text = row.Gioi_tinh;
                this.txtAddress.Text = row.Dia_chi;
                this.txtSDT.Text = row.SĐT;
                string s = row.Ngay_sinh;
                this.dtBirthday.Value = DateTime.ParseExact(s, "dd/MM/yyyy", null);
                this.txtEmail.Text = row.Email;

            }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbKhoa.Text;
            var result = from a in getsv.Nganhs where a.Khoa.Ten_khoa == db select new { nganh = a.Chuyen_nganh };
            this.cbNganh.DataSource = result.ToList();
            this.cbNganh.ValueMember = "nganh";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbNganh.Text;
            var result = from a in getsv.Lops where a.Nganh.Chuyen_nganh == db select new { lop = a.Lop1 };
            this.cbLop.DataSource = result.ToList();
            this.cbLop.ValueMember = "lop";
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            QLSV student = new QLSV();
            student.Ma_SV = this.txtMSSV.Text.Trim();
            student.Ten_SV = this.txtFullName.Text.Trim();

            var malop = getsv.Lops.Where(n => n.Lop1 == this.cbLop.Text).SingleOrDefault().Ma_lop.Trim();
            student.Lop = malop.ToString();
            student.Ngay_sinh = this.dtBirthday.Value.ToString("dd/MM/yyyy");
            student.Gioi_tinh = this.cbSex.Text.Trim();
            student.Dia_chi = this.txtAddress.Text.Trim();
            student.SĐT = this.txtSDT.Text.Trim();
            student.Email = this.txtEmail.Text.Trim();

            QLDASV DASV = new QLDASV();
            var maSV = from b in getsv.QLDASVs where b.Ma_SV == masv select b;
            if(maSV.Any())
            {
                foreach(var row in maSV)
                {
                    DASV.Ma_DA = row.Ma_DA.ToString();
                    DASV.Ten_DA = row.Ten_DA.ToString();
                    DASV.Ma_GV = row.Ma_GV.ToString();
                    DASV.Ten_GV = row.Ten_GV.ToString();
                    DASV.The_loai = row.The_loai.ToString();
                    DASV.Ngay_bat_dau = row.Ngay_bat_dau.ToString();
                 //   DASV.Tien_do = row.Tien_do.ToString();
                }
                DASV.Ma_SV = this.txtMSSV.Text.Trim();
                DASV.Ten_SV = this.txtFullName.Text.Trim();

                getsv.QLDASVs.AddOrUpdate(DASV);
                getsv.SaveChanges();
            }

            if (StudentController.UpdateStudent(student) == false)
            {
                MessageBox.Show("lỗi sửa sinh viên!");
                return;
            }
            else
            {
                MessageBox.Show("Sửa sinh viên thành công");
            }
        }
        public void Enablebtn()
        {
            
            this.btnDelete.Visible = true;
            this.btnEdit.Visible = true;
        }
        public void Disablebtn()
        {
            
            this.btnDelete.Visible = false;
            this.btnEdit.Visible = false;
        }
    }
}
