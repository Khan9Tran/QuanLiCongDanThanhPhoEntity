using QuanLiCongDanThanhPho.Model;
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

                //Nếu 2 người không sống trong khu vực thì không thể đăng ký
                if (chong == null || vo == null)
                {
                    MessageBox.Show("Thông tin không tồn tại trong hệ thống");
                }
                else
                {
                    //Kiểm tra tên có khớp không
                    if (chong != null && !isGiongNhau(chong.Ten, hN.TenNam))
                    {
                        return false;
                    }
                    if (vo != null && !isGiongNhau(vo.Ten, hN.TenNu))
                    {
                        return false;
                    }

                    //Thêm công dân chưa có vào tạm trong hệ thống
                    db.Honnhans.Add(hN);
                    db.SaveChanges();
                }
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
