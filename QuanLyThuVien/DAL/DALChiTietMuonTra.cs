using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALChiTietMuonTra
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALChiTietMuonTra() { }

        public List<CHITIETMUONTRA> lstChiTietMuonTra()
        {
            return quanLyThuVienDataContext.CHITIETMUONTRAs.Select(s => s).ToList<CHITIETMUONTRA>();
        }

        public bool themChiTietMuonTra(CHITIETMUONTRA chiTietMuon)
        {
            try
            {
                quanLyThuVienDataContext.CHITIETMUONTRAs.InsertOnSubmit(chiTietMuon);
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool suaChiTietMuonTra(int maChiTietMuon, int idNV)
        {
            try
            {
                CHITIETMUONTRA cHITIETMUONTRA = quanLyThuVienDataContext.CHITIETMUONTRAs.Where(i => i.IDCHITIETMUON == maChiTietMuon).SingleOrDefault();
                cHITIETMUONTRA.TINHTRANG = true;
                cHITIETMUONTRA.IDTHUTHUNHANTRA = idNV;
                DALSach dalSach = new DALSach();
                dalSach.capNhatSoLuongSachTra(cHITIETMUONTRA.IDSACH, cHITIETMUONTRA.SOLUONGMUON);
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool suaChiTietMuonTra_MaMuon(int maMuon, int idNV)
        {
            try
            {
                CHITIETMUONTRA cHITIETMUONTRA = quanLyThuVienDataContext.CHITIETMUONTRAs.Where(i => i.IDMUON == maMuon).SingleOrDefault();
                cHITIETMUONTRA.TINHTRANG = true;
                cHITIETMUONTRA.IDTHUTHUNHANTRA = idNV;
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
