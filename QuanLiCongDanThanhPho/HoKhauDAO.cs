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
        public void ThemHoKhau(HoKhau hK)
        {
            string sqlStr = string.Format($"INSERT INTO HOKHAU(MaHK,DiaChi,CCCDChuHo) VALUES('{hK.MaHoKhau}',N'{hK.DiaChi.toString()}', '{hK.CCCDChuHo}');");
            conn.ThucThi(sqlStr, "Tạo hộ khẩu mới thành công");
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
        public HoKhau LayThongTin(string maHoKhau)
        {

            string sqlStr = string.Format("SELECT * FROM HOKHAU WHERE MaHK = '{0}'", maHoKhau);
            return conn.LayThongTinHoKhau(sqlStr);
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
                var result = (from h in conn.Hokhaus
                              where !(h.MaHk == "00000A" || h.MaHk == "00000B")
                              join c in (from cong in conn.Congdans
                                         group cong by cong.MaHk into g
                                         select new { MaHK = g.Key, SL = g.Count() })
                              on h.MaHk equals c.MaHK
                              where h.DiaChi.Contains(tu) || h.CccdchuHo.Contains(tu) || h.MaHk.Contains(tu)
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
        public void CapNhatHoKhau(HoKhau hK)
        {
            string sqlStr = string.Format($"UPDATE HOKHAU SET DiaChi = N'{hK.DiaChi.toString()}', CCCDChuHo = '{hK.CCCDChuHo}' WHERE MaHK = '{hK.MaHoKhau}'");
            conn.ThucThi(sqlStr, $"Cập nhật hộ khẩu thành công");
        }
        public void XoaHoKhau(HoKhau hK)
        {
            string sqlStr = string.Format($"DELETE HOKHAU WHERE MaHK = '{hK.MaHoKhau}'");
            conn.ThucThi(sqlStr, "Đã xóa hộ không còn thành viên");
        }
        public List<object> TimHoNhieuNguoiNhat()
        {
            string sqlStr = string.Format("SELECT MaHK as 'Mã hộ', count(CCCD) as 'Số lượng' FROM CONGDAN GROUP BY MaHK HAVING count(CCCD) = (SELECT max(SL) FROM (SELECT count(CCCD) as SL FROM CONGDAN WHERE MaHK != '00000B' AND MaHK != '00000A' GROUP BY MaHK) as A)");
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
