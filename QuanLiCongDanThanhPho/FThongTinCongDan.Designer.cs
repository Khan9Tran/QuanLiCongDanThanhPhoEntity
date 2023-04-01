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
            this.lblTittleBar = new System.Windows.Forms.Label();
            this.pnlTittleBar = new System.Windows.Forms.Panel();
            this.ptcHinhDaiDien = new System.Windows.Forms.PictureBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblCccd = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDanToc = new System.Windows.Forms.Label();
            this.lblTonGiao = new System.Windows.Forms.Label();
            this.lblTinhTrangHonNhan = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblNghe = new System.Windows.Forms.Label();
            this.lblQuocTich = new System.Windows.Forms.Label();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.pnlThongTinCD = new System.Windows.Forms.Panel();
            this.btnThongTinCCCD = new System.Windows.Forms.Button();
            this.lblQuanHeVoiChuHo = new System.Windows.Forms.Label();
            this.txtQuanHeVoiChuHo = new System.Windows.Forms.TextBox();
            this.fpnlChucNang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnHonNhan = new System.Windows.Forms.Button();
            this.btnThue = new System.Windows.Forms.Button();
            this.btnHoKhau = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnKhaiSinh = new System.Windows.Forms.Button();
            this.txtHonNhan = new System.Windows.Forms.TextBox();
            this.txtTonGiao = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.txtMaThue = new System.Windows.Forms.TextBox();
            this.txtMaHoKhau = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.lblMaThue = new System.Windows.Forms.Label();
            this.lblMaHoKhau = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.sideBarWhite = new QuanLiCongDanThanhPho.SideBarWhite();
            this.titleBarWhite = new QuanLiCongDanThanhPho.TitleBarWhite();
            this.ofdHinhDaiDien = new System.Windows.Forms.OpenFileDialog();
            this.sfdHinhDaiDien = new System.Windows.Forms.SaveFileDialog();
            this.pnlTittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHinhDaiDien)).BeginInit();
            this.pnlThongTinCD.SuspendLayout();
            this.fpnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTittleBar
            // 
            this.lblTittleBar.AutoSize = true;
            this.lblTittleBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTittleBar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTittleBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTittleBar.Location = new System.Drawing.Point(252, 19);
            this.lblTittleBar.Name = "lblTittleBar";
            this.lblTittleBar.Size = new System.Drawing.Size(330, 38);
            this.lblTittleBar.TabIndex = 0;
            this.lblTittleBar.Text = "THÔNG TIN CÔNG DÂN";
            // 
            // pnlTittleBar
            // 
            this.pnlTittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pnlTittleBar.Controls.Add(this.lblTittleBar);
            this.pnlTittleBar.Location = new System.Drawing.Point(4, 40);
            this.pnlTittleBar.Name = "pnlTittleBar";
            this.pnlTittleBar.Size = new System.Drawing.Size(833, 77);
            this.pnlTittleBar.TabIndex = 1;
            // 
            // ptcHinhDaiDien
            // 
            this.ptcHinhDaiDien.BackColor = System.Drawing.Color.White;
            this.ptcHinhDaiDien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptcHinhDaiDien.Enabled = false;
            this.ptcHinhDaiDien.Location = new System.Drawing.Point(474, 200);
            this.ptcHinhDaiDien.Name = "ptcHinhDaiDien";
            this.ptcHinhDaiDien.Size = new System.Drawing.Size(176, 228);
            this.ptcHinhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcHinhDaiDien.TabIndex = 2;
            this.ptcHinhDaiDien.TabStop = false;
            this.ptcHinhDaiDien.Click += new System.EventHandler(this.picCongDan_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTen.Location = new System.Drawing.Point(30, 50);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(104, 28);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Họ và tên";
            // 
            // lblCccd
            // 
            this.lblCccd.AutoSize = true;
            this.lblCccd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCccd.Location = new System.Drawing.Point(30, 100);
            this.lblCccd.Name = "lblCccd";
            this.lblCccd.Size = new System.Drawing.Size(61, 28);
            this.lblCccd.TabIndex = 5;
            this.lblCccd.Text = "CCCD";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgaySinh.Location = new System.Drawing.Point(30, 150);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(107, 28);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.CalendarTitleBackColor = System.Drawing.Color.IndianRed;
            this.dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaySinh.Enabled = false;
            this.dtmNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaySinh.Location = new System.Drawing.Point(212, 144);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(174, 34);
            this.dtmNgaySinh.TabIndex = 8;
            this.dtmNgaySinh.Value = new System.DateTime(2023, 2, 28, 0, 0, 0, 0);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGioiTinh.Location = new System.Drawing.Point(30, 200);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(95, 28);
            this.lblGioiTinh.TabIndex = 9;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDanToc.Location = new System.Drawing.Point(30, 350);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(86, 28);
            this.lblDanToc.TabIndex = 11;
            this.lblDanToc.Text = "Dân tộc";
            // 
            // lblTonGiao
            // 
            this.lblTonGiao.AutoSize = true;
            this.lblTonGiao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTonGiao.Location = new System.Drawing.Point(30, 400);
            this.lblTonGiao.Name = "lblTonGiao";
            this.lblTonGiao.Size = new System.Drawing.Size(93, 28);
            this.lblTonGiao.TabIndex = 13;
            this.lblTonGiao.Text = "Tôn giáo";
            // 
            // lblTinhTrangHonNhan
            // 
            this.lblTinhTrangHonNhan.AutoSize = true;
            this.lblTinhTrangHonNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTinhTrangHonNhan.Location = new System.Drawing.Point(30, 700);
            this.lblTinhTrangHonNhan.Name = "lblTinhTrangHonNhan";
            this.lblTinhTrangHonNhan.Size = new System.Drawing.Size(104, 28);
            this.lblTinhTrangHonNhan.TabIndex = 17;
            this.lblTinhTrangHonNhan.Text = "Hôn nhân";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQueQuan.Location = new System.Drawing.Point(30, 500);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(103, 28);
            this.lblQueQuan.TabIndex = 19;
            this.lblQueQuan.Text = "Quê quán";
            // 
            // lblNghe
            // 
            this.lblNghe.AutoSize = true;
            this.lblNghe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNghe.Location = new System.Drawing.Point(30, 250);
            this.lblNghe.Name = "lblNghe";
            this.lblNghe.Size = new System.Drawing.Size(134, 28);
            this.lblNghe.TabIndex = 27;
            this.lblNghe.Text = "Nghề nghiệp";
            // 
            // lblQuocTich
            // 
            this.lblQuocTich.AutoSize = true;
            this.lblQuocTich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuocTich.Location = new System.Drawing.Point(30, 300);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new System.Drawing.Size(103, 28);
            this.lblQuocTich.TabIndex = 15;
            this.lblQuocTich.Text = "Quốc tịch";
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.BackColor = System.Drawing.Color.White;
            this.pnlThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTin.Location = new System.Drawing.Point(0, 42);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(1200, 678);
            this.pnlThongTin.TabIndex = 29;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.BackColor = System.Drawing.Color.Transparent;
            this.lblSoDT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoDT.Image = global::QuanLiCongDanThanhPho.Properties.Resources.call;
            this.lblSoDT.Location = new System.Drawing.Point(30, 550);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(56, 32);
            this.lblSoDT.TabIndex = 30;
            this.lblSoDT.Text = "      ";
            // 
            // pnlThongTinCD
            // 
            this.pnlThongTinCD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlThongTinCD.Controls.Add(this.btnThongTinCCCD);
            this.pnlThongTinCD.Controls.Add(this.lblQuanHeVoiChuHo);
            this.pnlThongTinCD.Controls.Add(this.txtQuanHeVoiChuHo);
            this.pnlThongTinCD.Controls.Add(this.fpnlChucNang);
            this.pnlThongTinCD.Controls.Add(this.btnHonNhan);
            this.pnlThongTinCD.Controls.Add(this.btnThue);
            this.pnlThongTinCD.Controls.Add(this.btnHoKhau);
            this.pnlThongTinCD.Controls.Add(this.ptcHinhDaiDien);
            this.pnlThongTinCD.Controls.Add(this.txtGhiChu);
            this.pnlThongTinCD.Controls.Add(this.lblGhiChu);
            this.pnlThongTinCD.Controls.Add(this.btnKhaiSinh);
            this.pnlThongTinCD.Controls.Add(this.txtHonNhan);
            this.pnlThongTinCD.Controls.Add(this.txtTonGiao);
            this.pnlThongTinCD.Controls.Add(this.lblTinhTrangHonNhan);
            this.pnlThongTinCD.Controls.Add(this.txtGioiTinh);
            this.pnlThongTinCD.Controls.Add(this.txtDanToc);
            this.pnlThongTinCD.Controls.Add(this.txtQuocTich);
            this.pnlThongTinCD.Controls.Add(this.txtMaThue);
            this.pnlThongTinCD.Controls.Add(this.txtMaHoKhau);
            this.pnlThongTinCD.Controls.Add(this.txtSDT);
            this.pnlThongTinCD.Controls.Add(this.txtQueQuan);
            this.pnlThongTinCD.Controls.Add(this.txtDiaChi);
            this.pnlThongTinCD.Controls.Add(this.txtNgheNghiep);
            this.pnlThongTinCD.Controls.Add(this.txtCCCD);
            this.pnlThongTinCD.Controls.Add(this.txtHoVaTen);
            this.pnlThongTinCD.Controls.Add(this.lblMaThue);
            this.pnlThongTinCD.Controls.Add(this.lblMaHoKhau);
            this.pnlThongTinCD.Controls.Add(this.lblDiaChi);
            this.pnlThongTinCD.Controls.Add(this.lblTen);
            this.pnlThongTinCD.Controls.Add(this.lblSoDT);
            this.pnlThongTinCD.Controls.Add(this.lblNghe);
            this.pnlThongTinCD.Controls.Add(this.lblQuocTich);
            this.pnlThongTinCD.Controls.Add(this.lblCccd);
            this.pnlThongTinCD.Controls.Add(this.lblTonGiao);
            this.pnlThongTinCD.Controls.Add(this.lblQueQuan);
            this.pnlThongTinCD.Controls.Add(this.lblGioiTinh);
            this.pnlThongTinCD.Controls.Add(this.lblNgaySinh);
            this.pnlThongTinCD.Controls.Add(this.dtmNgaySinh);
            this.pnlThongTinCD.Controls.Add(this.lblDanToc);
            this.pnlThongTinCD.Location = new System.Drawing.Point(4, 113);
            this.pnlThongTinCD.Name = "pnlThongTinCD";
            this.pnlThongTinCD.Size = new System.Drawing.Size(833, 797);
            this.pnlThongTinCD.TabIndex = 31;
            // 
            // btnThongTinCCCD
            // 
            this.btnThongTinCCCD.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTinCCCD.FlatAppearance.BorderSize = 0;
            this.btnThongTinCCCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinCCCD.Image = global::QuanLiCongDanThanhPho.Properties.Resources.view;
            this.btnThongTinCCCD.Location = new System.Drawing.Point(739, 99);
            this.btnThongTinCCCD.Name = "btnThongTinCCCD";
            this.btnThongTinCCCD.Size = new System.Drawing.Size(50, 27);
            this.btnThongTinCCCD.TabIndex = 102;
            this.btnThongTinCCCD.UseVisualStyleBackColor = false;
            this.btnThongTinCCCD.Click += new System.EventHandler(this.btnThongTinCCCD_Click);
            // 
            // lblQuanHeVoiChuHo
            // 
            this.lblQuanHeVoiChuHo.AutoSize = true;
            this.lblQuanHeVoiChuHo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuanHeVoiChuHo.Location = new System.Drawing.Point(30, 650);
            this.lblQuanHeVoiChuHo.Name = "lblQuanHeVoiChuHo";
            this.lblQuanHeVoiChuHo.Size = new System.Drawing.Size(197, 28);
            this.lblQuanHeVoiChuHo.TabIndex = 101;
            this.lblQuanHeVoiChuHo.Text = "Quan hệ với chủ hộ";
            // 
            // txtQuanHeVoiChuHo
            // 
            this.txtQuanHeVoiChuHo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtQuanHeVoiChuHo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuanHeVoiChuHo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuanHeVoiChuHo.Location = new System.Drawing.Point(261, 650);
            this.txtQuanHeVoiChuHo.Name = "txtQuanHeVoiChuHo";
            this.txtQuanHeVoiChuHo.ReadOnly = true;
            this.txtQuanHeVoiChuHo.Size = new System.Drawing.Size(530, 27);
            this.txtQuanHeVoiChuHo.TabIndex = 100;
            // 
            // fpnlChucNang
            // 
            this.fpnlChucNang.Controls.Add(this.btnXacNhan);
            this.fpnlChucNang.Controls.Add(this.btnSua);
            this.fpnlChucNang.Controls.Add(this.btnReLoad);
            this.fpnlChucNang.Location = new System.Drawing.Point(716, 144);
            this.fpnlChucNang.Name = "fpnlChucNang";
            this.fpnlChucNang.Size = new System.Drawing.Size(65, 284);
            this.fpnlChucNang.TabIndex = 99;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Image = global::QuanLiCongDanThanhPho.Properties.Resources.confirm;
            this.btnXacNhan.Location = new System.Drawing.Point(3, 3);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(50, 50);
            this.btnXacNhan.TabIndex = 109;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = global::QuanLiCongDanThanhPho.Properties.Resources.edit__2_;
            this.btnSua.Location = new System.Drawing.Point(3, 59);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(50, 50);
            this.btnSua.TabIndex = 100;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnReLoad.FlatAppearance.BorderSize = 0;
            this.btnReLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReLoad.ForeColor = System.Drawing.Color.White;
            this.btnReLoad.Image = global::QuanLiCongDanThanhPho.Properties.Resources.reset;
            this.btnReLoad.Location = new System.Drawing.Point(3, 115);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(50, 50);
            this.btnReLoad.TabIndex = 110;
            this.btnReLoad.UseVisualStyleBackColor = false;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnHonNhan
            // 
            this.btnHonNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnHonNhan.FlatAppearance.BorderSize = 0;
            this.btnHonNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHonNhan.Image = global::QuanLiCongDanThanhPho.Properties.Resources.view;
            this.btnHonNhan.Location = new System.Drawing.Point(742, 699);
            this.btnHonNhan.Name = "btnHonNhan";
            this.btnHonNhan.Size = new System.Drawing.Size(50, 35);
            this.btnHonNhan.TabIndex = 98;
            this.btnHonNhan.UseVisualStyleBackColor = false;
            this.btnHonNhan.Click += new System.EventHandler(this.btnHonNhan_Click);
            // 
            // btnThue
            // 
            this.btnThue.BackColor = System.Drawing.Color.Transparent;
            this.btnThue.FlatAppearance.BorderSize = 0;
            this.btnThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThue.Image = global::QuanLiCongDanThanhPho.Properties.Resources.view;
            this.btnThue.Location = new System.Drawing.Point(748, 600);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(50, 35);
            this.btnThue.TabIndex = 97;
            this.btnThue.UseVisualStyleBackColor = false;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // btnHoKhau
            // 
            this.btnHoKhau.BackColor = System.Drawing.Color.Transparent;
            this.btnHoKhau.FlatAppearance.BorderSize = 0;
            this.btnHoKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoKhau.Image = global::QuanLiCongDanThanhPho.Properties.Resources.view;
            this.btnHoKhau.Location = new System.Drawing.Point(399, 596);
            this.btnHoKhau.Name = "btnHoKhau";
            this.btnHoKhau.Size = new System.Drawing.Size(50, 35);
            this.btnHoKhau.TabIndex = 96;
            this.btnHoKhau.UseVisualStyleBackColor = false;
            this.btnHoKhau.Click += new System.EventHandler(this.btnHoKhau_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGhiChu.Location = new System.Drawing.Point(212, 758);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(525, 27);
            this.txtGhiChu.TabIndex = 52;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGhiChu.Location = new System.Drawing.Point(30, 750);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(113, 28);
            this.lblGhiChu.TabIndex = 51;
            this.lblGhiChu.Text = "Ghi chú (*)";
            // 
            // btnKhaiSinh
            // 
            this.btnKhaiSinh.BackColor = System.Drawing.Color.White;
            this.btnKhaiSinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKhaiSinh.ForeColor = System.Drawing.Color.Black;
            this.btnKhaiSinh.Location = new System.Drawing.Point(474, 140);
            this.btnKhaiSinh.Name = "btnKhaiSinh";
            this.btnKhaiSinh.Size = new System.Drawing.Size(176, 47);
            this.btnKhaiSinh.TabIndex = 50;
            this.btnKhaiSinh.Text = "Khai Sinh";
            this.btnKhaiSinh.UseVisualStyleBackColor = false;
            this.btnKhaiSinh.Click += new System.EventHandler(this.btnKhaiSinh_Click);
            // 
            // txtHonNhan
            // 
            this.txtHonNhan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHonNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHonNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHonNhan.Location = new System.Drawing.Point(212, 700);
            this.txtHonNhan.Name = "txtHonNhan";
            this.txtHonNhan.ReadOnly = true;
            this.txtHonNhan.Size = new System.Drawing.Size(525, 27);
            this.txtHonNhan.TabIndex = 46;
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTonGiao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTonGiao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTonGiao.Location = new System.Drawing.Point(212, 400);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.ReadOnly = true;
            this.txtTonGiao.Size = new System.Drawing.Size(178, 27);
            this.txtTonGiao.TabIndex = 45;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGioiTinh.Location = new System.Drawing.Point(212, 200);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(178, 27);
            this.txtGioiTinh.TabIndex = 44;
            // 
            // txtDanToc
            // 
            this.txtDanToc.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDanToc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDanToc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDanToc.Location = new System.Drawing.Point(212, 350);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.ReadOnly = true;
            this.txtDanToc.Size = new System.Drawing.Size(178, 27);
            this.txtDanToc.TabIndex = 43;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.BackColor = System.Drawing.Color.Gainsboro;
            this.txtQuocTich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuocTich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuocTich.Location = new System.Drawing.Point(212, 300);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.ReadOnly = true;
            this.txtQuocTich.Size = new System.Drawing.Size(178, 27);
            this.txtQuocTich.TabIndex = 42;
            // 
            // txtMaThue
            // 
            this.txtMaThue.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaThue.Location = new System.Drawing.Point(564, 600);
            this.txtMaThue.Name = "txtMaThue";
            this.txtMaThue.ReadOnly = true;
            this.txtMaThue.Size = new System.Drawing.Size(174, 27);
            this.txtMaThue.TabIndex = 41;
            // 
            // txtMaHoKhau
            // 
            this.txtMaHoKhau.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaHoKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHoKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHoKhau.Location = new System.Drawing.Point(212, 600);
            this.txtMaHoKhau.Name = "txtMaHoKhau";
            this.txtMaHoKhau.ReadOnly = true;
            this.txtMaHoKhau.Size = new System.Drawing.Size(174, 27);
            this.txtMaHoKhau.TabIndex = 40;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSDT.Location = new System.Drawing.Point(212, 550);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(570, 27);
            this.txtSDT.TabIndex = 39;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtQueQuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQueQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQueQuan.Location = new System.Drawing.Point(212, 500);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.ReadOnly = true;
            this.txtQueQuan.Size = new System.Drawing.Size(570, 27);
            this.txtQueQuan.TabIndex = 38;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiaChi.Location = new System.Drawing.Point(212, 450);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(569, 27);
            this.txtDiaChi.TabIndex = 37;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNgheNghiep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgheNghiep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNgheNghiep.Location = new System.Drawing.Point(212, 251);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.ReadOnly = true;
            this.txtNgheNghiep.Size = new System.Drawing.Size(178, 27);
            this.txtNgheNghiep.TabIndex = 36;
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCCCD.Location = new System.Drawing.Point(212, 99);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.ReadOnly = true;
            this.txtCCCD.Size = new System.Drawing.Size(521, 27);
            this.txtCCCD.TabIndex = 35;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHoVaTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoVaTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoVaTen.Location = new System.Drawing.Point(212, 51);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.ReadOnly = true;
            this.txtHoVaTen.Size = new System.Drawing.Size(569, 27);
            this.txtHoVaTen.TabIndex = 34;
            // 
            // lblMaThue
            // 
            this.lblMaThue.AutoSize = true;
            this.lblMaThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaThue.Location = new System.Drawing.Point(461, 600);
            this.lblMaThue.Name = "lblMaThue";
            this.lblMaThue.Size = new System.Drawing.Size(91, 28);
            this.lblMaThue.TabIndex = 33;
            this.lblMaThue.Text = "Mã thuế";
            // 
            // lblMaHoKhau
            // 
            this.lblMaHoKhau.AutoSize = true;
            this.lblMaHoKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaHoKhau.Location = new System.Drawing.Point(30, 600);
            this.lblMaHoKhau.Name = "lblMaHoKhau";
            this.lblMaHoKhau.Size = new System.Drawing.Size(124, 28);
            this.lblMaHoKhau.TabIndex = 32;
            this.lblMaHoKhau.Text = "Mã hộ khẩu";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.Location = new System.Drawing.Point(30, 450);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(78, 28);
            this.lblDiaChi.TabIndex = 31;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // sideBarWhite
            // 
            this.sideBarWhite.Location = new System.Drawing.Point(3, 3);
            this.sideBarWhite.Name = "sideBarWhite";
            this.sideBarWhite.Size = new System.Drawing.Size(75, 27);
            this.sideBarWhite.TabIndex = 32;
            // 
            // titleBarWhite
            // 
            this.titleBarWhite.Location = new System.Drawing.Point(786, 1);
            this.titleBarWhite.Name = "titleBarWhite";
            this.titleBarWhite.Size = new System.Drawing.Size(60, 30);
            this.titleBarWhite.TabIndex = 33;
            // 
            // FThongTinCongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(838, 579);
            this.Controls.Add(this.titleBarWhite);
            this.Controls.Add(this.sideBarWhite);
            this.Controls.Add(this.pnlThongTinCD);
            this.Controls.Add(this.pnlTittleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThongTinCongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FThongTinCongDan";
            this.Load += new System.EventHandler(this.FThongTinCongDan_Load);
            this.pnlTittleBar.ResumeLayout(false);
            this.pnlTittleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHinhDaiDien)).EndInit();
            this.pnlThongTinCD.ResumeLayout(false);
            this.pnlThongTinCD.PerformLayout();
            this.fpnlChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

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