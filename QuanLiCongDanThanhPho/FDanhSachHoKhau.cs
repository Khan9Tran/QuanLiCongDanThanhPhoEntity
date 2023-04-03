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
    public partial class FDanhSachHoKhau : Form
    {
        HoKhauDAO hkDao = new HoKhauDAO();
        private string luaChon;
        private DataTable ds;
        public FDanhSachHoKhau()
        {
            InitializeComponent();
            StackForm.Add(this);
            ds = new DataTable();
            luaChon = "tat ca";
        }

        private void gvHoKhau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FDanhSachHoKhau_Load(object sender, EventArgs e)
        {
            txtTimKiem_TextChanged(txtTimKiem, null);
            flpnlPhanLoai.Width = 45;
        }

        private void gvHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            luaChon = "tat ca";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void LayDanhSach()
        {
            gvHoKhau.DataSource = NgatTrang(ds, 13);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == "tat ca")
               ds = hkDao.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == "sotv")
               ds = hkDao.LayDanhSachXepTheoSoTV(txtTimKiem.Text);
            nudPage.Value = 1;
            LayDanhSach();
        }

        private void btnSoTV_Click(object sender, EventArgs e)
        {
            luaChon = "sotv";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maHoKhau = gvHoKhau.CurrentRow.Cells["Mã hộ khẩu"].Value.ToString();
            if (maHoKhau != "")
            {
                FThongTinHoKhau tTHK = new FThongTinHoKhau(maHoKhau);
                tTHK.ShowDialog();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyHoKhau dangKyHoKhau = new FDangKyHoKhau();
            (StackForm.fTrangChu).OpenChildForm(dangKyHoKhau);
        }

        private void cmnusMenuTachGop_Click(object sender, EventArgs e)
        {
            string maHoKhau = gvHoKhau.CurrentRow.Cells["Mã hộ khẩu"].Value.ToString();
            if (maHoKhau != "")
            {
                FDangKyHoKhau dangKyHoKhau = new FDangKyHoKhau(maHoKhau);
                (StackForm.fTrangChu).OpenChildForm(dangKyHoKhau);
            }
        }

        //Tạo ngắt trang
        private DataTable NgatTrang(DataTable ds, int recordNum)
        {
            int totalRecord = ds.Rows.Count;
            if (totalRecord <= 0)
                return ds;
            if (totalRecord % recordNum != 0)
                nudPage.Maximum = (totalRecord / recordNum) + 1;
            else
                nudPage.Maximum = totalRecord / recordNum;
            int page = int.Parse(nudPage.Value.ToString());
            return ds.AsEnumerable().Skip((page - 1) * recordNum).Take(recordNum).CopyToDataTable();
        }

        private void nudPage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (flpnlPhanLoai.Width > 50)
                flpnlPhanLoai.Width = 45;
            else
                flpnlPhanLoai.Width = 800;
        }
    }
}
