using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FXinPhepTTTV : Form
    {
        Congdan? congdan;
        CongDanDAO congDanDAO;
        TamTruTamVangDAO tTTVDAO;
        public FXinPhepTTTV(Account account)
        {
            InitializeComponent();
            congDanDAO = new CongDanDAO();
            tTTVDAO = new TamTruTamVangDAO();
            congdan = congDanDAO.LayThongTin(account.UserName);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            XinPhep();
        }

        //Trả về trạng thái xin TT hoặc xin TV
        private string TrangThai()
        {
            if (rdoTamTru.Checked == true)
            {
                return "CDTT";
            }
            if (rdoTamVang.Checked == true)
            {
                return "CDTV";
            }
            else
            {
                return "";
            }
        }
        private void XinPhep()
        {
            //Bắt lỗi nhập ngày
            try
            {
                int Ngay = int.Parse(txtDay.Text);
                if (Ngay <= 0) 
                {
                    MessageBox.Show("Ngày nhập phải lớn hơn 0");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập ngày là số nguyên dương");
                return;
            }

            //Tạo đối tượng TTTV
            Tamtrutamvang tTTV = new Tamtrutamvang()
            {
                TrangThai = TrangThai(),
                MaTttv = congdan.Cccd,
                Cccd = congdan.Cccd,
                LiDo = txtLiDo.Text,
                DiaChi = txtDiaChi.Text,
                NgayBd = DateTime.Now,
                NgayKt = DateTime.Now.AddDays(int.Parse(txtDay.Text))
            };

            if (KiemTraDuLieuNhap.isTamTruTamVang(tTTV) && tTTVDAO.ThemTamTruTamVang(tTTV))
            {
                MessageBox.Show("Vui lòng chờ duyệt");
            }    
            else
            {
                MessageBox.Show("Yêu cầu thất bại");
            }    
        }

    }
}
