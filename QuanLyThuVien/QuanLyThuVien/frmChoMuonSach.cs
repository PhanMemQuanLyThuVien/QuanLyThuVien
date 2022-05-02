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
        public frmChoMuonSach(int maSach)
        {
            this.maSach = maSach;
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
            if (soLuongMuon > sach.SOLUONGSACH)
            {
                txtSoLuongMuon.Focus();
                MessageBox.Show("Số lượng sách trong kho không đủ!");
                return false;
            }
            if(new BLLChiTietMuonTra().soLuongSachDGDaMuon(dOCGIA.IDMASOTHE) >= 3)
            {
                MessageBox.Show("Độc giả "+dOCGIA.HOTEN+" đã mượn 3 quyển sách.\nQui định không được vượt quá 3 quyển sách!");
                return false;
            }
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
                dOCGIA = new BLLDocGia().docGiaTheoMa(int.Parse(txtTim.Text));
                if (dOCGIA == null)
                {
                    txtTim.Focus();
                    MessageBox.Show("Không tìm thấy độc giả có mã số độc giả " + txtTim.Text + ".\nVui lòng nhập lại!", "Thông báo");
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
            catch(Exception ex)
            {
                MessageBox.Show("Không tìm thấy độc giả có mã số độc giả " + txtTim.Text + ".\nVui lòng nhập lại!", "Thông báo");
            }
        }
    }
}
