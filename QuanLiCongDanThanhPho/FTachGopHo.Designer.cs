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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblMaHoTach = new Label();
            lblMaHoGop = new Label();
            gvHoTach = new DataGridView();
            gvHoGop = new DataGridView();
            btnTach = new Button();
            btnGopHo = new Button();
            btnTaoHoMoi = new Button();
            txtMaHoTach = new TextBox();
            txtMaHoGop = new TextBox();
            btnMaHoTach = new Button();
            btnMaHoGop = new Button();
            btnReset = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gvHoTach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvHoGop).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMaHoTach
            // 
            lblMaHoTach.AutoSize = true;
            lblMaHoTach.Location = new Point(71, 25);
            lblMaHoTach.Name = "lblMaHoTach";
            lblMaHoTach.Size = new Size(119, 28);
            lblMaHoTach.TabIndex = 4;
            lblMaHoTach.Text = "Mã hộ tách";
            // 
            // lblMaHoGop
            // 
            lblMaHoGop.AutoSize = true;
            lblMaHoGop.Location = new Point(71, 375);
            lblMaHoGop.Name = "lblMaHoGop";
            lblMaHoGop.Size = new Size(207, 28);
            lblMaHoGop.TabIndex = 5;
            lblMaHoGop.Text = "Mã hộ gộp/ Tạo mới";
            // 
            // gvHoTach
            // 
            gvHoTach.BackgroundColor = Color.WhiteSmoke;
            gvHoTach.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gvHoTach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gvHoTach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gvHoTach.DefaultCellStyle = dataGridViewCellStyle6;
            gvHoTach.EnableHeadersVisualStyles = false;
            gvHoTach.Location = new Point(296, 84);
            gvHoTach.Name = "gvHoTach";
            gvHoTach.RowHeadersVisible = false;
            gvHoTach.RowHeadersWidth = 51;
            gvHoTach.RowTemplate.Height = 29;
            gvHoTach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvHoTach.Size = new Size(677, 230);
            gvHoTach.TabIndex = 6;
            // 
            // gvHoGop
            // 
            gvHoGop.BackgroundColor = Color.WhiteSmoke;
            gvHoGop.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            gvHoGop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            gvHoGop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            gvHoGop.DefaultCellStyle = dataGridViewCellStyle8;
            gvHoGop.EnableHeadersVisualStyles = false;
            gvHoGop.Location = new Point(296, 434);
            gvHoGop.Name = "gvHoGop";
            gvHoGop.RowHeadersVisible = false;
            gvHoGop.RowHeadersWidth = 51;
            gvHoGop.RowTemplate.Height = 29;
            gvHoGop.Size = new Size(677, 230);
            gvHoGop.TabIndex = 7;
            // 
            // btnTach
            // 
            btnTach.BackColor = Color.Transparent;
            btnTach.FlatAppearance.BorderSize = 0;
            btnTach.FlatStyle = FlatStyle.Flat;
            btnTach.Image = Properties.Resources.division;
            btnTach.ImageAlign = ContentAlignment.MiddleLeft;
            btnTach.Location = new Point(3, 59);
            btnTach.Name = "btnTach";
            btnTach.Size = new Size(170, 50);
            btnTach.TabIndex = 10;
            btnTach.Text = "Tách";
            btnTach.UseVisualStyleBackColor = false;
            btnTach.Click += btnTach_Click;
            // 
            // btnGopHo
            // 
            btnGopHo.BackColor = Color.Transparent;
            btnGopHo.FlatAppearance.BorderSize = 0;
            btnGopHo.FlatStyle = FlatStyle.Flat;
            btnGopHo.Image = Properties.Resources.merge__1_;
            btnGopHo.ImageAlign = ContentAlignment.MiddleLeft;
            btnGopHo.Location = new Point(3, 115);
            btnGopHo.Name = "btnGopHo";
            btnGopHo.Size = new Size(170, 50);
            btnGopHo.TabIndex = 11;
            btnGopHo.Text = "Gộp";
            btnGopHo.UseVisualStyleBackColor = false;
            btnGopHo.Click += btnGopHo_Click;
            // 
            // btnTaoHoMoi
            // 
            btnTaoHoMoi.BackColor = Color.Transparent;
            btnTaoHoMoi.FlatAppearance.BorderSize = 0;
            btnTaoHoMoi.FlatStyle = FlatStyle.Flat;
            btnTaoHoMoi.Image = Properties.Resources.plus__1_;
            btnTaoHoMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoHoMoi.Location = new Point(3, 3);
            btnTaoHoMoi.Name = "btnTaoHoMoi";
            btnTaoHoMoi.Size = new Size(170, 50);
            btnTaoHoMoi.TabIndex = 12;
            btnTaoHoMoi.Text = "Tạo mới";
            btnTaoHoMoi.UseVisualStyleBackColor = false;
            btnTaoHoMoi.Click += btnTaoHoMoi_Click;
            // 
            // txtMaHoTach
            // 
            txtMaHoTach.BackColor = Color.White;
            txtMaHoTach.BorderStyle = BorderStyle.FixedSingle;
            txtMaHoTach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHoTach.Location = new Point(296, 25);
            txtMaHoTach.Name = "txtMaHoTach";
            txtMaHoTach.Size = new Size(677, 34);
            txtMaHoTach.TabIndex = 20;
            // 
            // txtMaHoGop
            // 
            txtMaHoGop.BackColor = Color.White;
            txtMaHoGop.BorderStyle = BorderStyle.FixedSingle;
            txtMaHoGop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHoGop.Location = new Point(303, 375);
            txtMaHoGop.Name = "txtMaHoGop";
            txtMaHoGop.Size = new Size(670, 34);
            txtMaHoGop.TabIndex = 21;
            // 
            // btnMaHoTach
            // 
            btnMaHoTach.BackColor = Color.Transparent;
            btnMaHoTach.FlatAppearance.BorderSize = 0;
            btnMaHoTach.FlatStyle = FlatStyle.Flat;
            btnMaHoTach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaHoTach.ForeColor = Color.FromArgb(44, 53, 60);
            btnMaHoTach.Image = Properties.Resources.search__1_;
            btnMaHoTach.Location = new Point(990, 16);
            btnMaHoTach.Name = "btnMaHoTach";
            btnMaHoTach.Size = new Size(50, 50);
            btnMaHoTach.TabIndex = 54;
            btnMaHoTach.UseVisualStyleBackColor = false;
            btnMaHoTach.Click += btnMaHoTach_Click;
            // 
            // btnMaHoGop
            // 
            btnMaHoGop.BackColor = Color.Transparent;
            btnMaHoGop.FlatAppearance.BorderSize = 0;
            btnMaHoGop.FlatStyle = FlatStyle.Flat;
            btnMaHoGop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaHoGop.ForeColor = Color.FromArgb(44, 53, 60);
            btnMaHoGop.Image = Properties.Resources.search__1_;
            btnMaHoGop.Location = new Point(990, 364);
            btnMaHoGop.Name = "btnMaHoGop";
            btnMaHoGop.Size = new Size(50, 50);
            btnMaHoGop.TabIndex = 55;
            btnMaHoGop.UseVisualStyleBackColor = false;
            btnMaHoGop.Click += btnMaHoGop_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.DialogResult = DialogResult.OK;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = Properties.Resources.undo__1_;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(3, 171);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(170, 50);
            btnReset.TabIndex = 93;
            btnReset.Text = "Tải lại";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(btnTaoHoMoi);
            flowLayoutPanel1.Controls.Add(btnTach);
            flowLayoutPanel1.Controls.Add(btnGopHo);
            flowLayoutPanel1.Controls.Add(btnReset);
            flowLayoutPanel1.Location = new Point(50, 96);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(158, 235);
            flowLayoutPanel1.TabIndex = 94;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(1125, -17);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 853);
            panel1.TabIndex = 96;
            // 
            // FTachGopHo
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1532, 695);
            Controls.Add(panel1);
            Controls.Add(btnMaHoGop);
            Controls.Add(btnMaHoTach);
            Controls.Add(txtMaHoGop);
            Controls.Add(txtMaHoTach);
            Controls.Add(gvHoGop);
            Controls.Add(gvHoTach);
            Controls.Add(lblMaHoGop);
            Controls.Add(lblMaHoTach);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FTachGopHo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FTachGopHo";
            ((System.ComponentModel.ISupportInitialize)gvHoTach).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvHoGop).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panel1;
    }
}