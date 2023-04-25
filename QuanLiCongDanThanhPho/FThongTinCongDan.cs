using QuanLiCongDanThanhPho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCongDan : Form
    {
        CongDanDAO cdDAO;
        KhaiSinhDAO ksDAO;
        ThueDAO thueDAO;
        HonNhanDAO hnDAO;
        HoKhauDAO hkDAO;
        TamTruTamVangDAO tttvDAO;
        CCCDDAO cCCDDAO;

        private string maTamTru = "00000B";
        private string maChuaCoHK = "00000A";
        private string path = @"..\..\..\..\HinhCongDan";

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        Congdan congDan;
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

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
        }
        
        //Mở F khai sinh
        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FThongTinKhaiSinh tTKS = new FThongTinKhaiSinh(congDan.Cccd);
            tTKS.ShowDialog();
        }

        //Chỉ cho phép xem
        private void ReadOnly()
        {
            txtNgheNghiep.ReadOnly = true;
            txtNgheNghiep.BackColor = Color.Gainsboro;
            txtHoVaTen.ReadOnly = true;
            txtHoVaTen.BackColor = Color.Gainsboro;
            txtSDT.ReadOnly= true;
            txtSDT.BackColor = Color.Gainsboro;
            txtTonGiao.ReadOnly= true;
            txtTonGiao.BackColor = Color.Gainsboro;
            btnXacNhan.Enabled = false;
            txtDanToc.ReadOnly = true;
            txtDanToc.BackColor= Color.Gainsboro;
            txtQueQuan.ReadOnly = true;
            txtQueQuan.BackColor = Color.Gainsboro;
            txtQuocTich.ReadOnly = true;
            txtQuocTich.BackColor = Color.Gainsboro;
            txtDiaChi.ReadOnly = true;
            txtDiaChi.BackColor = Color.Gainsboro;
            txtGioiTinh.ReadOnly = true;
            txtGioiTinh.BackColor = Color.Gainsboro;
            txtQuanHeVoiChuHo.ReadOnly = true;
            txtQuanHeVoiChuHo.BackColor = Color.Gainsboro;
            dtmNgaySinh.Enabled = false;
            ptcHinhDaiDien.Enabled = false;
            ptcHinhDaiDien.BackColor = Color.Transparent;
        }

        //Cho phép sửa đổi
        private void UnReadOnLy()
        {
            txtNgheNghiep.ReadOnly = false;
            txtNgheNghiep.BackColor = Color.SteelBlue;
            txtHoVaTen.ReadOnly = false;
            txtHoVaTen.BackColor = Color.SteelBlue;  
            txtSDT.ReadOnly = false;
            txtSDT.BackColor = Color.SteelBlue;
            txtTonGiao.ReadOnly = false;
            txtTonGiao.BackColor = Color.SteelBlue;
            btnXacNhan.Enabled = true;
            txtDanToc.ReadOnly = false;
            txtDanToc.BackColor = Color.SteelBlue;
            txtQueQuan.ReadOnly = false;
            txtQueQuan.BackColor = Color.SteelBlue;
            txtQuocTich.ReadOnly = false;
            txtQuocTich.BackColor = Color.SteelBlue;
            txtDiaChi.ReadOnly = false;
            txtDiaChi.BackColor = Color.SteelBlue;
            txtGioiTinh.ReadOnly = false;
            txtGioiTinh.BackColor = Color.SteelBlue;
            if (txtMaHoKhau.Text != "")
            {
                txtQuanHeVoiChuHo.ReadOnly = false;
                txtQuanHeVoiChuHo.BackColor = Color.SteelBlue;
            }
            dtmNgaySinh.Enabled = true;
            ptcHinhDaiDien.Enabled = true;
            ptcHinhDaiDien.BackColor = Color.SteelBlue;
        }

        //Tự động đổi chế độ
        private void AutoReadOnly()
        {
            if (txtHoVaTen.ReadOnly == true)
            {
                UnReadOnLy();
            }
            else
            {
                ReadOnly();
            }
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
            Khaisinh ks = ksDAO.LayThongTin(congDan.Cccd);
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
            Thue thue = thueDAO.LayThongTin(congDan.Cccd);
            if (thue == null)
                btnThue.Enabled = false;
            else
                txtMaThue.Text = thue.MaThue;
        }

        private void LayHonNhan()
        {
            Honnhan hn = hnDAO.LayThongTin(congDan.Cccd);
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
            Hokhau hk = hkDAO.LayThongTin(congDan.MaHk);
            if (hk != null && isMaHK(hk.MaHk))
            {
                txtDiaChi.Text = hk.DiaChi;
            }
            else
            {
                btnHoKhau.Enabled = false;
            }    
        }

        private void LayTamTruTamVang()
        {
           Tamtrutamvang tttv = tttvDAO.LayThongTin(congDan.Cccd);
            if (tttv == null)
                txtGhiChu.Text = "Không có ghi chú";
            else
            {
                tttv = tttvDAO.LayThongTin(congDan.Cccd);
                txtGhiChu.Text = tttv.TrangThai;
            }
        }

        //Lấy hình công dân từ folder HinhCongDan
        private void LayHinhDaiDien()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\HinhCongDan"));
            string imagePath = string.Format(@$"{folderPath}\{txtCCCD.Text}");
            string png = imagePath + ".png";
            string jpg = imagePath + ".jpg";
            Bitmap bitmap = null;
            if (File.Exists(png))
            { 
                bitmap?.Dispose();
                ptcHinhDaiDien.Image?.Dispose();

                using (Bitmap tempImage = new Bitmap(png, true)) //Giúp k bị lỗi không thể truy cập file đang hoạt động khi xóa
                {
                    bitmap = new Bitmap(tempImage);
                    ptcHinhDaiDien.Image = bitmap;
                }
            }
            else if (File.Exists(jpg))
            {
                bitmap?.Dispose();
                ptcHinhDaiDien.Image?.Dispose();

                using (Bitmap tempImage = new Bitmap(jpg, true))
                {
                    bitmap = new Bitmap(tempImage);
                    ptcHinhDaiDien.Image = bitmap;
                }
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
                LayHinhDaiDien();
            }
        }
        private void TatXemCCCD()
        {
            Cccd cccd = new Cccd()
            {
                MaCccd = congDan.Cccd
            };
            cccd = cCCDDAO.LayThongTin(cccd);
            if (cccd.DacDiem == null)
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
            Congdan cd = cdDAO.LayThongTin(congDan.Cccd);
            if (isMaHK(cd.MaHk))
            {
                FThongTinHoKhau tTHK = new FThongTinHoKhau(cd.MaHk);
                tTHK.ShowDialog();
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
            Khaisinh khaiSinh = ksDAO.LayThongTin(congDan.Cccd);
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
            HoKhauDAO hKDAO = new HoKhauDAO();
            Hokhau hoKhau = hKDAO.LayThongTin(txtMaHoKhau.Text);
            if (txtQuanHeVoiChuHo.Text == "Chủ hộ" && hoKhau.CccdchuHo != txtCCCD.Text)
            {
                Congdan cD = cdDAO.LayThongTin(hoKhau.CccdchuHo);
                cD.QuanHeVoiChuHo = "Unknow";
                hoKhau.CccdchuHo = txtCCCD.Text;
                cdDAO.CapNhatCongDan();
            }
            hoKhau.DiaChi = txtDiaChi.Text;
            hkDAO.CapNhatHoKhau();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {  
            AutoReadOnly();
        }

        private void CapNhatHonNhan()
        {
            if (txtHonNhan.Text != "Chưa có hôn nhân" && txtHonNhan.Text != "")
            {
                Honnhan hn = hnDAO.LayThongTin(congDan.Cccd);
                if (hn.TenNam != txtHoVaTen.Text && hn.TenNu != txtHoVaTen.Text)
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
                ReadOnly();
            }    
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinCongDan();
            ReadOnly();
        }

        private void ThemHinh()
        {
            if (HinhDaiDien.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien))
            {
                HinhDaiDien.SaveHinhDaiDien(txtCCCD.Text, ofdHinhDaiDien, ptcHinhDaiDien, path);
            }
        }
        private void picCongDan_Click(object sender, EventArgs e)
        {
            ptcHinhDaiDien.Image = null;
            ThemHinh();
        }

        private void btnThongTinCCCD_Click(object sender, EventArgs e)
        {
            FThongTinCCCD thongTinCCCD = new FThongTinCCCD(cdDAO.LayThongTin(congDan.Cccd));
            thongTinCCCD.ShowDialog();
        }
    }
}
