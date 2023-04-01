namespace QuanLiCongDanThanhPho
{
    partial class FDanhSach
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
            this.pnlHienThiDanhSach = new System.Windows.Forms.Panel();
            this.cmbLuaChon = new System.Windows.Forms.ComboBox();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlHienThiDanhSach
            // 
            this.pnlHienThiDanhSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHienThiDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHienThiDanhSach.Location = new System.Drawing.Point(0, 103);
            this.pnlHienThiDanhSach.Name = "pnlHienThiDanhSach";
            this.pnlHienThiDanhSach.Size = new System.Drawing.Size(1532, 679);
            this.pnlHienThiDanhSach.TabIndex = 0;
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
            "Tạm Trú/Tạm Vắng",
            "Hộ khẩu"});
            this.cmbLuaChon.Location = new System.Drawing.Point(154, 32);
            this.cmbLuaChon.Name = "cmbLuaChon";
            this.cmbLuaChon.Size = new System.Drawing.Size(286, 36);
            this.cmbLuaChon.TabIndex = 1;
            this.cmbLuaChon.SelectedIndexChanged += new System.EventHandler(this.cmbLuaChon_SelectedIndexChanged);
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Location = new System.Drawing.Point(30, 40);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(110, 28);
            this.lblThongKe.TabIndex = 2;
            this.lblThongKe.Text = "Danh sách";
            // 
            // FDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1532, 782);
            this.Controls.Add(this.lblThongKe);
            this.Controls.Add(this.cmbLuaChon);
            this.Controls.Add(this.pnlHienThiDanhSach);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSach";
            this.Text = "FDanhSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlHienThiDanhSach;
        private ComboBox cmbLuaChon;
        private Label lblThongKe;
    }
}