using QuanLiCongDanThanhPho.Model;
using System.Data;


namespace QuanLiCongDanThanhPho
{
    internal class AccountDAO
    {
        public AccountDAO() { }
        QuanlitpContext db = DBConnection.Db;

        //Dùng update sau này khi cần xóa tài khoản.
        public void XoaTaiKhoan(Account acc)
        {
            db.Accounts.Remove(acc);
            db.SaveChanges();
            MessageBox.Show("Xóa tài khoản thành công");
        }

        public void CapNhatMatKhau(Account acc)
        {
            try
            {
                Account? acccount = db.Accounts.Find(acc.UserName);
                acccount.StrPassword = acc.StrPassword;
                db.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            catch
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }

        public void CapNhatDisplayName(Account acc)
        {
            Account? acccount = db.Accounts.Find(acc.UserName);
            acccount.DisplayName = acc.DisplayName;
            db.SaveChanges();
            MessageBox.Show("Đổi tên hiển thị thành công");
        }
        public Account? LayThongTinTaiKhoan(Account acc)
        {
            return db.Accounts.Where(p => p.UserName == acc.UserName).FirstOrDefault();
        }

        public bool DangKy(Account acc)
        {
            db.Accounts.Add(acc);
            db.SaveChanges();
            MessageBox.Show("Đăng ký thành công");
            return true;
        }

        public bool DangNhap(Account acc)
        {
            return db.Accounts.Where(p => p.UserName == acc.UserName && p.StrPassword == acc.StrPassword).Any();
        }
    }
}
