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
    public partial class frmAddDoanSV : Form
    {
        DBDOANWINEntities3 getdoansv = new DBDOANWINEntities3();
        public frmAddDoanSV()
        {
            InitializeComponent();
        }

        private void frmAddDoanSV_Load(object sender, EventArgs e)
        {
            //var result_SV = from b in getdoansv.QLSVs select new { MSV = b.Ma_SV };
            //this.cbMaSV.DataSource = result_SV.ToList();
            //this.cbMaSV.ValueMember = "MSV";



            //var result_GV = from c in getdoansv.QLGVs select new { MGV = c.Ma_GV };
            //this.cbMagv.DataSource = result_GV.ToList();
            //this.cbMagv.ValueMember = "MGV";

            var result_DA = from d in getdoansv.QLDAs select new { MDA = d.Ma_ĐA };
            this.cbMada.DataSource = result_DA.ToList();
            this.cbMada.ValueMember = "MDA";


            var result1 = from a in getdoansv.The_Loai select new { TL = a.Ten_TL };
            this.cbTheloai.DataSource = result1.ToList();
            this.cbTheloai.ValueMember = "TL";

           
        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbMaSV.Text;
            var result = from a in getdoansv.QLSVs where a.Ma_SV == db select new { tenSV = a.Ten_SV };
            foreach (var row in result)
            {
                this.txtTenSV.Text = row.tenSV;
            }
            //var result_Nganh = from b in getdoansv.QLSVs where b.Ma_SV == db select new { Manganh = b.Lop1.Ma_Nganh };
            //foreach (var row in result_Nganh)
            //{
            //    var result_GV = from c in getdoansv.QLGVs
            //                    where c.Nganh == row.Manganh
            //                    select new { Ma_GV = c.Ma_GV };
            //    var result_DA = from d in getdoansv.QLDAs
            //                    where d.Chuyen_nganh == row.Manganh
            //                    select new { MaDA = d.Ma_ĐA };
            //    this.cbMagv.DataSource = result_GV.ToList();
            //    this.cbMagv.ValueMember = "Ma_GV";
            //    this.cbMada.DataSource = result_DA.ToList();
            //    this.cbMada.ValueMember = "MaDA";
            //}
        }

        private void cbMagv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbMagv.Text;
            var result = from a in getdoansv.QLGVs where a.Ma_GV == db select new { tenGV = a.Ten_GV };
            foreach (var row in result)
            {
                this.txtTenGV.Text = row.tenGV;
            }
        }

        private void cbMada_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var db = this.cbMada.Text;
            
            var result = from a in getdoansv.QLDAs where a.Ma_ĐA == db select new { tenDA = a.Ten_ĐA };
            foreach (var row in result)
            {
                this.txtTendoan.Text = row.tenDA;
            }
            var result_Nganh = from b in getdoansv.QLDAs where b.Ma_ĐA== db select new { Manganh = b.Chuyen_nganh };
            foreach (var row in result_Nganh)
            {
                var result_GV = from c in getdoansv.QLGVs
                                where c.Nganh == row.Manganh
                                select new { Ma_GV = c.Ma_GV };
                var result_SV = from d in getdoansv.QLSVs
                                where d.Lop1.Ma_Nganh == row.Manganh
                                select new { MaSV = d.Ma_SV };
                this.cbMagv.DataSource = result_GV.ToList();
                this.cbMagv.ValueMember = "Ma_GV";
                this.cbMaSV.DataSource = result_SV.ToList();
                this.cbMaSV.ValueMember = "MaSV";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (Project_StudentController.getProject_Student(this.txtMADASV.Text.Trim(),this.cbMaSV.Text.Trim(), this.cbMagv.Text.Trim(), this.cbMada.Text.Trim()) != null)
            {
                MessageBox.Show("Đã tồn tại!");
                return;
            }
            else this.errorProvider1.Clear();
            var db = this.cbMada.Text.Trim();
            if (Project_StudentController.getProject(db) is false)
            {
                this.errorProvider1.SetError(this.cbMada, "Không tìm thấy đồ án này");
                return;
            }
            else this.errorProvider1.Clear();
            DateTime d1 = dateFrom.Value;
            DateTime d2 = dateTo.Value;

            TimeSpan time = d2 - d1;
            var t = int.Parse(Math.Round(time.TotalDays).ToString());
            if (t <=0)
            {
                this.errorProvider1.SetError(this.dateTo, "Ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }
            QLDASV DoAnSV = new QLDASV();
            DoAnSV.Ma_DASV = this.txtMADASV.Text.Trim();
            DoAnSV.Ma_SV = this.cbMaSV.Text.Trim();

            var tenSV = getdoansv.QLSVs.Where(n => n.Ma_SV == this.cbMaSV.Text).SingleOrDefault().Ten_SV.Trim();
            DoAnSV.Ten_SV = tenSV.ToString();

            DoAnSV.Ma_GV = this.cbMagv.Text.Trim();

            var tenGV = getdoansv.QLGVs.Where(n => n.Ma_GV == this.cbMagv.Text).SingleOrDefault().Ten_GV.Trim();
            DoAnSV.Ten_GV = tenGV.ToString();

            DoAnSV.Ma_DA = this.cbMada.Text.Trim();

            var tenDA = getdoansv.QLDAs.Where(n => n.Ma_ĐA == this.cbMada.Text).SingleOrDefault().Ten_ĐA.Trim();
            DoAnSV.Ten_DA = tenDA.ToString();

            var theloai = getdoansv.The_Loai.Where(n => n.Ten_TL == this.cbTheloai.Text).SingleOrDefault().Ma_TL.Trim();
            DoAnSV.The_loai = theloai.ToString();


            DoAnSV.Ngay_bat_dau = this.dateFrom.Value.ToString("dd/MM/yyyy");
            DoAnSV.Ngay_ket_thuc = this.dateTo.Value.ToString("dd/MM/yyyy");
            DoAnSV.Link_DA = this.txtLink.Text.Trim();

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
          
            // DoAnSV.Tien_do = this.txtTiendo.Text.Trim();

            if (Project_StudentController.AddProject_Student(DoAnSV) == false)
            {
                MessageBox.Show("Lỗi thêm đồ án sinh viên!");
                return;
            }
            else
            {
                
                Tien_do tiendo = new Tien_do();
                tiendo.Ma_DASV = this.txtMADASV.Text.Trim();
                tiendo.Báo_cáo_tiến_độ_lần_1 = tiendo1;
                tiendo.Báo_cáo_giữa_kỳ = tiendo2;
                tiendo.Báo_cáo_tiến_độ_lần_3 = tiendo3;
                tiendo.Báo_cáo_cuối_kỳ = tiendo4;
                getdoansv.Tien_do.Add(tiendo);
                getdoansv.SaveChanges();
                MessageBox.Show("Thêm đồ án sinh viên thành công!");
            }
            this.Close();
        }

        private void txtMADASV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
