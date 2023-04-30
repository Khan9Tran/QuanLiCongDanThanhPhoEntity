namespace QuanLiCongDanThanhPho
{
    partial class FDanhSachThue
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
            this.gvThue = new System.Windows.Forms.DataGridView();
            this.cmnusMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnusMenuChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnusMenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.flpnPhanLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTienDaNop = new System.Windows.Forms.Button();
            this.btnTreHan = new System.Windows.Forms.Button();
            this.btnCongDanCanTaoThue = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.nudPage = new System.Windows.Forms.NumericUpDown();
            this.txtDongThue = new System.Windows.Forms.TextBox();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).BeginInit();
            this.cmnusMenu.SuspendLayout();
            this.flpnPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).BeginInit();
            this.SuspendLayout();
            // 
            // gvThue
            // 
            this.gvThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvThue.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThue.ContextMenuStrip = this.cmnusMenu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvThue.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvThue.Location = new System.Drawing.Point(25, 127);
            this.gvThue.Name = "gvThue";
            this.gvThue.RowHeadersWidth = 51;
            this.gvThue.RowTemplate.Height = 29;
            this.gvThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvThue.Size = new System.Drawing.Size(1477, 426);
            this.gvThue.TabIndex = 0;
            this.gvThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvThue_CellClick);
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
            // flpnPhanLoai
            // 
            this.flpnPhanLoai.Controls.Add(this.btnLoc);
            this.flpnPhanLoai.Controls.Add(this.btnTatCa);
            this.flpnPhanLoai.Controls.Add(this.btnTienDaNop);
            this.flpnPhanLoai.Controls.Add(this.btnTreHan);
            this.flpnPhanLoai.Controls.Add(this.btnCongDanCanTaoThue);
            this.flpnPhanLoai.Location = new System.Drawing.Point(25, 71);
            this.flpnPhanLoai.Name = "flpnPhanLoai";
            this.flpnPhanLoai.Size = new System.Drawing.Size(858, 47);
            this.flpnPhanLoai.TabIndex = 9;
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
            // btnTienDaNop
            // 
            this.btnTienDaNop.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTienDaNop.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTienDaNop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienDaNop.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTienDaNop.ForeColor = System.Drawing.Color.Black;
            this.btnTienDaNop.Location = new System.Drawing.Point(172, 3);
            this.btnTienDaNop.Name = "btnTienDaNop";
            this.btnTienDaNop.Size = new System.Drawing.Size(125, 40);
            this.btnTienDaNop.TabIndex = 6;
            this.btnTienDaNop.Text = "Tiền đã nộp";
            this.btnTienDaNop.UseVisualStyleBackColor = false;
            this.btnTienDaNop.Click += new System.EventHandler(this.btnTienDaNop_Click);
            // 
            // btnTreHan
            // 
            this.btnTreHan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTreHan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTreHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreHan.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTreHan.ForeColor = System.Drawing.Color.Black;
            this.btnTreHan.Location = new System.Drawing.Point(303, 3);
            this.btnTreHan.Name = "btnTreHan";
            this.btnTreHan.Size = new System.Drawing.Size(128, 40);
            this.btnTreHan.TabIndex = 59;
            this.btnTreHan.Text = "Trễ Hạn";
            this.btnTreHan.UseVisualStyleBackColor = false;
            this.btnTreHan.Click += new System.EventHandler(this.btnTreHan_Click);
            // 
            // btnCongDanCanTaoThue
            // 
            this.btnCongDanCanTaoThue.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCongDanCanTaoThue.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCongDanCanTaoThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongDanCanTaoThue.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCongDanCanTaoThue.ForeColor = System.Drawing.Color.Black;
            this.btnCongDanCanTaoThue.Location = new System.Drawing.Point(437, 3);
            this.btnCongDanCanTaoThue.Name = "btnCongDanCanTaoThue";
            this.btnCongDanCanTaoThue.Size = new System.Drawing.Size(128, 40);
            this.btnCongDanCanTaoThue.TabIndex = 61;
            this.btnCongDanCanTaoThue.Text = "Truy thu thuế";
            this.btnCongDanCanTaoThue.UseVisualStyleBackColor = false;
            this.btnCongDanCanTaoThue.Click += new System.EventHandler(this.btnCongDanCanTaoThue_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(25, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1418, 31);
            this.txtTimKiem.TabIndex = 55;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search;
            this.picTimKiem.Location = new System.Drawing.Point(1465, 12);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(37, 31);
            this.picTimKiem.TabIndex = 57;
            this.picTimKiem.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.page;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1194, 71);
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
            this.nudPage.Location = new System.Drawing.Point(1352, 88);
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
            this.nudPage.ValueChanged += new System.EventHandler(this.nudPage_ValueChanged);
            // 
            // txtDongThue
            // 
            this.txtDongThue.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDongThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDongThue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDongThue.Location = new System.Drawing.Point(898, 605);
            this.txtDongThue.Name = "txtDongThue";
            this.txtDongThue.Size = new System.Drawing.Size(428, 31);
            this.txtDongThue.TabIndex = 60;
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.BackColor = System.Drawing.Color.Gainsboro;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThongTin.Location = new System.Drawing.Point(12, 605);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(105, 31);
            this.lblThongTin.TabIndex = 61;
            this.lblThongTin.Text = "Mã thuế:";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Image = global::QuanLiCongDanThanhPho.Properties.Resources.accept;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.Location = new System.Drawing.Point(1332, 596);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(170, 40);
            this.btnXacNhan.TabIndex = 62;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // FDanhSachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.txtDongThue);
            this.Controls.Add(this.nudPage);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.flpnPhanLoai);
            this.Controls.Add(this.gvThue);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSachThue";
            this.Text = "FDanhSachThue";
            this.Load += new System.EventHandler(this.FDanhSachThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).EndInit();
            this.cmnusMenu.ResumeLayout(false);
            this.flpnPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvThue;
        private FlowLayoutPanel flpnPhanLoai;
        private Button btnTatCa;
        private Button btnTienDaNop;
        private TextBox txtTimKiem;
        private PictureBox picTimKiem;
        private ContextMenuStrip cmnusMenu;
        private ToolStripMenuItem cmnusMenuChiTiet;
        private ToolStripMenuItem cmnusMenuXoa;
        private Button btnThem;
        private Button btnTreHan;
        private NumericUpDown nudPage;
        private Button btnLoc;
        private Button btnCongDanCanTaoThue;
        private TextBox txtDongThue;
        private Label lblThongTin;
        private Button btnXacNhan;
    }
}