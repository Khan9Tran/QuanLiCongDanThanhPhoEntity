namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyHoKhau : FormDangKy
    {
        private OpenChildForm childForm;
        private string maHoTach;

        public OpenChildForm ChildForm { get => childForm; set => childForm = value; }
        //Hàm khởi tạo các thành phần của form 
        public FDangKyHoKhau()
        {
            InitializeComponent();
            StackForm.Add(this);
            childForm = new OpenChildForm(pnlLuaChon);
        }

        //Mở Form tách gộp hộ, khi form đăng kí được truyền mã hộ tách 
        public FDangKyHoKhau(string maHoTach)
        {
            InitializeComponent();
            StackForm.Add(this);
            childForm = new OpenChildForm(pnlLuaChon);
            this.maHoTach = maHoTach;
            childForm.Open(new FTachGopHo(maHoTach));
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor = Color.WhiteSmoke;
        }

        //Mở form tách gộp hộ
        private void btnTachGop_Click(object sender, EventArgs e)
        {
            childForm.Open(new FTachGopHo());
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor = Color.WhiteSmoke;
        }

        //Mở form thêm người vào hộ có sẵn
        private void btnThem_Click(object sender, EventArgs e)
        {
            childForm.Open(new FThemNguoiVaoHo());
            btnTachGop.BackColor = Color.WhiteSmoke;
            btnThem.BackColor = Color.Gray;
        }
    }
}
