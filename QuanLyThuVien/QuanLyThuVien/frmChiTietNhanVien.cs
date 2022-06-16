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
using DTO;

namespace QuanLyThuVien
{
    public partial class frmChiTietNhanVien : Form
    {
        BLLNhanVien bLLNhanVien = new BLLNhanVien();
        private UserCtrlQuanLyThuThu userCtrlQuanLyThuThu;
        private int maTT;
        public frmChiTietNhanVien(UserCtrlQuanLyThuThu userCtrlQuanLyThuThu, int maTT)
        {
            this.maTT = maTT;
            this.userCtrlQuanLyThuThu = userCtrlQuanLyThuThu;
            InitializeComponent();
        }

        private void frmChiTietNhanVien_Load(object sender, EventArgs e)
        {
            enabledControl(false);
            
            loadThuThuVaoControls(bLLNhanVien.timNhanVienTheoID(maTT));
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

            if (nHANVIEN.tinhTrangHoatDong.Trim().Equals("Ngừng hoạt động"))
                btnNgung.Text = "Hoạt Động";
        }

        private void enabledControl(bool enabled)
        {
            txtCMND.Enabled = txtDiaChi.Enabled = enabled;
            txtHoTen.Enabled = txtSoDT.Enabled = enabled;
            dateTimePickerNgayLap.Enabled = dateTimePickerNgaySinh.Enabled = enabled;
            rdoNam.Enabled = rdoNu.Enabled = enabled;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enabledControl(true);
        }

        private void btnNgung_Click(object sender, EventArgs e)
        {
            if (btnNgung.Text == "Hoạt Động")
            {
                if (bLLNhanVien.hoatDongNhanVien(bLLNhanVien.timNhanVienTheoID(maTT).EMAIL))
                {
                    MessageBox.Show("Thành Công!", "Thông báo");
                    userCtrlQuanLyThuThu.loadTatCaNhanVien();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông báo");
                }
            }
            else
            {
                if (bLLNhanVien.ngungHoatDongNhanVien(bLLNhanVien.timNhanVienTheoID(maTT).EMAIL))
                {
                    MessageBox.Show("Thành Công!", "Thông báo");
                    userCtrlQuanLyThuThu.loadTatCaNhanVien();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông báo");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.ID = maTT;
            nv.HOTEN = txtHoTen.Text;
            nv.NGAYSINH = dateTimePickerNgaySinh.Value;
            nv.SODT = txtSoDT.Text;
            nv.GIOITINH = rdoNam.Checked;
            nv.NGAYVAOLAM = dateTimePickerNgayLap.Value;
            nv.DIACHI = txtDiaChi.Text;
            nv.CMND = txtCMND.Text;

            if (new BLLNhanVien().capNhatNV(nv))
            {
                MessageBox.Show("Thành công!");
                userCtrlQuanLyThuThu.loadTatCaNhanVien();
                this.Visible = false;
            }
            else { MessageBox.Show("Thất bại!"); }
        }

        private void dateTimePickerNgayLap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnNhapTT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void lbSDT_Click(object sender, EventArgs e)
        {

        }

        private void lbCMND_Click(object sender, EventArgs e)
        {

        }

        private void lbNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lbHoTen_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
