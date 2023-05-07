using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyThue : Form
    {
        private ThueDAO? thueDAO;
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
            StackForm.Add(this);
            thueDAO = new ThueDAO();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
            dtpNgayCapMa.Value = DateTime.Now;
            dtpHanNop.Value = DateTime.Now;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
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

            if (KiemTraDuLieuNhap.KiemTraThue(thue) && thueDAO.ThemThue(thue))
            {
                MessageBox.Show("Đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }
        }
    }
}
