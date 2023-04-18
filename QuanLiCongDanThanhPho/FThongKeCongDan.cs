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
        CongDanDAO cdDAO = new CongDanDAO();
        KhaiSinhDAO ksDAO = new KhaiSinhDAO();

        public FThongKeCongDan()
        {
            InitializeComponent();
            StackForm.Add(this);
        }

        private void FThongKeCongDancs_Load(object sender, EventArgs e)
        {
            gvSoLuongNamNu.DataSource = ksDAO.LayDanhSachVeSoNamNu();
            lblSoCongDan.Text += string.Format($" {cdDAO.LaySoLuongCongDan()}");
            lblSoLuongDaKetHon.Text += string.Format($" {cdDAO.LaySoLuongDaKetHon()}");
            lblSoLuongChuaKetHon.Text += string.Format($" {cdDAO.LaySoLuongDocThan()}");
            gvNhomTuoi.DataSource = ksDAO.LayTuoiCongDan();
            gvNgheNghiep.DataSource = cdDAO.LayDanhSachNgheNghiep();
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
