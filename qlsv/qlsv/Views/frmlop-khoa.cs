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
    public partial class frmlop_khoa : Form
    {
        DBDOANWINEntities3 getKhoa = new DBDOANWINEntities3();
        public frmlop_khoa()
        {
           
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDSSV_Click(object sender, EventArgs e)
        {
            var db1 = this.cbKhoa.Text;
            var db = this.cbLop.Text;
            frmInforStudent frm = new frmInforStudent(db,db1);
            frm.Show();
        }

        private void frmlop_khoa_Load(object sender, EventArgs e)
        {
            var result = from a in getKhoa.Khoas select new { a.Ten_khoa };
            this.cbKhoa.DataSource = result.ToList();
            this.cbKhoa.ValueMember = "Ten_khoa";
        }
        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = this.cbKhoa.Text;
            var result = (from a in getKhoa.QLSVs where a.Lop1.Nganh.Khoa.Ten_khoa == db select new  { Lop = a.Lop1.Lop1 }).Distinct();
            this.cbLop.DataSource = result.ToList();
            this.cbLop.ValueMember = "Lop";
        }
    }
}
