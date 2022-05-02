using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLLXuLy
    {
        public string nameImage { get; set; }
        public string pathImage { get; set; }
        public string duongDanLuuHinh { get; set; }
        public BLLXuLy()
        {
            
        }

        public void loadDuongDanLuuHinh()
        {
            this.duongDanLuuHinh = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\QuanLyThuVien\\Images\\" + nameImage;
        }

        public void chonHinh()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;)|*.jpg;*.jpge;", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] duongDanHinh = ofd.FileName.ToString().Split('\\');
                    this.nameImage = duongDanHinh[duongDanHinh.Length - 1];
                    this.pathImage = ofd.FileName;
                    loadDuongDanLuuHinh();
                }
            }
        }
        
    }
}
