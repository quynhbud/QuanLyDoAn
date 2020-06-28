using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlsv.views
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;


        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void QlUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLUser frm = new frmQLUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmabout frm = new frmabout();
            frm.MdiParent = this;
            frm.Show();
        }

        private void InforStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlop_khoa frm = new frmlop_khoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void InforteacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa_Nganh_Bomon frm = new frmKhoa_Nganh_Bomon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void InforProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa_Nganh_Theloai frm = new frmKhoa_Nganh_Theloai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SearchStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchSV frm = new frmSearchSV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SearchTeacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchGV frm = new frmSearchGV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SearchProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchDoan frm = new frmSearchDoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void StudentProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDaSV frm = new frmDaSV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

       
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.DisableMenu();
            this.DisableUser();
            this.EnableLogin();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void EnableMenu()
        {
            this.inforToolStripMenuItem.Enabled = true;
            this.SearchToolStripMenuItem.Enabled = true;
            this.StudentProjectToolStripMenuItem.Enabled = true;
            //this.QlUserToolStripMenuItem.Enabled = true;
        }
        public void DisableMenu()
        {
            this.inforToolStripMenuItem.Enabled = false;
            this.SearchToolStripMenuItem.Enabled = false;
            this.StudentProjectToolStripMenuItem.Enabled = false;
            //this.QlUserToolStripMenuItem.Enabled = true;
        }
        public void DisableUser()
        {
            this.QlUserToolStripMenuItem.Enabled = false;
        }
        public void EnableUser()
        {
            this.QlUserToolStripMenuItem.Enabled = true;
            
        }
        public void DisableLogin()
        {
            this.LoginToolStripMenuItem.Enabled = false;
            this.LogoutToolStripMenuItem.Enabled = true;
        }
        public void EnableLogin()
        {
            this.LoginToolStripMenuItem.Enabled = true;
            this.LogoutToolStripMenuItem.Enabled = false;
        }
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DisableMenu();
            this.EnableLogin();
            this.DisableUser();
            MessageBox.Show("Đăng xuất thành công!");
        }
    }
}
