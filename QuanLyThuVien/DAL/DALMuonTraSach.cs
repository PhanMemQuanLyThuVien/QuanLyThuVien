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
        
    }
}
