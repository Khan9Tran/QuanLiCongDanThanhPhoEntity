using QuanLiCongDanThanhPho.Models;
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
    public partial class FDangKyThue : Form
    {
        public FDangKyThue()
        {
            InitializeComponent();
            StackForm.Add(this);
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
        private void FDangKyThue_Load(object sender, EventArgs e)
        {

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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                Thue thue = new Thue(txtMaSoThue.Text, txtCCCD.Text, dtpNgayCapMa.Value, dtpHanNop.Value, txtSoTienCanNop.Text, txtSoTienDaNop.Text);
                ThueDAO congDanNopThue = new ThueDAO();
                congDanNopThue.ThemThue(thue);
            }
        }
    }
}
