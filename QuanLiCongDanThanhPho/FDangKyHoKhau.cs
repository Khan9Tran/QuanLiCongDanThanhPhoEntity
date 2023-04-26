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
        public OpenChildForm openChildForm;
        private string maHoTach;
        public FDangKyHoKhau()
        {
            InitializeComponent();
            StackForm.Add(this);
            openChildForm = new OpenChildForm(pnlLuaChon);
        }
        public FDangKyHoKhau(string maHoTach)
        {
            InitializeComponent();
            StackForm.Add(this);
            openChildForm = new OpenChildForm(pnlLuaChon);
            this.maHoTach = maHoTach;
            openChildForm.Open(new FTachGopHo(maHoTach));
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor = Color.WhiteSmoke;
        }

        private void btnTachGop_Click(object sender, EventArgs e)
        {
            openChildForm.Open(new FTachGopHo());
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor = Color.WhiteSmoke;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            openChildForm.Open(new FThemNguoiVaoHo());
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
