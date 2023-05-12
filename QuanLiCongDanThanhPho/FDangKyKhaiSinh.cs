using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyKhaiSinh : FormDangKy
    {

        public FDangKyKhaiSinh()
        {
            InitializeComponent();
        }

        public FDangKyKhaiSinh(string? cCCDThanNhan)
        {
            InitializeComponent();
            LoadThongTinChaMe(cCCDThanNhan);
        }

        private void LoadThongTinChaMe(string? cCCDThanNhan)
        {
            if (cCCDThanNhan != null)
            {
                Honnhan? honNhan = HNDAO?.LayThongTin(cCCDThanNhan);
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
            base.Reset();
        }

        private bool KiemTraChaMe()
        {
            Honnhan? chong = HNDAO?.LayThongTin(txtCccdCha.Text);
            Honnhan? vo = HNDAO?.LayThongTin(txtCccdMe.Text);

            if (chong == null || vo == null)
                return false;
            if (chong.MaHonNhan != vo.MaHonNhan)
                return false;
            if (txtTenCha.Text != chong.TenNam)
                return false;
            if (txtTenMe.Text != vo.TenNu)
                return false;
            return true;
        }

        internal override void DangKy()
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

            if (KiemTraChaMe() && KiemTraDuLieuNhap.KiemTraTenVaCCCD(congDan) && KiemTraDuLieuNhap.KiemTraKhaiSinh(kS) && CDDAO.ThemCongDan(congDan) && KSDAO.ThemKhaiSinh(kS))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Sai thông tin");
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }


    }
}
