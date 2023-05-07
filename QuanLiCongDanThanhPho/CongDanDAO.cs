using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace QuanLiCongDanThanhPho
{
    internal class CongDanDAO
    {
        QuanlitpContext db = DBConnection.Db;
        public CongDanDAO() { }
        public bool ThemCongDan(Congdan cD)
        {
            if (LayThongTin(cD.Cccd) != null)
                return false;
            db.Congdans.Add(cD);
            db.SaveChanges();

            Cccd cCCD = new Cccd()
            {
                MaCccd = cD.Cccd
            };

            CCCDDAO cCCDDAO = new CCCDDAO();
            cCCDDAO.ThemCCCD(cCCD);
            return true;
   
        }
        public bool XoaCongDan(Congdan cD)
        {
            Congdan tmp = LayThongTin(cD.Cccd);
            if (tmp == null) 
                return false;

            ThueDAO thueDAO = new ThueDAO();
            KhaiSinhDAO ksDAO = new KhaiSinhDAO();
            TamTruTamVangDAO tTTTVDAO = new TamTruTamVangDAO();
            HonNhanDAO hnDAO = new HonNhanDAO();
            CCCDDAO cCCCDAO = new CCCDDAO();
            Honnhan? hn = hnDAO.LayThongTin(cD.Cccd);

            thueDAO.XoaThue(cD.Cccd);
            ksDAO.XoaKhaiSinh(cD.Cccd);
            tTTTVDAO.XoaTamTruTamVang(cD.Cccd);
            if (hn != null)
                hnDAO.Xoa(hn);

            cCCCDAO.XoaCCCD(cD.Cccd);

            db.Congdans.Remove(cD);
            db.SaveChanges();
            return true;
        }
        public void CapNhatCongDan()
        {
            db.SaveChanges();
        }
        public bool ThayDoiHoKhau(Congdan cD)
        {
            try
            {
                Congdan? congDan = db.Congdans.Find(cD.Cccd);
                if (congDan != null)
                {
                    congDan.MaHk = cD.MaHk;
                    congDan.QuanHeVoiChuHo = cD.QuanHeVoiChuHo;
                    db.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            MessageBox.Show("Thay đổi hộ khẩu thành công");
            return true;
        }
        public bool NhapHoKhau(Congdan cD)
        {
            try
            {
                Congdan? congDan = db.Congdans.Find(cD.Cccd);
                if (congDan != null)
                {
                    congDan.MaHk = cD.MaHk;
                    congDan.QuanHeVoiChuHo = "Vừa nhập hộ";
                    db.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
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

        public Congdan? LayThongTin(string maCCCD)
        {
            Congdan? congDan = db.Congdans.Find(maCCCD);
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
                       where ((from p in db.Honnhans where q.Cccd == p.Cccdnu || q.Cccd == p.Cccdnam select p).Count() == 0)
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

        public int LaySoNguoiTrungBinhMotQuan()
        {
            var ds = LayDanhSachDC();
            var avgSoLuongNguoi = ds
                    .Select(x => (int)x.GetType().GetProperty("SoLuongNguoi").GetValue(x, null))
                    .Average();
            return (int)avgSoLuongNguoi;
        }
        public List<object> LayDanhSachDC()
        {
            DiaChi dc = new DiaChi();
            var query = (
                from cd in db.Congdans
                join hk in db.Hokhaus on cd.MaHk equals hk.MaHk
                where hk.DiaChi != "Tạm trú" && hk.DiaChi != "Tạm vắng"
                select hk.DiaChi
            ).Concat(
                from tt in db.Tamtrutamvangs
                select tt.DiaChi
            );

            var result = query.AsEnumerable()
                .Select(dc.DinhDang)
                .Select(d => new
                {
                    Quan = dc.QuanHuyen,
                    SoLuongNguoi = 1
                })
                .GroupBy(x => x.Quan)
                .Select(g => new
                {
                    Quan = g.Key,
                    SoLuongNguoi = g.Count()
                })
                .Cast<object>()
                .ToList();

            return result;

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
