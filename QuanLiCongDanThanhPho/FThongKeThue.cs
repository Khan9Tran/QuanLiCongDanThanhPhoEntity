namespace QuanLiCongDanThanhPho
{
    public partial class FThongKeThue : Form
    {
        private ThueDAO thueDAO;
        public FThongKeThue()
        {
            InitializeComponent();
            StackForm.Add(this);
            thueDAO = new ThueDAO();
        }
        private string donVi()
        {
            return " VNĐ";
        }
        private void FThongKeThue_Load(object sender, EventArgs e)
        {
            int[] thues = thueDAO.LayThongKeThue();
            int soNguoiTreHan = thueDAO.LaySoNguoiTreHan();
            lblTongTienThue.Text += " " + thues[2].ToString() + donVi();
            lblTongThueCanDong.Text += " " +thues[1].ToString() + donVi();
            lblTongThueDaDong.Text += " " + thues[0].ToString() + donVi();
            lblTrungBinhThue.Text += " " +(((int)(thues[2] / thues[3])).ToString()) + donVi();
            lblSoNguoiTreHan.Text += " " + soNguoiTreHan.ToString();
        }
    }
}
