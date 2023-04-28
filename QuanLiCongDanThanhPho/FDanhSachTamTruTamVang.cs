using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachTamTruTamVang : Form
    {
        private TamTruTamVangDAO tttvDAO;
        private dynamic luaChon;
        private List<Tamtrutamvang> ds;
        private Paging listTamTruTamVang;

        public FDanhSachTamTruTamVang()
        {
            InitializeComponent();
            StackForm.Add(this);
            ds = new List<Tamtrutamvang>();
            tttvDAO = new TamTruTamVangDAO();
            listTamTruTamVang = new Paging(nudPage, 10);
        }

        private enum Loc 
        {
            tatCa,
            tamTru,
            tamVang,
            quaHan
        }
        private void TimKiem(dynamic type)
        {
            luaChon = type;
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
            TimKiem(Loc.tatCa);
        }


        //Tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == Loc.tatCa)
                ds = tttvDAO.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == Loc.tamVang)
                ds = tttvDAO.LayDanhSachTamTru(txtTimKiem.Text);
            else if (luaChon == Loc.tamVang)
                ds = tttvDAO.LayDanhSachTamVang(txtTimKiem.Text);
            else if (luaChon == Loc.quaHan)
                ds = tttvDAO.LayDanhSachQuaHan(txtTimKiem.Text);
            nudPage.Value = 1;
            LoadDanhSach();
        }
        enum LoaiGiaHan
        {
            ngay,
            thang,
            nam
        }
        private void GiaHan(int num, dynamic type)
        {
            Tamtrutamvang tTTTV = tttvDAO.LayThongTin(CCCDDAO.GetCCCD(gvTVTT,1));
            if (type == LoaiGiaHan.ngay)
                tTTTV.NgayKt = tTTTV.NgayKt.Value.AddDays(num);
            else if (type ==  LoaiGiaHan.thang)
                tTTTV.NgayKt = tTTTV.NgayKt.Value.AddMonths(num);
            else
                tTTTV.NgayKt = tTTTV.NgayKt.Value.AddYears(num);
            tttvDAO.CapNhat();
        }
        private string DayFormat()
        {
            return "dd/MM/yyyy";
        }
        private void LoadDanhSach()
        {
            gvTVTT.DataSource = listTamTruTamVang.NgatTrang(ds);
            gvTVTT.Columns[4].DefaultCellStyle.Format = DayFormat();
            gvTVTT.Columns[3].DefaultCellStyle.Format = DayFormat();

            HeaderText();
            HightLightQuaHan();
        }
        private void HeaderText()
        {
            gvTVTT.Columns[0].HeaderText = "Mã tạm trú tạm vắng";
            gvTVTT.Columns[1].HeaderText = "Căn cước công dân";
            gvTVTT.Columns[2].HeaderText = "Địa chỉ";
            gvTVTT.Columns[3].HeaderText = "Ngày bắt đầu";
            gvTVTT.Columns[4].HeaderText = "Ngày kết thúc";
            gvTVTT.Columns[5].HeaderText = "Trạng thái";
            gvTVTT.Columns[6].HeaderText = "Lí do";
            gvTVTT.Columns[7].Visible = false;
        }
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

        private void btnTV_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tamVang);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tamTru);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyTamTruTamVang dangKyTTTV = new FDangKyTamTruTamVang();
            (StackForm.TrangChu).ChildForm.Open(dangKyTTTV);
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
            TimKiem(Loc.quaHan);
        }


        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (flpnlPhanLoai.Width > 50)
                flpnlPhanLoai.Width = 45;
            else
                flpnlPhanLoai.Width = 800;
        }

        private void ngayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaHan(3, LoaiGiaHan.ngay);
        }

        private void tuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaHan(7, LoaiGiaHan.ngay);
        }
        private void thangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaHan(1, LoaiGiaHan.thang);
        }

        private void namToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GiaHan(1, LoaiGiaHan.nam);
        }
    }
}
