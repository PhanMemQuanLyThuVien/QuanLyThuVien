using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALNhanVien
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALNhanVien() { }

        public int timIDNhanVien(string email)
        {
            return quanLyThuVienDataContext.NHANVIENs.Where(i => i.EMAIL.Trim() == email.Trim()).Single().ID;
        }

        public string timTenNhanVienTheoID(int id)
        {
            return quanLyThuVienDataContext.NHANVIENs.Where(i => i.ID == id).Single().HOTEN;
        }

        public List<NHANVIEN> lstNhanVien()
        {
            return quanLyThuVienDataContext.NHANVIENs.Select(i => i).ToList<NHANVIEN>();
        }

        public bool capNhatNhanVien(NHANVIEN nv)
        {
            try
            {
                NHANVIEN nvCapNhat = quanLyThuVienDataContext.NHANVIENs.Where(i => i.ID == nv.ID).Single();
                nvCapNhat.HOTEN = nv.HOTEN;
                nvCapNhat.NGAYSINH = nv.NGAYSINH;
                nvCapNhat.SODT = nv.SODT;
                nvCapNhat.GIOITINH = nv.GIOITINH;
                nvCapNhat.NGAYVAOLAM = nv.NGAYVAOLAM;
                nvCapNhat.DIACHI = nv.DIACHI;
                nvCapNhat.CMND = nv.CMND;

                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool themNhanVien(NHANVIEN nv)
        {
            try
            {
                quanLyThuVienDataContext.NHANVIENs.InsertOnSubmit(nv);
                quanLyThuVienDataContext.SubmitChanges();
                TAIKHOAN tk = new TAIKHOAN();
                tk.EMAIL = nv.EMAIL;
                tk.MATKHAU = nv.EMAIL;
                tk.CHUCVU = 2;
                tk.TRANGTHAI = true;
                new DALTaiKhoan().themTaiKhoan(tk);               
                return true;
            }
            catch { return false; }
        }

    }
}
