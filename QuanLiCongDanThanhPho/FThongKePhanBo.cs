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
    public partial class FThongKePhanBo : Form
    {
        private CongDanDAO cdDAO;
        private TamTruTamVangDAO tttvDAO;
        private HoKhauDAO hkDAO;
        public FThongKePhanBo()
        {
            InitializeComponent();
            StackForm.Add(this);
            cdDAO = new CongDanDAO();
            tttvDAO = new TamTruTamVangDAO();
            hkDAO = new HoKhauDAO();
        }

        private void FThongKePhanBo_Load(object sender, EventArgs e)
        {
            gvDanhSachQuan.DataSource = cdDAO.LayDanhSachDC();
            lblSoNguoiTamTru.Text += " " + tttvDAO.LaySoLuongTamTru().ToString();
            lblSoNguoiTamVang.Text += " " + tttvDAO.LaySoLuongTamVang().ToString();
            lblSoNguoiQuaHanTT.Text += " " + tttvDAO.LaySoLuongQuaHanTamTru().ToString();
            lblSoNguoiQuaHanTV.Text += " " + tttvDAO.LaySoLuongQuaHanTamVang().ToString();
            gvHoNhieuNguoiNhat.DataSource = hkDAO.TimHoNhieuNguoiNhat();
            lblSoNguoiTrungBinhMotQuan.Text += " " + cdDAO.LaySoNguoiTrungBinhMotQuan().ToString();
            HeaderText();
        }

        private void HeaderText()
        {
            gvDanhSachQuan.Columns[0].HeaderText = "Quận";
            gvDanhSachQuan.Columns[1].HeaderText = "Số lượng người";

            gvHoNhieuNguoiNhat.Columns[0].HeaderText = "Mã hộ khẩu";
            gvHoNhieuNguoiNhat.Columns[1].HeaderText = "Số lượng người";
        }
    }
}
