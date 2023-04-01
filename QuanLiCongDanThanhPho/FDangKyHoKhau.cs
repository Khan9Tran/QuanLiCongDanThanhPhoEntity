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
    public partial class FDangKyHoKhau : Form
    {
        private Form currentChildForm;
        private string maHoTach;
        public FDangKyHoKhau()
        {
            InitializeComponent();
            StackForm.Add(this);
        }
        public FDangKyHoKhau(string maHoTach)
        {
            InitializeComponent();
            StackForm.Add(this);
            this.maHoTach = maHoTach;
            OpenChildForm(new FTachGopHo(maHoTach));
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor = Color.WhiteSmoke;
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
            pnlLuaChon.Controls.Add(childForm);
            pnlLuaChon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnTachGop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTachGopHo());
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor = Color.WhiteSmoke;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThemNguoiVaoHo());
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
