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
    public partial class frmChiTietDocGia : Form
    {
        BLLDonVi bLLDonVi = new BLLDonVi();
        BLLDocGia bLLDocGia = new BLLDocGia();
        private int maSoThe;
        UserCtrlQuanLyDocGia userCtrlQuanLyDocGia;
        public frmChiTietDocGia(UserCtrlQuanLyDocGia userCtrlQuanLyDocGia, int maSoThe)
        {
            this.maSoThe = maSoThe;
            this.userCtrlQuanLyDocGia = userCtrlQuanLyDocGia;
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa độc giả " + txtHoTenDG.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bLLDocGia.xoaDocGia(maSoThe))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    userCtrlQuanLyDocGia.loadDocGia();
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
            enabledControl(false);
        }

        private void frmChiTietDocGia_Load(object sender, EventArgs e)
        {
            enabledControl(false);

            cboDonVi.DataSource = bLLDonVi.lstDonVi();
            cboDonVi.ValueMember = "ID";
            cboDonVi.DisplayMember = "TENDONVI";

            loadDocGiaVaoControls(bLLDocGia.docGiaTheoMa(maSoThe));
        }

        private void loadDocGiaVaoControls(DOCGIA dOCGIA)
        {
            txtCMND.Text = dOCGIA.CMND;
            txtDiaChi.Text = dOCGIA.DIACHI;
            txtEmai.Text = dOCGIA.EMAIL;
            txtHoTenDG.Text = dOCGIA.HOTEN;
            txtMaSoThe.Text = dOCGIA.IDMASOTHE.ToString();
            txtSoDT.Text = dOCGIA.SODT;
            dateTimePickerNgaySinh.Value = (DateTime)dOCGIA.NGAYSINH;
            dateTimePickerNgayLap.Value = (DateTime)dOCGIA.NGAYLAP;
            dateTimePickerNgayHetHan.Value = (DateTime)dOCGIA.HANSUDUNG;
            if (dOCGIA.GIOITINH == true)
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            cboDonVi.SelectedValue = dOCGIA.IDDONVI;
        }

        private void enabledControl(bool enabled)
        {
            txtCMND.Enabled = txtDiaChi.Enabled = txtEmai.Enabled = enabled;
            txtHoTenDG.Enabled = txtSoDT.Enabled = enabled;
            dateTimePickerNgayHetHan.Enabled = dateTimePickerNgayLap.Enabled = dateTimePickerNgaySinh.Enabled= enabled;
            btnChonHinhDG.Enabled = rdoNam.Enabled = rdoNu.Enabled = cboDonVi.Enabled = enabled;
        }
    }
}
