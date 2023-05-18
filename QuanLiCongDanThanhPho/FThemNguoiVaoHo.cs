using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FThemNguoiVaoHo : FormDangKy
    {
        public FThemNguoiVaoHo()
        {
            InitializeComponent();
            lblThongTin.Hide();
            gvNguoiChuaCoHoKhau.Hide();
        }

        //Hiển thị danh sách của những người chưa có hộ khẩu
        private void LoadDanhSachChuaHoKhau()
        {
            gvNguoiChuaCoHoKhau.DataSource = CDDAO.LayDanhSachTheoHoKhau("00000A");
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
            DangKy();
        }

        //Thêm công dân vào hộ được chọn
        internal override void DangKy()
        {
            Congdan? congDan = CDDAO.LayThongTin(txtCCCD.Text);
            if (congDan == null)
            {
                MessageBox.Show("Công dân không tồn tại");
            }
            else if (congDan.Ten != txtTen.Text)
            {
                MessageBox.Show("Tên không khớp với CCCD");
            }
            else if (KiemTraDuLieuNhap.KiemTraHaiHo(txtMaHo.Text, congDan.MaHk) && HKDAO.LayThongTin(txtMaHo.Text) != null)
            {
                congDan.MaHk = txtMaHo.Text;
                if (CDDAO.ThayDoiHoKhau(congDan))
                {
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        //Hiển thị thông tin công dân được chọn bên TextBox
        private void gvNguoiChuaCoHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtCCCD.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[1].Value.ToString();
            }
        }

        //Clear các TextBox,...
        internal override void Reset()
        {
            base.Reset();
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
