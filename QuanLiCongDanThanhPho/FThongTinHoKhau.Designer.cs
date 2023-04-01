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
            this.pnlTren = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlHienThongTin = new System.Windows.Forms.Panel();
            this.lblTong = new System.Windows.Forms.Label();
            this.fpnlChucNang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.lblQuanHe = new System.Windows.Forms.Label();
            this.gvQuanHeVoiChuHo = new System.Windows.Forms.DataGridView();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCCCDChuHo = new System.Windows.Forms.TextBox();
            this.txtTenChuHo = new System.Windows.Forms.TextBox();
            this.txtMaHoKhau = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMaHoKhau = new System.Windows.Forms.Label();
            this.lblCCCDChuHo = new System.Windows.Forms.Label();
            this.lblTenChuHo = new System.Windows.Forms.Label();
            this.sideBarWhite1 = new QuanLiCongDanThanhPho.SideBarWhite();
            this.titleBarWhite1 = new QuanLiCongDanThanhPho.TitleBarWhite();
            this.pnlTren.SuspendLayout();
            this.pnlHienThongTin.SuspendLayout();
            this.fpnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanHeVoiChuHo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTren
            // 
            this.pnlTren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pnlTren.Controls.Add(this.lblTieuDe);
            this.pnlTren.Location = new System.Drawing.Point(5, 32);
            this.pnlTren.Name = "pnlTren";
            this.pnlTren.Size = new System.Drawing.Size(828, 72);
            this.pnlTren.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTieuDe.Location = new System.Drawing.Point(346, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(146, 38);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "HỘ KHẨU";
            // 
            // pnlHienThongTin
            // 
            this.pnlHienThongTin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHienThongTin.Controls.Add(this.lblTong);
            this.pnlHienThongTin.Controls.Add(this.fpnlChucNang);
            this.pnlHienThongTin.Controls.Add(this.lblQuanHe);
            this.pnlHienThongTin.Controls.Add(this.gvQuanHeVoiChuHo);
            this.pnlHienThongTin.Controls.Add(this.txtDiaChi);
            this.pnlHienThongTin.Controls.Add(this.txtCCCDChuHo);
            this.pnlHienThongTin.Controls.Add(this.txtTenChuHo);
            this.pnlHienThongTin.Controls.Add(this.txtMaHoKhau);
            this.pnlHienThongTin.Controls.Add(this.lblDiaChi);
            this.pnlHienThongTin.Controls.Add(this.lblMaHoKhau);
            this.pnlHienThongTin.Controls.Add(this.lblCCCDChuHo);
            this.pnlHienThongTin.Controls.Add(this.lblTenChuHo);
            this.pnlHienThongTin.Location = new System.Drawing.Point(5, 105);
            this.pnlHienThongTin.Name = "pnlHienThongTin";
            this.pnlHienThongTin.Size = new System.Drawing.Size(828, 517);
            this.pnlHienThongTin.TabIndex = 1;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTong.Location = new System.Drawing.Point(514, 220);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(172, 28);
            this.lblTong.TabIndex = 98;
            this.lblTong.Text = "Tổng thành viên:";
            // 
            // fpnlChucNang
            // 
            this.fpnlChucNang.Controls.Add(this.btnXacNhan);
            this.fpnlChucNang.Controls.Add(this.btnSua);
            this.fpnlChucNang.Controls.Add(this.btnReLoad);
            this.fpnlChucNang.Location = new System.Drawing.Point(638, 452);
            this.fpnlChucNang.Name = "fpnlChucNang";
            this.fpnlChucNang.Size = new System.Drawing.Size(190, 59);
            this.fpnlChucNang.TabIndex = 97;
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
            this.btnSua.Location = new System.Drawing.Point(59, 3);
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
            this.btnReLoad.Location = new System.Drawing.Point(115, 3);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(50, 50);
            this.btnReLoad.TabIndex = 110;
            this.btnReLoad.UseVisualStyleBackColor = false;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // lblQuanHe
            // 
            this.lblQuanHe.AutoSize = true;
            this.lblQuanHe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuanHe.Location = new System.Drawing.Point(20, 220);
            this.lblQuanHe.Name = "lblQuanHe";
            this.lblQuanHe.Size = new System.Drawing.Size(197, 28);
            this.lblQuanHe.TabIndex = 11;
            this.lblQuanHe.Text = "Quan hệ với chủ hộ";
            // 
            // gvQuanHeVoiChuHo
            // 
            this.gvQuanHeVoiChuHo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvQuanHeVoiChuHo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvQuanHeVoiChuHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQuanHeVoiChuHo.Location = new System.Drawing.Point(94, 258);
            this.gvQuanHeVoiChuHo.Name = "gvQuanHeVoiChuHo";
            this.gvQuanHeVoiChuHo.RowHeadersWidth = 51;
            this.gvQuanHeVoiChuHo.RowTemplate.Height = 29;
            this.gvQuanHeVoiChuHo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvQuanHeVoiChuHo.Size = new System.Drawing.Size(684, 201);
            this.gvQuanHeVoiChuHo.TabIndex = 10;
            this.gvQuanHeVoiChuHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvQuanHeVoiChuHo_CellClick);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(259, 170);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(519, 27);
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCCCDChuHo
            // 
            this.txtCCCDChuHo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCCCDChuHo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCDChuHo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCCCDChuHo.ForeColor = System.Drawing.Color.Black;
            this.txtCCCDChuHo.Location = new System.Drawing.Point(259, 120);
            this.txtCCCDChuHo.Name = "txtCCCDChuHo";
            this.txtCCCDChuHo.ReadOnly = true;
            this.txtCCCDChuHo.Size = new System.Drawing.Size(519, 27);
            this.txtCCCDChuHo.TabIndex = 8;
            this.txtCCCDChuHo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenChuHo
            // 
            this.txtTenChuHo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenChuHo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenChuHo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenChuHo.ForeColor = System.Drawing.Color.Black;
            this.txtTenChuHo.Location = new System.Drawing.Point(259, 70);
            this.txtTenChuHo.Name = "txtTenChuHo";
            this.txtTenChuHo.ReadOnly = true;
            this.txtTenChuHo.Size = new System.Drawing.Size(519, 27);
            this.txtTenChuHo.TabIndex = 7;
            this.txtTenChuHo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaHoKhau
            // 
            this.txtMaHoKhau.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaHoKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHoKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHoKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMaHoKhau.Location = new System.Drawing.Point(259, 20);
            this.txtMaHoKhau.Name = "txtMaHoKhau";
            this.txtMaHoKhau.ReadOnly = true;
            this.txtMaHoKhau.Size = new System.Drawing.Size(519, 27);
            this.txtMaHoKhau.TabIndex = 6;
            this.txtMaHoKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.Location = new System.Drawing.Point(20, 170);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(78, 28);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblMaHoKhau
            // 
            this.lblMaHoKhau.AutoSize = true;
            this.lblMaHoKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaHoKhau.Location = new System.Drawing.Point(20, 20);
            this.lblMaHoKhau.Name = "lblMaHoKhau";
            this.lblMaHoKhau.Size = new System.Drawing.Size(124, 28);
            this.lblMaHoKhau.TabIndex = 4;
            this.lblMaHoKhau.Text = "Mã hộ khẩu";
            // 
            // lblCCCDChuHo
            // 
            this.lblCCCDChuHo.AutoSize = true;
            this.lblCCCDChuHo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCCCDChuHo.Location = new System.Drawing.Point(20, 120);
            this.lblCCCDChuHo.Name = "lblCCCDChuHo";
            this.lblCCCDChuHo.Size = new System.Drawing.Size(61, 28);
            this.lblCCCDChuHo.TabIndex = 3;
            this.lblCCCDChuHo.Text = "CCCD";
            // 
            // lblTenChuHo
            // 
            this.lblTenChuHo.AutoSize = true;
            this.lblTenChuHo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenChuHo.Location = new System.Drawing.Point(20, 70);
            this.lblTenChuHo.Name = "lblTenChuHo";
            this.lblTenChuHo.Size = new System.Drawing.Size(115, 28);
            this.lblTenChuHo.TabIndex = 2;
            this.lblTenChuHo.Text = "Tên chủ hộ";
            // 
            // sideBarWhite1
            // 
            this.sideBarWhite1.Location = new System.Drawing.Point(5, 2);
            this.sideBarWhite1.Name = "sideBarWhite1";
            this.sideBarWhite1.Size = new System.Drawing.Size(75, 29);
            this.sideBarWhite1.TabIndex = 2;
            // 
            // titleBarWhite1
            // 
            this.titleBarWhite1.Location = new System.Drawing.Point(783, 2);
            this.titleBarWhite1.Name = "titleBarWhite1";
            this.titleBarWhite1.Size = new System.Drawing.Size(60, 27);
            this.titleBarWhite1.TabIndex = 3;
            // 
            // FThongTinHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(838, 628);
            this.Controls.Add(this.titleBarWhite1);
            this.Controls.Add(this.sideBarWhite1);
            this.Controls.Add(this.pnlHienThongTin);
            this.Controls.Add(this.pnlTren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThongTinHoKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoKhau";
            this.Load += new System.EventHandler(this.FThongTinHoKhau_Load);
            this.pnlTren.ResumeLayout(false);
            this.pnlTren.PerformLayout();
            this.pnlHienThongTin.ResumeLayout(false);
            this.pnlHienThongTin.PerformLayout();
            this.fpnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanHeVoiChuHo)).EndInit();
            this.ResumeLayout(false);

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