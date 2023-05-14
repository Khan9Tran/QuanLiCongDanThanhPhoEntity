using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FSetting : Form
    {
        private Account account;
        private AccountDAO accountDAO;
        public FSetting(Account account)
        {
            InitializeComponent();
            this.account = account;
            accountDAO= new AccountDAO();
        }

        private bool KiemTraPass()
        {
            if (txtMatKhauHienTai.Text != account.StrPassword)
            {
                MessageBox.Show("Mật khẩu không chính xác.");
                return false;
            }
            if (txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp");
                return false;
            }
            if (txtMatKhauMoi.Text == txtMatKhauHienTai.Text)
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
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraPass())
            {
                account.StrPassword = txtNhapLai.Text;
                accountDAO.CapNhatMatKhau(account);
            }    
        }
    }
}
