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

        public TAIKHOAN getTaiKhoan(string email)
        {
            return qltv.TAIKHOANs.Where(tk => tk.EMAIL.Trim() == email).FirstOrDefault();
        }
       

        public bool ngungHoatDongTK(string email)
        {
            try
            {
                TAIKHOAN tk =  qltv.TAIKHOANs.Where(i=>i.EMAIL.Trim()==email.Trim()).FirstOrDefault();
                tk.TRANGTHAI = false;
                qltv.SubmitChanges();
                return true;
            }
            catch {
                return false;
            }
        }
        public bool hoatDongTK(string email)
        {
            try
            {
                TAIKHOAN tk = qltv.TAIKHOANs.Where(i => i.EMAIL.Trim() == email.Trim()).FirstOrDefault();
                tk.TRANGTHAI = true;
                qltv.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool themTaiKhoan(TAIKHOAN tk)
        {
            try
            {
                qltv.TAIKHOANs.InsertOnSubmit(tk);
                qltv.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool doiMatKhau(string email, string matKhauMoi)
        {
            try
            {
                TAIKHOAN tk = qltv.TAIKHOANs.Where(i => i.EMAIL.Trim().Equals(email.Trim())).SingleOrDefault();
                tk.MATKHAU = matKhauMoi;

                qltv.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
