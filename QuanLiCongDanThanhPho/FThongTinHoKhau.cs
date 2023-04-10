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
    public partial class FThongTinHoKhau : Form
    {
        private string maHoKhau;
        HoKhauDAO hkDAO = new HoKhauDAO();
        CongDanDAO cdDAO = new CongDanDAO();
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        public string MaHoKhau
        {
            get { return maHoKhau; }
            set { maHoKhau = value; }
        }
        public FThongTinHoKhau()
        {
            InitializeComponent();
        }
        public FThongTinHoKhau(string maHoKhau)
        {
            MaHoKhau = maHoKhau;
            InitializeComponent();
            StackForm.Add(this);
        }
        public void LayThongTinHoKhau()
        {
            if (MaHoKhau != null)
            {
                Hokhau hk = hkDAO.LayThongTin(MaHoKhau);
                txtCCCDChuHo.Text = hk.CccdchuHo;
                txtMaHoKhau.Text = hk.MaHk;
                txtDiaChi.Text = hk.DiaChi;
                //---Thong tin chu ho---//
                Congdan chuHo = cdDAO.LayThongTin(hk.CccdchuHo);
                txtTenChuHo.Text = chuHo.Ten.ToString();
                //---Quan he voi chu ho---//
                var dsNguoiTrongHo = cdDAO.LayDanhSachTheoHoKhau(maHoKhau);
                gvQuanHeVoiChuHo.DataSource = dsNguoiTrongHo;
                lblTong.Text = "Tổng thành viên: " + dsNguoiTrongHo.Count.ToString();
            }
        }
        private void CapNhatHoKhau()
        {
            Hokhau hoKhau = hkDAO.LayThongTin(maHoKhau);
            if (txtDiaChi.Text != "")
            {
                hoKhau.DiaChi = txtDiaChi.Text;
            }
            hkDAO.CapNhatHoKhau();
        }
        private void FThongTinHoKhau_Load(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

    
        private void ReadOnly()
        {
            txtDiaChi.ReadOnly = true;
            txtDiaChi.BackColor = Color.Gainsboro;
            btnXacNhan.Enabled = false;
        }

        private void UnReadOnly()
        {
            txtDiaChi.ReadOnly = false;
            txtDiaChi.BackColor = Color.SteelBlue;
            btnXacNhan.Enabled = true;
        }

        private void AutoReadOnly()
        {
            if (txtDiaChi.ReadOnly == false)
            {
                ReadOnly();
            }
            else
            {
                UnReadOnly();
            }
        }

        private void gvQuanHeVoiChuHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string maCCCD = gvQuanHeVoiChuHo.CurrentRow.Cells[0].Value.ToString();
                if (maCCCD != "")
                {
                    FThongTinCongDan ttCD = new FThongTinCongDan(cdDAO.LayThongTin(maCCCD));
                    ttCD.ShowDialog();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AutoReadOnly();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHoKhau();
            LayThongTinHoKhau();
            ReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
            ReadOnly();
        }
    }
}
