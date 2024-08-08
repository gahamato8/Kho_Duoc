
namespace KhoDuoc
{
    partial class FrmRPThongKeTonKhoHienTai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPThongKeTonKhoHienTai));
            this.ReportThongketonkhohientai = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReportThongketonkhohientai
            // 
            this.ReportThongketonkhohientai.ActiveViewIndex = -1;
            this.ReportThongketonkhohientai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportThongketonkhohientai.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportThongketonkhohientai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportThongketonkhohientai.Location = new System.Drawing.Point(0, 0);
            this.ReportThongketonkhohientai.Name = "ReportThongketonkhohientai";
            this.ReportThongketonkhohientai.Size = new System.Drawing.Size(1324, 757);
            this.ReportThongketonkhohientai.TabIndex = 0;
            // 
            // FrmRPThongKeTonKhoHienTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 757);
            this.Controls.Add(this.ReportThongketonkhohientai);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRPThongKeTonKhoHienTai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportThongketonkhohientai;
    }
}