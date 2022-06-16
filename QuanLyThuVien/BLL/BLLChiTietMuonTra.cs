using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLChiTietMuonTra
    {
        DALChiTietMuonTra dALChiTietMuonTra = new DALChiTietMuonTra();
        BLLNhanVien bLLNhanVien = new BLLNhanVien();
        BLLSach bLLSach = new BLLSach();
        DALSach dALSach = new DALSach();
        public BLLChiTietMuonTra() { }

        public int soLuongSachDGDaMuon(int maDG)
        {
            List<MUONTRASACH> lstDGMuon = new DALMuonTraSach().lstMuonTraSach().Where(i => i.IDMATHEDOCGIA == maDG).ToList<MUONTRASACH>();
            //nếu số lượng = 0 thì độc giả chưa mượn sách nào hết
            if (lstDGMuon.Count == 0)
                return 0;
            List<CHITIETMUONTRA> lstChiTietMuon = dALChiTietMuonTra.lstChiTietMuonTra().Where(i=>i.TINHTRANG==false).ToList<CHITIETMUONTRA>();
            
            int sLMuon = 0;
            try
            {
                foreach (MUONTRASACH item in lstDGMuon)
                {
                    sLMuon += lstChiTietMuon.Where(i => i.IDMUON == item.IDMUON).Single().SOLUONGMUON;
                }
                return sLMuon;
            }
            catch
            {
                return 0;
            }
        }
        public bool themChiTietMuonTra(CHITIETMUONTRA cHITIETMUONTRA)
        {
            return dALChiTietMuonTra.themChiTietMuonTra(cHITIETMUONTRA);
        }

        public bool themChiTietMuonTra(DOCGIA dOCGIA,SACH sach, int IDThuThu, int soLuongMuon, double tienTheChan)
        {
            //tạo MUONTRASACH thêm IDMATHEDOCGIA
            MUONTRASACH mUONTRASACH = new MUONTRASACH();
            mUONTRASACH.IDMATHEDOCGIA = dOCGIA.IDMASOTHE;
            //thêm mUONTRASACH vào database
            BLLMuonTraSach bLLMuonTraSach = new BLLMuonTraSach();
            bLLMuonTraSach.themMuonSach(mUONTRASACH);
            //lấy ra MUONTRASACH đã thêm
            mUONTRASACH = bLLMuonTraSach.timSachThemVaoCuoiCung();
            //gán giá trị vào chiTietMuon
            CHITIETMUONTRA chiTietMuon = new CHITIETMUONTRA();
            chiTietMuon.IDMUON = mUONTRASACH.IDMUON;
            chiTietMuon.IDSACH = sach.ID;
            chiTietMuon.IDTHUTHUCHOMUON = IDThuThu;
            chiTietMuon.SOLUONGMUON = soLuongMuon;
            chiTietMuon.NGAYMUON = DateTime.Now;
            if(dOCGIA.IDDONVI==1)
                chiTietMuon.HANTRA = DateTime.Now.AddDays(30);//đơn vị trong trường cho mượn 30 ngày
            else if(dOCGIA.IDDONVI == 2)
                chiTietMuon.HANTRA = DateTime.Now.AddDays(10);//đơn vị ngoài trường cho mượn 10 ngày
            chiTietMuon.TIENTHECHAN = tienTheChan;
            chiTietMuon.TINHTRANG = false;

            dALSach.capNhatSoLuongSachChoMuon(chiTietMuon.IDSACH, chiTietMuon.SOLUONGMUON);
            return dALChiTietMuonTra.themChiTietMuonTra(chiTietMuon);
        }

        public List<CHITIETMUONTRA> lstSachMuonTheoMaDG(int maDG)
        {
            try
            {
                List<CHITIETMUONTRA> lstCTSachMuon = dALChiTietMuonTra.lstChiTietMuonTra();
                List<CHITIETMUONTRA> lstSachMuon = new List<CHITIETMUONTRA>();
                List<MUONTRASACH> lstMuonSach = new BLLMuonTraSach().lstMuonSachTheoMaDG(maDG);

                foreach (MUONTRASACH item in lstMuonSach)
                {
                    CHITIETMUONTRA ctMT = lstCTSachMuon.Where(i => i.IDMUON == item.IDMUON).Single();
                    if (ctMT.TINHTRANG)
                        continue;
                    ctMT.TENTHUTHU = bLLNhanVien.timTenNhanVienTheoID(ctMT.IDTHUTHUCHOMUON);
                    ctMT.TENSACH = bLLSach.timSachTheoMa(ctMT.IDSACH).TENSACH;
                    lstSachMuon.Add(ctMT);
                }
                return lstSachMuon;
            }
            catch
            {
                return new List<CHITIETMUONTRA>();
            }
        }

        public bool traSach(int maCT, int idNV)
        {
            return dALChiTietMuonTra.suaChiTietMuonTra(maCT,idNV);
        }
        
        public bool traSachMaDG(int maDG, int idNV)
        {
            try
            {
                List<MUONTRASACH> lstMuonSach = new BLLMuonTraSach().lstMuonSachTheoMaDG(maDG);
                
                foreach (MUONTRASACH item in lstMuonSach)
                {
                    dALChiTietMuonTra.suaChiTietMuonTra_MaMuon(item.IDMUON,idNV);

                    CHITIETMUONTRA ctMT = dALChiTietMuonTra.lstChiTietMuonTra().Where(i => i.IDMUON == item.IDMUON).SingleOrDefault();
                    dALSach.capNhatSoLuongSachTra(ctMT.IDSACH, ctMT.SOLUONGMUON);
                }
                return true;
            }
            catch { return false; }
        }
        
    }

}
