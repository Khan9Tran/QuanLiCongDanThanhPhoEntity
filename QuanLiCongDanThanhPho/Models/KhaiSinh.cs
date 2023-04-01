using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho.Models
{
    internal class KhaiSinh
    {
        private string maKhaiSinh;
        private string hoTen;
        private string gioiTinh;
        private string quocTich;
        private string danToc;
        private DateTime ngaySinh;
        private DateTime ngayDangKy;
        private DiaChi noiSinh;
        private DiaChi queQuan;
        private string cCCDCha;
        private string tenCha;
        private string cCCDMe;
        private string tenMe;

        public KhaiSinh() 
        {
            hoTen = "unknow";
            gioiTinh = "u";
            quocTich = "unknow";
            danToc = "unknow";
            ngaySinh = DateTime.Now;
            ngayDangKy = DateTime.Now;
            noiSinh = new DiaChi();
            queQuan = new DiaChi();
            tenCha = "unknow";
            tenMe = "unknow";
        }
        public KhaiSinh(string cCCD, string ten)
        {
            hoTen = ten;
            maKhaiSinh = cCCD;
            gioiTinh = "u";
            quocTich = "unknow";
            danToc = "unknow";
            ngaySinh = DateTime.Now;
            ngayDangKy = DateTime.Now;
            noiSinh = new DiaChi();
            queQuan = new DiaChi();
            tenCha = "unknow";
            tenMe = "unknow";
        }
        public KhaiSinh(string maKhaiSinh, string hoTen, string gioiTinh, string quocTich, string danToc, DateTime ngaySinh, DateTime ngayDangKy, string noiSinh, string queQuan, string cCCDCha, string tenCha, string cCCDMe, string tenMe)
        {
            this.maKhaiSinh = maKhaiSinh;
            this.hoTen = hoTen;
            if (gioiTinh == "True")
                this.gioiTinh = "m";
            else
                this.gioiTinh = "f";
            this.quocTich = quocTich;
            this.danToc = danToc;
            this.ngaySinh = ngaySinh;
            this.ngayDangKy = ngayDangKy;
            this.noiSinh = new DiaChi();
            this.noiSinh.DinhDang(noiSinh);
            this.queQuan = new DiaChi();
            this.queQuan.DinhDang(queQuan);
            this.cCCDCha = cCCDCha;
            this.tenCha = tenCha;
            this.cCCDMe = cCCDMe;
            this.tenMe = tenMe;
        }
        public void DinhDangGioiTinh()
        {
            if (gioiTinh == "Nam" || gioiTinh == "True" || gioiTinh == "nam" || gioiTinh == "NAM" || gioiTinh == "m")
                gioiTinh = "m";
            else
                gioiTinh = "f";
        }
        public string MaKhaiSinh { get => maKhaiSinh; set => maKhaiSinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }
        public string CCCDCha { get => cCCDCha; set => cCCDCha = value; }
        public string TenCha { get => tenCha; set => tenCha = value; }
        public string CCCDMe { get => cCCDMe; set => cCCDMe = value; }
        public string TenMe { get => tenMe; set => tenMe = value; }
        internal DiaChi NoiSinh { get => noiSinh; set => noiSinh = value; }
        internal DiaChi QueQuan { get => queQuan; set => queQuan = value; }
    }
}
