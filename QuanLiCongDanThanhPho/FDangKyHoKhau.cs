namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyHoKhau : Form
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }
    }
}
