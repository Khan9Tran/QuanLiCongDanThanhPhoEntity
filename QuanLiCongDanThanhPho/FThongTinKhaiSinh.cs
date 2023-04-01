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

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinKhaiSinh : Form
    {
        private string maCCCD;
        KhaiSinhDAO ksDAO = new KhaiSinhDAO();
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }
        public FThongTinKhaiSinh()
        {
            InitializeComponent();
        }
        public FThongTinKhaiSinh(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            StackForm.Add(this);
        }
        private void btnThongTinCha_Click(object sender, EventArgs e)
        {
            if (txtCccdCha.Text != "" && txtCccdCha.Text != "unknow")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(txtCccdCha.Text);
                tTCD.ShowDialog();
            }
        }
        private void ReadOnly()
        {
            txtGioiTinh.ReadOnly = true;
            txtGioiTinh.BackColor = Color.Gainsboro;
            txtQuocTich.ReadOnly= true;
            txtQuocTich.BackColor = Color.Gainsboro;
            txtDanToc.ReadOnly= true;
            txtDanToc.BackColor = Color.Gainsboro;
            txtQueQuan.ReadOnly = true;
            txtQueQuan.BackColor = Color.Gainsboro; 
            txtNoiSinh.ReadOnly = true;
            txtNoiSinh.BackColor= Color.Gainsboro;
            btnXacNhan.Enabled = false;
            dtmNgaySinh.Enabled = false;
            dtmNgayDangKy.Enabled = false;
        }
        private void UnReadOnLy()
        {
            txtGioiTinh.ReadOnly = false;
            txtGioiTinh.BackColor = Color.SteelBlue;
            txtQuocTich.ReadOnly = false;
            txtQuocTich.BackColor = Color.SteelBlue;
            txtDanToc.ReadOnly = false;
            txtDanToc.BackColor = Color.SteelBlue;
            txtQueQuan.ReadOnly = false;
            txtQueQuan.BackColor = Color.SteelBlue;
            txtNoiSinh.ReadOnly = false;
            txtNoiSinh.BackColor = Color.SteelBlue;
            btnXacNhan.Enabled = true;
            dtmNgaySinh.Enabled = true;
            dtmNgayDangKy.Enabled = true;
        }
        private void AutoReadOnly()
        {
            if (txtGioiTinh.ReadOnly == false)
            {
                ReadOnly();
            }    
            else
            {
                UnReadOnLy();
            }    
        }
        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isGioiTinh(txtGioiTinh.Text))
            {
                MessageBox.Show("Giới tính sai địng dạng");
                txtGioiTinh.Focus();
                return false;
            }
            if (txtQuocTich.Text == "")
            {
                MessageBox.Show("Quốc tịch không được để trống");
                txtQuocTich.Focus();
                return false;
            }
            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Dân tộc không được để trống");
                txtDanToc.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                MessageBox.Show("Quê quán sai địng dạng");
                txtQueQuan.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtNoiSinh.Text))
            {
                MessageBox.Show("Nơi sinh sai địng dạng");
                txtNoiSinh.Focus();
                return false;
            }
            return true;
        }
        private void btnThongTinMe_Click(object sender, EventArgs e)
        {
            if (txtCccdMe.Text != "" && txtCccdMe.Text != "unknow")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(txtCccdMe.Text);
                tTCD.ShowDialog();
            }
        }
        public void LayThongTinKhaiKhaiSinh()
        {
            if (maCCCD != null)
            {
                KhaiSinh ks = ksDAO.LayThongTin(maCCCD);
                KhaiSinh ksCha = ksDAO.LayThongTin(ks.CCCDCha);
                KhaiSinh ksMe = ksDAO.LayThongTin(ks.CCCDMe);
                txtTen.Text = ks.HoTen;
                txtCccd.Text = ks.MaKhaiSinh;
                txtNoiSinh.Text = ks.NoiSinh.toString();
                dtmNgaySinh.Value = ks.NgaySinh;
                if (ks.GioiTinh == "f")
                    txtGioiTinh.Text = "Nữ";
                else if (ks.GioiTinh == "m")
                    txtGioiTinh.Text = "Nam";
                else
                    txtGioiTinh.Text = "unknow";
                txtDanToc.Text = ks.DanToc;
                txtQuocTich.Text = ks.QuocTich;
                txtQueQuan.Text = ks.QueQuan.toString();
                txtTenCha.Text = ks.TenCha;
                txtTenMe.Text = ks.TenMe;
                txtCccdCha.Text = ks.CCCDCha;
                txtCccdMe.Text = ks.CCCDMe;
                txtQuocTichCha.Text = ksCha.QuocTich;
                txtQuocTichMe.Text = ksMe.QuocTich;
                dtmNgayDangKy.Value = ks.NgayDangKy;
            }
        }
        private void FThongTinKhaiSinh_Load(object sender, EventArgs e)
        {
            LayThongTinKhaiKhaiSinh();
        }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        private void lblTittle_Click(object sender, EventArgs e)
        {

        }
        private void CapNhatKhaiSinh()
        {
            if (KiemTraThongTin())
            {
                KhaiSinh kS = ksDAO.LayThongTin(MaCCCD);
                kS.NoiSinh.DinhDang(txtNoiSinh.Text);
                kS.QueQuan.DinhDang(txtQueQuan.Text);
                kS.NgaySinh = dtmNgaySinh.Value;
                kS.DanToc = txtDanToc.Text;
                kS.QuocTich = txtQuocTich.Text;
                kS.GioiTinh = txtGioiTinh.Text;
                kS.DinhDangGioiTinh();
                kS.NgayDangKy = dtmNgayDangKy.Value;
                ksDAO.CapNhatKhaiSinh(kS);
                ReadOnly();
                LayThongTinKhaiKhaiSinh();
            }    
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatKhaiSinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AutoReadOnly();

        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            ReadOnly();
            LayThongTinKhaiKhaiSinh();
        }
    }
}
