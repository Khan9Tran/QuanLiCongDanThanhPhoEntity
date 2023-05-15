using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FXemCongDan : Form
    {
        private HinhDaiDien hinhCongDan;
        private Congdan? congDan;
        private KhaiSinhDAO kSDAO;
        private HoKhauDAO hKDAO;
        private ThueDAO thueDAO;
        private HonNhanDAO hNDAO;
        private string maTamTru = "00000B";
        private string maChuaCoHK = "00000A";

        public FXemCongDan(Congdan? congdan)
        {
            InitializeComponent();
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
            kSDAO = new KhaiSinhDAO();
            hKDAO = new HoKhauDAO();
            thueDAO = new ThueDAO();
            hNDAO = new HonNhanDAO();
            congDan = congdan;
        }

        private bool isMaHK(string? maHK)
        {
            return maHK != maTamTru && maHK != maChuaCoHK;
        }

        private void LayCongDan()
        {
            txtCCCD.Text = congDan.Cccd;
            txtTen.Text = congDan.Ten;
            txtSDT.Text = congDan.Sdt;
            hinhCongDan.LayHinhDaiDien(txtCCCD.Text, picHinhDaiDien);
        }

        private void LayKhaiSinh()
        {
            Khaisinh? ks = kSDAO.LayThongTin(congDan.Cccd);
            if (ks != null)
            {
                txtQuocTich.Text = ks.QuocTich;
                txtDanToc.Text = ks.DanToc;
                dtpNgaySinh.Value = ks.NgaySinh;
                if (ks.GioiTinh == "f")
                {
                    picNam.Hide();
                    picNu.Show();
                }
                else
                {
                    picNu.Hide();
                    picNam.Show();
                }
            }
        }

        private void LayHoKhau()
        {
            if (congDan.MaHk != null)
            {
                Hokhau? hk = hKDAO.LayThongTin(congDan.MaHk);
                if (hk != null)
                {
                    if (hk != null && isMaHK(hk.MaHk))
                    {
                        txtMaHoKhau.Text = hk.MaHk;
                        txtDiaChi.Text = hk.DiaChi;
                    }
                }
            }
        }

        private void LayThue()
        {
            Thue? thue = thueDAO.LayThongTin(congDan.Cccd);
            if (thue != null)
                txtMaThue.Text = thue.MaThue;
        }

        private void LayHonNhan()
        {
            Honnhan? hn = hNDAO.LayThongTin(congDan.Cccd);
            if (hn == null)
            {
                txtMaHonNhan.Text = "Chưa có hôn nhân";
            }
            else
                txtMaHonNhan.Text = hn.MaHonNhan;
        }

        private void FXemCongDan_Load(object sender, EventArgs e)
        {
            if (congDan != null)
            {
                LayCongDan();
                LayKhaiSinh();
                LayHoKhau();
                LayHonNhan();
                LayThue();
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHoKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuocTich_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDanToc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
