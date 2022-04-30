using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALTaiKhoan
    {
        QuanLyThuVienDataContext qltv = new QuanLyThuVienDataContext();
        public DALTaiKhoan() { }
        public List<TAIKHOAN> lstTaiKhoan()
        {
            return qltv.TAIKHOANs.Select(tk => tk).ToList<TAIKHOAN>();
        }
    }
}
