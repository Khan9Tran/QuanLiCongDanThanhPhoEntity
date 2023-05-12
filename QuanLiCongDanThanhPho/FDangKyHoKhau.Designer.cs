namespace QuanLiCongDanThanhPho
{
    partial class FDangKyHoKhau
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
            this.btnTachGop = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlLuaChon = new System.Windows.Forms.Panel();
            this.pnlBarDuoi = new System.Windows.Forms.Panel();
            this.pnlBarDuoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTachGop
            // 
            this.btnTachGop.BackColor = System.Drawing.Color.White;
            this.btnTachGop.FlatAppearance.BorderSize = 0;
            this.btnTachGop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTachGop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTachGop.Location = new System.Drawing.Point(1172, 17);
            this.btnTachGop.Name = "btnTachGop";
            this.btnTachGop.Size = new System.Drawing.Size(188, 50);
            this.btnTachGop.TabIndex = 10;
            this.btnTachGop.Text = "Tách Gộp Hộ";
            this.btnTachGop.UseVisualStyleBackColor = false;
            this.btnTachGop.Click += new System.EventHandler(this.btnTachGop_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.add_button__1_;
            this.btnThem.Location = new System.Drawing.Point(1383, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 11;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlLuaChon
            // 
            this.pnlLuaChon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLuaChon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLuaChon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnlLuaChon.Location = new System.Drawing.Point(0, 0);
            this.pnlLuaChon.Name = "pnlLuaChon";
            this.pnlLuaChon.Size = new System.Drawing.Size(1532, 647);
            this.pnlLuaChon.TabIndex = 12;
            // 
            // pnlBarDuoi
            // 
            this.pnlBarDuoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarDuoi.Controls.Add(this.btnThem);
            this.pnlBarDuoi.Controls.Add(this.btnTachGop);
            this.pnlBarDuoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarDuoi.Location = new System.Drawing.Point(0, 653);
            this.pnlBarDuoi.Name = "pnlBarDuoi";
            this.pnlBarDuoi.Size = new System.Drawing.Size(1532, 99);
            this.pnlBarDuoi.TabIndex = 13;
            // 
            // FDangKyHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 752);
            this.Controls.Add(this.pnlBarDuoi);
            this.Controls.Add(this.pnlLuaChon);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDangKyHoKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDangKyHoKhau";
            this.pnlBarDuoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTachGop;
        private Button btnThem;
        private Panel pnlLuaChon;
        private Panel pnlBarDuoi;
    }
}