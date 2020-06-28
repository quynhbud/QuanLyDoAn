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
using System.Runtime.CompilerServices;

namespace qlsv.views
{
    public partial class frmLogin : Form
    {
        public static int CHECK;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdUser_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string quyen;
            if (check()==1)
                quyen = "Admin";
            else if (check() == 2)
                quyen = "Người dùng";
            else
            {
                MessageBox.Show("Vui lòng chọn quyền đăng nhập!");
                return;
            }
            
            if (LoginController.Login(this.txtUser.Text.Trim(), this.txtPassword.Text.Trim(), quyen.Trim()) == true)
            {
                frmMain Main = (frmMain)this.MdiParent;
                Main.EnableMenu();
                if (quyen.Trim() == "Admin")
                    Main.EnableUser();
                else
                    Main.DisableUser();
                CHECK = check();
                MessageBox.Show("Đăng nhập thành công!");
                Main.DisableLogin();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi đăng nhập!");
            }    
        }
        public   int check()
        {
           
            if (this.rdAdmin.Checked == true)
                return 1;
            else if (this.rdUser.Checked == true)
                return 2;
            else
            {
                return 0;
            }
        }
       
    
    }
}
