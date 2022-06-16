using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLLNhanVien
    {
        DALNhanVien dALNhanVien = new DALNhanVien();
        BLLTaiKhoan bLLTaiKhoan = new BLLTaiKhoan();
        public BLLNhanVien() { }

        public int timIDNhanVien(string email)
        {
            return dALNhanVien.timIDNhanVien(email);
        }

        public string timTenNhanVienTheoID(int id)
        {
            return dALNhanVien.timTenNhanVienTheoID(id);
        }

        public NHANVIEN timNhanVienTheoID(int id)
        {
            NHANVIEN nv = dALNhanVien.lstNhanVien().Where(i=>i.ID==id).SingleOrDefault();
            nv.gioiTinh = "Nữ";
            if (nv.GIOITINH == true)
                nv.gioiTinh = "Nam";
            nv.tinhTrangHoatDong = "Ngừng hoạt động";
            if (bLLTaiKhoan.trangThaiTaiKhoan(nv.EMAIL.Trim()))
                nv.tinhTrangHoatDong = "Đang hoạt động";
            return nv;
        }

        public List<NHANVIEN> lstNhanVien()
        {
            List<NHANVIEN> nhanViens = new List<NHANVIEN>();
            foreach (NHANVIEN item in dALNhanVien.lstNhanVien())
            {
                //chức vụ quản lý thì ko lấy
                if (bLLTaiKhoan.chucVuTaiKhoan(item.EMAIL.Trim()) == 1)
                    continue;

                item.gioiTinh = "Nữ";
                if (item.GIOITINH == true)
                    item.gioiTinh = "Nam";
                item.tinhTrangHoatDong = "Ngừng hoạt động";
                if (bLLTaiKhoan.trangThaiTaiKhoan(item.EMAIL.Trim()))
                    item.tinhTrangHoatDong = "Đang hoạt động";
                nhanViens.Add(item);
            }
            return nhanViens;
        }

        public List<NHANVIEN> lstNhanVien_TheoSDT(string soDT)
        {
            List<NHANVIEN> nhanViens = new List<NHANVIEN>();
            foreach (NHANVIEN item in dALNhanVien.lstNhanVien())
            {
                //chức vụ quản lý thì ko lấy
                if (bLLTaiKhoan.chucVuTaiKhoan(item.EMAIL.Trim()) == 1)
                    continue;
                if (!item.SODT.Trim().Equals(soDT))
                    continue;
                item.gioiTinh = "Nữ";
                if (item.GIOITINH == true)
                    item.gioiTinh = "Nam";
                item.tinhTrangHoatDong = "Ngừng hoạt động";
                if (bLLTaiKhoan.trangThaiTaiKhoan(item.EMAIL.Trim()))
                    item.tinhTrangHoatDong = "Đang hoạt động";
                nhanViens.Add(item);
            }
            return nhanViens;
        }

        public bool ngungHoatDongNhanVien(string email)
        {
            return new DALTaiKhoan().ngungHoatDongTK(email);
        }

        public bool hoatDongNhanVien(string email)
        {
            return new DALTaiKhoan().hoatDongTK(email);
        }

        public bool capNhatNV(NHANVIEN nv)
        {
            return dALNhanVien.capNhatNhanVien(nv);
        }

        public bool themNhanVien(NHANVIEN nv)
        {
            return dALNhanVien.themNhanVien(nv);
        }
    }

}
