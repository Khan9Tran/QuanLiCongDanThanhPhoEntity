namespace QuanLiCongDanThanhPho
{
    partial class FDanhSachHoKhau
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
            this.gvHoKhau = new System.Windows.Forms.DataGridView();
            this.cmnusMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnusMenuChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnusMenuTachGop = new System.Windows.Forms.ToolStripMenuItem();
            this.flpnlPhanLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnSoTV = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.nudPage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoKhau)).BeginInit();
            this.cmnusMenu.SuspendLayout();
            this.flpnlPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).BeginInit();
            this.SuspendLayout();
            // 
            // gvHoKhau
            // 
            this.gvHoKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHoKhau.BackgroundColor = System.Drawing.Color.White;
            this.gvHoKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvHoKhau.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gvHoKhau.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHoKhau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvHoKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHoKhau.ContextMenuStrip = this.cmnusMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHoKhau.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvHoKhau.EnableHeadersVisualStyles = false;
            this.gvHoKhau.Location = new System.Drawing.Point(20, 177);
            this.gvHoKhau.Name = "gvHoKhau";
            this.gvHoKhau.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvHoKhau.RowHeadersVisible = false;
            this.gvHoKhau.RowHeadersWidth = 51;
            this.gvHoKhau.RowTemplate.Height = 29;
            this.gvHoKhau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHoKhau.Size = new System.Drawing.Size(1500, 490);
            this.gvHoKhau.TabIndex = 0;
            this.gvHoKhau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHoKhau_CellClick);
            // 
            // cmnusMenu
            // 
            this.cmnusMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmnusMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmnusMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnusMenuChiTiet,
            this.cmnusMenuTachGop});
            this.cmnusMenu.Name = "contextMenuStrip1";
            this.cmnusMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmnusMenu.ShowImageMargin = false;
            this.cmnusMenu.Size = new System.Drawing.Size(232, 68);
            // 
            // cmnusMenuChiTiet
            // 
            this.cmnusMenuChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmnusMenuChiTiet.Name = "cmnusMenuChiTiet";
            this.cmnusMenuChiTiet.Size = new System.Drawing.Size(231, 32);
            this.cmnusMenuChiTiet.Text = "Chi tiết";
            this.cmnusMenuChiTiet.Click += new System.EventHandler(this.cmnusMenuChiTiet_Click);
            // 
            // cmnusMenuTachGop
            // 
            this.cmnusMenuTachGop.Name = "cmnusMenuTachGop";
            this.cmnusMenuTachGop.Size = new System.Drawing.Size(231, 32);
            this.cmnusMenuTachGop.Text = "Tách/Gộp hộ khẩu";
            this.cmnusMenuTachGop.Click += new System.EventHandler(this.cmnusMenuTachGop_Click);
            // 
            // flpnlPhanLoai
            // 
            this.flpnlPhanLoai.Controls.Add(this.btnLoc);
            this.flpnlPhanLoai.Controls.Add(this.btnTatCa);
            this.flpnlPhanLoai.Controls.Add(this.btnSoTV);
            this.flpnlPhanLoai.Location = new System.Drawing.Point(20, 123);
            this.flpnlPhanLoai.Name = "flpnlPhanLoai";
            this.flpnlPhanLoai.Size = new System.Drawing.Size(699, 47);
            this.flpnlPhanLoai.TabIndex = 9;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Image = global::QuanLiCongDanThanhPho.Properties.Resources.dots__2_;
            this.btnLoc.Location = new System.Drawing.Point(3, 3);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(32, 40);
            this.btnLoc.TabIndex = 60;
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
            // btnSoTV
            // 
            this.btnSoTV.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSoTV.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSoTV.FlatAppearance.BorderSize = 0;
            this.btnSoTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoTV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoTV.ForeColor = System.Drawing.Color.White;
            this.btnSoTV.Location = new System.Drawing.Point(172, 3);
            this.btnSoTV.Name = "btnSoTV";
            this.btnSoTV.Size = new System.Drawing.Size(125, 40);
            this.btnSoTV.TabIndex = 5;
            this.btnSoTV.Text = "Thành viên";
            this.btnSoTV.UseVisualStyleBackColor = false;
            this.btnSoTV.Click += new System.EventHandler(this.btnSoTV_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(20, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1441, 38);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // picTimKiem
            // 
            this.picTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.picTimKiem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search;
            this.picTimKiem.Location = new System.Drawing.Point(1456, 12);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(37, 38);
            this.picTimKiem.TabIndex = 57;
            this.picTimKiem.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.add_file;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1214, 120);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 50);
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nudPage
            // 
            this.nudPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(75)))), ((int)(((byte)(150)))));
            this.nudPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudPage.Location = new System.Drawing.Point(1370, 126);
            this.nudPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPage.Name = "nudPage";
            this.nudPage.Size = new System.Drawing.Size(150, 30);
            this.nudPage.TabIndex = 59;
            this.nudPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPage.Click += new System.EventHandler(this.nudPage_ValueChanged);
            // 
            // FDanhSachHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.nudPage);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.flpnlPhanLoai);
            this.Controls.Add(this.gvHoKhau);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSachHoKhau";
            this.Text = "FDanhSachHoKhau";
            this.Load += new System.EventHandler(this.FDanhSachHoKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHoKhau)).EndInit();
            this.cmnusMenu.ResumeLayout(false);
            this.flpnlPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvHoKhau;
        private FlowLayoutPanel flpnlPhanLoai;
        private Button btnTatCa;
        private Button btnSoTV;
        private TextBox txtTimKiem;
        private PictureBox picTimKiem;
        private ContextMenuStrip cmnusMenu;
        private ToolStripMenuItem cmnusMenuChiTiet;
        private ToolStripMenuItem cmnusMenuTachGop;
        private Button btnThem;
        private NumericUpDown nudPage;
        private Button btnLoc;
    }
}