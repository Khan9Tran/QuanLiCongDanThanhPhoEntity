namespace QuanLiCongDanThanhPho
{
    partial class FThongTinHonNhan
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
            pnlChong = new Panel();
            btnThongTinChong = new Button();
            txtCCCDChong = new TextBox();
            txtNoiDangKy = new TextBox();
            txtTenChong = new TextBox();
            lblCCCDChong = new Label();
            lblTenChong = new Label();
            lblNoiDangKy = new Label();
            btnXoa = new Button();
            lblNgayDangKy = new Label();
            pnlVo = new Panel();
            fpnlChucNang = new FlowLayoutPanel();
            btnXacNhan = new Button();
            btnSua = new Button();
            btnReLoad = new Button();
            btnThongTinVo = new Button();
            dtmNgayDangKy = new DateTimePicker();
            txtTenVo = new TextBox();
            txtCCCDVo = new TextBox();
            lblCCCDVo = new Label();
            lblTenVo = new Label();
            lblDeMuc2 = new Label();
            pnlTitle = new Panel();
            titleBarWhite1 = new TitleBarWhite();
            sideBarWhite1 = new SideBarWhite();
            pnlChong.SuspendLayout();
            pnlVo.SuspendLayout();
            fpnlChucNang.SuspendLayout();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChong
            // 
            pnlChong.BackColor = Color.WhiteSmoke;
            pnlChong.Controls.Add(btnThongTinChong);
            pnlChong.Controls.Add(txtCCCDChong);
            pnlChong.Controls.Add(txtNoiDangKy);
            pnlChong.Controls.Add(txtTenChong);
            pnlChong.Controls.Add(lblCCCDChong);
            pnlChong.Controls.Add(lblTenChong);
            pnlChong.Controls.Add(lblNoiDangKy);
            pnlChong.Location = new Point(4, 109);
            pnlChong.Name = "pnlChong";
            pnlChong.Size = new Size(596, 604);
            pnlChong.TabIndex = 2;
            // 
            // btnThongTinChong
            // 
            btnThongTinChong.BackColor = Color.Transparent;
            btnThongTinChong.FlatAppearance.BorderSize = 0;
            btnThongTinChong.FlatStyle = FlatStyle.Flat;
            btnThongTinChong.Image = Properties.Resources.view;
            btnThongTinChong.Location = new Point(515, 293);
            btnThongTinChong.Name = "btnThongTinChong";
            btnThongTinChong.Size = new Size(50, 50);
            btnThongTinChong.TabIndex = 95;
            btnThongTinChong.UseVisualStyleBackColor = false;
            btnThongTinChong.Click += btnThongTinChong_Click;
            // 
            // txtCCCDChong
            // 
            txtCCCDChong.BackColor = Color.Gainsboro;
            txtCCCDChong.BorderStyle = BorderStyle.None;
            txtCCCDChong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCDChong.Location = new Point(250, 150);
            txtCCCDChong.Name = "txtCCCDChong";
            txtCCCDChong.ReadOnly = true;
            txtCCCDChong.Size = new Size(315, 27);
            txtCCCDChong.TabIndex = 7;
            // 
            // txtNoiDangKy
            // 
            txtNoiDangKy.BackColor = Color.Gainsboro;
            txtNoiDangKy.BorderStyle = BorderStyle.None;
            txtNoiDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoiDangKy.Location = new Point(250, 250);
            txtNoiDangKy.Name = "txtNoiDangKy";
            txtNoiDangKy.ReadOnly = true;
            txtNoiDangKy.Size = new Size(315, 27);
            txtNoiDangKy.TabIndex = 6;
            // 
            // txtTenChong
            // 
            txtTenChong.BackColor = Color.Gainsboro;
            txtTenChong.BorderStyle = BorderStyle.None;
            txtTenChong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenChong.Location = new Point(250, 50);
            txtTenChong.Name = "txtTenChong";
            txtTenChong.ReadOnly = true;
            txtTenChong.Size = new Size(315, 27);
            txtTenChong.TabIndex = 5;
            // 
            // lblCCCDChong
            // 
            lblCCCDChong.AutoSize = true;
            lblCCCDChong.Location = new Point(50, 150);
            lblCCCDChong.Name = "lblCCCDChong";
            lblCCCDChong.Size = new Size(61, 28);
            lblCCCDChong.TabIndex = 2;
            lblCCCDChong.Text = "CCCD";
            // 
            // lblTenChong
            // 
            lblTenChong.AutoSize = true;
            lblTenChong.Location = new Point(50, 50);
            lblTenChong.Name = "lblTenChong";
            lblTenChong.Size = new Size(168, 28);
            lblTenChong.TabIndex = 1;
            lblTenChong.Text = "Họ và tên chồng";
            // 
            // lblNoiDangKy
            // 
            lblNoiDangKy.AutoSize = true;
            lblNoiDangKy.Location = new Point(50, 250);
            lblNoiDangKy.Name = "lblNoiDangKy";
            lblNoiDangKy.Size = new Size(129, 28);
            lblNoiDangKy.TabIndex = 0;
            lblNoiDangKy.Text = "Nơi đăng ký";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(427, 649);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 50);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa đăng ký";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // lblNgayDangKy
            // 
            lblNgayDangKy.AutoSize = true;
            lblNgayDangKy.Location = new Point(50, 250);
            lblNgayDangKy.Name = "lblNgayDangKy";
            lblNgayDangKy.Size = new Size(144, 28);
            lblNgayDangKy.TabIndex = 3;
            lblNgayDangKy.Text = "Ngày đăng ký";
            // 
            // pnlVo
            // 
            pnlVo.BackColor = Color.WhiteSmoke;
            pnlVo.Controls.Add(fpnlChucNang);
            pnlVo.Controls.Add(btnThongTinVo);
            pnlVo.Controls.Add(btnXoa);
            pnlVo.Controls.Add(dtmNgayDangKy);
            pnlVo.Controls.Add(txtTenVo);
            pnlVo.Controls.Add(txtCCCDVo);
            pnlVo.Controls.Add(lblCCCDVo);
            pnlVo.Controls.Add(lblNgayDangKy);
            pnlVo.Controls.Add(lblTenVo);
            pnlVo.Location = new Point(600, 109);
            pnlVo.Name = "pnlVo";
            pnlVo.Size = new Size(595, 604);
            pnlVo.TabIndex = 3;
            // 
            // fpnlChucNang
            // 
            fpnlChucNang.Controls.Add(btnXacNhan);
            fpnlChucNang.Controls.Add(btnSua);
            fpnlChucNang.Controls.Add(btnReLoad);
            fpnlChucNang.Location = new Point(405, 540);
            fpnlChucNang.Name = "fpnlChucNang";
            fpnlChucNang.Size = new Size(190, 59);
            fpnlChucNang.TabIndex = 96;
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
            // btnThongTinVo
            // 
            btnThongTinVo.BackColor = Color.Transparent;
            btnThongTinVo.FlatAppearance.BorderSize = 0;
            btnThongTinVo.FlatStyle = FlatStyle.Flat;
            btnThongTinVo.Image = Properties.Resources.view;
            btnThongTinVo.Location = new Point(506, 293);
            btnThongTinVo.Name = "btnThongTinVo";
            btnThongTinVo.Size = new Size(50, 50);
            btnThongTinVo.TabIndex = 95;
            btnThongTinVo.UseVisualStyleBackColor = false;
            btnThongTinVo.Click += btnThongTinVo_Click;
            // 
            // dtmNgayDangKy
            // 
            dtmNgayDangKy.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtmNgayDangKy.CalendarMonthBackground = Color.Gainsboro;
            dtmNgayDangKy.CustomFormat = "dd/MM/yyyy";
            dtmNgayDangKy.Enabled = false;
            dtmNgayDangKy.Format = DateTimePickerFormat.Short;
            dtmNgayDangKy.Location = new Point(241, 244);
            dtmNgayDangKy.Name = "dtmNgayDangKy";
            dtmNgayDangKy.Size = new Size(315, 34);
            dtmNgayDangKy.TabIndex = 6;
            dtmNgayDangKy.Value = new DateTime(2023, 2, 28, 0, 0, 0, 0);
            // 
            // txtTenVo
            // 
            txtTenVo.BackColor = Color.Gainsboro;
            txtTenVo.BorderStyle = BorderStyle.None;
            txtTenVo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenVo.Location = new Point(241, 50);
            txtTenVo.Name = "txtTenVo";
            txtTenVo.ReadOnly = true;
            txtTenVo.Size = new Size(315, 27);
            txtTenVo.TabIndex = 5;
            // 
            // txtCCCDVo
            // 
            txtCCCDVo.BackColor = Color.Gainsboro;
            txtCCCDVo.BorderStyle = BorderStyle.None;
            txtCCCDVo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCDVo.Location = new Point(241, 150);
            txtCCCDVo.Name = "txtCCCDVo";
            txtCCCDVo.ReadOnly = true;
            txtCCCDVo.Size = new Size(315, 27);
            txtCCCDVo.TabIndex = 4;
            // 
            // lblCCCDVo
            // 
            lblCCCDVo.AutoSize = true;
            lblCCCDVo.Location = new Point(50, 150);
            lblCCCDVo.Name = "lblCCCDVo";
            lblCCCDVo.Size = new Size(61, 28);
            lblCCCDVo.TabIndex = 3;
            lblCCCDVo.Text = "CCCD";
            // 
            // lblTenVo
            // 
            lblTenVo.AutoSize = true;
            lblTenVo.Location = new Point(50, 50);
            lblTenVo.Name = "lblTenVo";
            lblTenVo.Size = new Size(134, 28);
            lblTenVo.TabIndex = 2;
            lblTenVo.Text = "Họ và tên vợ";
            // 
            // lblDeMuc2
            // 
            lblDeMuc2.AutoSize = true;
            lblDeMuc2.BackColor = Color.Transparent;
            lblDeMuc2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeMuc2.ForeColor = Color.WhiteSmoke;
            lblDeMuc2.Location = new Point(520, 19);
            lblDeMuc2.Name = "lblDeMuc2";
            lblDeMuc2.Size = new Size(168, 37);
            lblDeMuc2.TabIndex = 1;
            lblDeMuc2.Text = "HÔN NHÂN";
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.RoyalBlue;
            pnlTitle.Controls.Add(lblDeMuc2);
            pnlTitle.Location = new Point(4, 32);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1194, 79);
            pnlTitle.TabIndex = 4;
            // 
            // titleBarWhite1
            // 
            titleBarWhite1.Location = new Point(1144, -3);
            titleBarWhite1.Name = "titleBarWhite1";
            titleBarWhite1.Size = new Size(70, 35);
            titleBarWhite1.TabIndex = 5;
            // 
            // sideBarWhite1
            // 
            sideBarWhite1.Location = new Point(4, -3);
            sideBarWhite1.Name = "sideBarWhite1";
            sideBarWhite1.Size = new Size(84, 35);
            sideBarWhite1.TabIndex = 6;
            // 
            // FThongTinHonNhan
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(1200, 720);
            Controls.Add(sideBarWhite1);
            Controls.Add(titleBarWhite1);
            Controls.Add(pnlTitle);
            Controls.Add(pnlVo);
            Controls.Add(pnlChong);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FThongTinHonNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += FThongTinHonNhan_Load;
            pnlChong.ResumeLayout(false);
            pnlChong.PerformLayout();
            pnlVo.ResumeLayout(false);
            pnlVo.PerformLayout();
            fpnlChucNang.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChong;
        private Panel pnlVo;
        private Label lblNgayDangKy;
        private Label lblCCCDChong;
        private Label lblTenChong;
        private Label lblNoiDangKy;
        private Label lblCCCDVo;
        private Label lblTenVo;
        private Label lblDeMuc2;
        private TextBox txtCCCDChong;
        private TextBox txtNoiDangKy;
        private TextBox txtTenChong;
        private DateTimePicker dtmNgayDangKy;
        private TextBox txtTenVo;
        private TextBox txtCCCDVo;
        private Button btnXoa;
        private Panel pnlTitle;
        private Button btnThongTinChong;
        private Button btnThongTinVo;
        private TitleBarWhite titleBarWhite1;
        private SideBarWhite sideBarWhite1;
        private Button btnSua;
        private Button btnXacNhan;
        private FlowLayoutPanel fpnlChucNang;
        private Button btnReLoad;
    }
}