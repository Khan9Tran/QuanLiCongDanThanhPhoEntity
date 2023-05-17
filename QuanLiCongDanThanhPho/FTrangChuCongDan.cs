using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FTrangChuCongDan : Form
    {
        private OpenChildForm childForm;
        private Account account;
        private AccountDAO accountDAO;
        private FDangNhap fDangNhap;
        private HinhDaiDien hinhCongDan;

        public FTrangChuCongDan(Account acc, FDangNhap dangNhap)
        {
            InitializeComponent();
            pnlLoad.Visible = false;
            fDangNhap = dangNhap;
            account = acc;
            loadForm = new OpenChildForm(pnlLoad);
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }

        OpenChildForm loadForm;

        private void btnThongTin_Click(object sender, EventArgs e)
        {;
            pnlLoad.Visible = true;
            CongDanDAO cdDAO = new CongDanDAO();
            loadForm.Open(new FXemCongDan(cdDAO.LayThongTin(account.UserName)));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            cmnusSetting.Show(this, PointToClient(MousePosition));
        }

        private void cmusItemDoiMK_Click(object sender, EventArgs e)
        {
            pnlLoad.Visible = true;
            loadForm.Open(new FSetting(account));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            loadForm.CurrentChildForm = null;
            pnlLoad.Visible = false;
        }

        private void cmnusItemDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            fDangNhap.Show();
        }

        private void FTrangChuCongDan_Load(object sender, EventArgs e)
        {
            hinhCongDan.LayHinhDaiDien(account.UserName, ptcCongDan);
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            ThueDAO thueDAO = new ThueDAO();
            if (thueDAO.LayThongTin(account.UserName) != null)
            {
                loadForm.Open(new FThanhToanThue(account.UserName));
                pnlLoad.Visible = true;
            }
            else
                MessageBox.Show("Chưa có thuế. Cần liên hệ trực tiếp cơ quan để tạo");
        }

        private void btnTTTV_Click(object sender, EventArgs e)
        {
            TamTruTamVangDAO tTTV = new TamTruTamVangDAO ();
            Tamtrutamvang? tamtrutamvang = tTTV.LayThongTin(account.UserName);
            if (tamtrutamvang != null && (tamtrutamvang.TrangThai == "CDTV" || tamtrutamvang.TrangThai == "CDTT"))
            {
                MessageBox.Show("Thông tin TT/TV của bạn đang chờ duyệt");
            }
            else
            if (tamtrutamvang != null && tamtrutamvang.TrangThai != "CDTV" && tamtrutamvang.TrangThai != "CDTT")
            {
                MessageBox.Show("Thông tin TT/TV của bạn đã được duyệt");
            }    
            else
            {
                pnlLoad.Visible = true;
                loadForm.Open(new FXinPhepTTTV(account));
            }
        }

        private void btnCCCD_Click(object sender, EventArgs e)
        {
            CongDanDAO cdDAO = new CongDanDAO();
            FThongTinCCCD ttCCCD = new FThongTinCCCD(cdDAO.LayThongTin(account.UserName));
            ttCCCD.ShowDialog();
        }
    }
}
