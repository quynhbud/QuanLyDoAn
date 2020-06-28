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
    public partial class frmDaSV : Form
    {
        DBDOANWINEntities3 getdoan = new DBDOANWINEntities3();
        public frmDaSV()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }
            else
            {
                if (kiemtra() == 0)
                {
                    MessageBox.Show("Vui lòng chọn chức năng tìm kiếm");
                }
                if (kiemtra() == 1)
                {
                    var db = txtSearch.Text;
                    var result = from a in getdoan.QLDASVs where a.Ma_DA == db select  new { a.Ma_SV, a.Ten_SV, a.Ma_GV, a.Ten_GV, a.Ma_DA, a.Ten_DA };
                    if (result.ToList().Count <= 0)
                    {
                        MessageBox.Show("Không có thông tin đồ án cần tìm kiếm!");
                        return;
                    }
                    else
                    {
                        dataGridView1.DataSource = result.ToList();
                    }
                }
                else if (kiemtra() == 2)
                {
                    var db = txtSearch.Text;
                    var result = from a in getdoan.QLDASVs where a.Ma_SV == db select  new { a.Ma_SV, a.Ten_SV, a.Ma_GV, a.Ten_GV, a.Ma_DA, a.Ten_DA };
                    if (result.ToList().Count <= 0)
                    {
                        MessageBox.Show("Không có thông tin đồ án cần tìm kiếm!");
                        return;
                    }
                    else
                    {
                        dataGridView1.DataSource = result.ToList();
                    }
                }
                else if (kiemtra() == 3)
                {
                    var db = txtSearch.Text;
                    var result = from a in getdoan.QLDASVs where a.Ma_GV == db  select new { a.Ma_SV, a.Ten_SV, a.Ma_GV, a.Ten_GV, a.Ma_DA, a.Ten_DA };
                    if (result.ToList().Count <= 0)
                    {
                        MessageBox.Show("Không có thông tin đồ án cần tìm kiếm!");
                        return;
                    }
                    else
                    {
                        dataGridView1.DataSource = result.ToList();

                    }

                }
            }
        }

        private void frmDaSV_Load(object sender, EventArgs e)
        {
            var result = from a in getdoan.QLDASVs select new { a.Ma_DASV,a.Ma_DA, a.Ten_DA, a.Ma_SV, a.Ten_SV, a.Ma_GV, a.Ten_GV};
            //var result = from a in getdoan.QLDASVs select new { a.Ma_SV, a.Ho_va_Ten, a.Ma_GV,Ten_GV=a.GV_huong_dan,a.Ma_do_an,a.Ten_do_an,a.The_loai};
            dataGridView1.DataSource = result.ToList();
            int quyenhan = frmLogin.CHECK;
            if (quyenhan == 1)
                Enablebtn();
            if (quyenhan == 2)
                Disablebtn();
        }
        public int kiemtra()
        {
            if (rdMaDA.Checked == true)
                return 1;
            else if (rdMaSV.Checked == true)
                return 2;
            else if (rdMAGV.Checked == true)
                return 3;
            else
                return 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string row = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtSearch.Text = row;
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Length <= 0)
                MessageBox.Show("Vui lòng chọn thông tin cần xem!");
            else
            {
                var db = this.txtSearch.Text;
                frmSearchDaSv frm = new frmSearchDaSv(db);
                frm.Show();
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length <= 0)
            {
                var result = from a in getdoan.QLDASVs select new { a.Ma_DASV, a.Ma_DA, a.Ten_DA, a.Ma_SV, a.Ten_SV, a.Ma_GV, a.Ten_GV };
                dataGridView1.DataSource = result.ToList();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddDoanSV frm = new frmAddDoanSV();
            frm.Show();
            this.Close();
        }
        public void Enablebtn()
        {
            this.btnThem.Visible = true;
        
        }
        public void Disablebtn()
        {
            this.btnThem.Visible = false;
       
        }
    }
}
