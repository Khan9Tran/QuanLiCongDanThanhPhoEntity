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
    public partial class FThongKeCongDan : Form
    {
        private CongDanDAO cDDAO;
        private KhaiSinhDAO kSDAO;

        public FThongKeCongDan()
        {
            InitializeComponent();
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            kSDAO = new KhaiSinhDAO();
        }


        private void FThongKeCongDancs_Load(object sender, EventArgs e)
        {
            gvSoLuongNamNu.DataSource = kSDAO.LayDanhSachVeSoNamNu();
            lblSoCongDan.Text += string.Format($" {cDDAO.LaySoLuongCongDan()}");
            lblSoLuongDaKetHon.Text += string.Format($" {cDDAO.LaySoLuongDaKetHon()}");
            lblSoLuongChuaKetHon.Text += string.Format($" {cDDAO.LaySoLuongDocThan()}");
            gvNhomTuoi.DataSource = kSDAO.LayTuoiCongDan();
            gvNgheNghiep.DataSource = cDDAO.LayDanhSachNgheNghiep();
            HeaderText();
        }

        private void HeaderText()
        {
            gvNgheNghiep.Columns[0].HeaderText = "Nghề nghiệp";
            gvNgheNghiep.Columns[1].HeaderText = "Số lượng";

            gvSoLuongNamNu.Columns[0].HeaderText = "Giới tính";
            gvSoLuongNamNu.Columns[1].HeaderText = "Số lượng";

            gvNhomTuoi.Columns[0].HeaderText = "Nhóm tuổi";
            gvNhomTuoi.Columns[0].HeaderText = "Số lượng";
        }
    }
}
