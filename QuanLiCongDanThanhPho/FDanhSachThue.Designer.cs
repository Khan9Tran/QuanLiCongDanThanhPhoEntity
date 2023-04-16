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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gvThue = new DataGridView();
            cmnusMenu = new ContextMenuStrip(components);
            cmnusMenuChiTiet = new ToolStripMenuItem();
            cmnusMenuXoa = new ToolStripMenuItem();
            flpnPhanLoai = new FlowLayoutPanel();
            btnLoc = new Button();
            btnTatCa = new Button();
            btnTienDaNop = new Button();
            btnTreHan = new Button();
            txtTimKiem = new TextBox();
            picTimKiem = new PictureBox();
            btnThem = new Button();
            nudPage = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)gvThue).BeginInit();
            cmnusMenu.SuspendLayout();
            flpnPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPage).BeginInit();
            SuspendLayout();
            // 
            // gvThue
            // 
            gvThue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvThue.BackgroundColor = Color.WhiteSmoke;
            gvThue.BorderStyle = BorderStyle.None;
            gvThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvThue.ContextMenuStrip = cmnusMenu;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gvThue.DefaultCellStyle = dataGridViewCellStyle1;
            gvThue.Location = new Point(25, 201);
            gvThue.Name = "gvThue";
            gvThue.RowHeadersWidth = 51;
            gvThue.RowTemplate.Height = 29;
            gvThue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvThue.Size = new Size(1477, 466);
            gvThue.TabIndex = 0;
            gvThue.CellClick += gvThue_CellClick;
            // 
            // cmnusMenu
            // 
            cmnusMenu.BackColor = Color.WhiteSmoke;
            cmnusMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmnusMenu.ImageScalingSize = new Size(20, 20);
            cmnusMenu.Items.AddRange(new ToolStripItem[] { cmnusMenuChiTiet, cmnusMenuXoa });
            cmnusMenu.Name = "contextMenuStrip1";
            cmnusMenu.RenderMode = ToolStripRenderMode.Professional;
            cmnusMenu.ShowImageMargin = false;
            cmnusMenu.Size = new Size(129, 68);
            // 
            // cmnusMenuChiTiet
            // 
            cmnusMenuChiTiet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmnusMenuChiTiet.Name = "cmnusMenuChiTiet";
            cmnusMenuChiTiet.Size = new Size(128, 32);
            cmnusMenuChiTiet.Text = "Chi tiết";
            cmnusMenuChiTiet.Click += cmnusMenuChiTiet_Click;
            // 
            // cmnusMenuXoa
            // 
            cmnusMenuXoa.Name = "cmnusMenuXoa";
            cmnusMenuXoa.Size = new Size(128, 32);
            cmnusMenuXoa.Text = "Xóa";
            cmnusMenuXoa.Click += cmnusMenuXoa_Click;
            // 
            // flpnPhanLoai
            // 
            flpnPhanLoai.Controls.Add(btnLoc);
            flpnPhanLoai.Controls.Add(btnTatCa);
            flpnPhanLoai.Controls.Add(btnTienDaNop);
            flpnPhanLoai.Controls.Add(btnTreHan);
            flpnPhanLoai.Location = new Point(25, 148);
            flpnPhanLoai.Name = "flpnPhanLoai";
            flpnPhanLoai.Size = new Size(699, 47);
            flpnPhanLoai.TabIndex = 9;
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
            // btnTienDaNop
            // 
            btnTienDaNop.BackColor = Color.Gainsboro;
            btnTienDaNop.FlatAppearance.BorderColor = Color.Gray;
            btnTienDaNop.FlatStyle = FlatStyle.Flat;
            btnTienDaNop.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTienDaNop.ForeColor = Color.Black;
            btnTienDaNop.Location = new Point(172, 3);
            btnTienDaNop.Name = "btnTienDaNop";
            btnTienDaNop.Size = new Size(125, 40);
            btnTienDaNop.TabIndex = 6;
            btnTienDaNop.Text = "Tiền đã nộp";
            btnTienDaNop.UseVisualStyleBackColor = false;
            btnTienDaNop.Click += btnTienDaNop_Click;
            // 
            // btnTreHan
            // 
            btnTreHan.BackColor = Color.Gainsboro;
            btnTreHan.FlatAppearance.BorderColor = Color.Gray;
            btnTreHan.FlatStyle = FlatStyle.Flat;
            btnTreHan.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTreHan.ForeColor = Color.Black;
            btnTreHan.Location = new Point(303, 3);
            btnTreHan.Name = "btnTreHan";
            btnTreHan.Size = new Size(128, 40);
            btnTreHan.TabIndex = 59;
            btnTreHan.Text = "Trễ Hạn";
            btnTreHan.UseVisualStyleBackColor = false;
            btnTreHan.Click += btnTreHan_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.Gainsboro;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(25, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(1418, 31);
            txtTimKiem.TabIndex = 55;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.search;
            picTimKiem.Location = new Point(1465, 12);
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
            btnThem.Location = new Point(1209, 139);
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
            nudPage.Location = new Point(1352, 148);
            nudPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPage.Name = "nudPage";
            nudPage.Size = new Size(150, 30);
            nudPage.TabIndex = 59;
            nudPage.TextAlign = HorizontalAlignment.Center;
            nudPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudPage.ValueChanged += nudPage_ValueChanged;
            // 
            // FDanhSachThue
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1532, 679);
            Controls.Add(nudPage);
            Controls.Add(btnThem);
            Controls.Add(picTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(flpnPhanLoai);
            Controls.Add(gvThue);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDanhSachThue";
            Text = "FDanhSachThue";
            Load += FDanhSachThue_Load;
            ((System.ComponentModel.ISupportInitialize)gvThue).EndInit();
            cmnusMenu.ResumeLayout(false);
            flpnPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}