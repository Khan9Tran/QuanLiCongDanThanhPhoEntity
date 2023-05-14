namespace QuanLiCongDanThanhPho
{
    partial class FThanhToanThue
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
            this.lblTienNo = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtDongThue = new System.Windows.Forms.TextBox();
            this.btnToanBo = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblHanChot = new System.Windows.Forms.Label();
            this.dtpThoiHan = new System.Windows.Forms.DateTimePicker();
            this.lblMaThue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTienNo
            // 
            this.lblTienNo.AutoSize = true;
            this.lblTienNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTienNo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTienNo.Location = new System.Drawing.Point(55, 149);
            this.lblTienNo.Name = "lblTienNo";
            this.lblTienNo.Size = new System.Drawing.Size(123, 31);
            this.lblTienNo.TabIndex = 0;
            this.lblTienNo.Text = "Số tiền nợ";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLabel.ForeColor = System.Drawing.Color.DimGray;
            this.lblLabel.Location = new System.Drawing.Point(55, 406);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(303, 28);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "Nhập số tiền muốn thanh toán";
            // 
            // txtDongThue
            // 
            this.txtDongThue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDongThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDongThue.Location = new System.Drawing.Point(55, 487);
            this.txtDongThue.Name = "txtDongThue";
            this.txtDongThue.Size = new System.Drawing.Size(348, 34);
            this.txtDongThue.TabIndex = 2;
            // 
            // btnToanBo
            // 
            this.btnToanBo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnToanBo.FlatAppearance.BorderSize = 0;
            this.btnToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToanBo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToanBo.ForeColor = System.Drawing.Color.White;
            this.btnToanBo.Location = new System.Drawing.Point(55, 553);
            this.btnToanBo.Name = "btnToanBo";
            this.btnToanBo.Size = new System.Drawing.Size(150, 50);
            this.btnToanBo.TabIndex = 3;
            this.btnToanBo.Text = "Toàn bộ";
            this.btnToanBo.UseVisualStyleBackColor = false;
            this.btnToanBo.Click += new System.EventHandler(this.btnToanBo_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Image = global::QuanLiCongDanThanhPho.Properties.Resources.check__2_;
            this.btnXacNhan.Location = new System.Drawing.Point(427, 569);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(34, 34);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDonVi.ForeColor = System.Drawing.Color.DimGray;
            this.lblDonVi.Location = new System.Drawing.Point(427, 487);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(64, 31);
            this.lblDonVi.TabIndex = 5;
            this.lblDonVi.Text = "VND";
            // 
            // lblHanChot
            // 
            this.lblHanChot.AutoSize = true;
            this.lblHanChot.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHanChot.ForeColor = System.Drawing.Color.DimGray;
            this.lblHanChot.Location = new System.Drawing.Point(55, 275);
            this.lblHanChot.Name = "lblHanChot";
            this.lblHanChot.Size = new System.Drawing.Size(108, 31);
            this.lblHanChot.TabIndex = 6;
            this.lblHanChot.Text = "Thời hạn";
            // 
            // dtpThoiHan
            // 
            this.dtpThoiHan.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiHan.Location = new System.Drawing.Point(251, 279);
            this.dtpThoiHan.Name = "dtpThoiHan";
            this.dtpThoiHan.Size = new System.Drawing.Size(152, 27);
            this.dtpThoiHan.TabIndex = 7;
            this.dtpThoiHan.Value = new System.DateTime(2023, 5, 14, 0, 0, 0, 0);
            // 
            // lblMaThue
            // 
            this.lblMaThue.AutoSize = true;
            this.lblMaThue.BackColor = System.Drawing.Color.Transparent;
            this.lblMaThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaThue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMaThue.Location = new System.Drawing.Point(201, 47);
            this.lblMaThue.Name = "lblMaThue";
            this.lblMaThue.Size = new System.Drawing.Size(113, 28);
            this.lblMaThue.TabIndex = 8;
            this.lblMaThue.Text = "lblMaThue";
            // 
            // FThanhToanThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 753);
            this.Controls.Add(this.lblMaThue);
            this.Controls.Add(this.dtpThoiHan);
            this.Controls.Add(this.lblHanChot);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnToanBo);
            this.Controls.Add(this.txtDongThue);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.lblTienNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThanhToanThue";
            this.Text = "FormThanhToanThue";
            this.Load += new System.EventHandler(this.FThanhToanThue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTienNo;
        private Label lblLabel;
        private TextBox txtDongThue;
        private Button btnToanBo;
        private Button btnXacNhan;
        private Label lblDonVi;
        private Label lblHanChot;
        private DateTimePicker dtpThoiHan;
        private Label lblMaThue;
    }
}