using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        private string emailNhanVien;
        private BLLTaiKhoan bLLTaiKhoan = new BLLTaiKhoan();
        public frmMain(string emailNV)
        {
            this.emailNhanVien = emailNV;
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            phanQuyenMenu(menuStripQuanLy, bLLTaiKhoan.getMaChucVuTaiKhoan(emailNhanVien));
            addUserControl(new UserCtrlQuanLySach());
        }

        private void phanQuyenMenu(MenuStrip menuStripQL, string maChucVu)
        {
            for (int i = 0; i < menuStripQL.Items.Count; i++)
            {
                //nếu tag == 0 thì tất cả điều có quyền
                if (menuStripQL.Items[i].Tag.Equals("0"))
                    continue;
                if (!menuStripQL.Items[i].Tag.Equals(maChucVu))
                    menuStripQL.Items[i].Visible = false;                
            }
        }

        private void addUserControl(UserControl userCtrl)
        {
            userCtrl.Dock = DockStyle.Fill;            
            pnChucNang.Controls.Clear();
            pnChucNang.Controls.Add(userCtrl);
        }

        private void QuanLyThuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLyThuThu());
        }

        private void QuanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLySach());
        }

        private void QuanLyMuonTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLyMuonTra());
        }

        private void QuanLyDocGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLyDocGia());
        }

        private void ThongTinQuanTriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlThongTinQuanTri());
        }

        private void ThongTinThuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlThongTinThuThu());
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Visible = false;
            frm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
