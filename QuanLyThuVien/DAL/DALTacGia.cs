using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTacGia
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALTacGia() { }

        public List<TACGIA> lstTacGia()
        {
            return quanLyThuVienDataContext.TACGIAs.Select(i => i).ToList<TACGIA>();
        }

        public TACGIA timTacGiaTheoMa(int ma)
        {
            return quanLyThuVienDataContext.TACGIAs.Where(tg => tg.ID == ma).Single();
        }
    }
}
