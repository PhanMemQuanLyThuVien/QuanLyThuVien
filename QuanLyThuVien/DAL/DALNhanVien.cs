using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALNhanVien
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALNhanVien() { }

        public int timIDNhanVien(string email)
        {
            return quanLyThuVienDataContext.NHANVIENs.Where(i => i.EMAIL.Trim() == email.Trim()).Single().ID;
        }
    }
}
