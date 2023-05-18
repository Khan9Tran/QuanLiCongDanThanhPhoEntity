using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCongDan : FormThongTin
    {
        private string maTamTru = "00000B";
        private string maChuaCoHK = "00000A";

        public FThongTinCongDan(Congdan congdan)
        {
            InitializeComponent();
            SetTools();

            CongDan = congdan;
            HinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }

        //Mở F khai sinh
        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FThongTinKhaiSinh tTKS = new FThongTinKhaiSinh(CongDan.Cccd);
            tTKS.ShowDialog();
        }

        internal override void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            { txtNgheNghiep, txtHoVaTen, txtSDT, txtTonGiao, txtDanToc, txtQueQuan,
                txtQuocTich, txtDiaChi, txtGioiTinh, txtQuanHeVoiChuHo};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgaySinh, ptcHinhDaiDien
            };
            Tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        //Lấy ảnh công dân hiện lên picturebox
        private void LayCongDan()
        {
            if (CongDan != null)
            {
                txtCCCD.Text = CongDan.Cccd;
                txtHoVaTen.Text = CongDan.Ten;

                if (isMaHK(CongDan.MaHk))
                    txtMaHoKhau.Text = CongDan.MaHk;

                txtSDT.Text = CongDan.Sdt;
                txtTonGiao.Text = CongDan.TonGiao;
                txtNgheNghiep.Text = CongDan.NgheNghiep;
                txtQuanHeVoiChuHo.Text = CongDan.QuanHeVoiChuHo;
            }
        }

        private void LayKhaiSinh()
        {
            Khaisinh? ks = KSDAO.LayThongTin(CongDan.Cccd);
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
            Thue? thue = ThueDAO.LayThongTin(CongDan.Cccd);
            if (thue == null)
                btnThue.Enabled = false;
            else
                txtMaThue.Text = thue.MaThue;
        }

        private void LayHonNhan()
        {
            Honnhan? hn = HNDAO.LayThongTin(CongDan.Cccd);
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
            if (CongDan.MaHk != null)
            {
                Hokhau? hk = HKDAO.LayThongTin(CongDan.MaHk);
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
            Tamtrutamvang? tttv = TTTVDAO.LayThongTin(CongDan.Cccd);
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
            if (CongDan != null)
            {
                LayCongDan();
                LayKhaiSinh();
                LayThue();
                LayHonNhan();
                LayHoKhau();
                LayTamTruTamVang();
                HinhCongDan.LayHinhDaiDien(txtCCCD.Text, ptcHinhDaiDien);
            }
        }
        private void TatXemCCCD()
        {
            Cccd? cccd = new Cccd()
            {
                MaCccd = CongDan.Cccd
            };

            cccd = CCCDDAO.LayThongTin(cccd);

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
            Congdan? cd = CDDAO.LayThongTin(CongDan.Cccd);
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
            FThongTinThue tTThue = new FThongTinThue(CongDan.Cccd);
            tTThue.ShowDialog();
        }


        private void btnHonNhan_Click(object sender, EventArgs e)
        {
            FThongTinHonNhan tTHN = new FThongTinHonNhan(CongDan.Cccd);
            tTHN.ShowDialog();
        }

        private void CapNhatKhaiSinh()
        {
            Khaisinh? khaiSinh = KSDAO.LayThongTin(CongDan.Cccd);
            if (khaiSinh != null)
            {
                khaiSinh.Ten = txtHoVaTen.Text;
                khaiSinh.QueQuan = txtQueQuan.Text;
                khaiSinh.NgaySinh = dtmNgaySinh.Value;
                khaiSinh.DanToc = txtDanToc.Text;
                khaiSinh.QuocTich = txtQuocTich.Text;
                if (txtGioiTinh.Text == "Nam" || txtGioiTinh.Text == "NAM" || txtGioiTinh.Text == "nam")
                    khaiSinh.GioiTinh = "m";
                else
                    khaiSinh.GioiTinh = "f";
                if (KiemTraDuLieuNhap.isGioiTinh(txtGioiTinh.Text) && KiemTraDuLieuNhap.KiemTraKhaiSinh(khaiSinh))
                    KSDAO.CapNhatKhaiSinh();
            }
        }

        private void CapNhatCongDan()
        {
            CongDan.Ten = txtHoVaTen.Text;
            CongDan.Sdt = txtSDT.Text;
            CongDan.NgheNghiep = txtNgheNghiep.Text;
            CongDan.TonGiao = txtTonGiao.Text;
            CongDan.QuanHeVoiChuHo = txtQuanHeVoiChuHo.Text;
            if (KiemTraDuLieuNhap.KiemTraCongDan(CongDan))
                CDDAO.CapNhatCongDan();
        }

        //Thay đổi chủ hộ ở table hộ khẩu nếu có
        private void CapNhatHoKhau()
        {
            Hokhau? hoKhau = HKDAO.LayThongTin(txtMaHoKhau.Text);
            if (hoKhau != null)
            {
                if (txtQuanHeVoiChuHo.Text == "Chủ hộ" && hoKhau.CccdchuHo != txtCCCD.Text)
                {
                    string? hK = hoKhau.CccdchuHo;
                    if (hK != null)
                    {
                        Congdan? cD = CDDAO.LayThongTin(hK);
                        if (cD != null)
                        {
                            cD.QuanHeVoiChuHo = "Unknow";
                            hoKhau.CccdchuHo = txtCCCD.Text;
                            CDDAO.CapNhatCongDan();
                        }
                    }
                }
                hoKhau.DiaChi = txtDiaChi.Text;
                if (KiemTraDuLieuNhap.KiemTraHoKhau(hoKhau))
                    HKDAO.CapNhatHoKhau();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Tool?.AutoReadOnly();
        }

        private void CapNhatHonNhan()
        {
            if (txtHonNhan.Text != "Chưa có hôn nhân" && txtHonNhan.Text != "")
            {
                Honnhan? hn = HNDAO.LayThongTin(CongDan.Cccd);
                if (hn != null && hn.TenNam != txtHoVaTen.Text && hn.TenNu != txtHoVaTen.Text)
                {
                    if (txtCCCD.Text == hn.Cccdnam)
                        hn.TenNam = txtHoVaTen.Text;
                    else
                        hn.TenNu = txtHoVaTen.Text;
                    if (KiemTraDuLieuNhap.KiemTraHonNhan(hn))
                        HNDAO.CapNhatHonNhan();
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHoKhau();
            CapNhatKhaiSinh();
            CapNhatHonNhan();
            CapNhatCongDan();
            Tool?.AutoReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinCongDan();
            Tool?.AutoReadOnly();
        }

        private void ThemHinh()
        {
            if (HinhCongDan.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien))
            {
                HinhCongDan.SaveHinhDaiDien(txtCCCD.Text, ofdHinhDaiDien, ptcHinhDaiDien);
            }
        }
        private void picCongDan_Click(object sender, EventArgs e)
        {
            ptcHinhDaiDien.Image = null;
            ThemHinh();
        }

        private void btnThongTinCCCD_Click(object sender, EventArgs e)
        {
            Congdan? cD = CDDAO.LayThongTin(CongDan.Cccd);
            if (cD != null)
            {
                FThongTinCCCD thongTinCCCD = new FThongTinCCCD(cD);
                thongTinCCCD.ShowDialog();
            }
        }
    }
}
