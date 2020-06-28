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
    public partial class frmChitietdoan : Form
    {
        DBDOANWINEntities3 getdoan = new DBDOANWINEntities3();
        string mada;
        public frmChitietdoan(string Madoan)
        {
            mada = Madoan;
            InitializeComponent();
        }

        private void frmChitietdoan_Load(object sender, EventArgs e)
        {
            int quyenhan = frmLogin.CHECK;
            if (quyenhan == 1)
                Enablebtn();
            if (quyenhan == 2)
                Disablebtn();
            var result_Khoa = from a in getdoan.Khoas select new { a.Ten_khoa };
            this.cbKhoa.DataSource = result_Khoa.ToList();
            this.cbKhoa.ValueMember = "Ten_khoa";

            var result_TL = from b in getdoan.The_Loai select new { TL = b.Ten_TL };
            this.cbTheloai.DataSource = result_TL.ToList();
            this.cbTheloai.ValueMember = "TL";

            var db = mada;
            var result = from a in getdoan.QLDAs where a.Ma_ĐA == db select a;
            foreach (var row in result)
            {
                this.txtMada.Text = row.Ma_ĐA;
                this.txtNameProject.Text = row.Ten_ĐA;
                this.cbKhoa.Text = row.Nganh.Khoa.Ten_khoa;
                this.cbNganh.Text = row.Nganh.Chuyen_nganh;
                this.cbTheloai.Text = row.The_Loai1.Ten_TL;

            }
           
  
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
       
       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            QLDA project = new QLDA();

            project.Ma_ĐA = this.txtMada.Text.Trim();
            
            project.Ten_ĐA = this.txtNameProject.Text.Trim();
            var matl = getdoan.The_Loai.Where(tl => tl.Ten_TL == this.cbTheloai.Text).SingleOrDefault().Ma_TL.Trim();
            var manganh = getdoan.Nganhs.Where(n => n.Chuyen_nganh == this.cbNganh.Text).SingleOrDefault().Ma_nganh.Trim();
            project.Chuyen_nganh = manganh.ToString();
            project.The_loai = matl.ToString();

            QLDASV DASV = new QLDASV();
            var madoan = from b in getdoan.QLDASVs where b.Ma_DA == mada select b;

            if (madoan.Any())
            {
                foreach (var row in madoan)
                {
                    DASV.Ma_GV = row.Ma_GV.ToString();
                    DASV.Ma_SV = row.Ma_SV.ToString();
                    DASV.Ten_GV = row.Ten_GV.ToString();
                    DASV.Ten_SV = row.Ten_SV.ToString();
                    DASV.Ngay_bat_dau = row.Ngay_bat_dau.ToString();
                   // DASV.Tien_do = row.Tien_do.ToString();
                }

                DASV.Ma_DA = this.txtMada.Text.Trim();
                DASV.Ten_DA = this.txtNameProject.Text.Trim();
                DASV.The_loai = matl.ToString();
                getdoan.QLDASVs.AddOrUpdate(DASV);
                getdoan.SaveChanges();
            }
  

            if (ProjectController.UpdateProject(project) == false)
            {
                MessageBox.Show("lỗi sửa Project!");
                return;
            }
            else
            {
                MessageBox.Show("Sửa đồ án thành công");
               
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           // ProjectController.DeleteProject(this..Items[this.listEvent.SelectedItems[0].Index].Text);
            //this.listEvent.SelectedItems[0].Remove();
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
