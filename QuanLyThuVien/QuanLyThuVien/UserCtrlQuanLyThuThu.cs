using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace QuanLyThuVien
{
    public partial class UserCtrlQuanLyThuThu : UserControl
    {
        private BLLNhanVien bLLNhanVien = new BLLNhanVien();
        public UserCtrlQuanLyThuThu()
        {
            InitializeComponent();
        }

        private void btnLoadALL_Click(object sender, EventArgs e)
        {
            loadTatCaNhanVien();
        }

        private void UserCtrlQuanLyThuThu_Load(object sender, EventArgs e)
        {
            loadTatCaNhanVien();
        }

        public void loadTatCaNhanVien()
        {
            try
            {
                dagirdDanhSachNhanVien.DataSource = new BLLNhanVien().lstNhanVien();
                dagirdDanhSachNhanVien.Columns["GIOITINH"].Visible = false;
            }
            catch { }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên!","Thông báo");
                return;
            }

            try
            {
                dagirdDanhSachNhanVien.DataSource = new BLLNhanVien().lstNhanVien_TheoSDT(txtTim.Text.Trim());
                dagirdDanhSachNhanVien.Columns["GIOITINH"].Visible = false;
            }
            catch { }
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dagirdDanhSachNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xem chi tiết!", "Thông báo");
                return;
            }
            frmChiTietNhanVien frmChiTiet = new frmChiTietNhanVien(this, int.Parse(dagirdDanhSachNhanVien.CurrentRow.Cells["MaNV"].Value.ToString()));
            frmChiTiet.ShowDialog();
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ktNhap())
                return;
            NHANVIEN nv = new NHANVIEN();
            nv.HOTEN = txtHoTen.Text;
            nv.NGAYSINH = dateTimePickerNgaySinh.Value;
            nv.SODT = txtSoDT.Text;
            nv.GIOITINH = rdoNam.Checked;
            nv.EMAIL = txtEmai.Text;
            nv.NGAYVAOLAM = dateTimePickerNgayVaoLam.Value;
            nv.DIACHI = txtDiaChi.Text;
            nv.CMND = txtCMND.Text;

            if (bLLNhanVien.themNhanVien(nv))
            {
                MessageBox.Show("Thêm thành công!");

            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private bool ktNhap()
        {
            if (txtHoTen.Text.Trim().Length == 0)
            {
                txtHoTen.Focus();
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo");
                return false;
            }
            if (txtCMND.Text.Trim().Length == 0)
            {
                txtCMND.Focus();
                MessageBox.Show("Vui lòng nhập CMND!", "Thông báo");
                return false;
            }
            if (txtSoDT.Text.Trim().Length == 0)
            {
                txtSoDT.Focus();
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
                return false;
            }
            if (txtEmai.Text.Trim().Length == 0)
            {
                txtEmai.Focus();
                MessageBox.Show("Vui lòng nhập email!", "Thông báo");
                return false;
            }
            if (!txtEmai.kiemTraEmail())
            {
                txtEmai.Focus();
                MessageBox.Show("Email không hợp lệ!", "Thông báo");
                return false;
            }
            return true;
        }
    }
}
