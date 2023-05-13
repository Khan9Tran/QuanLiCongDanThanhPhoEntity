namespace QuanLiCongDanThanhPho
{
    partial class FThongKeCongDan
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
            this.gvSoLuongNamNu = new System.Windows.Forms.DataGridView();
            this.gvNhomTuoi = new System.Windows.Forms.DataGridView();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.lblSoCongDan = new System.Windows.Forms.Label();
            this.gvHonNhan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvSoLuongNamNu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomTuoi)).BeginInit();
            this.pnlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHonNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSoLuongNamNu
            // 
            this.gvSoLuongNamNu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSoLuongNamNu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvSoLuongNamNu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSoLuongNamNu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSoLuongNamNu.Location = new System.Drawing.Point(26, 335);
            this.gvSoLuongNamNu.Name = "gvSoLuongNamNu";
            this.gvSoLuongNamNu.RowHeadersVisible = false;
            this.gvSoLuongNamNu.RowHeadersWidth = 51;
            this.gvSoLuongNamNu.RowTemplate.Height = 29;
            this.gvSoLuongNamNu.Size = new System.Drawing.Size(374, 252);
            this.gvSoLuongNamNu.TabIndex = 23;
            // 
            // gvNhomTuoi
            // 
            this.gvNhomTuoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvNhomTuoi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvNhomTuoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvNhomTuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhomTuoi.Location = new System.Drawing.Point(515, 335);
            this.gvNhomTuoi.Name = "gvNhomTuoi";
            this.gvNhomTuoi.RowHeadersVisible = false;
            this.gvNhomTuoi.RowHeadersWidth = 51;
            this.gvNhomTuoi.RowTemplate.Height = 29;
            this.gvNhomTuoi.Size = new System.Drawing.Size(350, 252);
            this.gvNhomTuoi.TabIndex = 29;
            // 
            // pnlPanel
            // 
            this.pnlPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPanel.Controls.Add(this.lblSoCongDan);
            this.pnlPanel.Location = new System.Drawing.Point(14, 13);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(509, 57);
            this.pnlPanel.TabIndex = 35;
            // 
            // lblSoCongDan
            // 
            this.lblSoCongDan.AutoSize = true;
            this.lblSoCongDan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoCongDan.ForeColor = System.Drawing.Color.White;
            this.lblSoCongDan.Location = new System.Drawing.Point(14, 13);
            this.lblSoCongDan.Name = "lblSoCongDan";
            this.lblSoCongDan.Size = new System.Drawing.Size(332, 28);
            this.lblSoCongDan.TabIndex = 22;
            this.lblSoCongDan.Text = "Số lượng công dân của thành phố";
            // 
            // gvHonNhan
            // 
            this.gvHonNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHonNhan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvHonNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvHonNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHonNhan.Location = new System.Drawing.Point(1002, 335);
            this.gvHonNhan.Name = "gvHonNhan";
            this.gvHonNhan.RowHeadersVisible = false;
            this.gvHonNhan.RowHeadersWidth = 51;
            this.gvHonNhan.RowTemplate.Height = 29;
            this.gvHonNhan.Size = new System.Drawing.Size(327, 252);
            this.gvHonNhan.TabIndex = 36;
            // 
            // FThongKeCongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.gvHonNhan);
            this.Controls.Add(this.pnlPanel);
            this.Controls.Add(this.gvNhomTuoi);
            this.Controls.Add(this.gvSoLuongNamNu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThongKeCongDan";
            this.Text = "FThongKeCongDancs";
            this.Load += new System.EventHandler(this.FThongKeCongDancs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSoLuongNamNu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomTuoi)).EndInit();
            this.pnlPanel.ResumeLayout(false);
            this.pnlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHonNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView gvSoLuongNamNu;
        private DataGridView gvNhomTuoi;
        private Panel pnlPanel;
        private Label lblSoCongDan;
        private DataGridView gvHonNhan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGioiTinh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNhomTuoi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHonNhan;
    }
}