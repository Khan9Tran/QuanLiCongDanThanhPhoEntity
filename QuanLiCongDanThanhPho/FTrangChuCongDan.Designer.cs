namespace QuanLiCongDanThanhPho
{
    partial class FTrangChuCongDan
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
            this.components = new System.ComponentModel.Container();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.ptcCongDan = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.cmnusSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnusItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.cmusItemDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.fpnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnCCCD = new System.Windows.Forms.Button();
            this.btnThue = new System.Windows.Forms.Button();
            this.btnTTTV = new System.Windows.Forms.Button();
            this.pnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcCongDan)).BeginInit();
            this.cmnusSetting.SuspendLayout();
            this.fpnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlChucNang.Controls.Add(this.ptcCongDan);
            this.pnlChucNang.Controls.Add(this.btnBack);
            this.pnlChucNang.Controls.Add(this.btnSetting);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlChucNang.Location = new System.Drawing.Point(0, 0);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(81, 753);
            this.pnlChucNang.TabIndex = 0;
            // 
            // ptcCongDan
            // 
            this.ptcCongDan.BackColor = System.Drawing.Color.Transparent;
            this.ptcCongDan.Location = new System.Drawing.Point(8, 12);
            this.ptcCongDan.Name = "ptcCongDan";
            this.ptcCongDan.Size = new System.Drawing.Size(66, 72);
            this.ptcCongDan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcCongDan.TabIndex = 2;
            this.ptcCongDan.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::QuanLiCongDanThanhPho.Properties.Resources.previous;
            this.btnBack.Location = new System.Drawing.Point(34, 105);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.ContextMenuStrip = this.cmnusSetting;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = global::QuanLiCongDanThanhPho.Properties.Resources.settings__2_;
            this.btnSetting.Location = new System.Drawing.Point(23, 693);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(32, 32);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // cmnusSetting
            // 
            this.cmnusSetting.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmnusSetting.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnusSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnusItemDangXuat,
            this.cmusItemDoiMK});
            this.cmnusSetting.Name = "cmnusSetting";
            this.cmnusSetting.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmnusSetting.Size = new System.Drawing.Size(210, 68);
            // 
            // cmnusItemDangXuat
            // 
            this.cmnusItemDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmnusItemDangXuat.ForeColor = System.Drawing.Color.White;
            this.cmnusItemDangXuat.Name = "cmnusItemDangXuat";
            this.cmnusItemDangXuat.Size = new System.Drawing.Size(209, 32);
            this.cmnusItemDangXuat.Text = "Đăng xuất";
            this.cmnusItemDangXuat.Click += new System.EventHandler(this.cmnusItemDangXuat_Click);
            // 
            // cmusItemDoiMK
            // 
            this.cmusItemDoiMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmusItemDoiMK.ForeColor = System.Drawing.Color.White;
            this.cmusItemDoiMK.Name = "cmusItemDoiMK";
            this.cmusItemDoiMK.Size = new System.Drawing.Size(209, 32);
            this.cmusItemDoiMK.Text = "Đổi mật khẩu";
            this.cmusItemDoiMK.Click += new System.EventHandler(this.cmusItemDoiMK_Click);
            // 
            // pnlLoad
            // 
            this.pnlLoad.Location = new System.Drawing.Point(84, 0);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(545, 753);
            this.pnlLoad.TabIndex = 1;
            // 
            // fpnlMenu
            // 
            this.fpnlMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fpnlMenu.Controls.Add(this.btnThongTin);
            this.fpnlMenu.Controls.Add(this.btnCCCD);
            this.fpnlMenu.Controls.Add(this.btnThue);
            this.fpnlMenu.Controls.Add(this.btnTTTV);
            this.fpnlMenu.Location = new System.Drawing.Point(90, 0);
            this.fpnlMenu.Name = "fpnlMenu";
            this.fpnlMenu.Size = new System.Drawing.Size(542, 753);
            this.fpnlMenu.TabIndex = 1;
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.White;
            this.btnThongTin.FlatAppearance.BorderSize = 0;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThongTin.ForeColor = System.Drawing.Color.Black;
            this.btnThongTin.Image = global::QuanLiCongDanThanhPho.Properties.Resources.individual;
            this.btnThongTin.Location = new System.Drawing.Point(3, 3);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(265, 370);
            this.btnThongTin.TabIndex = 0;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnCCCD
            // 
            this.btnCCCD.BackColor = System.Drawing.Color.White;
            this.btnCCCD.FlatAppearance.BorderSize = 0;
            this.btnCCCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCCD.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCCCD.ForeColor = System.Drawing.Color.Black;
            this.btnCCCD.Image = global::QuanLiCongDanThanhPho.Properties.Resources.personal_information__1_;
            this.btnCCCD.Location = new System.Drawing.Point(274, 3);
            this.btnCCCD.Name = "btnCCCD";
            this.btnCCCD.Size = new System.Drawing.Size(265, 370);
            this.btnCCCD.TabIndex = 1;
            this.btnCCCD.Text = "CCCD";
            this.btnCCCD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCCCD.UseVisualStyleBackColor = false;
            this.btnCCCD.Click += new System.EventHandler(this.btnCCCD_Click);
            // 
            // btnThue
            // 
            this.btnThue.BackColor = System.Drawing.Color.White;
            this.btnThue.FlatAppearance.BorderSize = 0;
            this.btnThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThue.ForeColor = System.Drawing.Color.Black;
            this.btnThue.Image = global::QuanLiCongDanThanhPho.Properties.Resources.tax;
            this.btnThue.Location = new System.Drawing.Point(3, 379);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(265, 370);
            this.btnThue.TabIndex = 2;
            this.btnThue.Text = "Đóng thuế";
            this.btnThue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThue.UseVisualStyleBackColor = false;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // btnTTTV
            // 
            this.btnTTTV.BackColor = System.Drawing.Color.White;
            this.btnTTTV.FlatAppearance.BorderSize = 0;
            this.btnTTTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTTV.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTTTV.ForeColor = System.Drawing.Color.Black;
            this.btnTTTV.Image = global::QuanLiCongDanThanhPho.Properties.Resources.i_stay_at_home;
            this.btnTTTV.Location = new System.Drawing.Point(274, 379);
            this.btnTTTV.Name = "btnTTTV";
            this.btnTTTV.Size = new System.Drawing.Size(265, 370);
            this.btnTTTV.TabIndex = 3;
            this.btnTTTV.Text = "Đăng ký TT/TV";
            this.btnTTTV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTTTV.UseVisualStyleBackColor = false;
            this.btnTTTV.Click += new System.EventHandler(this.btnTTTV_Click);
            // 
            // FTrangChuCongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 753);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.fpnlMenu);
            this.Controls.Add(this.pnlChucNang);
            this.Name = "FTrangChuCongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartCITY";
            this.Load += new System.EventHandler(this.FTrangChuCongDan_Load);
            this.pnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcCongDan)).EndInit();
            this.cmnusSetting.ResumeLayout(false);
            this.fpnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlChucNang;
        private FlowLayoutPanel fpnlMenu;
        private Button btnThongTin;
        private Button btnCCCD;
        private Button btnThue;
        private Button btnTTTV;
        private Button btnSetting;
        private Panel pnlLoad;
        private Button btnBack;
        private ContextMenuStrip cmnusSetting;
        private ToolStripMenuItem cmnusItemDangXuat;
        private ToolStripMenuItem cmusItemDoiMK;
        private PictureBox ptcCongDan;
    }
}