using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLTacGia
    {
        DALTacGia dALTacGia = new DALTacGia();
        public BLLTacGia() { }

        public List<TACGIA> lstTacGia()
        {
            return dALTacGia.lstTacGia();
        }
    }
}
