using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Model;
using QuanLiCongDanThanhPho.Models;
using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FTachGopHo : Form
    {
        private CongDanDAO cDDAO;
        private bool isTach = false;
        private Congdan cD;
        public FTachGopHo()
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
            StackForm.Add(this);
        }
        public FTachGopHo(string maHoTach)
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
            StackForm.Add(this);
            txtMaHoTach.Text = maHoTach;
            LoadHoTach();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
                try
                {

                    int index = gvHoTach.CurrentCell.RowIndex;
                    if (index >= 0)
                    {
                        cD = new Congdan()
                        {
                            Cccd = gvHoTach.Rows[index].Cells[0].Value.ToString()
                        };
                        isTach = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                }
        }
        private bool KiemTraThongTin()
        {
            if (txtMaHoTach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hộ cần tách");
                txtMaHoTach.Focus();
                return false;
            }
            if (txtMaHoGop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hộ mới hoặc hộ muốn gộp vào");
                txtMaHoGop.Focus();
                return false;
            }
            return true;

        }

        private void TaoHoMoi()
        {
            //Kiểm tra 
            HoKhauDAO hKDAO = new HoKhauDAO();
            Hokhau hK = new Hokhau()
            {
                MaHk = txtMaHoGop.Text,
                DiaChi = "unknow, unknow, unknow,uknow",
                CccdchuHo = cD.Cccd,
            };
            hKDAO.ThemHoKhau(hK);
            cD.QuanHeVoiChuHo = "Chủ hộ";
            cD.MaHk = txtMaHoGop.Text;
            cDDAO.ThayDoiHoKhau(cD);
            LoadHoTach();
            LoadHoGop();
            XoaHoThua();
        }
        private void btnTaoHoMoi_Click(object sender, EventArgs e)
        { 
            if (KiemTraThongTin())
                if (isTach == true)
                {
                    //Kiểm tra 
                    if (gvHoGop.Rows.Count != 1)
                    {
                        MessageBox.Show("Hộ đã tồn tại");
                    }
                    else if (cD.MaHk == txtMaHoGop.Text)
                    {
                        MessageBox.Show("Đây là một hộ duy nhất!");
                    }
                    else
                    {
                        TaoHoMoi();
                    }
                    isTach = false;
                }
        }

        //Thực hiện xóa hộ nếu không còn thành viên
        private void XoaHoThua()
        {

            HoKhauDAO hKDAO = new HoKhauDAO();
            HoKhau hK = new HoKhau(txtMaHoTach.Text, "unknow, unknow, unknow,uknow", cD.Cccd);
            if (gvHoTach.Rows.Count <=1)
            {
                hKDAO.XoaHoKhau(hK);
            }
        }
        public void ThemVaoHo()
        {
            cD.MaHk = txtMaHoGop.Text;
            cDDAO.NhapHoKhau(cD);   
            LoadHoTach();
            LoadHoGop();
            XoaHoThua();
        }
        private void btnGopHo_Click(object sender, EventArgs e)
        {   
            if (KiemTraThongTin())
                if (isTach == true)
                {
                    if (gvHoGop.Rows.Count <= 1)
                    {
                        MessageBox.Show("Hộ không tồn tại");
                    }
                    else if (cD.MaHk == txtMaHoGop.Text)
                    {
                        MessageBox.Show("Đây là một hộ duy nhất!");
                    }
                    else
                    {
                        ThemVaoHo();
                    }
                    isTach = false;
                }
        }
        private void LoadHoTach()
        {
             gvHoTach.DataSource = cDDAO.LayDanhSachTheoHoKhau(txtMaHoTach.Text);
        }
        private void LoadHoGop()
        {
            gvHoGop.DataSource = cDDAO.LayDanhSachTheoHoKhau(txtMaHoGop.Text);
        }

        private void btnMaHoTach_Click(object sender, EventArgs e)
        {
            LoadHoTach();
        }

        private void btnMaHoGop_Click(object sender, EventArgs e)
        {
            LoadHoGop();
        }
        private void Reset()
        {
            txtMaHoGop.Text = "";
            txtMaHoTach.Text = "";
            isTach = false;
            LoadHoTach();
            LoadHoGop();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
