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
    public partial class FThongTinCCCD : Form
    {
        Congdan congDan;
        KhaiSinhDAO kSDAO;
        CCCDDAO CccdDAO;
        HoKhauDAO hKDAO;

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        private string path = @"..\..\..\..\HinhCongDan";

        public FThongTinCCCD(Congdan congDan)
        {
            InitializeComponent();
            StackForm.Add(this);
            this.congDan = congDan;
            kSDAO = new KhaiSinhDAO();
            CccdDAO = new CCCDDAO();
            hKDAO = new HoKhauDAO();
        }
        private void HienThiThongTin()
        {
            lblCCCD.Text = congDan.Cccd;
            lblTen.Text = congDan.Ten.ToUpper();

            Khaisinh ks = kSDAO.LayThongTin(lblCCCD.Text);
            if (ks != null)
            {
                if (ks.GioiTinh == "m")
                    lblGioiTinh.Text = "Nam";
                else lblGioiTinh.Text = "Nữ";
                lblNgaySinh.Text = ks.NgaySinh.ToString("dd/MM/yyyy");
                lblQueQuan.Text = ks.QueQuan;
                lblQuocTich.Text = ks.QuocTich;
            }

            Hokhau hk = hKDAO.LayThongTin(congDan.MaHk);
            if (hk != null)
                lblDiaChi.Text = hk.DiaChi;

            Cccd cCCD = CccdDAO.LayThongTin(new Cccd() { MaCccd = congDan.Cccd });
            if (cCCD != null)
            {
                lblNgayCap.Text = ((DateTime)cCCD.NgayCap).ToString("dd/MM/yyyy");
                lblDDNhanDang.Text = cCCD.DacDiem;
            }
        }
        private void FThongTinCCCD_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            HinhDaiDien.LayHinhDaiDien(lblCCCD.Text, ptcHinhDaiDien, path);
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
    }
}
