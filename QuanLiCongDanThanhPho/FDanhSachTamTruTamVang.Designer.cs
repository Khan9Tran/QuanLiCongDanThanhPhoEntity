namespace QuanLiCongDanThanhPho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvTVTT = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.flpnlPhanLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTV = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnQuaHan = new System.Windows.Forms.Button();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmnusMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnusMenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.giaHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gvTVTT.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvTVTT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvTVTT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gvTVTT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTVTT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTVTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTVTT.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvTVTT.EnableHeadersVisualStyles = false;
            this.gvTVTT.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gvTVTT.Location = new System.Drawing.Point(25, 141);
            this.gvTVTT.Name = "gvTVTT";
            this.gvTVTT.RowHeadersVisible = false;
            this.gvTVTT.RowHeadersWidth = 51;
            this.gvTVTT.RowTemplate.Height = 29;
            this.gvTVTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTVTT.Size = new System.Drawing.Size(1480, 504);
            this.gvTVTT.TabIndex = 1;
            this.gvTVTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTVTT_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(25, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1422, 38);
            this.txtTimKiem.TabIndex = 56;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // flpnlPhanLoai
            // 
            this.flpnlPhanLoai.Controls.Add(this.btnLoc);
            this.flpnlPhanLoai.Controls.Add(this.btnTatCa);
            this.flpnlPhanLoai.Controls.Add(this.btnTV);
            this.flpnlPhanLoai.Controls.Add(this.btnTT);
            this.flpnlPhanLoai.Controls.Add(this.btnQuaHan);
            this.flpnlPhanLoai.Location = new System.Drawing.Point(25, 82);
            this.flpnlPhanLoai.Name = "flpnlPhanLoai";
            this.flpnlPhanLoai.Size = new System.Drawing.Size(699, 47);
            this.flpnlPhanLoai.TabIndex = 58;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Image = global::QuanLiCongDanThanhPho.Properties.Resources.dots__2_;
            this.btnLoc.Location = new System.Drawing.Point(3, 3);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(32, 40);
            this.btnLoc.TabIndex = 62;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTatCa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTatCa.FlatAppearance.BorderSize = 0;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTatCa.ForeColor = System.Drawing.Color.White;
            this.btnTatCa.Location = new System.Drawing.Point(41, 3);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(125, 40);
            this.btnTatCa.TabIndex = 4;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnTV
            // 
            this.btnTV.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTV.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTV.FlatAppearance.BorderSize = 0;
            this.btnTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTV.ForeColor = System.Drawing.Color.White;
            this.btnTV.Location = new System.Drawing.Point(172, 3);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(125, 40);
            this.btnTV.TabIndex = 5;
            this.btnTV.Text = "Tạm vắng";
            this.btnTV.UseVisualStyleBackColor = false;
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTT.FlatAppearance.BorderSize = 0;
            this.btnTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTT.ForeColor = System.Drawing.Color.White;
            this.btnTT.Location = new System.Drawing.Point(303, 3);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(144, 40);
            this.btnTT.TabIndex = 6;
            this.btnTT.Text = "Tạm trú";
            this.btnTT.UseVisualStyleBackColor = false;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // btnQuaHan
            // 
            this.btnQuaHan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnQuaHan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnQuaHan.FlatAppearance.BorderSize = 0;
            this.btnQuaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuaHan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuaHan.ForeColor = System.Drawing.Color.White;
            this.btnQuaHan.Location = new System.Drawing.Point(453, 3);
            this.btnQuaHan.Name = "btnQuaHan";
            this.btnQuaHan.Size = new System.Drawing.Size(144, 40);
            this.btnQuaHan.TabIndex = 61;
            this.btnQuaHan.Text = "Quá hạn";
            this.btnQuaHan.UseVisualStyleBackColor = false;
            this.btnQuaHan.Click += new System.EventHandler(this.btnQuaHan_Click);
            // 
            // picTimKiem
            // 
            this.picTimKiem.BackColor = System.Drawing.Color.RoyalBlue;
            this.picTimKiem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search;
            this.picTimKiem.Location = new System.Drawing.Point(1443, 12);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(37, 38);
            this.picTimKiem.TabIndex = 59;
            this.picTimKiem.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.add_file;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1187, 85);
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
            this.cmnusMenuXoa,
            this.giaHạnToolStripMenuItem});
            this.cmnusMenu.Name = "contextMenuStrip1";
            this.cmnusMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmnusMenu.ShowImageMargin = false;
            this.cmnusMenu.Size = new System.Drawing.Size(132, 68);
            // 
            // cmnusMenuXoa
            // 
            this.cmnusMenuXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmnusMenuXoa.Name = "cmnusMenuXoa";
            this.cmnusMenuXoa.Size = new System.Drawing.Size(131, 32);
            this.cmnusMenuXoa.Text = "Xóa";
            this.cmnusMenuXoa.Click += new System.EventHandler(this.cmnusMenuXoa_Click);
            // 
            // giaHạnToolStripMenuItem
            // 
            this.giaHạnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngayToolStripMenuItem,
            this.tuanToolStripMenuItem,
            this.thangToolStripMenuItem,
            this.namToolStripMenuItem1});
            this.giaHạnToolStripMenuItem.Name = "giaHạnToolStripMenuItem";
            this.giaHạnToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.giaHạnToolStripMenuItem.Text = "Gia hạn";
            // 
            // ngayToolStripMenuItem
            // 
            this.ngayToolStripMenuItem.Name = "ngayToolStripMenuItem";
            this.ngayToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.ngayToolStripMenuItem.Text = "3 ngày";
            this.ngayToolStripMenuItem.Click += new System.EventHandler(this.ngayToolStripMenuItem_Click);
            // 
            // tuanToolStripMenuItem
            // 
            this.tuanToolStripMenuItem.Name = "tuanToolStripMenuItem";
            this.tuanToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.tuanToolStripMenuItem.Text = "1 tuần";
            this.tuanToolStripMenuItem.Click += new System.EventHandler(this.tuanToolStripMenuItem_Click);
            // 
            // thangToolStripMenuItem
            // 
            this.thangToolStripMenuItem.Name = "thangToolStripMenuItem";
            this.thangToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.thangToolStripMenuItem.Text = "1 tháng";
            this.thangToolStripMenuItem.Click += new System.EventHandler(this.thangToolStripMenuItem_Click);
            // 
            // namToolStripMenuItem1
            // 
            this.namToolStripMenuItem1.Name = "namToolStripMenuItem1";
            this.namToolStripMenuItem1.Size = new System.Drawing.Size(171, 32);
            this.namToolStripMenuItem1.Text = "1 năm";
            this.namToolStripMenuItem1.Click += new System.EventHandler(this.namToolStripMenuItem1_Click);
            // 
            // nudPage
            // 
            this.nudPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(75)))), ((int)(((byte)(150)))));
            this.nudPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudPage.Location = new System.Drawing.Point(1355, 90);
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
            this.BackColor = System.Drawing.Color.White;
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
        private Button btnLoc;
        private ToolStripMenuItem giaHạnToolStripMenuItem;
        private ToolStripMenuItem ngayToolStripMenuItem;
        private ToolStripMenuItem tuanToolStripMenuItem;
        private ToolStripMenuItem thangToolStripMenuItem;
        private ToolStripMenuItem namToolStripMenuItem1;
    }
}