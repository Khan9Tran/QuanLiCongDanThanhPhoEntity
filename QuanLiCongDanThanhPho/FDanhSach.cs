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
                flpnlPhanLoai.Width = 800;
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
