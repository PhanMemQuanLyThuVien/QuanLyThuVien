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
    public partial class frmChoMuonSach : Form
    {
        private int maSach;
        private string emailNhanVien;
        private UserControlQLSach userControlQLSach;
        public frmChoMuonSach(int maSach, string emailNhanVien, UserControlQLSach userControlQLSach)
        {
            this.emailNhanVien = emailNhanVien;
            this.maSach = maSach;
            this.userControlQLSach = userControlQLSach;
            InitializeComponent();
        }

        private void frmChoMuonSach_Load(object sender, EventArgs e)
        {
            loadSach();
        }

        SACH sach = null;
        private void loadSach()
        {
            sach = new BLLSach().timSachTheoMa(maSach);
            txtTenSach.Text = sach.TENSACH;
            txtTenTacGia.Text = sach.BUTDANH;
            txtSoLuongSachCon.Text = sach.SOLUONGSACH.ToString();
            txtTienTheChan.Text = sach.GIA.ToString();
            BLLXuLy bLLXuLy = new BLLXuLy();
            bLLXuLy.nameImage = sach.HINHSACH;
            bLLXuLy.loadDuongDanLuuHinh();
            try
            {
                picAnhSach.Image = Image.FromFile(bLLXuLy.duongDanLuuHinh);
            }
            catch { }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!kTNhap())
                return;
            DialogResult r = MessageBox.Show("Xác nhận cho mượn sách!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                return;
            }
            int idThuThu = new BLLNhanVien().timIDNhanVien(emailNhanVien);
            int soLuongMuon = int.Parse(txtSoLuongMuon.Text);
            double tienTheChan = int.Parse(txtTienTheChan.Text);
            if (new BLLChiTietMuonTra().themChiTietMuonTra(dOCGIA,sach,idThuThu, soLuongMuon,tienTheChan))
            {
                xoaDocGia();
                MessageBox.Show("Cho mượn thành công!");
                userControlQLSach.loadSachs();
                WordExport wordExport = new WordExport();
                DateTime dtime = DateTime.Now;
                wordExport.PhieuMuonSach(dtime.Day.ToString(), dtime.Month.ToString(), dtime.Year.ToString(),
                    dOCGIA.HOTEN, dOCGIA.IDMASOTHE.ToString(), sach.TENSACH, sach.BUTDANH, soLuongMuon.ToString());
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Lỗi cho mượn!");
            }
        }

        private void xoaDocGia()
        {
            txtEmai.Text = txtHoTenDG.Text = txtMaSoThe.Text = txtSoDT.Text = string.Empty;
            dateTimePickerNgayHetHan.Value = DateTime.Now;
            try
            {
                picAnhDG.Image = null;
            }
            catch { }
        }

        int soLuongMuon = 0;
        private bool kTNhap()
        {
            if (txtMaSoThe.Text.Length == 0)
            {
                txtTim.Focus();
                MessageBox.Show("Vui lòng chọn độc giả cho mượn!");
                return false;
            }
            if (DateTime.Now > dOCGIA.HANSUDUNG)
            {
                MessageBox.Show("Thẻ độc giả đã hết hạn, không được phép mượn!");
                return false;
            }
            if (txtSoLuongMuon.Text.Trim().Length == 0)
            {
                txtSoLuongMuon.Focus();
                MessageBox.Show("Vui lòng nhập số lượng cho mượn!");
                return false;
            }
            soLuongMuon = int.Parse(txtSoLuongMuon.Text.Trim());
            if (soLuongMuon <= 0)
            {
                txtSoLuongMuon.Focus();
                MessageBox.Show("Số lượng sách mượn phải lớn hơn 0!");
                return false;
            }
            if (soLuongMuon > 3)
            {
                txtSoLuongMuon.Focus();
                MessageBox.Show("Số lượng sách mượn phải nhỏ hơn hoặc bằng 3!");
                return false;
            }
            if (soLuongMuon > sach.SOLUONGSACH)
            {
                txtSoLuongMuon.Focus();
                MessageBox.Show("Số lượng sách trong kho không đủ!");
                return false;
            }
            try
            {
                if (new BLLChiTietMuonTra().soLuongSachDGDaMuon(dOCGIA.IDMASOTHE) >= 3)
                {
                    MessageBox.Show("Độc giả " + dOCGIA.HOTEN + " đã mượn 3 quyển sách.\nQui định không được vượt quá 3 quyển sách!");
                    return false;
                }
            }
            catch { return true; }
            return true;
        }

        DOCGIA dOCGIA = null;
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim().Length == 0)
            {
                txtTim.Focus();
                return;
            }
            try
            {
                dOCGIA = new BLLDocGia().docGiaTheoSDT(txtTim.Text.Trim());
                if (dOCGIA == null)
                {
                    txtTim.Focus();
                    MessageBox.Show("Không tìm thấy độc giả có số điện thoại " + txtTim.Text + ".\nVui lòng nhập lại!", "Thông báo");
                    return;
                }
                
                txtEmai.Text = dOCGIA.EMAIL;
                txtHoTenDG.Text = dOCGIA.HOTEN;
                txtMaSoThe.Text = dOCGIA.IDMASOTHE.ToString();
                txtSoDT.Text = dOCGIA.SODT;
                dateTimePickerNgayHetHan.Value = (DateTime)dOCGIA.HANSUDUNG;
                BLLXuLy bLLXuLy = new BLLXuLy();
                bLLXuLy.nameImage = dOCGIA.HINHANH;
                bLLXuLy.loadDuongDanLuuHinh();
                try
                {
                    picAnhSach.Image = Image.FromFile(bLLXuLy.duongDanLuuHinh);
                }
                catch { }
            }
            catch
            {
                MessageBox.Show("Không tìm thấy độc giả có mã số độc giả " + txtTim.Text + ".\nVui lòng nhập lại!", "Thông báo");
            }
        }
    }
}
