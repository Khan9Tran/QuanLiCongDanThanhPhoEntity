using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho.Models
{
    internal class TamTruTamVang
    {
        private string maSo;
        private string cCCD;
        private string trangThai;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private DiaChi diaChi;
        private string lyDo;
        public TamTruTamVang()
        {
            trangThai = "unknow";
            ngayBatDau = DateTime.Now;
            ngayKetThuc = DateTime.Now;
            diaChi = new DiaChi();
            lyDo = "unknow";
        }
        public bool KiemTraThongTin()
        {
            return true;
        }
        public TamTruTamVang(string maSo, string cCCD, string trangThai, DateTime ngayBatDau, DateTime ngayKetThuc, string diaChi, string lyDo)
        {
            MaSo = maSo;
            this.cCCD = cCCD;
            if (trangThai == "True")
            {
                this.trangThai = "Tạm trú";
            }   
            else
            {
                this.trangThai = "Tạm vắng";
            }    
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            this.diaChi = new DiaChi();
            this.diaChi.DinhDang(diaChi);
            LyDo = lyDo;
        }

        public string MaSo { get => maSo; set => maSo = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public DiaChi DiaChi { get => diaChi; set => diaChi = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
    }
}
