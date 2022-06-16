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
                    userCtrlQuanLyDocGia.loadDocGia();
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
            DOCGIA dg = new DOCGIA();
            dg.IDMASOTHE = maSoThe;
            dg.HOTEN = txtHoTenDG.Text;
            dg.NGAYSINH = dateTimePickerNgaySinh.Value;
            dg.SODT = txtSoDT.Text;
            dg.EMAIL = txtEmai.Text;
            dg.IDDONVI = int.Parse(cboDonVi.SelectedValue.ToString());
            dg.GIOITINH = rdoNam.Checked;
            dg.NGAYLAP = dateTimePickerNgayLap.Value;
            dg.HANSUDUNG = dateTimePickerNgayHetHan.Value;
            dg.DIACHI = txtDiaChi.Text;
            dg.CMND = txtCMND.Text;
            dg.HINHANH = nameImageDocGia;
            if (bLLDocGia.capNhatDocGia(dg))
            {
                userCtrlQuanLyDocGia.loadDocGia();
                enabledControl(false);
                MessageBox.Show("Lưu thành công!", "Thông báo");
                try
                {
                    string duongDanLuuHinh = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\QuanLyThuVien\\Images\\" + nameImageDocGia;
                    File.Copy(pathImage, duongDanLuuHinh, true);
                }
                catch { }
            }
            else
                MessageBox.Show("Lưu thất bại!", "Thông báo");
            
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
            nameImageDocGia = dOCGIA.HINHANH;
            pathImage = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\QuanLyThuVien\\Images\\" + nameImageDocGia;
            //hiện hình ảnh lên pic
            try
            {
                picAnhDG.Image = Image.FromFile(pathImage);
            }
            catch { }
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
            btnChonHinh.Enabled = rdoNam.Enabled = rdoNu.Enabled = cboDonVi.Enabled = enabled;
        }

        string nameImageDocGia = string.Empty;
        string pathImage = string.Empty;
        private void btnChonHinhDG_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;)|*.jpg;*.jpge;", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] duongDanHinh = ofd.FileName.ToString().Split('\\');
                    nameImageDocGia = duongDanHinh[duongDanHinh.Length - 1];
                    pathImage = ofd.FileName;
                    //hiện hình ảnh lên pic
                    picAnhDG.Image = Image.FromFile(pathImage);
                }
            }
        }

        private void dateTimePickerNgayHetHan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgayLap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbMaSoThe_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSoThe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnNhapTT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbDonVi_Click(object sender, EventArgs e)
        {

        }

        private void lbGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void cboDonVi_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtHoTenDG_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picAnhDG_Click(object sender, EventArgs e)
        {

        }
    }
}
