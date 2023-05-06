using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachCongDan : FormDanhSach
    {
        CongDanDAO cdDao;

        private enum Loc
        {
            tatCa,
            nam,
            nu,
            ketHon,
            docThan,
            tuoiTac,
        }
        public FDanhSachCongDan()
        {
            InitializeComponent();
            cdDao = new CongDanDAO();
            ListData = new Paging(nudPage, 15);
            btnTamVang.Enabled = false;
            btnThue.Enabled = false;
            btnKhaiSinh.Enabled = true;
        }

        //Tìm kiếm công dân theo các điều kiện
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (LuaChon == Loc.tatCa)
            {
                Ds = cdDao.LayDanhSachChuaTu(txtTimKiem.Text).ToList<Object>();
            }
            else if (LuaChon == Loc.nam)
            {
                Ds = cdDao.LayDanhSachCongDanNam(txtTimKiem.Text).ToList<Object>();
            }
            else if (LuaChon == Loc.nu)
            {
                Ds = cdDao.LayDanhSachCongDanNu(txtTimKiem.Text).ToList<Object>();

            }
            else if (LuaChon == Loc.ketHon)
            {
                Ds = cdDao.LayDanhSachDaKetHon(txtTimKiem.Text).ToList<Object>();
            }
            else if (LuaChon == Loc.docThan)
            {
                Ds = cdDao.LayDanhSachChuaKetHon(txtTimKiem.Text).ToList<Object>();
            }
            else if (LuaChon == Loc.tuoiTac)
            {
                Ds = cdDao.LayDanhSachTuoiXepTuBeDenLon(txtTimKiem.Text).ToList<Object>();
            }
            nudPage.Value = 1;
            LoadDanhSach(gvDanhSachCongDan);
        }


        internal override void HeaderText()
        {
            gvDanhSachCongDan.Columns[0].HeaderText = "CCCD";
            gvDanhSachCongDan.Columns[1].HeaderText = "Họ và tên";
            gvDanhSachCongDan.Columns[2].HeaderText = "Nghề nghiệp";
            gvDanhSachCongDan.Columns[3].HeaderText = "Số ĐT";
            gvDanhSachCongDan.Columns[4].HeaderText = "Tôn giáo";
            gvDanhSachCongDan.Columns[5].HeaderText = "Mã hộ";
            gvDanhSachCongDan.Columns[6].Visible = false;
            gvDanhSachCongDan.Columns[7].Visible = false;
            gvDanhSachCongDan.Columns[8].Visible = false;
        }
        private void FDanhSachCongDan_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            fpnlPhanLoai.Width = 45;
        }

        private void gvDanhSachCongDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThue.Enabled = true;
            btnTamVang.Enabled = true;
            btnKhaiSinh.Enabled = true;
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            if (e.RowIndex != -1)
            {
                ThueDAO thueDAO = new ThueDAO();
                //Kiểm tra nếu không có trong ds thuế thì có thể đk
                if (thueDAO.LayThongTin(cCCD) != null)
                {
                    btnThue.Enabled = false;
                }    
                TamTruTamVangDAO tttvDAO = new TamTruTamVangDAO();
                //Kiểm tra nếu không có trong ds tạm trú, tạm vắng thì có thể đk
                if (tttvDAO.LayThongTin(cCCD) != null)
                {
                    btnTamVang.Enabled = false;
                }
                HonNhanDAO hnDAO = new HonNhanDAO();
                if (hnDAO.LayThongTin(cCCD) == null)
                {
                    btnKhaiSinh.Enabled = false;
                }
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        //Lọc giới tính: Nam
        private void btnNam_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.nam);
        }

        //Show tất cả
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
        }

        //Lọc giới tính: nữ
        private void btnNu_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.nu);
        }

        //Lọc người chưa kết hôn
        private void btnDocThan_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.docThan);
        }

        //Lọc người đã kết hôn
        private void btnKetHon_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.ketHon);
        }

        //Sắp xếp theo tuổi tác
        private void btnTuoiTac_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tuoiTac);
        }
        
        private void TimKiem(dynamic type)
        {
            LuaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Đưa đến form đăng ký công dân
        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyCongDan dangKyCongDan = new FDangKyCongDan();
            (StackForm.TrangChu).ChildForm.Open(dangKyCongDan);
        }


        //Menu
        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maCCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            Congdan? cD = cdDao.LayThongTin(maCCCD);
            if (maCCCD != "" && cD != null)
            {
                FThongTinCongDan ttCD = new FThongTinCongDan(cD);
                ttCD.ShowDialog();
            }
        }

        //Xóa công dân
        private void XoaCongDan()
        {
            string maCCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            if (maCCCD != "")
            {
                Congdan? cd = cdDao.LayThongTin(maCCCD);
                if (cd != null)
                {
                    cdDao.XoaCongDan(cd);
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }

        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Bạn có thật sự muốn xóa công dân?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (message == DialogResult.Yes)
            {
                XoaCongDan();
            }
        }

        //Đóng mở các nút lọc
        private void btnLoc_Click(object sender, EventArgs e)
        {
            Loc_Click(fpnlPhanLoai);
        }

        //Thay đổi ngắt trang
        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach(gvDanhSachCongDan);
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            FDangKyThue dangKyThue = new FDangKyThue(cCCD);
            (StackForm.TrangChu)?.ChildForm.Open(dangKyThue);
        }

        private void btnTamVang_Click(object sender, EventArgs e)
        {
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            FDangKyTamTruTamVang dKTamTruTamVang = new FDangKyTamTruTamVang(cCCD);
            (StackForm.TrangChu)?.ChildForm.Open(dKTamTruTamVang);
        }

        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            FDangKyKhaiSinh dKKhaiSinh = new FDangKyKhaiSinh(cCCD);
            (StackForm.TrangChu)?.ChildForm.Open(dKKhaiSinh);
        }
    }
}