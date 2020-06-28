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
    public partial class frmAdduser : Form
    {
        DBDOANWINEntities3 getuser = new DBDOANWINEntities3();
        public frmAdduser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdduser_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtUsername, "Vui lòng nhập tên đăng nhập");
                return;
            }
            else if (LoginController.Getaccount(this.txtUsername.Text.Trim()) != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
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


            QLUser acc = new QLUser();

            acc.Ten_dang_nhap = this.txtUsername.Text.Trim();
            acc.Mat_khau = this.txtPass.Text.Trim();
            acc.Quyen_han = this.cbQuyen.Text.Trim();


            if (LoginController.AddAccount(acc) == false)
            {
                MessageBox.Show("lỗi thêm tài khoản!");
                return;
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thành công");
                this.Close();
            }

        }
    }
}
