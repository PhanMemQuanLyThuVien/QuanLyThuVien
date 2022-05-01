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
        QuanLyThuVienDataContext qltv = new QuanLyThuVienDataContext();
        public DALDocGia() { }

        public List<DOCGIA> lstDocGia()
        {
            return qltv.DOCGIAs.Select(dg => dg).ToList<DOCGIA>();
        }
        
        public bool themDocGia(DOCGIA docGia)
        {
            try
            {
                qltv.DOCGIAs.InsertOnSubmit(docGia);
                qltv.SubmitChanges();
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
                DOCGIA dOCGIA = qltv.DOCGIAs.Where(dg => dg.IDMASOTHE == maDG).Single();
                qltv.DOCGIAs.DeleteOnSubmit(dOCGIA);
                qltv.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
