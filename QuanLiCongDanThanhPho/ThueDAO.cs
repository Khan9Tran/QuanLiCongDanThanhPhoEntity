using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    /*
    class GenObj<T> where T : class
    {
        public List<T> LayDanhSach() //generic
        {
            var list = (from q in db.T select q).ToList();
            return list;
        }
    }
    */
    internal class ThueDAO
    {
        QuanlitpContext db = DBConnection.Db;
        DBConnection conn = new DBConnection();
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
            if (thue != null)
            {
                db.Thues.Remove(thue);
                db.SaveChanges();
                MessageBox.Show("Xóa thuế thành công");
            }
        }
        public Thue LayThongTin(string maCCCD)
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
            MessageBox.Show("Cập nhật thuế thành công");
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
