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
    public partial class frmAddDa : Form
    {
        DBDOANWINEntities3 getdoan = new DBDOANWINEntities3();
        public frmAddDa()
        {
            InitializeComponent();
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbKhoa.Text;
            var result = from a in getdoan.Nganhs where a.Khoa.Ten_khoa == db select new { nganh = a.Chuyen_nganh };
            this.cbNganh.DataSource = result.ToList();
            this.cbNganh.ValueMember = "nganh";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddDa_Load(object sender, EventArgs e)
        {
            var result_Khoa = from a in getdoan.Khoas select new { a.Ten_khoa };
            this.cbKhoa.DataSource = result_Khoa.ToList();
            this.cbKhoa.ValueMember = "Ten_khoa";

            var result_TL = from b in getdoan.The_Loai select new { TL = b.Ten_TL };
            this.cbTheloai.DataSource = result_TL.ToList();
            this.cbTheloai.ValueMember = "TL";
        }

        private void cbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var db = this.cbKhoa.Text;
            var result = from a in getdoan.Khoas where a.Ten_khoa == db select new { makhoa = a.Ma_khoa };
            var result1 = from b in getdoan.Nganhs join c in result on b.Ma_khoa equals c.makhoa select new { nganh = b.Chuyen_nganh };
            this.cbNganh.DataSource = result1.ToList();
            this.cbNganh.ValueMember = "nganh";
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtMDA.Text.Trim().Length <=0)
            {
                this.errorProvider1.SetError(this.txtMDA, "Vui lòng nhập mã đồ án");
                return;
            }
            else if (ProjectController.getProject(this.txtMDA.Text.Trim()) != null)
            {
                MessageBox.Show("Mã đồ án đã tồn tại!");
                return;
            }
            else this.errorProvider1.Clear();

            if (this.txtFNameProject.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtFNameProject, "Vui lòng nhập tên đồ án");
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
                this.errorProvider1.SetError(this.cbNganh, "Vui lòng chọn ngành");
                return;
            }
            else this.errorProvider1.Clear();

            if (this.cbTheloai.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.cbTheloai, "Vui lòng chọn thể loại đồ án");
                return;
            }
            else this.errorProvider1.Clear();

            QLDA project = new QLDA();
          
            project.Ma_ĐA = this.txtMDA.Text.Trim();
            project.Ten_ĐA = this.txtFNameProject.Text.Trim();
            var matl = getdoan.The_Loai.Where(tl => tl.Ten_TL == this.cbTheloai.Text).SingleOrDefault().Ma_TL.Trim();
            var manganh = getdoan.Nganhs.Where(n => n.Chuyen_nganh == this.cbNganh.Text).SingleOrDefault().Ma_nganh.Trim();
            project.Chuyen_nganh = manganh.ToString();
            project.The_loai = matl.ToString();

            if( ProjectController.AddProject(project) ==false)
            {
                MessageBox.Show("lỗi thêm Project!");
                return;
            }
            else
            {
                MessageBox.Show("Thêm đồ án thành công");
            }
            this.Close();
        }

        private void lblFullname_Click(object sender, EventArgs e)
        {

        }
    }
}
