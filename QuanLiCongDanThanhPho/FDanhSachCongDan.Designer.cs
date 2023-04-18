namespace QuanLiCongDanThanhPho
{
    partial class FDanhSachCongDan
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
            this.gvDanhSachCongDan = new System.Windows.Forms.DataGridView();
            this.cmnusMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnusMenuChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnusMenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTuoiTac = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnNu = new System.Windows.Forms.Button();
            this.fpnlPhanLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnDocThan = new System.Windows.Forms.Button();
            this.btnKetHon = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.nudPage = new System.Windows.Forms.NumericUpDown();
            this.fpnlChucNang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThue = new System.Windows.Forms.Button();
            this.btnTamVang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongDan)).BeginInit();
            this.cmnusMenu.SuspendLayout();
            this.fpnlPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).BeginInit();
            this.fpnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvDanhSachCongDan
            // 
            this.gvDanhSachCongDan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDanhSachCongDan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvDanhSachCongDan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDanhSachCongDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachCongDan.ContextMenuStrip = this.cmnusMenu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDanhSachCongDan.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvDanhSachCongDan.Location = new System.Drawing.Point(15, 165);
            this.gvDanhSachCongDan.Name = "gvDanhSachCongDan";
            this.gvDanhSachCongDan.RowHeadersWidth = 51;
            this.gvDanhSachCongDan.RowTemplate.Height = 29;
            this.gvDanhSachCongDan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDanhSachCongDan.Size = new System.Drawing.Size(1500, 502);
            this.gvDanhSachCongDan.TabIndex = 0;
            this.gvDanhSachCongDan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDanhSachCongDan_CellClick);
            // 
            // cmnusMenu
            // 
            this.cmnusMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmnusMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmnusMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnusMenuChiTiet,
            this.cmnusMenuXoa});
            this.cmnusMenu.Name = "contextMenuStrip1";
            this.cmnusMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmnusMenu.ShowImageMargin = false;
            this.cmnusMenu.Size = new System.Drawing.Size(129, 68);
            // 
            // cmnusMenuChiTiet
            // 
            this.cmnusMenuChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmnusMenuChiTiet.Name = "cmnusMenuChiTiet";
            this.cmnusMenuChiTiet.Size = new System.Drawing.Size(128, 32);
            this.cmnusMenuChiTiet.Text = "Chi tiết";
            this.cmnusMenuChiTiet.Click += new System.EventHandler(this.cmnusMenuChiTiet_Click);
            // 
            // cmnusMenuXoa
            // 
            this.cmnusMenuXoa.Name = "cmnusMenuXoa";
            this.cmnusMenuXoa.Size = new System.Drawing.Size(128, 32);
            this.cmnusMenuXoa.Text = "Xóa";
            this.cmnusMenuXoa.Click += new System.EventHandler(this.cmnusMenuXoa_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(15, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1462, 31);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTatCa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTatCa.ForeColor = System.Drawing.Color.Black;
            this.btnTatCa.Location = new System.Drawing.Point(41, 3);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(125, 40);
            this.btnTatCa.TabIndex = 4;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnTuoiTac
            // 
            this.btnTuoiTac.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTuoiTac.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTuoiTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuoiTac.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTuoiTac.ForeColor = System.Drawing.Color.Black;
            this.btnTuoiTac.Location = new System.Drawing.Point(172, 3);
            this.btnTuoiTac.Name = "btnTuoiTac";
            this.btnTuoiTac.Size = new System.Drawing.Size(125, 40);
            this.btnTuoiTac.TabIndex = 5;
            this.btnTuoiTac.Text = "Tuổi tác";
            this.btnTuoiTac.UseVisualStyleBackColor = false;
            this.btnTuoiTac.Click += new System.EventHandler(this.btnTuoiTac_Click);
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNam.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNam.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNam.ForeColor = System.Drawing.Color.Black;
            this.btnNam.Location = new System.Drawing.Point(303, 3);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(125, 40);
            this.btnNam.TabIndex = 6;
            this.btnNam.Text = "Nam";
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnNu
            // 
            this.btnNu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNu.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNu.ForeColor = System.Drawing.Color.Black;
            this.btnNu.Location = new System.Drawing.Point(434, 3);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(125, 40);
            this.btnNu.TabIndex = 7;
            this.btnNu.Text = "Nữ";
            this.btnNu.UseVisualStyleBackColor = false;
            this.btnNu.Click += new System.EventHandler(this.btnNu_Click);
            // 
            // fpnlPhanLoai
            // 
            this.fpnlPhanLoai.Controls.Add(this.btnLoc);
            this.fpnlPhanLoai.Controls.Add(this.btnTatCa);
            this.fpnlPhanLoai.Controls.Add(this.btnTuoiTac);
            this.fpnlPhanLoai.Controls.Add(this.btnNam);
            this.fpnlPhanLoai.Controls.Add(this.btnNu);
            this.fpnlPhanLoai.Controls.Add(this.btnDocThan);
            this.fpnlPhanLoai.Controls.Add(this.btnKetHon);
            this.fpnlPhanLoai.Location = new System.Drawing.Point(12, 64);
            this.fpnlPhanLoai.Name = "fpnlPhanLoai";
            this.fpnlPhanLoai.Size = new System.Drawing.Size(843, 47);
            this.fpnlPhanLoai.TabIndex = 8;
            // 
            // btnLoc
            // 
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Image = global::QuanLiCongDanThanhPho.Properties.Resources.dots__2_;
            this.btnLoc.Location = new System.Drawing.Point(3, 3);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(32, 40);
            this.btnLoc.TabIndex = 10;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnDocThan
            // 
            this.btnDocThan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDocThan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDocThan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocThan.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDocThan.ForeColor = System.Drawing.Color.Black;
            this.btnDocThan.Location = new System.Drawing.Point(565, 3);
            this.btnDocThan.Name = "btnDocThan";
            this.btnDocThan.Size = new System.Drawing.Size(125, 40);
            this.btnDocThan.TabIndex = 8;
            this.btnDocThan.Text = "Độc thân";
            this.btnDocThan.UseVisualStyleBackColor = false;
            this.btnDocThan.Click += new System.EventHandler(this.btnDocThan_Click);
            // 
            // btnKetHon
            // 
            this.btnKetHon.BackColor = System.Drawing.Color.Gainsboro;
            this.btnKetHon.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKetHon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetHon.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKetHon.ForeColor = System.Drawing.Color.Black;
            this.btnKetHon.Location = new System.Drawing.Point(696, 3);
            this.btnKetHon.Name = "btnKetHon";
            this.btnKetHon.Size = new System.Drawing.Size(125, 40);
            this.btnKetHon.TabIndex = 9;
            this.btnKetHon.Text = "Kết hôn";
            this.btnKetHon.UseVisualStyleBackColor = false;
            this.btnKetHon.Click += new System.EventHandler(this.btnKetHon_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.page;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 50);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search;
            this.picTimKiem.Location = new System.Drawing.Point(1483, 12);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(37, 31);
            this.picTimKiem.TabIndex = 56;
            this.picTimKiem.TabStop = false;
            // 
            // nudPage
            // 
            this.nudPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(75)))), ((int)(((byte)(150)))));
            this.nudPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudPage.Location = new System.Drawing.Point(1370, 76);
            this.nudPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPage.Name = "nudPage";
            this.nudPage.Size = new System.Drawing.Size(150, 30);
            this.nudPage.TabIndex = 57;
            this.nudPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPage.ValueChanged += new System.EventHandler(this.nudPage_ValueChanged);
            // 
            // fpnlChucNang
            // 
            this.fpnlChucNang.Controls.Add(this.btnThem);
            this.fpnlChucNang.Controls.Add(this.btnThue);
            this.fpnlChucNang.Controls.Add(this.btnTamVang);
            this.fpnlChucNang.Controls.Add(this.button1);
            this.fpnlChucNang.Location = new System.Drawing.Point(861, 64);
            this.fpnlChucNang.Name = "fpnlChucNang";
            this.fpnlChucNang.Size = new System.Drawing.Size(520, 62);
            this.fpnlChucNang.TabIndex = 58;
            // 
            // btnThue
            // 
            this.btnThue.BackColor = System.Drawing.Color.Transparent;
            this.btnThue.FlatAppearance.BorderSize = 0;
            this.btnThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThue.Image = global::QuanLiCongDanThanhPho.Properties.Resources.personal;
            this.btnThue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThue.Location = new System.Drawing.Point(159, 3);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(150, 50);
            this.btnThue.TabIndex = 57;
            this.btnThue.Text = "Thuế";
            this.btnThue.UseVisualStyleBackColor = false;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // btnTamVang
            // 
            this.btnTamVang.BackColor = System.Drawing.Color.Transparent;
            this.btnTamVang.FlatAppearance.BorderSize = 0;
            this.btnTamVang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamVang.Image = global::QuanLiCongDanThanhPho.Properties.Resources.potential;
            this.btnTamVang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTamVang.Location = new System.Drawing.Point(315, 3);
            this.btnTamVang.Name = "btnTamVang";
            this.btnTamVang.Size = new System.Drawing.Size(150, 50);
            this.btnTamVang.TabIndex = 58;
            this.btnTamVang.Text = "     Tạm vắng";
            this.btnTamVang.UseVisualStyleBackColor = false;
            this.btnTamVang.Click += new System.EventHandler(this.btnTamVang_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 59;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FDanhSachCongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.fpnlChucNang);
            this.Controls.Add(this.nudPage);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.fpnlPhanLoai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gvDanhSachCongDan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSachCongDan";
            this.Text = "DanhSachCongDan";
            this.Load += new System.EventHandler(this.FDanhSachCongDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongDan)).EndInit();
            this.cmnusMenu.ResumeLayout(false);
            this.fpnlPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).EndInit();
            this.fpnlChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvDanhSachCongDan;
        private TextBox txtTimKiem;
        private Button btnTatCa;
        private Button btnTuoiTac;
        private Button btnNam;
        private Button btnNu;
        private FlowLayoutPanel fpnlPhanLoai;
        private Button btnDocThan;
        private Button btnKetHon;
        private PictureBox picTimKiem;
        private Button btnThem;
        private ContextMenuStrip cmnusMenu;
        private ToolStripMenuItem cmnusMenuChiTiet;
        private ToolStripMenuItem cmnusMenuXoa;
        private NumericUpDown nudPage;
        private Button btnLoc;
        private FlowLayoutPanel fpnlChucNang;
        private Button btnThue;
        private Button btnTamVang;
        private Button button1;
    }
}