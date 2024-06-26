﻿using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHonNhan : FormThongTin
    {

        public FThongTinHonNhan(string maCCCD)
        {
            MaCCCD = maCCCD;

            InitializeComponent();
            SetTools();
        }
        private void btnThongTinChong_Click(object sender, EventArgs e)
        {
            Congdan? chong = CDDAO.LayThongTin(txtCCCDChong.Text);
            if (chong != null)
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(chong);
                tTCD.ShowDialog();
            }
        }

        private void btnThongTinVo_Click(object sender, EventArgs e)
        {
            Congdan? vo = CDDAO.LayThongTin(txtCCCDVo.Text);
            if (vo != null)
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(vo);
                tTCD.ShowDialog();
            }
        }
        public void LayThongTinHonNhan()
        {
            if (MaCCCD != null)
            {
                Honnhan? hn = HNDAO.LayThongTin(MaCCCD);
                if (hn != null)
                {
                    txtTenChong.Text = hn.TenNam;
                    txtTenVo.Text = hn.TenNu;
                    txtCCCDChong.Text = hn.Cccdnam;
                    txtCCCDVo.Text = hn.Cccdnu;
                    txtNoiDangKy.Text = hn.NoiDangKy;
                    dtmNgayDangKy.Value = hn.NgayDangKy.Value;
                }
            }
        }
        private void FThongTinHonNhan_Load(object sender, EventArgs e)
        {
            LayThongTinHonNhan();
        }

        internal override void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            { txtNoiDangKy};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgayDangKy
            };

            Tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Tool?.AutoReadOnly();
        }

        public void CapNhatHonNhan()
        {
            Honnhan? hN = HNDAO.LayThongTin(MaCCCD);
            if (hN != null)
            {
                hN.NoiDangKy = txtNoiDangKy.Text;
                hN.NgayDangKy = dtmNgayDangKy.Value;

                if (KiemTraDuLieuNhap.KiemTraHonNhan(hN))
                {
                    HNDAO.CapNhatHonNhan();
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHonNhan();
            Tool?.TurnOff();
            LayThongTinHonNhan();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHonNhan();
        }
    }
}
