using QuanLiCongDanThanhPho.Model;
using System.Configuration;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachTamTruTamVang : FormDanhSach
    {
        private TamTruTamVangDAO tttvDAO;

        public FDanhSachTamTruTamVang()
        {
            InitializeComponent();

            tttvDAO = new TamTruTamVangDAO();
            ListData = new Paging(nudPage, 15);
        }

        private enum Loc 
        {
            tatCa,
            tamTru,
            tamVang,
            quaHan,
            choDuyet
        }
        //Đổi màu nút nhấn
        private void ChangeBtnColor(Loc type)
        {
            btnTatCa.BackColor = Color.RoyalBlue;
            btnQuaHan.BackColor = Color.RoyalBlue;
            btnTT.BackColor = Color.RoyalBlue;
            btnTV.BackColor = Color.RoyalBlue;
            btnChoDuyet.BackColor = Color.RoyalBlue;

            if (type == Loc.tatCa) 
            {
                btnTatCa.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.tamTru)
            {
                btnTT.BackColor= Color.DarkBlue;
            }
            else if (type == Loc.tamVang)
            {
                btnTV.BackColor= Color.DarkBlue;
            }
            else if (type == Loc.quaHan)
            {
                btnQuaHan.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.choDuyet) 
            {
                btnChoDuyet.BackColor = Color.DarkBlue;
            }
        }

        private void TimKiem(dynamic type)
        {
            LuaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);

        }

        //Load danh sách ban đầu
        private void FDanhSachTamTruTamVang_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            flpnlPhanLoai.Width = 45;
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.tatCa);
            TimKiem(Loc.tatCa);
        }


        //Tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (LuaChon == Loc.tatCa)
                Ds = tttvDAO.LayDanhSachChuaTu(txtTimKiem.Text).ToList<Object>();
            else if (LuaChon == Loc.tamTru)
                Ds = tttvDAO.LayDanhSachTamTru(txtTimKiem.Text).ToList<Object>();
            else if (LuaChon == Loc.tamVang)
                Ds = tttvDAO.LayDanhSachTamVang(txtTimKiem.Text).ToList<Object>();
            else if (LuaChon == Loc.quaHan)
                Ds = tttvDAO.LayDanhSachQuaHan(txtTimKiem.Text).ToList<Object>();
            else if (LuaChon == Loc.choDuyet)
                Ds = tttvDAO.LayDanhSachChoDuyet(txtTimKiem.Text).ToList<Object>();
            nudPage.Value = 1;
            LoadDanhSach(gvTVTT);
        }
        enum LoaiGiaHan
        {
            ngay,
            thang,
            nam
        }

        //Tăng số ngày kết thúc tạm trú tạm vắng
        private void GiaHan(int num, dynamic type)
        {
            Tamtrutamvang? tTTTV = tttvDAO.LayThongTin(CCCDDAO.GetCCCD(gvTVTT,1));
            if (tTTTV != null)
            {
                if (type == LoaiGiaHan.ngay)
                    tTTTV.NgayKt = tTTTV.NgayKt.Value.AddDays(num);
                else if (type == LoaiGiaHan.thang)
                    tTTTV.NgayKt = tTTTV.NgayKt.Value.AddMonths(num);
                else
                    tTTTV.NgayKt = tTTTV.NgayKt.Value.AddYears(num);
                tttvDAO.CapNhat();
            }
        }

        internal override void HeaderText()
        {
            gvTVTT.Columns[0].HeaderText = "Mã tạm trú/ tạm vắng";
            gvTVTT.Columns[1].HeaderText = "Căn cước công dân";
            gvTVTT.Columns[2].HeaderText = "Địa chỉ";
            gvTVTT.Columns[3].HeaderText = "Ngày bắt đầu";
            gvTVTT.Columns[4].HeaderText = "Ngày kết thúc";
            gvTVTT.Columns[5].HeaderText = "Trạng thái";
            gvTVTT.Columns[6].HeaderText = "Lí do";
            gvTVTT.Columns[7].Visible = false;

            gvTVTT.Columns[4].DefaultCellStyle.Format = DayFormat();
            gvTVTT.Columns[3].DefaultCellStyle.Format = DayFormat();

            HightLightQuaHan();
        }

        // Tô đỏ những người quá hạn tạm trú/tạm vắng
        private void HightLightQuaHan()
        {
            for (int index = 0; index < gvTVTT.Rows.Count; index++)
            {
                if ((DateTime)gvTVTT.Rows[index].Cells[4].Value < DateTime.Now)
                {
                    gvTVTT.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        // Lọc danh sách tạm vắng
        private void btnTV_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.tamVang);
            TimKiem(Loc.tamVang);
        }

        // Lọc danh sách tạm trú
        private void btnTT_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.tamTru);
            TimKiem(Loc.tamTru);
        }

        //Chuyển đến form thêm tttv
        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyTamTruTamVang dangKyTTTV = new FDangKyTamTruTamVang();
            (StackForm.TrangChu)?.ChildForm.Open(dangKyTTTV);
        }

        private void gvTVTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        //Xóa thông tin
        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn xóa thông tin tạm trú/tạm vắng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                string maCCCD = CCCDDAO.GetCCCD(gvTVTT, 1);

                if (maCCCD != "")
                {
                    tttvDAO.XoaTamTruTamVang(maCCCD);
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }

        //Lọc danh sách hết hạn tạm trú tạm vắng
        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.quaHan);
            TimKiem(Loc.quaHan);
        }

        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach(gvTVTT);
        }

        //Mở chức năng lọc
        private void btnLoc_Click(object sender, EventArgs e)
        {
            Loc_Click(flpnlPhanLoai);
        }

        // Tăng thời gian tạm trú/tạm vắng thêm 3 ngày
        private void ngayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaHan(3, LoaiGiaHan.ngay);
        }

        // Tăng thời gian tạm trú/tạm vắng thêm 7 ngày / 1 tuần
        private void tuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaHan(7, LoaiGiaHan.ngay);
        }

        // Tăng thời gian tạm trú/tạm vắng thêm 1 tháng
        private void thangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaHan(1, LoaiGiaHan.thang);
        }

        // Tăng thời gian tạm trú/tạm vắng thêm 1 năm
        private void namToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GiaHan(1, LoaiGiaHan.nam);
        }
        //Duyệt yêu cầu tạm trú tạm vắng
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (gvTVTT.Rows.Count > 0)
            {
                string maCCCD = CCCDDAO.GetCCCD(gvTVTT, 1);

                Tamtrutamvang tTTV = tttvDAO.LayThongTin(maCCCD);
                if (tTTV != null)
                {
                    if (tTTV.TrangThai == "CDTV" || tTTV.TrangThai == "CDTT")
                    {
                        if (tTTV.TrangThai == "CDTV")
                            tTTV.TrangThai = "Tạm vắng";
                        else
                            tTTV.TrangThai = "Tạm trú";
                        tttvDAO.CapNhat();
                        MessageBox.Show("Đã duyệt");
                    }

                }
            }
        }
        //Mở danh sách công dân chờ duyệt tttv
        private void btnChoDuyet_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.choDuyet);
            TimKiem(Loc.choDuyet);
        }
    }
}
