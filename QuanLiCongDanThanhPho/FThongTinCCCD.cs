﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCCCD : Form
    {
        CongDan congDan;

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        public FThongTinCCCD()
        {
            InitializeComponent();
        }
        public FThongTinCCCD(CongDan congDan)
        {
            InitializeComponent();
            StackForm.Add(this);
            this.congDan = congDan;
        }
        private void HienThiThongTin()
        {
            lblCCCD.Text = congDan.CCCD;
            lblTen.Text = congDan.Ten.ToUpper();
            KhaiSinhDAO khaiSinhDAO = new KhaiSinhDAO();
            KhaiSinh ks = khaiSinhDAO.LayThongTin(lblCCCD.Text);
            if (ks.GioiTinh == "m")
                lblGioiTinh.Text = "Nam";
            else lblGioiTinh.Text = "Nữ";
            lblNgaySinh.Text = ks.NgaySinh.ToShortDateString();
            lblQueQuan.Text = ks.QueQuan.toString();
            lblQuocTich.Text = ks.QuocTich;
            HoKhauDAO hoKhauDAO = new HoKhauDAO();
            HoKhau hk = hoKhauDAO.LayThongTin(congDan.MaHoKhau);
            lblDiaChi.Text = hk.DiaChi.toString();
            CCCDDAO cCCDDAO = new CCCDDAO();
            CCCD cCCD =cCCDDAO.LayThongTin(new CCCD(congDan.CCCD, DateTime.Now, "unknow"));
            lblNgayCap.Text = cCCD.NgayCap.ToShortDateString();
            lblDDNhanDang.Text = cCCD.DacDiem;



        }

        //Lấy hình công dân từ folder HinhCongDan
        private void LayHinhDaiDien()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\HinhCongDan"));
            string imagePath = string.Format(@$"{folderPath}\{lblCCCD.Text}");
            string png = imagePath + ".png";
            string jpg = imagePath + ".jpg";
            Bitmap bitmap = null;
            if (File.Exists(png))
            {
                bitmap?.Dispose();
                ptcHinhDaiDien.Image?.Dispose();

                using (Bitmap tempImage = new Bitmap(png, true)) //Giúp k bị lỗi không thể truy cập file đang hoạt động khi xóa
                {
                    bitmap = new Bitmap(tempImage);
                    ptcHinhDaiDien.Image = bitmap;
                }
            }
            else if (File.Exists(jpg))
            {
                bitmap?.Dispose();
                ptcHinhDaiDien.Image?.Dispose();

                using (Bitmap tempImage = new Bitmap(jpg, true))
                {
                    bitmap = new Bitmap(tempImage);
                    ptcHinhDaiDien.Image = bitmap;
                }
            }
        }

        private void FThongTinCCCD_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            LayHinhDaiDien();
        }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
    }
}
