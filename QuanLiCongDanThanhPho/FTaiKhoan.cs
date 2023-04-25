using QuanLiCongDanThanhPho.Model;
using System.Drawing.Imaging;

namespace QuanLiCongDanThanhPho
{
    public partial class FTaiKhoan : Form
    {
        private AccountDAO accountDAO;
        private Account account;
        private string path = @"..\..\..\..\HinhTaiKhoan";
        public Account Account { get => account; set => account = value; }

        public FTaiKhoan(Account acc)
        {
            InitializeComponent();
            StackForm.Add(this);
            pnlDoiPass.Hide();
            accountDAO = new AccountDAO();
            account = acc;
        }
        private void ClearPass()
        {
            txtMatKhau.Clear();
            txtMatKhauMoiNhapLai.Clear();
            txtMatKhauMoi.Clear();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (btnDoiMK.Text == "Đổi mật khẩu")
            {
                pnlDoiPass.Show();
                btnDoiMK.Text = "Đóng";
            }
            else
            {
                ClearPass();
                pnlDoiPass.Hide();
                btnDoiMK.Text = "Đổi mật khẩu";
            }
        }

        private void HienThiThongTin()
        {
            txtDisplayName.Text = account.DisplayName;
            txtUserName.Text = account.UserName;
            HinhDaiDien.LayHinhDaiDien(account.UserName, ptcHinhDaiDien, path);
        }

        private void CapNhatMatKhau(string matKhauMoi, string userName)
        {
            Account acc = new Account();
            acc.StrPassword = matKhauMoi;
            acc.UserName = userName;
            accountDAO.CapNhatMatKhau(acc);
        }

        private void CapNhatDisplayName(string newDisplayName, string userName)
        {
            account.DisplayName = newDisplayName;
            accountDAO.CapNhatDisplayName(account);
            StackForm.fTrangChu.LoadTaiKhoan();
        }

        private void Reset()
        {
            txtMatKhauMoi.Clear();
            txtMatKhau.Clear();
            txtMatKhauMoiNhapLai.Clear();
        }

        private bool KiemTraPass()
        {
            if (txtMatKhau.Text != account.StrPassword)
            {
                MessageBox.Show("Mật khẩu không chính xác.");
                return false;
            }
            if (txtMatKhauMoi.Text != txtMatKhauMoiNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp");
                return false;
            }
            if (txtMatKhauMoi.Text == txtMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ");
                return false;
            }
            if (txtMatKhauMoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải từ 6 kí tự");
                return false;
            }
            if (!KiemTraDuLieuNhap.isPass(txtMatKhauMoi.Text))
            {

                MessageBox.Show("Mật khẩu phải chứa ít nhất một chữ viết hoa, một chữ thường, một số và một kí tự đặt biệt");
                return false;
            }
            return true;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraPass())
            {
                CapNhatMatKhau(txtMatKhauMoi.Text, account.UserName);

                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void ReadOnly()
        {
            btnThemHinh.Enabled = false;
            txtDisplayName.ReadOnly = true;
            txtDisplayName.BackColor = Color.Gainsboro;
            btnCapNhat.Enabled = false;
        }
        private void UnReadOnly()
        {
            btnThemHinh.Enabled = true;
            txtDisplayName.ReadOnly = false;
            txtDisplayName.BackColor = Color.SteelBlue;
            btnCapNhat.Enabled = true;
        }

        private void AutoReadOnLy()
        {
            if (txtDisplayName.ReadOnly == false)
            {
                ReadOnly();
            }
            else
            {
                UnReadOnly();
            }
        }

        //Cập nhật thông tin DisplayName 
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtDisplayName.Text != "" && KiemTraDuLieuNhap.isTen(txtUserName.Text))
            {
                CapNhatDisplayName(txtDisplayName.Text, account.UserName);
                StackForm.fTrangChu.Account.DisplayName = txtDisplayName.Text;
                ReadOnly();
            }
            else
            {
                MessageBox.Show("Tên hiển thị sai định dạng");
            }
            HienThiThongTin();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AutoReadOnLy();
        }

        private void FTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void btnXemMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnXemMKMoi_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.UseSystemPasswordChar == true)
            {
                txtMatKhauMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauMoi.UseSystemPasswordChar = true;
            }
        }

        private void btnXemMKNhapLai_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoiNhapLai.UseSystemPasswordChar == true)
            {
                txtMatKhauMoiNhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauMoiNhapLai.UseSystemPasswordChar = true;
            }
        }
        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            if (HinhDaiDien.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien))
            {
                StackForm.fTrangChu.LoadTaiKhoan();
                HinhDaiDien.SaveHinhDaiDien(account.UserName, ofdHinhDaiDien, ptcHinhDaiDien, path);
            }
        }
    }
}
