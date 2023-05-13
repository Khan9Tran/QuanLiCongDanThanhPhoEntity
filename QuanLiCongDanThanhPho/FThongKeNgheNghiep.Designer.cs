namespace QuanLiCongDanThanhPho
{
    partial class FThongKeNgheNghiep
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
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.lblNgheNghiep = new System.Windows.Forms.Label();
            this.pnlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPanel
            // 
            this.pnlPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPanel.Controls.Add(this.lblNgheNghiep);
            this.pnlPanel.Location = new System.Drawing.Point(27, 58);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(344, 56);
            this.pnlPanel.TabIndex = 2;
            // 
            // lblNgheNghiep
            // 
            this.lblNgheNghiep.AutoSize = true;
            this.lblNgheNghiep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNgheNghiep.ForeColor = System.Drawing.Color.White;
            this.lblNgheNghiep.Location = new System.Drawing.Point(12, 12);
            this.lblNgheNghiep.Name = "lblNgheNghiep";
            this.lblNgheNghiep.Size = new System.Drawing.Size(309, 28);
            this.lblNgheNghiep.TabIndex = 0;
            this.lblNgheNghiep.Text = "Top 15 nghề nghiệp thịnh hành";
            // 
            // FThongKeNgheNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.pnlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThongKeNgheNghiep";
            this.Text = "FThongKeNgheNghiep";
            this.Load += new System.EventHandler(this.FThongKeNgheNghiep_Load);
            this.pnlPanel.ResumeLayout(false);
            this.pnlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlPanel;
        private Label lblNgheNghiep;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNgheNghiep;
    }
}