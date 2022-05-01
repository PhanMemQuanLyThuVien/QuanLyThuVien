using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLTaiKhoan
    {
        DALTaiKhoan dALTaiKhoan = new DALTaiKhoan();
        public BLLTaiKhoan() { }

        public bool ktDangNhap(string email, string matKhau)
        {
            int kt = dALTaiKhoan.lstTaiKhoan().Where(tk => tk.EMAIL.Trim() == email.Trim() && tk.MATKHAU.Trim() == matKhau.Trim()).ToList().Count();
            if (kt == 0)
                return false;
            return true;
        }

        public string getMaChucVuTaiKhoan(string email)
        {
            //mã 1: Quản lý
            //mã 2: Thủ thư
            return dALTaiKhoan.getTaiKhoan(email).CHUCVU.ToString();
        }
    }
}
