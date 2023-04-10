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
        DBConnection conn = new DBConnection();
        QuanlitpContext db = DBConnection.Db;
        public ThueDAO() { }
        public List<Thue> LayDanhSach()
        {
            var list = (from q in db.Thues select q).ToList();
            return list;
        }
        public void ThemThue(Thue thue)
        {
            db.Thues.Add(thue);
            db.SaveChanges();
            MessageBox.Show("Them thue thanh cong");
        }
        public void XoaThue(string canCuoc)
        {
            Thue thue = LayThongTin(canCuoc);
            db.Thues.Remove(thue);
            db.SaveChanges();
        }
        public Thue LayThongTin(string maCCCD)
        {
            return db.Thues.Where(p => p.Cccd == maCCCD).FirstOrDefault();
        }
        public List<Thue> LayDanhSachChuaTu(string tu)
        {
            var list = (from q in db.Thues 
                        where q.SoTienDaNop.Contains(tu) || q.SoTienDaNop.Contains(tu) || q.MaThue.Contains(tu) || q.Cccd.Contains(tu)
                        select q).ToList();
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
        public void CapNhatThue(Thue t) 
        {
            Thue thue = db.Thues.Find(t.MaThue);
            thue.HanNop = t.HanNop;
            thue.SoTienDaNop = t.SoTienDaNop;
            thue.SoTienCanNop = t.SoTienCanNop;
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
    }
}
