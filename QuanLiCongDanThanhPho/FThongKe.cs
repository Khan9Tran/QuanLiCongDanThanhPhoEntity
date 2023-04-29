namespace QuanLiCongDanThanhPho
{
    public partial class FThongKe : Form
    {
        private OpenChildForm childForm;

        public FThongKe()
        {
            InitializeComponent();
            StackForm.Add(this);
            childForm = new OpenChildForm(pnlHienThiThongKe);
        }

        public OpenChildForm ChildForm { get => childForm; set => childForm = value; }
        
        private enum Type {
            congDan,
            thue,
            phanBoDanCu
        };

        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Type)cmbLuaChon.SelectedIndex == Type.congDan)
                childForm.Open(new FThongKeCongDan());
            else if ((Type)cmbLuaChon.SelectedIndex== Type.phanBoDanCu)
                childForm.Open(new FThongKePhanBo());
            else if ((Type)(Type)cmbLuaChon.SelectedIndex == Type.thue)
                childForm.Open(new FThongKeThue());
        }
    }
}
