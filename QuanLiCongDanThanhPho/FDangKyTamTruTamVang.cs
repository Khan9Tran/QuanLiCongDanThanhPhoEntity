﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Model;
using QuanLiCongDanThanhPho.Models;
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyTamTruTamVang : Form
    {
        TamTruTamVangDAO tTTVDAO;
        public FDangKyTamTruTamVang()
        {
            InitializeComponent();
            tTTVDAO = new TamTruTamVangDAO();
            StackForm.Add(this);
        }
        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isMaSo(txtMaSo.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra mã số");
                txtMaSo.Focus();
                return false;
            }    
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại CCCD");
                txtCCCD.Focus(); 
                return false;
            }    
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại họ và tên");
                txtTen.Focus();
                return false;
            }
            if (rdoTamTru.Checked == false && rdoTamVang.Checked == false) 
            {
                MessageBox.Show("Vui lòng chọn tạm trú hoặc tạm vắng");
                return false;
            }
            if (txtLiDo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Lí do");
                return false;
            }    
            if (!KiemTraDuLieuNhap.isSoDT(txtSDT.Text))
            {
                txtSDT.Focus();
                MessageBox.Show("Vui lòng SDT đúng định dạng");
                return false;
            }   
            if (!KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text))
            {
                txtDiaChi.Focus();
                MessageBox.Show("Vui lòng kiểm tra lại địa chỉ");
                return false;
            }  
            return true;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                if (rdoTamTru.Checked == true)
                {
                    Congdan cDTamTru = new Congdan()
                    {
                        Cccd = txtCCCD.Text,
                        Ten = txtTen.Text,
                        Sdt = txtSDT.Text,
                        MaHk = "00000B",
                        QuanHeVoiChuHo = "Tạm trú tại địa phương"
                    };

                    CongDanDAO cDTamTruDAO = new CongDanDAO();
                    cDTamTruDAO.ThemCongDan(cDTamTru);
                }
                Tamtrutamvang tTTV = new Tamtrutamvang()
                {
                    Cccd = txtCCCD.Text,
                    TrangThai = txtLiDo.Text,
                    MaTttv = txtMaSo.Text,
                    NgayBd = dtpNgayBatDau.Value,
                    NgayKt = dtpNgayKetThuc.Value,
                    LiDo = txtLiDo.Text,
                    DiaChi = txtDiaChi.Text,
                };
                try
                {
                    tTTVDAO.ThemTamTruTamVang(tTTV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có công dân ở địa phương");
                }
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
    }
}
