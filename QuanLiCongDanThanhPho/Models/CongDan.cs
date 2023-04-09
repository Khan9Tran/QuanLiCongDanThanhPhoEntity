using QuanLiCongDanThanhPho.Model;
using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    public partial class CongDan
    {
        private string cCCD;
        private string ten;
        private string ngheNghiep;
        private string sDT;
        private string tonGiao;
        private string maHoKhau;
        private string quanHeVoiChuHo;

        public CongDan()
        {
            ten = "unknow";
            ngheNghiep = "unknow";
            SDT = "unknow";
            tonGiao = "unknow";
            maHoKhau = "unknow";
            quanHeVoiChuHo = "unknow";
        }
        public CongDan(string cCCD, string ten, string ngheNghiep, string sDT, string tonGiao, string maHoKhau, string quanHeVoiChuHo, string diaChi)
        {
            this.cCCD = cCCD;
            this.ten = ten;
            this.ngheNghiep = ngheNghiep;
            this.sDT = sDT;
            this.tonGiao = tonGiao;
            this.maHoKhau = maHoKhau;
            this.quanHeVoiChuHo = quanHeVoiChuHo;
            if (quanHeVoiChuHo == "Chủ hộ")
            {
                DiaChi dC = new DiaChi();
                dC.DinhDang(diaChi);
                HoKhauDAO hoKhauDAO = new HoKhauDAO();
                Hokhau hK = new Hokhau()
                {
                    MaHk = MaHoKhau,
                    DiaChi = dC.toString(),
                    CccdchuHo = CCCD,
                };
                hoKhauDAO.ThemHoKhau(hK);
            }
        }
        public CongDan(string cCCD, string ten)
        {
            this.cCCD = cCCD;
            this.ten = ten;
            ngheNghiep = "unknow";
            sDT = "unknow";
            tonGiao = "unknow";
            maHoKhau = "00000A";
            quanHeVoiChuHo = "Chưa nhập hộ";
        }
        public CongDan(string cCCD, string ten, string sDT)
        {
            this.cCCD = cCCD;
            this.ten = ten;
            this.SDT = sDT;
            maHoKhau = "00000B";
            ngheNghiep = "unknow";
            tonGiao = "unknow";
            quanHeVoiChuHo = "Tạm trú tại địa phương";

        }   

        public string CCCD { get => cCCD; set => cCCD = value; }
        public string Ten { get => ten; set => ten = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        public string QuanHeVoiChuHo { get => quanHeVoiChuHo; set => quanHeVoiChuHo = value; }
    }
}