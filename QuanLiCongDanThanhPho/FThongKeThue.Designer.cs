namespace QuanLiCongDanThanhPho
{
    partial class FThongKeThue
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
            this.lblTongTienThue = new System.Windows.Forms.Label();
            this.lblTongThueDaDong = new System.Windows.Forms.Label();
            this.lblTongThueCanDong = new System.Windows.Forms.Label();
            this.lblSoNguoiTreHan = new System.Windows.Forms.Label();
            this.lblTrungBinhThue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTongTienThue
            // 
            this.lblTongTienThue.AutoSize = true;
            this.lblTongTienThue.Location = new System.Drawing.Point(29, 32);
            this.lblTongTienThue.Name = "lblTongTienThue";
            this.lblTongTienThue.Size = new System.Drawing.Size(152, 28);
            this.lblTongTienThue.TabIndex = 0;
            this.lblTongTienThue.Text = "Tổng tiền thuế";
            // 
            // lblTongThueDaDong
            // 
            this.lblTongThueDaDong.AutoSize = true;
            this.lblTongThueDaDong.Location = new System.Drawing.Point(29, 88);
            this.lblTongThueDaDong.Name = "lblTongThueDaDong";
            this.lblTongThueDaDong.Size = new System.Drawing.Size(292, 28);
            this.lblTongThueDaDong.TabIndex = 1;
            this.lblTongThueDaDong.Text = "Tổng tiền thuế đã được đóng";
            // 
            // lblTongThueCanDong
            // 
            this.lblTongThueCanDong.AutoSize = true;
            this.lblTongThueCanDong.Location = new System.Drawing.Point(29, 148);
            this.lblTongThueCanDong.Name = "lblTongThueCanDong";
            this.lblTongThueCanDong.Size = new System.Drawing.Size(246, 28);
            this.lblTongThueCanDong.TabIndex = 2;
            this.lblTongThueCanDong.Text = "Tổng tiền thuế cần đóng";
            // 
            // lblSoNguoiTreHan
            // 
            this.lblSoNguoiTreHan.AutoSize = true;
            this.lblSoNguoiTreHan.Location = new System.Drawing.Point(29, 275);
            this.lblSoNguoiTreHan.Name = "lblSoNguoiTreHan";
            this.lblSoNguoiTreHan.Size = new System.Drawing.Size(226, 28);
            this.lblSoNguoiTreHan.TabIndex = 3;
            this.lblSoNguoiTreHan.Text = "Số người trễ hạn đóng";
            // 
            // lblTrungBinhThue
            // 
            this.lblTrungBinhThue.AutoSize = true;
            this.lblTrungBinhThue.Location = new System.Drawing.Point(29, 210);
            this.lblTrungBinhThue.Name = "lblTrungBinhThue";
            this.lblTrungBinhThue.Size = new System.Drawing.Size(414, 28);
            this.lblTrungBinhThue.TabIndex = 4;
            this.lblTrungBinhThue.Text = "Trung bình tiền thuế một người phải đóng";
            // 
            // FThongKeThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.lblTrungBinhThue);
            this.Controls.Add(this.lblSoNguoiTreHan);
            this.Controls.Add(this.lblTongThueCanDong);
            this.Controls.Add(this.lblTongThueDaDong);
            this.Controls.Add(this.lblTongTienThue);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThongKeThue";
            this.Text = "FThongKeThue";
            this.Load += new System.EventHandler(this.FThongKeThue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTongTienThue;
        private Label lblTongThueDaDong;
        private Label lblTongThueCanDong;
        private Label lblSoNguoiTreHan;
        private Label lblTrungBinhThue;
    }
}