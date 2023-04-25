﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FDanhSachTamTruTamVang : Form
    {
        TamTruTamVangDAO tttvDao;
        private dynamic luaChon;
        private List<Tamtrutamvang> ds;
        public FDanhSachTamTruTamVang()
        {
            InitializeComponent();
            StackForm.Add(this);
            ds = new List<Tamtrutamvang>();
            tttvDao = new TamTruTamVangDAO();
        }

        private enum Loc 
        {
            tatCa,
            tamTru,
            tamVang,
            quaHan
        }
        private void TimKiem(dynamic type)
        {
            luaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);

        }
        //Load danh sách ban đầu
        private void FDanhSachTamTruTamVang_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            flpnlPhanLoai.Width = 45;
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
        }


        //Tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == Loc.tatCa)
                ds = tttvDao.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == Loc.tamVang)
                ds = tttvDao.LayDanhSachTamTru(txtTimKiem.Text);
            else if (luaChon == Loc.tamVang)
                ds = tttvDao.LayDanhSachTamVang(txtTimKiem.Text);
            else if (luaChon == Loc.quaHan)
                ds = tttvDao.LayDanhSachQuaHan(txtTimKiem.Text);
            nudPage.Value = 1;
            LoadDanhSach();
        }
        enum LoaiGiaHan
        {
            ngay,
            thang,
            nam
        }
        private string getCCCD()
        {
            return (string)gvTVTT.CurrentRow.Cells[1].Value;
        }
        private void GiaHan(int num, dynamic type)
        {
            Tamtrutamvang tTTTV = tttvDao.LayThongTin(getCCCD());
            if (type == LoaiGiaHan.ngay)
                tTTTV.NgayKt = tTTTV.NgayKt.Value.AddDays(num);
            else if (type ==  LoaiGiaHan.thang)
                tTTTV.NgayKt = tTTTV.NgayKt.Value.AddMonths(num);
            else
                tTTTV.NgayKt = tTTTV.NgayKt.Value.AddYears(num);
            tttvDao.CapNhat();
        }
        private string DayFormat()
        {
            return "dd/MM/yyyy";
        }
        private void LoadDanhSach()
        {
            gvTVTT.DataSource = NgatTrang(ds, 10);
            gvTVTT.Columns[4].DefaultCellStyle.Format = DayFormat();
            gvTVTT.Columns[3].DefaultCellStyle.Format = DayFormat();

            HeaderText();
            HightLightQuaHan();
        }
        private void HeaderText()
        {
            gvTVTT.Columns[0].HeaderText = "Mã tạm trú tạm vắng";
            gvTVTT.Columns[1].HeaderText = "Căn cước công dân";
            gvTVTT.Columns[2].HeaderText = "Địa chỉ";
            gvTVTT.Columns[3].HeaderText = "Ngày bắt đầu";
            gvTVTT.Columns[4].HeaderText = "Ngày kết thúc";
            gvTVTT.Columns[5].HeaderText = "Trạng thái";
            gvTVTT.Columns[6].HeaderText = "Lí do";
            gvTVTT.Columns[7].Visible = false;
        }
        private void HightLightQuaHan()
        {
            for (int index = 0; index < gvTVTT.Rows.Count; index++)
            {
                if ((DateTime)gvTVTT.Rows[index].Cells[4].Value < DateTime.Now)
                {
                    gvTVTT.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tamVang);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tamTru);
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
                string maCCCD = getCCCD();

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
            TimKiem(Loc.quaHan);
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

        private void ngayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaHan(3, LoaiGiaHan.ngay);
        }

        private void tuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaHan(7, LoaiGiaHan.ngay);
        }
        private void thangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaHan(1, LoaiGiaHan.thang);
        }

        private void namToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GiaHan(1, LoaiGiaHan.nam);
        }
    }
}
