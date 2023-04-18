using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSach : Form
    {
        public Form currentChildForm;
        public FDanhSach()
        {
            InitializeComponent();
            StackForm.Add(this);
            FlatStyle();
        }
        private void FlatStyle()
        {
            btnCongDan.FlatAppearance.BorderSize = 0;
            btnHoKhau.FlatAppearance.BorderSize = 0;
            btnThue.FlatAppearance.BorderSize = 0;
            btnTTTV.FlatAppearance.BorderSize = 0;
        }
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlHienThiDanhSach.Controls.Add(childForm);
            pnlHienThiDanhSach.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (flpnlPhanLoai.Width > 50)
                flpnlPhanLoai.Width = 45;
            else
                flpnlPhanLoai.Width = 1600;
        }

        private void FDanhSach_Load(object sender, EventArgs e)
        {
            flpnlPhanLoai.Width = 45;
        }

        private void btnCongDan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachCongDan());
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachThue());
        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachHoKhau());
        }

        private void btnTTTV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachTamTruTamVang());
        }
    }
}
