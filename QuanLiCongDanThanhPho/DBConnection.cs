using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public class DBConnection
    {
        private static QuanlitpContext db = new QuanlitpContext();
        public static QuanlitpContext Db { get => db; set => db = value; }

    }
}
