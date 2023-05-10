using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachThue : FormDanhSach
    {
        private ThueDAO thueDAO;
        private CongDanDAO cDDAO;
        public FDanhSachThue()
        {
            InitializeComponent();

            thueDAO = new ThueDAO();
            cDDAO = new CongDanDAO();
            ListData = new Paging(nudPage, 10);
        }

        private enum Loc
        {
            tatCa,
            daNop,
            treHan
        }

        private void TimKiem(dynamic type)
        {
            LuaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }
        private void FDanhSachThue_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            flpnPhanLoai.Width = 45;
        }

        private void gvThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
                LoadLblThue(e.RowIndex);
            }

        }

        // Danh sach thuế của tất cả công dân
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
        }

        // Thay đổi danh sách trong datagridview theo từ tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (LuaChon == Loc.tatCa)
                Ds = thueDAO.LayDanhSachChuaTu(txtTimKiem.Text).ToList<Object>();
            else if (LuaChon == Loc.daNop)
                Ds = thueDAO.LayDanhSachSoTienDaNop(txtTimKiem.Text).ToList<Object>();
            else if (LuaChon == Loc.treHan)
                Ds = thueDAO.LayDanhSachTreHan(txtTimKiem.Text).ToList<Object>();
            nudPage.Value = 1;
            LoadDanhSach(gvThue);

        }

        internal override void HeaderText()
        {
            gvThue.Columns[0].HeaderText = "Mã Thuế";
            gvThue.Columns[1].HeaderText = "Căn cước công dân";
            gvThue.Columns[2].HeaderText = "Còn nợ (VNĐ)";
            gvThue.Columns[3].HeaderText = "Đã thu (VNĐ)";
            gvThue.Columns[4].HeaderText = "Ngày cấp";
            gvThue.Columns[5].HeaderText = "Hạn nộp";
            gvThue.Columns[6].Visible = false;

            gvThue.Columns[4].DefaultCellStyle.Format = DayFormat();
            gvThue.Columns[5].DefaultCellStyle.Format = DayFormat();
        }

        private void LoadLblThue(int rowIndex)
        {
            Congdan? cD = cDDAO.LayThongTin(CCCDDAO.GetCCCD(gvThue, 1));
            if (cD != null)
            {
                string Ten = cD.Ten;
                string soTienCanNop = (string)gvThue.Rows[rowIndex].Cells[2].Value;
                lblThongTin.Text = Ten + " cần thanh toán " + soTienCanNop + " VNĐ";
            }
        }

        // Sắp xếp danh sách tăng dần theo số tiền đã nộp
        private void btnTienDaNop_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.daNop);
        }

        // Xóa thông tin thuế của công dân ra khỏi csdl
        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn xóa thông tin thuế?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                string maCCCD = CCCDDAO.GetCCCD(gvThue, 1);
                if (maCCCD != "")
                {
                    thueDAO.XoaThue(maCCCD);
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }

        // Mở ra form thông tin thuế của công dân được chọn
        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maCCCD = CCCDDAO.GetCCCD(gvThue, 1);

            if (maCCCD != "")
            {
                FThongTinThue ttThue = new FThongTinThue(maCCCD);
                ttThue.ShowDialog();
            }
        }

        // Mở ra form đăng kí thuế
        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyThue dangKyThue = new FDangKyThue();
            (StackForm.TrangChu)?.ChildForm.Open(dangKyThue);
        }

        // Lọc danh sách những người đóng tiền trẽ hạn/ chưa đủ tiền khi quá thời gian
        private void btnTreHan_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.treHan);
        }

        //Thay đổi page
        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach(gvThue);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Loc_Click(flpnPhanLoai);
        }

        private void btnCongDanCanTaoThue_Click(object sender, EventArgs e)
        {
            FDanhSachCongDan dscd = new FDanhSachCongDan(thueDAO.DuTuoiDongThue().ToList<Object>());
            FDanhSach ds = new FDanhSach();
            (StackForm.TrangChu)?.ChildForm.Open(ds);
            ds.ChildForm.Open(dscd);

        }
        private bool ThanhToan()
        {
            if (txtDongThue.Text.Length == 0) return false;
            if (KiemTraDuLieuNhap.isTien(txtDongThue.Text))
            {   try
                {
                    int tienNhap = int.Parse(txtDongThue.Text);
                    Thue? thue = thueDAO.LayThongTin(CCCDDAO.GetCCCD(gvThue, 1));
                    if (thue != null && thue.ThanhToan(tienNhap))
                    {
                        thueDAO.CapNhatThue();
                        return true;
                    }
                }
                catch
                {
                    MessageBox.Show("Số tiền quá lớn");
                }
            }
            return false;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (ThanhToan())
                MessageBox.Show("Thanh toán thành công");
            else
                MessageBox.Show("Thanh toán thất bại");
        }
    }
}
