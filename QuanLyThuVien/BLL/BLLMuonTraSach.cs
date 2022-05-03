using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLLMuonTraSach
    {
        DALMuonTraSach dALMuonTra = new DALMuonTraSach();
        public BLLMuonTraSach() { }

        public bool themMuonSach(MUONTRASACH muon)
        {
            return dALMuonTra.themMuonSach(muon);
        }

        public MUONTRASACH timSachThemVaoCuoiCung()
        {
            return dALMuonTra.timSachThemVaoCuoiCung();
        }
    }
}
