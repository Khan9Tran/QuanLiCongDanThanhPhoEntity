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
    public partial class FDangKyKhaiSinh : Form
    {
        public FDangKyKhaiSinh()
        {
            InitializeComponent();
            StackForm.Add(this);
        }
        KhaiSinhDAO kSDAO = new KhaiSinhDAO();

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
            CongDanDAO cDDAOCha = new CongDanDAO();
            CongDanDAO cDDAOMe = new CongDanDAO();
            string tenCha = cDDAOCha.LayThongTin(txtCccdCha.Text).Ten;
            string tenMe = cDDAOMe.LayThongTin(txtCccdMe.Text).Ten;
            if ((tenCha != "unknow") && (txtTenCha.Text != tenCha))
            {
                MessageBox.Show("Tên và căn cước công dân cha không khớp");
                return false;
            }
            if ((tenMe != "unknow" ) && (txtTenMe.Text != tenMe))
            {
                MessageBox.Show("Tên và căn cước công dân mẹ không khớp");
                return false;
            }
            return true;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin() && KiemTraChaMe())
            { 
                CongDanDAO cDDAO = new CongDanDAO();
                Congdan congDan = new Congdan()
                {
                    Ten = txtTen.Text,
                    Cccd = txtCccd.Text
                };
                cDDAO.ThemCongDan(congDan);
                KhaiSinh kS = new KhaiSinh(txtCccd.Text, txtTen.Text, rdoNam.Checked.ToString(), cboQuocTich.SelectedItem.ToString(), cboDanToc.SelectedItem.ToString(), dtmNgaySinh.Value, dtmNgayDangKy.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCccdCha.Text, txtTenCha.Text, txtCccdMe.Text, txtTenMe.Text);
                kSDAO.ThemKhaSinh(kS);
            }
        }


    }
}
