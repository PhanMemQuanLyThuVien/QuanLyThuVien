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
    public partial class UserCtrlQuanLySach : UserControl
    {
        BLLSach bLLSach = new BLLSach();
        BLLXuLy bLLXuLy = new BLLXuLy();
        private string emailNhanVien;
        public UserCtrlQuanLySach(string emailNhanVien)
        {
            this.emailNhanVien = emailNhanVien;
            InitializeComponent();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            loadSachs();
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
                List<SACH> sACHes = bLLSach.timSachTheoTen(txtTim.Text);
                if (sACHes.Count == 0)
                    MessageBox.Show("Không tìm thấy sách có tên " + txtTim.Text,"Thông báo");
                else
                {
                    dagirdDanhSachSach.DataSource = sACHes;
                    anCotKhongCanThiet();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {

        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {

        }

        private void btnChonHinhSach_Click(object sender, EventArgs e)
        {
            bLLXuLy.chonHinh();
            try
            {
                picAnhSach.Image = Image.FromFile(bLLXuLy.pathImage);
            }
            catch { }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (!ktNhap())
                return;
            SACH S = new SACH();
            S.TENSACH = txtTenSach.Text;
            S.IDNXB = int.Parse(cboNXB.SelectedValue.ToString());
            S.IDTACGIA = int.Parse(cboTacGia.SelectedValue.ToString());
            S.IDTHELOAI = int.Parse(cboTacGia.SelectedValue.ToString());
            S.SOLUONGSACH = int.Parse(txtSoLuong.Text);
            S.GIA = double.Parse(txtGia.Text);
            S.NAMXB = int.Parse(txtNamXB.Text);
            S.VITRISACH = txtViTri.Text;
            S.HINHSACH = bLLXuLy.nameImage;
            if (ma == 0)
            {
                if (bLLSach.themSach(S))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    try
                    {
                        File.Copy(bLLXuLy.pathImage, bLLXuLy.duongDanLuuHinh, true);
                    }
                    catch { }
                    btnThemSach.Text = "Lưu";
                    enabledControls(false);
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
            }
            else
            {
                S.ID = ma;
                if (bLLSach.capNhatSach(S))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    try
                    {
                        File.Copy(bLLXuLy.pathImage, bLLXuLy.duongDanLuuHinh, true);
                    }
                    catch { }
                    btnThemSach.Text = "Lưu";
                    enabledControls(false);
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
            }
            loadSachs();
        }

        private bool ktNhap()
        {
            if (txtTenSach.Text.Trim().Length == 0)
            {
                txtTenSach.Focus();
                MessageBox.Show("Vui lòng nhập tên sách!", "Thông báo");
                return false;
            }
            if (txtGia.Text.Trim().Length == 0)
            {
                txtGia.Focus();
                MessageBox.Show("Vui lòng nhập giá!", "Thông báo");
                return false;
            }
            if (txtNamXB.Text.Trim().Length == 0)
            {
                txtNamXB.Focus();
                MessageBox.Show("Vui lòng nhập năm xuất bản!", "Thông báo");
                return false;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                txtSoLuong.Focus();
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo");
                return false;
            }
            if (txtViTri.Text.Trim().Length == 0)
            {
                txtViTri.Focus();
                MessageBox.Show("Vui lòng nhập vị trí sách!", "Thông báo");
                return false;
            }
            return true;
        }

        private void UserCtrlQuanLySach_Load(object sender, EventArgs e)
        {
            enabledControls(false);
            loadSachs();
            loadNhaXuatBans();
            loadTheLoai();
            loadTacGia();
        }

        private void loadTacGia()
        {
            cboTacGia.DataSource = new BLLTacGia().lstTacGia();
            cboTacGia.ValueMember = "ID";
            cboTacGia.DisplayMember = "BUTDANH";
        }

        private void loadTheLoai()
        {
            cboTheLoai.DataSource = new BLLTheLoai().lstTheLoai();
            cboTheLoai.ValueMember = "ID";
            cboTheLoai.DisplayMember = "TENTHELOAI";
        }

        private void loadNhaXuatBans()
        {
            cboNXB.DataSource = new BLLNhaXuatBan().lstNhaXuatBan();
            cboNXB.ValueMember = "ID";
            cboNXB.DisplayMember = "TENNXB";
        }

        private void loadSachs()
        {
            dagirdDanhSachSach.DataSource = new BLLSach().lstSach();
            anCotKhongCanThiet();
        }
        private void anCotKhongCanThiet()
        {
            //ẩn những cột không cần thiết
            dagirdDanhSachSach.Columns["IDNXB"].Visible = false;
            dagirdDanhSachSach.Columns["IDTACGIA"].Visible = false;
            dagirdDanhSachSach.Columns["IDTHELOAI"].Visible = false;
            dagirdDanhSachSach.Columns["Hinh"].Visible = false;
            dagirdDanhSachSach.Columns["NHAXUATBAN"].Visible = false;
            dagirdDanhSachSach.Columns["THELOAI"].Visible = false;
            dagirdDanhSachSach.Columns["TACGIA"].Visible = false;

        }

        int ma = 0;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dagirdDanhSachSach.CurrentRow == null || ma==0)
            {
                MessageBox.Show("Vui lòng chọn sách để sửa!", "Thông báo");
                return;
            }
            enabledControls(true);
            ma = int.Parse(dagirdDanhSachSach.CurrentRow.Cells["MaSach"].Value.ToString());
            btnThemSach.Text = "Lưu Sửa";
        }

        private void enabledControls(bool enab)
        {
            txtTenSach.Enabled = cboTheLoai.Enabled = cboNXB.Enabled = enab;
            cboTacGia.Enabled = txtGia.Enabled = txtNamXB.Enabled = enab;
            txtSoLuong.Enabled = txtViTri.Enabled = btnChonHinhSach.Enabled = enab;
            btnThemSach.Enabled = enab;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dagirdDanhSachSach.CurrentRow == null || ma == 0)
            {
                MessageBox.Show("Vui lòng chọn sách để xóa!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa sách " + txtTenSach.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bLLSach.xoaSach(ma))
                {
                    enabledControls(false);
                    xoaDuLieuControls();
                    loadSachs();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
            }
        }

        private void dagirdDanhSachSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dagirdDanhSachSach.CurrentRow == null)
            {
                return;
            }
            ma = int.Parse(dagirdDanhSachSach.CurrentRow.Cells["MaSach"].Value.ToString().Trim());
            txtTenSach.Text = dagirdDanhSachSach.CurrentRow.Cells["TenSach"].Value.ToString().Trim();
            cboTheLoai.SelectedValue = dagirdDanhSachSach.CurrentRow.Cells["IDTheLoai"].Value;
            cboNXB.SelectedValue = dagirdDanhSachSach.CurrentRow.Cells["IDnxb"].Value;
            cboTacGia.SelectedValue = dagirdDanhSachSach.CurrentRow.Cells["IDTacGia"].Value;
            txtGia.Text = dagirdDanhSachSach.CurrentRow.Cells["Gia"].Value.ToString().Trim();
            txtNamXB.Text = dagirdDanhSachSach.CurrentRow.Cells["NamXB"].Value.ToString().Trim();
            txtSoLuong.Text = dagirdDanhSachSach.CurrentRow.Cells["SoLuong"].Value.ToString().Trim();
            txtViTri.Text = dagirdDanhSachSach.CurrentRow.Cells["ViTri"].Value.ToString().Trim();

            bLLXuLy.nameImage = dagirdDanhSachSach.CurrentRow.Cells["Hinh"].Value.ToString().Trim();
            bLLXuLy.loadDuongDanLuuHinh();
            try
            {
                picAnhSach.Image = Image.FromFile(bLLXuLy.duongDanLuuHinh);
            }
            catch { }
        }
        
        private void btnXoaThem_Click(object sender, EventArgs e)
        {
            enabledControls(true);
            xoaDuLieuControls();
            btnThemSach.Text = "Lưu Thêm";
        }

        private void xoaDuLieuControls()
        {
            ma = 0;
            cboTheLoai.SelectedValue = cboNXB.SelectedValue = cboTacGia.SelectedValue = 1;
            txtTenSach.Text = txtGia.Text = txtNamXB.Text = string.Empty;
            txtSoLuong.Text = txtViTri.Text = string.Empty;
            picAnhSach.Image = null;
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            if (dagirdDanhSachSach.CurrentRow == null || ma == 0)
            {
                MessageBox.Show("Vui lòng chọn sách để cho mượn!", "Thông báo");
                return;
            }
            frmChoMuonSach frm = new frmChoMuonSach(ma,emailNhanVien);
            frm.ShowDialog();
        }
    }
}
