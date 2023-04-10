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
    internal class ThueDAO
    {
        QuanlitpContext db = DBConnection.Db;
        DBConnection conn = new DBConnection();
        public ThueDAO() { }
        public List<Model.Thue> LayDanhSach()
        {
            using (var conn = new QuanlitpContext())
            {
                var thues = from q in conn.Thues
                            select q;
                return thues.ToList();
            }
        }
        public void ThemThue(Model.Thue thue)
        {
            using (var conn = new QuanlitpContext())
            {
                conn.Thues.Add(thue);
                conn.SaveChanges();
            }
        }
        public void XoaThue(string canCuoc)
        {
            Model.Thue result = db.Thues.Where(x => x.Cccd == canCuoc).SingleOrDefault();
            db.Thues.Remove(result);
            db.SaveChanges();
        }

        public Model.Thue LayThongTin(string MaCCCD)
        {
            using (var conn = new QuanlitpContext())
            {
                var thue = conn.Thues.First(q => q.Cccd == MaCCCD);
                return thue;
            }
        }
        public string ChuoiLayDanhSachTheoTu(string tu)
        {
            string str = string.Format($"SELECT MaThue as 'Mã thuế', CCCD, SoTienCanNop as 'Số tiền cần nộp', HanNop as 'Hạn nộp' FROM THUE WHERE (MaThue like '%{tu}%' OR CCCD like '%{tu}%' OR SoTienCanNop like '%{tu}%' OR Convert(varchar,Format(HanNop, 'dd/MM/yyyy')) like '%{tu}%')");
            return str;
        }
        public List<Model.Thue> LayDanhSachChuaTu(string tu)
        {
            var result = from q in db.Thues
                         where q.MaThue.Contains(tu) || q.SoTienCanNop.Contains(tu) || q.SoTienDaNop.Contains(tu)
                         select q;
            return result.ToList();
        }
        public List<Model.Thue> LayDanhSachSoTienDaNop(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                       orderby q.SoTienDaNop ascending
                       select q;
            return list.ToList();
        }
        public List<Model.Thue> LayDanhSachTreHan(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                       where q.HanNop < DateTime.Now
                       select q;
            return list.ToList();
        }
        public void CapNhatThue(Model.Thue thue)
        {
            using (var conn = new QuanlitpContext())
            {
                var thues = conn.Thues.FirstOrDefault(q => q.MaThue == thue.MaThue);
                if (thue != null)
                {
                    thues.SoTienDaNop = thue.SoTienDaNop.ToString();
                    thues.SoTienCanNop = thue.SoTienCanNop.ToString();
                    conn.SaveChanges();
                    MessageBox.Show("Cập nhật thuế thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật hộ khẩu thất bại");
                }
            }
        }

        public int[] LayThongKeThue()
        {
            string sqlStr = string.Format("SELECT SUM(CONVERT(INT,SoTienCanNop)) as TongTienCanNop, SUM(CONVERT(INT,SoTienDaNop)) as TongTienDaNop, COUNT(*) as SL FROM THUE");
            DataTable dt = conn.LayDanhSach(sqlStr);
            int[] thues = new int[4];
            thues[0] = dt.Rows[0].Field<int>("TongTienCanNop");
            thues[1] = dt.Rows[0].Field<int>("TongTienDaNop");
            thues[2] = thues[0] + thues[1];
            thues[3] = dt.Rows[0].Field<int>("SL");
            return thues;
        }
        public int LaySoNguoiTreHan()
        {
            string sqlStr = string.Format("SELECT COUNT(*) as SL FROM THUE WHERE GETDATE() > THUE.HanNop");
            DataTable dt = conn.LayDanhSach(sqlStr);
            int cnt = dt.Rows[0].Field<int>("SL");
            return cnt;
        }
    }
}
