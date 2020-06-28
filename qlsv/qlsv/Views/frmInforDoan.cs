using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using qlsv.Models;
using qlsv.Controllers;

namespace qlsv.views
{
    public partial class frmInforDoan : Form
    {
        string TenTL;
        string TenNganh;
        DBDOANWINEntities3 getKhoa = new DBDOANWINEntities3();
        public frmInforDoan(string Nganh, string TL)
        {
            TenTL=TL;
            TenNganh = Nganh;
            InitializeComponent();
        }

        private void frmInforDoan_Load(object sender, EventArgs e)
        {
            var result = from a in getKhoa.QLDAs where a.The_Loai1.Ten_TL == TenTL && a.Nganh.Chuyen_nganh == TenNganh select new { a.Ma_ĐA, a.Ten_ĐA, Ten_TL = a.The_Loai1.Ten_TL, Nganh = a.Nganh.Chuyen_nganh, Khoa = a.Nganh.Khoa.Ten_khoa };

            //var result = from a in getKhoa.QLDAs where a.The_loai == maTL && a.chuyen_nganh==maNganh select a;
            dataGridView1.DataSource = result.ToList();
            //dataGridView1.Columns["QLDASVs"].Visible = false;

            //frmLogin login = new frmLogin();

            int quyenhan = frmLogin.CHECK;
            if (quyenhan == 1)
                Enablebtn();
            if (quyenhan == 2)
                Disablebtn();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddDa frm = new frmAddDa();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string row = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtMada.Text = row;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtMada.Text.Length <= 0)
                MessageBox.Show("Vui lòng chọn đồ án cần sửa!");
            else
            {
                var db = this.txtMada.Text;
                frmChitietdoan frm = new frmChitietdoan(db);
                frm.Show();
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtMada.Text.Length <= 0)
                MessageBox.Show("Vui lòng chọn đồ án cần xóa!");
            else
            {
                var result = MessageBox.Show("Bạn chắc chắn muốn xóa đồ án này?", "QLDASV", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    QLDASV DASV = new QLDASV();
                    var db = this.txtMada.Text;
                    var maDA = getKhoa.QLDASVs.Where(n => n.Ma_DA == db).SingleOrDefault();
                    if (maDA == null)
                    {
                        if (ProjectController.DeleteProject(db) == false)
                        {
                            MessageBox.Show("Lỗi xóa đồ án!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa đồ án thành công!");
                        }
                        this.Close();
                    }
                    else
                    {
                        var maDASV = getKhoa.QLDASVs.Where(n => n.Ma_DA == db).SingleOrDefault().Ma_DASV.Trim();
                        var tiendo = getKhoa.Tien_do.Where(n => n.Ma_DASV == maDASV).SingleOrDefault();
                        if (tiendo != null)
                        {
                            getKhoa.Tien_do.Remove(tiendo);
                            getKhoa.SaveChanges();
                        }

                        if (maDA != null)
                        {
                            getKhoa.QLDASVs.Remove(maDA);
                            getKhoa.SaveChanges();
                        }

                        if (ProjectController.DeleteProject(db) == false)
                        {
                            MessageBox.Show("Lỗi xóa đồ án!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa đồ án thành công!");
                        }
                        this.Close();
                    }
                }
            }

        }
        public void Enablebtn()
        {
            this.btnAdd.Visible= true;
            this.btnDelete.Visible = true;
            this.btnEdit.Visible = true;
            this.txtMada.Visible = true;
        }
        public void Disablebtn()
        {
            this.btnAdd.Visible = false;
            this.btnDelete.Visible = false;
            this.btnEdit.Visible = false;
            this.txtMada.Visible = false;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
