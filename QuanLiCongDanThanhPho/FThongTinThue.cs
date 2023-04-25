using QuanLiCongDanThanhPho.Model;
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
    public partial class FThongTinThue : Form
    {
        private string maCCCD;

        ThueDAO thueDAO;
        CongDanDAO cdDAO;
        HoKhauDAO hkDAO;

        //Dùng để kéo thả form
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        public string MaCCCD { get => maCCCD; set => maCCCD = value; }

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
            thueDAO = new ThueDAO();
            cdDAO = new CongDanDAO();
            hkDAO = new HoKhauDAO();
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
        private void LayThongTinThue()
        {
            if (MaCCCD != null)
            {
                Thue thue = thueDAO.LayThongTin(MaCCCD);
                Congdan cd = cdDAO.LayThongTin(MaCCCD);
                Hokhau hk = hkDAO.LayThongTin(cd.MaHk);

                txtMaSoThue.Text = thue.MaThue;
                txtTen.Text = cd.Ten;
                txtCCCD.Text = cd.Cccd;
                txtSdt.Text = cd.Sdt;
                txtDiaChi.Text = hk.DiaChi;
                txtSoTienCanNop.Text = thue.SoTienCanNop;
                txtSoTienDaNop.Text = thue.SoTienDaNop;
                dtmNgayCapMaSoThue.Value = thue.NgayCap.Value;
                dtmHanNopThue.Value = thue.HanNop.Value;
            }
        }
        private void FThongTinThue_Load(object sender, EventArgs e)
        {
            LayThongTinThue();
        }

        //Tạo kéo thả form
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        private void CapNhatThue()
        {
            Thue thue = thueDAO.LayThongTin(MaCCCD);

            if (txtMaSoThue.Text != "")
            {
                thue.Cccd = txtCCCD.Text;
                thue.SoTienCanNop = txtSoTienCanNop.Text;
                thue.SoTienDaNop = txtSoTienDaNop.Text;
                thue.NgayCap = dtmNgayCapMaSoThue.Value;
                thue.HanNop = dtmHanNopThue.Value;
            }

            thueDAO.CapNhatThue();
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
