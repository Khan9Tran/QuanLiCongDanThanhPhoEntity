using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    internal class CCCDDAO
    {
        DBConnection conn = new DBConnection();
        public void ThemCCCD(CCCD canCuoc)
        {
            string sqlStr = string.Format($"INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('{canCuoc.MaCCCD}', N'{canCuoc.DacDiem}', '{canCuoc.NgayCap}');");
            conn.ThucThi(sqlStr, "Căn cước đã khởi tạo");
        }
        public void XoaCCCD(string maCanCuoc) 
        {
            string sqlStr = string.Format($"DELETE FROM CCCD WHERE MaCCCD = '{maCanCuoc}'");
            conn.ThucThi(sqlStr, "Xóa căn cước thành công");
        }
        public void CapNhatCCCD(CCCD canCuoc) 
        {
            string sqlStr = string.Format($"UPDATE CCCD SET DacDiem = N'{canCuoc.DacDiem}', NgayCap = '{canCuoc.NgayCap}' WHERE MaCCCD = '{canCuoc.MaCCCD}'");
            conn.ThucThi(sqlStr, "Cấp căn cước thành công");
        }
        public DataTable DanhSachCCCDTheoDacDiem(string dacDiem)
        {
            string sqlStr = string.Format($"SELECT CCCD.MaCCCD, CONGDAN.Ten FROM CCCD INNER JOIN CONGDAN ON CCCD.MaCCCD = CONGDAN.CCCD WHERE DacDiem = N'{dacDiem}'");
            return conn.LayDanhSach(sqlStr);
        }
        public CCCD LayThongTin(CCCD cCCD)
        {
            string sqlStr = string.Format($"SELECT * FROM CCCD WHERE MaCCCD = '{cCCD.MaCCCD}'");
            return conn.LayThongTinCCCD(sqlStr);
        }
    }
}
