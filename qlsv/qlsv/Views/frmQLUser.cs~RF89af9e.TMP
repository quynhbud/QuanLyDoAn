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
    public partial class frmQLUser : Form
    {
        DBDOANWINEntities3 getuser = new DBDOANWINEntities3();
        public frmQLUser()
        {
            InitializeComponent();
        }

        private void frmQLUser_Load(object sender, EventArgs e)
        {
            var result = from a in getuser.QLUsers  select a;
            dataGridView1.DataSource = result.ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdduser frm = new frmAdduser();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (this.txtTenuser.Text.Length <= 0)
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!");
            else
            {
                var db = this.txtTenuser.Text;
                frmSuaUser frm = new frmSuaUser(db);
                frm.Show();
                this.txtTenuser.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string row = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtTenuser.Text = row;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtTenuser.Text.Length <= 0)
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
            else
            {
                var result = MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này?", "QLDASV", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    var db = this.txtTenuser.Text;
                    if (LoginController.DeleteAccount(db) == false)
                    {
                        MessageBox.Show("Lỗi xóa tài khoản!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thành công!");
                    }
                    this.Close();
                }    
            }
        }
    }
}
