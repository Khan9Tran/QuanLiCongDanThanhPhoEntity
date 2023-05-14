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
    public partial class FDangKyTaiKhoan : Form
    {
        CongDanDAO cdDAO;
        AccountDAO accountDAO;
        public FDangKyTaiKhoan()
        {
            InitializeComponent();
            StackForm.Add(this);
            cdDAO = new CongDanDAO();
            accountDAO = new AccountDAO();
            
        }

        private void btnThongTinCCCD_Click(object sender, EventArgs e)
        {
            Congdan? congDan = cdDAO.LayThongTin(txtCCCD.Text);
            if (congDan != null) 
            {
                txtTenHienThi.Text = congDan.Ten;
            }
        }

        private bool KiemTra()
        {
            Congdan? cd = cdDAO.LayThongTin(txtCCCD.Text);
            Congdan congDanTmp = new Congdan()
            {
                Cccd = txtCCCD.Text,
                Ten = txtTenHienThi.Text,
            };
            if (cd == null || !KiemTraDuLieuNhap.KiemTraTenVaCCCD(congDanTmp))
            {
                return false;
            }  
            if (txtMatKhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải từ 6 kí tự");
            }    
            if (!KiemTraDuLieuNhap.isPass(txtMatKhau.Text))
            {

                MessageBox.Show("Mật khẩu phải chứa ít nhất một chữ viết hoa, một chữ thường, một số và một kí tự đặt biệt");
                return false;
            }
            if (txtMatKhau.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu  không khớp");
                return false;
            }
            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KiemTra()) 
            {
                TaoHoacCapNhatTaiKhoan();
            }

        }

        private void TaoHoacCapNhatTaiKhoan()
        {
            Account acc = new Account()
            {
                UserName = txtCCCD.Text,
                DisplayName = txtTenHienThi.Text,
                StrPassword = txtMatKhau.Text,
                QuyenTruyCap = 0
            };
            if (accountDAO.LayThongTinTaiKhoan(acc) == null)
            {
                accountDAO.DangKy(acc);
                MessageBox.Show("Tạo tài khoản thành công");
            }    
            else
            {
                accountDAO.CapNhatDisplayName(acc);
                accountDAO.CapNhatMatKhau(acc);
            }    
        }
    }
}
