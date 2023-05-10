using System.Data;
using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    internal class CCCDDAO
    {
        QuanlitpContext db = DBConnection.Db;
        public bool ThemCCCD(Cccd canCuoc)
        {
            if (LayThongTin(canCuoc.MaCccd) != null)
                return false;
            db.Add(canCuoc);
            db.SaveChanges();
            return true;
        }

        public bool XoaCCCD(string maCanCuoc) 
        {
           
            Cccd? cCCD = LayThongTin(maCanCuoc);

            if (cCCD == null)
            {
                return false;
            }

            db.Remove(cCCD);
            db.SaveChanges();
            return true;
        }

        public void CapNhatCCCD() 
        {
            db.SaveChanges();
        }

        public Cccd? LayThongTin(string maCanCuoc)
        {
            Cccd? cCCD = db.Cccds.Where(p => p.MaCccd == maCanCuoc).FirstOrDefault();
            return cCCD;
        }
        public List<Object> DanhSachCCCDTheoDacDiem()
        {
            var cccds = db.Cccds.Where(q => q.DacDiem == null);
            var list = (from q in cccds
                        join p in db.Congdans on q.MaCccd equals p.Cccd
                        select new { p.Ten, q.MaCccd, q.NgayCap, q.DacDiem }).Cast<Object>().ToList();  
            return list;
        }

        static public string GetCCCD(DataGridView gvDanhSach, int index)
        {
            return (string)gvDanhSach.CurrentRow.Cells[index].Value;
        }

        public Cccd? LayThongTin(Cccd cCCD)
        {
            Cccd? canCuoc = db.Cccds.Where(p => p.MaCccd == cCCD.MaCccd).FirstOrDefault();
            return canCuoc;
        }
    }
}
