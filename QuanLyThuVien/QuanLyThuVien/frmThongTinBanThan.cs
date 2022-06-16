using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace QuanLyThuVien
{
    public partial class frmThongTinBanThan : Form
    {
        private BLLNhanVien bLLNhanVien = new BLLNhanVien();
        private string emailNV;
        public frmThongTinBanThan(string emailNV)
        {
            this.emailNV = emailNV;
            InitializeComponent();
        }

        private void frmThongTinBanThan_Load(object sender, EventArgs e)
        {
            loadControl(false);
            loadThuThuVaoControls(bLLNhanVien.timNhanVienTheoID(bLLNhanVien.timIDNhanVien(emailNV)));
        }

        private void loadThuThuVaoControls(NHANVIEN nHANVIEN)
        {
            txtCMND.Text = nHANVIEN.CMND;
            txtDiaChi.Text = nHANVIEN.DIACHI;
            txtEmai.Text = nHANVIEN.EMAIL;
            txtHoTen.Text = nHANVIEN.HOTEN;
            txtSoDT.Text = nHANVIEN.SODT;
            dateTimePickerNgaySinh.Value = (DateTime)nHANVIEN.NGAYSINH;
            dateTimePickerNgayLap.Value = (DateTime)nHANVIEN.NGAYVAOLAM;
            if (nHANVIEN.GIOITINH == true)
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
        }

        private void loadControl(bool visible)
        {
            txtMKCu.Visible = txtMKMoi.Visible = txtNhapLaiMKMoi.Visible
                = lbMKCu.Visible = lbMKMoi.Visible = lbReMKMoi.Visible = btnLuu.Visible = visible;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            loadControl(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thay đổi mật khẩu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                loadControl(false);
                setTextControl(string.Empty);
                return;
            }
            if (!txtMKMoi.Text.Trim().Equals(txtNhapLaiMKMoi.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu mới bạn nhập không giống nhau!","Thông báo");
                return;
            }
            if(!new BLLTaiKhoan().ktDangNhap(emailNV, txtMKCu.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông báo");
                return;
            }
            if(new BLLTaiKhoan().doiMatKhau(emailNV, txtMKMoi.Text))
            {
                loadControl(false);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                setTextControl(string.Empty);
            }
            else { MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo"); }
            
        }

        private void setTextControl(string empty)
        {
            txtMKCu.Text = txtMKMoi.Text = txtNhapLaiMKMoi.Text = empty;
        }
    }
}
