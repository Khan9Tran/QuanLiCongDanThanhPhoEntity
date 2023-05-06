using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyTamTruTamVang : Form
    {
        private TamTruTamVangDAO? tTTVDAO;
        private CongDanDAO? congDanDAO;
        private string? cCCD;

        public FDangKyTamTruTamVang()
        {
            Init();
        }
        public void Init()
        {
            InitializeComponent();
            tTTVDAO = new TamTruTamVangDAO();
            congDanDAO = new CongDanDAO();  
            StackForm.Add(this);
        }
        public FDangKyTamTruTamVang(string cCCD)
        {
            Init();
            this.cCCD = cCCD;
            
        }
        private void LoadThongTin(string cCCD)
        {
            if (cCCD != null)
            {
                Congdan? congDan = congDanDAO?.LayThongTin(cCCD);
                if (congDan != null)
                {
                    txtTen.Text = congDan.Ten;
                    txtCCCD.Text = congDan.Cccd;
                    txtMaSo.Text = congDan.Cccd;
                    rdoTamVang.Checked = true;
                    txtSDT.Text = congDan.Sdt;
                }
            }
        }
        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isMaSo(txtMaSo.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra mã số");
                txtMaSo.Focus();
                return false;
            }    
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại CCCD");
                txtCCCD.Focus(); 
                return false;
            }    
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại họ và tên");
                txtTen.Focus();
                return false;
            }
            if (rdoTamTru.Checked == false && rdoTamVang.Checked == false) 
            {
                MessageBox.Show("Vui lòng chọn tạm trú hoặc tạm vắng");
                return false;
            }
            if (txtLiDo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Lí do");
                return false;
            }    
            if (!KiemTraDuLieuNhap.isSoDT(txtSDT.Text))
            {
                txtSDT.Focus();
                MessageBox.Show("Vui lòng SDT đúng định dạng");
                return false;
            }   
            if (!KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text))
            {
                txtDiaChi.Focus();
                MessageBox.Show("Vui lòng kiểm tra lại địa chỉ");
                return false;
            }  
            return true;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                if (tTTVDAO?.LayThongTin(txtCCCD.Text) == null)
                {
                    string trangThai = "";
                    if (rdoTamTru.Checked == true)
                    {
                        trangThai = "Tạm trú";
                        if (congDanDAO?.LayThongTin(txtCCCD.Text) == null)
                        {
                            Congdan cDTamTru = new Congdan()
                            {
                                Cccd = txtCCCD.Text,
                                Ten = txtTen.Text,
                                Sdt = txtSDT.Text,
                                MaHk = "00000B",
                                QuanHeVoiChuHo = "Tạm trú tại địa phương"
                            };
                            congDanDAO.ThemCongDan(cDTamTru);
                        }
                    }
                    else
                    {
                        trangThai = "Tạm vắng";
                    }

                    Tamtrutamvang tTTV = new Tamtrutamvang()
                    {
                        Cccd = txtCCCD.Text,
                        TrangThai = trangThai,
                        MaTttv = txtMaSo.Text,
                        NgayBd = dtpNgayBatDau.Value,
                        NgayKt = dtpNgayKetThuc.Value,
                        LiDo = txtLiDo.Text,
                        DiaChi = txtDiaChi.Text,
                    };

                    tTTVDAO.ThemTamTruTamVang(tTTV);
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }    
     
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
        }

        private void FDangKyTamTruTamVang_Load(object sender, EventArgs e)
        {
            LoadThongTin(cCCD);
        }
    }
}
