﻿using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHoKhau : MoveForm
    {
        private string maHoKhau;
        private HoKhauDAO hkDAO;
        private CongDanDAO cdDAO;

        private ToolsForControl tool; 

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }

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
                Hokhau hk = hkDAO.LayThongTin(MaHoKhau);
                txtCCCDChuHo.Text = hk.CccdchuHo;
                txtMaHoKhau.Text = hk.MaHk;
                txtDiaChi.Text = hk.DiaChi;

                //---Thong tin chu ho---//
                Congdan chuHo = cdDAO.LayThongTin(hk.CccdchuHo);
                txtTenChuHo.Text = chuHo.Ten.ToString();

                //---Quan he voi chu ho---//

                var dsNguoiTrongHo = cdDAO.LayDanhSachTheoHoKhau(maHoKhau);
                gvQuanHeVoiChuHo.DataSource = dsNguoiTrongHo;
                lblTong.Text = "Tổng thành viên: " + dsNguoiTrongHo.Count.ToString();
            }
        }
        private void CapNhatHoKhau()
        {
            Hokhau hoKhau = hkDAO.LayThongTin(maHoKhau);
            if (txtDiaChi.Text != "")
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
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
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
                    FThongTinCongDan ttCD = new FThongTinCongDan(cdDAO.LayThongTin(maCCCD));
                    ttCD.ShowDialog();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tool.AutoReadOnly();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHoKhau();
            LayThongTinHoKhau();
            tool.TurnOff();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
            tool.State = ToolsForControl.Turn.on;
            tool.TurnOff();
        }
    }
}
