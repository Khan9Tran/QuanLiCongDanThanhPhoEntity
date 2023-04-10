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
    internal class CCCDDAO
    {
        QuanlitpContext db = DBConnection.Db;
        public void ThemCCCD(Cccd canCuoc)
        {
            db.Add(canCuoc);
            db.SaveChanges();
            MessageBox.Show("Them can cuoc thanh cong");
        }
        public void XoaCCCD(string maCanCuoc) 
        {
            Cccd cCCD= db.Cccds.Find(maCanCuoc);
            db.Remove(cCCD);
            db.SaveChanges();
            MessageBox.Show("Them can cuoc thanh cong");
        }
        public void CapNhatCCCD(Cccd canCuoc) 
        {
            Cccd cCCD = db.Cccds.Find(canCuoc.MaCccd);
            cCCD.NgayCap = canCuoc.NgayCap;
            cCCD.DacDiem = canCuoc.DacDiem;
            db.SaveChanges();
            MessageBox.Show("cap nhat thanh cong");
        }
        public List<Cccd> DanhSachCCCDTheoDacDiem(string dacDiem)
        {
            var list = db.Cccds.Where(q => q.DacDiem.Contains(dacDiem)).ToList();
            return list;
        }
        public Cccd LayThongTin(Cccd cCCD)
        {
            var canCuoc = db.Cccds.Find(cCCD.MaCccd);
            return canCuoc;
        }
    }
}
