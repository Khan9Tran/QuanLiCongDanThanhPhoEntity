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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gvTVTT = new DataGridView();
            txtTimKiem = new TextBox();
            flpnlPhanLoai = new FlowLayoutPanel();
            btnLoc = new Button();
            btnTatCa = new Button();
            btnTV = new Button();
            btnTT = new Button();
            btnQuaHan = new Button();
            picTimKiem = new PictureBox();
            btnThem = new Button();
            cmnusMenu = new ContextMenuStrip(components);
            cmnusMenuXoa = new ToolStripMenuItem();
            nudPage = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)gvTVTT).BeginInit();
            flpnlPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            cmnusMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPage).BeginInit();
            SuspendLayout();
            // 
            // gvTVTT
            // 
            gvTVTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvTVTT.BackgroundColor = Color.WhiteSmoke;
            gvTVTT.BorderStyle = BorderStyle.None;
            gvTVTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gvTVTT.DefaultCellStyle = dataGridViewCellStyle1;
            gvTVTT.ImeMode = ImeMode.Disable;
            gvTVTT.Location = new Point(25, 162);
            gvTVTT.Name = "gvTVTT";
            gvTVTT.RowHeadersWidth = 51;
            gvTVTT.RowTemplate.Height = 29;
            gvTVTT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvTVTT.Size = new Size(1480, 488);
            gvTVTT.TabIndex = 1;
            gvTVTT.CellClick += gvTVTT_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.Gainsboro;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(25, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(1422, 31);
            txtTimKiem.TabIndex = 56;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // flpnlPhanLoai
            // 
            flpnlPhanLoai.Controls.Add(btnLoc);
            flpnlPhanLoai.Controls.Add(btnTatCa);
            flpnlPhanLoai.Controls.Add(btnTV);
            flpnlPhanLoai.Controls.Add(btnTT);
            flpnlPhanLoai.Controls.Add(btnQuaHan);
            flpnlPhanLoai.Location = new Point(25, 108);
            flpnlPhanLoai.Name = "flpnlPhanLoai";
            flpnlPhanLoai.Size = new Size(699, 47);
            flpnlPhanLoai.TabIndex = 58;
            // 
            // btnLoc
            // 
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Image = Properties.Resources.dots__2_;
            btnLoc.Location = new Point(3, 3);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(32, 40);
            btnLoc.TabIndex = 62;
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
            // btnTV
            // 
            btnTV.BackColor = Color.Gainsboro;
            btnTV.FlatAppearance.BorderColor = Color.Gray;
            btnTV.FlatStyle = FlatStyle.Flat;
            btnTV.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTV.ForeColor = Color.Black;
            btnTV.Location = new Point(172, 3);
            btnTV.Name = "btnTV";
            btnTV.Size = new Size(125, 40);
            btnTV.TabIndex = 5;
            btnTV.Text = "Tạm vắng";
            btnTV.UseVisualStyleBackColor = false;
            btnTV.Click += btnTV_Click;
            // 
            // btnTT
            // 
            btnTT.BackColor = Color.Gainsboro;
            btnTT.FlatAppearance.BorderColor = Color.Gray;
            btnTT.FlatStyle = FlatStyle.Flat;
            btnTT.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTT.ForeColor = Color.Black;
            btnTT.Location = new Point(303, 3);
            btnTT.Name = "btnTT";
            btnTT.Size = new Size(144, 40);
            btnTT.TabIndex = 6;
            btnTT.Text = "Tạm trú";
            btnTT.UseVisualStyleBackColor = false;
            btnTT.Click += btnTT_Click;
            // 
            // btnQuaHan
            // 
            btnQuaHan.BackColor = Color.Gainsboro;
            btnQuaHan.FlatAppearance.BorderColor = Color.Gray;
            btnQuaHan.FlatStyle = FlatStyle.Flat;
            btnQuaHan.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuaHan.ForeColor = Color.Black;
            btnQuaHan.Location = new Point(453, 3);
            btnQuaHan.Name = "btnQuaHan";
            btnQuaHan.Size = new Size(144, 40);
            btnQuaHan.TabIndex = 61;
            btnQuaHan.Text = "Quá hạn";
            btnQuaHan.UseVisualStyleBackColor = false;
            btnQuaHan.Click += btnQuaHan_Click;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.search;
            picTimKiem.Location = new Point(1468, 12);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(37, 31);
            picTimKiem.TabIndex = 59;
            picTimKiem.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = Properties.Resources.page;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(1190, 101);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(162, 50);
            btnThem.TabIndex = 60;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cmnusMenu
            // 
            cmnusMenu.BackColor = Color.WhiteSmoke;
            cmnusMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmnusMenu.ImageScalingSize = new Size(20, 20);
            cmnusMenu.Items.AddRange(new ToolStripItem[] { cmnusMenuXoa });
            cmnusMenu.Name = "contextMenuStrip1";
            cmnusMenu.RenderMode = ToolStripRenderMode.Professional;
            cmnusMenu.ShowImageMargin = false;
            cmnusMenu.Size = new Size(96, 36);
            // 
            // cmnusMenuXoa
            // 
            cmnusMenuXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmnusMenuXoa.Name = "cmnusMenuXoa";
            cmnusMenuXoa.Size = new Size(95, 32);
            cmnusMenuXoa.Text = "Xóa";
            cmnusMenuXoa.Click += cmnusMenuXoa_Click;
            // 
            // nudPage
            // 
            nudPage.BackColor = Color.FromArgb(14, 75, 150);
            nudPage.BorderStyle = BorderStyle.None;
            nudPage.ForeColor = Color.WhiteSmoke;
            nudPage.Location = new Point(1355, 108);
            nudPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPage.Name = "nudPage";
            nudPage.Size = new Size(150, 30);
            nudPage.TabIndex = 61;
            nudPage.TextAlign = HorizontalAlignment.Center;
            nudPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudPage.ValueChanged += nudPage_ValueChanged;
            // 
            // FDanhSachTamTruTamVang
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1532, 679);
            Controls.Add(nudPage);
            Controls.Add(btnThem);
            Controls.Add(picTimKiem);
            Controls.Add(flpnlPhanLoai);
            Controls.Add(txtTimKiem);
            Controls.Add(gvTVTT);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDanhSachTamTruTamVang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDanhSachTamTruTamVang";
            Load += FDanhSachTamTruTamVang_Load;
            ((System.ComponentModel.ISupportInitialize)gvTVTT).EndInit();
            flpnlPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            cmnusMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}