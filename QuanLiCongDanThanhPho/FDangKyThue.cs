using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyThue : FormDangKy
    {
        public FDangKyThue()
        {
            Init();
        }

        //Load thông tin thuế của công dân nếu được truyền CCCD
        public FDangKyThue(string cCCD)
        {
            Init();
            LoadThongTin(cCCD);

        }

        public void Init()
        {
            InitializeComponent();
        }
        //Hiển thị thông tin của công dân trong TextBox
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

        //Clear các TextBox
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

        //Đăng kí thuế cho công dân
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
