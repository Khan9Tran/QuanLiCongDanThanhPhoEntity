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

namespace QuanLiCongDanThanhPho
{
    public partial class FTachGopHo : Form
    {
        private CongDanDAO cDDAO;
        private HoKhauDAO hKDAO;
        private bool isTach = false;
        private Congdan cD;
        public void init()
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
            hKDAO = new HoKhauDAO();
            StackForm.Add(this);
        }

        public FTachGopHo()
        {
            init();
        }
        public FTachGopHo(string maHoTach)
        {
            init();
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
        private bool isHoKhau(string maHoKhau)
        {
            Hokhau hK = hKDAO.LayThongTin(txtMaHoGop.Text);
            if (hK == null)
                return false;
            return true;
        }
        private void btnTaoHoMoi_Click(object sender, EventArgs e)
        { 
            if (KiemTraThongTin() && isTach == true)
            {
                //Kiểm tra 
                if (isHoKhau(txtMaHoGop.Text))
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

            Hokhau hK = hKDAO.LayThongTin(txtMaHoTach.Text);
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
            if (KiemTraThongTin() && isTach == true)
            {
                if (!isHoKhau(txtMaHoGop.Text))
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
             HeaderTach();
        }
        private void LoadHoGop()
        {
            gvHoGop.DataSource = cDDAO.LayDanhSachTheoHoKhau(txtMaHoGop.Text);
            HeaderGop();
        }

        private List<string> HeaderText = new List<string>()
            { "CCCD", "Tên", "Nghề nghiệp", "SĐT", "Tôn giáo", "Mã hộ khẩu", "Quan hệ với chủ hộ" };
        private void HeaderTach()
        {

            for (int i = 0; i < gvHoTach.Columns.Count - 2; i++) 
            {
                gvHoTach.Columns[i].HeaderText = HeaderText[i];
            }
            for (int i = gvHoTach.Columns.Count - 2; i < gvHoTach.Columns.Count; i++)
            {
                gvHoTach.Columns[i].Visible = false;
            }
        }
        private void HeaderGop()
        {

            for (int i = 0; i < gvHoGop.Columns.Count - 2; i++)
            {
                gvHoGop.Columns[i].HeaderText = HeaderText[i];
            }
            for (int i = gvHoGop.Columns.Count - 2; i < gvHoGop.Columns.Count; i++)
            {
                gvHoGop.Columns[i].Visible = false;
            }
        }
        private void btnMaHoTach_Click(object sender, EventArgs e)
        { 
            if (txtMaHoTach.Text != "")
                LoadHoTach();
        }

        private void btnMaHoGop_Click(object sender, EventArgs e)
        {
            if (txtMaHoGop.Text != "")
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
