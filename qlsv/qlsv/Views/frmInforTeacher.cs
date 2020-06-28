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
    
    public partial class frmInforTeacher : Form
    {
        DBDOANWINEntities3 getKhoa = new DBDOANWINEntities3();
        string Tennganh;
        public frmInforTeacher(string nganh)
        {
            Tennganh = nganh;
            
            InitializeComponent();
        }

        private void frmInforTeacher_Load(object sender, EventArgs e)
        {

            var result = from a in getKhoa.QLGVs where a.Nganh1.Chuyen_nganh == Tennganh select new { a.Ma_GV, a.Ten_GV, a.Gioi_tinh, a.Ngay_sinh, nganh=a.Nganh1.Chuyen_nganh,Khoa= a.Nganh1.Khoa.Ten_khoa, a.Dia_chi, a.SĐT, a.Email };
            dataGridView1.DataSource = result.ToList();
            //  dataGridView1.Columns["QLDASVs"].Visible = false;
            int quyenhan = frmLogin.CHECK;
            if (quyenhan == 1)
                Enablebtn();
            if (quyenhan == 2)
                Disablebtn();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string row = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtMaGV.Text = row;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtMaGV.Text.Length <= 0)
                MessageBox.Show("Vui lòng chọn thông tin giảng viên cần sửa!");
            else
            {
                string db = this.txtMaGV.Text;
                frmChitietGV frm = new frmChitietGV(db);
                frm.Show();
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddGV frm = new frmAddGV();
            frm.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtMaGV.Text.Length <= 0)
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa!");
            else
            {
                var result = MessageBox.Show("Bạn chắc chắn muốn xóa giảng viên này?", "QLDASV", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    QLDASV DASV = new QLDASV();
                    var db = this.txtMaGV.Text;
                    var maGV = getKhoa.QLDASVs.Where(n => n.Ma_GV == db).SingleOrDefault();
                    if (maGV == null)
                    {
                        if (TeacherController.DeleteTeacher(db) == false)
                        {
                            MessageBox.Show("Lỗi xóa giảng viên!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa giảng viên thành công!");
                        }
                        this.Close();
                    }
                    else
                    {
                        var maDASV = getKhoa.QLDASVs.Where(n => n.Ma_GV == db).SingleOrDefault().Ma_DASV.Trim();
                        var tiendo = getKhoa.Tien_do.Where(n => n.Ma_DASV == maDASV).SingleOrDefault();
                        if (tiendo != null)
                        {
                            getKhoa.Tien_do.Remove(tiendo);
                            getKhoa.SaveChanges();
                        }

                        {
                            getKhoa.QLDASVs.Remove(maGV);
                            getKhoa.SaveChanges();
                        }

                        if (TeacherController.DeleteTeacher(db) == false)
                        {
                            MessageBox.Show("Lỗi xóa giảng viên!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa giảng viên thành công!");
                        }
                        this.Close();
                    }
                }
            }
        }
        public void Enablebtn()
        {
            this.btnAdd.Visible = true;
            this.btnDelete.Visible = true;
            this.btnEdit.Visible = true;
            this.txtMaGV.Visible = true;
        }
        public void Disablebtn()
        {
            this.btnAdd.Visible = false;
            this.btnDelete.Visible = false;
            this.btnEdit.Visible = false;
            this.txtMaGV.Visible = false;
        }
    }
}
