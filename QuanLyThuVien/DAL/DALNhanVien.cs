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
        public List<NHANVIEN> lstNhanVien()
        {
            return quanLyThuVienDataContext.NHANVIENs.Select(nv => nv).ToList<NHANVIEN>();
        }
        //public List<NHANVIEN> LoadNhanVienTheoID(string id)
        //{
        //    return quanLyThuVienDataContext.NHANVIENs.Where(t => t.ID.Equals(id)).Select(t => t).ToList();
        //}
        public bool themNhanVien(NHANVIEN nhanVien)
        {
            try
            {
                quanLyThuVienDataContext.NHANVIENs.InsertOnSubmit(nhanVien);
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNhanVien(int maNV)
        {
            try
            {
                NHANVIEN nHANVIEN = quanLyThuVienDataContext.NHANVIENs.Where(nv => nv.ID == maNV).Single();
                quanLyThuVienDataContext.NHANVIENs.DeleteOnSubmit(nHANVIEN);
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool capNhatNhanVien(NHANVIEN nhanVien)
        {
            try
            {
                NHANVIEN nv = quanLyThuVienDataContext.NHANVIENs.Where(nV => nV.ID == nhanVien.ID).Single();
                //nv = nhanVien;
                nv.HOTEN = nhanVien.HOTEN;
                nv.NGAYSINH = nhanVien.NGAYSINH;
                nv.GIOITINH = nhanVien.GIOITINH;
                nv.EMAIL = nhanVien.EMAIL;
                nv.SODT = nhanVien.SODT;
                nv.CMND = nhanVien.CMND;
                nv.DIACHI = nhanVien.DIACHI;
                nv.NGAYVAOLAM = nhanVien.NGAYVAOLAM;


                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
