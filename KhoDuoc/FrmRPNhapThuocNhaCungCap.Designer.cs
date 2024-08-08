
namespace KhoDuoc
{
    partial class FrmRPNhapThuocNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPNhapThuocNhaCungCap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RpPhieuNhapKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RpPhieuNhapKho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 796);
            this.panel1.TabIndex = 11;
            // 
            // RpPhieuNhapKho
            // 
            this.RpPhieuNhapKho.ActiveViewIndex = -1;
            this.RpPhieuNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RpPhieuNhapKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.RpPhieuNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RpPhieuNhapKho.Location = new System.Drawing.Point(0, 0);
            this.RpPhieuNhapKho.Name = "RpPhieuNhapKho";
            this.RpPhieuNhapKho.Size = new System.Drawing.Size(1403, 796);
            this.RpPhieuNhapKho.TabIndex = 3;
            // 
            // FrmRPNhapThuocNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 796);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmRPNhapThuocNhaCungCap";
            this.Text = "FrmRPNhapThuocNhaCungCap";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer RpPhieuNhapKho;
    }
}