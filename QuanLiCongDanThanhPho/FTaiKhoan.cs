using QuanLiCongDanThanhPho.Model;
using System.Drawing.Imaging;

namespace QuanLiCongDanThanhPho
{
    public partial class FTaiKhoan : Form
    {
        private AccountDAO accountDAO;
        private Account account;
        private HinhDaiDien hinhAdmin;
        public Account Account { get => account; set => account = value; }

        public FTaiKhoan(Account acc)
        {
            InitializeComponent();
            StackForm.Add(this);
            pnlDoiPass.Hide();
            accountDAO = new AccountDAO();
            account = acc;
            hinhAdmin = new HinhDaiDien(HinhDaiDien.Type.admin);
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
            hinhAdmin.LayHinhDaiDien(account.UserName, ptcHinhDaiDien);
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
            StackForm.TrangChu?.LoadTaiKhoan();
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
            return true && KiemTraDuLieuNhap.KiemTraPass(txtMatKhau.Text, txtMatKhauMoi.Text, txtMatKhauMoiNhapLai.Text);
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
                StackForm.TrangChu.Account.DisplayName = txtDisplayName.Text;
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
            if (hinhAdmin.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien))
            {
                StackForm.TrangChu?.LoadTaiKhoan();
                hinhAdmin.SaveHinhDaiDien(account.UserName, ofdHinhDaiDien, ptcHinhDaiDien);
            }
        }
    }
}
