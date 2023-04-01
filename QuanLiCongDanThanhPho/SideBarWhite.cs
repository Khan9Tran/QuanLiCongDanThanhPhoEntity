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
    public partial class SideBarWhite : UserControl
    {
        public SideBarWhite()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StackForm.Back();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StackForm.ClearAll();
            StackForm.fTrangChu.BringToFront();
        }

        private void SideBarWhite_Load(object sender, EventArgs e)
        {

        }
    }
}
