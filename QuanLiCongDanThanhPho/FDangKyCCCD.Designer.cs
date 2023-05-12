namespace QuanLiCongDanThanhPho
{
    partial class FDangKyCCCD
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
            txtTen = new TextBox();
            lblTen = new Label();
            txtCCCD = new TextBox();
            lblCCCD = new Label();
            dtmNgayCap = new DateTimePicker();
            lblNgayCap = new Label();
            txtDDNhanDang = new TextBox();
            lblDDNhanDang = new Label();
            btnReset = new Button();
            gvDanhSachChuaCapCCCD = new DataGridView();
            label1 = new Label();
            btnDangKy = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gvDanhSachChuaCapCCCD).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.White;
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(15, 129);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(534, 27);
            txtTen.TabIndex = 22;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(311, 127);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(104, 28);
            lblTen.TabIndex = 21;
            lblTen.Text = "Họ và tên";
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.White;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(15, 196);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(348, 27);
            txtCCCD.TabIndex = 24;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(311, 194);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 23;
            lblCCCD.Text = "CCCD";
            // 
            // dtmNgayCap
            // 
            dtmNgayCap.CustomFormat = "dd/MM/yyyy";
            dtmNgayCap.Format = DateTimePickerFormat.Custom;
            dtmNgayCap.Location = new Point(15, 334);
            dtmNgayCap.Name = "dtmNgayCap";
            dtmNgayCap.Size = new Size(341, 34);
            dtmNgayCap.TabIndex = 39;
            dtmNgayCap.Value = new DateTime(2023, 3, 7, 0, 0, 0, 0);
            // 
            // lblNgayCap
            // 
            lblNgayCap.AutoSize = true;
            lblNgayCap.Location = new Point(311, 337);
            lblNgayCap.Name = "lblNgayCap";
            lblNgayCap.Size = new Size(101, 28);
            lblNgayCap.TabIndex = 38;
            lblNgayCap.Text = "Ngày cấp";
            // 
            // txtDDNhanDang
            // 
            txtDDNhanDang.BackColor = Color.White;
            txtDDNhanDang.BorderStyle = BorderStyle.None;
            txtDDNhanDang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDDNhanDang.Location = new Point(15, 270);
            txtDDNhanDang.Name = "txtDDNhanDang";
            txtDDNhanDang.Size = new Size(534, 27);
            txtDDNhanDang.TabIndex = 41;
            // 
            // lblDDNhanDang
            // 
            lblDDNhanDang.AutoSize = true;
            lblDDNhanDang.Location = new Point(311, 268);
            lblDDNhanDang.Name = "lblDDNhanDang";
            lblDDNhanDang.Size = new Size(208, 28);
            lblDDNhanDang.TabIndex = 40;
            lblDDNhanDang.Text = "Đặc điểm nhận dạng";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.DialogResult = DialogResult.OK;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = Properties.Resources.undo__1_;
            btnReset.Location = new Point(59, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(50, 50);
            btnReset.TabIndex = 92;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // gvDanhSachChuaCapCCCD
            // 
            gvDanhSachChuaCapCCCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvDanhSachChuaCapCCCD.BackgroundColor = Color.WhiteSmoke;
            gvDanhSachChuaCapCCCD.BorderStyle = BorderStyle.None;
            gvDanhSachChuaCapCCCD.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 43, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gvDanhSachChuaCapCCCD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gvDanhSachChuaCapCCCD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gvDanhSachChuaCapCCCD.DefaultCellStyle = dataGridViewCellStyle2;
            gvDanhSachChuaCapCCCD.GridColor = Color.Gainsboro;
            gvDanhSachChuaCapCCCD.Location = new Point(311, 482);
            gvDanhSachChuaCapCCCD.MultiSelect = false;
            gvDanhSachChuaCapCCCD.Name = "gvDanhSachChuaCapCCCD";
            gvDanhSachChuaCapCCCD.ReadOnly = true;
            gvDanhSachChuaCapCCCD.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            gvDanhSachChuaCapCCCD.RowHeadersWidth = 51;
            gvDanhSachChuaCapCCCD.RowTemplate.Height = 29;
            gvDanhSachChuaCapCCCD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvDanhSachChuaCapCCCD.Size = new Size(748, 218);
            gvDanhSachChuaCapCCCD.TabIndex = 93;
            gvDanhSachChuaCapCCCD.CellClick += gvDanhSachChuaCapCCCD_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(311, 433);
            label1.Name = "label1";
            label1.Size = new Size(525, 28);
            label1.TabIndex = 94;
            label1.Text = "Danh sách công dân địa phương chưa được cấp CCCD:";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Transparent;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Image = Properties.Resources.accept;
            btnDangKy.Location = new Point(3, 3);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(50, 50);
            btnDangKy.TabIndex = 95;
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Controls.Add(btnDangKy);
            flowLayoutPanel1.Controls.Add(btnReset);
            flowLayoutPanel1.Location = new Point(1344, 668);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(119, 59);
            flowLayoutPanel1.TabIndex = 96;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(txtCCCD);
            panel1.Controls.Add(txtDDNhanDang);
            panel1.Controls.Add(dtmNgayCap);
            panel1.Location = new Point(525, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 379);
            panel1.TabIndex = 97;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(1329, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 755);
            panel2.TabIndex = 98;
            // 
            // FDangKyCCCD
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1532, 752);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(gvDanhSachChuaCapCCCD);
            Controls.Add(lblDDNhanDang);
            Controls.Add(lblNgayCap);
            Controls.Add(lblCCCD);
            Controls.Add(lblTen);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDangKyCCCD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDangKyCCCD";
            Load += FDangKyCCCD_Load;
            ((System.ComponentModel.ISupportInitialize)gvDanhSachChuaCapCCCD).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTen;
        private Label lblTen;
        private TextBox txtCCCD;
        private Label lblCCCD;
        private DateTimePicker dtmNgayCap;
        private Label lblNgayCap;
        private TextBox txtDDNhanDang;
        private Label lblDDNhanDang;
        private Button btnReset;
        private DataGridView gvDanhSachChuaCapCCCD;
        private Label label1;
        private Button btnDangKy;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}