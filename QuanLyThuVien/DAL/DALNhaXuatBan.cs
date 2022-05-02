using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALNhaXuatBan
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALNhaXuatBan() { }

        public List<NHAXUATBAN> lstNhaXuatBan()
        {
            return quanLyThuVienDataContext.NHAXUATBANs.Select(i => i).ToList<NHAXUATBAN>();
        }
    }
}
