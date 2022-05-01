using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLLDonVi
    {
        DALDonVi dALDonVi = new DALDonVi();
        public BLLDonVi() { }

        public List<DONVI> lstDonVi()
        {
            return dALDonVi.lstDonVi();
        }
    }
}
