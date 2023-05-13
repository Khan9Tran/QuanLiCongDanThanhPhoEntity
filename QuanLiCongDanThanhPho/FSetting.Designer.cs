namespace QuanLiCongDanThanhPho
{
    partial class FSetting
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
            this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.MatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblMkHT = new System.Windows.Forms.Label();
            this.lblMkMoi = new System.Windows.Forms.Label();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMatKhauHienTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauHienTai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(188, 266);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(283, 34);
            this.txtMatKhauHienTai.TabIndex = 0;
            this.txtMatKhauHienTai.UseSystemPasswordChar = true;
            // 
            // MatKhauMoi
            // 
            this.MatKhauMoi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatKhauMoi.Location = new System.Drawing.Point(188, 391);
            this.MatKhauMoi.Name = "MatKhauMoi";
            this.MatKhauMoi.Size = new System.Drawing.Size(283, 34);
            this.MatKhauMoi.TabIndex = 1;
            this.MatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNhapLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhapLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNhapLai.Location = new System.Drawing.Point(188, 512);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(283, 34);
            this.txtNhapLai.TabIndex = 2;
            this.txtNhapLai.UseSystemPasswordChar = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Image = global::QuanLiCongDanThanhPho.Properties.Resources.check__2_;
            this.btnXacNhan.Location = new System.Drawing.Point(436, 588);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(35, 35);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // lblMkHT
            // 
            this.lblMkHT.AutoSize = true;
            this.lblMkHT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMkHT.ForeColor = System.Drawing.Color.DimGray;
            this.lblMkHT.Location = new System.Drawing.Point(80, 209);
            this.lblMkHT.Name = "lblMkHT";
            this.lblMkHT.Size = new System.Drawing.Size(180, 28);
            this.lblMkHT.TabIndex = 4;
            this.lblMkHT.Text = "Mật khẩu hiện tại";
            // 
            // lblMkMoi
            // 
            this.lblMkMoi.AutoSize = true;
            this.lblMkMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMkMoi.ForeColor = System.Drawing.Color.DimGray;
            this.lblMkMoi.Location = new System.Drawing.Point(80, 334);
            this.lblMkMoi.Name = "lblMkMoi";
            this.lblMkMoi.Size = new System.Drawing.Size(145, 28);
            this.lblMkMoi.TabIndex = 5;
            this.lblMkMoi.Text = "Mật khẩu mới";
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNhapLai.ForeColor = System.Drawing.Color.DimGray;
            this.lblNhapLai.Location = new System.Drawing.Point(80, 471);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(98, 28);
            this.lblNhapLai.TabIndex = 6;
            this.lblNhapLai.Text = "Nhập lại ";
            // 
            // FSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 706);
            this.Controls.Add(this.lblNhapLai);
            this.Controls.Add(this.lblMkMoi);
            this.Controls.Add(this.lblMkHT);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.MatKhauMoi);
            this.Controls.Add(this.txtMatKhauHienTai);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSetting";
            this.Text = "FSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMatKhauHienTai;
        private TextBox MatKhauMoi;
        private TextBox txtNhapLai;
        private Button btnXacNhan;
        private Label lblMkHT;
        private Label lblMkMoi;
        private Label lblNhapLai;
    }
}