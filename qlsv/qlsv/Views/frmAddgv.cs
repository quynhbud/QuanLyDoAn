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
    public partial class frmAddGV : Form
    {
        DBDOANWINEntities3 getgv = new DBDOANWINEntities3();
        public frmAddGV()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddGV_Load(object sender, EventArgs e)
        {
            var result1 = from a in getgv.Khoas select new { a.Ten_khoa };
            this.cbKhoa.DataSource = result1.ToList();
            this.cbKhoa.ValueMember = "Ten_khoa";
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbKhoa.Text;

            var result = from a in getgv.Nganhs where a.Khoa.Ten_khoa == db select new { nganh = a.Chuyen_nganh };
            this.cbNganh.DataSource = result.ToList();
            this.cbNganh.ValueMember = "nganh";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtMGV.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtMGV, "Vui lòng nhập mã giảng viên");
                return;
            }
            else if (TeacherController.getTeacher(this.txtMGV.Text.Trim()) != null)
            {
                MessageBox.Show("Mã giảng viên đã tồn tại!");
                return;
            }
            else this.errorProvider1.Clear();

            if (this.txtFullName.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtFullName, "Vui lòng nhập tên giảng viên");
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

            QLGV teachers = new QLGV();
            teachers.Ma_GV = this.txtMGV.Text.Trim();
            teachers.Ten_GV = this.txtFullName.Text.Trim();

            var manganh = getgv.Nganhs.Where(n => n.Chuyen_nganh == this.cbNganh.Text).SingleOrDefault().Ma_nganh.Trim();
            teachers.Nganh = manganh.ToString();

            teachers.Ngay_sinh = this.dateTimeBirthday.Value.ToString("dd/MM/yyyy");
            teachers.Gioi_tinh = this.cbSex.Text.Trim();
            teachers.Dia_chi = this.txtAddress.Text.Trim();
            teachers.SĐT = this.txtPhone.Text.Trim();
            teachers.Email = this.txtEmail.Text.Trim();

            if(TeacherController.AddTeacher(teachers) ==false)
            {
                MessageBox.Show("Lỗi thêm giảng viên!");
                return;
            }
            else
            {
                MessageBox.Show("Thêm giảng viên thành công!");
            }
            this.Close();
        }
    }
}
