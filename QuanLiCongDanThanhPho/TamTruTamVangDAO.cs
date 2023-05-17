using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    internal class TamTruTamVangDAO
    {
        QuanlitpContext db = DBConnection.Db;
        public TamTruTamVangDAO() { }
        public List<Tamtrutamvang> LayDanhSachTamTru(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                       where q.TrangThai == "Tạm trú"
                       select q;
            return list.ToList();
        }
        public List<Tamtrutamvang> LayDanhSachTamVang(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                       where q.TrangThai == "Tạm vắng"
                       select q;
            return list.ToList();
        }
        public List<Tamtrutamvang> LayDanhSachChoDuyet(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                       where q.TrangThai == "CDTT" || q.TrangThai == "CDTV"
                       select q;
            return list.ToList();
        }

        public Tamtrutamvang LayThongTinTheoMaSo(string maTttv)
        {
            var tTTV = db.Tamtrutamvangs.Where(q => q.MaTttv == maTttv).FirstOrDefault();
            return tTTV;
        }
        public bool ThemTamTruTamVang(Tamtrutamvang tTTV)
        {
            if (LayThongTin(tTTV.Cccd) != null && LayThongTinTheoMaSo(tTTV.MaTttv) != null)
            {
                return false;
            }    
            db.Tamtrutamvangs.Add(tTTV);
            db.SaveChanges();
            return true;
        }
        public bool XoaTamTruTamVang(string canCuoc)
        {
            Tamtrutamvang? tTTV = LayThongTin(canCuoc);
            if (tTTV == null)
            {
                return false;
            }    

            db.Tamtrutamvangs.Remove(tTTV);
            db.SaveChanges();
            return true;
        }
        public void CapNhat()
        {
            db.SaveChanges();
        }

        public Tamtrutamvang? LayThongTin(string maCCCD)
        {
            var tTTV = db.Tamtrutamvangs.Where(q => q.Cccd == maCCCD).FirstOrDefault();
            return tTTV;
        } 

        public List<Tamtrutamvang> LayDanhSachChuaTu(string tu)
        {
            var list = from q in db.Tamtrutamvangs
                        where q.LiDo.Contains(tu) ||q.DiaChi.Contains(tu) || q.TrangThai.Contains(tu) || q.MaTttv.Contains(tu)
                        select q;
            return list.ToList();
        }

        public List<Tamtrutamvang> LayDanhSachTheoTrangThai(string trangthai)
        {
            var list = from q in LayDanhSach()
                       where q.TrangThai == trangthai
                       select q;
            return list.ToList();
        }

        public int LaySoLuongTamTru()
        {
            var list = LayDanhSachTheoTrangThai("Tạm trú");
            return list.Count;
        }

        public int LaySoLuongTamVang()
        {
            var list = LayDanhSachTheoTrangThai("Tạm vắng");
            return list.Count;
        }

        public List<Tamtrutamvang> LayDanhSachQuaHan(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                       where q.NgayKt < DateTime.Now
                       select q;
            return list.ToList();
        }
        
        public int LaySoLuongQuaHanTamTru()
        {
            var list = from q in LayDanhSachTheoTrangThai("Tạm trú")
                       where q.NgayKt < DateTime.Now
                       select q;
            return list.ToList().Count;
     
        }
        public int LaySoLuongQuaHanTamVang()
        {
            var list = from q in LayDanhSachTheoTrangThai("Tạm vắng")
                       where q.NgayKt < DateTime.Now
                       select q;
            return list.ToList().Count;

        }
        public List<Tamtrutamvang> LayDanhSach()
        {
            var list = from q in db.Tamtrutamvangs
                        select q;
            return list.ToList();
        }

        public int LaySoLuong()
        {
            var list = LayDanhSach();
            return list.Count;
        }
    }
}
