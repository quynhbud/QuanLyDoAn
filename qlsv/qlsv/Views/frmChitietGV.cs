using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmChitietGV : Form
    {
        DBDOANWINEntities3 getgv= new DBDOANWINEntities3();
        string magv;
        public frmChitietGV(string Magv)
        {
            magv = Magv;
            InitializeComponent();
        }

        private void frmChitietGV_Load(object sender, EventArgs e)
        {
            int quyenhan = frmLogin.CHECK;
            if (quyenhan == 1)
                Enablebtn();
            if (quyenhan == 2)
                Disablebtn();
            var result1 = from a in getgv.Khoas select new { a.Ten_khoa };
            this.cbKhoa.DataSource = result1.ToList();
            this.cbKhoa.ValueMember = "Ten_khoa";

            this.txtMGV.Text = magv.Trim();
            var db = this.txtMGV.Text;
            var result = from a in getgv.QLGVs where a.Ma_GV == db select new { a.Ma_GV, a.Ten_GV, a.Gioi_tinh, a.Ngay_sinh, nganh = a.Nganh1.Chuyen_nganh, Khoa = a.Nganh1.Khoa.Ten_khoa, a.Dia_chi, a.SĐT, a.Email };
            foreach (var row in result)
            {
                this.txtFullName.Text = row.Ten_GV;
                this.cbKhoa.Text = row.Khoa;
                this.cbNganh.Text = row.nganh;
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

            var result = from a in getgv.Nganhs where a.Khoa.Ten_khoa == db select new { nganh = a.Chuyen_nganh };
            this.cbNganh.DataSource = result.ToList();
            this.cbNganh.ValueMember = "nganh";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            QLGV teacher = new QLGV();
            teacher.Ma_GV = this.txtMGV.Text.Trim();
            teacher.Ten_GV = this.txtFullName.Text.Trim();

            var maNganh = getgv.Nganhs.Where(n => n.Chuyen_nganh == this.cbNganh.Text).SingleOrDefault().Ma_nganh.Trim();
            teacher.Nganh = maNganh.ToString();

            teacher.Ngay_sinh = this.dtBirthday.Value.ToString("dd/MM/yyyy");
            teacher.Gioi_tinh = this.cbSex.Text.Trim();
            teacher.Dia_chi = this.txtAddress.Text.Trim();
            teacher.SĐT = this.txtSDT.Text.Trim();
            teacher.Email = this.txtEmail.Text.Trim();

            QLDASV DASV = new QLDASV();
            var maGV = from b in getgv.QLDASVs where b.Ma_GV == magv select b;
            if (maGV.Any())
            {
                foreach (var row in maGV)
                {
                    DASV.Ma_SV = row.Ma_SV.ToString();
                    DASV.Ten_SV = row.Ten_SV.ToString();
                    DASV.Ma_DA = row.Ma_DA.ToString();
                    DASV.Ten_DA = row.Ten_DA.ToString();
                    DASV.The_loai = row.The_loai.ToString();
                    DASV.Ngay_bat_dau = row.Ngay_bat_dau.ToString();
                //    DASV.Tien_do = row.Tien_do.ToString();
                }
                DASV.Ma_GV = this.txtMGV.Text.Trim();
                DASV.Ten_GV = this.txtFullName.Text.Trim();

                getgv.QLDASVs.AddOrUpdate(DASV);
                getgv.SaveChanges();
            }

            if (TeacherController.UpdateTeacher(teacher) == false)
            {
                MessageBox.Show("lỗi sửa giảng viên!");
                return;
            }
            else
            {
                MessageBox.Show("Sửa giảng viên thành công");
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
