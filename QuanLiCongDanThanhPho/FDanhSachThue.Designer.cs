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
            this.flpnPhanLoai.Controls.Add(this.btnLoc);
            this.flpnPhanLoai.Controls.Add(this.btnTatCa);
            this.flpnPhanLoai.Controls.Add(this.btnTienDaNop);
            this.flpnPhanLoai.Controls.Add(this.btnTreHan);
            this.flpnPhanLoai.Location = new System.Drawing.Point(25, 148);
            this.flpnPhanLoai.Name = "flpnPhanLoai";
            this.flpnPhanLoai.Size = new System.Drawing.Size(699, 47);
            this.flpnPhanLoai.TabIndex = 9;
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
        private Button btnCongDanCanTaoThue;
    }
}