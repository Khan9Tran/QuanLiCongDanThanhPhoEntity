using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinThue : MoveForm
    {
        private string? maCCCD;
        private ToolsForControl? tool;

        private ThueDAO thueDAO;
        private CongDanDAO cdDAO;
        private HoKhauDAO hkDAO;

        public string? MaCCCD { get => maCCCD; set => maCCCD = value; }

        public FThongTinThue(string maCCCD)
        {
            InitializeComponent();
            StackForm.Add(this);

            MaCCCD = maCCCD;
            thueDAO = new ThueDAO();
            cdDAO = new CongDanDAO();
            hkDAO = new HoKhauDAO();

            SetTools();
        }


        private void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            {txtSoTienCanNop, txtSoTienDaNop};

            List<Control> listControl = new List<Control>()
            {
                dtmHanNopThue, dtmNgayCapMaSoThue, btnXacNhan
            };
            tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void LayThongTinThue()
        {
            if (MaCCCD != null)
            {
                Thue? thue = thueDAO.LayThongTin(MaCCCD);
                Congdan? cd = cdDAO.LayThongTin(MaCCCD);
                if (cd != null)
                {
                    string? maHk = cd.MaHk;
                    if (maHk != null)
                    {
                        Hokhau? hk = hkDAO.LayThongTin(maHk);
                        txtDiaChi.Text = hk.DiaChi;
                    }
                    txtMaSoThue.Text = maHk;
                    txtTen.Text = cd.Ten;
                    txtCCCD.Text = cd.Cccd;
                    txtSdt.Text = cd.Sdt;
                }
                txtSoTienCanNop.Text = thue.SoTienCanNop;
                txtSoTienDaNop.Text = thue.SoTienDaNop;
                if (thue.NgayCap != null)
                    dtmNgayCapMaSoThue.Value = thue.NgayCap.Value;
                if (thue.HanNop != null)
                    dtmHanNopThue.Value = thue.HanNop.Value;
            }
        }
        private void FThongTinThue_Load(object sender, EventArgs e)
        {
            LayThongTinThue();
        }

        private void CapNhatThue()
        {
            Thue? thue = thueDAO.LayThongTin(MaCCCD);

            if (txtMaSoThue.Text != "" && thue != null)
            {
                thue.Cccd = txtCCCD.Text;
                thue.SoTienCanNop = txtSoTienCanNop.Text;
                thue.SoTienDaNop = txtSoTienDaNop.Text;
                thue.NgayCap = dtmNgayCapMaSoThue.Value;
                thue.HanNop = dtmHanNopThue.Value;
                if (KiemTraDuLieuNhap.KiemTraThue(thue))
                {
                    thueDAO.CapNhatThue();
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }    
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatThue();
            LayThongTinThue();
            tool?.TurnOff(); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                tool?.AutoReadOnly();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinThue();
            tool?.TurnOff();
        }
    }
}
