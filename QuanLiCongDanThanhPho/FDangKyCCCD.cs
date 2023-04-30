using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCCCD : Form
    {
        CCCDDAO cCCDDAO;

        public FDangKyCCCD()
        {
            InitializeComponent();
            cCCDDAO = new CCCDDAO();
            StackForm.Add(this);
        }
        
        private void FDangKyCCCD_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            HeaderText();
        }
       private bool KiemTraThongTin()
       {
            if (txtCCCD.Text == "")
            {
                MessageBox.Show("CCCD không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                MessageBox.Show("Họ và tên không hợp lệ");
                return false;
            }
            if (txtDDNhanDang.Text== "")
            {
                MessageBox.Show("Đặc điểm nhận dạng không được để trống");
                return false;
            }
            return true;

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
            CongDanDAO cDDAO = new CongDanDAO();
            if (KiemTraThongTin())
            {
                Congdan? cD = cDDAO.LayThongTin(txtCCCD.Text);
                if (cD != null && cD.Ten == txtTen.Text)
                {
                    Cccd cCCD = new Cccd()
                    {
                        MaCccd = txtCCCD.Text,
                        NgayCap = dtmNgayCap.Value,
                        DacDiem = txtDDNhanDang.Text
                    };
                    cCCDDAO.CapNhatCCCD(cCCD);
                }
                else
                {
                    MessageBox.Show("CCCD và Họ tên không khớp");
                }    
                
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
