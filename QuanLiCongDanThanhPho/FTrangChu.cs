using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Models;
namespace QuanLiCongDanThanhPho
{
    public partial class FTrangChu : Form
    {
        public Form currentChildForm;
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        private Account account;
        private AccountDAO accountDAO;

        public Account Account { get => account; set => account = value; }

        public FTrangChu()
        {
            InitializeComponent();
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(pnlHienThiForm);
            StackForm.fTrangChu = this;
        }
        public FTrangChu(Account acc)
        {
            InitializeComponent();
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(pnlHienThiForm);
            StackForm.fTrangChu = this;
            accountDAO = new AccountDAO();
            account = accountDAO.LayThongTinTaiKhoan(acc);
            tmrPhongTo.Interval = 1;
            tmrThuNho.Interval = 1;
        }
        public void LoadTaiKhoan()
        {
            account = accountDAO.LayThongTinTaiKhoan(account);
            btnTaiKhoan.Text = "Xin chào: " + account.DisplayName;
            LayHinhDaiDien();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            cmnusDangKy.Show(this, this.PointToClient(MousePosition));
            TatMenu(sender, e);
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSach());
            TatMenu(sender, e);

        }
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlHienThiForm.Controls.Add(childForm);
            pnlHienThiForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void TatMenu(object sender, EventArgs e)
        {
            if (pnlMenu.Width > 80)
                btnMenuShow_Click(sender, e);
        }
        private void cmnusDangKyItemTamTruTamVang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyTamTruTamVang());
            TatMenu(sender, e);
        }

        private void cmnusitemDangKyHonNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyHonNhan());
            TatMenu(sender, e);
        }

        private void cmnusDangKyItemKhaiSinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyKhaiSinh());
            TatMenu(sender, e);
        }

        private void cmnusDanhMucItemCongDan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachCongDan());
            TatMenu(sender, e);
        }

        private void cmnusDanhMucItemHoKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachHoKhau());
            TatMenu(sender, e);
        }
        private void cmnusDanhMucItemTamTruTamVang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachTamTruTamVang());
            TatMenu(sender, e);
        }

        private void cmnusDanhMucItemThue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachThue());
            TatMenu(sender, e);
        }

        private void cmnusDangKyItemCongDan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyCongDan());
            TatMenu(sender, e);
        }


        private void FTrangChu_Load(object sender, EventArgs e)
        {
            pnlMenu.BringToFront();
            LoadTaiKhoan();
            tmrNgayHienTai.Start();
        }

        private void btnMenuShow_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width <= 80)
            {
                tmrPhongTo.Start();
                pnlHienThiForm.BackColor = Color.Gainsboro;
            }
            else
            {
                tmrThuNho.Start();
                pnlHienThiForm.BackColor = Color.White;
            }
        }


        private void tmrThuNho_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width >= 80)
            {
                pnlMenu.Width -= 35;
                if (pnlMenu.Width <= 80)
                {
                    tmrThuNho.Stop();
                }
            }
        }

        private void tmrPhongTo_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width < 290)
            {
                pnlMenu.Width += 35;
                if (pnlMenu.Width >= 290)
                {
                    tmrPhongTo.Stop();
                }
            }
        }
        private void LayHinhDaiDien()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\HinhTaiKhoan"));
            string imagePath = string.Format(@$"{folderPath}\{account.UserName}");
            string png = imagePath + ".png";
            string jpg = imagePath + ".jpg";
            Bitmap bitmap = null;

            if (File.Exists(png))
            {
                bitmap?.Dispose();
                ptcHinhDaiDien.Image?.Dispose();

                using (Bitmap tempImage = new Bitmap(png, true)) //Giúp k bị lỗi không thể truy cập file đang hoạt động khi xóa
                {
                    bitmap = new Bitmap(tempImage);
                    ptcHinhDaiDien.Image = bitmap;
                }
            }
            else if (File.Exists(jpg))
            {
                bitmap?.Dispose();
                ptcHinhDaiDien.Image?.Dispose();

                using (Bitmap tempImage = new Bitmap(jpg, true))
                {
                    bitmap = new Bitmap(tempImage);
                    ptcHinhDaiDien.Image = bitmap;
                }
            }

        }

        private void pnlDanhMuc_MouseHover(object sender, EventArgs e)
        {
            pnlDanhMuc.BackColor = Color.FromArgb(44, 43, 60);
        }
        private void pnlDanhMuc_MouseLeave(object sender, EventArgs e)
        {
            pnlDanhMuc.BackColor = Color.FromArgb(50, 49, 70);
        }

        private void lblDangKy_MouseHover(object sender, EventArgs e)
        {
            pnlDangKy.BackColor = Color.FromArgb(44, 43, 60);
        }

        private void lblDangKy_MouseLeave(object sender, EventArgs e)
        {
            pnlDangKy.BackColor = Color.FromArgb(50, 49, 70);
        }

        private void pnlThongKe_MouseHover(object sender, EventArgs e)
        {
            pnlThongKe.BackColor = Color.FromArgb(44, 43, 60);
        }

        private void pnlThongKe_MouseLeave(object sender, EventArgs e)
        {
            pnlThongKe.BackColor = Color.FromArgb(50, 49, 70);
        }

        private void cmnusDangKyItemHoKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyHoKhau());
            TatMenu(sender, e);
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void cmnusDangKyItemCCCD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyCCCD());
            TatMenu(sender, e);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            cmnusTaiKhoan.Show(new Point(1500,142));
        }

        private void TaiKhoanItemDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            FDangNhap fDangNhap= new FDangNhap();
            fDangNhap.ShowDialog();
            StackForm.ClearAll();
            Close();
        }

        private void cmnusTaiKhoanItemThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn thoát", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                StackForm.ClearAll();
                Application.Exit();
            }
        }

        private void cmnusTaiKhoanItemCaNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTaiKhoan(account));
        }
        private void lblThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongKe());
            TatMenu(sender, e);
        }

        private void ptcHinhDaiDien_Click(object sender, EventArgs e)
        {
            cmnusTaiKhoan.Show(new Point(1500, 142));
        }

        private void ItemCongDanChuyenDi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FKhaiTu());
            TatMenu(sender, e);
        }

        private void tmrNgayHienTai_Tick(object sender, EventArgs e)
        {
            lblNgayHienTai.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
