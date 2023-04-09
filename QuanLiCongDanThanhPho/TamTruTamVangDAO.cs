using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using QuanLiCongDanThanhPho.Model;
using QuanLiCongDanThanhPho.Models;
namespace QuanLiCongDanThanhPho
{
    internal class TamTruTamVangDAO
    {
        DBConnection conn = new DBConnection();
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
        public void ThemTamTruTamVang(Tamtrutamvang tTTV)
        {
            using (var conn = new QuanlitpContext()) 
            {
                conn.Tamtrutamvangs.Add(tTTV);
                conn.SaveChanges();
            }
        }
        public void XoaTamTruTamVang(string canCuoc)
        {
            using (var conn = new QuanlitpContext())
            {
                Tamtrutamvang tTTV = conn.Tamtrutamvangs.Where(x => x.Cccd == canCuoc).SingleOrDefault();
                conn.Tamtrutamvangs.Remove(tTTV);
                conn.SaveChanges();
            }
        }
        public Boolean KiemTraTamTruTamVang(string maCCCD)
        {
            return LayThongTin(maCCCD) != null;
        }
        public Tamtrutamvang LayThongTin(string maCCCD)
        {
            using (var conn = new QuanlitpContext())
            {
                var tTTV = conn.Tamtrutamvangs.First(q => q.Cccd == maCCCD);
                return tTTV;
            }
        } 

        public List<Tamtrutamvang> LayDanhSachChuaTu(string tu)
        {
            using (var conn = new QuanlitpContext()) 
            {
                var list = from q in conn.Tamtrutamvangs
                           where q.LiDo.Contains(tu) ||q.DiaChi.Contains(tu) || q.TrangThai.Contains(tu) || q.MaTttv.Contains(tu)
                           select q;
                return list.ToList();
            }
                
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
            using (var conn = new QuanlitpContext())
            {
                var list = from q in conn.Tamtrutamvangs
                           select q;
                return list.ToList();
            }
        }
        public int LaySoLuong()
        {
            var list = LayDanhSach();
            return list.Count;
        }
    }
}
