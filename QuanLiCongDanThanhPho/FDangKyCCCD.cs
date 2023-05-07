using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCCCD : Form
    {
        CCCDDAO cCCDDAO;
        CongDanDAO congDanDAO;

        public FDangKyCCCD()
        {
            InitializeComponent();
            cCCDDAO = new CCCDDAO();
            congDanDAO = new CongDanDAO();
            StackForm.Add(this);
        }
        
        private void FDangKyCCCD_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            if (gvDanhSachChuaCapCCCD.Rows.Count > 0)
            {
                HeaderText();
            };
        }
        private void Reset()
        {
            txtCCCD.Text = "";
            txtDDNhanDang.Text = "";
            txtTen.Text = "";
            dtmNgayCap.Value = DateTime.Now;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Congdan? cD = congDanDAO.LayThongTin(txtCCCD.Text);
            Cccd? cCCD = cCCDDAO.LayThongTin(txtCCCD.Text);

            if (cD != null && cD.Ten == txtTen.Text && KiemTraDuLieuNhap.KiemTraTenVaCCCD(cD) && KiemTraDuLieuNhap.isEmpty(txtDDNhanDang.Text) == false && cCCD != null)
            {
                cCCD.NgayCap = dtmNgayCap.Value;
                cCCD.DacDiem = txtDDNhanDang.Text;
                cCCDDAO.CapNhatCCCD();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }    
                
            LoadDanhSach();
            
        }
        private void LoadDanhSach()
        {
            gvDanhSachChuaCapCCCD.DataSource = cCCDDAO.DanhSachCCCDTheoDacDiem();
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
