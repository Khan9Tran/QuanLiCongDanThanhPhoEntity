using QuanLiCongDanThanhPho.Models;
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
        public ThueDAO() { }
        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT MaThue as 'Mã thuế', CCCD, SoTienCanNop as 'Số tiền cần nộp', HanNop as 'Hạn nộp' FROM THUE");
        }
        public void ThemThue(Models.Thue thue)
        {
            string sqlStr = string.Format($"INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('{thue.MaThue}','{thue.CCCD}', '{thue.SoTienCanNop}','{thue.SoTienDaNop}', '{thue.NgayCapMa}', '{thue.HanNop}');");
            conn.ThucThi(sqlStr,"Thêm thông tin thuế thành công");
        }
        public void XoaThue(string canCuoc)
        {
            string sqlStr = string.Format($"DELETE FROM THUE WHERE CCCD = '{canCuoc}'");
            conn.ThucThi(sqlStr, "Xóa thông tin thuế thành công");
        }
        public Models.Thue LayThongTin(string maCCCD)
        {
            /*string sqlStr = string.Format("SELECT * FROM THUE WHERE CCCD = {0}", maCCCD);
            return conn.LayThongTinThue(sqlStr);*/
            return null;
        }
        public string ChuoiLayDanhSachTheoTu(string tu)
        {
            string str = string.Format($"SELECT MaThue as 'Mã thuế', CCCD, SoTienCanNop as 'Số tiền cần nộp', HanNop as 'Hạn nộp' FROM THUE WHERE (MaThue like '%{tu}%' OR CCCD like '%{tu}%' OR SoTienCanNop like '%{tu}%' OR Convert(varchar,Format(HanNop, 'dd/MM/yyyy')) like '%{tu}%')");
            return str;
        }
        public DataTable LayDanhSachChuaTu(string tu)
        {
            string strSql = ChuoiLayDanhSachTheoTu(tu);
            return conn.LayDanhSach(strSql);
        }
        public DataTable LayDanhSachSoTienDaNop(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu) + " ORDER BY SoTienDaNop ASC";
            return conn.LayDanhSach(sqlStr);
        }
        public DataTable LayDanhSachTreHan(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu) + " AND GETDATE() > THUE.HanNop";
            return conn.LayDanhSach(sqlStr);
        }
        public void CapNhatThue(Models.Thue thue) 
        {
            /* string sqlStr = string.Format($"UPDATE THUE SET CCCD = '{thue.CCCD}', SoTienCanNop = '{thue.SoTienCanNop}', SoTienDaNop = '{thue.SoTienDaNop}', NgayCap = '{thue.NgayCapMa}', HanNop = '{thue.HanNop}' WHERE MaThue = '{thue.MaThue}'");
             conn.ThucThi(sqlStr, $"Cập nhật thuế thành công");*/
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
