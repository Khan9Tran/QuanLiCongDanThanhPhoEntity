namespace QuanLiCongDanThanhPho
{
    partial class FThongTinCongDan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTittleBar = new Label();
            pnlTittleBar = new Panel();
            ptcHinhDaiDien = new PictureBox();
            lblTen = new Label();
            lblCccd = new Label();
            lblNgaySinh = new Label();
            dtmNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            lblDanToc = new Label();
            lblTonGiao = new Label();
            lblTinhTrangHonNhan = new Label();
            lblQueQuan = new Label();
            lblNghe = new Label();
            lblQuocTich = new Label();
            pnlThongTin = new Panel();
            lblSoDT = new Label();
            pnlThongTinCD = new Panel();
            btnThongTinCCCD = new Button();
            lblQuanHeVoiChuHo = new Label();
            txtQuanHeVoiChuHo = new TextBox();
            fpnlChucNang = new FlowLayoutPanel();
            btnXacNhan = new Button();
            btnSua = new Button();
            btnReLoad = new Button();
            btnHonNhan = new Button();
            btnThue = new Button();
            btnHoKhau = new Button();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            btnKhaiSinh = new Button();
            txtHonNhan = new TextBox();
            txtTonGiao = new TextBox();
            txtGioiTinh = new TextBox();
            txtDanToc = new TextBox();
            txtQuocTich = new TextBox();
            txtMaThue = new TextBox();
            txtMaHoKhau = new TextBox();
            txtSDT = new TextBox();
            txtQueQuan = new TextBox();
            txtDiaChi = new TextBox();
            txtNgheNghiep = new TextBox();
            txtCCCD = new TextBox();
            txtHoVaTen = new TextBox();
            lblMaThue = new Label();
            lblMaHoKhau = new Label();
            lblDiaChi = new Label();
            sideBarWhite = new SideBarWhite();
            titleBarWhite = new TitleBarWhite();
            ofdHinhDaiDien = new OpenFileDialog();
            sfdHinhDaiDien = new SaveFileDialog();
            pnlTittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptcHinhDaiDien).BeginInit();
            pnlThongTinCD.SuspendLayout();
            fpnlChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // lblTittleBar
            // 
            lblTittleBar.AutoSize = true;
            lblTittleBar.BackColor = Color.Transparent;
            lblTittleBar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTittleBar.ForeColor = Color.WhiteSmoke;
            lblTittleBar.Location = new Point(252, 19);
            lblTittleBar.Name = "lblTittleBar";
            lblTittleBar.Size = new Size(330, 38);
            lblTittleBar.TabIndex = 0;
            lblTittleBar.Text = "THÔNG TIN CÔNG DÂN";
            // 
            // pnlTittleBar
            // 
            pnlTittleBar.BackColor = Color.RoyalBlue;
            pnlTittleBar.Controls.Add(lblTittleBar);
            pnlTittleBar.Location = new Point(4, 40);
            pnlTittleBar.Name = "pnlTittleBar";
            pnlTittleBar.Size = new Size(833, 77);
            pnlTittleBar.TabIndex = 1;
            // 
            // ptcHinhDaiDien
            // 
            ptcHinhDaiDien.BackColor = Color.White;
            ptcHinhDaiDien.BackgroundImageLayout = ImageLayout.Zoom;
            ptcHinhDaiDien.Enabled = false;
            ptcHinhDaiDien.Location = new Point(474, 200);
            ptcHinhDaiDien.Name = "ptcHinhDaiDien";
            ptcHinhDaiDien.Size = new Size(176, 228);
            ptcHinhDaiDien.SizeMode = PictureBoxSizeMode.StretchImage;
            ptcHinhDaiDien.TabIndex = 2;
            ptcHinhDaiDien.TabStop = false;
            ptcHinhDaiDien.Click += picCongDan_Click;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.BackColor = Color.Transparent;
            lblTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTen.Location = new Point(30, 50);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(104, 28);
            lblTen.TabIndex = 3;
            lblTen.Text = "Họ và tên";
            // 
            // lblCccd
            // 
            lblCccd.AutoSize = true;
            lblCccd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCccd.Location = new Point(30, 100);
            lblCccd.Name = "lblCccd";
            lblCccd.Size = new Size(61, 28);
            lblCccd.TabIndex = 5;
            lblCccd.Text = "CCCD";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgaySinh.Location = new Point(30, 150);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(107, 28);
            lblNgaySinh.TabIndex = 7;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtmNgaySinh
            // 
            dtmNgaySinh.CalendarTitleBackColor = Color.IndianRed;
            dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtmNgaySinh.Enabled = false;
            dtmNgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtmNgaySinh.Format = DateTimePickerFormat.Custom;
            dtmNgaySinh.Location = new Point(212, 144);
            dtmNgaySinh.Name = "dtmNgaySinh";
            dtmNgaySinh.Size = new Size(174, 34);
            dtmNgaySinh.TabIndex = 8;
            dtmNgaySinh.Value = new DateTime(2023, 2, 28, 0, 0, 0, 0);
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGioiTinh.Location = new Point(30, 200);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(95, 28);
            lblGioiTinh.TabIndex = 9;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblDanToc
            // 
            lblDanToc.AutoSize = true;
            lblDanToc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDanToc.Location = new Point(30, 350);
            lblDanToc.Name = "lblDanToc";
            lblDanToc.Size = new Size(86, 28);
            lblDanToc.TabIndex = 11;
            lblDanToc.Text = "Dân tộc";
            // 
            // lblTonGiao
            // 
            lblTonGiao.AutoSize = true;
            lblTonGiao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTonGiao.Location = new Point(30, 400);
            lblTonGiao.Name = "lblTonGiao";
            lblTonGiao.Size = new Size(93, 28);
            lblTonGiao.TabIndex = 13;
            lblTonGiao.Text = "Tôn giáo";
            // 
            // lblTinhTrangHonNhan
            // 
            lblTinhTrangHonNhan.AutoSize = true;
            lblTinhTrangHonNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTinhTrangHonNhan.Location = new Point(30, 700);
            lblTinhTrangHonNhan.Name = "lblTinhTrangHonNhan";
            lblTinhTrangHonNhan.Size = new Size(104, 28);
            lblTinhTrangHonNhan.TabIndex = 17;
            lblTinhTrangHonNhan.Text = "Hôn nhân";
            // 
            // lblQueQuan
            // 
            lblQueQuan.AutoSize = true;
            lblQueQuan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQueQuan.Location = new Point(30, 500);
            lblQueQuan.Name = "lblQueQuan";
            lblQueQuan.Size = new Size(103, 28);
            lblQueQuan.TabIndex = 19;
            lblQueQuan.Text = "Quê quán";
            // 
            // lblNghe
            // 
            lblNghe.AutoSize = true;
            lblNghe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNghe.Location = new Point(30, 250);
            lblNghe.Name = "lblNghe";
            lblNghe.Size = new Size(134, 28);
            lblNghe.TabIndex = 27;
            lblNghe.Text = "Nghề nghiệp";
            // 
            // lblQuocTich
            // 
            lblQuocTich.AutoSize = true;
            lblQuocTich.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuocTich.Location = new Point(30, 300);
            lblQuocTich.Name = "lblQuocTich";
            lblQuocTich.Size = new Size(103, 28);
            lblQuocTich.TabIndex = 15;
            lblQuocTich.Text = "Quốc tịch";
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.BorderStyle = BorderStyle.FixedSingle;
            pnlThongTin.Dock = DockStyle.Fill;
            pnlThongTin.Location = new Point(0, 42);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(1200, 678);
            pnlThongTin.TabIndex = 29;
            // 
            // lblSoDT
            // 
            lblSoDT.AutoSize = true;
            lblSoDT.BackColor = Color.Transparent;
            lblSoDT.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoDT.Image = Properties.Resources.telephone;
            lblSoDT.Location = new Point(30, 550);
            lblSoDT.Name = "lblSoDT";
            lblSoDT.Size = new Size(56, 32);
            lblSoDT.TabIndex = 30;
            lblSoDT.Text = "      ";
            // 
            // pnlThongTinCD
            // 
            pnlThongTinCD.BackColor = Color.WhiteSmoke;
            pnlThongTinCD.Controls.Add(btnThongTinCCCD);
            pnlThongTinCD.Controls.Add(lblQuanHeVoiChuHo);
            pnlThongTinCD.Controls.Add(txtQuanHeVoiChuHo);
            pnlThongTinCD.Controls.Add(fpnlChucNang);
            pnlThongTinCD.Controls.Add(btnHonNhan);
            pnlThongTinCD.Controls.Add(btnThue);
            pnlThongTinCD.Controls.Add(btnHoKhau);
            pnlThongTinCD.Controls.Add(ptcHinhDaiDien);
            pnlThongTinCD.Controls.Add(txtGhiChu);
            pnlThongTinCD.Controls.Add(lblGhiChu);
            pnlThongTinCD.Controls.Add(btnKhaiSinh);
            pnlThongTinCD.Controls.Add(txtHonNhan);
            pnlThongTinCD.Controls.Add(txtTonGiao);
            pnlThongTinCD.Controls.Add(lblTinhTrangHonNhan);
            pnlThongTinCD.Controls.Add(txtGioiTinh);
            pnlThongTinCD.Controls.Add(txtDanToc);
            pnlThongTinCD.Controls.Add(txtQuocTich);
            pnlThongTinCD.Controls.Add(txtMaThue);
            pnlThongTinCD.Controls.Add(txtMaHoKhau);
            pnlThongTinCD.Controls.Add(txtSDT);
            pnlThongTinCD.Controls.Add(txtQueQuan);
            pnlThongTinCD.Controls.Add(txtDiaChi);
            pnlThongTinCD.Controls.Add(txtNgheNghiep);
            pnlThongTinCD.Controls.Add(txtCCCD);
            pnlThongTinCD.Controls.Add(txtHoVaTen);
            pnlThongTinCD.Controls.Add(lblMaThue);
            pnlThongTinCD.Controls.Add(lblMaHoKhau);
            pnlThongTinCD.Controls.Add(lblDiaChi);
            pnlThongTinCD.Controls.Add(lblTen);
            pnlThongTinCD.Controls.Add(lblSoDT);
            pnlThongTinCD.Controls.Add(lblNghe);
            pnlThongTinCD.Controls.Add(lblQuocTich);
            pnlThongTinCD.Controls.Add(lblCccd);
            pnlThongTinCD.Controls.Add(lblTonGiao);
            pnlThongTinCD.Controls.Add(lblQueQuan);
            pnlThongTinCD.Controls.Add(lblGioiTinh);
            pnlThongTinCD.Controls.Add(lblNgaySinh);
            pnlThongTinCD.Controls.Add(dtmNgaySinh);
            pnlThongTinCD.Controls.Add(lblDanToc);
            pnlThongTinCD.Location = new Point(4, 113);
            pnlThongTinCD.Name = "pnlThongTinCD";
            pnlThongTinCD.Size = new Size(833, 797);
            pnlThongTinCD.TabIndex = 31;
            // 
            // btnThongTinCCCD
            // 
            btnThongTinCCCD.BackColor = Color.Transparent;
            btnThongTinCCCD.FlatAppearance.BorderSize = 0;
            btnThongTinCCCD.FlatStyle = FlatStyle.Flat;
            btnThongTinCCCD.Image = Properties.Resources.search__1_;
            btnThongTinCCCD.Location = new Point(733, 99);
            btnThongTinCCCD.Name = "btnThongTinCCCD";
            btnThongTinCCCD.Size = new Size(50, 34);
            btnThongTinCCCD.TabIndex = 102;
            btnThongTinCCCD.UseVisualStyleBackColor = false;
            btnThongTinCCCD.Click += btnThongTinCCCD_Click;
            // 
            // lblQuanHeVoiChuHo
            // 
            lblQuanHeVoiChuHo.AutoSize = true;
            lblQuanHeVoiChuHo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuanHeVoiChuHo.Location = new Point(30, 650);
            lblQuanHeVoiChuHo.Name = "lblQuanHeVoiChuHo";
            lblQuanHeVoiChuHo.Size = new Size(197, 28);
            lblQuanHeVoiChuHo.TabIndex = 101;
            lblQuanHeVoiChuHo.Text = "Quan hệ với chủ hộ";
            // 
            // txtQuanHeVoiChuHo
            // 
            txtQuanHeVoiChuHo.BackColor = Color.Gainsboro;
            txtQuanHeVoiChuHo.BorderStyle = BorderStyle.None;
            txtQuanHeVoiChuHo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuanHeVoiChuHo.Location = new Point(261, 650);
            txtQuanHeVoiChuHo.Name = "txtQuanHeVoiChuHo";
            txtQuanHeVoiChuHo.ReadOnly = true;
            txtQuanHeVoiChuHo.Size = new Size(530, 27);
            txtQuanHeVoiChuHo.TabIndex = 100;
            // 
            // fpnlChucNang
            // 
            fpnlChucNang.BackColor = SystemColors.Window;
            fpnlChucNang.BorderStyle = BorderStyle.FixedSingle;
            fpnlChucNang.Controls.Add(btnXacNhan);
            fpnlChucNang.Controls.Add(btnSua);
            fpnlChucNang.Controls.Add(btnReLoad);
            fpnlChucNang.Location = new Point(705, 200);
            fpnlChucNang.Name = "fpnlChucNang";
            fpnlChucNang.Size = new Size(65, 227);
            fpnlChucNang.TabIndex = 99;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Transparent;
            btnXacNhan.Enabled = false;
            btnXacNhan.FlatAppearance.BorderSize = 0;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Image = Properties.Resources.check__2_;
            btnXacNhan.Location = new Point(3, 3);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(61, 74);
            btnXacNhan.TabIndex = 109;
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = Properties.Resources.edit__3_;
            btnSua.Location = new Point(3, 83);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(61, 65);
            btnSua.TabIndex = 100;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnReLoad
            // 
            btnReLoad.BackColor = Color.Transparent;
            btnReLoad.FlatAppearance.BorderSize = 0;
            btnReLoad.FlatStyle = FlatStyle.Flat;
            btnReLoad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReLoad.ForeColor = Color.White;
            btnReLoad.Image = Properties.Resources.undo__1_;
            btnReLoad.Location = new Point(3, 154);
            btnReLoad.Name = "btnReLoad";
            btnReLoad.Size = new Size(61, 78);
            btnReLoad.TabIndex = 110;
            btnReLoad.UseVisualStyleBackColor = false;
            btnReLoad.Click += btnReLoad_Click;
            // 
            // btnHonNhan
            // 
            btnHonNhan.BackColor = Color.Transparent;
            btnHonNhan.FlatAppearance.BorderSize = 0;
            btnHonNhan.FlatStyle = FlatStyle.Flat;
            btnHonNhan.Image = Properties.Resources.search__1_;
            btnHonNhan.Location = new Point(742, 699);
            btnHonNhan.Name = "btnHonNhan";
            btnHonNhan.Size = new Size(50, 35);
            btnHonNhan.TabIndex = 98;
            btnHonNhan.UseVisualStyleBackColor = false;
            btnHonNhan.Click += btnHonNhan_Click;
            // 
            // btnThue
            // 
            btnThue.BackColor = Color.Transparent;
            btnThue.FlatAppearance.BorderSize = 0;
            btnThue.FlatStyle = FlatStyle.Flat;
            btnThue.Image = Properties.Resources.search__1_;
            btnThue.Location = new Point(748, 600);
            btnThue.Name = "btnThue";
            btnThue.Size = new Size(50, 35);
            btnThue.TabIndex = 97;
            btnThue.UseVisualStyleBackColor = false;
            btnThue.Click += btnThue_Click;
            // 
            // btnHoKhau
            // 
            btnHoKhau.BackColor = Color.Transparent;
            btnHoKhau.FlatAppearance.BorderSize = 0;
            btnHoKhau.FlatStyle = FlatStyle.Flat;
            btnHoKhau.Image = Properties.Resources.search__1_;
            btnHoKhau.Location = new Point(399, 596);
            btnHoKhau.Name = "btnHoKhau";
            btnHoKhau.Size = new Size(50, 35);
            btnHoKhau.TabIndex = 96;
            btnHoKhau.UseVisualStyleBackColor = false;
            btnHoKhau.Click += btnHoKhau_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BackColor = Color.Gainsboro;
            txtGhiChu.BorderStyle = BorderStyle.None;
            txtGhiChu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGhiChu.Location = new Point(212, 758);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.ReadOnly = true;
            txtGhiChu.Size = new Size(525, 27);
            txtGhiChu.TabIndex = 52;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGhiChu.Location = new Point(30, 750);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(113, 28);
            lblGhiChu.TabIndex = 51;
            lblGhiChu.Text = "Ghi chú (*)";
            // 
            // btnKhaiSinh
            // 
            btnKhaiSinh.BackColor = Color.DodgerBlue;
            btnKhaiSinh.FlatAppearance.BorderColor = Color.White;
            btnKhaiSinh.FlatStyle = FlatStyle.Flat;
            btnKhaiSinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhaiSinh.ForeColor = Color.White;
            btnKhaiSinh.Location = new Point(474, 140);
            btnKhaiSinh.Name = "btnKhaiSinh";
            btnKhaiSinh.Size = new Size(176, 47);
            btnKhaiSinh.TabIndex = 50;
            btnKhaiSinh.Text = "Khai Sinh";
            btnKhaiSinh.UseVisualStyleBackColor = false;
            btnKhaiSinh.Click += btnKhaiSinh_Click;
            // 
            // txtHonNhan
            // 
            txtHonNhan.BackColor = Color.Gainsboro;
            txtHonNhan.BorderStyle = BorderStyle.None;
            txtHonNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHonNhan.Location = new Point(212, 700);
            txtHonNhan.Name = "txtHonNhan";
            txtHonNhan.ReadOnly = true;
            txtHonNhan.Size = new Size(525, 27);
            txtHonNhan.TabIndex = 46;
            // 
            // txtTonGiao
            // 
            txtTonGiao.BackColor = Color.Gainsboro;
            txtTonGiao.BorderStyle = BorderStyle.None;
            txtTonGiao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTonGiao.Location = new Point(212, 400);
            txtTonGiao.Name = "txtTonGiao";
            txtTonGiao.ReadOnly = true;
            txtTonGiao.Size = new Size(178, 27);
            txtTonGiao.TabIndex = 45;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.BackColor = Color.Gainsboro;
            txtGioiTinh.BorderStyle = BorderStyle.None;
            txtGioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGioiTinh.Location = new Point(212, 200);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.ReadOnly = true;
            txtGioiTinh.Size = new Size(178, 27);
            txtGioiTinh.TabIndex = 44;
            // 
            // txtDanToc
            // 
            txtDanToc.BackColor = Color.Gainsboro;
            txtDanToc.BorderStyle = BorderStyle.None;
            txtDanToc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDanToc.Location = new Point(212, 350);
            txtDanToc.Name = "txtDanToc";
            txtDanToc.ReadOnly = true;
            txtDanToc.Size = new Size(178, 27);
            txtDanToc.TabIndex = 43;
            // 
            // txtQuocTich
            // 
            txtQuocTich.BackColor = Color.Gainsboro;
            txtQuocTich.BorderStyle = BorderStyle.None;
            txtQuocTich.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuocTich.Location = new Point(212, 300);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.ReadOnly = true;
            txtQuocTich.Size = new Size(178, 27);
            txtQuocTich.TabIndex = 42;
            // 
            // txtMaThue
            // 
            txtMaThue.BackColor = Color.Gainsboro;
            txtMaThue.BorderStyle = BorderStyle.None;
            txtMaThue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaThue.Location = new Point(564, 600);
            txtMaThue.Name = "txtMaThue";
            txtMaThue.ReadOnly = true;
            txtMaThue.Size = new Size(174, 27);
            txtMaThue.TabIndex = 41;
            // 
            // txtMaHoKhau
            // 
            txtMaHoKhau.BackColor = Color.Gainsboro;
            txtMaHoKhau.BorderStyle = BorderStyle.None;
            txtMaHoKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHoKhau.Location = new Point(212, 600);
            txtMaHoKhau.Name = "txtMaHoKhau";
            txtMaHoKhau.ReadOnly = true;
            txtMaHoKhau.Size = new Size(174, 27);
            txtMaHoKhau.TabIndex = 40;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.Gainsboro;
            txtSDT.BorderStyle = BorderStyle.None;
            txtSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(212, 550);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(570, 27);
            txtSDT.TabIndex = 39;
            // 
            // txtQueQuan
            // 
            txtQueQuan.BackColor = Color.Gainsboro;
            txtQueQuan.BorderStyle = BorderStyle.None;
            txtQueQuan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQueQuan.Location = new Point(212, 500);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.ReadOnly = true;
            txtQueQuan.Size = new Size(570, 27);
            txtQueQuan.TabIndex = 38;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.Gainsboro;
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(212, 450);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(569, 27);
            txtDiaChi.TabIndex = 37;
            // 
            // txtNgheNghiep
            // 
            txtNgheNghiep.BackColor = Color.Gainsboro;
            txtNgheNghiep.BorderStyle = BorderStyle.None;
            txtNgheNghiep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgheNghiep.Location = new Point(212, 251);
            txtNgheNghiep.Name = "txtNgheNghiep";
            txtNgheNghiep.ReadOnly = true;
            txtNgheNghiep.Size = new Size(178, 27);
            txtNgheNghiep.TabIndex = 36;
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.White;
            txtCCCD.BorderStyle = BorderStyle.FixedSingle;
            txtCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(212, 99);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.ReadOnly = true;
            txtCCCD.Size = new Size(515, 34);
            txtCCCD.TabIndex = 35;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BackColor = Color.White;
            txtHoVaTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoVaTen.Location = new Point(212, 51);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.ReadOnly = true;
            txtHoVaTen.Size = new Size(569, 34);
            txtHoVaTen.TabIndex = 34;
            // 
            // lblMaThue
            // 
            lblMaThue.AutoSize = true;
            lblMaThue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaThue.Location = new Point(461, 600);
            lblMaThue.Name = "lblMaThue";
            lblMaThue.Size = new Size(91, 28);
            lblMaThue.TabIndex = 33;
            lblMaThue.Text = "Mã thuế";
            // 
            // lblMaHoKhau
            // 
            lblMaHoKhau.AutoSize = true;
            lblMaHoKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHoKhau.Location = new Point(30, 600);
            lblMaHoKhau.Name = "lblMaHoKhau";
            lblMaHoKhau.Size = new Size(124, 28);
            lblMaHoKhau.TabIndex = 32;
            lblMaHoKhau.Text = "Mã hộ khẩu";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiaChi.Location = new Point(30, 450);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(78, 28);
            lblDiaChi.TabIndex = 31;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // sideBarWhite
            // 
            sideBarWhite.Location = new Point(3, 3);
            sideBarWhite.Name = "sideBarWhite";
            sideBarWhite.Size = new Size(75, 27);
            sideBarWhite.TabIndex = 32;
            // 
            // titleBarWhite
            // 
            titleBarWhite.Location = new Point(786, 1);
            titleBarWhite.Name = "titleBarWhite";
            titleBarWhite.Size = new Size(60, 30);
            titleBarWhite.TabIndex = 33;
            // 
            // FThongTinCongDan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(838, 579);
            Controls.Add(titleBarWhite);
            Controls.Add(sideBarWhite);
            Controls.Add(pnlThongTinCD);
            Controls.Add(pnlTittleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FThongTinCongDan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FThongTinCongDan";
            Load += FThongTinCongDan_Load;
            pnlTittleBar.ResumeLayout(false);
            pnlTittleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptcHinhDaiDien).EndInit();
            pnlThongTinCD.ResumeLayout(false);
            pnlThongTinCD.PerformLayout();
            fpnlChucNang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTittleBar;
        private Panel pnlTittleBar;
        private PictureBox ptcHinhDaiDien;
        private Label lblTen;
        private Label lblCccd;
        private Label lblNgaySinh;
        private DateTimePicker dtmNgaySinh;
        private Label lblGioiTinh;
        private Label lblDanToc;
        private Label lblTonGiao;
        private Label lblTinhTrangHonNhan;
        private Label lblQueQuan;
        private Label lblNghe;
        private Label lblQuocTich;
        private Panel pnlThongTin;
        private Label lblSoDT;
        private Panel pnlThongTinCD;
        private TextBox txtTonGiao;
        private TextBox txtGioiTinh;
        private TextBox txtDanToc;
        private TextBox txtQuocTich;
        private TextBox txtMaThue;
        private TextBox txtMaHoKhau;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private TextBox txtNgheNghiep;
        private TextBox txtCCCD;
        private TextBox txtHoVaTen;
        private Label lblMaThue;
        private Label lblMaHoKhau;
        private Label lblDiaChi;
        private TextBox txtHonNhan;
        private Button btnKhaiSinh;
        private TextBox txtGhiChu;
        private Label lblGhiChu;
        private TextBox txtQueQuan;
        private Button btnHoKhau;
        private Button btnHonNhan;
        private Button btnThue;
        private SideBarWhite sideBarWhite;
        private TitleBarWhite titleBarWhite;
        private FlowLayoutPanel fpnlChucNang;
        private Button btnXacNhan;
        private Button btnSua;
        private Button btnReLoad;
        private Label lblQuanHeVoiChuHo;
        private TextBox txtQuanHeVoiChuHo;
        private OpenFileDialog ofdHinhDaiDien;
        private SaveFileDialog sfdHinhDaiDien;
        private Button btnThongTinCCCD;
    }
}