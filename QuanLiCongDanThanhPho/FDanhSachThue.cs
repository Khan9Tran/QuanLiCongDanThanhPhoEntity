using QuanLiCongDanThanhPho.Model;
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
    public partial class FDanhSachThue : Form
    {
        ThueDAO thueDAO;
        CongDanDAO cDDAO;
        private dynamic luaChon; // Khởi tạo lựa chọn bộ lọc
        private List<Thue> ds; //Khởi tạo danh sách cho datagridview
        public FDanhSachThue()
        {
            InitializeComponent();
            StackForm.Add(this);
            thueDAO = new ThueDAO();
            cDDAO = new CongDanDAO();
            ds = new List<Thue>();
        }

        private enum Loc
        {
            tatCa,
            daNop,
            treHan
        }

        private void TimKiem(dynamic type)
        {
            luaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }
        private void FDanhSachThue_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            flpnPhanLoai.Width = 45;
        }


        private void gvThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
                LoadLblThue(e.RowIndex);
            }

        }
        // Danh sach thuế của tất cả công dân
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
        }

        // Thay đổi danh sách trong datagridview theo từ tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == Loc.tatCa)
                ds = thueDAO.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == Loc.daNop)
                ds = thueDAO.LayDanhSachSoTienDaNop(txtTimKiem.Text);
            else if (luaChon == Loc.treHan)
                ds = thueDAO.LayDanhSachTreHan(txtTimKiem.Text);
            nudPage.Value = 1;
            LoadDanhSach();

        }
        // Hàm sửa gán datatable cho datagridview
        private void LoadDanhSach()
        {
            gvThue.DataSource = NgatTrang(ds, 10);
            gvThue.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            HeaderText();
        }

        private void HeaderText()
        {
            gvThue.Columns[0].HeaderText = "Mã Thuế";
            gvThue.Columns[1].HeaderText = "Căn cước công dân";
            gvThue.Columns[2].HeaderText = "Còn nợ (VNĐ)";
            gvThue.Columns[3].HeaderText = "Đã thu (VNĐ)";
            gvThue.Columns[4].HeaderText = "Ngày cấp";
            gvThue.Columns[5].HeaderText = "Hạn nộp";
            gvThue.Columns[6].Visible = false;
        }

        private void LoadLblThue(int rowIndex)
        {
            Congdan cD = cDDAO.LayThongTin(getCCCD());
            string Ten = cD.Ten;
            string soTienCanNop = (string)gvThue.Rows[rowIndex].Cells[2].Value;
            lblThongTin.Text = Ten + " cần thanh toán " + soTienCanNop + " VNĐ";
        }

        // Sắp xếp danh sách tăng dần theo số tiền đã nộp
        private void btnTienDaNop_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.daNop);
        }

        private string getCCCD()
        {
            return  (string)gvThue.CurrentRow.Cells[1].Value;
        }

        // Xóa thông tin thuế của công dân ra khỏi csdl
        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn xóa thông tin thuế?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                string maCCCD = getCCCD();
                if (maCCCD != "")
                {
                    thueDAO.XoaThue(maCCCD);
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }

        // Mở ra form thông tin thuế của công dân được chọn
        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maCCCD = getCCCD();

            if (maCCCD != "")
            {
                FThongTinThue ttThue = new FThongTinThue();
                ttThue.MaCCCD = maCCCD;
                ttThue.ShowDialog();
            }
        }

        // Mở ra form đăng kí thuế
        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyThue dangKyThue = new FDangKyThue();
            (StackForm.fTrangChu).openChildForm.Open(dangKyThue);
        }

        // Lọc danh sách những người đóng tiền trẽ hạn/ chưa đủ tiền khi quá thời gian
        private void btnTreHan_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.treHan);
        }

        //Ngắt trang
        private List<Thue> NgatTrang(List<Thue> ds, int recordNum)
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

        //Thay đổi page
        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (flpnPhanLoai.Width > 50)
                flpnPhanLoai.Width = 45;
            else
                flpnPhanLoai.Width = 1000;
        }

        private void btnCongDanCanTaoThue_Click(object sender, EventArgs e)
        {
            FDanhSachCongDan ds = new FDanhSachCongDan();
            (StackForm.fTrangChu).openChildForm.Open(ds);
            ds.Ds = thueDAO.DuTuoiDongThue();

        }
        private bool ThanhToan()
        {
            if (txtDongThue.Text.Length == 0) return false;
            if (KiemTraDuLieuNhap.isTien(txtDongThue.Text))
            {
                int tienNhap = int.Parse(txtDongThue.Text);
                Thue thue = thueDAO.LayThongTin(getCCCD());
                if (thue.ThanhToan(tienNhap))
                {
                    thueDAO.CapNhatThue();
                    return true;
                }
            }
            return false;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (ThanhToan())
                MessageBox.Show("Thanh toán thành công");
            else
                MessageBox.Show("Thanh toán thất bại");
        }
    }
}
