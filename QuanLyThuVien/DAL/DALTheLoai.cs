using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALTheLoai
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALTheLoai() { }

        public List<THELOAI> lstTheLoai()
        {
            return quanLyThuVienDataContext.THELOAIs.Select(i => i).ToList<THELOAI>();
        }
    }
}
