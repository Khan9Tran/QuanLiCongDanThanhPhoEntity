namespace QuanLiCongDanThanhPho
{
    partial class FThongTinHoKhau
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
            pnlTren = new Panel();
            lblTieuDe = new Label();
            pnlHienThongTin = new Panel();
            lblTong = new Label();
            fpnlChucNang = new FlowLayoutPanel();
            btnXacNhan = new Button();
            btnSua = new Button();
            btnReLoad = new Button();
            lblQuanHe = new Label();
            gvQuanHeVoiChuHo = new DataGridView();
            txtDiaChi = new TextBox();
            txtCCCDChuHo = new TextBox();
            txtTenChuHo = new TextBox();
            txtMaHoKhau = new TextBox();
            lblDiaChi = new Label();
            lblMaHoKhau = new Label();
            lblCCCDChuHo = new Label();
            lblTenChuHo = new Label();
            sideBarWhite1 = new SideBarWhite();
            titleBarWhite1 = new TitleBarWhite();
            pnlTren.SuspendLayout();
            pnlHienThongTin.SuspendLayout();
            fpnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvQuanHeVoiChuHo).BeginInit();
            SuspendLayout();
            // 
            // pnlTren
            // 
            pnlTren.BackColor = Color.RoyalBlue;
            pnlTren.Controls.Add(lblTieuDe);
            pnlTren.Location = new Point(5, 32);
            pnlTren.Name = "pnlTren";
            pnlTren.Size = new Size(828, 72);
            pnlTren.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.ForeColor = Color.WhiteSmoke;
            lblTieuDe.Location = new Point(346, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(146, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "HỘ KHẨU";
            // 
            // pnlHienThongTin
            // 
            pnlHienThongTin.BackColor = Color.WhiteSmoke;
            pnlHienThongTin.Controls.Add(lblTong);
            pnlHienThongTin.Controls.Add(fpnlChucNang);
            pnlHienThongTin.Controls.Add(lblQuanHe);
            pnlHienThongTin.Controls.Add(gvQuanHeVoiChuHo);
            pnlHienThongTin.Controls.Add(txtDiaChi);
            pnlHienThongTin.Controls.Add(txtCCCDChuHo);
            pnlHienThongTin.Controls.Add(txtTenChuHo);
            pnlHienThongTin.Controls.Add(txtMaHoKhau);
            pnlHienThongTin.Controls.Add(lblDiaChi);
            pnlHienThongTin.Controls.Add(lblMaHoKhau);
            pnlHienThongTin.Controls.Add(lblCCCDChuHo);
            pnlHienThongTin.Controls.Add(lblTenChuHo);
            pnlHienThongTin.Location = new Point(5, 105);
            pnlHienThongTin.Name = "pnlHienThongTin";
            pnlHienThongTin.Size = new Size(828, 517);
            pnlHienThongTin.TabIndex = 1;
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTong.Location = new Point(514, 220);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(172, 28);
            lblTong.TabIndex = 98;
            lblTong.Text = "Tổng thành viên:";
            // 
            // fpnlChucNang
            // 
            fpnlChucNang.Controls.Add(btnXacNhan);
            fpnlChucNang.Controls.Add(btnSua);
            fpnlChucNang.Controls.Add(btnReLoad);
            fpnlChucNang.Location = new Point(638, 452);
            fpnlChucNang.Name = "fpnlChucNang";
            fpnlChucNang.Size = new Size(190, 59);
            fpnlChucNang.TabIndex = 97;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Transparent;
            btnXacNhan.Enabled = false;
            btnXacNhan.FlatAppearance.BorderSize = 0;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Image = Properties.Resources.accept;
            btnXacNhan.Location = new Point(3, 3);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(50, 50);
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
            btnSua.Location = new Point(59, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(50, 50);
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
            btnReLoad.Location = new Point(115, 3);
            btnReLoad.Name = "btnReLoad";
            btnReLoad.Size = new Size(50, 50);
            btnReLoad.TabIndex = 110;
            btnReLoad.UseVisualStyleBackColor = false;
            btnReLoad.Click += btnReLoad_Click;
            // 
            // lblQuanHe
            // 
            lblQuanHe.AutoSize = true;
            lblQuanHe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuanHe.Location = new Point(20, 220);
            lblQuanHe.Name = "lblQuanHe";
            lblQuanHe.Size = new Size(197, 28);
            lblQuanHe.TabIndex = 11;
            lblQuanHe.Text = "Quan hệ với chủ hộ";
            // 
            // gvQuanHeVoiChuHo
            // 
            gvQuanHeVoiChuHo.BackgroundColor = Color.WhiteSmoke;
            gvQuanHeVoiChuHo.BorderStyle = BorderStyle.None;
            gvQuanHeVoiChuHo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvQuanHeVoiChuHo.Location = new Point(94, 258);
            gvQuanHeVoiChuHo.Name = "gvQuanHeVoiChuHo";
            gvQuanHeVoiChuHo.RowHeadersWidth = 51;
            gvQuanHeVoiChuHo.RowTemplate.Height = 29;
            gvQuanHeVoiChuHo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvQuanHeVoiChuHo.Size = new Size(684, 201);
            gvQuanHeVoiChuHo.TabIndex = 10;
            gvQuanHeVoiChuHo.CellClick += gvQuanHeVoiChuHo_CellClick;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.Gainsboro;
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.ForeColor = Color.Black;
            txtDiaChi.Location = new Point(259, 170);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(519, 27);
            txtDiaChi.TabIndex = 9;
            txtDiaChi.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCCCDChuHo
            // 
            txtCCCDChuHo.BackColor = Color.Gainsboro;
            txtCCCDChuHo.BorderStyle = BorderStyle.None;
            txtCCCDChuHo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCDChuHo.ForeColor = Color.Black;
            txtCCCDChuHo.Location = new Point(259, 120);
            txtCCCDChuHo.Name = "txtCCCDChuHo";
            txtCCCDChuHo.ReadOnly = true;
            txtCCCDChuHo.Size = new Size(519, 27);
            txtCCCDChuHo.TabIndex = 8;
            txtCCCDChuHo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTenChuHo
            // 
            txtTenChuHo.BackColor = Color.Gainsboro;
            txtTenChuHo.BorderStyle = BorderStyle.None;
            txtTenChuHo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenChuHo.ForeColor = Color.Black;
            txtTenChuHo.Location = new Point(259, 70);
            txtTenChuHo.Name = "txtTenChuHo";
            txtTenChuHo.ReadOnly = true;
            txtTenChuHo.Size = new Size(519, 27);
            txtTenChuHo.TabIndex = 7;
            txtTenChuHo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMaHoKhau
            // 
            txtMaHoKhau.BackColor = Color.Gainsboro;
            txtMaHoKhau.BorderStyle = BorderStyle.None;
            txtMaHoKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHoKhau.ForeColor = Color.Black;
            txtMaHoKhau.Location = new Point(259, 20);
            txtMaHoKhau.Name = "txtMaHoKhau";
            txtMaHoKhau.ReadOnly = true;
            txtMaHoKhau.Size = new Size(519, 27);
            txtMaHoKhau.TabIndex = 6;
            txtMaHoKhau.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiaChi.Location = new Point(20, 170);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(78, 28);
            lblDiaChi.TabIndex = 5;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblMaHoKhau
            // 
            lblMaHoKhau.AutoSize = true;
            lblMaHoKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHoKhau.Location = new Point(20, 20);
            lblMaHoKhau.Name = "lblMaHoKhau";
            lblMaHoKhau.Size = new Size(124, 28);
            lblMaHoKhau.TabIndex = 4;
            lblMaHoKhau.Text = "Mã hộ khẩu";
            // 
            // lblCCCDChuHo
            // 
            lblCCCDChuHo.AutoSize = true;
            lblCCCDChuHo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCCCDChuHo.Location = new Point(20, 120);
            lblCCCDChuHo.Name = "lblCCCDChuHo";
            lblCCCDChuHo.Size = new Size(61, 28);
            lblCCCDChuHo.TabIndex = 3;
            lblCCCDChuHo.Text = "CCCD";
            // 
            // lblTenChuHo
            // 
            lblTenChuHo.AutoSize = true;
            lblTenChuHo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenChuHo.Location = new Point(20, 70);
            lblTenChuHo.Name = "lblTenChuHo";
            lblTenChuHo.Size = new Size(115, 28);
            lblTenChuHo.TabIndex = 2;
            lblTenChuHo.Text = "Tên chủ hộ";
            // 
            // sideBarWhite1
            // 
            sideBarWhite1.Location = new Point(5, 2);
            sideBarWhite1.Name = "sideBarWhite1";
            sideBarWhite1.Size = new Size(75, 29);
            sideBarWhite1.TabIndex = 2;
            // 
            // titleBarWhite1
            // 
            titleBarWhite1.Location = new Point(783, 2);
            titleBarWhite1.Name = "titleBarWhite1";
            titleBarWhite1.Size = new Size(60, 27);
            titleBarWhite1.TabIndex = 3;
            // 
            // FThongTinHoKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(838, 628);
            Controls.Add(titleBarWhite1);
            Controls.Add(sideBarWhite1);
            Controls.Add(pnlHienThongTin);
            Controls.Add(pnlTren);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FThongTinHoKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HoKhau";
            Load += FThongTinHoKhau_Load;
            pnlTren.ResumeLayout(false);
            pnlTren.PerformLayout();
            pnlHienThongTin.ResumeLayout(false);
            pnlHienThongTin.PerformLayout();
            fpnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvQuanHeVoiChuHo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTren;
        private Panel pnlHienThongTin;
        private Label lblDiaChi;
        private Label lblMaHoKhau;
        private Label lblCCCDChuHo;
        private Label lblTenChuHo;
        private Label lblQuanHe;
        private DataGridView gvQuanHeVoiChuHo;
        private TextBox txtDiaChi;
        private TextBox txtCCCDChuHo;
        private TextBox txtTenChuHo;
        private TextBox txtMaHoKhau;
        private Label lblTieuDe;
        private SideBarWhite sideBarWhite1;
        private TitleBarWhite titleBarWhite1;
        private FlowLayoutPanel fpnlChucNang;
        private Button btnXacNhan;
        private Button btnSua;
        private Button btnReLoad;
        private Label lblTong;
    }
}