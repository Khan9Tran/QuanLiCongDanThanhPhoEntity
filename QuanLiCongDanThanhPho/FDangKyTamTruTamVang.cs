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

        private bool TaoCongDan(Congdan congdan)
        {
            if (congdan != null) 
            {
                return true;
            }
            Congdan cDTamTru = new Congdan()
            {
                Cccd = txtCCCD.Text,
                Ten = txtTen.Text,
                Sdt = txtSDT.Text,
                MaHk = "00000B",
                QuanHeVoiChuHo = "Tạm trú tại địa phương"
            };
            if (KiemTraDuLieuNhap.KiemTraTenVaCCCD(cDTamTru))
            {
                congDanDAO?.ThemCongDan(cDTamTru);
                return true;
            }
            else
                return false;
        }

        private string TamTru()
        {
            return "Tạm trú";
        }

        private string TamVang()
        {
            return "Tạm vắng";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Tamtrutamvang tTTV = new Tamtrutamvang()
            {
                Cccd = txtCCCD.Text,
                MaTttv = txtMaSo.Text,
                NgayBd = dtpNgayBatDau.Value,
                NgayKt = dtpNgayKetThuc.Value,
                LiDo = txtLiDo.Text,
                DiaChi = txtDiaChi.Text,
            };

            Congdan? congdan = congDanDAO?.LayThongTin(txtCCCD.Text);
            if (rdoTamVang.Checked == true && congdan == null)
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }   
            else if (rdoTamTru.Checked == true)
            {
                tTTV.TrangThai = TamTru();
            }
            else if (rdoTamVang.Checked == true)
            {
                tTTV.TrangThai = TamVang();
            }
            if (KiemTraDuLieuNhap.isTamTruTamVang(tTTV) && KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text) && TaoCongDan(congdan) && tTTVDAO.ThemTamTruTamVang(tTTV))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }    
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
        }

        private void FDangKyTamTruTamVang_Load(object sender, EventArgs e)
        {
            if (cCCD != null)
                LoadThongTin(cCCD);
        }
    }
}
