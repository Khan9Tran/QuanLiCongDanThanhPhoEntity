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

        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLuaChon.SelectedItem == "Công dân")
                OpenChildForm(new FDanhSachCongDan());
            else if (cmbLuaChon.SelectedItem == "Thuế")
                OpenChildForm(new FDanhSachThue());
            else if (cmbLuaChon.SelectedItem == "Tạm Trú/Tạm Vắng")
                OpenChildForm(new FDanhSachTamTruTamVang());
            else if (cmbLuaChon.SelectedItem == "Hộ khẩu")
                OpenChildForm(new FDanhSachHoKhau());

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
    }
}
