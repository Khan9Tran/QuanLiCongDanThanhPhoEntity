﻿using QuanLiCongDanThanhPho.Model;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachCongDan : Form
    {
        CongDanDAO cdDao;
        private dynamic luaChon;
        private List<Congdan> ds;
        private Paging listCongDan;

        public List<Congdan> Ds { get => ds; set => ds = value; }

        private enum Loc
        {
            tatCa,
            nam,
            nu,
            ketHon,
            docThan,
            tuoiTac,
        }
        public FDanhSachCongDan()
        {

            InitializeComponent();
            cdDao = new CongDanDAO();
            ds = new List<Congdan>();
            listCongDan = new Paging(nudPage, 15);
            StackForm.Add(this);
            btnTamVang.Enabled = false;
            btnThue.Enabled = false;
        }

        //Tìm kiếm công dân theo các điều kiện
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == Loc.tatCa)
            {
                ds = cdDao.LayDanhSachChuaTu(txtTimKiem.Text);
            }
            else if (luaChon == Loc.nam)
            {
                ds = cdDao.LayDanhSachCongDanNam(txtTimKiem.Text);
            }
            else if (luaChon == Loc.nu)
            {
                ds = cdDao.LayDanhSachCongDanNu(txtTimKiem.Text);

            }
            else if (luaChon == Loc.ketHon)
            {
                ds = cdDao.LayDanhSachDaKetHon(txtTimKiem.Text);
            }
            else if (luaChon == Loc.docThan)
            {
                ds = cdDao.LayDanhSachChuaKetHon(txtTimKiem.Text);
            }
            else if (luaChon == Loc.tuoiTac)
            {
                ds = cdDao.LayDanhSachTuoiXepTuBeDenLon(txtTimKiem.Text);
            }
            nudPage.Value = 1;
            LoadDanhSach();
        }

        //Tải danh sách lên datagridview
        private void LoadDanhSach()
        {
            gvDanhSachCongDan.DataSource = listCongDan.NgatTrang(ds);
            HeaderText();
        }

        private void HeaderText()
        {
            gvDanhSachCongDan.Columns[0].HeaderText = "CCCD";
            gvDanhSachCongDan.Columns[1].HeaderText = "Họ và tên";
            gvDanhSachCongDan.Columns[2].HeaderText = "Nghề nghiệp";
            gvDanhSachCongDan.Columns[3].HeaderText = "Số ĐT";
            gvDanhSachCongDan.Columns[4].HeaderText = "Tôn giáo";
            gvDanhSachCongDan.Columns[5].HeaderText = "Mã hộ";
            gvDanhSachCongDan.Columns[6].Visible = false;
            gvDanhSachCongDan.Columns[7].Visible = false;
            gvDanhSachCongDan.Columns[8].Visible = false;
        }
        private void FDanhSachCongDan_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            fpnlPhanLoai.Width = 45;
        }

        private void gvDanhSachCongDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThue.Enabled = true;
            btnTamVang.Enabled = true;
            if (e.RowIndex != -1)
            {
                ThueDAO thueDAO = new ThueDAO();
                //Kiểm tra nếu không có trong ds thuế thì có thể đk
                if (thueDAO.LayThongTin(GetCCCD()) != null)
                {
                    btnThue.Enabled = false;
                }    
                TamTruTamVangDAO tttvDAO= new TamTruTamVangDAO();
                //Kiểm tra nếu không có trong ds tạm trú, tạm vắng thì có thể đk
                if (tttvDAO.LayThongTin(GetCCCD()) != null)
                {
                    btnTamVang.Enabled = false;
                }    
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        //Lọc giới tính: Nam
        private void btnNam_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.nam);
        }

        //Show tất cả
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
        }

        //Lọc giới tính: nữ
        private void btnNu_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.nu);
        }

        //Lọc người chưa kết hôn
        private void btnDocThan_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.docThan);
        }

        //Lọc người đã kết hôn
        private void btnKetHon_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.ketHon);
        }

        //Sắp xếp theo tuổi tác
        private void btnTuoiTac_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tuoiTac);
        }
        
        private void TimKiem(dynamic type)
        {
            luaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Đưa đến form đăng ký công dân
        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyCongDan dangKyCongDan = new FDangKyCongDan();
            (StackForm.TrangChu).ChildForm.Open(dangKyCongDan);
        }

        //Lấy mã cccd bằng kick vào gridview
        private string GetCCCD()
        {
            return (string)gvDanhSachCongDan.CurrentRow.Cells[0].Value;
        }

        //Menu
        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maCCCD = GetCCCD();
            Congdan cD = cdDao.LayThongTin(maCCCD);
            if (maCCCD != "" && cD != null)
            {
                FThongTinCongDan ttCD = new FThongTinCongDan(cD);
                ttCD.ShowDialog();
            }
        }

        //Xóa công dân
        private void XoaCongDan()
        {
            string maCCCD = GetCCCD();
            if (maCCCD != "")
            {
                Congdan cd = cdDao.LayThongTin(maCCCD);
                if (cd != null)
                {
                    cdDao.XoaCongDan(cd);
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }

        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Bạn có thật sự muốn xóa công dân?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (message == DialogResult.Yes)
            {
                XoaCongDan();
            }
        }

        //Đóng mở các nút lọc
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (fpnlPhanLoai.Width > 50)
            {
                fpnlPhanLoai.Width = 45;
            }    
            else 
            {
                fpnlPhanLoai.Width = 900;
            }
        }

        //Thay đổi ngắt trang
        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            FDangKyThue dangKyThue = new FDangKyThue(GetCCCD());
            (StackForm.TrangChu).ChildForm.Open(dangKyThue);
        }

        private void btnTamVang_Click(object sender, EventArgs e)
        {
            FDangKyTamTruTamVang dKTamTruTamVang = new FDangKyTamTruTamVang(GetCCCD());
            (StackForm.TrangChu).ChildForm.Open(dKTamTruTamVang);
        }
    }
}