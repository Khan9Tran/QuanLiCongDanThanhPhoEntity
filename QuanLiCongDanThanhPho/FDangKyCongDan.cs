using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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

        private bool ThemHoKhau()
        {
            if (hKDAO.LayThongTin(txtHoKhau.Text) == null)
            {
                Hokhau hK = new Hokhau()
                {
                    MaHk = txtHoKhau.Text,
                    DiaChi = txtDiaChi.Text,
                    CccdchuHo = txtCCCD.Text,
                };
                if (KiemTraDuLieuNhap.KiemTraHoKhau(hK) && cboQuanHe.SelectedItem.ToString() == "Chủ hộ")
                {
                    hKDAO.ThemHoKhau(hK);
                    return true;
                }
                else
                {
                    return false;
                }    
            }
            return true; 
        }

        private void ThemCongDan()
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
                && ptcHinhDaiDien.Image != null && ThemHoKhau() && cDDAO.ThemCongDan(cD) && kSDAO.ThemKhaiSinh(kS))
            {
                hinhCongDan.SaveHinhDaiDien(txtCCCD.Text, ofdHinhDaiDien, ptcHinhDaiDien);

                if (cboTinhTrang.SelectedItem.ToString() == "Kết hôn")
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
                    if (!thueDAO.ThemThue(thue))
                    {
                        MessageBox.Show("Mã số thuế bị trùng. Vui lòng đăng ký thuế sau");
                    }    

                    if (KiemTraDuLieuNhap.KiemTraHonNhan(hN) && hNDAO.ThemHonNhan(hN))
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
