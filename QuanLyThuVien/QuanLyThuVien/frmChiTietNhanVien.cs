using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int id;
        UserCtrlThongTinThuThu userCtrlThongTinThuThu;
        public frmChiTietNhanVien(UserCtrlThongTinThuThu userCtrlThongTinThuThu, int id)
        {
            this.id = id;
            this.userCtrlThongTinThuThu = userCtrlThongTinThuThu;
            InitializeComponent();
        }

        private void frmChiTietNhanVien_Load(object sender, EventArgs e)
        {
            enabledControl(false);

            loadNhanVienVaoControls(bLLNhanVien.nhanVienTheoID(id));
        }
        private void loadNhanVienVaoControls(NHANVIEN nHANVIEN)
        {
            txtID.Text = nHANVIEN.ID.ToString();
            txtHoTenNV.Text = nHANVIEN.HOTEN;
            dateTimePickerNgaySinh.Value = (DateTime)nHANVIEN.NGAYSINH;
            if (nHANVIEN.GIOITINH == true)
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            txtEmai.Text = nHANVIEN.EMAIL;
            txtSoDT.Text = nHANVIEN.SODT;
            txtCMND.Text = nHANVIEN.CMND;
            txtDiaChi.Text = nHANVIEN.DIACHI;
            dateTimePickerNVL.Value = (DateTime)nHANVIEN.NGAYVAOLAM;
        }

        private void enabledControl(bool enabled)
        {
            txtCMND.Enabled = txtDiaChi.Enabled = txtEmai.Enabled = enabled;
            txtSoDT.Enabled = txtSoDT.Enabled = enabled;
            dateTimePickerNVL.Enabled = dateTimePickerNgaySinh.Enabled = enabled;
            rdoNam.Enabled = rdoNu.Enabled = enabled;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên " + txtHoTenNV.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bLLNhanVien.xoaNhanVien(id))
                {
                    userCtrlThongTinThuThu.loadNhanVien();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    this.Close();
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enabledControl(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.ID = id;
            nv.HOTEN = txtHoTenNV.Text;
            nv.NGAYSINH = dateTimePickerNgaySinh.Value;
            nv.GIOITINH = rdoNam.Checked;
            nv.EMAIL = txtEmai.Text;
            nv.SODT = txtSoDT.Text;
            nv.CMND = txtCMND.Text;
            nv.DIACHI = txtDiaChi.Text;
            nv.NGAYVAOLAM = dateTimePickerNVL.Value;
            if (bLLNhanVien.capNhatNhanVien(nv))
            {
                userCtrlThongTinThuThu.loadNhanVien();
                enabledControl(false);
                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
            else
                MessageBox.Show("Lưu thất bại!", "Thông báo");
        }
    }
}
