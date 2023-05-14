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

            return KiemTraDuLieuNhap.KiemTraPass(txtMatKhauHienTai.Text, txtMatKhauMoi.Text, txtNhapLai.Text);
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
