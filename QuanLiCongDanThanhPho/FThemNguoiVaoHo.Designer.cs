namespace QuanLiCongDanThanhPho
{
    partial class FThemNguoiVaoHo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtMaHo = new TextBox();
            lblMaHo = new Label();
            btnThem = new Button();
            lblTenNguoiThem = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            txtCCCD = new TextBox();
            btnTim = new Button();
            txtQuanHeVoiChuHo = new TextBox();
            lblQuanHeVoiChuHo = new Label();
            btnReset = new Button();
            gvNguoiChuaCoHoKhau = new DataGridView();
            lblThongTin = new Label();
            pnlTrangTri = new Panel();
            ((System.ComponentModel.ISupportInitialize)gvNguoiChuaCoHoKhau).BeginInit();
            pnlTrangTri.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaHo
            // 
            txtMaHo.BackColor = Color.White;
            txtMaHo.BorderStyle = BorderStyle.None;
            txtMaHo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHo.Location = new Point(10, 215);
            txtMaHo.Name = "txtMaHo";
            txtMaHo.Size = new Size(511, 27);
            txtMaHo.TabIndex = 22;
            // 
            // lblMaHo
            // 
            lblMaHo.AutoSize = true;
            lblMaHo.Location = new Point(40, 182);
            lblMaHo.Name = "lblMaHo";
            lblMaHo.Size = new Size(78, 28);
            lblMaHo.TabIndex = 21;
            lblMaHo.Text = "Mã hộ ";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = Properties.Resources.accept;
            btnThem.Location = new Point(1388, 155);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(50, 50);
            btnThem.TabIndex = 23;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblTenNguoiThem
            // 
            lblTenNguoiThem.AutoSize = true;
            lblTenNguoiThem.Location = new Point(40, 272);
            lblTenNguoiThem.Name = "lblTenNguoiThem";
            lblTenNguoiThem.Size = new Size(45, 28);
            lblTenNguoiThem.TabIndex = 24;
            lblTenNguoiThem.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.White;
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(10, 305);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(511, 27);
            txtTen.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 353);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 26;
            label2.Text = "CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.White;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(10, 386);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(511, 27);
            txtCCCD.TabIndex = 27;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.Transparent;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Image = Properties.Resources.search__1_;
            btnTim.Location = new Point(1388, 262);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(50, 50);
            btnTim.TabIndex = 28;
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // txtQuanHeVoiChuHo
            // 
            txtQuanHeVoiChuHo.BackColor = Color.White;
            txtQuanHeVoiChuHo.BorderStyle = BorderStyle.None;
            txtQuanHeVoiChuHo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuanHeVoiChuHo.Location = new Point(10, 471);
            txtQuanHeVoiChuHo.Name = "txtQuanHeVoiChuHo";
            txtQuanHeVoiChuHo.Size = new Size(511, 27);
            txtQuanHeVoiChuHo.TabIndex = 30;
            // 
            // lblQuanHeVoiChuHo
            // 
            lblQuanHeVoiChuHo.AutoSize = true;
            lblQuanHeVoiChuHo.Location = new Point(40, 439);
            lblQuanHeVoiChuHo.Name = "lblQuanHeVoiChuHo";
            lblQuanHeVoiChuHo.Size = new Size(197, 28);
            lblQuanHeVoiChuHo.TabIndex = 29;
            lblQuanHeVoiChuHo.Text = "Quan hệ với chủ hộ";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.DialogResult = DialogResult.OK;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = Properties.Resources.undo__1_;
            btnReset.Location = new Point(1388, 211);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(50, 50);
            btnReset.TabIndex = 108;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // gvNguoiChuaCoHoKhau
            // 
            gvNguoiChuaCoHoKhau.BackgroundColor = Color.WhiteSmoke;
            gvNguoiChuaCoHoKhau.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gvNguoiChuaCoHoKhau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gvNguoiChuaCoHoKhau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gvNguoiChuaCoHoKhau.DefaultCellStyle = dataGridViewCellStyle2;
            gvNguoiChuaCoHoKhau.EnableHeadersVisualStyles = false;
            gvNguoiChuaCoHoKhau.Location = new Point(802, 183);
            gvNguoiChuaCoHoKhau.Name = "gvNguoiChuaCoHoKhau";
            gvNguoiChuaCoHoKhau.RowHeadersVisible = false;
            gvNguoiChuaCoHoKhau.RowHeadersWidth = 51;
            gvNguoiChuaCoHoKhau.RowTemplate.Height = 29;
            gvNguoiChuaCoHoKhau.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvNguoiChuaCoHoKhau.Size = new Size(571, 284);
            gvNguoiChuaCoHoKhau.TabIndex = 109;
            gvNguoiChuaCoHoKhau.CellClick += gvNguoiChuaCoHoKhau_CellClick;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Location = new Point(802, 131);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(272, 28);
            lblThongTin.TabIndex = 110;
            lblThongTin.Text = "Danh sách chưa có hộ khẩu";
            // 
            // pnlTrangTri
            // 
            pnlTrangTri.BackColor = SystemColors.ActiveCaption;
            pnlTrangTri.Controls.Add(txtMaHo);
            pnlTrangTri.Controls.Add(txtTen);
            pnlTrangTri.Controls.Add(txtCCCD);
            pnlTrangTri.Controls.Add(txtQuanHeVoiChuHo);
            pnlTrangTri.Location = new Point(243, -32);
            pnlTrangTri.Name = "pnlTrangTri";
            pnlTrangTri.Size = new Size(529, 855);
            pnlTrangTri.TabIndex = 113;
            // 
            // FThemNguoiVaoHo
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1532, 695);
            Controls.Add(pnlTrangTri);
            Controls.Add(lblThongTin);
            Controls.Add(gvNguoiChuaCoHoKhau);
            Controls.Add(btnReset);
            Controls.Add(lblQuanHeVoiChuHo);
            Controls.Add(btnTim);
            Controls.Add(label2);
            Controls.Add(lblTenNguoiThem);
            Controls.Add(btnThem);
            Controls.Add(lblMaHo);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FThemNguoiVaoHo";
            Text = "FThemNguoiVaoHo";
            ((System.ComponentModel.ISupportInitialize)gvNguoiChuaCoHoKhau).EndInit();
            pnlTrangTri.ResumeLayout(false);
            pnlTrangTri.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaHo;
        private Label lblMaHo;
        private Button btnThem;
        private Label lblTenNguoiThem;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtCCCD;
        private Button btnTim;
        private TextBox txtQuanHeVoiChuHo;
        private Label lblQuanHeVoiChuHo;
        private Button btnReset;
        private DataGridView gvNguoiChuaCoHoKhau;
        private Label lblThongTin;
        private Panel pnlTrangTri;
    }
}