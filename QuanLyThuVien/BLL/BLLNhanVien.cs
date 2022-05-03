using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLNhanVien
    {
        DALNhanVien dALNhanVien = new DALNhanVien();
        public BLLNhanVien() { }

        public int timIDNhanVien(string email)
        {
            return dALNhanVien.timIDNhanVien(email);
        }
    }
}
