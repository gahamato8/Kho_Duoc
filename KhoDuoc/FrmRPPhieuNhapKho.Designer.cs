
namespace KhoDuoc
{
    partial class FrmRPPhieuNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPPhieuNhapKho));
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaPhieuCNP = new ControlProject1510.XFilteg();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RpPhieuNhapKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.txtMaPhieuCNP);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1366, 51);
            this.panel4.TabIndex = 8;
            // 
            // txtMaPhieuCNP
            // 
            this.txtMaPhieuCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaPhieuCNP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhieuCNP.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuCNP.Location = new System.Drawing.Point(133, 10);
            this.txtMaPhieuCNP.Name = "txtMaPhieuCNP";
            this.txtMaPhieuCNP.ReadOnly = true;
            this.txtMaPhieuCNP.Size = new System.Drawing.Size(254, 32);
            this.txtMaPhieuCNP.TabIndex = 277;
            this.txtMaPhieuCNP.TabStop = false;
            this.txtMaPhieuCNP.xCoTimMoRong = false;
            this.txtMaPhieuCNP.xDataGrid = null;
            this.txtMaPhieuCNP.xField_Key = "MaPhieu";
            this.txtMaPhieuCNP.xKeep_Old_Value = false;
            this.txtMaPhieuCNP.xTimChinhXac = false;
            this.txtMaPhieuCNP.xTimMoRong = "";
            this.txtMaPhieuCNP.xTimTrenField = "MaPhieu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 276;
            this.label2.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(535, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP KHO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RpPhieuNhapKho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 595);
            this.panel1.TabIndex = 9;
            // 
            // RpPhieuNhapKho
            // 
            this.RpPhieuNhapKho.ActiveViewIndex = -1;
            this.RpPhieuNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RpPhieuNhapKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.RpPhieuNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RpPhieuNhapKho.Location = new System.Drawing.Point(0, 0);
            this.RpPhieuNhapKho.Name = "RpPhieuNhapKho";
            this.RpPhieuNhapKho.Size = new System.Drawing.Size(1366, 595);
            this.RpPhieuNhapKho.TabIndex = 0;
            // 
            // FrmRPPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRPPhieuNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer RpPhieuNhapKho;
        private ControlProject1510.XFilteg txtMaPhieuCNP;
        private System.Windows.Forms.Label label2;
    }
}