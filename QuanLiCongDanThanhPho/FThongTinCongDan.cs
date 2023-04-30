using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCongDan : MoveForm
    {
        private CongDanDAO cdDAO;
        private KhaiSinhDAO ksDAO;
        private ThueDAO thueDAO;
        private HonNhanDAO hnDAO;
        private HoKhauDAO hkDAO;
        private TamTruTamVangDAO tttvDAO;
        private CCCDDAO cCCDDAO;

        private ToolsForControl? tool;

        private string maTamTru = "00000B";
        private string maChuaCoHK = "00000A";

        private HinhDaiDien hinhCongDan;
        private Congdan congDan;

        public FThongTinCongDan(Congdan congdan)
        {
            InitializeComponent();
            StackForm.Add(this);
            cdDAO = new CongDanDAO();
            ksDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hkDAO = new HoKhauDAO();
            hnDAO = new HonNhanDAO();
            tttvDAO = new TamTruTamVangDAO();
            cCCDDAO = new CCCDDAO();
            congDan = congdan;
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
            SetTools();
        }
        
        //Mở F khai sinh
        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FThongTinKhaiSinh tTKS = new FThongTinKhaiSinh(congDan.Cccd);
            tTKS.ShowDialog();
        }

        private void SetTools()
        { 
            List<TextBox> listTxt = new List<TextBox>()
            { txtNgheNghiep, txtHoVaTen, txtSDT, txtTonGiao, txtDanToc, txtQueQuan,
                txtQuocTich, txtDiaChi, txtGioiTinh, txtQuanHeVoiChuHo};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgaySinh, ptcHinhDaiDien
            };
            tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void LayCongDan()
        {
            if (congDan != null)
            {
                txtCCCD.Text = congDan.Cccd;
                txtHoVaTen.Text = congDan.Ten;

                if (isMaHK(congDan.MaHk))
                    txtMaHoKhau.Text = congDan.MaHk;

                txtSDT.Text = congDan.Sdt;
                txtTonGiao.Text = congDan.TonGiao;
                txtNgheNghiep.Text = congDan.NgheNghiep;
                txtQuanHeVoiChuHo.Text = congDan.QuanHeVoiChuHo;
            }
        }

        private void LayKhaiSinh()
        {
            Khaisinh? ks = ksDAO.LayThongTin(congDan.Cccd);
            if (ks != null)
            {
                dtmNgaySinh.Value = ks.NgaySinh;
                if (ks.GioiTinh == "f")  // "f" là giới tính nữ, "m" là nam
                    txtGioiTinh.Text = "Nữ";
                else
                    txtGioiTinh.Text = "Nam";
                txtDanToc.Text = ks.DanToc;
                txtQuocTich.Text = ks.QuocTich;
                txtQueQuan.Text = ks.QueQuan;
            }
        }

        private void LayThue()
        {
            Thue? thue = thueDAO.LayThongTin(congDan.Cccd);
            if (thue == null)
                btnThue.Enabled = false;
            else
                txtMaThue.Text = thue.MaThue;
        }

        private void LayHonNhan()
        {
            Honnhan? hn = hnDAO.LayThongTin(congDan.Cccd);
            if (hn == null)
            {
                txtHonNhan.Text = "Chưa có hôn nhân";
                btnHonNhan.Enabled = false;
            }
            else
                txtHonNhan.Text = hn.MaHonNhan;
        }

        private void LayHoKhau()
        {
            if (congDan.MaHk != null)
            {
                Hokhau? hk = hkDAO.LayThongTin(congDan.MaHk);
                if (hk != null && isMaHK(hk.MaHk))
                {
                    txtDiaChi.Text = hk.DiaChi;
                }
                else
                {
                    txtQuanHeVoiChuHo.Text = "Không có";
                    btnHoKhau.Enabled = false;
                }
            }
        }

        private void LayTamTruTamVang()
        {
           Tamtrutamvang? tttv = tttvDAO.LayThongTin(congDan.Cccd);
            if (tttv == null)
                txtGhiChu.Text = "Không có ghi chú";
            else
            {
                string? trangThai = tttv.TrangThai;
                txtGhiChu.Text = trangThai;
            }
        }


        public void LayThongTinCongDan()
        {
            if (congDan != null)
            {
                LayCongDan();
                LayKhaiSinh();
                LayThue();
                LayHonNhan();
                LayHoKhau();
                LayTamTruTamVang();
                hinhCongDan.LayHinhDaiDien(txtCCCD.Text,ptcHinhDaiDien);
            }
        }
        private void TatXemCCCD()
        {
            Cccd? cccd = new Cccd()
            {
                MaCccd = congDan.Cccd
            };

            cccd = cCCDDAO.LayThongTin(cccd);

            if (cccd == null || cccd.DacDiem == null)
            {
                btnThongTinCCCD.Enabled = false;
            }
        }
        private void FThongTinCongDan_Load(object sender, EventArgs e)
        {
            LayThongTinCongDan();
            TatXemCCCD();
        }

        private bool isMaHK(string? maHK)
        {
            return maHK != maTamTru && maHK != maChuaCoHK;
        }
        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            Congdan? cd = cdDAO.LayThongTin(congDan.Cccd);
            if (cd != null)
            {
                string? hK = cd.MaHk;
                if (hK != null)
                {
                    if (isMaHK(cd.MaHk))
                    {
                        FThongTinHoKhau tTHK = new FThongTinHoKhau(hK);
                        tTHK.ShowDialog();
                    }
                }
            }
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            FThongTinThue tTThue = new FThongTinThue(congDan.Cccd);
            tTThue.ShowDialog();
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isTen(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại họ và tên");
                txtHoVaTen.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isGioiTinh(txtGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại giới tính");
                txtGioiTinh.Focus();
                return false;
            }
            if (txtNgheNghiep.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại nghề nghiệp");
                txtNgheNghiep.Focus();
                return false;
            }
            if (txtQuocTich.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại quốc tịch");
                txtQuocTich.Focus();
                return false;
            }
            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại dân tộc");
                txtDanToc.Focus();
                return false;
            }
            if (txtTonGiao.Text == "")
            {
                MessageBox.Show("Tôn giáo không được để trống");
                txtTonGiao.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại địa chỉ");
                txtDiaChi.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại quê quán");
                txtQueQuan.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isSoDT(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số điện thoại");
                txtSDT.Focus();
                return false;
            }      
            if (txtQuanHeVoiChuHo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mối quan hệ với chủ hộ");
                txtQuanHeVoiChuHo.Focus();
                return false;
            }    
            return true;
        }

        private void btnHonNhan_Click(object sender, EventArgs e)
        {
            FThongTinHonNhan tTHN = new FThongTinHonNhan(congDan.Cccd);
            tTHN.ShowDialog();
        }

        private void CapNhatKhaiSinh()
        {
            Khaisinh? khaiSinh = ksDAO.LayThongTin(congDan.Cccd);
            if (khaiSinh != null)
            {
                khaiSinh.Ten = txtHoVaTen.Text;
                khaiSinh.QueQuan = txtQueQuan.Text;
                khaiSinh.NgaySinh = dtmNgaySinh.Value;
                khaiSinh.DanToc = txtDanToc.Text;
                khaiSinh.QuocTich = txtQuocTich.Text;
                if (txtGioiTinh.Text == "Nam")
                    khaiSinh.GioiTinh = "m";
                else
                    khaiSinh.GioiTinh = "f";
                ksDAO.CapNhatKhaiSinh();
            }
        }    

        private void CapNhatCongDan()
        {
            congDan.Ten = txtHoVaTen.Text;
            congDan.Sdt = txtSDT.Text;
            congDan.NgheNghiep = txtNgheNghiep.Text;
            congDan.TonGiao = txtTonGiao.Text;
            congDan.QuanHeVoiChuHo = txtQuanHeVoiChuHo.Text;
            cdDAO.CapNhatCongDan();
        }

        //Thay đổi chủ hộ ở table hộ khẩu nếu có
        private void CapNhatHoKhau()
        {
            Hokhau? hoKhau = hkDAO.LayThongTin(txtMaHoKhau.Text);
            if (hoKhau != null)
            {
                if (txtQuanHeVoiChuHo.Text == "Chủ hộ" && hoKhau.CccdchuHo != txtCCCD.Text)
                {
                    string? hK = hoKhau.CccdchuHo;
                    if (hK != null)
                    {
                        Congdan? cD = cdDAO.LayThongTin(hK);
                        if (cD != null)
                        {
                            cD.QuanHeVoiChuHo = "Unknow";
                            hoKhau.CccdchuHo = txtCCCD.Text;
                            cdDAO.CapNhatCongDan();
                        }
                    }
                }
                hoKhau.DiaChi = txtDiaChi.Text;
                hkDAO.CapNhatHoKhau();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            tool?.AutoReadOnly();
        }

        private void CapNhatHonNhan()
        {
            if (txtHonNhan.Text != "Chưa có hôn nhân" && txtHonNhan.Text != "")
            {
                Honnhan? hn = hnDAO.LayThongTin(congDan.Cccd);
                if (hn != null && hn.TenNam != txtHoVaTen.Text && hn.TenNu != txtHoVaTen.Text)
                {
                    if (txtCCCD.Text == hn.Cccdnam)
                        hn.TenNam = txtHoVaTen.Text;
                    else
                        hn.TenNu = txtHoVaTen.Text;
                    hnDAO.CapNhatHonNhan();
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {  
            if (KiemTraThongTin())
            {
                CapNhatHoKhau();
                CapNhatKhaiSinh();
                CapNhatHonNhan();
                CapNhatCongDan();
                tool?.AutoReadOnly();
            }    
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinCongDan();
            tool?.AutoReadOnly();
        }

        private void ThemHinh()
        {
            if (hinhCongDan.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien))
            {
                hinhCongDan.SaveHinhDaiDien(txtCCCD.Text, ofdHinhDaiDien, ptcHinhDaiDien);
            }
        }
        private void picCongDan_Click(object sender, EventArgs e)
        {
            ptcHinhDaiDien.Image = null;
            ThemHinh();
        }

        private void btnThongTinCCCD_Click(object sender, EventArgs e)
        {
            Congdan? cD = cdDAO.LayThongTin(congDan.Cccd);
            if (cD != null)
            {
                FThongTinCCCD thongTinCCCD = new FThongTinCCCD(cD);
                thongTinCCCD.ShowDialog();
            }
        }
    }
}
