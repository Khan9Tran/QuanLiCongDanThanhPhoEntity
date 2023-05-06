using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyHonNhan : Form
    {
        HonNhanDAO hNDAO;
        KhaiSinhDAO kSDAO;
        CongDanDAO cdDAO;
        public FDangKyHonNhan()
        {
            InitializeComponent();
            hNDAO = new HonNhanDAO();
            kSDAO = new KhaiSinhDAO();
            cdDAO = new CongDanDAO();
            StackForm.Add(this);
        }
        
        //Thêm hôn nhân mới
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Honnhan hN = new Honnhan()
            {
                MaHonNhan = txtMaHonNhan.Text,
                Cccdnam = txtCCCDChong.Text,
                TenNam = txtTenChong.Text,
                Cccdnu = txtCCCDVo.Text,
                TenNu = txtTenVo.Text,
                NoiDangKy = txtNoiDK.Text,
                NgayDangKy = dtpNgayDangKy.Value,
            };

            if (KiemTraDuLieuNhap.KiemTraHonNhan(hN) &&  hNDAO.ThemHonNhan(hN))
                MessageBox.Show("Đăng ký thành công");
            else
                MessageBox.Show("Đăng ký thất bại");
        }

        //Bật các nút giúp cho phép đăng ký li hôn
        public void ChoPhepLiHon()
        {
            txtCCCDChong.ReadOnly = true;
            txtCCCDVo.ReadOnly = true;
            txtTenChong.ReadOnly = true;
            txtTenVo.ReadOnly = true;
            txtNoiDK.ReadOnly = true;
            dtpNgayDangKy.Enabled = false;
            btnDelete.Enabled = true;
            btnDangKy.Enabled = false;
        }

        //Bật các nút cho phép kết hôn
        public void ChoPhepDangKy()
        {
            txtCCCDChong.ReadOnly = false;
            txtCCCDVo.ReadOnly = false;
            txtTenChong.ReadOnly = false;
            txtTenVo.ReadOnly = false;
            txtNoiDK.ReadOnly = false;
            dtpNgayDangKy.Enabled = true;
            btnDelete.Enabled = false;
            btnDangKy.Enabled = true;
        }

        //Li hôn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Honnhan? hN = hNDAO.LayThongTin(txtCCCDChong.Text);
            if (hNDAO.Xoa(hN))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            Reset();
        }

        //Đưa form về trạng thái ban đầu
        private void Reset()
        {
            Clear();
            txtMaHonNhan.Clear();
            ChoPhepDangKy();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }


        //Xóa các textbox
        public void Clear()
        {
            ToolsForControl.ClearTextBox(Controls);
            dtpNgayDangKy.Value = DateTime.Now;
        }

        //Tải thông tin hôn nhân lên
        private void LoadHonNhan()
        {
            Honnhan? hn = hNDAO.LayThongTinTheoMaSo(txtMaHonNhan.Text);
            if (hn != null)
            {
                txtCCCDChong.Text = hn.Cccdnam;
                txtCCCDVo.Text = hn.Cccdnu;
                txtTenChong.Text = hn.TenNam;
                txtTenVo.Text = hn.TenNu;
                txtNoiDK.Text = hn.NoiDangKy;
                dtpNgayDangKy.Value = hn.NgayDangKy.Value;

                if (hn.Cccdnam != null)
                    ChoPhepLiHon();
                else
                    ChoPhepDangKy();
            }
        }

        //Tìm kiếm theo mã số
        private void txtMaHonNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHonNhan.Text.Length > 0)
            {
                LoadHonNhan();  
            }

        }

        //Trả về tên hôn nhân thep mã số
        private string? LayTenTheoCCCD(string cCCD)
        {
            Khaisinh? ks = kSDAO.LayThongTin(cCCD);
            if (ks != null)
                return ks.Ten;
            return null;
        }

        //Tìm kiếm theo CCCD
        private void btnTimChong_Click(object sender, EventArgs e)
        {
            txtTenChong.Text = LayTenTheoCCCD(txtCCCDChong.Text);
        }

        private void btnTimVo_Click(object sender, EventArgs e)
        {
            txtTenVo.Text = LayTenTheoCCCD(txtCCCDVo.Text);
        }
    }
}