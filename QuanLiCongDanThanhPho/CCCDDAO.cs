using System.Data;
using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    internal class CCCDDAO
    {
        QuanlitpContext db = DBConnection.Db;
        public void ThemCCCD(Cccd canCuoc)
        {
            db.Add(canCuoc);
            db.SaveChanges();
            MessageBox.Show("Thêm căn cước thành công");
        }

        public void XoaCCCD(string maCanCuoc) 
        {
            Cccd? cCCD = db.Cccds.Where(p => p.MaCccd == maCanCuoc).FirstOrDefault();
            if (cCCD != null)
            {
                db.Remove(cCCD);
                db.SaveChanges();
            }
            MessageBox.Show("Xóa căn cước thành công");
        }

        public void CapNhatCCCD(Cccd canCuoc) 
        {
            Cccd? cCCD = db.Cccds.Where(p => p.MaCccd == canCuoc.MaCccd).FirstOrDefault();
            if (cCCD != null)
            {
                cCCD.NgayCap = canCuoc.NgayCap;
                cCCD.DacDiem = canCuoc.DacDiem;
                db.SaveChanges();
            }
            MessageBox.Show("Cập nhật căn cước thành công");
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
