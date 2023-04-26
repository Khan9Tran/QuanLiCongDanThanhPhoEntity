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
    public partial class FThongKe : Form
    {
        KhaiSinhDAO ksDAO = new KhaiSinhDAO();
        public OpenChildForm openChildForm;

        public FThongKe()
        {
            InitializeComponent();
            StackForm.Add(this);
            openChildForm = new OpenChildForm(pnlHienThiThongKe);
        }
        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLuaChon.SelectedItem.ToString() == "Công dân")
                openChildForm.Open(new FThongKeCongDan());
            else if (cmbLuaChon.SelectedItem.ToString() == "Phân bố dân cư")
                openChildForm.Open(new FThongKePhanBo());
            else if (cmbLuaChon.SelectedItem.ToString() == "Thuế")
                openChildForm.Open(new FThongKeThue());
        }
    }
}
