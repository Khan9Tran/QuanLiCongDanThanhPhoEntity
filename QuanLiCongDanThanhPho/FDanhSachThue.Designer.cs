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
            this.gvThue.Location = new System.Drawing.Point(25, 201);
            this.gvThue.Name = "gvThue";
            this.gvThue.RowHeadersWidth = 51;
            this.gvThue.RowTemplate.Height = 29;
            this.gvThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvThue.Size = new System.Drawing.Size(1477, 466);
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
            this.flpnPhanLoai.Location = new System.Drawing.Point(25, 148);
            this.flpnPhanLoai.Name = "flpnPhanLoai";
            this.flpnPhanLoai.Size = new System.Drawing.Size(699, 47);
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
            this.btnCongDanCanTaoThue.Size = new System.Drawing.Size(204, 40);
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
            this.btnThem.Location = new System.Drawing.Point(1209, 139);
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
            this.nudPage.Location = new System.Drawing.Point(1352, 148);
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
            // FDanhSachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.nudPage);
            this.Controls.Add(this.btnThem);
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
    }
}