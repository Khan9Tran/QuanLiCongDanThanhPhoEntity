﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCongDan : Form
    {
        CongDanDAO cdDAO;
        KhaiSinhDAO kSDAO;
        ThueDAO thueDAO;
        HonNhanDAO hNDAO;
        CCCDDAO cCCDDAO;
        public FDangKyCongDan()
        {
            InitializeComponent();
            StackForm.Add(this);
            cdDAO = new CongDanDAO();
            kSDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hNDAO = new HonNhanDAO();
            cCCDDAO = new CCCDDAO();
        }
        public bool isData()
        {
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text))
            {
                MessageBox.Show("Nhập CCCD 12 số");
                txtCCCD.Focus();
                return false;
            }

            return true;
        }    
        public void ThemCongDan()
        {
            if (KiemTraThongTin())
            {
                CongDan cD = new CongDan(txtCCCD.Text, txtTen.Text, txtNgheNghiep.Text, txtSoDT.Text, cboTonGiao.SelectedItem.ToString(), txtHoKhau.Text, cboQuanHe.SelectedItem.ToString(), txtDiaChi.Text);
                cdDAO.ThemCongDan(cD);

                KhaiSinh kS = new KhaiSinh(txtCCCD.Text, txtTen.Text, rdoNam.Checked.ToString(), cboQuocTich.SelectedItem.ToString(), cboDanToc.SelectedItem.ToString(), dtmNgaySinh.Value, dtmDKKhaiSinh.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCCCDCha.Text, txtTenCha.Text, txtCCCDMe.Text, txtTenMe.Text);
                kSDAO.ThemKhaSinh(kS);

                Thue thue = new Thue(txtThue.Text, txtCCCD.Text);
                thueDAO.ThemThue(thue);

                if (cboTinhTrang.SelectedItem.ToString() == "Kết hôn")
                {

                    HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCD.Text, txtTen.Text, txtCCCDVoChong.Text, txtTenVoChong.Text, "", DateTime.Now, rdoNam.ToString());
                    hNDAO.ThemHonNhan(hN);
                }
                if (ptcHinhDaiDien.Image != null) 
                    SaveHinhDaiDien();
            }
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
            ThemCongDan();
        }
        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text))
            {
                txtCCCD.Focus();
                MessageBox.Show("CCCD không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                txtTen.Focus();
                MessageBox.Show("Họ và tên không hợp lệ");
                return false;
            }
            if (cboQuocTich.SelectedItem == null)
            {
                cboQuocTich.Focus();
                MessageBox.Show("Vui lòng chọn quốc tịch");
                return false;

            }
            if (cboDanToc.SelectedItem == null)
            {
                cboDanToc.Focus();
                MessageBox.Show("Vui lòng chọn dân tộc");
                return false;

            }
            if (cboTonGiao.SelectedItem == null)
            {
                cboTonGiao.Focus();
                MessageBox.Show("Vui lòng chọn tôn giáo");
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                txtQueQuan.Focus();
                MessageBox.Show("Vui lòng kiểm tra lại quê quán");
                return false;
            }
            if (!KiemTraDuLieuNhap.isSoDT(txtSoDT.Text))
            {
                txtSoDT.Focus();
                MessageBox.Show("Vui lòng nhập số đt đúng định dạng");
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text))
            {
                txtDiaChi.Focus();
                MessageBox.Show("Vui lòng kiểm tra lại địa chỉ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtNoiSinh.Text))
            {
                txtNoiSinh.Focus();
                MessageBox.Show("Vui lòng kiểm tra lại nơi sinh");
                return false;
            }
            if (txtNgheNghiep.Text == "")
            {
                txtNgheNghiep.Focus();
                MessageBox.Show("Vui lòng nhập nghề nghiệp");
                return false;
            }
            if (!KiemTraDuLieuNhap.isMaSo(txtThue.Text))
            {
                txtThue.Focus();
                MessageBox.Show("Mã thuế không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenCha.Text))
            {
                txtTenCha.Focus();
                MessageBox.Show("Tên cha không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCDCha.Text))
            {
                txtCCCDCha.Focus();
                MessageBox.Show("CCCD cha không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenMe.Text))
            {
                txtTenCha.Focus();
                MessageBox.Show("Tên mẹ không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCDMe.Text))
            {
                txtCCCDCha.Focus();
                MessageBox.Show("CCCD mẹ không hợp lệ");
                return false;
            }
            if (cboTinhTrang.SelectedItem == null)
            {
                cboTinhTrang.Focus();
                MessageBox.Show("Vui lòng chọn tình trạng hôn nhân");
                return false;
            }
            if (cboTinhTrang.SelectedItem.ToString() == "Hôn nhân")
            {
                if (!KiemTraDuLieuNhap.isTen(txtTenVoChong.Text))
                {
                    txtTenVoChong.Focus();
                    MessageBox.Show("Vui lòng nhập tên vợ/chồng");
                    return false;
                }
                if (!KiemTraDuLieuNhap.isCCCD(txtCCCDVoChong.Text))
                {
                    txtCCCDVoChong.Focus();
                    MessageBox.Show("Vui lòng nhập CCCD vợ/chồng");
                    return false;
                }
                if (!KiemTraDuLieuNhap.isMaSo(txtMaHonNhan.Text))
                {
                    txtMaHonNhan.Focus();
                    MessageBox.Show("Vui lòng nhập mã đăng ký hôn nhân");
                    return false;
                }
            }
            if (!KiemTraDuLieuNhap.isMaSo(txtHoKhau.Text))
            {
                txtHoKhau.Focus();
                MessageBox.Show("Vui lòng nhập mã hộ khẩu hoặc tạo mới");
                return false;
            }    
            if (cboQuanHe.SelectedItem == null)
            {
                cboQuanHe.Focus();
                MessageBox.Show("Vui lòng chọn mối quan hệ");
                return false;
            }    
            if (ptcHinhDaiDien.Image == null)
            {
                MessageBox.Show("Vui lòng thêm ảnh đại diện");
                return false;
            }
            return true;
        }    

        private void cboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTinhTrang.SelectedItem.ToString() == "Kết hôn")
            {
                txtTenVoChong.ReadOnly = false;
                txtMaHonNhan.ReadOnly = false;
                txtCCCDVoChong.ReadOnly = false;
                txtCCCDVoChong.BackColor = Color.Gainsboro;
                txtMaHonNhan.BackColor = Color.Gainsboro;
                txtTenVoChong.BackColor = Color.Gainsboro;
            } 
            else
            {
                txtTenVoChong.ReadOnly = true;
                txtMaHonNhan.ReadOnly = true;
                txtCCCDVoChong.ReadOnly = true;
                txtCCCDVoChong.BackColor = Color.WhiteSmoke;
                txtMaHonNhan.BackColor = Color.WhiteSmoke;
                txtTenVoChong.BackColor = Color.WhiteSmoke;
            }    
        }
        private void ThemHinh()
        {
            ofdHinhDaiDien.Filter = "PImage Files (*.jpg, *.png)|*.jpg;*.png";
            try
            {
                if (ofdHinhDaiDien.ShowDialog() == DialogResult.OK)
                {
                    ptcHinhDaiDien.Image = new Bitmap(ofdHinhDaiDien.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được ảnh" + ex);
            }
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            ThemHinh();
        }

        private void SaveHinhDaiDien()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = string.Format($"{txtCCCD.Text}");
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\HinhCongDan"));
            string fullPath;
            if (ofdHinhDaiDien.FileName.Contains(".jpg"))
            {
                fileName += ".jpg";
                fullPath = Path.Combine(folderPath, fileName);
                ptcHinhDaiDien.Image.Save(fullPath, ImageFormat.Jpeg);
            }
            else
            {
                fileName += ".png";
                fullPath = Path.Combine(folderPath, fileName);
                ptcHinhDaiDien.Image.Save(fullPath, ImageFormat.Png);
            }
        }
    }
}
