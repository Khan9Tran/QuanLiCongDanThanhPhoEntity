using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHoKhau : FormThongTin
    {

        public FThongTinHoKhau(string maHoKhau)
        {
            InitializeComponent();
            MaHoKhau = maHoKhau;

            SetTools();
        }
        public void LayThongTinHoKhau()
        {
            if (MaHoKhau != null)
            {
                Hokhau? hk = HKDAO.LayThongTin(MaHoKhau);
                if (hk != null)
                {
                    txtCCCDChuHo.Text = hk.CccdchuHo;
                    txtMaHoKhau.Text = hk.MaHk;
                    txtDiaChi.Text = hk.DiaChi;

                    if (MaHoKhau != null)
                    {
                        //---Thong tin chu ho---//
                        Congdan? chuHo = CDDAO.LayThongTin(hk.CccdchuHo);
                        if (chuHo != null)
                            txtTenChuHo.Text = chuHo.Ten.ToString();

                        //---Quan he voi chu ho---//

                        var dsNguoiTrongHo = CDDAO.LayDanhSachTheoHoKhau(MaHoKhau);
                        gvQuanHeVoiChuHo.DataSource = dsNguoiTrongHo;
                        lblTong.Text = "Tổng thành viên: " + dsNguoiTrongHo.Count.ToString();
                    }
                }
            }
        }
        private void CapNhatHoKhau()
        {
            Hokhau? hoKhau = HKDAO.LayThongTin(MaHoKhau);

            if (KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text) && hoKhau != null)
            {
                hoKhau.DiaChi = txtDiaChi.Text;
                HKDAO.CapNhatHoKhau();
                MessageBox.Show("Cập nhật thành công");
            }
        }
        private void FThongTinHoKhau_Load(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
            HeaderText();
        }

        private void HeaderText()
        {
            gvQuanHeVoiChuHo.Columns[0].HeaderText = "CCCD";
            gvQuanHeVoiChuHo.Columns[1].HeaderText = "Tên";
            gvQuanHeVoiChuHo.Columns[2].HeaderText = "Nghề nghiệp";
            gvQuanHeVoiChuHo.Columns[3].HeaderText = "Số điện thoại";
            gvQuanHeVoiChuHo.Columns[4].HeaderText = "Tôn giáo";
            gvQuanHeVoiChuHo.Columns[5].Visible = false;
            gvQuanHeVoiChuHo.Columns[6].HeaderText = "Quan hệ với chủ hộ";
            gvQuanHeVoiChuHo.Columns[7].Visible = false;
            gvQuanHeVoiChuHo.Columns[8].Visible = false;
        }

        internal override void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            {txtDiaChi};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan
            };
            Tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void gvQuanHeVoiChuHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string maCCCD = (string)gvQuanHeVoiChuHo.CurrentRow.Cells[0].Value;
                if (maCCCD != "")
                {
                    Congdan? cD = CDDAO.LayThongTin(maCCCD);
                    if (cD != null)
                    {
                        FThongTinCongDan ttCD = new FThongTinCongDan(cD);
                        ttCD.ShowDialog();
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Tool?.AutoReadOnly();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHoKhau();
            LayThongTinHoKhau();
            Tool?.TurnOff();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
            if (Tool != null)
            {
                Tool.State = ToolsForControl.Turn.on;
                Tool?.TurnOff();
            }
        }
    }
}
