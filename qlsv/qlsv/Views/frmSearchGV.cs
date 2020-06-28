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
    
    public partial class frmSearchGV : Form
    {
        DBDOANWINEntities3 getgv = new DBDOANWINEntities3();
        public frmSearchGV()
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
                MessageBox.Show("Vui lòng chọn thông tin giảng viên cần xem!");
            else
            {
                string db = this.txtSearch.Text;
                frmChitietGV frm = new frmChitietGV(db);
                frm.Show();
                this.Close();
            }
        }
        public int kiemtra()
        {
            if (this.rdMaGV.Checked == true)
                return 1;
            else if (this.rdTenGV.Checked == true)
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
                    var result = from a in getgv.QLGVs where a.Ma_GV == db select new { a.Ma_GV, a.Ten_GV, a.Gioi_tinh, a.Ngay_sinh, nganh = a.Nganh1.Chuyen_nganh, Khoa = a.Nganh1.Khoa.Ten_khoa, a.Dia_chi, a.SĐT, a.Email };
                    if (result.ToList().Count <= 0)
                    {
                        MessageBox.Show("Không có thông tin giảng viên cần tìm kiếm!");
                        
                    }
                    else
                        this.dataGridView1.DataSource = result.ToList();
                    this.txtSearch.Clear();
                }
                else if (kiemtra() == 2)
                {
                    var db = this.txtSearch.Text;
                    var result = from a in getgv.QLGVs where a.Ten_GV== db select new { a.Ma_GV, a.Ten_GV, a.Gioi_tinh, a.Ngay_sinh, nganh = a.Nganh1.Chuyen_nganh, Khoa = a.Nganh1.Khoa.Ten_khoa, a.Dia_chi, a.SĐT, a.Email };
                    if (result.ToList().Count <= 0)
                    {
                        MessageBox.Show("Không có thông tin giảng viên cần tìm kiếm!");
                        
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
