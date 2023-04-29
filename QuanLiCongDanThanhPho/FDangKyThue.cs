﻿using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyThue : Form
    {
        public FDangKyThue()
        {
            Init();
        }

        public FDangKyThue(string cCCD)
        {
            Init();
            LoadThongTin(cCCD);
            
        }

        public void Init()
        {
            InitializeComponent();
            StackForm.Add(this);
        }

        public void LoadThongTin(string cCCD) 
        {
            if (cCCD != null)
            {
                CongDanDAO congDanDAO = new CongDanDAO();
                Congdan congDan = congDanDAO.LayThongTin(cCCD);
                txtMaSoThue.Text = congDan.Cccd;
                txtCCCD.Text = congDan.Cccd;
                txtSoTienDaNop.Text = "0";
            }
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isMaSo(txtMaSoThue.Text))
            {
                MessageBox.Show("Mã số thuế sai định dạng");
                txtMaSoThue.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text))
            {
                MessageBox.Show("CCCD sai định dạng");
                txtCCCD.Focus();
                return false;
            }
            if (txtSoTienCanNop.Text == "")
            {
                txtSoTienCanNop.Focus();
                MessageBox.Show("Vui lòng nhập số tiền cần nộp");
                return false;
            }
            if (txtSoTienDaNop.Text == "")
            {
                txtSoTienDaNop.Focus();
                MessageBox.Show("Vui lòng nhập số tiền Đã nộp");
                return false;
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
            dtpNgayCapMa.Value = DateTime.Now;
            dtpHanNop.Value = DateTime.Now;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                Thue thue = new Thue()
                {
                    MaThue = txtMaSoThue.Text,
                    Cccd = txtCCCD.Text,
                    NgayCap =dtpNgayCapMa.Value,
                    HanNop = dtpHanNop.Value,
                    SoTienCanNop = txtSoTienCanNop.Text,
                    SoTienDaNop = txtSoTienDaNop.Text
                };
                ThueDAO congDanNopThue = new ThueDAO();
                congDanNopThue.ThemThue(thue);
            }
        }
    }
}
