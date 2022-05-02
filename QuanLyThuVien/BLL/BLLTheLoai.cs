using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLTheLoai
    {
        DALTheLoai dALTheLoai = new DALTheLoai();
        public BLLTheLoai() { }

        public List<THELOAI> lstTheLoai()
        {
            return dALTheLoai.lstTheLoai();
        }
    }
}
