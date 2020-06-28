using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlsv.Models;
using qlsv.Controllers;


namespace qlsv.views
{
    public partial class frmKhoa_Nganh_Theloai : Form
    {
        DBDOANWINEntities3 getKhoa = new DBDOANWINEntities3();
        public frmKhoa_Nganh_Theloai()
        {
            InitializeComponent();
       
        }

        private void btnDSDA_Click(object sender, EventArgs e)
        {
            var db = this.cbNganh.Text;
            var db1 = this.cbTheloai.Text;
            frmInforDoan frm = new frmInforDoan(db,db1);
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbKhoa.Text;
            var result = from a in getKhoa.Nganhs where a.Khoa.Ten_khoa == db select new { nganh = a.Chuyen_nganh };
            this.cbNganh.DataSource = result.ToList();
            this.cbNganh.ValueMember = "nganh";
        }

        private void frmKhoa_Nganh_Theloai_Load(object sender, EventArgs e)
        {
            var result = from a in getKhoa.Khoas select new { a.Ten_khoa };
            this.cbKhoa.DataSource = result.ToList();
            this.cbKhoa.ValueMember = "Ten_khoa";
        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbNganh.Text;
            var result = (from a in getKhoa.QLDAs where a.Nganh.Chuyen_nganh == db select new { TL = a.The_Loai1.Ten_TL }).Distinct();
            this.cbTheloai.DataSource = result.ToList();
            this.cbTheloai.ValueMember = "TL";
        }
    }
}
