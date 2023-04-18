﻿using QuanLiCongDanThanhPho.Model;
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
    public partial class FDanhSachCongDan : Form
    {
        CongDanDAO cdDao;
        private string luaChon;
        private List<Congdan> ds;

        public List<Congdan> Ds { get => ds; set => ds = value; }

        public FDanhSachCongDan()
        {

            InitializeComponent();
            cdDao = new CongDanDAO();
            ds = new List<Congdan>();
            StackForm.Add(this);
            luaChon = "tat ca";
        }

        //Tìm kiếm công dân theo các điều kiện
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == "tat ca")
            {
                ds = cdDao.LayDanhSachChuaTu(txtTimKiem.Text);
            }
            else if (luaChon == "nam")
            {
                ds = cdDao.LayDanhSachCongDanNam(txtTimKiem.Text);
            }
            else if (luaChon == "nu")
            {
                ds = cdDao.LayDanhSachCongDanNu(txtTimKiem.Text);

            }
            else if (luaChon == "ket hon")
            {
                ds = cdDao.LayDanhSachDaKetHon(txtTimKiem.Text);
            }
            else if (luaChon == "doc than")
            {
                ds = cdDao.LayDanhSachChuaKetHon(txtTimKiem.Text);
            }
            else if (luaChon == "tuoi tac")
            {
                ds = cdDao.LayDanhSachTuoiXepTuBeDenLon(txtTimKiem.Text);
            }
            nudPage.Value = 1;
            LoadDanhSach();
        }

        //Tải danh sách lên datagridview
        private void LoadDanhSach()
        {
            gvDanhSachCongDan.DataSource = NgatTrang(ds,15);
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
            txtTimKiem_TextChanged(txtTimKiem, null);
            fpnlPhanLoai.Width = 45;
        }

        private void gvDanhSachCongDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        //Lọc giới tính: Nam
        private void btnNam_Click(object sender, EventArgs e)
        {
            luaChon = "nam";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Show tất cả
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            luaChon = "tat ca";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Lọc giới tính: nữ
        private void btnNu_Click(object sender, EventArgs e)
        {
            luaChon = "nu";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Lọc người chưa kết hôn
        private void btnDocThan_Click(object sender, EventArgs e)
        {
            luaChon = "doc than";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Lọc người đã kết hôn
        private void btnKetHon_Click(object sender, EventArgs e)
        {
            luaChon = "ket hon";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Sắp xếp theo tuổi tác
        private void btnTuoiTac_Click(object sender, EventArgs e)
        {
            luaChon = "tuoi tac";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Đưa đến form đăng ký công dân
        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyCongDan dangKyCongDan = new FDangKyCongDan();
            (StackForm.fTrangChu).OpenChildForm(dangKyCongDan);
        }

        //Lấy mã cccd bằng kick vào gridview
        private string GetCCCD()
        {
            return gvDanhSachCongDan.CurrentRow.Cells[0].Value.ToString();
        }

        //Menu
        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maCCCD = GetCCCD();
            Congdan cD = cdDao.LayThongTin(maCCCD);
            if (maCCCD != "")
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
                cdDao.XoaCongDan(cd);
                txtTimKiem_TextChanged(txtTimKiem, null);
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

        //Phân trang cho datagridview
        private List<Congdan> NgatTrang(List<Congdan> ds, int recordNum)
        {
            int totalRecord = ds.Count;
            if (totalRecord <= 0)
                return ds;
            if (totalRecord % recordNum != 0)
                nudPage.Maximum = (totalRecord / recordNum) + 1;
            else
                nudPage.Maximum =  totalRecord / recordNum;
            int page = int.Parse(nudPage.Value.ToString());
            return ds.AsEnumerable().Skip((page -1)* recordNum).Take(recordNum).ToList();
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
    }
}