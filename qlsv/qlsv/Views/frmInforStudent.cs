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
    public partial class frmInforStudent : Form
    {
        DBDOANWINEntities3 getKhoa = new DBDOANWINEntities3();
        string tenlop;
        string tenkhoa;
        public frmInforStudent(string Tenlop, string Tenkhoa)
        {
            tenlop = Tenlop;
            tenkhoa = Tenkhoa;
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInforStudent_Load(object sender, EventArgs e)
        {
            var result = (from a in getKhoa.QLSVs where (a.Lop1.Lop1 == tenlop && a.Lop1.Nganh.Khoa.Ten_khoa == tenkhoa) select new { a.Ma_SV, a.Ten_SV, a.Ngay_sinh, a.Gioi_tinh, Lop = a.Lop1.Lop1, a.Lop1.Nganh.Chuyen_nganh, a.Lop1.Nganh.Khoa.Ten_khoa, a.Dia_chi, a.SĐT, a.Email });
            dataGridView1.DataSource = result.ToList();
            int quyenhan = frmLogin.CHECK;
            if (quyenhan == 1)
                Enablebtn();
            if (quyenhan == 2)
                Disablebtn();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string row = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtMasv.Text = row;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtMasv.Text.Length <= 0)
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
            else
            {
                var db = this.txtMasv.Text;
                frmChitietsv frm = new frmChitietsv(db);
                frm.Show();
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSV frm = new frmAddSV();
            frm.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtMasv.Text.Length <= 0)
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
            else
            {
                var result = MessageBox.Show("Bạn chắc chắn muốn xóa sinh viên này?", "QLDASV", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {

                    var db = this.txtMasv.Text;
                    var maSV = getKhoa.QLDASVs.Where(n => n.Ma_SV == db).SingleOrDefault();
                    if (maSV == null)
                    {
                        if (StudentController.DeleteStudent(db) == false)
                        {
                            MessageBox.Show("Lỗi xóa sinh viên!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa sinh viên thành công!");
                        }
                        this.Close();
                    }
                    else
                    {
                        var maDASV = getKhoa.QLDASVs.Where(n => n.Ma_SV == db).SingleOrDefault().Ma_DASV.Trim();

                        var tiendo = getKhoa.Tien_do.Where(n => n.Ma_DASV == maDASV).SingleOrDefault();

                        if (tiendo != null)
                        {
                            getKhoa.Tien_do.Remove(tiendo);
                            getKhoa.SaveChanges();
                        }
                        
                        {
                            getKhoa.QLDASVs.Remove(maSV);
                            getKhoa.SaveChanges();
                        }

                        if (StudentController.DeleteStudent(db) == false)
                        {
                            MessageBox.Show("Lỗi xóa sinh viên!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa sinh viên thành công!");
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
            this.txtMasv.Visible = true;
        }
        public void Disablebtn()
        {
            this.btnAdd.Visible = false;
            this.btnDelete.Visible = false;
            this.btnEdit.Visible = false;
            this.txtMasv.Visible = false;
        }
    }
}
