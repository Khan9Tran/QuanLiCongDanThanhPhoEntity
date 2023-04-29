using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCongDan : Form
    {
        private CongDanDAO cDDAO;
        private KhaiSinhDAO kSDAO;
        private ThueDAO thueDAO;
        private HonNhanDAO hNDAO;
        private HoKhauDAO hKDAO;
        private HinhDaiDien hinhCongDan;

        public FDangKyCongDan()
        {
            InitializeComponent();
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            kSDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hNDAO = new HonNhanDAO();
            hKDAO = new HoKhauDAO();
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }
        public bool isData()
        {
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text))
            {
                MessageBox.Show("Nhập CCCD 12 số");
                txtCCCD.Focus();
                return false;
            }
            return true;
        }    

        public void ThemCongDan()
        {
            if (KiemTraThongTin())
            {
                if (cboQuanHe.SelectedItem.ToString() == "Chủ hộ")
                {
                    Hokhau hK = new Hokhau()
                    {
                        MaHk = txtHoKhau.Text,
                        DiaChi = txtDiaChi.Text,
                        CccdchuHo = txtCCCD.Text,
                    };

                    hKDAO.ThemHoKhau(hK);
                }
                Congdan cD = new Congdan()
                {
                    Cccd = txtCCCD.Text,
                    Ten = txtTen.Text, 
                    NgheNghiep = txtNgheNghiep.Text,
                    Sdt = txtSoDT.Text,
                    TonGiao = cboTonGiao.SelectedItem.ToString(),
                    MaHk = txtHoKhau.Text,
                    QuanHeVoiChuHo = cboQuanHe.SelectedItem.ToString(),
                };

                cDDAO.ThemCongDan(cD);

                string gt = "";
                if (rdoNam.Checked)
                {
                    gt = "m";
                }
                else
                {
                    gt = "f";
                }
                Khaisinh kS = new Khaisinh()
                {
                    MaKs = txtCCCD.Text,
                    Ten = txtTen.Text,
                    GioiTinh = gt,
                    QuocTich = (string)cboQuocTich.SelectedItem,
                    DanToc = (string)cboDanToc.SelectedItem,
                    NgaySinh = dtmNgaySinh.Value,
                    NgayDangKy = dtmDKKhaiSinh.Value,
                    NoiSinh = txtNoiSinh.Text,
                    QueQuan = txtQueQuan.Text,
                    Cccdcha = txtCCCDCha.Text,
                    TenCha = txtTenCha.Text,
                    Cccdme = txtCCCDMe.Text,
                    TenMe = txtTenMe.Text
                };
                kSDAO.ThemKhaSinh(kS);

                Thue thue = new Thue()
                {
                    MaThue = txtThue.Text,
                    Cccd = txtCCCD.Text
                };
                thueDAO.ThemThue(thue);

                if (cboTinhTrang.SelectedItem.ToString() == "Kết hôn")
                {
                    Honnhan hN = new Honnhan()
                    {
                        MaHonNhan = txtMaHonNhan.Text,
                        Cccdnam = txtCCCD.Text,
                        TenNam = txtTen.Text,
                        Cccdnu = txtCCCDVoChong.Text,
                        TenNu = txtTenVoChong.Text,
                        NoiDangKy = "",
                        NgayDangKy = DateTime.Now,
                    };
                    if (rdoNam.ToString() == "False")
                    {
                        hN.TenNam = txtTenVoChong.Text;
                        hN.Cccdnam = txtCCCDVoChong.Text;
                        hN.TenNu = txtTen.Text;
                        hN.Cccdnu = txtCCCD.Text;
                    }
                    hNDAO.ThemHonNhan(hN);
                }
                if (ptcHinhDaiDien.Image != null) 
                    hinhCongDan.SaveHinhDaiDien(txtCCCD.Text, ofdHinhDaiDien, ptcHinhDaiDien);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
            dtmDKKhaiSinh.Value = DateTime.Now;
            dtmNgaySinh.Value = DateTime.Now;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            ThemCongDan();
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text))
            {
                txtCCCD.Focus();
                MessageBox.Show("CCCD không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                txtTen.Focus();
                MessageBox.Show("Họ và tên không hợp lệ");
                return false;
            }
            if (cboQuocTich.SelectedItem == null)
            {
                cboQuocTich.Focus();
                MessageBox.Show("Vui lòng chọn quốc tịch");
                return false;

            }
            if (cboDanToc.SelectedItem == null)
            {
                cboDanToc.Focus();
                MessageBox.Show("Vui lòng chọn dân tộc");
                return false;

            }
            if (cboTonGiao.SelectedItem == null)
            {
                cboTonGiao.Focus();
                MessageBox.Show("Vui lòng chọn tôn giáo");
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                txtQueQuan.Focus();
                MessageBox.Show("Vui lòng kiểm tra lại quê quán");
                return false;
            }
            if (!KiemTraDuLieuNhap.isSoDT(txtSoDT.Text))
            {
                txtSoDT.Focus();
                MessageBox.Show("Vui lòng nhập số đt đúng định dạng");
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text))
            {
                txtDiaChi.Focus();
                MessageBox.Show("Vui lòng kiểm tra lại địa chỉ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtNoiSinh.Text))
            {
                txtNoiSinh.Focus();
                MessageBox.Show("Vui lòng kiểm tra lại nơi sinh");
                return false;
            }
            if (txtNgheNghiep.Text == "")
            {
                txtNgheNghiep.Focus();
                MessageBox.Show("Vui lòng nhập nghề nghiệp");
                return false;
            }
            if (!KiemTraDuLieuNhap.isMaSo(txtThue.Text))
            {
                txtThue.Focus();
                MessageBox.Show("Mã thuế không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenCha.Text))
            {
                txtTenCha.Focus();
                MessageBox.Show("Tên cha không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCDCha.Text))
            {
                txtCCCDCha.Focus();
                MessageBox.Show("CCCD cha không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenMe.Text))
            {
                txtTenCha.Focus();
                MessageBox.Show("Tên mẹ không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCDMe.Text))
            {
                txtCCCDCha.Focus();
                MessageBox.Show("CCCD mẹ không hợp lệ");
                return false;
            }
            if (cboTinhTrang.SelectedItem == null)
            {
                cboTinhTrang.Focus();
                MessageBox.Show("Vui lòng chọn tình trạng hôn nhân");
                return false;
            }
            if (cboTinhTrang.SelectedItem.ToString() == "Hôn nhân")
            {
                if (!KiemTraDuLieuNhap.isTen(txtTenVoChong.Text))
                {
                    txtTenVoChong.Focus();
                    MessageBox.Show("Vui lòng nhập tên vợ/chồng");
                    return false;
                }
                if (!KiemTraDuLieuNhap.isCCCD(txtCCCDVoChong.Text))
                {
                    txtCCCDVoChong.Focus();
                    MessageBox.Show("Vui lòng nhập CCCD vợ/chồng");
                    return false;
                }
                if (!KiemTraDuLieuNhap.isMaSo(txtMaHonNhan.Text))
                {
                    txtMaHonNhan.Focus();
                    MessageBox.Show("Vui lòng nhập mã đăng ký hôn nhân");
                    return false;
                }
            }
            if (!KiemTraDuLieuNhap.isMaSo(txtHoKhau.Text))
            {
                txtHoKhau.Focus();
                MessageBox.Show("Vui lòng nhập mã hộ khẩu hoặc tạo mới");
                return false;
            }    
            if (cboQuanHe.SelectedItem == null)
            {
                cboQuanHe.Focus();
                MessageBox.Show("Vui lòng chọn mối quan hệ");
                return false;
            }    
            if (ptcHinhDaiDien.Image == null)
            {
                MessageBox.Show("Vui lòng thêm ảnh đại diện");
                return false;
            }
            return true;
        }    

        private void cboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTinhTrang.SelectedItem.ToString() == "Kết hôn")
            {
                txtTenVoChong.ReadOnly = false;
                txtMaHonNhan.ReadOnly = false;
                txtCCCDVoChong.ReadOnly = false;
                txtCCCDVoChong.BackColor = Color.Gainsboro;
                txtMaHonNhan.BackColor = Color.Gainsboro;
                txtTenVoChong.BackColor = Color.Gainsboro;
            } 
            else
            {
                txtTenVoChong.ReadOnly = true;
                txtMaHonNhan.ReadOnly = true;
                txtCCCDVoChong.ReadOnly = true;
                txtCCCDVoChong.BackColor = Color.WhiteSmoke;
                txtMaHonNhan.BackColor = Color.WhiteSmoke;
                txtTenVoChong.BackColor = Color.WhiteSmoke;
            }    
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            hinhCongDan.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien);
        }

        
    }
}
