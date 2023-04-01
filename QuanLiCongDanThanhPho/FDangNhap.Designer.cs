namespace QuanLiCongDanThanhPho
{
    partial class FDangNhap
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
            this.components = new System.ComponentModel.Container();
            this.pnlDangNhap = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.tmrShowTime = new System.Windows.Forms.Timer(this.components);
            this.pnlDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDangNhap.Controls.Add(this.btnDangNhap);
            this.pnlDangNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDangNhap.Location = new System.Drawing.Point(330, 0);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(70, 150);
            this.pnlDangNhap.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(74)))), ((int)(((byte)(155)))));
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangNhap.Image = global::QuanLiCongDanThanhPho.Properties.Resources.right;
            this.btnDangNhap.Location = new System.Drawing.Point(-3, 0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(73, 150);
            this.btnDangNhap.TabIndex = 95;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.Silver;
            this.pnlLine.Location = new System.Drawing.Point(25, 75);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(280, 2);
            this.pnlLine.TabIndex = 2;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Gray;
            this.txtTaiKhoan.Location = new System.Drawing.Point(25, 35);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(250, 27);
            this.txtTaiKhoan.TabIndex = 3;
            this.txtTaiKhoan.Text = "Tài Khoản";
            this.txtTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            this.txtTaiKhoan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTaiKhoan_MouseDown);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.txtMatKhau.Location = new System.Drawing.Point(25, 83);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(250, 27);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "Mật Khẩu";
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            this.txtMatKhau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtMatKhau_MouseDown);
            // 
            // tmrShowTime
            // 
            this.tmrShowTime.Tick += new System.EventHandler(this.tmrShowTime_Tick);
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.pnlDangNhap);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDangNhap";
            this.Enter += new System.EventHandler(this.btnDangNhap_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FDangNhap_KeyDown);
            this.pnlDangNhap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlDangNhap;
        private Panel pnlLine;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private System.Windows.Forms.Timer tmrShowTime;
    }
}