using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHonNhan : MoveForm
    {
        private string? maCCCD;
        private HonNhanDAO hNDAO;
        private CongDanDAO cDDAO;

        private ToolsForControl? tool;
        public string? MaCCCD { get => maCCCD; set => maCCCD = value; }

        public FThongTinHonNhan(string maCCCD)
        {
            MaCCCD = maCCCD;

            InitializeComponent();
            StackForm.Add(this);

            hNDAO = new HonNhanDAO();
            cDDAO = new CongDanDAO();

            if (tool == null)
                SetTools();
        }
        private void btnThongTinChong_Click(object sender, EventArgs e)
        {
            if (txtCCCDChong.Text != "")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(cDDAO.LayThongTin(txtCCCDChong.Text));
                tTCD.ShowDialog();
            }
        }

        private void btnThongTinVo_Click(object sender, EventArgs e)
        {
            if (txtCCCDVo.Text != "")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(cDDAO.LayThongTin(txtCCCDVo.Text));
                tTCD.ShowDialog();
            }
        }
        public void LayThongTinHonNhan()
        {
            if (maCCCD != null)
            {
                Honnhan? hn = hNDAO.LayThongTin(maCCCD);
                if (hn != null)
                {
                    txtTenChong.Text = hn.TenNam;
                    txtTenVo.Text = hn.TenNu;
                    txtCCCDChong.Text = hn.Cccdnam;
                    txtCCCDVo.Text = hn.Cccdnu;
                    txtNoiDangKy.Text = hn.NoiDangKy;
                    dtmNgayDangKy.Value = hn.NgayDangKy.Value;
                }
            }
        }    
        private void FThongTinHonNhan_Load(object sender, EventArgs e)
        {
            LayThongTinHonNhan();
        }

        private void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            { txtNoiDangKy};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgayDangKy
            };
            tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            tool?.AutoReadOnly();
        }
        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isDiaChi(txtNoiDangKy.Text))
            {
                MessageBox.Show("Kiểm tra lại nơi đăng ký");
                txtNoiDangKy.Focus();
                return false;
            }    
            return true;
        }    
        public void CapNhatHonNhan()
        {
            Honnhan? hN = hNDAO.LayThongTin(maCCCD);
            if (KiemTraThongTin() && hN != null)
            {
                hN.NoiDangKy = txtNoiDangKy.Text;
                hN.NgayDangKy = dtmNgayDangKy.Value;
                hNDAO.CapNhatHonNhan();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHonNhan();
            tool?.TurnOff();
            LayThongTinHonNhan();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHonNhan();
        }
    }
}
