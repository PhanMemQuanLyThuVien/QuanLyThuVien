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
            phanQuyenMenu(bLLTaiKhoan.getMaChucVuTaiKhoan(emailNhanVien));
            
        }

        private void phanQuyenMenu(string maChucVu)
        {
            foreach (Control control in panelMenu.Controls)
            {
                if(control is Bunifu.UI.WinForms.BunifuButton.BunifuButton)
                {
                    if(control.Tag.ToString().Equals(maChucVu)
                        && maChucVu.Equals("1"))
                    {
                        btnQLSach.Visible = false;
                        btnQLMuonTra.Visible = false;
                        btnQLDocGia.Visible = false;
                    }else if (control.Tag.ToString().Equals(maChucVu)
                        && maChucVu.Equals("2"))
                    {
                        btnQLTT.Visible = false;
                    }
                }
            }
            addUserControl(new UserControlQLSach(emailNhanVien));
            if (maChucVu.Equals("1"))
            {
                addUserControl(new UserCtrlQuanLyThuThu());
            }
        }

        private void addUserControl(UserControl userCtrl)
        {
            userCtrl.Dock = DockStyle.Fill;
            panelChildFrom.Controls.Clear();
            panelChildFrom.Controls.Add(userCtrl);
        }
        

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch { }
        }

        private void btnQLTT_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLyThuThu());
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            addUserControl(new UserControlQLSach(emailNhanVien));
        }

        private void btnQLMuonTra_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLyMuonTra(emailNhanVien));
        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {
            addUserControl(new UserCtrlQuanLyDocGia());
        }

        private void btnThongTinQT_Click(object sender, EventArgs e)
        {
            frmThongTinBanThan frm = new frmThongTinBanThan(emailNhanVien);
            frm.ShowDialog();
        }


        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            addUserControl(new UserControlGioiThieu());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Visible = false;
            frm.Show();
        }
    }
}
