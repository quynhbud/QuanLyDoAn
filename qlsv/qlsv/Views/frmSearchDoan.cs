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
    public partial class frmSearchDoan : Form
    {
        DBDOANWINEntities3 getdoan = new DBDOANWINEntities3();
        public frmSearchDoan()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Length <= 0)
                MessageBox.Show("Vui lòng chọn thông tin đồ án cần xem!");
            else
            {
                string db = this.txtSearch.Text;
                frmChitietdoan frm = new frmChitietdoan(db);
                frm.Show();
                this.Close();
            }
        }
        public int kiemtra()
        {
            if (this.rdMaDA.Checked == true)
                return 1;
            else if (this.rdTenDA.Checked == true)
                return 2;
            else
                return 0;
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
                    MessageBox.Show("Vui lòng chọn tính năng tìm kiếm");
                    return;
                }
                else if (kiemtra() == 1)
                {
                    var db = this.txtSearch.Text;
                    var result = from a in getdoan.QLDAs where a.Ma_ĐA == db select new { a.Ma_ĐA, a.Ten_ĐA, Ten_TL = a.The_Loai1.Ten_TL, Nganh = a.Nganh.Chuyen_nganh, Khoa = a.Nganh.Khoa.Ten_khoa };
                    if (result.ToList().Count <= 0)
                    {
                        MessageBox.Show("Không có thông tin đồ án cần tìm kiếm!");
                        
                    }
                    else
                        this.dataGridView1.DataSource = result.ToList();
                    this.txtSearch.Clear();
                }
                else if (kiemtra() == 2)
                {
                    var db = this.txtSearch.Text;
                    var result = from a in getdoan.QLDAs where a.Ten_ĐA == db select new { a.Ma_ĐA, a.Ten_ĐA, Ten_TL = a.The_Loai1.Ten_TL, Nganh = a.Nganh.Chuyen_nganh, Khoa = a.Nganh.Khoa.Ten_khoa };
                    if (result.ToList().Count <= 0)
                    {
                        MessageBox.Show("Không có thông tin đồ án cần tìm kiếm!");
                        return;
                    }
                    else
                        this.dataGridView1.DataSource = result.ToList();
                    this.txtSearch.Clear();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string row = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtSearch.Text = row;
        }
    }
}
