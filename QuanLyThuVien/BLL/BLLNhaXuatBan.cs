using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLNhaXuatBan
    {
        DALNhaXuatBan dALNhaXuatBan = new DALNhaXuatBan();
        public BLLNhaXuatBan() { }

        public List<NHAXUATBAN> lstNhaXuatBan()
        {
            return dALNhaXuatBan.lstNhaXuatBan();
        }
    }
}
