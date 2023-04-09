﻿using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    internal class HonNhanDAO
    {
        DBConnection conn = new DBConnection();
        
        //Kiểm tra tên nhập vào có trùng khớp với trong hệ thống không
        public bool isGiongNhau(string a, string b)
        {
            if (a != b) return false;
            return true;
        }

        //Đnăng ký hôn nhân
        public void ThemHonNhan(Honnhan hN)
        {
            CongDanDAO congDanDAO = new CongDanDAO();
            KhaiSinhDAO ksDao = new KhaiSinhDAO();
            string tenChong = congDanDAO.LayThongTin(hN.Cccdnam).Ten;
            string tenVo = congDanDAO.LayThongTin(hN.Cccdnu).Ten;

            //Nếu 2 người không sống trong khu vực thì không thể đăng ký
            if (tenChong == "unknow" && tenVo == "unknow")
            {
                MessageBox.Show("Thông tin không tồn tại trong hệ thống");
                return;
            }

            //Kiểm tra tên có khớp không
            if (tenChong != "unknow" && !isGiongNhau(tenChong, hN.TenNam))
            {
                MessageBox.Show("Tên chồng không khớp với CCCD");
                return;
            }
            if (tenVo != "unknow" && !isGiongNhau(tenVo, hN.TenNu))
            {
                MessageBox.Show("Tên vợ không khớp với CCCD");
                return;
            }

            //Thêm công dân chưa có vào tạm trong hệ thống
            Congdan congDan;
            KhaiSinh khaiSinh;
            if (tenChong == "unknow")
            {
                congDan = new Congdan()
                {   
                    Cccd = hN.Cccdnam,
                    Ten =hN.TenNam
                };
                khaiSinh = new KhaiSinh(hN.Cccdnam, hN.TenNam);
                MessageBox.Show("Thông chồng đã được tạo, nếu sống trong khu vực hãy bổ sung thông tin");
                congDanDAO.ThemCongDan(congDan);
                ksDao.ThemKhaSinh(khaiSinh);
            }
            if (tenVo == "unknow")
            {
                congDan = new Congdan()
                {
                    Cccd = hN.Cccdnu,
                    Ten = hN.TenNu
                };
                khaiSinh = new KhaiSinh(hN.Cccdnu, hN.TenNu);
                MessageBox.Show("Thông tin vợ đã được tạo, nếu sống trong khu vực hãy bổ sung thông tin");
                congDanDAO.ThemCongDan(congDan);
                ksDao.ThemKhaSinh(khaiSinh);
            }
            using (var conn = new QuanlitpContext())
            {
                conn.Honnhans.Add(hN);
                conn.SaveChanges();
            }
        }

        //Cập nhật thông tin hôn nhân
        public void CapNhatHonNhan(Honnhan honNhan)
        {
            using (var conn = new QuanlitpContext())
            {
                var hN = conn.Honnhans.First(q => q.MaHonNhan == honNhan.MaHonNhan);
                if (hN != null)
                {
                    hN = honNhan;
                    conn.SaveChanges();
                    MessageBox.Show("Cập nhật hôn nhân thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật hôn nhân thật bại");
                }
            }
        }

        //Kiểm tra xem người có CCCD này đã kết hôn chưa
        public Boolean KiemTraHonNhan(string maCCCD)
        {
            string sqlStr = string.Format("SELECT COUNT(*) as COUNT FROM HONNHAN WHERE CCCDNam = '{0}' OR CCCDNu = '{0}'", maCCCD);
            return conn.KiemTraCoKhong(sqlStr);
        }

        //Xóa hôn nhân
        public void Xoa(Honnhan honNhan)
        {
            using (var conn = new QuanlitpContext())
            {
                var hN = conn.Honnhans.Find(honNhan.MaHonNhan);
                if (hN != null)
                {
                    conn.Honnhans.Remove(hN);
                    conn.SaveChanges();
                    MessageBox.Show("Xóa hôn nhân thành công");
                }
                else
                {
                    MessageBox.Show("Xóa hôn nhân thất bại");
                }
            }
        }    

        //Lấy tất cả thông tin của hôn nhân theo CCCD
        public Honnhan LayThongTin(string maCCCD)
        {
            using (var conn = new QuanlitpContext())
            {
                var hN = conn.Honnhans.First(q => q.Cccdnam == maCCCD || q.Cccdnu == maCCCD);
                return hN;
            }
        }

        //Lấy tất cả thông tin của hôn nhân theo mã số
        public Honnhan LayThongTinTheoMaSo(string maHonNhan)
        {
            using (var conn = new QuanlitpContext())
            {
                var hN = conn.Honnhans.First(q => q.MaHonNhan == maHonNhan);
                return hN;
            }
        }
    }
}
