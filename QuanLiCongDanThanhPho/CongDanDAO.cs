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
        QuanlitpContext db = DBConnection.Db;
        DBConnection conn = new DBConnection();
        public CongDanDAO() { }
        public void ThemCongDan(Congdan cD)
        {
            db.Congdans.Add(cD);
            db.SaveChanges();
            Cccd cCCD = new Cccd()
            {
                MaCccd = cD.Cccd
            };
            CCCDDAO cCCDDAO = new CCCDDAO();
            cCCDDAO.ThemCCCD(cCCD);
            MessageBox.Show("Thêm công dân thành công");
        }
        public void XoaCongDan(Congdan cD)
        {
            ThueDAO thueDAO = new ThueDAO();
            KhaiSinhDAO ksDAO = new KhaiSinhDAO();
            TamTruTamVangDAO tTTTVDAO = new TamTruTamVangDAO();
            HonNhanDAO hnDAO = new HonNhanDAO();
            CCCDDAO cCCCDAO = new CCCDDAO();
            Honnhan hn = hnDAO.LayThongTin(cD.Cccd);

            thueDAO.XoaThue(cD.Cccd);
            ksDAO.XoaKhaiSinh(cD.Cccd);
            tTTTVDAO.XoaTamTruTamVang(cD.Cccd);
            hnDAO.Xoa(hn);
            cCCCDAO.XoaCCCD(cD.Cccd);
            Congdan congdan = db.Congdans.Find(cD.Cccd);
            db.Congdans.Remove(congdan);
            db.SaveChanges();
            MessageBox.Show("Xoa thanh cong");
        }
        public void CapNhatCongDan()
        {    
            db.SaveChanges();
            MessageBox.Show("Cập nhật công dân thành công");
        }
        public void ThayDoiHoKhau(Congdan cD)
        {       
            Congdan congDan = db.Congdans.Find(cD.Cccd);
            congDan.MaHk = cD.MaHk;
            congDan.QuanHeVoiChuHo = cD.QuanHeVoiChuHo;
            db.SaveChanges();
            MessageBox.Show("Thay đổi hộ khẩu thành công");
        }
        public void NhapHoKhau(Congdan cD)
        {       
                Congdan congDan = db.Congdans.Find(cD.Cccd);
                congDan.MaHk = cD.MaHk;
                congDan.QuanHeVoiChuHo = "Vừa nhập hộ";
                db.SaveChanges();
        }
        public List<Congdan> LayDanhSach()
        {
                var cDs = from q in db.Congdans
                          select q;
                return cDs.ToList();
        }
        public List<Congdan> LayDanhSachTheoHoKhau(string maHK)
        {
            var cDs = from q in db.Congdans
                          where q.MaHk == maHK
                          select q;
            return cDs.ToList();
        }
        public Congdan LayThongTin(string maCCCD)
        {
            Congdan congDan = db.Congdans.Find(maCCCD);
            return congDan; 
        }
        public List<Congdan> LayDanhSachCongDanNam(string tu)
        {
             var list = from q in LayDanhSachChuaTu(tu)
                           join p in db.Khaisinhs
                           on q.Cccd equals p.MaKs
                           where p.GioiTinh == "m"
                           select q;
              return list.ToList();   
           
        }
        public List<Congdan> LayDanhSachCongDanNu(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                        join p in db.Khaisinhs
                        on q.Cccd equals p.MaKs
                        where (p.GioiTinh == "f")
                        select q;
            return list.ToList();
        }
        public List<Congdan> LayDanhSachDaKetHon(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                       where ((from p in db.Honnhans where q.Cccd == p.Cccdnu || q.Cccd == p.Cccdnam select p).Count() > 0)
                        select q;
            return list.ToList();
        }
        public List<Congdan> LayDanhSachChuaKetHon(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                        where ((from p in db.Honnhans where q.Cccd == p.Cccdnu || q.Cccd == p.Cccdnam select p).Count() == 0 )
                        select q;
            return list.ToList();
        }
        public List<Congdan> LayDanhSachTuoiXepTuBeDenLon(string tu)
        {
            var list = from q in LayDanhSachChuaTu(tu)
                        join p in db.Khaisinhs
                        on q.Cccd equals p.MaKs
                        orderby p.NgaySinh
                        select q;
            return list.ToList();
        }
        public List<Congdan> LayDanhSachChuaTu(string tu)
        {
            var list = from q in db.Congdans
                        where (q.Ten.Contains(tu) || q.TonGiao.Contains(tu) || q.Sdt.Contains(tu) || q.Cccd.Contains(tu) || q.NgheNghiep.Contains(tu) || q.QuanHeVoiChuHo.Contains(tu) || q.MaHk.Contains(tu))
                        select q;
            return list.ToList();
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
        public List<object> LayDanhSachNgheNghiep()
        {
            var result = db.Congdans
                            .GroupBy(g => g.NgheNghiep)
                            .Select(q => new
                            {
                                NgheNghiep = q.Key,
                                SoLuong = q.Count()
                            })
                            .Cast<object>()
                            .ToList();
            return result;
        }
        public int LaySoLuongDocThan()
        {
            return LayDanhSach().Count() - LaySoLuongDaKetHon(); 
        }
        public int LaySoLuongDaKetHon()
        {
            int slNam = (from q in db.Congdans join p in db.Honnhans on q.Cccd equals p.Cccdnam select q).Count();
            int slNu = (from q in db.Congdans join p in db.Honnhans on q.Cccd equals p.Cccdnu select q).Count();
            return slNam + slNu;
        }
    }
}
