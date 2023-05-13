using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiCongDanThanhPho.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace QuanLiCongDanThanhPho
{
    internal class ThueDAO
    {
        QuanlitpContext db = DBConnection.Db;
        public ThueDAO() { }
        public List<Thue> LayDanhSach()
        {
            var list = (from q in db.Thues select q).ToList();
            return list;
        }

        public bool ThemThue(Thue thue)
        {
            if (LayThongTinTheoMaSo(thue.MaThue) != null || LayThongTin(thue.Cccd) != null)
            {
                return false;
            }
            db.Thues.Add(thue);
            db.SaveChanges();
            return true;
        }

        public bool XoaThue(string canCuoc)
        {
            Thue? thue = LayThongTin(canCuoc);
            if (thue == null)
            {
                return false;
            }

            db.Thues.Remove(thue);
            db.SaveChanges();
            return true;
        }

        public Thue? LayThongTin(string maCCCD)
        {
            return db.Thues.Where(p => p.Cccd == maCCCD).FirstOrDefault();
        }

        public Thue? LayThongTinTheoMaSo(string maSo)
        {
            return db.Thues.Where(p => p.MaThue == maSo).FirstOrDefault();
        }
        public List<Thue> LayDanhSachChuaTu(string tu)
        {
            var list = (from q in db.Thues 
                        where q.SoTienDaNop.Contains(tu) || q.SoTienDaNop.Contains(tu) || q.MaThue.Contains(tu) || q.Cccd.Contains(tu)
                        select q
                        ).ToList();
            return list;
        }

        public List<Thue> LayDanhSachSoTienDaNop(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                       orderby q.SoTienDaNop ascending
                       select q;
            return list.ToList();
        }

        public List<Thue> LayDanhSachTreHan(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                       where q.HanNop < DateTime.Now && q.SoTienCanNop != "0"
                       select q;
            return list.ToList();
        }

        public void CapNhatThue() 
        {
            db.SaveChanges();
        }

        public int[] LayThongKeThue()
        {
            int[] thues = new int[4];
            thues[0] = (from q in db.Thues
                        let TongTienCanNop = Convert.ToInt32(q.SoTienCanNop)
                        select TongTienCanNop).Sum();
            thues[1] = (from q in db.Thues
                        let TongTienDaNop = Convert.ToInt32(q.SoTienDaNop)
                        select TongTienDaNop).Sum();
            thues[2] = thues[0] + thues[1];
            thues[3] = LayDanhSach().Count();
            return thues;
        }

        public int LaySoNguoiTreHan()
        {
            var list = (from q in db.Thues
                       where q.HanNop < DateTime.Now && q.SoTienCanNop != "0"
                       select q).ToList();
            return list.Count;
        }

        public List<Congdan> DuTuoiDongThue()
        {
            var list = from q in db.Thues
                        join p in db.Congdans
                        on q.Cccd equals p.Cccd
                        select p;
            var listCongDanDuTuoi = from q in db.Congdans
                                    join p in db.Khaisinhs on q.Cccd equals p.MaKs
                                    let years = DateTime.Now.Year - p.NgaySinh.Year
                                    let birthdayThisYear = p.NgaySinh.AddYears(years)
                                    where (DateTime.Now < birthdayThisYear && years - 1 >= 18) || (DateTime.Now >= birthdayThisYear && years >= 18)
                                    select q;

            var listChuaDongThue =(from q in  listCongDanDuTuoi select q).Except(list).ToList();
            return listChuaDongThue.ToList();
        }

        public DataTable LayDanhSachTienDongThueCacQuan()
        {
            CongDanDAO cDDAO = new CongDanDAO();
            DiaChi dc = new DiaChi();
            //var cacQuan = cDDAO.LayDanhSachDC();
            DataTable result = new DataTable();
            result.Columns.Add("Quận", typeof(string));
            result.Columns.Add("Tiền đã thu", typeof(int));

            var congDan = (
                from cd in db.Congdans
                join hk in db.Hokhaus on cd.MaHk equals hk.MaHk
                where hk.DiaChi != "Tạm trú" && hk.DiaChi != "Tạm vắng"
                select new
                {
                    Cccd = cd.Cccd,
                    DiaChi = hk.DiaChi
                }
            ).Concat(
                from tt in db.Tamtrutamvangs
                select new
                {
                    Cccd = tt.Cccd,
                    DiaChi = tt.DiaChi
                }
            );

            var cacQuan = congDan.AsEnumerable()
                .Select(d => dc.DinhDang(d.DiaChi))
                .Select(d => new
                {
                    Quan = dc.QuanHuyen,
                    SoLuongNguoi = 1
                })
                .GroupBy(x => x.Quan)
                .Select(g => new
                {
                    Quan = g.Key,
                    SoLuongNguoi = g.Count()
                })
                .OrderByDescending(x => x.SoLuongNguoi)
                .ToList();


            foreach (var row in cacQuan) {
                var query = (from q in db.Thues
                             join c in congDan on q.Cccd equals c.Cccd
                             where c.DiaChi.Contains(row.Quan)
                             group q by c.DiaChi into g
                             select new
                             {
                                 Quan = row.Quan,
                                 TienDaThu = g.Sum(x => Convert.ToInt32(x.SoTienDaNop))
                             }).ToList();
                foreach (var row1 in query)
                {
                    result.Rows.Add(row1.Quan, row1.TienDaThu);
                }
            }
            return result;
        }
    }
}
