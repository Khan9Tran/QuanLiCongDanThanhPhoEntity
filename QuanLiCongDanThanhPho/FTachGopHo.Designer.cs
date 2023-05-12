namespace QuanLiCongDanThanhPho
{
    partial class FTachGopHo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMaHoTach = new System.Windows.Forms.Label();
            this.lblMaHoGop = new System.Windows.Forms.Label();
            this.gvHoTach = new System.Windows.Forms.DataGridView();
            this.gvHoGop = new System.Windows.Forms.DataGridView();
            this.btnTach = new System.Windows.Forms.Button();
            this.btnGopHo = new System.Windows.Forms.Button();
            this.btnTaoHoMoi = new System.Windows.Forms.Button();
            this.txtMaHoTach = new System.Windows.Forms.TextBox();
            this.txtMaHoGop = new System.Windows.Forms.TextBox();
            this.btnMaHoTach = new System.Windows.Forms.Button();
            this.btnMaHoGop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoTach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoGop)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaHoTach
            // 
            this.lblMaHoTach.AutoSize = true;
            this.lblMaHoTach.Location = new System.Drawing.Point(71, 25);
            this.lblMaHoTach.Name = "lblMaHoTach";
            this.lblMaHoTach.Size = new System.Drawing.Size(119, 28);
            this.lblMaHoTach.TabIndex = 4;
            this.lblMaHoTach.Text = "Mã hộ tách";
            // 
            // lblMaHoGop
            // 
            this.lblMaHoGop.AutoSize = true;
            this.lblMaHoGop.Location = new System.Drawing.Point(71, 375);
            this.lblMaHoGop.Name = "lblMaHoGop";
            this.lblMaHoGop.Size = new System.Drawing.Size(207, 28);
            this.lblMaHoGop.TabIndex = 5;
            this.lblMaHoGop.Text = "Mã hộ gộp/ Tạo mới";
            // 
            // gvHoTach
            // 
            this.gvHoTach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvHoTach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHoTach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvHoTach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHoTach.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvHoTach.EnableHeadersVisualStyles = false;
            this.gvHoTach.Location = new System.Drawing.Point(296, 84);
            this.gvHoTach.Name = "gvHoTach";
            this.gvHoTach.RowHeadersVisible = false;
            this.gvHoTach.RowHeadersWidth = 51;
            this.gvHoTach.RowTemplate.Height = 29;
            this.gvHoTach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHoTach.Size = new System.Drawing.Size(677, 230);
            this.gvHoTach.TabIndex = 6;
            // 
            // gvHoGop
            // 
            this.gvHoGop.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvHoGop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHoGop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvHoGop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHoGop.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvHoGop.EnableHeadersVisualStyles = false;
            this.gvHoGop.Location = new System.Drawing.Point(296, 434);
            this.gvHoGop.Name = "gvHoGop";
            this.gvHoGop.RowHeadersVisible = false;
            this.gvHoGop.RowHeadersWidth = 51;
            this.gvHoGop.RowTemplate.Height = 29;
            this.gvHoGop.Size = new System.Drawing.Size(677, 230);
            this.gvHoGop.TabIndex = 7;
            // 
            // btnTach
            // 
            this.btnTach.BackColor = System.Drawing.Color.Transparent;
            this.btnTach.FlatAppearance.BorderSize = 0;
            this.btnTach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTach.Image = global::QuanLiCongDanThanhPho.Properties.Resources.division;
            this.btnTach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTach.Location = new System.Drawing.Point(3, 59);
            this.btnTach.Name = "btnTach";
            this.btnTach.Size = new System.Drawing.Size(170, 50);
            this.btnTach.TabIndex = 10;
            this.btnTach.Text = "Tách";
            this.btnTach.UseVisualStyleBackColor = false;
            this.btnTach.Click += new System.EventHandler(this.btnTach_Click);
            // 
            // btnGopHo
            // 
            this.btnGopHo.BackColor = System.Drawing.Color.Transparent;
            this.btnGopHo.FlatAppearance.BorderSize = 0;
            this.btnGopHo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGopHo.Image = global::QuanLiCongDanThanhPho.Properties.Resources.merge__1_;
            this.btnGopHo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGopHo.Location = new System.Drawing.Point(3, 115);
            this.btnGopHo.Name = "btnGopHo";
            this.btnGopHo.Size = new System.Drawing.Size(170, 50);
            this.btnGopHo.TabIndex = 11;
            this.btnGopHo.Text = "Gộp";
            this.btnGopHo.UseVisualStyleBackColor = false;
            this.btnGopHo.Click += new System.EventHandler(this.btnGopHo_Click);
            // 
            // btnTaoHoMoi
            // 
            this.btnTaoHoMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnTaoHoMoi.FlatAppearance.BorderSize = 0;
            this.btnTaoHoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHoMoi.Image = global::QuanLiCongDanThanhPho.Properties.Resources.plus__1_;
            this.btnTaoHoMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHoMoi.Location = new System.Drawing.Point(3, 3);
            this.btnTaoHoMoi.Name = "btnTaoHoMoi";
            this.btnTaoHoMoi.Size = new System.Drawing.Size(170, 50);
            this.btnTaoHoMoi.TabIndex = 12;
            this.btnTaoHoMoi.Text = "Tạo mới";
            this.btnTaoHoMoi.UseVisualStyleBackColor = false;
            this.btnTaoHoMoi.Click += new System.EventHandler(this.btnTaoHoMoi_Click);
            // 
            // txtMaHoTach
            // 
            this.txtMaHoTach.BackColor = System.Drawing.Color.White;
            this.txtMaHoTach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHoTach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHoTach.Location = new System.Drawing.Point(296, 25);
            this.txtMaHoTach.Name = "txtMaHoTach";
            this.txtMaHoTach.Size = new System.Drawing.Size(677, 34);
            this.txtMaHoTach.TabIndex = 20;
            // 
            // txtMaHoGop
            // 
            this.txtMaHoGop.BackColor = System.Drawing.Color.White;
            this.txtMaHoGop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHoGop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHoGop.Location = new System.Drawing.Point(303, 375);
            this.txtMaHoGop.Name = "txtMaHoGop";
            this.txtMaHoGop.Size = new System.Drawing.Size(670, 34);
            this.txtMaHoGop.TabIndex = 21;
            // 
            // btnMaHoTach
            // 
            this.btnMaHoTach.BackColor = System.Drawing.Color.Transparent;
            this.btnMaHoTach.FlatAppearance.BorderSize = 0;
            this.btnMaHoTach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaHoTach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaHoTach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.btnMaHoTach.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search__1_;
            this.btnMaHoTach.Location = new System.Drawing.Point(990, 16);
            this.btnMaHoTach.Name = "btnMaHoTach";
            this.btnMaHoTach.Size = new System.Drawing.Size(50, 50);
            this.btnMaHoTach.TabIndex = 54;
            this.btnMaHoTach.UseVisualStyleBackColor = false;
            this.btnMaHoTach.Click += new System.EventHandler(this.btnMaHoTach_Click);
            // 
            // btnMaHoGop
            // 
            this.btnMaHoGop.BackColor = System.Drawing.Color.Transparent;
            this.btnMaHoGop.FlatAppearance.BorderSize = 0;
            this.btnMaHoGop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaHoGop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaHoGop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.btnMaHoGop.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search__1_;
            this.btnMaHoGop.Location = new System.Drawing.Point(990, 364);
            this.btnMaHoGop.Name = "btnMaHoGop";
            this.btnMaHoGop.Size = new System.Drawing.Size(50, 50);
            this.btnMaHoGop.TabIndex = 55;
            this.btnMaHoGop.UseVisualStyleBackColor = false;
            this.btnMaHoGop.Click += new System.EventHandler(this.btnMaHoGop_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = global::QuanLiCongDanThanhPho.Properties.Resources.undo__1_;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(3, 171);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 50);
            this.btnReset.TabIndex = 93;
            this.btnReset.Text = "Tải lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnTaoHoMoi);
            this.flowLayoutPanel1.Controls.Add(this.btnTach);
            this.flowLayoutPanel1.Controls.Add(this.btnGopHo);
            this.flowLayoutPanel1.Controls.Add(this.btnReset);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1192, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(158, 235);
            this.flowLayoutPanel1.TabIndex = 94;
            // 
            // FTachGopHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 695);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnMaHoGop);
            this.Controls.Add(this.btnMaHoTach);
            this.Controls.Add(this.txtMaHoGop);
            this.Controls.Add(this.txtMaHoTach);
            this.Controls.Add(this.gvHoGop);
            this.Controls.Add(this.gvHoTach);
            this.Controls.Add(this.lblMaHoGop);
            this.Controls.Add(this.lblMaHoTach);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FTachGopHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTachGopHo";
            ((System.ComponentModel.ISupportInitialize)(this.gvHoTach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoGop)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMaHoTach;
        private Label lblMaHoGop;
        private DataGridView gvHoTach;
        private DataGridView gvHoGop;
        private Button btnTach;
        private Button btnGopHo;
        private Button btnTaoHoMoi;
        private TextBox txtMaHoTach;
        private TextBox txtMaHoGop;
        private Button btnMaHoTach;
        private Button btnMaHoGop;
        private Button btnReset;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}