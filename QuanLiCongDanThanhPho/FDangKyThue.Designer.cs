namespace QuanLiCongDanThanhPho
{
    partial class FDangKyThue
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
            txtSoTienCanNop = new TextBox();
            lblSoTien = new Label();
            txtMaSoThue = new TextBox();
            lblMaThue = new Label();
            txtCCCD = new TextBox();
            lblCCCD = new Label();
            lblNgayCapMa = new Label();
            dtpNgayCapMa = new DateTimePicker();
            dtpHanNop = new DateTimePicker();
            lblHanNop = new Label();
            btnReset = new Button();
            btnDangKy = new Button();
            fpnlChucNang = new FlowLayoutPanel();
            lblSoTienDaNop = new Label();
            txtSoTienDaNop = new TextBox();
            fpnlChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // txtSoTienCanNop
            // 
            txtSoTienCanNop.BackColor = Color.Gainsboro;
            txtSoTienCanNop.BorderStyle = BorderStyle.None;
            txtSoTienCanNop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoTienCanNop.Location = new Point(643, 343);
            txtSoTienCanNop.Name = "txtSoTienCanNop";
            txtSoTienCanNop.Size = new Size(292, 27);
            txtSoTienCanNop.TabIndex = 31;
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new Point(424, 344);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(159, 28);
            lblSoTien.TabIndex = 30;
            lblSoTien.Text = "Số tiền cần nộp";
            // 
            // txtMaSoThue
            // 
            txtMaSoThue.BackColor = Color.Gainsboro;
            txtMaSoThue.BorderStyle = BorderStyle.None;
            txtMaSoThue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSoThue.Location = new Point(643, 185);
            txtMaSoThue.Name = "txtMaSoThue";
            txtMaSoThue.Size = new Size(442, 27);
            txtMaSoThue.TabIndex = 29;
            // 
            // lblMaThue
            // 
            lblMaThue.AutoSize = true;
            lblMaThue.Location = new Point(424, 184);
            lblMaThue.Name = "lblMaThue";
            lblMaThue.Size = new Size(91, 28);
            lblMaThue.TabIndex = 28;
            lblMaThue.Text = "Mã thuế";
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.Gainsboro;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(643, 265);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(442, 27);
            txtCCCD.TabIndex = 33;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(424, 264);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 32;
            lblCCCD.Text = "CCCD";
            // 
            // lblNgayCapMa
            // 
            lblNgayCapMa.AutoSize = true;
            lblNgayCapMa.Location = new Point(423, 504);
            lblNgayCapMa.Name = "lblNgayCapMa";
            lblNgayCapMa.Size = new Size(136, 28);
            lblNgayCapMa.TabIndex = 34;
            lblNgayCapMa.Text = "Ngày cấp mã";
            // 
            // dtpNgayCapMa
            // 
            dtpNgayCapMa.CustomFormat = "dd/MM/yyyy";
            dtpNgayCapMa.Format = DateTimePickerFormat.Custom;
            dtpNgayCapMa.Location = new Point(643, 504);
            dtpNgayCapMa.Name = "dtpNgayCapMa";
            dtpNgayCapMa.Size = new Size(341, 34);
            dtpNgayCapMa.TabIndex = 38;
            dtpNgayCapMa.Value = new DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // dtpHanNop
            // 
            dtpHanNop.CustomFormat = "dd/MM/yyyy";
            dtpHanNop.Format = DateTimePickerFormat.Custom;
            dtpHanNop.Location = new Point(643, 584);
            dtpHanNop.Name = "dtpHanNop";
            dtpHanNop.Size = new Size(341, 34);
            dtpHanNop.TabIndex = 40;
            dtpHanNop.Value = new DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // lblHanNop
            // 
            lblHanNop.AutoSize = true;
            lblHanNop.Location = new Point(423, 584);
            lblHanNop.Name = "lblHanNop";
            lblHanNop.Size = new Size(92, 28);
            lblHanNop.TabIndex = 39;
            lblHanNop.Text = "Hạn nộp";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.DialogResult = DialogResult.OK;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = Properties.Resources.reset;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(3, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(146, 50);
            btnReset.TabIndex = 92;
            btnReset.Text = "Tải Lại";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Transparent;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.ForeColor = Color.Black;
            btnDangKy.Image = Properties.Resources.confirm;
            btnDangKy.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangKy.Location = new Point(155, 3);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(179, 50);
            btnDangKy.TabIndex = 93;
            btnDangKy.Text = "Xác nhận";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // fpnlChucNang
            // 
            fpnlChucNang.Controls.Add(btnReset);
            fpnlChucNang.Controls.Add(btnDangKy);
            fpnlChucNang.Location = new Point(1175, 716);
            fpnlChucNang.Name = "fpnlChucNang";
            fpnlChucNang.Size = new Size(345, 54);
            fpnlChucNang.TabIndex = 94;
            // 
            // lblSoTienDaNop
            // 
            lblSoTienDaNop.AutoSize = true;
            lblSoTienDaNop.Location = new Point(424, 424);
            lblSoTienDaNop.Name = "lblSoTienDaNop";
            lblSoTienDaNop.Size = new Size(150, 28);
            lblSoTienDaNop.TabIndex = 95;
            lblSoTienDaNop.Text = "Số tiền đã nộp";
            // 
            // txtSoTienDaNop
            // 
            txtSoTienDaNop.BackColor = Color.Gainsboro;
            txtSoTienDaNop.BorderStyle = BorderStyle.None;
            txtSoTienDaNop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoTienDaNop.Location = new Point(643, 424);
            txtSoTienDaNop.Name = "txtSoTienDaNop";
            txtSoTienDaNop.Size = new Size(292, 27);
            txtSoTienDaNop.TabIndex = 96;
            // 
            // FDangKyThue
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 782);
            Controls.Add(txtSoTienDaNop);
            Controls.Add(lblSoTienDaNop);
            Controls.Add(fpnlChucNang);
            Controls.Add(dtpHanNop);
            Controls.Add(lblHanNop);
            Controls.Add(dtpNgayCapMa);
            Controls.Add(lblNgayCapMa);
            Controls.Add(txtCCCD);
            Controls.Add(lblCCCD);
            Controls.Add(txtSoTienCanNop);
            Controls.Add(lblSoTien);
            Controls.Add(txtMaSoThue);
            Controls.Add(lblMaThue);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDangKyThue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDangKyThue";
            fpnlChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoTienCanNop;
        private Label lblSoTien;
        private TextBox txtMaSoThue;
        private Label lblMaThue;
        private TextBox txtCCCD;
        private Label lblCCCD;
        private Label lblNgayCapMa;
        private DateTimePicker dtpNgayCapMa;
        private DateTimePicker dtpHanNop;
        private Label lblHanNop;
        private Button btnReset;
        private Button btnDangKy;
        private FlowLayoutPanel fpnlChucNang;
        private Label lblSoTienDaNop;
        private TextBox txtSoTienDaNop;
    }
}