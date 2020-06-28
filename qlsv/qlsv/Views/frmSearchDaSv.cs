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
    
    public partial class frmSearchDaSv : Form
    {
        DBDOANWINEntities3 getdoansv = new DBDOANWINEntities3();
        string madasv;
        DateTime ngay;
        public frmSearchDaSv(string Madasv)
        {
            madasv = Madasv;
            InitializeComponent();
        }

        private void frmSearchDaSv_Load(object sender, EventArgs e)
        {
            int quyenhan = frmLogin.CHECK;
            if (quyenhan == 1)
                Enablebtn();
            if (quyenhan == 2)
                Disablebtn();
            var db = madasv;
            var result = (from a in getdoansv.QLDASVs where a.Ma_DASV == db select a);
            
            

            foreach (var row in result)
            {
                this.txtMADASV.Text = row.Ma_DASV;
                  this.txtMASV.Text = row.Ma_SV;
                // this.cbMaSV.Text = row.Ma_SV;
                //this.lstMASV.Text = row.Ma_SV;
                this.txtTenSV.Text = row.Ten_SV;
                 this.txtMAGV.Text = row.Ma_GV;
                this.txtTenGV.Text = row.Ten_GV;
                  this.txtMADA.Text = row.Ma_DA;
                this.txtTendoan.Text = row.Ten_DA;
                this.txtTL.Text = row.The_loai;
                this.txtLink.Text = row.Link_DA;

               
              //  this.txtTiendo.Text = row.Tien_do;
                string from = row.Ngay_bat_dau;
                string to = row.Ngay_ket_thuc;
                this.dateFrom.Value = DateTime.ParseExact(from, "dd/MM/yyyy", null);
                this.dateTo.Value = DateTime.ParseExact(to, "dd/MM/yyyy", null);
                string tiendo1 = row.Tien_do.Báo_cáo_tiến_độ_lần_1.Trim();
                string tiendo2 = row.Tien_do.Báo_cáo_giữa_kỳ.Trim();
                string tiendo3 = row.Tien_do.Báo_cáo_tiến_độ_lần_3.Trim();
                string tiendo4 = row.Tien_do.Báo_cáo_cuối_kỳ.Trim();
                int count = 0;
                ngay = dateTo.Value;
                if (tiendo1 == "Hoàn Thành")
                {
                    this.chBTiendo1.Checked = true;
                    count++;
                }
                if (tiendo2 == "Hoàn Thành")
                {
                    this.chBGiuaky.Checked = true;
                    count++;
                }
                if (tiendo3 == "Hoàn Thành")
                {
                    this.chBTiendo3.Checked = true;
                    count++;
                }
                if (tiendo4 == "Hoàn Thành")
                {
                    this.chBCuoiky.Checked = true;
                    count++;
                    this.txtTrangthai.Text = "Đã hoàn thành";
                }
                else if(ngay.DayOfYear > DateTime.Now.DayOfYear )
                {
                    this.txtTrangthai.Text = "Đang thực hiện";
                }
                else
                {
                    this.txtTrangthai.Text = "Quá hạn";
                }
         
                progressBar1.Maximum = 100;
                int tb =(count*100)/4;
                progressBar1.Value = tb;
                label4.Text = progressBar1.Value.ToString() + "%";

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void txtMASV_TextChanged(object sender, EventArgs e)
        {
            //var db = this.txtMASV.Text;
            //var result = from a in getdoansv.QLSVs where a.Ma_SV == db select new { tenSV = a.Ten_SV };
            //foreach (var row in result)
            //{
            //    this.txtTenSV.Text = row.tenSV;
            //}
            //var result_Nganh = from b in getdoansv.QLSVs where b.Ma_SV == db select new { Manganh = b.Lop1.Ma_Nganh };
            //foreach (var row in result_Nganh)
            //{
            //    var result_GV = from c in getdoansv.QLGVs
            //                    where c.Nganh == row.Manganh
            //                    select new { Ma_GV = c.Ma_GV };
            //    var result_DA = from d in getdoansv.QLDAs
            //                    where d.Chuyen_nganh == row.Manganh
            //                    select new { MaDA = d.Ma_ĐA };
            //    this.txtMAGV.Text = result_GV.ToString();
            //    this.txtMADA.Text = result_DA.ToString();

            //}
        }

        private void txtMAGV_TextChanged(object sender, EventArgs e)
        {
            var db = this.txtMAGV.Text;
            var result = from a in getdoansv.QLGVs where a.Ma_GV == db select new { tenGV = a.Ten_GV };
            foreach (var row in result)
            {
                this.txtTenGV.Text = row.tenGV;
            }
        }

        private void txtMADA_TextChanged(object sender, EventArgs e)
        {
            var db = this.txtMADA.Text;
            var result = from a in getdoansv.QLDAs where a.Ma_ĐA == db select new { tenDA = a.Ten_ĐA, tl = a.The_loai };
            foreach (var row in result)
            {
                this.txtTendoan.Text = row.tenDA;
                this.txtTL.Text = row.tl;
            }

            //var result_Nganh = from b in getdoansv.QLDAs where b.Ma_ĐA == db select new { Manganh = b.Nganh.Ma_nganh};
            //foreach (var row in result_Nganh)
            //{
            //    var result_GV = from c in getdoansv.QLGVs
            //                    where c.Nganh == row.Manganh
            //                    select new { Ma_GV = c.Ma_GV };
            //    var result_SV = from d in getdoansv.QLSVs
            //                    where d.Lop1.Ma_Nganh== row.Manganh
            //                    select new { MaSV=d.Ma_SV };
            //    this.txtMAGV.Text = result_GV.ToString();
            //    this.txtMASV.Text = result_SV.ToString();

            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            QLDASV Project_Student = new QLDASV();
            Project_Student.Ma_DASV = this.txtMADASV.Text.Trim();
            Project_Student.Ma_DA = this.txtMADA.Text.Trim();
            Project_Student.Ten_DA = this.txtTendoan.Text.Trim();
            Project_Student.Ma_SV = this.txtMASV.Text.Trim();
            Project_Student.Ten_SV = this.txtTenSV.Text.Trim();
            Project_Student.Ma_GV = this.txtMAGV.Text.Trim();
            Project_Student.Ten_GV = this.txtTenGV.Text.Trim();
            Project_Student.Ma_DA = this.txtMADA.Text.Trim();
            Project_Student.Ten_DA = this.txtTendoan.Text.Trim();
            Project_Student.The_loai = this.txtTL.Text.Trim();
            Project_Student.Ngay_bat_dau = this.dateFrom.Value.ToString("dd/MM/yyyy");
            Project_Student.Ngay_ket_thuc= this.dateTo.Value.ToString("dd/MM/yyyy");
            Project_Student.Link_DA = this.txtLink.Text.Trim();

            string tiendo1 = "Chưa Hoàn Thành";
            string tiendo2 = "Chưa Hoàn Thành";
            string tiendo3 = "Chưa Hoàn Thành";
            string tiendo4 = "Chưa Hoàn Thành";

            if (this.chBTiendo1.Checked == true)
                tiendo1 = "Hoàn Thành";
            if (this.chBGiuaky.Checked == true)
                tiendo2 = "Hoàn Thành";
            if (this.chBTiendo3.Checked == true)
                tiendo3 = "Hoàn Thành";
            if (this.chBCuoiky.Checked == true)
                tiendo4 = "Hoàn Thành";

            //  Project_Student.Tien_do = this.txtTiendo.Text.Trim();

            if (Project_StudentController.UpdateProject_Student(Project_Student) == false)
            {
                MessageBox.Show("Lỗi sửa đồ án sinh viên!");

            }
            else
            {

                Tien_do tiendo = new Tien_do();
                tiendo.Ma_DASV = this.txtMADASV.Text.Trim();
                tiendo.Báo_cáo_tiến_độ_lần_1 = tiendo1;
                tiendo.Báo_cáo_giữa_kỳ = tiendo2;
                tiendo.Báo_cáo_tiến_độ_lần_3 = tiendo3;
                tiendo.Báo_cáo_cuối_kỳ = tiendo4;
                getdoansv.Tien_do.AddOrUpdate(tiendo);
                getdoansv.SaveChanges();
                MessageBox.Show("Sửa đồ án sinh viên thành công!");
                this.Close();
            }
        }

        private void progressBar1_Changed(object sender, EventArgs e)
        {
            //this.progressBar1.t = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Percentage;

            
        }

        private void progressBar1_EnabledChanged(object sender, EventArgs e)
        {
           // this.progressBar1.t = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Percentage;
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa đồ án sinh viên này?", "QLDASV", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                var db = this.txtMADASV.Text;
                var madasv = getdoansv.QLDASVs.Where(n => n.Ma_DASV == db).SingleOrDefault().Ma_DASV.Trim();
                var tiendo = getdoansv.Tien_do.Where(n => n.Ma_DASV == madasv).SingleOrDefault();
                if(tiendo != null)
                {
                    getdoansv.Tien_do.Remove(tiendo);
                    getdoansv.SaveChanges();
                }
 
                if(Project_StudentController.DeleteProject_Student(db) == false)
                {
                    MessageBox.Show("Lỗi xóa đồ án sinh viên!");
                }
                else
                {
                    MessageBox.Show("Xóa đồ án sinh viên thành công!");
                }
                this.Close();

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
