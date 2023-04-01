using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Models;
using System.Data.SqlTypes;
using System.Data;

namespace QuanLiCongDanThanhPho
{
    internal class KhaiSinhDAO
    {
        DBConnection conn = new DBConnection();
        public string StringKhaiSinh(KhaiSinh kS)
        {
            string sqlStr = string.Format($"INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy, GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('{kS.MaKhaiSinh}' , N'{kS.HoTen}', '{kS.NgaySinh}','{kS.NgayDangKy}', '{kS.GioiTinh}', N'{kS.DanToc}', N'{kS.QuocTich}', N'{kS.NoiSinh.toString()}', N'{kS.QueQuan.toString()}','{kS.CCCDCha}', N'{kS.TenCha}', '{kS.CCCDMe}', N'{kS.TenMe}');");
            return sqlStr;
        }
        public void CapNhatKhaiSinh(KhaiSinh kS)
        {
            string sqlStr = string.Format($"UPDATE KHAISINH SET  Ten = N'{kS.HoTen}', NgaySinh = '{kS.NgaySinh}', NgayDangKy = '{kS.NgayDangKy}', GioiTinh = '{kS.GioiTinh}', DanToc = N'{kS.DanToc}', QuocTich = N'{kS.QuocTich}', NoiSinh = N'{kS.NoiSinh.toString()}', QueQuan = N'{kS.QueQuan.toString()}', CCCDCha = '{kS.CCCDCha}', TenCha = N'{kS.TenCha}', CCCDMe = '{kS.CCCDMe}', TenMe = N'{kS.TenMe}' WHERE MaKS = '{kS.MaKhaiSinh}'");
            conn.ThucThi(sqlStr, "Cập nhật khai sinh thành công");
        }
        public void ThemKhaSinh(KhaiSinh kS)
        {
            string sqlStr = StringKhaiSinh(kS);
            conn.ThucThi(sqlStr,"Thêm khai sinh thành công");
        }
        public void XoaKhaiSinh(string maKhaiSinh)
        {
            string sqlStr = string.Format($"DELETE FROM KHAISINH WHERE MaKS = '{maKhaiSinh}'");
            conn.ThucThi(sqlStr, "Xóa khai sinh thành công");
        }
        public KhaiSinh LayThongTin(string maCCCD)
        {
            string strSql = string.Format("SELECT * FROM KHAISINH WHERE MaKS = '{0}'", maCCCD);
            return conn.LayThongTinKhaiSinh(strSql);
        }
        public DataTable LayDanhSachVeSoNamNu()
        {
            string sqlStr = string.Format("SELECT GioiTinh as 'Giới tính', COUNT(*) as 'Số lượng' FROM KHAISINH RIGHT JOIN CONGDAN ON CONGDAN.CCCD = KHAISINH.MaKS GROUP BY GioiTinh");
            DataTable dt = conn.LayDanhSach(sqlStr);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Giới tính"] != DBNull.Value && (string)dr["Giới tính"] == "f")
                    dr["Giới tính"] = "Nữ";
                else if (dr["Giới tính"] != DBNull.Value && (string)dr["Giới tính"] == "m")
                    dr["Giới tính"] = "Nam";
                else
                    dr["Giới tính"] = "Unknown";
            }
            return dt;
        }
        public KhaiSinh LayThongTinNamNuTheoTu(string tu, string dieuKien)
        {
            string strSql = string.Format($"SELECT * FROM KHAISINH WHERE MaKS like '%{tu}%'");
            if (dieuKien.Length > 0)
            {
                strSql += string.Format($" AND GioiTinh = '{dieuKien}'");
            }
            return conn.LayThongTinKhaiSinh(strSql);
        }
        private int[] SoLuongNguoiTrongNhomTuoi(DataTable dt)
        {
            int[] cntNhomTuoi = { 0, 0 ,0 };
            foreach (DataRow dr in dt.Rows)
            {
                if ((int)dr["SoTuoi"] < 15)
                    cntNhomTuoi[0]++;
                else if ((int)dr["SoTuoi"] >= 15 && (int)dr["SoTuoi"] <= 64)
                    cntNhomTuoi[1]++;
                else
                    cntNhomTuoi[2]++;
            }
            return cntNhomTuoi;
        }
        public DataTable LayTuoiCongDan()
        {
            string sqlStr = string.Format("SELECT YEAR(GETDATE()) - YEAR(NgaySinh) as SoTuoi FROM KHAISINH");
            DataTable duLieu = conn.LayDanhSach(sqlStr);
            DataTable dtNhomTuoi = new DataTable();
            dtNhomTuoi.Clear();
            dtNhomTuoi.Columns.Add("Nhóm tuổi");
            dtNhomTuoi.Columns.Add("Số lượng");
            int[] soLuongNhomTuoi = SoLuongNguoiTrongNhomTuoi(duLieu);
            DataRow row1 = dtNhomTuoi.NewRow();
            row1["Nhóm tuổi"] = "0-14";
            row1["Số lượng"] = soLuongNhomTuoi[0];
            DataRow row2 = dtNhomTuoi.NewRow();
            row2["Nhóm tuổi"] = "15-64";
            row2["Số lượng"] = soLuongNhomTuoi[1];
            DataRow row3 = dtNhomTuoi.NewRow();
            row3["Nhóm tuổi"] = "65+";
            row3["Số lượng"] = soLuongNhomTuoi[2];
            dtNhomTuoi.Rows.Add(row1);
            dtNhomTuoi.Rows.Add(row2);
            dtNhomTuoi.Rows.Add(row3);
            return dtNhomTuoi;
        }
    }
}
