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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblHanChot = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(55, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số tiền muốn thanh toán";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(55, 487);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 34);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(55, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Toàn bộ";
            this.button1.UseVisualStyleBackColor = false;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 279);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2023, 5, 14, 0, 0, 0, 0);
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
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblHanChot);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTienNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThanhToanThue";
            this.Text = "FormThanhToanThue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTienNo;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button btnXacNhan;
        private Label lblDonVi;
        private Label lblHanChot;
        private DateTimePicker dateTimePicker1;
        private Label lblMaThue;
    }
}