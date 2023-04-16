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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gvHoKhau = new DataGridView();
            cmnusMenu = new ContextMenuStrip(components);
            cmnusMenuChiTiet = new ToolStripMenuItem();
            cmnusMenuTachGop = new ToolStripMenuItem();
            flpnlPhanLoai = new FlowLayoutPanel();
            btnLoc = new Button();
            btnTatCa = new Button();
            btnSoTV = new Button();
            txtTimKiem = new TextBox();
            picTimKiem = new PictureBox();
            btnThem = new Button();
            nudPage = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)gvHoKhau).BeginInit();
            cmnusMenu.SuspendLayout();
            flpnlPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPage).BeginInit();
            SuspendLayout();
            // 
            // gvHoKhau
            // 
            gvHoKhau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvHoKhau.BackgroundColor = Color.WhiteSmoke;
            gvHoKhau.BorderStyle = BorderStyle.None;
            gvHoKhau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvHoKhau.ContextMenuStrip = cmnusMenu;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gvHoKhau.DefaultCellStyle = dataGridViewCellStyle1;
            gvHoKhau.Location = new Point(20, 177);
            gvHoKhau.Name = "gvHoKhau";
            gvHoKhau.RowHeadersWidth = 51;
            gvHoKhau.RowTemplate.Height = 29;
            gvHoKhau.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvHoKhau.Size = new Size(1500, 490);
            gvHoKhau.TabIndex = 0;
            gvHoKhau.CellClick += gvHoKhau_CellClick;
            gvHoKhau.CellContentClick += gvHoKhau_CellContentClick;
            // 
            // cmnusMenu
            // 
            cmnusMenu.BackColor = Color.WhiteSmoke;
            cmnusMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmnusMenu.ImageScalingSize = new Size(20, 20);
            cmnusMenu.Items.AddRange(new ToolStripItem[] { cmnusMenuChiTiet, cmnusMenuTachGop });
            cmnusMenu.Name = "contextMenuStrip1";
            cmnusMenu.RenderMode = ToolStripRenderMode.Professional;
            cmnusMenu.ShowImageMargin = false;
            cmnusMenu.Size = new Size(232, 68);
            // 
            // cmnusMenuChiTiet
            // 
            cmnusMenuChiTiet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmnusMenuChiTiet.Name = "cmnusMenuChiTiet";
            cmnusMenuChiTiet.Size = new Size(231, 32);
            cmnusMenuChiTiet.Text = "Chi tiết";
            cmnusMenuChiTiet.Click += cmnusMenuChiTiet_Click;
            // 
            // cmnusMenuTachGop
            // 
            cmnusMenuTachGop.Name = "cmnusMenuTachGop";
            cmnusMenuTachGop.Size = new Size(231, 32);
            cmnusMenuTachGop.Text = "Tách/Gộp hộ khẩu";
            cmnusMenuTachGop.Click += cmnusMenuTachGop_Click;
            // 
            // flpnlPhanLoai
            // 
            flpnlPhanLoai.Controls.Add(btnLoc);
            flpnlPhanLoai.Controls.Add(btnTatCa);
            flpnlPhanLoai.Controls.Add(btnSoTV);
            flpnlPhanLoai.Location = new Point(20, 123);
            flpnlPhanLoai.Name = "flpnlPhanLoai";
            flpnlPhanLoai.Size = new Size(699, 47);
            flpnlPhanLoai.TabIndex = 9;
            // 
            // btnLoc
            // 
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Image = Properties.Resources.dots__2_;
            btnLoc.Location = new Point(3, 3);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(32, 40);
            btnLoc.TabIndex = 60;
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnTatCa
            // 
            btnTatCa.BackColor = Color.Gainsboro;
            btnTatCa.FlatAppearance.BorderColor = Color.Gray;
            btnTatCa.FlatStyle = FlatStyle.Flat;
            btnTatCa.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTatCa.ForeColor = Color.Black;
            btnTatCa.Location = new Point(41, 3);
            btnTatCa.Name = "btnTatCa";
            btnTatCa.Size = new Size(125, 40);
            btnTatCa.TabIndex = 4;
            btnTatCa.Text = "Tất cả";
            btnTatCa.UseVisualStyleBackColor = false;
            btnTatCa.Click += btnTatCa_Click;
            // 
            // btnSoTV
            // 
            btnSoTV.BackColor = Color.Gainsboro;
            btnSoTV.FlatAppearance.BorderColor = Color.Gray;
            btnSoTV.FlatStyle = FlatStyle.Flat;
            btnSoTV.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSoTV.ForeColor = Color.Black;
            btnSoTV.Location = new Point(172, 3);
            btnSoTV.Name = "btnSoTV";
            btnSoTV.Size = new Size(125, 40);
            btnSoTV.TabIndex = 5;
            btnSoTV.Text = "Thành viên";
            btnSoTV.UseVisualStyleBackColor = false;
            btnSoTV.Click += btnSoTV_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.Gainsboro;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(20, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(1441, 31);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.search;
            picTimKiem.Location = new Point(1483, 12);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(37, 31);
            picTimKiem.TabIndex = 57;
            picTimKiem.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = Properties.Resources.page;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(1214, 120);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 50);
            btnThem.TabIndex = 58;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // nudPage
            // 
            nudPage.BackColor = Color.FromArgb(14, 75, 150);
            nudPage.BorderStyle = BorderStyle.None;
            nudPage.ForeColor = Color.WhiteSmoke;
            nudPage.Location = new Point(1370, 126);
            nudPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPage.Name = "nudPage";
            nudPage.Size = new Size(150, 30);
            nudPage.TabIndex = 59;
            nudPage.TextAlign = HorizontalAlignment.Center;
            nudPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudPage.ValueChanged += nudPage_ValueChanged;
            // 
            // FDanhSachHoKhau
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1532, 679);
            Controls.Add(nudPage);
            Controls.Add(btnThem);
            Controls.Add(picTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(flpnlPhanLoai);
            Controls.Add(gvHoKhau);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDanhSachHoKhau";
            Text = "FDanhSachHoKhau";
            Load += FDanhSachHoKhau_Load;
            ((System.ComponentModel.ISupportInitialize)gvHoKhau).EndInit();
            cmnusMenu.ResumeLayout(false);
            flpnlPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
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