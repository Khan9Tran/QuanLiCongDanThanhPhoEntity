using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyKhaiSinh : Form
    {
        private CongDanDAO cDDAO;
        private HonNhanDAO hNDAO;
        private KhaiSinhDAO kSDAO;
        public FDangKyKhaiSinh()
        {
            InitializeComponent();
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            hNDAO = new HonNhanDAO();
            kSDAO = new KhaiSinhDAO();
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                txtTen.Focus();
                MessageBox.Show("Tên Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCccd.Text))
            {
                txtCccd.Focus();
                MessageBox.Show("CCCD không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                txtQueQuan.Focus();
                MessageBox.Show("Quê quán Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtNoiSinh.Text))
            {
                txtNoiSinh.Focus();
                MessageBox.Show("Nơi sinh không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenCha.Text))
            {
                txtTenCha.Focus();
                MessageBox.Show("Tên cha Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCccdCha.Text))
            {
                txtCccdCha.Focus();
                MessageBox.Show("CCCD cha không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenMe.Text))
            {
                txtTenMe.Focus();
                MessageBox.Show("Tên mẹ Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCccdMe.Text))
            {
                txtCccdMe.Focus();
                MessageBox.Show("CCCD Me không hợp lệ");
                return false;
            }
            if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Giới tính không hợp lệ");
                return false;
            }
            if (cboQuocTich.SelectedItem == null)
            {
                cboQuocTich.Focus();
                MessageBox.Show("Quốc tịch không hợp lệ");
                return false;
            }
            if (cboDanToc.SelectedItem == null)
            {
                cboDanToc.Focus();
                MessageBox.Show("Dân tộc không hợp lệ");
                return false;
            }
            return true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        { 
            ToolsForControl.ClearTextBox(Controls);
        }

        private bool KiemTraChaMe()
        {
            Honnhan? chong = hNDAO.LayThongTin(txtCccdCha.Text);
            Honnhan? vo = hNDAO.LayThongTin(txtCccdMe.Text);

            if (chong == null || vo == null)
                return false;   
            if (chong.MaHonNhan != vo.MaHonNhan) 
                return false;
            if (txtTenCha.Text != chong.TenNam)
                return false;
            if (txtTenMe.Text  != vo.TenNu)
                return false;
            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                if (KiemTraChaMe())
                {
                    Congdan congDan = new Congdan()
                    {
                        Ten = txtTen.Text,
                        Cccd = txtCccd.Text,
                        MaHk = "00000A"
                    };
                    cDDAO.ThemCongDan(congDan);

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
                        MaKs = txtCccd.Text,
                        Ten = txtTen.Text,
                        GioiTinh = gt,
                        QuocTich = (string)cboQuocTich.SelectedItem,
                        DanToc = (string)cboDanToc.SelectedItem,
                        NgaySinh = dtmNgaySinh.Value,
                        NgayDangKy = dtmNgayDangKy.Value,
                        NoiSinh = txtNoiSinh.Text,
                        QueQuan = txtQueQuan.Text,
                        Cccdcha = txtCccdCha.Text,
                        TenCha = txtTenCha.Text,
                        Cccdme = txtCccdMe.Text,
                        TenMe = txtTenMe.Text,
                    };
                    kSDAO.ThemKhaSinh(kS);
                }
                else
                {
                    MessageBox.Show("Sai thông tin");
                }    
            }
        }


    }
}
