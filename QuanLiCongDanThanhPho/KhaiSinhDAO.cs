using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Models;
using System.Data.SqlTypes;
using System.Data;
using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    internal class KhaiSinhDAO
    {
        DBConnection conn = new DBConnection();
        QuanlitpContext db = new QuanlitpContext();
        public string StringKhaiSinh(KhaiSinh kS)
        {
            string sqlStr = string.Format($"INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy, GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('{kS.MaKhaiSinh}' , N'{kS.HoTen}', '{kS.NgaySinh}','{kS.NgayDangKy}', '{kS.GioiTinh}', N'{kS.DanToc}', N'{kS.QuocTich}', N'{kS.NoiSinh.toString()}', N'{kS.QueQuan.toString()}','{kS.CCCDCha}', N'{kS.TenCha}', '{kS.CCCDMe}', N'{kS.TenMe}');");
            return sqlStr;
        }
        public void CapNhatKhaiSinh(Khaisinh kS)
        {
         
            Khaisinh khaiSinh = db.Khaisinhs.Find(kS.MaKs);
            khaiSinh.NoiSinh = kS.NoiSinh;
            khaiSinh.NgaySinh = kS.NgaySinh;
            khaiSinh.QueQuan = kS.QueQuan;
            khaiSinh.DanToc = kS.DanToc;
            khaiSinh.Cccdcha= kS.Cccdcha;
            khaiSinh.Cccdme= kS.Cccdme;
            khaiSinh.QuocTich = kS.QuocTich;
            khaiSinh.Ten = kS.Ten;
            khaiSinh.GioiTinh = kS.GioiTinh;
            khaiSinh.TenCha = kS.TenCha;
            khaiSinh.TenMe = kS.TenMe;
            db.SaveChanges();

        }
        public void ThemKhaSinh(Khaisinh kS)
        {
            db.Khaisinhs.Add(kS);
            db.SaveChanges();
        }
        public void XoaKhaiSinh(string maKhaiSinh)
        {
            Khaisinh khaiSinh = db.Khaisinhs.Find(maKhaiSinh);
            db.Remove(khaiSinh);
            db.SaveChanges();
        }
        public Khaisinh LayThongTin(string maCCCD)
        {
                Khaisinh khaiSinh = db.Khaisinhs.Find(maCCCD);
                return khaiSinh;
        }
        public DataTable LayDanhSachVeSoNamNu()
        {
            string sqlStr = string.Format("SELECT GioiTinh as 'Giới tính', COUNT(*) as 'Số lượng' FROM KHAISINH RIGHT JOIN CONGDAN ON CONGDAN.CCCD = KHAISINH.MaKS GROUP BY GioiTinh");
            DataTable dt = conn.LayDanhSach(sqlStr);
            /*using (var conn = new QuanlitpContext())
            {
                var list = from q in conn.Khaisinhs join p in conn.Congdans on q.MaKs equals p.Cccd
                           group q by q.GioiTinh into g
                           select new
                           {
         
                           }
            }*/
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
        public Khaisinh LayThongTinhNamNuTheoTu(string tu, string dieuKien)
        {
                var khaiSinh = db.Khaisinhs.Where(q => q.NoiSinh.Contains(tu) || q.QueQuan.Contains(tu) || q.QuocTich.Contains(tu) || q.MaKs.Contains(tu) || q.DanToc.Contains(tu) || q.Cccdcha.Contains(tu) || q.Cccdme.Contains(tu) && q.GioiTinh == dieuKien).FirstOrDefault();
                return khaiSinh;
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
