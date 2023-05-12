using System.Data;
using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    internal class KhaiSinhDAO
    {
        QuanlitpContext db = new QuanlitpContext();

        public void CapNhatKhaiSinh()
        {
            db.SaveChanges();
        }

        public bool ThemKhaiSinh(Khaisinh kS)
        {
            if (LayThongTin(kS.MaKs) != null)
                return false;   
            db.Khaisinhs.Add(kS);
            db.SaveChanges();
            return true;
            
        }

        public bool XoaKhaiSinh(string maKhaiSinh)
        {
            Khaisinh? khaiSinh = db.Khaisinhs.Find(maKhaiSinh);
            if (khaiSinh != null)
            {
                db.Remove(khaiSinh);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Khaisinh? LayThongTin(string maCCCD)
        {
            Khaisinh? khaiSinh = db.Khaisinhs.Find(maCCCD);
            return khaiSinh;
        }

        public List<object> LayDanhSachVeSoNamNu()
        {
            var result = db.Khaisinhs
               .GroupBy(c => c.GioiTinh)
               .Select(g => new {
                   MaHk = g.Key,
                   SoLuong = g.Count()
               })
               .Cast<object>()
               .ToList();
            return result;
        }

        public Khaisinh? LayThongTinhNamNuTheoTu(string tu, string dieuKien)
        {
                var khaiSinh = db.Khaisinhs.Where(q => q.NoiSinh.Contains(tu) || q.QueQuan.Contains(tu) || q.QuocTich.Contains(tu) || q.MaKs.Contains(tu) || q.DanToc.Contains(tu) || q.Cccdcha.Contains(tu) || q.Cccdme.Contains(tu) && q.GioiTinh == dieuKien).FirstOrDefault();
                return khaiSinh;
        }   

        private int[] SoLuongNguoiTrongNhomTuoi(IEnumerable<dynamic> dt)
        {
            int[] cntNhomTuoi = { 0, 0 ,0 };
            foreach (var row in dt)
            {
                int soTuoi = row.SoTuoi;
                if (soTuoi < 15)
                    cntNhomTuoi[0]++;
                else if (soTuoi >= 15 && soTuoi <= 64)
                    cntNhomTuoi[1]++;
                else
                    cntNhomTuoi[2]++;
            }
            return cntNhomTuoi;
        }

        public DataTable LayTuoiCongDan()
        {
            var dulieu = from q in db.Khaisinhs
                         let SoTuoi = DateTime.Now.Year - q.NgaySinh.Year
                         select new { SoTuoi };

            var dtNhomTuoi = new DataTable();
            dtNhomTuoi.Columns.Add("Nhóm tuổi");
            dtNhomTuoi.Columns.Add("Số lượng");

            var soLuongNhomTuoi = SoLuongNguoiTrongNhomTuoi(dulieu);
            dtNhomTuoi.Rows.Add("0-14", soLuongNhomTuoi[0]);
            dtNhomTuoi.Rows.Add("15-64", soLuongNhomTuoi[1]);
            dtNhomTuoi.Rows.Add("65+", soLuongNhomTuoi[2]);

            return dtNhomTuoi;
        }
    }
}
