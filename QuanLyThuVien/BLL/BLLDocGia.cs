using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLLDocGia
    {
        DALDocGia dALDocGia = new DALDocGia();
        DALDonVi dALDonVi = new DALDonVi();
        public BLLDocGia() { }

        public List<DOCGIA> lstDocGia()
        {
            List<DONVI> donVis = dALDonVi.lstDonVi();
            List<DOCGIA> docGias = dALDocGia.lstDocGia();
            var listDG = (from dg in docGias
                          join dv in donVis
                          on dg.IDDONVI equals dv.ID
                          select new
                          {
                              dg.IDMASOTHE,
                              dg.HOTEN,
                              dg.NGAYLAP,
                              dg.NGAYSINH,
                              dg.GIOITINH,
                              dg.HANSUDUNG,
                              dg.SODT,
                              dg.EMAIL,
                              dg.CMND,
                              dg.DIACHI,
                              dg.HINHANH,
                              dv.TENDONVI,
                              dg.IDDONVI
                          }).ToList();

            List<DOCGIA> lstDG = new List<DOCGIA>();
            foreach (var item in listDG)
            {
                DOCGIA dg = new DOCGIA();
                dg.IDMASOTHE = item.IDMASOTHE;
                dg.HOTEN = item.HOTEN;
                dg.NGAYLAP = item.NGAYLAP;
                dg.NGAYSINH = item.NGAYSINH;
                dg.HANSUDUNG = item.HANSUDUNG;
                dg.SODT = item.SODT;
                dg.EMAIL = item.EMAIL;
                dg.CMND = item.CMND;
                dg.DIACHI = item.DIACHI;
                dg.HINHANH = item.HINHANH;
                dg.tenDonVi = item.TENDONVI;
                dg.IDDONVI = item.IDDONVI;
                dg.GIOITINH = item.GIOITINH;
                if (item.GIOITINH==true)
                    dg.gioiTinhString = "Nam";
                else
                    dg.gioiTinhString = "Nữ";
                lstDG.Add(dg);
            }
            return lstDG;
        }

        public DOCGIA docGiaTheoMa(int maDG)
        {
            return lstDocGia().Where(dg => dg.IDMASOTHE == maDG).Single();
        }

        public bool themDocGia(DOCGIA docGia)
        {
            return dALDocGia.themDocGia(docGia);
        }

        public bool xoaDocGia(int maDG)
        {
            return dALDocGia.xoaDocGia(maDG);
        }

        public bool capNhatDocGia(DOCGIA docGia)
        {
            return dALDocGia.capNhatDocGia(docGia);
        }
    }
}
