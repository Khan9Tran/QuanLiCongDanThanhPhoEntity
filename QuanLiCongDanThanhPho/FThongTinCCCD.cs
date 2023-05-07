using QuanLiCongDanThanhPho.Model;


namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCCCD : FormThongTin
    {

        private HinhDaiDien hinhCongDan;

        public FThongTinCCCD(Congdan congDan)
        {
            InitializeComponent();
            CongDan = congDan;
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }
        
        private string DateTimeFormat()
        {
            return "dd/MM/yyyy";
        }
        private void HienThiThongTin()
        {
            lblCCCD.Text = CongDan.Cccd;
            lblTen.Text = CongDan.Ten.ToUpper();

            Khaisinh? ks = KSDAO.LayThongTin(lblCCCD.Text);
            if (ks != null)
            {
                if (ks.GioiTinh == "m")
                    lblGioiTinh.Text = "Nam";
                else 
                    lblGioiTinh.Text = "Nữ";

                lblNgaySinh.Text = ks.NgaySinh.ToString(DateTimeFormat());
                lblQueQuan.Text = ks.QueQuan;
                lblQuocTich.Text = ks.QuocTich;
            }

            Hokhau? hk = HKDAO.LayThongTin(CongDan.MaHk);
            if (hk != null)
                lblDiaChi.Text = hk.DiaChi;

            Cccd? cCCD = CCCDDAO.LayThongTin(new Cccd() { MaCccd = CongDan.Cccd });
            if (cCCD != null)
            {
                lblNgayCap.Text = ((DateTime)cCCD.NgayCap).ToString(DateTimeFormat());
                lblDDNhanDang.Text = cCCD.DacDiem;
            }
        }
        private void FThongTinCCCD_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            hinhCongDan.LayHinhDaiDien(lblCCCD.Text, ptcHinhDaiDien);
        }

    }
}
