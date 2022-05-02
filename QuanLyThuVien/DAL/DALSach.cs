using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALSach
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALSach() { }

        public List<SACH> lstSach()
        {
            return quanLyThuVienDataContext.SACHes.Select(i => i).ToList<SACH>();
        }
        
        public List<SACH> timSachTheoTen(string tenSach)
        {
            List<SACH> lstS = new List<SACH>();

            foreach (timSachTheoTenResult item in quanLyThuVienDataContext.timSachTheoTen(tenSach).ToList<timSachTheoTenResult>())
            {
                SACH S = new SACH();
                S.ID = item.ID;
                S.TENSACH = item.TENSACH;
                S.IDNXB = item.IDNXB;
                S.IDTACGIA = item.IDTACGIA;
                S.IDTHELOAI = item.IDTHELOAI;
                S.SOLUONGSACH = item.SOLUONGSACH;
                S.GIA = item.GIA;
                S.NAMXB = item.NAMXB;
                S.VITRISACH = item.VITRISACH;
                S.HINHSACH = item.HINHSACH;
                lstS.Add(S);
            }
            return lstS;
        }

        public SACH timSachTheoMaID(int maID)
        {
            return quanLyThuVienDataContext.SACHes.Where(s => s.ID == maID).Single();
        }

        public bool themSach(SACH S)
        {
            try
            {
                quanLyThuVienDataContext.SACHes.InsertOnSubmit(S);
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool capNhatSach(SACH sach)
        {
            try
            {
                SACH S = quanLyThuVienDataContext.SACHes.Where(sachs => sachs.ID == sach.ID).Single();
                S.TENSACH = sach.TENSACH;
                S.IDNXB = sach.IDNXB;
                S.IDTACGIA = sach.IDTACGIA;
                S.IDTHELOAI = sach.IDTHELOAI;
                S.SOLUONGSACH = sach.SOLUONGSACH;
                S.GIA = sach.GIA;
                S.NAMXB = sach.NAMXB;
                S.VITRISACH = sach.VITRISACH;
                S.HINHSACH = sach.HINHSACH;
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaSach(int maSach)
        {
            try
            {
                SACH sACH = quanLyThuVienDataContext.SACHes.Where(s => s.ID == maSach).Single();
                quanLyThuVienDataContext.SACHes.DeleteOnSubmit(sACH);
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
