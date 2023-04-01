namespace QuanLiCongDanThanhPho
{
    partial class FThongKe
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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.cmbLuaChon = new System.Windows.Forms.ComboBox();
            this.pnlHienThiThongKe = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(30, 40);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(100, 28);
            this.lblDanhSach.TabIndex = 4;
            this.lblDanhSach.Text = "Thống kê";
            // 
            // cmbLuaChon
            // 
            this.cmbLuaChon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbLuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLuaChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLuaChon.FormattingEnabled = true;
            this.cmbLuaChon.Items.AddRange(new object[] {
            "Công dân",
            "Thuế",
            "Phân bố dân cư"});
            this.cmbLuaChon.Location = new System.Drawing.Point(146, 37);
            this.cmbLuaChon.Name = "cmbLuaChon";
            this.cmbLuaChon.Size = new System.Drawing.Size(286, 36);
            this.cmbLuaChon.TabIndex = 3;
            this.cmbLuaChon.SelectedIndexChanged += new System.EventHandler(this.cmbLuaChon_SelectedIndexChanged);
            // 
            // pnlHienThiThongKe
            // 
            this.pnlHienThiThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHienThiThongKe.Location = new System.Drawing.Point(0, 103);
            this.pnlHienThiThongKe.Name = "pnlHienThiThongKe";
            this.pnlHienThiThongKe.Size = new System.Drawing.Size(1532, 679);
            this.pnlHienThiThongKe.TabIndex = 5;
            // 
            // FThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 782);
            this.Controls.Add(this.pnlHienThiThongKe);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.cmbLuaChon);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThongKe";
            this.Text = "FThongKe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDanhSach;
        private ComboBox cmbLuaChon;
        private Panel pnlHienThiThongKe;
    }
}