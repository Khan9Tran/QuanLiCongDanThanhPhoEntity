﻿namespace QuanLiCongDanThanhPho
{
    partial class FDanhSachTamTruTamVang
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
            this.gvTVTT = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.flpnlPhanLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTV = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnQuaHan = new System.Windows.Forms.Button();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmnusMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnusMenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.nudPage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gvTVTT)).BeginInit();
            this.flpnlPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.cmnusMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTVTT
            // 
            this.gvTVTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTVTT.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvTVTT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvTVTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTVTT.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gvTVTT.Location = new System.Drawing.Point(25, 162);
            this.gvTVTT.Name = "gvTVTT";
            this.gvTVTT.RowHeadersWidth = 51;
            this.gvTVTT.RowTemplate.Height = 29;
            this.gvTVTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTVTT.Size = new System.Drawing.Size(1480, 488);
            this.gvTVTT.TabIndex = 1;
            this.gvTVTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTVTT_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(25, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1422, 31);
            this.txtTimKiem.TabIndex = 56;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // flpnlPhanLoai
            // 
            this.flpnlPhanLoai.Controls.Add(this.btnTatCa);
            this.flpnlPhanLoai.Controls.Add(this.btnTV);
            this.flpnlPhanLoai.Controls.Add(this.btnTT);
            this.flpnlPhanLoai.Controls.Add(this.btnQuaHan);
            this.flpnlPhanLoai.Location = new System.Drawing.Point(25, 108);
            this.flpnlPhanLoai.Name = "flpnlPhanLoai";
            this.flpnlPhanLoai.Size = new System.Drawing.Size(699, 47);
            this.flpnlPhanLoai.TabIndex = 58;
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTatCa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTatCa.ForeColor = System.Drawing.Color.Black;
            this.btnTatCa.Location = new System.Drawing.Point(3, 3);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(125, 40);
            this.btnTatCa.TabIndex = 4;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnTV
            // 
            this.btnTV.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTV.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTV.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTV.ForeColor = System.Drawing.Color.Black;
            this.btnTV.Location = new System.Drawing.Point(134, 3);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(125, 40);
            this.btnTV.TabIndex = 5;
            this.btnTV.Text = "Tạm vắng";
            this.btnTV.UseVisualStyleBackColor = false;
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTT.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTT.ForeColor = System.Drawing.Color.Black;
            this.btnTT.Location = new System.Drawing.Point(265, 3);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(144, 40);
            this.btnTT.TabIndex = 6;
            this.btnTT.Text = "Tạm trú";
            this.btnTT.UseVisualStyleBackColor = false;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // btnQuaHan
            // 
            this.btnQuaHan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnQuaHan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnQuaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuaHan.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuaHan.ForeColor = System.Drawing.Color.Black;
            this.btnQuaHan.Location = new System.Drawing.Point(415, 3);
            this.btnQuaHan.Name = "btnQuaHan";
            this.btnQuaHan.Size = new System.Drawing.Size(144, 40);
            this.btnQuaHan.TabIndex = 61;
            this.btnQuaHan.Text = "Quá hạn";
            this.btnQuaHan.UseVisualStyleBackColor = false;
            this.btnQuaHan.Click += new System.EventHandler(this.btnQuaHan_Click);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search;
            this.picTimKiem.Location = new System.Drawing.Point(1468, 12);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(37, 31);
            this.picTimKiem.TabIndex = 59;
            this.picTimKiem.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.page;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1190, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(162, 50);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmnusMenu
            // 
            this.cmnusMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmnusMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmnusMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnusMenuXoa});
            this.cmnusMenu.Name = "contextMenuStrip1";
            this.cmnusMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmnusMenu.ShowImageMargin = false;
            this.cmnusMenu.Size = new System.Drawing.Size(96, 36);
            // 
            // cmnusMenuXoa
            // 
            this.cmnusMenuXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmnusMenuXoa.Name = "cmnusMenuXoa";
            this.cmnusMenuXoa.Size = new System.Drawing.Size(95, 32);
            this.cmnusMenuXoa.Text = "Xóa";
            this.cmnusMenuXoa.Click += new System.EventHandler(this.cmnusMenuXoa_Click);
            // 
            // nudPage
            // 
            this.nudPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(75)))), ((int)(((byte)(150)))));
            this.nudPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudPage.Location = new System.Drawing.Point(1355, 108);
            this.nudPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPage.Name = "nudPage";
            this.nudPage.Size = new System.Drawing.Size(150, 30);
            this.nudPage.TabIndex = 61;
            this.nudPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPage.ValueChanged += new System.EventHandler(this.nudPage_ValueChanged);
            // 
            // FDanhSachTamTruTamVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.nudPage);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.flpnlPhanLoai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gvTVTT);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSachTamTruTamVang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDanhSachTamTruTamVang";
            this.Load += new System.EventHandler(this.FDanhSachTamTruTamVang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTVTT)).EndInit();
            this.flpnlPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.cmnusMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView gvTVTT;
        private TextBox txtTimKiem;
        private FlowLayoutPanel flpnlPhanLoai;
        private Button btnTatCa;
        private Button btnTV;
        private Button btnTT;
        private PictureBox picTimKiem;
        private Button btnThem;
        private ContextMenuStrip cmnusMenu;
        private ToolStripMenuItem cmnusMenuXoa;
        private Button btnQuaHan;
        private NumericUpDown nudPage;
    }
}