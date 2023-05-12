using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCCCD : FormDangKy
    {

        public FDangKyCCCD()
        {
            InitializeComponent();
        }

        private void FDangKyCCCD_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            if (gvDanhSachChuaCapCCCD.Rows.Count > 0)
            {
                HeaderText();
            };
        }
        internal override void Reset()
        {
            base.Reset();
            dtmNgayCap.Value = DateTime.Now;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        internal override void DangKy()
        {
            Congdan? cD = CDDAO.LayThongTin(txtCCCD.Text);
            Cccd? cCCD = CCCDDAO.LayThongTin(txtCCCD.Text);

            if (cD != null && cD.Ten == txtTen.Text && KiemTraDuLieuNhap.KiemTraTenVaCCCD(cD) && KiemTraDuLieuNhap.isEmpty(txtDDNhanDang.Text) == false && cCCD != null)
            {
                cCCD.NgayCap = dtmNgayCap.Value;
                cCCD.DacDiem = txtDDNhanDang.Text;
                CCCDDAO.CapNhatCCCD();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

            LoadDanhSach();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();

        }
        private void LoadDanhSach()
        {
            gvDanhSachChuaCapCCCD.DataSource = CCCDDAO.DanhSachCCCDTheoDacDiem();
            Reset();
        }

        private void HeaderText()
        {
            gvDanhSachChuaCapCCCD.Columns[0].HeaderText = "Tên";
            gvDanhSachChuaCapCCCD.Columns[1].HeaderText = "CCCD";
            gvDanhSachChuaCapCCCD.Columns[2].HeaderText = "Ngày cấp";
            gvDanhSachChuaCapCCCD.Columns[3].HeaderText = "Đặc điểm";
        }
        private void gvDanhSachChuaCapCCCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtCCCD.Text = gvDanhSachChuaCapCCCD.Rows[dong].Cells[1].Value.ToString();
                txtTen.Text = gvDanhSachChuaCapCCCD.Rows[dong].Cells[0].Value.ToString();
            }
            txtDDNhanDang.Text = "";
            dtmNgayCap.Value = DateTime.Now;
        }
    }
}
