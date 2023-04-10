using QuanLiCongDanThanhPho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangNhap : Form
    {
        private AccountDAO accDAO;
        private bool checkTK = false;
        private bool checkPass = false;
        FLOGO flogo;
        public FDangNhap()
        {
            InitializeComponent();
            accDAO = new AccountDAO();
            KeyPreview = true;
            flogo = new FLOGO();
            tmrShowTime.Interval = 5;
        }

        private void txtTaiKhoan_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkTK == false)
            {
                txtTaiKhoan.Clear();
            }
            checkTK = true;
        }

        private void txtMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkPass == false)
            {
                txtMatKhau.Clear();
            }
            checkPass = true;
            txtMatKhau.UseSystemPasswordChar = true;
        }
        
        private void DangNhap()
        {
            Account acc = new Account()
            {
                UserName = txtTaiKhoan.Text,
                StrPassword = txtMatKhau.Text,
            };
            if (!accDAO.DangNhap(acc))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }    
            else
            {
                Hide();
                tmrShowTime.Start();
                flogo.Show();
            }    
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void FDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                base.OnKeyDown(e);
            }
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void tmrShowTime_Tick(object sender, EventArgs e)
        {
            if (flogo.Width > 20)
            {
                flogo.Width -= 20;
            }
            else
            {
                tmrShowTime.Stop();
                flogo.Close();
                Account acc = new Account()
                {
                    UserName = txtMatKhau.Text,
                    StrPassword= txtMatKhau.Text,
                };
                FTrangChu newTrangChu = new FTrangChu(acc);
                newTrangChu.ShowDialog();
                Close();
            }
        }
    }
}
