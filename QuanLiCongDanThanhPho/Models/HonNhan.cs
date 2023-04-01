using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho.Models
{
    internal class HonNhan
    {
        private string maSo;
        private string cCCDChong;
        private string tenChong;
        private string cCCDVo;
        private string tenVo;
        private DiaChi noiDangKy;
        private DateTime ngayDangKy;

        public HonNhan()
        {
            noiDangKy = new DiaChi();
            ngayDangKy = DateTime.Now;
        }

        public HonNhan(string maSo, string cCCDChong, string tenChong, string cCCDVo, string tenVo, string noiDangKy, DateTime ngayDangKy, string gioiTinh)
        {
            this.maSo = maSo;
            if (gioiTinh == "False")
            {
                this.cCCDChong = cCCDVo;
                this.tenChong = tenVo;
                this.cCCDVo = cCCDChong;
                this.tenChong = tenVo;
            }
            else
            {
                this.cCCDChong = cCCDChong;
                this.tenChong = tenChong;
                this.cCCDVo = cCCDVo;
                this.tenVo = tenVo;
            }
            this.noiDangKy = new DiaChi();
            if (noiDangKy == "")
                this.noiDangKy.DinhDang("unknow,unknow,unknow,unknow");
            else 
                this.noiDangKy.DinhDang(noiDangKy);
            this.ngayDangKy = ngayDangKy;

        }

        public HonNhan(string maSo, string cCCDChong, string tenChong, string cCCDVo, string tenVo, string noiDangKy, DateTime ngayDangKy)
        {
            this.maSo = maSo;
            this.cCCDChong = cCCDChong;
            this.tenChong = tenChong;
            this.cCCDVo = cCCDVo;
            this.tenVo = tenVo;
            this.noiDangKy = new DiaChi();
            this.noiDangKy.DinhDang(noiDangKy);
            this.ngayDangKy = ngayDangKy;
        }

        public string MaSo { get => maSo; set => maSo = value; }
        public string CCCDChong { get => cCCDChong; set => cCCDChong = value; }
        public string TenChong { get => tenChong; set => tenChong = value; }
        public string CCCDVo { get => cCCDVo; set => cCCDVo = value; }
        public string TenVo { get => tenVo; set => tenVo = value; }
        public DateTime NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }
        internal DiaChi NoiDangKy { get => noiDangKy; set => noiDangKy = value; }
    }
}
