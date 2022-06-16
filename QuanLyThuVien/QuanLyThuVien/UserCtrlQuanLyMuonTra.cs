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
    public partial class UserCtrlQuanLyMuonTra : UserControl
    {
        private DOCGIA dgMuonSach = null;
        private string emailNhanVien;
        public UserCtrlQuanLyMuonTra(string emailNhanVien)
        {
            InitializeComponent();
            this.emailNhanVien = emailNhanVien;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại độc giả cần tìm!");
                return;
            }
            dgMuonSach = new BLLDocGia().docGiaTheoSDT(txtTim.Text.Trim());
            if(dgMuonSach==null)
            {
                MessageBox.Show("Không tìm thấy độc giả!");
            }
            else
            {
                txtMaDG.Text = dgMuonSach.IDMASOTHE.ToString();
                txtTenDG.Text = dgMuonSach.HOTEN;

                loadDSDsach();
            }
        }

        private void loadDSDsach()
        {
            List<CHITIETMUONTRA> lstCTMuonTra = new BLLChiTietMuonTra().lstSachMuonTheoMaDG(dgMuonSach.IDMASOTHE);
            if (lstCTMuonTra.Count == 0)
            {
                MessageBox.Show("Độc giả chưa mượn sách!");
                return;
            }
            dagirdDanhSachSach.DataSource = new BLLChiTietMuonTra().lstSachMuonTheoMaDG(dgMuonSach.IDMASOTHE);
            
            dagirdDanhSachSach.Columns["IDTHUTHUCHOMUON"].Visible = false;
            dagirdDanhSachSach.Columns["IDTHUTHUNHANTRA"].Visible = false;
            dagirdDanhSachSach.Columns["TINHTRANG"].Visible = false;
            dagirdDanhSachSach.Columns["MUONTRASACH"].Visible = false;
            dagirdDanhSachSach.Columns["NHANVIEN"].Visible = false;
            dagirdDanhSachSach.Columns["NHANVIEN1"].Visible = false;
            dagirdDanhSachSach.Columns["SACH"].Visible = false;
        }
        private void loadDSDSachTra()
        {
            dagirdDanhSachSach.DataSource = new BLLChiTietMuonTra().lstSachMuonTheoMaDG(dgMuonSach.IDMASOTHE);
            
            dagirdDanhSachSach.Columns["IDTHUTHUCHOMUON"].Visible = false;
            dagirdDanhSachSach.Columns["IDTHUTHUNHANTRA"].Visible = false;
            dagirdDanhSachSach.Columns["TINHTRANG"].Visible = false;
            dagirdDanhSachSach.Columns["MUONTRASACH"].Visible = false;
            dagirdDanhSachSach.Columns["NHANVIEN"].Visible = false;
            dagirdDanhSachSach.Columns["NHANVIEN1"].Visible = false;
            dagirdDanhSachSach.Columns["SACH"].Visible = false;
        }

        private void UserCtrlQuanLyMuonTra_Load(object sender, EventArgs e)
        {
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

        private void dagirdDanhSachSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dagirdDanhSachSach.CurrentRow == null)
            {
                return;
            }
            SACH ttSach = null;
            try
            {
                int ma = int.Parse(dagirdDanhSachSach.CurrentRow.Cells["maSach"].Value.ToString().Trim());
                ttSach = new BLLSach().timSachTheoMa(ma);
                txtTenSach.Text = ttSach.TENSACH;
                cboTheLoai.SelectedValue = ttSach.THELOAI.ID;
                cboNXB.SelectedValue = ttSach.NHAXUATBAN.ID;
                cboTacGia.SelectedValue = ttSach.IDTACGIA;
                txtGia.Text = ttSach.GIA.ToString();
                txtNamXB.Text = ttSach.NAMXB.ToString();
                txtViTri.Text = ttSach.VITRISACH;
            }
            catch { }
            
            try
            {
                BLLXuLy bLLXuLy = new BLLXuLy();
                bLLXuLy.nameImage = ttSach.HINHSACH;
                bLLXuLy.loadDuongDanLuuHinh();
                picAnhSach.Image = Image.FromFile(bLLXuLy.duongDanLuuHinh);
            }
            catch { }
        }

        private void btnTraMotQuyen_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn sách để trả!","Thông báo");
                return;
            }
            DialogResult r = MessageBox.Show("Xác nhận trả sách!", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                return;
            }


            BLLChiTietMuonTra bLLChiTietMuonTra = new BLLChiTietMuonTra();
            int maCTMuon = int.Parse(dagirdDanhSachSach.CurrentRow.Cells["CTMuon"].Value.ToString().Trim());
            
            if (bLLChiTietMuonTra.traSach(maCTMuon, new BLLNhanVien().timIDNhanVien(emailNhanVien)))
            {
                MessageBox.Show("Trả sách thành công!");
                loadDSDSachTra();
                txtGia.Text = txtMaDG.Text = txtNamXB.Text = txtTenDG.Text = txtTenSach.Text = txtViTri.Text = string.Empty;
                picAnhSach.Image = null;
            }
            else
            {
                MessageBox.Show("Trả sách thất bại!");
            }
        }

        private void btnTraTatCa_Click(object sender, EventArgs e)
        {
            if (dgMuonSach == null)
            {
                return;
            }
            List<CHITIETMUONTRA> lstCTMuonTra = new BLLChiTietMuonTra().lstSachMuonTheoMaDG(dgMuonSach.IDMASOTHE);
            if (lstCTMuonTra.Count == 0)
            {
                MessageBox.Show("Độc giả chưa mượn sách!");
                return;
            }
            DialogResult r = MessageBox.Show("Xác nhận trả sách!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                return;
            }
            BLLChiTietMuonTra bLLChiTietMuonTra = new BLLChiTietMuonTra();
            if (bLLChiTietMuonTra.traSachMaDG(dgMuonSach.IDMASOTHE,new BLLNhanVien().timIDNhanVien(emailNhanVien)))
            {
                MessageBox.Show("Trả sách thành công!");
                loadDSDSachTra();
                txtGia.Text = txtMaDG.Text = txtNamXB.Text = txtTenDG.Text = txtTenSach.Text = txtViTri.Text = string.Empty;
                picAnhSach.Image = null;
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
