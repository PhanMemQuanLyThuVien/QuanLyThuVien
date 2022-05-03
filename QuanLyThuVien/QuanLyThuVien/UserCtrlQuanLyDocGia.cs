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
    public partial class UserCtrlQuanLyDocGia : UserControl
    {
        BLLDocGia bLLDocGia = new BLLDocGia();
        BLLDonVi bLLDonVi = new BLLDonVi();
        BLLXuLy bLLXuLy = new BLLXuLy();
        public UserCtrlQuanLyDocGia()
        {
            InitializeComponent();
        }

        private void UserCtrlQuanLyDocGia_Load(object sender, EventArgs e)
        {
            loadDocGia();
            //load đơn vị vào cboDonVi
            cboDonVi.DataSource = bLLDonVi.lstDonVi();
            cboDonVi.ValueMember = "ID";
            cboDonVi.DisplayMember = "TENDONVI";            
        }

        private void anCotKhongCanThiet()
        {
            //ẩn những cột không cần thiết
            dagirdDanhSachDocGia.Columns["IDDONVI"].Visible = false;
            dagirdDanhSachDocGia.Columns["DONVI"].Visible = false;
            dagirdDanhSachDocGia.Columns["GIOITINH"].Visible = false;
        }

        public void loadDocGia()
        {
            dagirdDanhSachDocGia.DataSource = new BLLDocGia().lstDocGia();
            anCotKhongCanThiet();
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            if (!ktNhap())
                return;
            DOCGIA dg = new DOCGIA();
            dg.HOTEN = txtHoTenDG.Text;
            dg.NGAYSINH = dateTimePickerNgaySinh.Value;
            dg.SODT = txtSoDT.Text;
            dg.EMAIL = txtEmai.Text;
            dg.IDDONVI = int.Parse(cboDonVi.SelectedValue.ToString());
            dg.GIOITINH = rdoNam.Checked;
            dg.NGAYLAP = DateTime.Now;
            //hạn sử dụng 1 năm kể từ ngày lập
            dg.HANSUDUNG = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
            dg.HINHANH = bLLXuLy.nameImage;
            dg.DIACHI = txtDiaChi.Text;
            dg.CMND = txtCMND.Text;
            if (bLLDocGia.themDocGia(dg))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo");
                try
                {
                    File.Copy(bLLXuLy.pathImage, bLLXuLy.duongDanLuuHinh, true);
                }
                catch { }
            }
            else
                MessageBox.Show("Thêm thất bại!", "Thông báo");
            loadDocGia();
        }

        private bool ktNhap()
        {
            if (txtHoTenDG.Text.Trim().Length == 0)
            {
                txtHoTenDG.Focus();
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

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            loadDocGia();
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
                DOCGIA docGia = bLLDocGia.docGiaTheoMa(int.Parse(txtTim.Text));
                if (docGia == null)
                {
                    txtTim.Focus();
                    MessageBox.Show("Không tìm thấy độc giả có mã số độc giả " + txtTim.Text + ".\nVui lòng nhập lại!", "Thông báo");
                    return;
                }
                
                dagirdDanhSachDocGia.DataSource = new List<DOCGIA>() { docGia };
                anCotKhongCanThiet();
            }
            catch
            {
                txtTim.Focus();
                MessageBox.Show("Vui lòng nhập mã số độc giả!", "Thông báo");
            }
        }

        private void btnChonHinhDG_Click(object sender, EventArgs e)
        {
            bLLXuLy.chonHinh();
            try
            {
                picAnhDG.Image = Image.FromFile(bLLXuLy.pathImage);
            }
            catch { }
        }

        private void btnXemChiTietDocGia_Click(object sender, EventArgs e)
        {
            if (dagirdDanhSachDocGia.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả để xem chi tiết!", "Thông báo");
                return;
            }
            frmChiTietDocGia frmChiTietDG = new frmChiTietDocGia(this, int.Parse(dagirdDanhSachDocGia.CurrentRow.Cells["MaSoThe"].Value.ToString()));
            frmChiTietDG.ShowDialog();
        }
    }
}
