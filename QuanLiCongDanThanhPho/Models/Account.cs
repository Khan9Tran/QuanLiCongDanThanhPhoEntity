using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho.Models
{
    public class Account
    {
        private string userName;
        private string password;
        private string displayName;
        private int type;

        public Account() 
        {
            userName = "unknow";
            password = "unknow";
            displayName = "unknow";
            type = -1;
        }
        public Account(string userName, string password, string displayName, int type)
        {
            this.userName = userName;
            this.password = password;
            this.displayName = displayName;
            this.type = type;
        }
        public Account(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Type { get => type;set => type = value; }
    }
}
