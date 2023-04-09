using Microsoft.IdentityModel.Tokens;
using QuanLiCongDanThanhPho.Model;
using QuanLiCongDanThanhPho.Models;
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
        DBConnection conn = new DBConnection();
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
            using (var conn = new QuanlitpContext())
            {
                var Hks = from q in conn.Hokhaus
                          select q;
                return Hks.ToList();
            }
        }
        public Hokhau LayThongTin(string maHoKhau)
        {
            using (var conn = new QuanlitpContext())
            {
                var hK = conn.Hokhaus.First(q => q.MaHk == maHoKhau);
                return hK;
            }
        }
        public List<Hokhau> LayDanhSachChuaTu(string tu)
        {
            using (var conn = new QuanlitpContext())
            {
                var Hks = from q in conn.Hokhaus
                          where (q.MaHk.Contains(tu) || q.DiaChi.Contains(tu) || q.CccdchuHo.Contains(tu)) && (q.MaHk != "00000A" && q.MaHk != "00000B")
                          select q;
                return Hks.ToList();
            }
        }
        public List<Hokhau> LayDanhSachXepTheoSoTV(string tu)
        {
            using (var conn = new QuanlitpContext())
            {
                var result =  (from h in LayDanhSachChuaTu(tu)
                              join c in (from cong in conn.Congdans
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
        }
        public void CapNhatHoKhau(Hokhau hoKhau)
        {
            using (var conn = new QuanlitpContext())
            {
                var hK = conn.Hokhaus.FirstOrDefault(q => q.MaHk == hoKhau.MaHk);
                if (hK != null)
                {
                    hK.DiaChi = hoKhau.DiaChi.ToString();
                    hK.CccdchuHo = hoKhau.CccdchuHo;
                    conn.SaveChanges();
                    MessageBox.Show("Cập nhật hộ khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật hộ khẩu thất bại");
                }
            }
        }
        public void XoaHoKhau(HoKhau hK)
        {
            using (var conn = new QuanlitpContext())
            {
                var hkToDelete = conn.Hokhaus.FirstOrDefault(hk => hk.MaHk == hK.MaHoKhau);
                if (hkToDelete != null)
                {
                    conn.Hokhaus.Remove(hkToDelete);
                    conn.SaveChanges();
                    MessageBox.Show("Đã xóa hộ không còn thành viên");
                }
                else
                {
                    MessageBox.Show("Xóa hộ khẩu thất bại");
                }
            }
        }
        public List<object> TimHoNhieuNguoiNhat()
        {
            using (var conn = new QuanlitpContext()) {
                var subquery = conn.Congdans
                    .Where(c => c.MaHk != "00000A" && c.MaHk != "00000B")
                    .GroupBy(c => c.MaHk)
                    .Select(g => g.Count());

                var result = conn.Congdans
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
}
