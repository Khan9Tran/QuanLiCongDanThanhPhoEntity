using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCongDan : FormDangKy
    {
        private HinhDaiDien hinhCongDan;

        public FDangKyCongDan()
        {
            InitializeComponent();
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }

        enum LuaChon
        {
            docThan,
            ketHon,
        }

        //Thêm hộ khẩu mới nếu công dân đăng kí là chủ hộ
        private bool ThemHoKhau()
        {
            if (HKDAO.LayThongTin(txtHoKhau.Text) == null)
            {
                try
                {
                    Hokhau hK = new Hokhau()
                    {
                        MaHk = txtHoKhau.Text,
                        DiaChi = txtDiaChi.Text,
                        CccdchuHo = txtCCCD.Text,
                    };
                    if (KiemTraDuLieuNhap.KiemTraHoKhau(hK) && cboQuanHe.SelectedItem.ToString() == "Chủ hộ" && HKDAO.ThemHoKhau(hK))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Tạo hộ khẩu lỗi");
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn quan hệ với chú hộ");
                    return false;
                }
            }
            return true;
        }

        //Đăng ký thông tin cho công dân bao gồm thông tin cơ bản của về công dân, khai sinh, thuế, hộ khẩu, hôn nhân nếu có
        internal override void DangKy()
        {
            Congdan cD = new Congdan()
            {
                Cccd = txtCCCD.Text,
                Ten = txtTen.Text,
                NgheNghiep = txtNgheNghiep.Text,
                Sdt = txtSoDT.Text,
                TonGiao = (string)cboTonGiao.SelectedItem,
                MaHk = txtHoKhau.Text,
                QuanHeVoiChuHo = (string)cboQuanHe.SelectedItem,
            };

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

            Thue thue = new Thue()
            {
                MaThue = txtThue.Text,
                Cccd = txtCCCD.Text
            };

            if (KiemTraDuLieuNhap.KiemTraCongDan(cD) && KiemTraDuLieuNhap.KiemTraKhaiSinh(kS) && KiemTraDuLieuNhap.KiemTraThueDonGian(thue)
                && KiemTraDuLieuNhap.isHinh(ptcHinhDaiDien) && ThemHoKhau() && CDDAO.ThemCongDan(cD) && KSDAO.ThemKhaiSinh(kS))
            {
                hinhCongDan.SaveHinhDaiDien(txtCCCD.Text, ofdHinhDaiDien, ptcHinhDaiDien);

                if (!ThueDAO.ThemThue(thue))
                {
                    MessageBox.Show("Mã số thuế bị trùng. Vui lòng đăng ký thuế sau");
                }

                if (cboTinhTrang.SelectedIndex == (int)LuaChon.ketHon)
                {
                    Honnhan hN = new Honnhan()
                    {
                        MaHonNhan = txtMaHonNhan.Text,
                        Cccdnam = txtCCCD.Text,
                        TenNam = txtTen.Text,
                        Cccdnu = txtCCCDVoChong.Text,
                        TenNu = txtTenVoChong.Text,
                        NoiDangKy = "unknow, unknow, unknow, unkow",
                        NgayDangKy = DateTime.Now,
                    };
                    if (gt == "f")
                    {
                        hN.TenNam = txtTenVoChong.Text;
                        hN.Cccdnam = txtCCCDVoChong.Text;
                        hN.TenNu = txtTen.Text;
                        hN.Cccdnu = txtCCCD.Text;
                    }

                    if (KiemTraDuLieuNhap.KiemTraHonNhan(hN) && HNDAO.ThemHonNhan(hN))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công. Thêm hôn nhân lỗi");
                    }

                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }



        }

        //Clear các TextBox, đặt lại các DateTimePicker
        internal override void Reset()
        {
            base.Reset();
            dtmDKKhaiSinh.Value = DateTime.Now;
            dtmNgaySinh.Value = DateTime.Now;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }

        //Chỉnh lại trạng thái(đọc/ghi) của TextBox theo tình trạng hôn nhân
        private void cboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            List<TextBox> textBoxs = new List<TextBox>() { txtTenVoChong, txtMaHonNhan, txtCCCDVoChong };
            if (cboTinhTrang.SelectedIndex == (int)LuaChon.ketHon)
            {
                ToolsForControl.ReadOnly(textBoxs, false, Color.Gainsboro);
            }
            else
            {
                ToolsForControl.ReadOnly(textBoxs, true, Color.WhiteSmoke);
            }
        }

        //Thêm hình đại diện của công dân
        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            hinhCongDan.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien);
        }


    }
}
