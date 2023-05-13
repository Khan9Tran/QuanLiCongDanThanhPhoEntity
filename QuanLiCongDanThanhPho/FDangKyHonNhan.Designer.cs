namespace QuanLiCongDanThanhPho
{
    partial class FDangKyHonNhan
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
            lblTen = new Label();
            txtTenChong = new TextBox();
            txtTenVo = new TextBox();
            lblCCCD = new Label();
            txtCCCDChong = new TextBox();
            txtCCCDVo = new TextBox();
            dtpNgayDangKy = new DateTimePicker();
            lblNgayDangKy = new Label();
            lblChong = new Label();
            lblVo = new Label();
            btnTimChong = new Button();
            btnTimVo = new Button();
            lblNoiDangKy = new Label();
            txtNoiDK = new TextBox();
            txtMaHonNhan = new TextBox();
            btnReset = new Button();
            btnDangKy = new Button();
            btnDelete = new Button();
            fpnlChucNang = new FlowLayoutPanel();
            label1 = new Label();
            fpnlChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.ForeColor = Color.FromArgb(44, 43, 60);
            lblTen.Location = new Point(708, 360);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(104, 28);
            lblTen.TabIndex = 1;
            lblTen.Text = "Họ và tên";
            // 
            // txtTenChong
            // 
            txtTenChong.BackColor = Color.Gainsboro;
            txtTenChong.BorderStyle = BorderStyle.None;
            txtTenChong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenChong.Location = new Point(120, 360);
            txtTenChong.Name = "txtTenChong";
            txtTenChong.Size = new Size(479, 27);
            txtTenChong.TabIndex = 11;
            // 
            // txtTenVo
            // 
            txtTenVo.BackColor = Color.Gainsboro;
            txtTenVo.BorderStyle = BorderStyle.None;
            txtTenVo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenVo.Location = new Point(917, 372);
            txtTenVo.Name = "txtTenVo";
            txtTenVo.Size = new Size(490, 27);
            txtTenVo.TabIndex = 13;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.ForeColor = Color.FromArgb(44, 43, 60);
            lblCCCD.Location = new Point(708, 275);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 14;
            lblCCCD.Text = "CCCD";
            // 
            // txtCCCDChong
            // 
            txtCCCDChong.BackColor = Color.Gainsboro;
            txtCCCDChong.BorderStyle = BorderStyle.None;
            txtCCCDChong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCDChong.Location = new Point(120, 275);
            txtCCCDChong.Name = "txtCCCDChong";
            txtCCCDChong.Size = new Size(397, 27);
            txtCCCDChong.TabIndex = 15;
            // 
            // txtCCCDVo
            // 
            txtCCCDVo.BackColor = Color.Gainsboro;
            txtCCCDVo.BorderStyle = BorderStyle.None;
            txtCCCDVo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCDVo.Location = new Point(917, 271);
            txtCCCDVo.Name = "txtCCCDVo";
            txtCCCDVo.Size = new Size(397, 27);
            txtCCCDVo.TabIndex = 17;
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
            dtpNgayDangKy.Format = DateTimePickerFormat.Custom;
            dtpNgayDangKy.Location = new Point(326, 531);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(250, 34);
            dtpNgayDangKy.TabIndex = 19;
            dtpNgayDangKy.Value = new DateTime(2023, 3, 6, 0, 0, 0, 0);
            // 
            // lblNgayDangKy
            // 
            lblNgayDangKy.AutoSize = true;
            lblNgayDangKy.ForeColor = Color.FromArgb(44, 43, 60);
            lblNgayDangKy.Location = new Point(120, 531);
            lblNgayDangKy.Name = "lblNgayDangKy";
            lblNgayDangKy.Size = new Size(144, 28);
            lblNgayDangKy.TabIndex = 18;
            lblNgayDangKy.Text = "Ngày đăng ký";
            // 
            // lblChong
            // 
            lblChong.AutoSize = true;
            lblChong.ForeColor = Color.FromArgb(44, 43, 60);
            lblChong.Location = new Point(120, 213);
            lblChong.Name = "lblChong";
            lblChong.Size = new Size(72, 28);
            lblChong.TabIndex = 51;
            lblChong.Text = "Chồng";
            // 
            // lblVo
            // 
            lblVo.AutoSize = true;
            lblVo.ForeColor = Color.FromArgb(44, 43, 60);
            lblVo.Location = new Point(917, 213);
            lblVo.Name = "lblVo";
            lblVo.Size = new Size(38, 28);
            lblVo.TabIndex = 52;
            lblVo.Text = "Vợ";
            // 
            // btnTimChong
            // 
            btnTimChong.BackColor = Color.Transparent;
            btnTimChong.FlatAppearance.BorderSize = 0;
            btnTimChong.FlatStyle = FlatStyle.Flat;
            btnTimChong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimChong.ForeColor = Color.FromArgb(44, 53, 60);
            btnTimChong.Image = Properties.Resources.search__1_;
            btnTimChong.Location = new Point(549, 264);
            btnTimChong.Name = "btnTimChong";
            btnTimChong.Size = new Size(50, 50);
            btnTimChong.TabIndex = 53;
            btnTimChong.UseVisualStyleBackColor = false;
            btnTimChong.Click += btnTimChong_Click;
            // 
            // btnTimVo
            // 
            btnTimVo.BackColor = Color.Transparent;
            btnTimVo.FlatAppearance.BorderSize = 0;
            btnTimVo.FlatStyle = FlatStyle.Flat;
            btnTimVo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimVo.ForeColor = Color.FromArgb(44, 53, 60);
            btnTimVo.Image = Properties.Resources.search__1_;
            btnTimVo.Location = new Point(1357, 264);
            btnTimVo.Name = "btnTimVo";
            btnTimVo.Size = new Size(50, 50);
            btnTimVo.TabIndex = 54;
            btnTimVo.UseVisualStyleBackColor = false;
            btnTimVo.Click += btnTimVo_Click;
            // 
            // lblNoiDangKy
            // 
            lblNoiDangKy.AutoSize = true;
            lblNoiDangKy.ForeColor = Color.FromArgb(44, 43, 60);
            lblNoiDangKy.Location = new Point(120, 454);
            lblNoiDangKy.Name = "lblNoiDangKy";
            lblNoiDangKy.Size = new Size(129, 28);
            lblNoiDangKy.TabIndex = 55;
            lblNoiDangKy.Text = "Nơi đăng ký";
            // 
            // txtNoiDK
            // 
            txtNoiDK.BackColor = Color.Gainsboro;
            txtNoiDK.BorderStyle = BorderStyle.None;
            txtNoiDK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoiDK.Location = new Point(326, 454);
            txtNoiDK.Name = "txtNoiDK";
            txtNoiDK.Size = new Size(511, 27);
            txtNoiDK.TabIndex = 56;
            // 
            // txtMaHonNhan
            // 
            this.txtMaHonNhan.BackColor = System.Drawing.Color.White;
            this.txtMaHonNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHonNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHonNhan.Location = new System.Drawing.Point(305, 116);
            this.txtMaHonNhan.Name = "txtMaHonNhan";
            this.txtMaHonNhan.Size = new System.Drawing.Size(244, 34);
            this.txtMaHonNhan.TabIndex = 58;
            this.txtMaHonNhan.TextChanged += new System.EventHandler(this.txtMaHonNhan_TextChanged);
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.DialogResult = DialogResult.OK;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = Properties.Resources.undo__1_;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(159, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 50);
            btnReset.TabIndex = 59;
            btnReset.Text = "Tải lại";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Transparent;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Image = Properties.Resources.check__2_;
            btnDangKy.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangKy.Location = new Point(315, 3);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(170, 50);
            btnDangKy.TabIndex = 60;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = Properties.Resources.delete__1_;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(3, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 50);
            btnDelete.TabIndex = 61;
            btnDelete.Text = "Li hôn";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // fpnlChucNang
            // 
            fpnlChucNang.Controls.Add(btnDelete);
            fpnlChucNang.Controls.Add(btnReset);
            fpnlChucNang.Controls.Add(btnDangKy);
            fpnlChucNang.Location = new Point(1040, 708);
            fpnlChucNang.Name = "fpnlChucNang";
            fpnlChucNang.Size = new Size(507, 62);
            fpnlChucNang.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(44, 43, 60);
            label1.Location = new Point(112, 115);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 64;
            label1.Text = "Mã hôn nhân";
            // 
            // FDangKyHonNhan
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1532, 782);
            Controls.Add(label1);
            Controls.Add(fpnlChucNang);
            Controls.Add(txtMaHonNhan);
            Controls.Add(txtNoiDK);
            Controls.Add(lblNoiDangKy);
            Controls.Add(btnTimVo);
            Controls.Add(btnTimChong);
            Controls.Add(lblVo);
            Controls.Add(lblChong);
            Controls.Add(dtpNgayDangKy);
            Controls.Add(lblNgayDangKy);
            Controls.Add(txtCCCDVo);
            Controls.Add(txtCCCDChong);
            Controls.Add(lblCCCD);
            Controls.Add(txtTenVo);
            Controls.Add(txtTenChong);
            Controls.Add(lblTen);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDangKyHonNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDangKyKetHon";
            fpnlChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTen;
        private TextBox txtTenChong;
        private TextBox txtTenVo;
        private Label lblCCCD;
        private TextBox txtCCCDChong;
        private TextBox txtCCCDVo;
        private DateTimePicker dtpNgayDangKy;
        private Label lblNgayDangKy;
        private Label lblChong;
        private Label lblVo;
        private Button btnTimChong;
        private Button btnTimVo;
        private Label lblNoiDangKy;
        private TextBox txtNoiDK;
        private TextBox txtMaHonNhan;
        private Button btnReset;
        private Button btnDangKy;
        private Button btnDelete;
        private FlowLayoutPanel fpnlChucNang;
        private Label label1;
    }
}