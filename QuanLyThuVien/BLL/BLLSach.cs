using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.Linq.SqlClient;

namespace BLL
{
    public class BLLSach
    {
        DALSach dALSach = new DALSach();
        DALTheLoai dALTheLoai = new DALTheLoai();
        DALTacGia dALTacGia = new DALTacGia();
        DALNhaXuatBan dALNhaXuatBan = new DALNhaXuatBan();
        public BLLSach() { }

        public List<SACH> lstSach()
        {
            return loadlstSach(dALSach.lstSach());
        }

        private List<SACH> loadlstSach(List<SACH> saches)
        {
            List<THELOAI> theLoais = dALTheLoai.lstTheLoai();
            List<TACGIA> tacGias = dALTacGia.lstTacGia();
            List<NHAXUATBAN> nhaXuatBans = dALNhaXuatBan.lstNhaXuatBan();
            var listSach = (from s in saches
                            join tg in tacGias on s.IDTACGIA equals tg.ID
                            join tl in theLoais on s.IDTHELOAI equals tl.ID
                            join nxb in nhaXuatBans on s.IDNXB equals nxb.ID
                            select new
                            {
                                s.ID,
                                s.TENSACH,
                                s.IDNXB,
                                s.IDTACGIA,
                                s.IDTHELOAI,
                                s.SOLUONGSACH,
                                s.GIA,
                                s.NAMXB,
                                s.VITRISACH,
                                s.HINHSACH,
                                tg.BUTDANH,
                                tl.TENTHELOAI,
                                nxb.TENNXB
                            }).ToList();

            List<SACH> lstS = new List<SACH>();
            foreach (var item in listSach)
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
                S.TENTHELOAI = item.TENTHELOAI;
                S.BUTDANH = item.BUTDANH;
                S.TENNXB = item.TENNXB;
                lstS.Add(S);
            }
            return lstS;
        }

        public List<SACH> timSachTheoTen(string tenSach)
        {
            List<SACH> saches = dALSach.timSachTheoTen(tenSach);
            if (saches.Count == 0)
                return saches;
            return loadlstSach(saches);
        }

        public bool themSach(SACH S)
        {
            return dALSach.themSach(S);
        }

        public bool capNhatSach(SACH S)
        {
            return dALSach.capNhatSach(S);
        }

        public bool xoaSach(int maSach)
        {
            return dALSach.xoaSach(maSach);
        }

        public SACH timSachTheoMa(int maID)
        {
            SACH sach = dALSach.timSachTheoMaID(maID);
            sach.BUTDANH = dALTacGia.timTacGiaTheoMa(sach.IDTACGIA).BUTDANH;
            return sach;
        }
    }
}
