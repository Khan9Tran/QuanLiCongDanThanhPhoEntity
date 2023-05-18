using QuanLiCongDanThanhPho.Model;
using static QuanLiCongDanThanhPho.ToolsForControl;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyKhaiSinh : FormDangKy
    {
        //Hàm khởi tạo các thành phần của form
        public FDangKyKhaiSinh()
        {
            InitializeComponent();
        }

        //Hiện thị thông tin của cha mẹ nếu được truyền vào mã cccd của cha hoặc mẹ
        public FDangKyKhaiSinh(string? cCCDThanNhan)
        {
            InitializeComponent();
            LoadThongTinChaMe(cCCDThanNhan);
        }

        //Lấy thông tin cha mẹ để vào các TextBox
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

        //Clear các TextBox có trong form
        private void btnReset_Click(object sender, EventArgs e)
        {
            base.Reset();
        }

        // Kiểm tra thông tin cha mẹ nhập có hợp lệ không
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

        //Đăng ký khai sinh
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

        private int turn = 0;

        //Tạo nên 3 turn lấy thông tin theo chồng/vợ/không lấy
        private void TuDongNhap()
        {
            Khaisinh? chong = KSDAO.LayThongTin(txtCccdCha.Text);
            Khaisinh? vo = KSDAO.LayThongTin(txtCccdMe.Text);
            if (turn == 0 && chong == null)
            {
                turn = 1;
                if (vo == null) turn = 2;
            }
            switch (turn)
            {
                case 0:
                    txtQueQuan.Text = chong.QueQuan;
                    txtNoiSinh.Text = chong.NoiSinh;
                    cboQuocTich.SelectedItem = chong.QuocTich;
                    cboDanToc.SelectedItem = chong.DanToc;
                    if (vo != null)
                    {
                        turn += 1;
                    }
                    else
                    {
                        turn += 2;
                    }
                    break;
                case 1:
                    txtQueQuan.Text = vo.QueQuan;
                    txtNoiSinh.Text = vo.NoiSinh;
                    cboQuocTich.SelectedItem = vo.QuocTich;
                    cboDanToc.SelectedItem = vo.DanToc;
                    turn++;
                    break;
                case 2:
                    txtQueQuan.Text = "";
                    txtNoiSinh.Text = "";
                    cboQuocTich.SelectedItem = "";
                    cboDanToc.SelectedItem = "";
                    turn = 0;
                    break;
            }
        }
        private void btnAuto_Click(object sender, EventArgs e)
        {
            TuDongNhap();
        }
    }
}
