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
using QuanLiCongDanThanhPho.Model;
namespace QuanLiCongDanThanhPho
{
    public partial class FThemNguoiVaoHo : Form
    {
        private CongDanDAO cDDAO;
        public FThemNguoiVaoHo()
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
            lblThongTin.Hide();
            gvNguoiChuaCoHoKhau.Hide();
            StackForm.Add(this);
        }
        private void LoadDanhSachChuaHoKhau()
        {
            gvNguoiChuaCoHoKhau.DataSource = cDDAO.LayDanhSachTheoHoKhau("00000A");
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            lblThongTin.Show();
            gvNguoiChuaCoHoKhau.Show();
            LoadDanhSachChuaHoKhau();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Congdan congDan = new Congdan() 
            {
                Cccd = txtCCCD.Text,
                Ten = txtTen.Text,
                MaHk = txtMaHo.Text,
                QuanHeVoiChuHo = txtQuanHeVoiChuHo.Text
            };
            CongDanDAO cDDAO = new CongDanDAO();
            cDDAO.ThayDoiHoKhau(congDan);
            LoadDanhSachChuaHoKhau();
        }

        private void gvNguoiChuaCoHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtCCCD.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[1].Value.ToString();
        }
        private void Reset()
        {
            txtCCCD.Text = "";
            txtTen.Text = "";
            txtMaHo.Text = "";
            txtQuanHeVoiChuHo.Text = "";
            gvNguoiChuaCoHoKhau.Hide();
            lblThongTin.Hide();
            LoadDanhSachChuaHoKhau();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
