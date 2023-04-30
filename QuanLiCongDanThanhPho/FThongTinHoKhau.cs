using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHoKhau : MoveForm
    {
        private string? maHoKhau;
        private HoKhauDAO hkDAO;
        private CongDanDAO cdDAO;

        private ToolsForControl? tool; 

        public string? MaHoKhau { get => maHoKhau; set => maHoKhau = value; }

        public FThongTinHoKhau(string maHoKhau)
        {
            MaHoKhau = maHoKhau;
            InitializeComponent();
            StackForm.Add(this);

            hkDAO = new HoKhauDAO();
            cdDAO = new CongDanDAO();

            SetTools();
        }
        public void LayThongTinHoKhau()
        {
            if (MaHoKhau != null)
            {
                Hokhau? hk = hkDAO.LayThongTin(MaHoKhau);
                if (hk != null)
                {
                    txtCCCDChuHo.Text = hk.CccdchuHo;
                    txtMaHoKhau.Text = hk.MaHk;
                    txtDiaChi.Text = hk.DiaChi;

                    if (maHoKhau != null)
                    {
                        //---Thong tin chu ho---//
                        Congdan? chuHo = cdDAO.LayThongTin(maHoKhau);
                        if (chuHo != null)
                            txtTenChuHo.Text = chuHo.Ten.ToString();

                        //---Quan he voi chu ho---//

                        var dsNguoiTrongHo = cdDAO.LayDanhSachTheoHoKhau(maHoKhau);
                        gvQuanHeVoiChuHo.DataSource = dsNguoiTrongHo;
                        lblTong.Text = "Tổng thành viên: " + dsNguoiTrongHo.Count.ToString();
                    }
                }
            }
        }
        private void CapNhatHoKhau()
        {
            Hokhau? hoKhau = hkDAO.LayThongTin(maHoKhau);
            if (txtDiaChi.Text != "" && hoKhau != null)
            {
                hoKhau.DiaChi = txtDiaChi.Text;
            }
            hkDAO.CapNhatHoKhau();
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

        private void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            {txtDiaChi};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan
            };
            tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }
     
        private void gvQuanHeVoiChuHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string maCCCD = (string)gvQuanHeVoiChuHo.CurrentRow.Cells[0].Value;
                if (maCCCD != "")
                {
                    Congdan? cD = cdDAO.LayThongTin(maCCCD);
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
            tool?.AutoReadOnly();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHoKhau();
            LayThongTinHoKhau();
            tool?.TurnOff();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
            if (tool != null)
            {
                tool.State = ToolsForControl.Turn.on;
                tool?.TurnOff();
            }
        }
    }
}
