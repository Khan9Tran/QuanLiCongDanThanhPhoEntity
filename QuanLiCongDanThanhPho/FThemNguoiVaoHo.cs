using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FThemNguoiVaoHo : Form
    {
        private CongDanDAO cDDAO;
        public FThemNguoiVaoHo()
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
            lblThongTin.Hide();
            gvNguoiChuaCoHoKhau.Hide();
            StackForm.Add(this);
        }

        private void LoadDanhSachChuaHoKhau()
        {
            gvNguoiChuaCoHoKhau.DataSource = cDDAO.LayDanhSachTheoHoKhau("00000A");
            HeaderText();
        }

        private void HeaderText()
        {
            gvNguoiChuaCoHoKhau.Columns[0].HeaderText = "CCCD";
            gvNguoiChuaCoHoKhau.Columns[1].HeaderText = "Tên";
            gvNguoiChuaCoHoKhau.Columns[2].HeaderText = "Nghề nghiệp";
            gvNguoiChuaCoHoKhau.Columns[3].HeaderText = "SĐT";
            gvNguoiChuaCoHoKhau.Columns[4].HeaderText = "Tôn giáo";
            gvNguoiChuaCoHoKhau.Columns[5].HeaderText = "Mã hộ khẩu";
            gvNguoiChuaCoHoKhau.Columns[6].HeaderText = "Quan hệ với chủ hộ";
            gvNguoiChuaCoHoKhau.Columns[7].Visible = false;
            gvNguoiChuaCoHoKhau.Columns[8].Visible = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            lblThongTin.Show();
            gvNguoiChuaCoHoKhau.Show();
            LoadDanhSachChuaHoKhau();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Congdan congDan = new Congdan() 
            {
                Cccd = txtCCCD.Text,
                Ten = txtTen.Text,
                MaHk = txtMaHo.Text,
                QuanHeVoiChuHo = txtQuanHeVoiChuHo.Text
            };

            if (cDDAO.ThayDoiHoKhau(congDan))
            {
                MessageBox.Show("Thêm thành công");
                Reset();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void gvNguoiChuaCoHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtCCCD.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[1].Value.ToString();
        }

        private void Reset()
        {
            ToolsForControl.ClearTextBox(Controls);
            gvNguoiChuaCoHoKhau.Hide();
            lblThongTin.Hide();
            LoadDanhSachChuaHoKhau();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
