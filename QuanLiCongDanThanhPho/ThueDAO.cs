using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Model;
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
            try
            {
                db.Thues.Add(thue);
                db.SaveChanges();
            }
            catch(Exception ex) 
            {
                return false;
            }
            return true;
        }

        public bool XoaThue(string canCuoc)
        {
            try
            {
                Thue? thue = LayThongTin(canCuoc);
                if (thue != null)
                {
                    db.Thues.Remove(thue);
                    db.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Thue? LayThongTin(string maCCCD)
        {
            return db.Thues.Where(p => p.Cccd == maCCCD).FirstOrDefault();
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
    }
}
