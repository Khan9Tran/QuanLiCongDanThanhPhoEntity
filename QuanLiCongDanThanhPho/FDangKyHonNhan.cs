﻿using QuanLiCongDanThanhPho.Models;
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
    public partial class FDangKyHonNhan : Form
    {
        HonNhanDAO hNDAO;
        KhaiSinhDAO ksDAO;
        public FDangKyHonNhan()
        {
            InitializeComponent();
            hNDAO = new HonNhanDAO();
            ksDAO = new KhaiSinhDAO();
            StackForm.Add(this);
        }
        
        //Thêm hôn nhân mới
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCDChong.Text, txtTenChong.Text, txtCCCDVo.Text, txtTenVo.Text, txtNoiDK.Text, dtpNgayDangKy.Value);
                hNDAO.ThemHonNhan(hN);
            }
        }

        //Bật các nút giúp cho phép đăng ký li hôn
        public void ChoPhepLiHon()
        {
            txtCCCDChong.ReadOnly = true;
            txtCCCDVo.ReadOnly = true;
            txtTenChong.ReadOnly = true;
            txtTenVo.ReadOnly = true;
            txtNoiDK.ReadOnly = true;
            dtpNgayDangKy.Enabled = false;
            btnDelete.Enabled = true;
            btnDangKy.Enabled = false;
        }

        //Bật các nút cho phép kết hôn
        public void ChoPhepDangKy()
        {
            txtCCCDChong.ReadOnly = false;
            txtCCCDVo.ReadOnly = false;
            txtTenChong.ReadOnly = false;
            txtTenVo.ReadOnly = false;
            txtNoiDK.ReadOnly = false;
            dtpNgayDangKy.Enabled = true;
            btnDelete.Enabled = false;
            btnDangKy.Enabled = true;
        }

        //Li hôn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCDChong.Text, txtTenChong.Text, txtCCCDVo.Text, txtCCCDChong.Text, txtNoiDK.Text, dtpNgayDangKy.Value);
            hNDAO.Xoa(hN);
            Reset();
        }

        //Đưa form về trạng thái ban đầu
        private void Reset()
        {
            Clear();
            txtMaHonNhan.Clear();
            ChoPhepDangKy();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Kiểm tra hợp lệ của thông tin
        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isMaSo(txtMaHonNhan.Text))
            {
                MessageBox.Show("Mã hôn nhân sai định dạng");
                txtMaHonNhan.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCDChong.Text))
            {
                MessageBox.Show("CCCD chồng sai định dạng");
                txtCCCDChong.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCDVo.Text))
            {
                MessageBox.Show("CCCD vợ sai định dạng");
                txtCCCDVo.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenChong.Text))
            {
                MessageBox.Show("Tên chồng sai định dạng");
                txtTenChong.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenVo.Text))
            {
                MessageBox.Show("Tên vợ sai định dạng");
                txtTenVo.Focus();
                return false;
            }
            if (hNDAO.LayThongTin(txtCCCDChong.Text).TenChong != null)
            {
                MessageBox.Show("Người chồng đã kết hôn");
                return false;
            }
            else if (ksDAO.LayThongTin(txtCCCDChong.Text).GioiTinh == "f")
            {
                MessageBox.Show("Người chồng sai giới tính");
                return false;
            }    
            if (hNDAO.LayThongTin(txtCCCDChong.Text).TenChong != null)
            {
                MessageBox.Show("Người vợ đã kết hôn");
                return false;
            }
            else if (ksDAO.LayThongTin(txtCCCDVo.Text).GioiTinh == "m")
            {
                MessageBox.Show("Người vợ sai giới tính");
                return false;
            }
            return true;

        }

        //Xóa các textbox
        public void Clear()
        {
            txtCCCDChong.Clear();
            txtCCCDVo.Clear();
            txtTenChong.Clear();
            txtTenVo.Clear();
            txtNoiDK.Clear();
            dtpNgayDangKy.Value = DateTime.Now;
        }

        //Tải thông tin hôn nhân lên
        private void LoadHonNhan()
        {
            HonNhan hn = hNDAO.LayThongTinTheoMaSo(txtMaHonNhan.Text);
            txtCCCDChong.Text = hn.CCCDChong;
            txtCCCDVo.Text = hn.CCCDVo;
            txtTenChong.Text = hn.TenChong;
            txtTenVo.Text = hn.TenVo;
            txtNoiDK.Text = hn.NoiDangKy.toString();
            dtpNgayDangKy.Value = hn.NgayDangKy;
            if (hn.CCCDChong != null)
                ChoPhepLiHon();
            else
                ChoPhepDangKy();
        }

        //Tìm kiếm theo mã số
        private void txtMaHonNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHonNhan.Text.Length > 0)
            {
                LoadHonNhan();  
            }

        }

        //Trả về tên hôn nhân thep mã số
        private string LayTenTheoCCCD(string cCCD)
        {
            KhaiSinh ks = ksDAO.LayThongTin(cCCD);
            return ks.HoTen;
        }

        //Tìm kiếm theo CCCD
        private void btnTimChong_Click(object sender, EventArgs e)
        {
            txtTenChong.Text = LayTenTheoCCCD(txtCCCDChong.Text);
        }

        private void btnTimVo_Click(object sender, EventArgs e)
        {
            txtTenVo.Text = LayTenTheoCCCD(txtCCCDVo.Text);
        }
    }
}