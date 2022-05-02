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
    }
}
