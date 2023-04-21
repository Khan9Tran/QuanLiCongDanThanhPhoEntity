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
    public partial class FDangKyTamTruTamVang : Form
    {
        TamTruTamVangDAO tTTVDAO;
        public FDangKyTamTruTamVang()
        {
            InitializeComponent();
            tTTVDAO = new TamTruTamVangDAO();
            StackForm.Add(this);
        }
        public FDangKyTamTruTamVang(string cCCD)
        {
            InitializeComponent();
            tTTVDAO = new TamTruTamVangDAO();
            StackForm.Add(this);
            LoadThongTin(cCCD);
            
        }
        private void LoadThongTin(string cCCD)
        {
            if (cCCD != null)
            {
                CongDanDAO congDanDAO = new CongDanDAO();
                Congdan congDan = congDanDAO.LayThongTin(cCCD);
                txtTen.Text = congDan.Ten;
                txtCCCD.Text = congDan.Cccd;
                txtMaSo.Text = congDan.Cccd;
                rdoTamVang.Checked = true;
                txtSDT.Text = congDan.Sdt;
            }
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
                    try
                    {

                        cDTamTruDAO.ThemCongDan(cDTamTru);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Không thể dùng tùy chọn này");
                        return;
                    }
                }
                string trangThai = "Tạm vắng";
                if (rdoTamTru.Checked == true)
                {
                    trangThai = "Tạm trú";
                }
                Tamtrutamvang tTTV = new Tamtrutamvang()
                {
                    Cccd = txtCCCD.Text,
                    TrangThai = trangThai,
                    MaTttv = txtMaSo.Text,
                    NgayBd = dtpNgayBatDau.Value,
                    NgayKt = dtpNgayKetThuc.Value,
                    LiDo = txtLiDo.Text,
                    DiaChi = txtDiaChi.Text,
                };
                if (tTTVDAO.LayThongTin(tTTV.Cccd) == null)
                {
                    tTTVDAO.ThemTamTruTamVang(tTTV);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
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
