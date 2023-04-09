using QuanLiCongDanThanhPho.Model;
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

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachTamTruTamVang : Form
    {
        TamTruTamVangDAO tttvDao;
        private string luaChon;
        private List<Tamtrutamvang> ds;
        public FDanhSachTamTruTamVang()
        {
            InitializeComponent();
            StackForm.Add(this);
            ds = new List<Tamtrutamvang>();
            tttvDao = new TamTruTamVangDAO();
            luaChon = "tat ca";
        }

        //Load danh sách ban đầu
        private void FDanhSachTamTruTamVang_Load(object sender, EventArgs e)
        {
            txtTimKiem_TextChanged(txtTimKiem, null);
            flpnlPhanLoai.Width = 45;
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            luaChon = "tat ca";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }


        //Tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == "tat ca")
                ds = tttvDao.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == "tam tru")
                ds = tttvDao.LayDanhSachTamTru(txtTimKiem.Text);
            else if (luaChon == "tam vang")
                ds = tttvDao.LayDanhSachTamVang(txtTimKiem.Text);
            else if (luaChon == "qua han")
                ds = tttvDao.LayDanhSachQuaHan(txtTimKiem.Text);
            nudPage.Value = 1;
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            gvTVTT.DataSource = NgatTrang(ds, 10);
            gvTVTT.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            gvTVTT.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            luaChon = "tam vang";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            luaChon = "tam tru";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyTamTruTamVang dangKyTTTV = new FDangKyTamTruTamVang();
            (StackForm.fTrangChu).OpenChildForm(dangKyTTTV);
        }

        private void gvTVTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        //Xóa thông tin
        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn xóa thông tin tạm trú/tạm vắng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                string maCCCD = gvTVTT.CurrentRow.Cells["CCCD"].Value.ToString();
                if (maCCCD != "")
                {
                    tttvDao.XoaTamTruTamVang(maCCCD);
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }

        //Lọc danh sách hết hạn tạm trú tạm vắng
        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            luaChon = "qua han";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Ngắt trang
        private List<Tamtrutamvang> NgatTrang(List<Tamtrutamvang> ds, int recordNum)
        {
            int totalRecord = ds.Count;
            if (totalRecord <= 0)
                return ds;
            if (totalRecord % recordNum != 0)
                nudPage.Maximum = (totalRecord / recordNum) + 1;
            else
                nudPage.Maximum = totalRecord / recordNum;
            int page = int.Parse(nudPage.Value.ToString());
            return ds.AsEnumerable().Skip((page - 1) * recordNum).Take(recordNum).ToList();
        }

        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
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
