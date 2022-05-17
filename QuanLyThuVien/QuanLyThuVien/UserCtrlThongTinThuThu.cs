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
using System.IO;

namespace QuanLyThuVien
{
    public partial class UserCtrlThongTinThuThu : UserControl
    {
        BLLNhanVien bLLNhanVien = new BLLNhanVien();

        public UserCtrlThongTinThuThu()
        {
            InitializeComponent();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            loadNhanVien();
        }

        private void UserCtrlThongTinThuThu_Load(object sender, EventArgs e)
        {
            loadNhanVien();
        }
        private void anCotKhongCanThiet()
        {
            //ẩn những cột không cần thiết
            dagirdDanhSachThuThu.Columns["TAIKHOAN"].Visible = false;
            dagirdDanhSachThuThu.Columns["GIOITINH"].Visible = false;
        }

        public void loadNhanVien()
        {
            dagirdDanhSachThuThu.DataSource = new BLLNhanVien().lstNhanVien();
            anCotKhongCanThiet();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Length == 0)
            {
                txtTim.Focus();
                return;
            }
            try
            {
                NHANVIEN nhanVien = bLLNhanVien.nhanVienTheoID(int.Parse(txtTim.Text));
                if (nhanVien == null)
                {
                    txtTim.Focus();
                    MessageBox.Show("Không tìm thấy nhân viên có id " + txtTim.Text + ".\nVui lòng nhập lại!", "Thông báo");
                    return;
                }

                dagirdDanhSachThuThu.DataSource = new List<NHANVIEN>() { nhanVien };
                anCotKhongCanThiet();
            }
            catch
            {
                txtTim.Focus();
                MessageBox.Show("Vui lòng nhập mã số độc giả!", "Thông báo");
            }
        }

        private void btnThemThuThu_Click(object sender, EventArgs e)
        {
            if (!ktNhap())
                return;
            NHANVIEN nv = new NHANVIEN();
            nv.HOTEN = txtHoTenNV.Text;
            nv.NGAYSINH = dateTimePickerNgaySinh.Value;
            nv.GIOITINH = rdoNam.Checked;
            nv.EMAIL = txtEmai.Text;
            nv.SODT = txtSoDT.Text;
            nv.CMND = txtCMND.Text;
            nv.DIACHI = txtDiaChi.Text;
            nv.NGAYVAOLAM = dateTimePickerNVL.Value;
            if (bLLNhanVien.themNhanVien(nv))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            else
                MessageBox.Show("Thêm thất bại!", "Thông báo");
            loadNhanVien();
        }
        private bool ktNhap()
        {
            if (txtHoTenNV.Text.Trim().Length == 0)
            {
                txtHoTenNV.Focus();
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
        private void btnXemChiTietThuThu_Click(object sender, EventArgs e)
        {
            if (dagirdDanhSachThuThu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả để xem chi tiết!", "Thông báo");
                return;
            }
            frmChiTietNhanVien frmChiTietNV = new frmChiTietNhanVien(this, int.Parse(dagirdDanhSachThuThu.CurrentRow.Cells["ID"].Value.ToString()));
            frmChiTietNV.ShowDialog();
        }
    }
}
