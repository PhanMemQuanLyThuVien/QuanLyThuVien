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
        public BLLChiTietMuonTra() { }

        public int soLuongSachDGDaMuon(int maDG)
        {
            List<MUONTRASACH> lstDGMuon = new DALMuonTraSach().lstMuonTraSach().Where(i => i.IDMATHEDOCGIA == maDG).ToList<MUONTRASACH>();
            //nếu số lượng = 0 thì độc giả chưa mượn sách nào hết
            if (lstDGMuon.Count == 0)
                return 0;
            List<CHITIETMUONTRA> lstChiTietMuon = dALChiTietMuonTra.lstChiTietMuonTra();
            int sLMuon = 0;
            foreach (MUONTRASACH item in lstDGMuon)
            {
                sLMuon += lstChiTietMuon.Where(i => i.IDMUON == item.IDMUON).Single().SOLUONGMUON;
            }
            return sLMuon;
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
            chiTietMuon.HANTRA = DateTime.Now.AddDays(30);
            chiTietMuon.TIENTHECHAN = tienTheChan;
            chiTietMuon.TINHTRANG = false;
            return dALChiTietMuonTra.themChiTietMuonTra(chiTietMuon);
        }
        
    }

}
