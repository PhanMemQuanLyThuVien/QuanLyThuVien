﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALChiTietMuonTra
    {
        QuanLyThuVienDataContext quanLyThuVienDataContext = new QuanLyThuVienDataContext();
        public DALChiTietMuonTra() { }

        public List<CHITIETMUONTRA> lstChiTietMuonTra()
        {
            return quanLyThuVienDataContext.CHITIETMUONTRAs.Select(s => s).ToList<CHITIETMUONTRA>();
        }

        public bool themChiTietMuonTra(CHITIETMUONTRA chiTietMuon)
        {
            try
            {
                quanLyThuVienDataContext.CHITIETMUONTRAs.InsertOnSubmit(chiTietMuon);
                quanLyThuVienDataContext.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
