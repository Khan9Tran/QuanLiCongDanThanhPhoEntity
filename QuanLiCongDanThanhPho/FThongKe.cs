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
        private OpenChildForm childForm;

        public FThongKe()
        {
            InitializeComponent();
            StackForm.Add(this);
            childForm = new OpenChildForm(pnlHienThiThongKe);
        }

        public OpenChildForm ChildForm { get => childForm; set => childForm = value; }

        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLuaChon.SelectedItem.ToString() == "Công dân")
                childForm.Open(new FThongKeCongDan());
            else if (cmbLuaChon.SelectedItem.ToString() == "Phân bố dân cư")
                childForm.Open(new FThongKePhanBo());
            else if (cmbLuaChon.SelectedItem.ToString() == "Thuế")
                childForm.Open(new FThongKeThue());
        }
    }
}
