using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyKhaiSinh : Form
    {
        private CongDanDAO? cDDAO;
        private HonNhanDAO? hNDAO;
        private KhaiSinhDAO? kSDAO;

        private void Init()
        {
            InitializeComponent();
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            hNDAO = new HonNhanDAO();
            kSDAO = new KhaiSinhDAO();
        }

        public FDangKyKhaiSinh()
        {
            Init();
        }

        public FDangKyKhaiSinh(string? cCCDThanNhan)
        {
            Init();
            LoadThongTinChaMe(cCCDThanNhan);
        }

        private void LoadThongTinChaMe(string? cCCDThanNhan)
        {
            if (cCCDThanNhan != null)
            {
                Honnhan? honNhan = hNDAO?.LayThongTin(cCCDThanNhan);
                if (honNhan != null)
                {
                    txtCccdCha.Text = honNhan.Cccdnam;
                    txtCccdMe.Text = honNhan.Cccdnu;
                    txtTenCha.Text = honNhan.TenNam;
                    txtTenMe.Text = honNhan.TenNu;
                }
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        { 
            ToolsForControl.ClearTextBox(Controls);
        }

        private bool KiemTraChaMe()
        {
            Honnhan? chong = hNDAO?.LayThongTin(txtCccdCha.Text);
            Honnhan? vo = hNDAO?.LayThongTin(txtCccdMe.Text);

            if (chong == null || vo == null)
                return false;   
            if (chong.MaHonNhan != vo.MaHonNhan) 
                return false;
            if (txtTenCha.Text != chong.TenNam)
                return false;
            if (txtTenMe.Text  != vo.TenNu)
                return false;
            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
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

            if (KiemTraChaMe() && KiemTraDuLieuNhap.KiemTraTenVaCCCD(congDan) && KiemTraDuLieuNhap.KiemTraKhaiSinh(kS) && cDDAO.ThemCongDan(congDan) && kSDAO.ThemKhaiSinh(kS))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Sai thông tin");
            }
        }


    }
}
