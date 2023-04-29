using QuanLiCongDanThanhPho.Model;
using System.Data;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachHoKhau : FormDanhSach
    {
        private HoKhauDAO hkDAO;
        
        enum Loc 
        {
            tatCa,
            soTv
        }
        public FDanhSachHoKhau()
        {
            InitializeComponent();

            hkDAO = new HoKhauDAO();
            ListData = new Paging(nudPage, 10);
        }

        private void TimKiem(dynamic type)
        {
            LuaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }
        private void FDanhSachHoKhau_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            flpnlPhanLoai.Width = 45;
        }

        private void gvHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
        }

        internal override void HeaderText()
        {
            gvHoKhau.Columns[0].HeaderText = "Mã Hộ Khẩu";
            gvHoKhau.Columns[1].HeaderText = "Địa chỉ";
            gvHoKhau.Columns[2].HeaderText = "Căn cước công dân chủ hộ";
            gvHoKhau.Columns[3].Visible = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (LuaChon == Loc.tatCa)
                Ds = hkDAO.LayDanhSachChuaTu(txtTimKiem.Text).ToList<Object>();
            else if (LuaChon == Loc.soTv)
                Ds = hkDAO.LayDanhSachXepTheoSoTV(txtTimKiem.Text).ToList<Object>();

            nudPage.Value = 1;
            LoadDanhSach(gvHoKhau);
        }

        private void btnSoTV_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.soTv);
        }

        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maHoKhau = getMaHk();
            if (maHoKhau != "")
            {
                FThongTinHoKhau tTHK = new FThongTinHoKhau(maHoKhau);
                tTHK.ShowDialog();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyHoKhau dangKyHoKhau = new FDangKyHoKhau();
            (StackForm.TrangChu).ChildForm.Open(dangKyHoKhau);
        }

        private string getMaHk()
        {
            return (string)gvHoKhau.CurrentRow.Cells[0].Value;
        }

        private void cmnusMenuTachGop_Click(object sender, EventArgs e)
        {
            string maHoKhau = getMaHk();
            if (maHoKhau != "")
            {
                FDangKyHoKhau dangKyHoKhau = new FDangKyHoKhau(maHoKhau);
                (StackForm.TrangChu).ChildForm.Open(dangKyHoKhau);
            }
        }

        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach(gvHoKhau);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Loc_Click(flpnlPhanLoai);
        }
    }
}
