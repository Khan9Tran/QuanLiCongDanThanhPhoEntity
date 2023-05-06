using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinKhaiSinh : MoveForm
    {
        private string? maCCCD;
        private KhaiSinhDAO ksDAO;
        private CongDanDAO cdDAO;

        private ToolsForControl? tool;


        public string? MaCCCD { get => maCCCD; set => maCCCD = value; }

        public FThongTinKhaiSinh(string maCCCD)
        {
            MaCCCD = maCCCD;

            InitializeComponent();
            StackForm.Add(this);

            ksDAO = new KhaiSinhDAO();
            cdDAO = new CongDanDAO();

            SetTools();
        }
        private void btnThongTinCha_Click(object sender, EventArgs e)
        {
            OpenThanNhan(txtCccdCha);
        }

        private void OpenThanNhan(TextBox txtCongDan)
        {
            if (KiemTraDuLieuNhap.isCCCD(txtCongDan.Text))
            {
                Congdan? cD = cdDAO.LayThongTin(txtCongDan.Text);
                if (cD != null)
                {
                    FThongTinCongDan tTCD = new FThongTinCongDan(cD);
                    tTCD.ShowDialog();
                }
            }
        }

        private void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            { txtGioiTinh, txtQuocTich, txtDanToc, txtQueQuan, txtNoiSinh};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgaySinh, dtmNgayDangKy
            };
            tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isGioiTinh(txtGioiTinh.Text))
            {
                MessageBox.Show("Giới tính sai địng dạng");
                txtGioiTinh.Focus();
                return false;
            }
            if (txtQuocTich.Text == "")
            {
                MessageBox.Show("Quốc tịch không được để trống");
                txtQuocTich.Focus();
                return false;
            }
            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Dân tộc không được để trống");
                txtDanToc.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                MessageBox.Show("Quê quán sai địng dạng");
                txtQueQuan.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtNoiSinh.Text))
            {
                MessageBox.Show("Nơi sinh sai địng dạng");
                txtNoiSinh.Focus();
                return false;
            }
            return true;
        }
        private void btnThongTinMe_Click(object sender, EventArgs e)
        {
            OpenThanNhan(txtCccdMe);
        }

        private enum thanNhan
        {
            cha,
            me
        }
        private void LoadQuocTich(string cCCD, TextBox quocTich)
        {
            Khaisinh? ks = ksDAO.LayThongTin(cCCD);
            if (ks != null)
            {
                quocTich.Text = ks.QuocTich;
            }    
        }
        public void LayThongTinKhaiKhaiSinh()
        {
            if (maCCCD != null)
            {
                Khaisinh? ks = ksDAO.LayThongTin(maCCCD);
                if (ks != null)
                {

                    if (ks.Cccdcha != null)
                    {
                        LoadQuocTich(ks.Cccdcha, txtQuocTichCha);
                    }
                    if (ks.Cccdme != null)
                    {
                        LoadQuocTich(ks.Cccdme, txtQuocTichMe);

                    }

                    txtTen.Text = ks.Ten;
                    txtCccd.Text = ks.MaKs;
                    txtNoiSinh.Text = ks.NoiSinh;
                    dtmNgaySinh.Value = ks.NgaySinh;

                    if (ks.GioiTinh == "f")
                        txtGioiTinh.Text = "Nữ";
                    else if (ks.GioiTinh == "m")
                        txtGioiTinh.Text = "Nam";
                    else
                        txtGioiTinh.Text = "u";

                    txtDanToc.Text = ks.DanToc;
                    txtQuocTich.Text = ks.QuocTich;
                    txtQueQuan.Text = ks.QueQuan;

                    txtTenCha.Text = ks.TenCha;
                    txtTenMe.Text = ks.TenMe;

                    txtCccdCha.Text = ks.Cccdcha;
                    txtCccdMe.Text = ks.Cccdme;
                    if (ks.NgayDangKy != null)
                    {
                        dtmNgayDangKy.Value = ks.NgayDangKy.Value;
                    }
                }
            }
        }
        private void FThongTinKhaiSinh_Load(object sender, EventArgs e)
        {
            LayThongTinKhaiKhaiSinh();
        }

        private void CapNhatKhaiSinh()
        {
            if (KiemTraThongTin())
            {
                if (MaCCCD != null)
                {
                    Khaisinh? kS = ksDAO.LayThongTin(MaCCCD);
                    if (kS != null)
                    {
                        kS.NoiSinh = txtNoiSinh.Text;
                        kS.QueQuan = txtQueQuan.Text;
                        kS.NgaySinh = dtmNgaySinh.Value;
                        kS.DanToc = txtDanToc.Text;
                        kS.QuocTich = txtQuocTich.Text;
                        if (txtGioiTinh.Text == "nam")
                            kS.GioiTinh = "m";
                        else
                            kS.GioiTinh = "f";
                        kS.NgayDangKy = dtmNgayDangKy.Value;
                        ksDAO.CapNhatKhaiSinh();
                        tool?.TurnOff();
                        LayThongTinKhaiKhaiSinh();
                        MessageBox.Show("Cập nhật thành công");
                    }
                }
            }    
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatKhaiSinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tool?.AutoReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            tool?.TurnOff();
            LayThongTinKhaiKhaiSinh();
        }
    }
}
