using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Model;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Principal;
using System.Windows.Forms;

namespace QuanLiCongDanThanhPho
{
    internal class AccountDAO
    {
        public AccountDAO() { }
        QuanlitpContext db = DBConnection.Db;
        public void XoaTaiKhoan(Account acc)
        {
            db.Accounts.Remove(acc);
            db.SaveChanges();
            MessageBox.Show("Xoa tai khoan thanh cong");
        }
        public void CapNhatMatKhau(Account acc)
        {
            Account acccount = db.Accounts.Find(acc.UserName);
            acccount.StrPassword = acc.StrPassword;
            db.SaveChanges();
            MessageBox.Show("Doi mat khau thanh cong");
        }
        public void CapNhatDisplayName(Account acc)
        {
            Account acccount = db.Accounts.Find(acc.UserName);
            acccount.DisplayName = acc.DisplayName;
            db.SaveChanges();
            MessageBox.Show("Doi ten hien thi thanh cong");
        }
        public Account LayThongTinTaiKhoan(Account acc)
        {
            return db.Accounts.Where(p => p.UserName == acc.UserName).FirstOrDefault();
        }
        public void CapNhatThongTin(Account acc)
        {

        }
        public bool DangNhap(Account acc)
        {
            return db.Accounts.Where(p => p.UserName == acc.UserName && p.StrPassword == acc.StrPassword).Any();
        }
    }
}
