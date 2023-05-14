namespace QuanLiCongDanThanhPho
{
    partial class FXinPhepTTTV
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
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.rdoTamTru = new System.Windows.Forms.RadioButton();
            this.rdoTamVang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLiDo = new System.Windows.Forms.TextBox();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDay
            // 
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDay.Location = new System.Drawing.Point(384, 384);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(125, 34);
            this.txtDay.TabIndex = 0;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgayBD.Location = new System.Drawing.Point(71, 272);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(144, 28);
            this.lblNgayBD.TabIndex = 1;
            this.lblNgayBD.Text = "Ngày đăng ký";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Image = global::QuanLiCongDanThanhPho.Properties.Resources.check__2_;
            this.btnXacNhan.Location = new System.Drawing.Point(475, 668);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(34, 34);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // rdoTamTru
            // 
            this.rdoTamTru.AutoSize = true;
            this.rdoTamTru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoTamTru.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoTamTru.Location = new System.Drawing.Point(81, 144);
            this.rdoTamTru.Name = "rdoTamTru";
            this.rdoTamTru.Size = new System.Drawing.Size(108, 32);
            this.rdoTamTru.TabIndex = 4;
            this.rdoTamTru.TabStop = true;
            this.rdoTamTru.Text = "Tạm trú";
            this.rdoTamTru.UseVisualStyleBackColor = true;
            // 
            // rdoTamVang
            // 
            this.rdoTamVang.AutoSize = true;
            this.rdoTamVang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoTamVang.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoTamVang.Location = new System.Drawing.Point(383, 144);
            this.rdoTamVang.Name = "rdoTamVang";
            this.rdoTamVang.Size = new System.Drawing.Size(126, 32);
            this.rdoTamVang.TabIndex = 5;
            this.rdoTamVang.TabStop = true;
            this.rdoTamVang.Text = "Tạm vắng";
            this.rdoTamVang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số ngày tạm trú/ tạm vắng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lí do";
            // 
            // txtLiDo
            // 
            this.txtLiDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLiDo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLiDo.Location = new System.Drawing.Point(187, 501);
            this.txtLiDo.Name = "txtLiDo";
            this.txtLiDo.Size = new System.Drawing.Size(322, 34);
            this.txtLiDo.TabIndex = 8;
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDangKy.Enabled = false;
            this.dtpNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDangKy.Location = new System.Drawing.Point(384, 272);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(125, 27);
            this.dtpNgayDangKy.TabIndex = 9;
            this.dtpNgayDangKy.Value = new System.DateTime(2023, 5, 14, 0, 0, 0, 0);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblGhiChu.Location = new System.Drawing.Point(116, 727);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(380, 17);
            this.lblGhiChu.TabIndex = 10;
            this.lblGhiChu.Text = "*Mã tạm trú/ tạm vắng nến được duyệt sẽ tạo theo CCCD của bạn";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDiaChi.Location = new System.Drawing.Point(71, 628);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(440, 34);
            this.txtDiaChi.TabIndex = 11;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.Location = new System.Drawing.Point(69, 578);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(112, 28);
            this.lblDiaChi.TabIndex = 12;
            this.lblDiaChi.Text = "Nơi TT/TV";
            // 
            // FXinPhepTTTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 753);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.txtLiDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoTamVang);
            this.Controls.Add(this.rdoTamTru);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lblNgayBD);
            this.Controls.Add(this.txtDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FXinPhepTTTV";
            this.Text = "FXinPhepTTTV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDay;
        private Label lblNgayBD;
        private Button btnXacNhan;
        private RadioButton rdoTamTru;
        private RadioButton rdoTamVang;
        private Label label1;
        private Label label2;
        private TextBox txtLiDo;
        private DateTimePicker dtpNgayDangKy;
        private Label lblGhiChu;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
    }
}