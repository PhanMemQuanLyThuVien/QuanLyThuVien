using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        private frmLogin frmlogin;
        private string emailNhanVien;
        public frmMain(frmLogin frmlogin, string emailNV)
        {
            this.frmlogin = frmlogin;
            this.emailNhanVien = emailNV;
            InitializeComponent();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLySach());
        }

        private void btnQuanLyMuonTra_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLyMuonTra());
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLyDocGia());
        }

        private void btnThongTinQuanTri_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlThongTinQuanTri());
        }

        private void btnThongTinThuThu_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlThongTinThuThu());
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLyNhanVien());
        }

        private void addUserControl(UserControl userCtrl)
        {
            userCtrl.Dock = DockStyle.Fill;
            pnChucNang.Controls.Clear();
            pnChucNang.Controls.Add(userCtrl);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmlogin.Close();
        }
    }
}
