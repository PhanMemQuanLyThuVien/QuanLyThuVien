using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALDonVi
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALDonVi() { }
        public List<DONVI> lstDonVi()
        {
            return quanLyThuVienDataContext.DONVIs.Select(dv => dv).ToList<DONVI>();
        }
    }
}
