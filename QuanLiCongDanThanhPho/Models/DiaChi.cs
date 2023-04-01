using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho.Models
{
    internal class DiaChi
    {
        private string soNhaVaDuong;
        private string xaPhuongTT;
        private string quanHuyen;
        private string tinhThanhPho;
        public DiaChi()
        {
            soNhaVaDuong = "unknow";
            xaPhuongTT = "unknow";
            quanHuyen = "unknow";
            tinhThanhPho = "unknow";
        }

        public DiaChi(string soNhaVaDuong, string xaPhuongTT, string quanHuyen, string tinhThanhPho)
        {
            this.soNhaVaDuong = soNhaVaDuong;
            this.xaPhuongTT = xaPhuongTT;
            this.quanHuyen = quanHuyen;
            this.tinhThanhPho = tinhThanhPho;
        }

        public string SoNhaVaDuong { get => soNhaVaDuong; set => soNhaVaDuong = value; }
        public string XaPhuongTT { get => xaPhuongTT; set => xaPhuongTT = value; }
        public string QuanHuyen { get => quanHuyen; set => quanHuyen = value; }
        public string TinhThanhPho { get => tinhThanhPho; set => tinhThanhPho = value; }

        public bool DinhDang(string str)
        {
            try
            {
                string[] s = str.Split(',');
                for (int i = 0; i < 4; i++)
                {
                    s[i] = s[i].Trim();
                }
                soNhaVaDuong = s[0];
                xaPhuongTT = s[1];
                quanHuyen = s[2];
                tinhThanhPho = s[3];
                
  
            }
            catch(Exception ex) 
            {
                return false;
            }
            return  true;
        }
        public string toString()
        {
            string diaChi = $"{SoNhaVaDuong}, {XaPhuongTT}, {QuanHuyen}, {TinhThanhPho}";
            return diaChi;
        }
    }
}
