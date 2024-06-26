﻿using QuanLiCongDanThanhPho.Model;


namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCCCD : FormThongTin
    {
        public FThongTinCCCD(Congdan congDan)
        {
            InitializeComponent();
            CongDan = congDan;
            HinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }
        
        private string DateTimeFormat()
        {
            return "dd/MM/yyyy";
        }

        private void HienThiThongTin()
        {
            lblCCCD.Text = CongDan.Cccd;
            lblTen.Text = CongDan.Ten.ToUpper();
            // Hiển thị thông tin lấy từ class công dân
            Khaisinh? ks = KSDAO.LayThongTin(lblCCCD.Text);
            if (ks != null)
            {
                if (ks.GioiTinh == "m")
                    lblGioiTinh.Text = "Nam";
                else 
                    lblGioiTinh.Text = "Nữ";

                lblNgaySinh.Text = ks.NgaySinh.ToString(DateTimeFormat());
                lblQueQuan.Text = ks.QueQuan;
                lblQuocTich.Text = ks.QuocTich;
            }
            // Hiển thị thông tin lấy từ class hộ khẩu
            Hokhau? hk = HKDAO.LayThongTin(CongDan.MaHk);
            if (hk != null)
                lblDiaChi.Text = hk.DiaChi;
            // Hiển thị thông tin láy từ class CCCD
            Cccd? cCCD = CCCDDAO.LayThongTin(new Cccd() { MaCccd = CongDan.Cccd });
            if (cCCD != null)
            {
                lblNgayCap.Text = ((DateTime)cCCD.NgayCap).ToString(DateTimeFormat());
                lblDDNhanDang.Text = cCCD.DacDiem;
            }
        }

        private void FThongTinCCCD_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            HinhCongDan.LayHinhDaiDien(lblCCCD.Text, ptcHinhDaiDien);
        }

    }
}
