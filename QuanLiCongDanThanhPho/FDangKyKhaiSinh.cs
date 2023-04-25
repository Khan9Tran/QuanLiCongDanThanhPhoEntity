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
    public partial class FDangKyKhaiSinh : Form
    {
        CongDanDAO cDDAO;
        HonNhanDAO hNDAO;
        KhaiSinhDAO kSDAO;
        public FDangKyKhaiSinh()
        {

            InitializeComponent();
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            hNDAO = new HonNhanDAO();
            kSDAO = new KhaiSinhDAO();
        }

        private void FDangKyKhaiSinh_Load(object sender, EventArgs e)
        {

        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                txtTen.Focus();
                MessageBox.Show("Tên Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCccd.Text))
            {
                txtCccd.Focus();
                MessageBox.Show("CCCD không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                txtQueQuan.Focus();
                MessageBox.Show("Quê quán Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtNoiSinh.Text))
            {
                txtNoiSinh.Focus();
                MessageBox.Show("Nơi sinh không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenCha.Text))
            {
                txtTenCha.Focus();
                MessageBox.Show("Tên cha Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCccdCha.Text))
            {
                txtCccdCha.Focus();
                MessageBox.Show("CCCD cha không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenMe.Text))
            {
                txtTenMe.Focus();
                MessageBox.Show("Tên mẹ Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCccdMe.Text))
            {
                txtCccdMe.Focus();
                MessageBox.Show("CCCD Me không hợp lệ");
                return false;
            }
            if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Giới tính không hợp lệ");
                return false;
            }
            if (cboQuocTich.SelectedItem == null)
            {
                cboQuocTich.Focus();
                MessageBox.Show("Quốc tịch không hợp lệ");
                return false;
            }
            if (cboDanToc.SelectedItem == null)
            {
                cboDanToc.Focus();
                MessageBox.Show("Dân tộc không hợp lệ");
                return false;
            }
            return true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }
        private bool KiemTraChaMe()
        {
            Congdan cha = cDDAO.LayThongTin(txtCccdCha.Text);
            Congdan me = cDDAO.LayThongTin(txtCccdMe.Text);

            if ((cha != null) && (txtTenCha.Text != cha.Ten))
            {
                MessageBox.Show("Tên và căn cước công dân cha không khớp");
                return false;
            }
            if ((me != null ) && (txtTenMe.Text != me.Ten))
            {
                MessageBox.Show("Tên và căn cước công dân mẹ không khớp");
                return false;
            }
            if (hNDAO.LayThongTin(txtCccdCha.Text) != hNDAO.LayThongTin(txtCccdMe.Text))
            {
                MessageBox.Show("Hôn nhân không khớp");
                return false;
            }
            
            return true;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin() && KiemTraChaMe())
            { 
                Congdan congDan = new Congdan()
                {
                    Ten = txtTen.Text,
                    Cccd = txtCccd.Text,
                    MaHk = "00000A"
                };

                string gt = "";
                if (rdoNam.Checked)
                {
                    gt = "m";
                }
                else
                {
                    gt = "f";
                }
                cDDAO.ThemCongDan(congDan);
                Khaisinh kS = new Khaisinh()
                {
                    MaKs = txtCccd.Text,
                    Ten = txtTen.Text,
                    GioiTinh = gt,
                    QuocTich = (string)cboQuocTich.SelectedItem,
                    DanToc = (string)cboDanToc.SelectedItem,
                    NgaySinh = dtmNgaySinh.Value,
                    NgayDangKy = dtmNgayDangKy.Value,
                    NoiSinh = txtNoiSinh.Text,
                    QueQuan = txtQueQuan.Text,
                    Cccdcha = txtCccdCha.Text,
                    TenCha = txtTenCha.Text,
                    Cccdme = txtCccdMe.Text,
                    TenMe = txtTenMe.Text,
                };
                kSDAO.ThemKhaSinh(kS);
            }
        }


    }
}
