using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyTamTruTamVang : FormDangKy
    {
        private string? cCCD;

        public FDangKyTamTruTamVang()
        {
            Init();
        }
        public void Init()
        {
            InitializeComponent();
        }
        public FDangKyTamTruTamVang(string cCCD)
        {
            Init();
            this.cCCD = cCCD;

        }
        private void LoadThongTin(string cCCD)
        {
            if (cCCD != null)
            {
                Congdan? congDan = CDDAO?.LayThongTin(cCCD);
                if (congDan != null)
                {
                    txtTen.Text = congDan.Ten;
                    txtCCCD.Text = congDan.Cccd;
                    txtMaSo.Text = congDan.Cccd;
                    rdoTamVang.Checked = true;
                    txtSDT.Text = congDan.Sdt;
                }
            }
        }

        private bool TaoCongDan(Congdan congDan)
        {
            if (congDan != null)
            {
                if (congDan.Ten != txtTen.Text)
                {
                    MessageBox.Show("Nhập sai tên");
                    return false;
                }
                return true;
            }
            Congdan cDTamTru = new Congdan()
            {
                Cccd = txtCCCD.Text,
                Ten = txtTen.Text,
                Sdt = txtSDT.Text,
                MaHk = "00000B",
                QuanHeVoiChuHo = "Tạm trú tại địa phương"
            };
            if (KiemTraDuLieuNhap.KiemTraTenVaCCCD(cDTamTru))
            {
                CDDAO?.ThemCongDan(cDTamTru);
                return true;
            }
            else
                return false;
        }

        private string TamTru()
        {
            return "Tạm trú";
        }

        private string TamVang()
        {
            return "Tạm vắng";
        }

        internal override void DangKy()
        {
            Tamtrutamvang tTTV = new Tamtrutamvang()
            {
                Cccd = txtCCCD.Text,
                MaTttv = txtMaSo.Text,
                NgayBd = dtpNgayBatDau.Value,
                NgayKt = dtpNgayKetThuc.Value,
                LiDo = txtLiDo.Text,
                DiaChi = txtDiaChi.Text,
            };

            Congdan? congdan = CDDAO?.LayThongTin(txtCCCD.Text);
            if (TTTVDAO.LayThongTin(txtCCCD.Text) != null || TTTVDAO.LayThongTinTheoMaSo(txtMaSo.Text) != null)
            {
                MessageBox.Show("Công dân đã đăng ký TTTV trước đó/ hoặc mã số trùng");
                return;
            }    
            if (rdoTamVang.Checked == true && congdan == null)
            {
                MessageBox.Show("Công dân không tồn tại ở địa phương");
                return;
            }
            else if (rdoTamTru.Checked == true)
            {
                tTTV.TrangThai = TamTru();
            }
            else if (rdoTamVang.Checked == true)
            {
                tTTV.TrangThai = TamVang();
            }
            if (KiemTraDuLieuNhap.isTamTruTamVang(tTTV) && KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text) && TaoCongDan(congdan) && TTTVDAO.ThemTamTruTamVang(tTTV))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            base.Reset();
        }

        private void FDangKyTamTruTamVang_Load(object sender, EventArgs e)
        {
            if (cCCD != null)
                LoadThongTin(cCCD);
        }
    }
}
