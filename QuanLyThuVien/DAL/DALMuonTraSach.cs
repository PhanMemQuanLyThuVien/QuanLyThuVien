using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALMuonTraSach
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALMuonTraSach() { }

        public List<MUONTRASACH> lstMuonTraSach()
        {
            return quanLyThuVienDataContext.MUONTRASACHes.Select(s => s).ToList<MUONTRASACH>();
        }
        
        public bool themMuonSach(MUONTRASACH muon)
        {
            try
            {
                quanLyThuVienDataContext.MUONTRASACHes.InsertOnSubmit(muon);
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public MUONTRASACH timSachThemVaoCuoiCung()
        {
            return quanLyThuVienDataContext.MUONTRASACHes.OrderByDescending(i=>i.IDMUON).First();
        }
    }
}
