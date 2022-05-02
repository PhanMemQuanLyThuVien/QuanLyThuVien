using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALDocGia
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALDocGia() { }

        public List<DOCGIA> lstDocGia()
        {
            return quanLyThuVienDataContext.DOCGIAs.Select(dg => dg).ToList<DOCGIA>();
        }
        
        public bool themDocGia(DOCGIA docGia)
        {
            try
            {
                quanLyThuVienDataContext.DOCGIAs.InsertOnSubmit(docGia);
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaDocGia(int maDG)
        {
            try
            {
                DOCGIA dOCGIA = quanLyThuVienDataContext.DOCGIAs.Where(dg => dg.IDMASOTHE == maDG).Single();
                quanLyThuVienDataContext.DOCGIAs.DeleteOnSubmit(dOCGIA);
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool capNhatDocGia(DOCGIA docGia)
        {
            try
            {
                DOCGIA dg = quanLyThuVienDataContext.DOCGIAs.Where(dG => dG.IDMASOTHE == docGia.IDMASOTHE).Single();
                //dg = docGia;
                dg.HOTEN = docGia.HOTEN;
                dg.NGAYSINH = docGia.NGAYSINH;
                dg.NGAYLAP = docGia.NGAYLAP;
                dg.HANSUDUNG = docGia.HANSUDUNG;
                dg.HINHANH = docGia.HINHANH;
                dg.SODT = docGia.SODT;
                dg.GIOITINH = docGia.GIOITINH;
                dg.CMND = docGia.CMND;
                dg.DIACHI = docGia.DIACHI;
                dg.IDDONVI = docGia.IDDONVI;
                dg.EMAIL = docGia.EMAIL;

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
