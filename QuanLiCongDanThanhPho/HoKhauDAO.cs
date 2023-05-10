using QuanLiCongDanThanhPho.Model;


namespace QuanLiCongDanThanhPho
{
    internal class HoKhauDAO
    {
        QuanlitpContext db = DBConnection.Db;
        public HoKhauDAO() { }
        public bool ThemHoKhau(Hokhau hK)
        {   if (LayThongTin(hK.MaHk) != null)
                return false;
            db.Hokhaus.Add(hK);
            db.SaveChanges();
            return true;
        }

        public List<Hokhau> LayDanhSach()
        {
            var Hks = from q in db.Hokhaus
                        select q;
            return Hks.ToList();
            
        }

        public Hokhau? LayThongTin(string maHoKhau)
        {
            Hokhau? hK = db.Hokhaus.Where(q => q.MaHk == maHoKhau).FirstOrDefault();
            return hK;
        }

        public List<Hokhau> LayDanhSachChuaTu(string tu)
        {
            var Hks = from q in db.Hokhaus
                        where (q.MaHk.Contains(tu) || q.DiaChi.Contains(tu) || q.CccdchuHo.Contains(tu)) && (q.MaHk != "00000A" && q.MaHk != "00000B")
                        select q;
            return Hks.ToList();
            
        }

        public List<Hokhau> LayDanhSachXepTheoSoTV(string tu)
        {
            
            var result =  (from h in LayDanhSachChuaTu(tu)
                            join c in (from cong in db.Congdans
                                        group cong by cong.MaHk into g
                                        select new { MaHK = g.Key, SL = g.Count() })
                            on h.MaHk equals c.MaHK
                            orderby c.SL ascending
                            select new Hokhau
                            {
                                MaHk = h.MaHk,
                                DiaChi = h.DiaChi,
                                CccdchuHo = h.CccdchuHo,
                                  
                            });
            return result.ToList();
            
        }
        public void CapNhatHoKhau()
        {
                db.SaveChanges();
        }
        public bool XoaHoKhau(Hokhau hK)
        {
            try
            {
                if (hK != null)
                {
                    db.Hokhaus.Remove(hK);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public List<object> TimHoNhieuNguoiNhat()
        {
            var subquery = db.Congdans
                .Where(c => c.MaHk != "00000A" && c.MaHk != "00000B")
                .GroupBy(c => c.MaHk)
                .Select(g => g.Count());

            var result = db.Congdans
                .Where(c => c.MaHk != "00000A" && c.MaHk != "00000B")
                .GroupBy(c => c.MaHk)
                .Select(g => new {
                    MaHk = g.Key,
                    SoLuong = g.Count()
                })
                .Where(x => x.SoLuong == subquery.Max())
                .Select(x => new {
                    x.MaHk,
                    x.SoLuong
                })
                .Cast<object>()
                .ToList();
            return result.ToList();
        }
    }
}
