using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FTachGopHo : Form
    {
        private CongDanDAO? cDDAO;
        private HoKhauDAO? hKDAO;
        private bool isTach = false;
        private string cCCD;
        public void init()
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
            hKDAO = new HoKhauDAO();
            StackForm.Add(this);
        }

        public FTachGopHo()
        {
            init();
        }
        public FTachGopHo(string maHoTach)
        {
            init();
            txtMaHoTach.Text = maHoTach;
            LoadHoTach();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gvHoTach.CurrentCell.RowIndex;


                if (index >= 0 && gvHoTach.Rows[index].Cells[0] != null)
                {
                    string tmp = (string)gvHoTach.Rows[index].Cells[0].Value;
                    if (KiemTraDuLieuNhap.isCCCD(tmp))
                    {
                        cCCD = tmp;
                        isTach = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không tồn tại hộ này");
            }
        }


        private bool TaoHoMoi()
        {
            //Kiểm tra 
            Hokhau hK = new Hokhau()
            {
                MaHk = txtMaHoGop.Text,
                DiaChi = "unknow, unknow, unknow,uknow",
                CccdchuHo = cCCD,
            };

            if (hKDAO.ThemHoKhau(hK))
            {
                Congdan? cD = cDDAO.LayThongTin(cCCD);

                cD.QuanHeVoiChuHo = "Chủ hộ";
                cD.MaHk = txtMaHoGop.Text;

                cDDAO?.ThayDoiHoKhau(cD);

                LoadHoTach();
                LoadHoGop();
                XoaHoThua();
                return true;
            }   
            return false;
        }

        private void btnTaoHoMoi_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap.KiemTraHaiHo(txtMaHoGop.Text, txtMaHoTach.Text) && isTach == true && TaoHoMoi())
            {
                MessageBox.Show("Tạo hộ mới thành công");
            }
            else
            {
                MessageBox.Show("Tạo hộ mới thất bại");
            }

            isTach = false;
        }

        //Thực hiện xóa hộ nếu không còn thành viên
        private void XoaHoThua()
        { 
            Hokhau? hK = hKDAO?.LayThongTin(txtMaHoTach.Text);
            if (hK != null && gvHoTach.Rows.Count == 0)
            {
                hKDAO?.XoaHoKhau(hK);
            }
        }
        public bool ThemVaoHo()
        {
            if (hKDAO.LayThongTin(txtMaHoGop.Text) == null)
                return false;
            if (cDDAO?.NhapHoKhau(cCCD, txtMaHoGop.Text) == false)
                return false;

            LoadHoTach();
            LoadHoGop();
            XoaHoThua();

            return true;
        }
        private void btnGopHo_Click(object sender, EventArgs e)
        {   
            if (KiemTraDuLieuNhap.KiemTraHaiHo(txtMaHoGop.Text, txtMaHoTach.Text) && isTach == true && ThemVaoHo())
            {

                MessageBox.Show("Gộp thành viên thành công");
            }
            else
            {
                MessageBox.Show("Gộp thất bại");
            }

            isTach = false;
        }

        private void LoadHoTach()
        {
             gvHoTach.DataSource = cDDAO?.LayDanhSachTheoHoKhau(txtMaHoTach.Text);
             HeaderTach();
        }

        private void LoadHoGop()
        {
            gvHoGop.DataSource = cDDAO?.LayDanhSachTheoHoKhau(txtMaHoGop.Text);
            HeaderGop();
        }

        //Hổ trợ hiển thị tên cột có dấu
        private List<string> HeaderText = new List<string>()
            { "CCCD", "Tên", "Nghề nghiệp", "SĐT", "Tôn giáo", "Mã hộ khẩu", "Quan hệ với chủ hộ" };

        private void HeaderTach()
        {

            for (int i = 0; i < gvHoTach.Columns.Count - 2; i++) 
            {
                gvHoTach.Columns[i].HeaderText = HeaderText[i];
            }
            for (int i = gvHoTach.Columns.Count - 2; i < gvHoTach.Columns.Count; i++)
            {
                gvHoTach.Columns[i].Visible = false;
            }
        }
        private void HeaderGop()
        {

            for (int i = 0; i < gvHoGop.Columns.Count - 2; i++)
            {
                gvHoGop.Columns[i].HeaderText = HeaderText[i];
            }
            for (int i = gvHoGop.Columns.Count - 2; i < gvHoGop.Columns.Count; i++)
            {
                gvHoGop.Columns[i].Visible = false;
            }
        }
        private void btnMaHoTach_Click(object sender, EventArgs e)
        { 
            if (txtMaHoTach.Text != "")
                LoadHoTach();
        }

        private void btnMaHoGop_Click(object sender, EventArgs e)
        {
            if (txtMaHoGop.Text != "")
                LoadHoGop();
        }
        private void Reset()
        {
            txtMaHoGop.Text = "";
            txtMaHoTach.Text = "";
            isTach = false;
            LoadHoTach();
            LoadHoGop();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
