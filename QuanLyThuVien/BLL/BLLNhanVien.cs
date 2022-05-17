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
        public BLLNhanVien() { }

        public int timIDNhanVien(string email)
        {
            return dALNhanVien.timIDNhanVien(email);
        }
        public NHANVIEN nhanVienTheoID(int id)
        {
            return lstNhanVien().Where(nv => nv.ID == id).Single();
        }
        //public List<NHANVIEN> loadNV()
        //{
        //    return dALNhanVien.lstNhanVien();
        //}
        public List<NHANVIEN> lstNhanVien()
        {
            List<NHANVIEN> nhanViens = dALNhanVien.lstNhanVien();
            var listNV = (from nv in nhanViens
                          select new
                          {
                              nv.ID,
                              nv.HOTEN,
                              nv.NGAYSINH,
                              nv.GIOITINH,
                              nv.EMAIL,
                              nv.SODT,
                              nv.CMND,
                              nv.DIACHI,
                              nv.NGAYVAOLAM
                          }).ToList();
            List<NHANVIEN> lstNV = new List<NHANVIEN>();
            foreach (var item in listNV)
            {
                NHANVIEN nv = new NHANVIEN();
                nv.ID = item.ID;
                nv.HOTEN = item.HOTEN;
                nv.NGAYSINH = item.NGAYSINH;
                nv.GIOITINH = item.GIOITINH;
                if (item.GIOITINH == true)
                    nv.gioiTinhString = "Nam";
                else
                    nv.gioiTinhString = "Nữ";
                nv.EMAIL = item.EMAIL;
                nv.SODT = item.SODT;
                nv.CMND = item.CMND;
                nv.DIACHI = item.DIACHI;
                nv.NGAYVAOLAM = item.NGAYVAOLAM;
                lstNV.Add(nv);
            }
            return lstNV;
        }
        public bool themNhanVien(NHANVIEN nhanVien)
        {
            return dALNhanVien.themNhanVien(nhanVien);
        }

        public bool xoaNhanVien(int maNV)
        {
            return dALNhanVien.xoaNhanVien(maNV);
        }

        public bool capNhatNhanVien(NHANVIEN nhanVien)
        {
            return dALNhanVien.capNhatNhanVien(nhanVien);
        }
    }
}
