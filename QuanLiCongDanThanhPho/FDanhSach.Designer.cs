namespace QuanLiCongDanThanhPho
{
    partial class FDanhSach
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
            this.pnlHienThiDanhSach = new System.Windows.Forms.Panel();
            this.flpnlPhanLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnCongDan = new System.Windows.Forms.Button();
            this.btnThue = new System.Windows.Forms.Button();
            this.btnHoKhau = new System.Windows.Forms.Button();
            this.btnTTTV = new System.Windows.Forms.Button();
            this.flpnlPhanLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHienThiDanhSach
            // 
            this.pnlHienThiDanhSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHienThiDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHienThiDanhSach.Location = new System.Drawing.Point(0, 103);
            this.pnlHienThiDanhSach.Name = "pnlHienThiDanhSach";
            this.pnlHienThiDanhSach.Size = new System.Drawing.Size(1532, 679);
            this.pnlHienThiDanhSach.TabIndex = 0;
            // 
            // flpnlPhanLoai
            // 
            this.flpnlPhanLoai.Controls.Add(this.btnLoc);
            this.flpnlPhanLoai.Controls.Add(this.btnCongDan);
            this.flpnlPhanLoai.Controls.Add(this.btnThue);
            this.flpnlPhanLoai.Controls.Add(this.btnHoKhau);
            this.flpnlPhanLoai.Controls.Add(this.btnTTTV);
            this.flpnlPhanLoai.Location = new System.Drawing.Point(12, 31);
            this.flpnlPhanLoai.Name = "flpnlPhanLoai";
            this.flpnlPhanLoai.Size = new System.Drawing.Size(1153, 47);
            this.flpnlPhanLoai.TabIndex = 10;
            // 
            // btnLoc
            // 
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Image = global::QuanLiCongDanThanhPho.Properties.Resources.dots__2_;
            this.btnLoc.Location = new System.Drawing.Point(3, 3);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(32, 40);
            this.btnLoc.TabIndex = 60;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnCongDan
            // 
            this.btnCongDan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCongDan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongDan.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCongDan.ForeColor = System.Drawing.Color.Black;
            this.btnCongDan.Location = new System.Drawing.Point(41, 3);
            this.btnCongDan.Name = "btnCongDan";
            this.btnCongDan.Size = new System.Drawing.Size(125, 40);
            this.btnCongDan.TabIndex = 4;
            this.btnCongDan.Text = "Công dân";
            this.btnCongDan.UseVisualStyleBackColor = false;
            this.btnCongDan.Click += new System.EventHandler(this.btnCongDan_Click);
            // 
            // btnThue
            // 
            this.btnThue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThue.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThue.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThue.ForeColor = System.Drawing.Color.Black;
            this.btnThue.Location = new System.Drawing.Point(172, 3);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(125, 40);
            this.btnThue.TabIndex = 5;
            this.btnThue.Text = "Thuế";
            this.btnThue.UseVisualStyleBackColor = false;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // btnHoKhau
            // 
            this.btnHoKhau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHoKhau.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnHoKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoKhau.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHoKhau.ForeColor = System.Drawing.Color.Black;
            this.btnHoKhau.Location = new System.Drawing.Point(303, 3);
            this.btnHoKhau.Name = "btnHoKhau";
            this.btnHoKhau.Size = new System.Drawing.Size(125, 40);
            this.btnHoKhau.TabIndex = 61;
            this.btnHoKhau.Text = "Hộ khẩu";
            this.btnHoKhau.UseVisualStyleBackColor = false;
            this.btnHoKhau.Click += new System.EventHandler(this.btnHoKhau_Click);
            // 
            // btnTTTV
            // 
            this.btnTTTV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTTTV.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTTTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTTV.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTTTV.ForeColor = System.Drawing.Color.Black;
            this.btnTTTV.Location = new System.Drawing.Point(434, 3);
            this.btnTTTV.Name = "btnTTTV";
            this.btnTTTV.Size = new System.Drawing.Size(223, 40);
            this.btnTTTV.TabIndex = 62;
            this.btnTTTV.Text = "Tạm trú/Tạm vắng";
            this.btnTTTV.UseVisualStyleBackColor = false;
            this.btnTTTV.Click += new System.EventHandler(this.btnTTTV_Click);
            // 
            // FDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1532, 782);
            this.Controls.Add(this.flpnlPhanLoai);
            this.Controls.Add(this.pnlHienThiDanhSach);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSach";
            this.Text = "FDanhSach";
            this.Load += new System.EventHandler(this.FDanhSach_Load);
            this.flpnlPhanLoai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHienThiDanhSach;
        private FlowLayoutPanel flpnlPhanLoai;
        private Button btnLoc;
        private Button btnCongDan;
        private Button btnThue;
        private Button btnHoKhau;
        private Button btnTTTV;
    }
}