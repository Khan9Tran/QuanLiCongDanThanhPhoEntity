using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCCCD : Form
    {
        private Congdan congDan;
        private KhaiSinhDAO kSDAO;
        private CCCDDAO CccdDAO;
        private HoKhauDAO hKDAO;

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        private HinhDaiDien hinhCongDan;

        public FThongTinCCCD(Congdan congDan)
        {
            InitializeComponent();
            StackForm.Add(this);
            this.congDan = congDan;
            kSDAO = new KhaiSinhDAO();
            CccdDAO = new CCCDDAO();
            hKDAO = new HoKhauDAO();
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }
        private void HienThiThongTin()
        {
            lblCCCD.Text = congDan.Cccd;
            lblTen.Text = congDan.Ten.ToUpper();

            Khaisinh ks = kSDAO.LayThongTin(lblCCCD.Text);
            if (ks != null)
            {
                if (ks.GioiTinh == "m")
                    lblGioiTinh.Text = "Nam";
                else lblGioiTinh.Text = "Nữ";
                lblNgaySinh.Text = ks.NgaySinh.ToString("dd/MM/yyyy");
                lblQueQuan.Text = ks.QueQuan;
                lblQuocTich.Text = ks.QuocTich;
            }

            Hokhau hk = hKDAO.LayThongTin(congDan.MaHk);
            if (hk != null)
                lblDiaChi.Text = hk.DiaChi;

            Cccd cCCD = CccdDAO.LayThongTin(new Cccd() { MaCccd = congDan.Cccd });
            if (cCCD != null)
            {
                lblNgayCap.Text = ((DateTime)cCCD.NgayCap).ToString("dd/MM/yyyy");
                lblDDNhanDang.Text = cCCD.DacDiem;
            }
        }
        private void FThongTinCCCD_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            hinhCongDan.LayHinhDaiDien(lblCCCD.Text, ptcHinhDaiDien);
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
    }
}
