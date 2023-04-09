using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Model;
using QuanLiCongDanThanhPho.Models;
namespace QuanLiCongDanThanhPho
{
    internal class CongDanDAO
    {
        DBConnection conn = new DBConnection();
        public CongDanDAO() { }
        public void ThemCongDan(Congdan cD)
        {   
            using (var conn = new QuanlitpContext())
            {
                conn.Congdans.Add(cD);
                conn.SaveChanges();
            }    
            CCCD cCCD = new CCCD(cD.Cccd);
            CCCDDAO cCCDDAO = new CCCDDAO();
            cCCDDAO.ThemCCCD(cCCD);
        }
        public void XoaCongDan(Congdan cD)
        {
            ThueDAO thueDAO = new ThueDAO();
            KhaiSinhDAO ksDAO = new KhaiSinhDAO();
            TamTruTamVangDAO tTTTVDAO = new TamTruTamVangDAO();
            HonNhanDAO hnDAO = new HonNhanDAO();
            CCCDDAO cCCCDAO = new CCCDDAO();
            thueDAO.XoaThue(cD.Cccd);
            ksDAO.XoaKhaiSinh(cD.Cccd);
            if (tTTTVDAO.KiemTraTamTruTamVang(cD.Cccd))
            {
                tTTTVDAO.XoaTamTruTamVang(cD.Cccd);
            }
            if (hnDAO.KiemTraHonNhan(cD.Cccd))
            {
                HonNhan hn = hnDAO.LayThongTin(cD.Cccd);
                hnDAO.Xoa(hn);
            }
            cCCCDAO.XoaCCCD(cD.Cccd);
            using (var conn = new QuanlitpContext())
            {
                Congdan congdan = conn.Congdans.Find(cD.Cccd);
                conn.Congdans.Remove(congdan);
                conn.SaveChanges();
            }    
        }
        public void CapNhatCongDan(Congdan cD )
        {
           using (var conn = new QuanlitpContext())
           {
                Congdan congDan = conn.Congdans.Find(cD.Cccd);
                congDan = cD;
                conn.SaveChanges();
           }    
        }
        public void ThayDoiHoKhau(Congdan cD)
        {
           using (var conn = new QuanlitpContext())
           {
                Congdan congDan = conn.Congdans.Find(cD.Cccd);
                congDan.MaHk = cD.MaHk;
                congDan.QuanHeVoiChuHo = cD.QuanHeVoiChuHo;
                conn.SaveChanges();
           }    
        }
        public void NhapHoKhau(Congdan cD)
        {
            using (var conn = new QuanlitpContext())
            {
                Congdan congDan = conn.Congdans.Find(cD.Cccd);
                congDan.MaHk = cD.MaHk;
                congDan.QuanHeVoiChuHo = "Vừa nhập hộ";
                conn.SaveChanges();
            }
        }
        public List<Congdan> LayDanhSach()
        {
           using (var conn = new QuanlitpContext()) 
            {
                var cDs = from q in conn.Congdans
                          select q;
                return cDs.ToList();
           }
        }
        public List<Congdan> LayDanhSachTheoHoKhau(string maHK)
        {
            using (var conn = new QuanlitpContext())
            {
                var cDs = from q in conn.Congdans
                          where q.MaHk.Contains(maHK)
                          select q;
                return cDs.ToList();
            }
        }
        public Congdan LayThongTin(string maCCCD)
        {
            using (var conn = new QuanlitpContext())
            {
                Congdan congDan = conn.Congdans.Where(q => q.Cccd == maCCCD).FirstOrDefault();
                return congDan;
            }    
        }
        public List<Congdan> LayDanhSachCongDanNam(string tu)
        {
            using (var conn = new QuanlitpContext())
            {
                var list = from q in conn.Congdans
                           join p in conn.Khaisinhs
                           on q.Cccd equals p.MaKs
                           where ((q.Ten.Contains(tu) || q.TonGiao.Contains(tu) || q.Sdt.Contains(tu) || q.Cccd.Contains(tu) || q.NgheNghiep.Contains(tu) || q.QuanHeVoiChuHo.Contains(tu) || q.MaHk.Contains(tu)) && p.GioiTinh == "m")
                           select q;
                return list.ToList();
            }   
           
        }
        public List<Congdan> LayDanhSachCongDanNu(string tu)
        {
            using (var conn = new QuanlitpContext())
            {
                var list = from q in conn.Congdans
                           join p in conn.Khaisinhs
                           on q.Cccd equals p.MaKs
                           where ((q.Ten.Contains(tu) || q.TonGiao.Contains(tu) || q.Sdt.Contains(tu) || q.Cccd.Contains(tu) || q.NgheNghiep.Contains(tu) || q.QuanHeVoiChuHo.Contains(tu) || q.MaHk.Contains(tu)) && p.GioiTinh == "f")
                           select q;
                return list.ToList();
            }
        }
        public List<Congdan> LayDanhSachDaKetHon(string tu)
        {
            using (var conn = new QuanlitpContext())
            {
                var list = from q in conn.Congdans
                           where ((from p in conn.Honnhans where q.Cccd == p.Cccdnu || q.Cccd == p.Cccdnam select p).Count() > 0 && (q.Ten.Contains(tu) || q.TonGiao.Contains(tu) || q.Sdt.Contains(tu) || q.Cccd.Contains(tu) || q.NgheNghiep.Contains(tu) || q.QuanHeVoiChuHo.Contains(tu) || q.MaHk.Contains(tu)))
                           select q;
                return list.ToList();
            }
        }
        public List<Congdan> LayDanhSachChuaKetHon(string tu)
        {
            using (var conn = new QuanlitpContext())
            {
                var list = from q in conn.Congdans
                           where ((from p in conn.Honnhans where q.Cccd == p.Cccdnu || q.Cccd == p.Cccdnam select p).Count() == 0 && (q.Ten.Contains(tu) || q.TonGiao.Contains(tu) || q.Sdt.Contains(tu) || q.Cccd.Contains(tu) || q.NgheNghiep.Contains(tu) || q.QuanHeVoiChuHo.Contains(tu) || q.MaHk.Contains(tu)))
                           select q;
                return list.ToList();
            }
        }
        public List<Congdan> LayDanhSachTuoiXepTuBeDenLon(string tu)
        {
            using (var conn = new QuanlitpContext())
            {
                var list = from q in conn.Congdans
                           join p in conn.Khaisinhs
                           on q.Cccd equals p.MaKs
                           where ((q.Ten.Contains(tu) || q.TonGiao.Contains(tu) || q.Sdt.Contains(tu) || q.Cccd.Contains(tu) || q.NgheNghiep.Contains(tu) || q.QuanHeVoiChuHo.Contains(tu) || q.MaHk.Contains(tu)))
                           orderby p.NgaySinh
                           select q;
                return list.ToList();
            }
        }
        public List<Congdan> LayDanhSachChuaTu(string tu)
        {
            using (var conn = new QuanlitpContext())
            {
                var list = from q in conn.Congdans
                           where (q.Ten.Contains(tu) || q.TonGiao.Contains(tu) || q.Sdt.Contains(tu) || q.Cccd.Contains(tu) || q.NgheNghiep.Contains(tu) || q.QuanHeVoiChuHo.Contains(tu) || q.MaHk.Contains(tu))
                           select q;
                return list.ToList();
            }
        }
        public int LaySoLuongCongDan()
        {
            return LayDanhSach().Count;
        }
        // Hàm tương tự như group by và count 1 cột nhưng cho DataTable
        private DataTable GroupByVaCountChoDataTable(DataTable dt, string tenCot1, string tenCot2)
        {
            var groups = dt.AsEnumerable().GroupBy(row => row[0]);
            var resultTable = new DataTable();
            resultTable.Columns.Add(tenCot1, typeof(object));
            resultTable.Columns.Add(tenCot2, typeof(int));
            foreach (var group in groups)
            {
                var value = group.Key;
                var count = group.Count();
                var newRow = resultTable.NewRow();
                newRow[tenCot1] = value;
                newRow[tenCot2] = count;
                resultTable.Rows.Add(newRow);
            }
            return resultTable;
        }
        public int LaySoNguoiTrungBinhCuaMotQuan()
        {
            int cnt = (int)LayDanhSachDiaChi().Compute("AVG([Số lượng người])", "");
            return cnt;
        }
        public DataTable LayDanhSachDiaChi()
        {
            DiaChi dc = new DiaChi();
            string sqlStr = string.Format("SELECT DiaChi FROM CONGDAN INNER JOIN HOKHAU ON CONGDAN.MaHK = HOKHAU.MaHK WHERE HOKHAU.DiaChi <> N'Tạm trú' AND HOKHAU.DiaChi <> N'Tạm vắng' UNION ALL SELECT DiaChi FROM TAMTRUTAMVANG");
            DataTable dt = conn.LayDanhSach(sqlStr);
            foreach(DataRow dr in dt.Rows)
            {
                dr["DiaChi"] = dc.DinhDang((string)dr["DiaChi"]);
                dr["DiaChi"] = dc.QuanHuyen;
            }
            return GroupByVaCountChoDataTable(dt, "Quận", "Số lượng người");
        }
        public DataTable LayDanhSachNgheNghiep()
        {
            string sqlStr = string.Format("SELECT NgheNghiep as 'Nghề nghiệp', COUNT(NgheNghiep) as 'Số lượng' FROM CONGDAN GROUP BY NgheNghiep");
            return conn.LayDanhSach(sqlStr);
        }
        public int LaySoLuongDocThan()
        {
            string strSql = string.Format($"SELECT COUNT(*) as SoLuong FROM (SELECT CD.CCCD, CD.Ten, CD.SDT, CD.NgheNghiep, CD.TonGiao FROM CONGDAN AS CD EXCEPT SELECT CONGDAN.CCCD, CONGDAN.Ten, CONGDAN.SDT, CONGDAN.NgheNghiep, CONGDAN.TonGiao FROM CONGDAN, HONNHAN WHERE CONGDAN.CCCD = HONNHAN.CCCDNam OR CONGDAN.CCCD = HONNHAN.CCCDNu) as CONGDAN \r\n          \r\n\r\n");
            DataTable dt = conn.LayDanhSach(strSql);
            int count = dt.Rows[0].Field<int>("SoLuong");
            return count;
        }
        public int LaySoLuongDaKetHon()
        {
            string strSql = string.Format($"SELECT COUNT(*) as SoLuong FROM (SELECT distinct * FROM CONGDAN INNER JOIN HONNHAN ON CONGDAN.CCCD = HONNHAN.CCCDNam OR CONGDAN.CCCD = HONNHAN.CCCDNu) as CONGDAN");
            DataTable dt = conn.LayDanhSach(strSql);
            int count = dt.Rows[0].Field<int>("SoLuong");
            return count;
        }
    }
}
