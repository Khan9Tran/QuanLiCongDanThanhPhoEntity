namespace QuanLiCongDanThanhPho
{
    partial class FKhaiTu
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
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.fpnlChucNang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.panelTrangTri = new System.Windows.Forms.Panel();
            this.fpnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCCCD.ForeColor = System.Drawing.Color.White;
            this.lblCCCD.Location = new System.Drawing.Point(380, 230);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(61, 28);
            this.lblCCCD.TabIndex = 1;
            this.lblCCCD.Text = "CCCD";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(380, 330);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(106, 28);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Họ và Tên";
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.Color.White;
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCCCD.Location = new System.Drawing.Point(530, 230);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(534, 34);
            this.txtCCCD.TabIndex = 21;
            this.txtCCCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.White;
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTen.Location = new System.Drawing.Point(530, 330);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(534, 34);
            this.txtTen.TabIndex = 22;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fpnlChucNang
            // 
            this.fpnlChucNang.Controls.Add(this.btnReset);
            this.fpnlChucNang.Controls.Add(this.btnDangKy);
            this.fpnlChucNang.Location = new System.Drawing.Point(1171, 681);
            this.fpnlChucNang.Name = "fpnlChucNang";
            this.fpnlChucNang.Size = new System.Drawing.Size(349, 59);
            this.fpnlChucNang.TabIndex = 99;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = global::QuanLiCongDanThanhPho.Properties.Resources.undo__1_;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(3, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 50);
            this.btnReset.TabIndex = 92;
            this.btnReset.Text = "Tải lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.Transparent;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangKy.ForeColor = System.Drawing.Color.Black;
            this.btnDangKy.Image = global::QuanLiCongDanThanhPho.Properties.Resources.accept;
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.Location = new System.Drawing.Point(159, 3);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(150, 50);
            this.btnDangKy.TabIndex = 89;
            this.btnDangKy.Text = "      Xác nhận";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search__1_;
            this.picTimKiem.Location = new System.Drawing.Point(1070, 230);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(37, 31);
            this.picTimKiem.TabIndex = 100;
            this.picTimKiem.TabStop = false;
            // 
            // panelTrangTri
            // 
            this.panelTrangTri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTrangTri.Location = new System.Drawing.Point(304, -8);
            this.panelTrangTri.Name = "panelTrangTri";
            this.panelTrangTri.Size = new System.Drawing.Size(211, 385);
            this.panelTrangTri.TabIndex = 101;
            // 
            // FKhaiTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 752);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.fpnlChucNang);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.panelTrangTri);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FKhaiTu";
            this.Text = "FDangKyChuyenDi";
            this.fpnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCCCD;
        private Label lblTen;
        private TextBox txtCCCD;
        private TextBox txtTen;
        private FlowLayoutPanel fpnlChucNang;
        private Button btnReset;
        private Button btnDangKy;
        private PictureBox picTimKiem;
        private Panel panelTrangTri;
    }
}