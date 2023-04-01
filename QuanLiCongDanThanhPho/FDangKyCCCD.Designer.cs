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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.dtmNgayCap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayCap = new System.Windows.Forms.Label();
            this.txtDDNhanDang = new System.Windows.Forms.TextBox();
            this.lblDDNhanDang = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.gvDanhSachChuaCapCCCD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachChuaCapCCCD)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTen.Location = new System.Drawing.Point(525, 128);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(534, 27);
            this.txtTen.TabIndex = 22;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(311, 127);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(104, 28);
            this.lblTen.TabIndex = 21;
            this.lblTen.Text = "Họ và tên";
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCCCD.Location = new System.Drawing.Point(525, 195);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(348, 27);
            this.txtCCCD.TabIndex = 24;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(311, 194);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(61, 28);
            this.lblCCCD.TabIndex = 23;
            this.lblCCCD.Text = "CCCD";
            // 
            // dtmNgayCap
            // 
            this.dtmNgayCap.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayCap.Location = new System.Drawing.Point(525, 337);
            this.dtmNgayCap.Name = "dtmNgayCap";
            this.dtmNgayCap.Size = new System.Drawing.Size(341, 34);
            this.dtmNgayCap.TabIndex = 39;
            this.dtmNgayCap.Value = new System.DateTime(2023, 3, 7, 0, 0, 0, 0);
            // 
            // lblNgayCap
            // 
            this.lblNgayCap.AutoSize = true;
            this.lblNgayCap.Location = new System.Drawing.Point(311, 337);
            this.lblNgayCap.Name = "lblNgayCap";
            this.lblNgayCap.Size = new System.Drawing.Size(101, 28);
            this.lblNgayCap.TabIndex = 38;
            this.lblNgayCap.Text = "Ngày cấp";
            // 
            // txtDDNhanDang
            // 
            this.txtDDNhanDang.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDDNhanDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDDNhanDang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDDNhanDang.Location = new System.Drawing.Point(525, 269);
            this.txtDDNhanDang.Name = "txtDDNhanDang";
            this.txtDDNhanDang.Size = new System.Drawing.Size(534, 27);
            this.txtDDNhanDang.TabIndex = 41;
            // 
            // lblDDNhanDang
            // 
            this.lblDDNhanDang.AutoSize = true;
            this.lblDDNhanDang.Location = new System.Drawing.Point(311, 268);
            this.lblDDNhanDang.Name = "lblDDNhanDang";
            this.lblDDNhanDang.Size = new System.Drawing.Size(208, 28);
            this.lblDDNhanDang.TabIndex = 40;
            this.lblDDNhanDang.Text = "Đặc điểm nhận dạng";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = global::QuanLiCongDanThanhPho.Properties.Resources.reset;
            this.btnReset.Location = new System.Drawing.Point(59, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 50);
            this.btnReset.TabIndex = 92;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gvDanhSachChuaCapCCCD
            // 
            this.gvDanhSachChuaCapCCCD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDanhSachChuaCapCCCD.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvDanhSachChuaCapCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDanhSachChuaCapCCCD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDanhSachChuaCapCCCD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDanhSachChuaCapCCCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDanhSachChuaCapCCCD.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDanhSachChuaCapCCCD.GridColor = System.Drawing.Color.Gainsboro;
            this.gvDanhSachChuaCapCCCD.Location = new System.Drawing.Point(311, 482);
            this.gvDanhSachChuaCapCCCD.MultiSelect = false;
            this.gvDanhSachChuaCapCCCD.Name = "gvDanhSachChuaCapCCCD";
            this.gvDanhSachChuaCapCCCD.ReadOnly = true;
            this.gvDanhSachChuaCapCCCD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvDanhSachChuaCapCCCD.RowHeadersWidth = 51;
            this.gvDanhSachChuaCapCCCD.RowTemplate.Height = 29;
            this.gvDanhSachChuaCapCCCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDanhSachChuaCapCCCD.Size = new System.Drawing.Size(748, 218);
            this.gvDanhSachChuaCapCCCD.TabIndex = 93;
            this.gvDanhSachChuaCapCCCD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDanhSachChuaCapCCCD_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(311, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 28);
            this.label1.TabIndex = 94;
            this.label1.Text = "Danh sách công dân địa phương chưa được cấp CCCD:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.Transparent;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Image = global::QuanLiCongDanThanhPho.Properties.Resources.confirm;
            this.btnDangKy.Location = new System.Drawing.Point(3, 3);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(50, 50);
            this.btnDangKy.TabIndex = 95;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDangKy);
            this.flowLayoutPanel1.Controls.Add(this.btnReset);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1344, 668);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(137, 59);
            this.flowLayoutPanel1.TabIndex = 96;
            // 
            // FDangKyCCCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 752);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvDanhSachChuaCapCCCD);
            this.Controls.Add(this.txtDDNhanDang);
            this.Controls.Add(this.lblDDNhanDang);
            this.Controls.Add(this.dtmNgayCap);
            this.Controls.Add(this.lblNgayCap);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDangKyCCCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDangKyCCCD";
            this.Load += new System.EventHandler(this.FDangKyCCCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachChuaCapCCCD)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}