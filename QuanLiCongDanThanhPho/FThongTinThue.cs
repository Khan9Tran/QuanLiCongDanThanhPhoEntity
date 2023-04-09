using QuanLiCongDanThanhPho.Model;
using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinThue : Form
    {
        private string maCCCD;
        ThueDAO thueDAO = new ThueDAO();
        CongDanDAO cdDAO = new CongDanDAO();
        HoKhauDAO hkDAO = new HoKhauDAO();
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }
        public FThongTinThue()
        {
            InitializeComponent();
            StackForm.Add(this);
        }
        public FThongTinThue(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            StackForm.Add(this);
        }
        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isTien(txtSoTienCanNop.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số tiền cần nộp");
                txtSoTienCanNop.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isTien(txtSoTienDaNop.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số tiền đã nộp");
                txtSoTienDaNop.Focus();
                return false;
            }   
            return true;
        }
        private void ReadOnly()
        {
            txtSoTienCanNop.ReadOnly = true;
            txtSoTienCanNop.BackColor = Color.Gainsboro;
            txtSoTienDaNop.ReadOnly = true;
            txtSoTienDaNop.BackColor = Color.Gainsboro;
            dtmHanNopThue.Enabled = false;
            dtmNgayCapMaSoThue.Enabled = false;
            btnXacNhan.Enabled = false;
        }
        private void UnReanOnly()
        {
            txtSoTienCanNop.ReadOnly = false;
            txtSoTienCanNop.BackColor = Color.SteelBlue;
            txtSoTienDaNop.ReadOnly = false;
            txtSoTienDaNop.BackColor = Color.SteelBlue;
            dtmHanNopThue.Enabled = true;
            dtmNgayCapMaSoThue.Enabled = true;
            btnXacNhan.Enabled = true;
        }
        private void AutoReadOnly()
        {
            if (txtSoTienCanNop.ReadOnly == false)
            {
                ReadOnly();
            }
            else
            {
                UnReanOnly();
            } 
                
        }
        private string DinhDangTienTe(string s)
        {
            string result = s;
            for (int i = result.Length - 3; i > 0; i -= 3)
            {
                result = result.Insert(i, ".");
            }
            return result + " VND";
        }

        private void LayThongTinThue()
        {
            if (MaCCCD != null)
            {
                Models.Thue thue = thueDAO.LayThongTin(MaCCCD);
                Congdan cd = cdDAO.LayThongTin(MaCCCD);
                Hokhau hk = hkDAO.LayThongTin(cd.MaHk);
                txtMaSoThue.Text = thue.MaThue;
                txtTen.Text = cd.Ten;
                txtCCCD.Text = cd.Cccd;
                txtSdt.Text = cd.Sdt;
                txtDiaChi.Text = hk.DiaChi;
                txtSoTienCanNop.Text = DinhDangTienTe(thue.SoTienCanNop);
                txtSoTienDaNop.Text = DinhDangTienTe(thue.SoTienDaNop);
                dtmNgayCapMaSoThue.Value = thue.NgayCapMa;
                dtmHanNopThue.Value = thue.HanNop;
            }
        }
        private void FThongTinThue_Load(object sender, EventArgs e)
        {
            LayThongTinThue();
        }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        private void CapNhatThue()
        {
            Models.Thue thue = thueDAO.LayThongTin(MaCCCD);
            if (txtMaSoThue.Text != "")
            {
                thue.CCCD = txtCCCD.Text;
                thue.SoTienCanNop = txtSoTienCanNop.Text;
                thue.SoTienDaNop = txtSoTienDaNop.Text;
                thue.NgayCapMa = dtmNgayCapMaSoThue.Value;
                thue.HanNop = dtmHanNopThue.Value;
            }
            thueDAO.CapNhatThue(thue);
        }    
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                CapNhatThue();
                LayThongTinThue();
                ReadOnly();
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AutoReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinThue();
            ReadOnly();
        }
    }
}
