using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongKeThue : Form
    {
        ThueDAO thueDAO = new ThueDAO();
        public FThongKeThue()
        {
            InitializeComponent();
            StackForm.Add(this);
        }

        private string DinhDangTienTe(string s)
        {
            string result = s;
            for (int i = result.Length-3; i > 0; i -= 3)
            {
                result = result.Insert(i, ".");
            }
            return result +" VND";
        }
        private void FThongKeThue_Load(object sender, EventArgs e)
        {
            int[] thues = thueDAO.LayThongKeThue();
            int soNguoiTreHan = thueDAO.LaySoNguoiTreHan();
            lblTongTienThue.Text += " " + DinhDangTienTe(thues[2].ToString());
            lblTongThueCanDong.Text += " " + DinhDangTienTe(thues[1].ToString());
            lblTongThueDaDong.Text += " " + DinhDangTienTe(thues[0].ToString());
            lblTrungBinhThue.Text += " " + DinhDangTienTe(((int)(thues[2] / thues[3])).ToString());
            lblSoNguoiTreHan.Text += " " + soNguoiTreHan.ToString();
        }
    }
}
