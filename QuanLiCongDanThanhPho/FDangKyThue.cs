using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyThue : FormDangKy
    {
        public FDangKyThue()
        {
            Init();
        }

        public FDangKyThue(string cCCD)
        {
            Init();
            LoadThongTin(cCCD);

        }

        public void Init()
        {
            InitializeComponent();
        }

        public void LoadThongTin(string cCCD)
        {
            if (cCCD != null)
            {
                CongDanDAO congDanDAO = new CongDanDAO();
                Congdan? congDan = congDanDAO.LayThongTin(cCCD);
                if (congDan != null)
                {
                    txtMaSoThue.Text = congDan.Cccd;
                    txtCCCD.Text = congDan.Cccd;
                }
                txtSoTienDaNop.Text = "0";
            }
        }

        internal override void Reset()
        {
            base.Reset();
            dtpNgayCapMa.Value = DateTime.Now;
            dtpHanNop.Value = DateTime.Now;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        internal override void DangKy()
        {
            Thue thue = new Thue()
            {
                MaThue = txtMaSoThue.Text,
                Cccd = txtCCCD.Text,
                NgayCap = dtpNgayCapMa.Value,
                HanNop = dtpHanNop.Value,
                SoTienCanNop = txtSoTienCanNop.Text,
                SoTienDaNop = txtSoTienDaNop.Text
            };

            if (KiemTraDuLieuNhap.KiemTraThue(thue) && ThueDAO.ThemThue(thue))
            {
                MessageBox.Show("Đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }
    }
}
