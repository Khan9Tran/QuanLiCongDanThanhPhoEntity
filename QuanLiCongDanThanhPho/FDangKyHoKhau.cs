namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyHoKhau : FormDangKy
    {
        private OpenChildForm childForm;
        private string maHoTach;

        public OpenChildForm ChildForm { get => childForm; set => childForm = value; }

        public FDangKyHoKhau()
        {
            InitializeComponent();
            StackForm.Add(this);
            childForm = new OpenChildForm(pnlLuaChon);
        }
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

        private void btnTachGop_Click(object sender, EventArgs e)
        {
            childForm.Open(new FTachGopHo());
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor = Color.WhiteSmoke;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            childForm.Open(new FThemNguoiVaoHo());
            btnTachGop.BackColor = Color.WhiteSmoke;
            btnThem.BackColor = Color.Gray;
        }
    }
}
