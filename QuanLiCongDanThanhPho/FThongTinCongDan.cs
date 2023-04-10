using QuanLiCongDanThanhPho.Model;
using QuanLiCongDanThanhPho.Models;
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
        private string maCCCD;
        CongDanDAO cdDAO;
        KhaiSinhDAO ksDAO;
        ThueDAO thueDAO;
        HonNhanDAO hnDAO;
        HoKhauDAO hkDAO;
        TamTruTamVangDAO tttvDAO;

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        
        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }
 
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        public FThongTinCongDan()
        {
            InitializeComponent();
        }

        public FThongTinCongDan(string maCCCD)
        {
            InitializeComponent();
            MaCCCD = maCCCD;
            StackForm.Add(this);
            cdDAO = new CongDanDAO();
            ksDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hkDAO = new HoKhauDAO();
            hnDAO = new HonNhanDAO();
            tttvDAO = new TamTruTamVangDAO();
        }
        
        //Mở F khai sinh
        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FThongTinKhaiSinh tTKS = new FThongTinKhaiSinh(MaCCCD);
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
            if (txtMaHoKhau.Text != "Unknow")
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

        //Lấy ảnh công dân hiện lên picturebox
        private void LayCongDan()
        {
            Congdan cd = cdDAO.LayThongTin(MaCCCD);
            txtCCCD.Text = cd.Cccd;
            txtHoVaTen.Text = cd.Ten;
            txtMaHoKhau.Text = cd.MaHk;
            txtSDT.Text = cd.Sdt;
            txtTonGiao.Text = cd.TonGiao;
            txtNgheNghiep.Text = cd.NgheNghiep;
            txtQuanHeVoiChuHo.Text = cd.QuanHeVoiChuHo;
        }

        private void LayKhaiSinh()
        {
            Khaisinh ks = ksDAO.LayThongTin(MaCCCD);
            dtmNgaySinh.Value = ks.NgaySinh;
            if (ks.GioiTinh == "f")  // "f" là giới tính nữ, "m" là nam
                txtGioiTinh.Text = "Nữ";
            else
                txtGioiTinh.Text = "Nam";
            txtDanToc.Text = ks.DanToc;
            txtQuocTich.Text = ks.QuocTich;
            txtQueQuan.Text = ks.QueQuan;
        }

        private void LayThue()
        {
            Model.Thue thue = thueDAO.LayThongTin(MaCCCD);
            if (thue.MaThue == null || thue.MaThue == "")
                btnThue.Enabled = false;
            txtMaThue.Text = thue.MaThue;
        }

        private void LayHonNhan()
        {
            Honnhan hn = new Honnhan();
            hn = hnDAO.LayThongTin(MaCCCD);
            if (!hnDAO.KiemTraHonNhan(MaCCCD))
            {
                txtHonNhan.Text = "Chưa có hôn nhân";
                btnHonNhan.Enabled = false;
            }
            else
                txtHonNhan.Text = hn.MaHonNhan;
        }

        private void LayHoKhau()
        {
            Congdan cd = cdDAO.LayThongTin(MaCCCD);
            Hokhau hk = hkDAO.LayThongTin(cd.MaHk);
            txtDiaChi.Text = hk.DiaChi;
        }

        private void LayTamTruTamVang()
        {
           Tamtrutamvang tttv = new Tamtrutamvang();
            if (!tttvDAO.KiemTraTamTruTamVang(MaCCCD))
                txtGhiChu.Text = "Không có ghi chú";
            else
            {
                tttv = tttvDAO.LayThongTin(MaCCCD);
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
            if (maCCCD != null)
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
        private void FThongTinCongDan_Load(object sender, EventArgs e)
        {
                LayThongTinCongDan();
        }


        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            Congdan cd = cdDAO.LayThongTin(maCCCD);
            FThongTinHoKhau tTHK = new FThongTinHoKhau(cd.MaHk);
            tTHK.ShowDialog();
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            FThongTinThue tTThue = new FThongTinThue(MaCCCD);
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
            FThongTinHonNhan tTHN = new FThongTinHonNhan(MaCCCD);
            tTHN.ShowDialog();
        }

        private void CapNhatKhaiSinh()
        {
            Khaisinh khaiSinh = ksDAO.LayThongTin(MaCCCD);
            khaiSinh.Ten = txtHoVaTen.Text;
            khaiSinh.QueQuan = txtQueQuan.Text;
            khaiSinh.NgaySinh = dtmNgaySinh.Value;
            khaiSinh.DanToc = txtDanToc.Text;
            khaiSinh.QuocTich = txtQuocTich.Text;
            khaiSinh.GioiTinh = txtGioiTinh.Text;
            ksDAO.CapNhatKhaiSinh(khaiSinh);  
        }    

        private void CapNhatCongDan()
        {
            Congdan cd = cdDAO.LayThongTin(MaCCCD);
            cd.Ten = txtHoVaTen.Text;
            cd.Sdt = txtSDT.Text;
            cd.NgheNghiep = txtNgheNghiep.Text;
            cd.TonGiao = txtTonGiao.Text;
            cd.QuanHeVoiChuHo = txtQuanHeVoiChuHo.Text;
            cdDAO.CapNhatCongDan(cd);

        }

        //Thay đổi chủ hộ ở table hộ khẩu nếu có
        private void CapNhatHoKhau()
        {
            if (txtQuanHeVoiChuHo.Text == "Chủ hộ")
            {
                HoKhauDAO hKDAO = new HoKhauDAO();
                Hokhau hoKhau = hKDAO.LayThongTin(txtMaHoKhau.Text);
                if (hoKhau.CccdchuHo != txtCCCD.Text)
                {
                    Congdan cD = cdDAO.LayThongTin(hoKhau.CccdchuHo);
                    cD.QuanHeVoiChuHo = "Unknow";
                    cdDAO.CapNhatCongDan(cD);
                    hoKhau.CccdchuHo = txtCCCD.Text;
                    hKDAO.CapNhatHoKhau(hoKhau);
                }    
            }    
        }
        private void btnSua_Click(object sender, EventArgs e)
        {  
            AutoReadOnly();
        }

        private void CapNhatHonNhan()
        {
            if (txtHonNhan.Text != "Chưa có hôn nhân" && txtHonNhan.Text != "")
            {
                Honnhan hn = hnDAO.LayThongTin(MaCCCD);
                if (txtCCCD.Text == hn.Cccdnam)
                    hn.TenNam = txtHoVaTen.Text;  
                else
                    hn.TenNu = txtHoVaTen.Text;
                hnDAO.CapNhatHonNhan(hn);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {  
            if (KiemTraThongTin())
            {
                CapNhatCongDan();
                CapNhatKhaiSinh();
                CapNhatHonNhan();
                LayThongTinCongDan();
                CapNhatHoKhau();
                ReadOnly();
            }    
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinCongDan();
            ReadOnly();
        }

        //Xóa file ảnh tồn tại
        public void DeleteDirectory(string folderPath, string fileName)
        {
            string fileNamePng = fileName + ".png";
            string fullPathPng = Path.Combine(folderPath, fileNamePng);

            string fileNameJpg = fileName + ".jpg";
            string fullPathJpg = Path.Combine(folderPath, fileNameJpg);

            if (File.Exists(fullPathPng)) 
            {
                File.Delete(fullPathPng);
            }
            if (File.Exists(fullPathJpg)) 
            {
                File.Delete(fullPathJpg);
            }
            
        }

        private void SaveHinhDaiDien()
        {

            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = string.Format($"{txtCCCD.Text}");
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\HinhCongDan"));
            DeleteDirectory(folderPath, fileName);
            string fullPath;
            if (ofdHinhDaiDien.FileName.Contains(".jpg"))
            {
                fileName += ".jpg";
                fullPath = Path.Combine(folderPath, fileName);
                ptcHinhDaiDien.Image.Save(fullPath, ImageFormat.Jpeg);
            }
            else
            {
                fileName += ".png";
                fullPath = Path.Combine(folderPath, fileName);
                ptcHinhDaiDien.Image.Save(fullPath, ImageFormat.Png);
            }
        }
        private void ThemHinh()
        {
            ofdHinhDaiDien.Filter = "PImage Files (*.jpg, *.png)|*.jpg;*.png";
            try
            {
                if (ofdHinhDaiDien.ShowDialog() == DialogResult.OK)
                {
                    ptcHinhDaiDien.Image = new Bitmap(ofdHinhDaiDien.FileName);
                    SaveHinhDaiDien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được ảnh" + ex);
            }
        }
        private void picCongDan_Click(object sender, EventArgs e)
        {
            ptcHinhDaiDien.Image = null;
            ThemHinh();
        }

        private void btnThongTinCCCD_Click(object sender, EventArgs e)
        {
            FThongTinCCCD thongTinCCCD = new FThongTinCCCD(cdDAO.LayThongTin(maCCCD));
            thongTinCCCD.ShowDialog();
        }
    }
}
