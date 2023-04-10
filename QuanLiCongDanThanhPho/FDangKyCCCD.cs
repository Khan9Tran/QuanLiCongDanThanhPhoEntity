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
    public partial class FDangKyCCCD : Form
    {
        CCCDDAO cCCDDAO;

        public FDangKyCCCD()
        {
            InitializeComponent();
            cCCDDAO = new CCCDDAO();
            StackForm.Add(this);
        }
        
        private void FDangKyCCCD_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
       private bool KiemTraThongTin()
       {
            if (txtCCCD.Text == "")
            {
                MessageBox.Show("CCCD không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                MessageBox.Show("Họ và tên không hợp lệ");
                return false;
            }
            if (txtDDNhanDang.Text== "")
            {
                MessageBox.Show("Đặc điểm nhận dạng không được để trống");
                return false;
            }
            return true;

       }
        private void Reset()
        {
            txtCCCD.Text = "";
            txtDDNhanDang.Text = "";
            txtTen.Text = "";
            dtmNgayCap.Value = DateTime.Now;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            CongDanDAO cDDAO = new CongDanDAO();
            if (KiemTraThongTin())
            { 
                if (cDDAO.LayThongTin(txtCCCD.Text).Ten == txtTen.Text)
                {
                    Cccd cCCD = new Cccd()
                    {
                        MaCccd = txtCCCD.Text,
                        NgayCap = dtmNgayCap.Value,
                        DacDiem = txtDDNhanDang.Text
                    };
                    cCCDDAO.CapNhatCCCD(cCCD);
                }
                else
                {
                    MessageBox.Show("CCCD và Họ tên không khớp");
                }    
                
            }
            LoadDanhSach();
            
        }
        private void LoadDanhSach()
        {
            gvDanhSachChuaCapCCCD.DataSource = cCCDDAO.DanhSachCCCDTheoDacDiem("Unknow");
            Reset();
        }    
        private void gvDanhSachChuaCapCCCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtCCCD.Text = gvDanhSachChuaCapCCCD.Rows[dong].Cells["maCCCD"].Value.ToString();
                txtTen.Text = gvDanhSachChuaCapCCCD.Rows[dong].Cells["Ten"].Value.ToString();
            }
            txtDDNhanDang.Text = "";
            dtmNgayCap.Value = DateTime.Now;
        }
    }
}
