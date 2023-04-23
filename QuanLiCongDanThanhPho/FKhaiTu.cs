using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FKhaiTu : Form
    {
        public FKhaiTu()
        {
            InitializeComponent();
            StackForm.Add(this);
            congDanDAO = new CongDanDAO();
        }
        CongDanDAO congDanDAO;

        private bool KiemTraThongTin()
        {
            Congdan cD = congDanDAO.LayThongTin(txtCCCD.Text);
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text) || cD.Cccd == null)
            {
                MessageBox.Show("CCCD không chính xác");
                txtCCCD.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text) || cD.Ten != txtTen.Text)
            {
                MessageBox.Show("Tên nhập không chính xác");
                txtTen.Focus();
                return false;

            }
            return true;
        }
        private void XoaCongDan()
        {
            Congdan cD = new Congdan()
            {
                Cccd = txtCCCD.Text,
                Ten = txtTen.Text,
            };
            congDanDAO.XoaCongDan(cD);
        }
        private void Reset()
        {
            txtCCCD.Clear();
            txtTen.Clear();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                XoaCongDan();
                Reset();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            Congdan cD = congDanDAO.LayThongTin(txtCCCD.Text);
            if (cD != null)
                txtTen.Text = cD.Ten;
        }
    }
}
