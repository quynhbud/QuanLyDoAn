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

namespace qlsv.views
{
    public partial class frmAddSV : Form
    {
        DBDOANWINEntities3 getsv = new DBDOANWINEntities3();
        public frmAddSV()
        {
            InitializeComponent();
        }

        private void frmAddSV_Load(object sender, EventArgs e)
        {
            var result1 = from a in getsv.Khoas select new { a.Ten_khoa };
            this.cbKhoa.DataSource = result1.ToList();
            this.cbKhoa.ValueMember = "Ten_khoa";
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbKhoa.Text;
            var result = from a in getsv.Nganhs where a.Khoa.Ten_khoa == db select new { nganh = a.Chuyen_nganh };
            this.cbNganh.DataSource = result.ToList();
            this.cbNganh.ValueMember = "nganh";
        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbNganh.Text;
            var result = from a in getsv.Lops where a.Nganh.Chuyen_nganh == db select new { lop = a.Lop1 };
            this.cbLop.DataSource = result.ToList();
            this.cbLop.ValueMember = "lop";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtMSSV.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtMSSV, "Vui lòng nhập mã sinh viên");
                return;
            }
            else if (StudentController.getStudent(this.txtMSSV.Text.Trim()) != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                return;
            }
            
            else this.errorProvider1.Clear();

            if (this.txtFullName.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtFullName, "Vui lòng nhập tên sinh viên");
                return;
            }
            else this.errorProvider1.Clear();

            if (this.cbKhoa.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.cbKhoa, "Vui lòng chọn Khoa");
                return;
            }
            else this.errorProvider1.Clear();

            if (this.cbNganh.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.cbNganh, "Vui lòng chọn Ngành");
                return;
            }
            else this.errorProvider1.Clear();

            if (this.cbSex.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.cbSex, "Vui lòng chọn giới tính");
                return;
            }
            else this.errorProvider1.Clear();

            if (this.txtAddress.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtAddress, "Vui lòng nhập địa chỉ");
                return;
            }
            else this.errorProvider1.Clear();
            if (this.txtPhone.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtPhone, "Vui lòng chọn giới tính");
                return;
            }
            else this.errorProvider1.Clear();
            if (this.txtEmail.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtEmail, "Vui lòng chọn giới tính");
                return;
            }
            else this.errorProvider1.Clear();

            DateTime d1 = dateTimeBirthday.Value;
            DateTime d2 = DateTime.Now;

            TimeSpan time = d2 - d1;
            var t = int.Parse(Math.Round(time.TotalDays).ToString());
            int tuoi = t / 365;
            if (tuoi < 18)
            {
                this.errorProvider1.SetError(this.dateTimeBirthday, "Bạn phải lớn hơn hoặc bằng 18 tuổi");
                return;
            }
            else this.errorProvider1.Clear();


            QLSV student = new QLSV();
            student.Ma_SV = this.txtMSSV.Text.Trim();
            student.Ten_SV = this.txtFullName.Text.Trim();

            var malop = getsv.Lops.Where(n => n.Lop1 == this.cbLop.Text).SingleOrDefault().Ma_lop.Trim();
            student.Lop = malop.ToString();

            student.Ngay_sinh = this.dateTimeBirthday.Value.ToString("dd/MM/yyyy");
            student.Gioi_tinh = this.cbSex.Text.Trim();
            student.Dia_chi = this.txtAddress.Text.Trim();
            student.SĐT = this.txtPhone.Text.Trim();
            student.Email = this.txtEmail.Text.Trim();

            if(StudentController.AddStudent(student) == false)
            {
                MessageBox.Show("Lỗi thêm sinh viên!");
                return;
            }
            else
            {
                MessageBox.Show("Thêm sinh viên thành công!");
            }
            this.Close();
        }
    }
}
