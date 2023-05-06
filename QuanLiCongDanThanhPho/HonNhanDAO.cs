﻿using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    internal class HonNhanDAO
    {
        QuanlitpContext db = DBConnection.Db;

        //Kiểm tra tên nhập vào có trùng khớp với trong hệ thống không
        public bool isGiongNhau(string? a, string? b)
        {
            if (a != b) return false;
            return true;
        }

        //Đnăng ký hôn nhân
        public bool ThemHonNhan(Honnhan hN)
        {
            try
            {
                CongDanDAO congDanDAO = new CongDanDAO();
                KhaiSinhDAO ksDao = new KhaiSinhDAO();

                Congdan? chong = congDanDAO.LayThongTin(hN.Cccdnam);
                Congdan? vo = congDanDAO.LayThongTin(hN.Cccdnu);

                Khaisinh? ksChong = ksDao.LayThongTin(hN.Cccdnam);
                Khaisinh? ksVo = ksDao.LayThongTin(hN.Cccdnu);

                if ((ksChong != null && ksVo != null ) && (ksChong.GioiTinh != "m" || ksVo.GioiTinh != "f"))
                {
                    return false;
                }

                if (LayThongTin(hN.MaHonNhan) != null || chong == null || vo == null)
                {
                    return false;
                }    

                //Kiểm tra tên có khớp không
                if (!isGiongNhau(chong.Ten, hN.TenNam))
                {
                    return false;
                }
                if (!isGiongNhau(vo.Ten, hN.TenNu))
                {
                    return false;
                }

                //Thêm công dân chưa có vào tạm trong hệ thống
                db.Honnhans.Add(hN);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Cập nhật thông tin hôn nhân
        public void CapNhatHonNhan()
        {
            db.SaveChanges();
        }

        //Xóa hôn nhân
        public bool Xoa(Honnhan honNhan)
        {
            try
            {
                if (honNhan != null)
                {
                    Honnhan? hN = db.Honnhans.Find(honNhan.MaHonNhan);
                    if (hN != null)
                    {
                        db.Honnhans.Remove(hN);
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }    

        //Lấy tất cả thông tin của hôn nhân theo CCCD
        public Honnhan? LayThongTin(string maCCCD)
        {   
            var hN = db.Honnhans.Where(p => p.Cccdnam == maCCCD || p.Cccdnu == maCCCD).FirstOrDefault();
            return hN;
        }

        //Lấy tất cả thông tin của hôn nhân theo mã số
        public Honnhan? LayThongTinTheoMaSo(string maHonNhan)
        {
           var hN = db.Honnhans.Where(p => p.MaHonNhan == maHonNhan).FirstOrDefault();
           return hN; 
        }
    }
}
