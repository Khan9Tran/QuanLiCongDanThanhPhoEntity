namespace QuanLiCongDanThanhPho
{
    partial class FThongTinThue
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
            pnlTittleBar = new Panel();
            lblTittle = new Label();
            pnlThongTinThue = new Panel();
            fpnlChucNang = new FlowLayoutPanel();
            btnXacNhan = new Button();
            btnSua = new Button();
            btnReLoad = new Button();
            dtmHanNopThue = new DateTimePicker();
            dtmNgayCapMaSoThue = new DateTimePicker();
            txtSoTienDaNop = new TextBox();
            txtSoTienCanNop = new TextBox();
            txtSdt = new TextBox();
            txtDiaChi = new TextBox();
            txtCCCD = new TextBox();
            txtTen = new TextBox();
            txtMaSoThue = new TextBox();
            lblHanNopThue = new Label();
            lblDiaChi = new Label();
            lblNgayCapMaSoThue = new Label();
            lblSoTienDaNop = new Label();
            lblSoTienCanNop = new Label();
            lblSdt = new Label();
            lblCCCD = new Label();
            lblTen = new Label();
            lblMaSoThue = new Label();
            sideBarWhite1 = new SideBarWhite();
            titleBarWhite1 = new TitleBarWhite();
            pnlTittleBar.SuspendLayout();
            pnlThongTinThue.SuspendLayout();
            fpnlChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTittleBar
            // 
            pnlTittleBar.BackColor = Color.RoyalBlue;
            pnlTittleBar.Controls.Add(lblTittle);
            pnlTittleBar.Location = new Point(3, 32);
            pnlTittleBar.Name = "pnlTittleBar";
            pnlTittleBar.Size = new Size(920, 71);
            pnlTittleBar.TabIndex = 0;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Transparent;
            lblTittle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTittle.ForeColor = Color.WhiteSmoke;
            lblTittle.Location = new Point(359, 9);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(252, 38);
            lblTittle.TabIndex = 0;
            lblTittle.Text = "THÔNG TIN THUẾ";
            // 
            // pnlThongTinThue
            // 
            pnlThongTinThue.BackColor = Color.WhiteSmoke;
            pnlThongTinThue.Controls.Add(fpnlChucNang);
            pnlThongTinThue.Controls.Add(dtmHanNopThue);
            pnlThongTinThue.Controls.Add(dtmNgayCapMaSoThue);
            pnlThongTinThue.Controls.Add(txtSoTienDaNop);
            pnlThongTinThue.Controls.Add(txtSoTienCanNop);
            pnlThongTinThue.Controls.Add(txtSdt);
            pnlThongTinThue.Controls.Add(txtDiaChi);
            pnlThongTinThue.Controls.Add(txtCCCD);
            pnlThongTinThue.Controls.Add(txtTen);
            pnlThongTinThue.Controls.Add(txtMaSoThue);
            pnlThongTinThue.Controls.Add(lblHanNopThue);
            pnlThongTinThue.Controls.Add(lblDiaChi);
            pnlThongTinThue.Controls.Add(lblNgayCapMaSoThue);
            pnlThongTinThue.Controls.Add(lblSoTienDaNop);
            pnlThongTinThue.Controls.Add(lblSoTienCanNop);
            pnlThongTinThue.Controls.Add(lblSdt);
            pnlThongTinThue.Controls.Add(lblCCCD);
            pnlThongTinThue.Controls.Add(lblTen);
            pnlThongTinThue.Controls.Add(lblMaSoThue);
            pnlThongTinThue.Location = new Point(3, 87);
            pnlThongTinThue.Name = "pnlThongTinThue";
            pnlThongTinThue.Size = new Size(920, 560);
            pnlThongTinThue.TabIndex = 2;
            // 
            // fpnlChucNang
            // 
            fpnlChucNang.Controls.Add(btnXacNhan);
            fpnlChucNang.Controls.Add(btnSua);
            fpnlChucNang.Controls.Add(btnReLoad);
            fpnlChucNang.Location = new Point(730, 501);
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
            // dtmHanNopThue
            // 
            dtmHanNopThue.CustomFormat = "dd/MM/yyyy";
            dtmHanNopThue.Enabled = false;
            dtmHanNopThue.Format = DateTimePickerFormat.Custom;
            dtmHanNopThue.Location = new Point(713, 370);
            dtmHanNopThue.Name = "dtmHanNopThue";
            dtmHanNopThue.Size = new Size(160, 34);
            dtmHanNopThue.TabIndex = 17;
            dtmHanNopThue.Value = new DateTime(2023, 3, 13, 0, 0, 0, 0);
            // 
            // dtmNgayCapMaSoThue
            // 
            dtmNgayCapMaSoThue.CustomFormat = "dd/MM/yyyy";
            dtmNgayCapMaSoThue.Enabled = false;
            dtmNgayCapMaSoThue.Format = DateTimePickerFormat.Custom;
            dtmNgayCapMaSoThue.Location = new Point(250, 370);
            dtmNgayCapMaSoThue.Name = "dtmNgayCapMaSoThue";
            dtmNgayCapMaSoThue.Size = new Size(160, 34);
            dtmNgayCapMaSoThue.TabIndex = 16;
            dtmNgayCapMaSoThue.Value = new DateTime(2023, 3, 13, 0, 0, 0, 0);
            // 
            // txtSoTienDaNop
            // 
            txtSoTienDaNop.BackColor = Color.Gainsboro;
            txtSoTienDaNop.BorderStyle = BorderStyle.None;
            txtSoTienDaNop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoTienDaNop.Location = new Point(250, 320);
            txtSoTienDaNop.Name = "txtSoTienDaNop";
            txtSoTienDaNop.Size = new Size(623, 27);
            txtSoTienDaNop.TabIndex = 15;
            txtSoTienDaNop.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSoTienCanNop
            // 
            txtSoTienCanNop.BackColor = Color.Gainsboro;
            txtSoTienCanNop.BorderStyle = BorderStyle.None;
            txtSoTienCanNop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoTienCanNop.Location = new Point(250, 270);
            txtSoTienCanNop.Name = "txtSoTienCanNop";
            txtSoTienCanNop.ReadOnly = true;
            txtSoTienCanNop.Size = new Size(623, 27);
            txtSoTienCanNop.TabIndex = 14;
            txtSoTienCanNop.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSdt
            // 
            txtSdt.BackColor = Color.Gainsboro;
            txtSdt.BorderStyle = BorderStyle.None;
            txtSdt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdt.Location = new Point(250, 170);
            txtSdt.Name = "txtSdt";
            txtSdt.ReadOnly = true;
            txtSdt.Size = new Size(623, 27);
            txtSdt.TabIndex = 13;
            txtSdt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.Gainsboro;
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(250, 220);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(623, 27);
            txtDiaChi.TabIndex = 12;
            txtDiaChi.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.Gainsboro;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(250, 120);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.ReadOnly = true;
            txtCCCD.Size = new Size(623, 27);
            txtCCCD.TabIndex = 11;
            txtCCCD.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.Gainsboro;
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(250, 70);
            txtTen.Name = "txtTen";
            txtTen.ReadOnly = true;
            txtTen.Size = new Size(623, 27);
            txtTen.TabIndex = 10;
            txtTen.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMaSoThue
            // 
            txtMaSoThue.BackColor = Color.Gainsboro;
            txtMaSoThue.BorderStyle = BorderStyle.None;
            txtMaSoThue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSoThue.Location = new Point(250, 20);
            txtMaSoThue.Name = "txtMaSoThue";
            txtMaSoThue.ReadOnly = true;
            txtMaSoThue.Size = new Size(623, 27);
            txtMaSoThue.TabIndex = 9;
            txtMaSoThue.TextAlign = HorizontalAlignment.Center;
            // 
            // lblHanNopThue
            // 
            lblHanNopThue.AutoSize = true;
            lblHanNopThue.Location = new Point(591, 370);
            lblHanNopThue.Name = "lblHanNopThue";
            lblHanNopThue.Size = new Size(92, 28);
            lblHanNopThue.TabIndex = 8;
            lblHanNopThue.Text = "Hạn nộp";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(50, 220);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(78, 28);
            lblDiaChi.TabIndex = 0;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgayCapMaSoThue
            // 
            lblNgayCapMaSoThue.AutoSize = true;
            lblNgayCapMaSoThue.Location = new Point(50, 370);
            lblNgayCapMaSoThue.Name = "lblNgayCapMaSoThue";
            lblNgayCapMaSoThue.Size = new Size(101, 28);
            lblNgayCapMaSoThue.TabIndex = 7;
            lblNgayCapMaSoThue.Text = "Ngày cấp";
            // 
            // lblSoTienDaNop
            // 
            lblSoTienDaNop.AutoSize = true;
            lblSoTienDaNop.Location = new Point(50, 320);
            lblSoTienDaNop.Name = "lblSoTienDaNop";
            lblSoTienDaNop.Size = new Size(150, 28);
            lblSoTienDaNop.TabIndex = 6;
            lblSoTienDaNop.Text = "Số tiền đã nộp";
            // 
            // lblSoTienCanNop
            // 
            lblSoTienCanNop.AutoSize = true;
            lblSoTienCanNop.Location = new Point(50, 270);
            lblSoTienCanNop.Name = "lblSoTienCanNop";
            lblSoTienCanNop.Size = new Size(159, 28);
            lblSoTienCanNop.TabIndex = 5;
            lblSoTienCanNop.Text = "Số tiền cần nộp";
            // 
            // lblSdt
            // 
            lblSdt.AutoSize = true;
            lblSdt.Location = new Point(50, 176);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new Size(138, 28);
            lblSdt.TabIndex = 4;
            lblSdt.Text = "Số điện thoại";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(50, 120);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 3;
            lblCCCD.Text = "CCCD";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(50, 70);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(138, 28);
            lblTen.TabIndex = 2;
            lblTen.Text = "Tên công dân";
            // 
            // lblMaSoThue
            // 
            lblMaSoThue.AutoSize = true;
            lblMaSoThue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaSoThue.Location = new Point(50, 20);
            lblMaSoThue.Name = "lblMaSoThue";
            lblMaSoThue.Size = new Size(118, 28);
            lblMaSoThue.TabIndex = 1;
            lblMaSoThue.Text = "Mã số thuế";
            // 
            // sideBarWhite1
            // 
            sideBarWhite1.Location = new Point(3, -1);
            sideBarWhite1.Name = "sideBarWhite1";
            sideBarWhite1.Size = new Size(75, 30);
            sideBarWhite1.TabIndex = 4;
            // 
            // titleBarWhite1
            // 
            titleBarWhite1.Location = new Point(873, 1);
            titleBarWhite1.Name = "titleBarWhite1";
            titleBarWhite1.Size = new Size(60, 28);
            titleBarWhite1.TabIndex = 5;
            // 
            // FThongTinThue
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(927, 652);
            Controls.Add(titleBarWhite1);
            Controls.Add(sideBarWhite1);
            Controls.Add(pnlThongTinThue);
            Controls.Add(pnlTittleBar);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FThongTinThue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FThongTinThue";
            Load += FThongTinThue_Load;
            pnlTittleBar.ResumeLayout(false);
            pnlTittleBar.PerformLayout();
            pnlThongTinThue.ResumeLayout(false);
            pnlThongTinThue.PerformLayout();
            fpnlChucNang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTittleBar;
        private Panel pnlThongTinThue;
        private Label lblTittle;
        private Label lblDiaChi;
        private Label lblNgayCapMaSoThue;
        private Label lblSoTienDaNop;
        private Label lblSoTienCanNop;
        private Label lblSdt;
        private Label lblCCCD;
        private Label lblTen;
        private Label lblMaSoThue;
        private TextBox txtMaSoThue;
        private Label lblHanNopThue;
        private DateTimePicker dtmHanNopThue;
        private DateTimePicker dtmNgayCapMaSoThue;
        private TextBox txtSoTienDaNop;
        private TextBox txtSoTienCanNop;
        private TextBox txtSdt;
        private TextBox txtDiaChi;
        private TextBox txtCCCD;
        private TextBox txtTen;
        private SideBarWhite sideBarWhite1;
        private TitleBarWhite titleBarWhite1;
        private FlowLayoutPanel fpnlChucNang;
        private Button btnXacNhan;
        private Button btnSua;
        private Button btnReLoad;
    }
}