using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho.Models
{
    internal class Thue
    {
        private string maThue;
        private string cCCD;
        private DateTime ngayCapMa;
        private DateTime hanNop;
        private string soTienCanNop;
        private string soTienDaNop;

        public Thue() 
        {
            ngayCapMa = DateTime.Now;
            hanNop = DateTime.Now;
            soTienCanNop = "0";
            soTienDaNop = "0";
        }
        public Thue(string maThue, string cCCD, DateTime ngayCapMa, DateTime hanNop, string soTienCanNop, string soTienDaNop)
        {
            this.maThue = maThue;
            this.cCCD = cCCD;
            this.ngayCapMa = ngayCapMa;
            this.hanNop = hanNop;
            this.soTienCanNop = soTienCanNop;
            this.soTienDaNop = soTienDaNop;
        }
        public Thue(string maThue, string cCCD)
        {
            this.maThue = maThue;
            this.cCCD = cCCD;
            this.ngayCapMa = DateTime.Now;
            this.hanNop = DateTime.Now;
            this.soTienCanNop = "0";
            this.soTienDaNop = "0";
        }
        public string MaThue { get => maThue; set => maThue = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public DateTime NgayCapMa { get => ngayCapMa; set => ngayCapMa = value; }
        public DateTime HanNop { get => hanNop; set => hanNop = value; }
        public string SoTienCanNop { get => soTienCanNop; set => soTienCanNop = value; }
        public string SoTienDaNop { get => soTienDaNop; set => soTienDaNop = value; }
    }
}
