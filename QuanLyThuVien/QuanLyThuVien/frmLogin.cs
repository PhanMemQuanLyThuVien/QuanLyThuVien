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
    public partial class frmLogin : Form
    {
        BLLTaiKhoan bLLTaiKhoan = new BLLTaiKhoan();
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!bLLTaiKhoan.ktDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                frmMain frm = new frmMain(txtTaiKhoan.Text);
                this.Hide();
                frm.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
