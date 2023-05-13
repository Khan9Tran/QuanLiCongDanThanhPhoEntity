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
    public partial class FTrangChuCongDan : Form
    {
        private OpenChildForm childForm;
        private Account account;
        private AccountDAO accountDAO;
        private FDangNhap fDangNhap;
        private HinhDaiDien hinhCongDan;

        public FTrangChuCongDan(Account acc, FDangNhap dangNhap)
        {
            InitializeComponent();
            pnlLoad.Visible = false;
            fDangNhap = dangNhap;
            account = acc;
            loadForm = new OpenChildForm(pnlLoad);
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }

        OpenChildForm loadForm;

        private void btnThongTin_Click(object sender, EventArgs e)
        {;
            pnlLoad.Visible = true;
            loadForm.Open(new FXemCongDan());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            cmnusSetting.Show(this, PointToClient(MousePosition));
        }

        private void cmusItemDoiMK_Click(object sender, EventArgs e)
        {
            pnlLoad.Visible = true;
            loadForm.Open(new FSetting());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            loadForm.CurrentChildForm = null;
            pnlLoad.Visible = false;
        }

        private void cmnusItemDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            fDangNhap.Show();
        }

        private void FTrangChuCongDan_Load(object sender, EventArgs e)
        {
            hinhCongDan.LayHinhDaiDien(account.UserName, ptcCongDan);
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            pnlLoad.Visible = true;
            loadForm.Open(new FThanhToanThue());
        }

        private void btnTTTV_Click(object sender, EventArgs e)
        {
            pnlLoad.Visible = true;
            loadForm.Open(new FXinPhepTTTV());
        }

        private void btnCCCD_Click(object sender, EventArgs e)
        {
            CongDanDAO cdDAO = new CongDanDAO();
            FThongTinCCCD ttCCCD = new FThongTinCCCD(cdDAO.LayThongTin(account.UserName));
            ttCCCD.ShowDialog();
        }
    }
}
