using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinThue : FormThongTin
    {

        public FThongTinThue(string maCCCD)
        {
            InitializeComponent();
            StackForm.Add(this);

            MaCCCD = maCCCD;
            SetTools();
        }


        internal override void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            {txtSoTienCanNop, txtSoTienDaNop};

            List<Control> listControl = new List<Control>()
            {
                dtmHanNopThue, dtmNgayCapMaSoThue, btnXacNhan
            };
            Tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void LayThongTinThue()
        {
            if (MaCCCD != null)
            {
                Thue? thue = ThueDAO.LayThongTin(MaCCCD);
                Congdan? cd = CDDAO.LayThongTin(MaCCCD);
                if (cd != null)
                {
                    string? maHk = cd.MaHk;
                    if (maHk != null)
                    {
                        Hokhau? hk = HKDAO.LayThongTin(maHk);
                        txtDiaChi.Text = hk.DiaChi;
                    }

                    txtMaSoThue.Text = maHk;
                    txtTen.Text = cd.Ten;
                    txtCCCD.Text = cd.Cccd;
                    txtSdt.Text = cd.Sdt;
                }
                txtSoTienCanNop.Text = thue.SoTienCanNop;
                txtSoTienDaNop.Text = thue.SoTienDaNop;
                if (thue.NgayCap != null)
                    dtmNgayCapMaSoThue.Value = thue.NgayCap.Value;
                if (thue.HanNop != null)
                    dtmHanNopThue.Value = thue.HanNop.Value;
            }
        }
        private void FThongTinThue_Load(object sender, EventArgs e)
        {
            LayThongTinThue();
        }

        private void CapNhatThue()
        {
            Thue? thue = ThueDAO.LayThongTin(MaCCCD);

            if (txtMaSoThue.Text != "" && thue != null && KiemTraDuLieuNhap.isTien(txtSoTienCanNop.Text) && KiemTraDuLieuNhap.isTien(txtSoTienDaNop.Text))
            {
                thue.Cccd = txtCCCD.Text;
                thue.SoTienCanNop = txtSoTienCanNop.Text;
                thue.SoTienDaNop = txtSoTienDaNop.Text;
                thue.NgayCap = dtmNgayCapMaSoThue.Value;
                thue.HanNop = dtmHanNopThue.Value;
                if (KiemTraDuLieuNhap.KiemTraThue(thue))
                {
                    ThueDAO.CapNhatThue();
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            else
            {
                MessageBox.Show("Thông tin nhập sai");
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatThue();
            LayThongTinThue();
            Tool?.TurnOff();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Tool?.AutoReadOnly();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinThue();
            Tool?.TurnOff();
        }
    }
}
