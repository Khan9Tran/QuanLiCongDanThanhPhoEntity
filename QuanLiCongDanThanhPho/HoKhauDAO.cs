using Microsoft.IdentityModel.Tokens;
using QuanLiCongDanThanhPho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class HoKhauDAO
    {
        QuanlitpContext db = DBConnection.Db;
        public HoKhauDAO() { }
        public void ThemHoKhau(Hokhau hK)
        {
            using (var conn = new QuanlitpContext())
            {
                conn.Hokhaus.Add(hK);
                conn.SaveChanges();
            }
        }
        public List<Hokhau> LayDanhSach()
        {
            var Hks = from q in db.Hokhaus
                        select q;
            return Hks.ToList();
            
        }
        public Hokhau LayThongTin(string maHoKhau)
        {
            Hokhau hK = db.Hokhaus.Where(q => q.MaHk == maHoKhau).FirstOrDefault();
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
                MessageBox.Show("Cập nhật hộ khẩu thành công");
        }
        public void XoaHoKhau(Hokhau hK)
        {   
            db.Hokhaus.Remove(hK);
            db.SaveChanges();
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
