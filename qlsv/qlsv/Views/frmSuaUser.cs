using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlsv.Controllers;
using qlsv.Models;

namespace qlsv.views
{
    public partial class frmSuaUser : Form
    {
        string ten;
        DBDOANWINEntities3 getuser = new DBDOANWINEntities3();
        public frmSuaUser(string User)
        {
            ten = User;
            InitializeComponent();
        }

        private void frmSuaUser_Load(object sender, EventArgs e)
        {
            this.txtTenuser.Text = ten.Trim();
            var db = this.txtTenuser.Text;
            var result = (from a in getuser.QLUsers where a.Ten_dang_nhap== db select a);
            foreach (var row in result)
            {
                this.txtPass.Text = row.Mat_khau;
                this.cbQuyen.Text = row.Quyen_han;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtTenuser.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtTenuser, "Vui lòng nhập tên đăng nhập");
                return;
            }          
            else this.errorProvider1.Clear();

            if (this.txtPass.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtPass, "Vui lòng nhập mật khẩu");
                return;
            }
            else this.errorProvider1.Clear();

            if (this.cbQuyen.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.cbQuyen, "Vui lòng chọn quyền hạn");
                return;
            }
            else this.errorProvider1.Clear();


            QLUser user = new QLUser();

            user.Ten_dang_nhap = this.txtTenuser.Text.Trim();
            user.Mat_khau = this.txtPass.Text.Trim();
            user.Quyen_han = this.cbQuyen.Text.Trim();

            if (LoginController.UpdateAccout(user) == false)
            {
                MessageBox.Show("lỗi sửa User!");
                return;
            }
            else
            {
                MessageBox.Show("Sửa user thành công");
                this.Close();
            }
        }
    }
}
