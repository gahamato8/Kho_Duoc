
namespace KhoDuoc
{
    partial class FrmBaoCaoThongKeNhapThuoc1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoThongKeNhapThuoc1));
            this.ReportThongKeNhapThuoc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new ControlProject1510.XFilteg();
            this.txtMaThuoc = new ControlProject1510.XFilteg();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnInTatCa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrdanhsachthuoc = new System.Windows.Forms.DataGridView();
            this.cTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdanhsachthuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportThongKeNhapThuoc
            // 
            this.ReportThongKeNhapThuoc.ActiveViewIndex = -1;
            this.ReportThongKeNhapThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportThongKeNhapThuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportThongKeNhapThuoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportThongKeNhapThuoc.Location = new System.Drawing.Point(0, 110);
            this.ReportThongKeNhapThuoc.Name = "ReportThongKeNhapThuoc";
            this.ReportThongKeNhapThuoc.Size = new System.Drawing.Size(1350, 619);
            this.ReportThongKeNhapThuoc.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel11.Controls.Add(this.label20);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1350, 57);
            this.panel11.TabIndex = 8;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label20.Location = new System.Drawing.Point(12, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1326, 64);
            this.label20.TabIndex = 0;
            this.label20.Text = "BÁO CÁO THỐNG KÊ NHẬP THUỐC";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.BackColor = System.Drawing.Color.White;
            this.txtTenThuoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuoc.ForeColor = System.Drawing.Color.Black;
            this.txtTenThuoc.Location = new System.Drawing.Point(672, 10);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.ReadOnly = true;
            this.txtTenThuoc.Size = new System.Drawing.Size(487, 32);
            this.txtTenThuoc.TabIndex = 169;
            this.txtTenThuoc.TabStop = false;
            this.txtTenThuoc.xCoTimMoRong = false;
            this.txtTenThuoc.xDataGrid = null;
            this.txtTenThuoc.xField_Key = "MaThuoc";
            this.txtTenThuoc.xKeep_Old_Value = false;
            this.txtTenThuoc.xTimChinhXac = false;
            this.txtTenThuoc.xTimMoRong = "";
            this.txtTenThuoc.xTimTrenField = "MaThuoc";
            this.txtTenThuoc.Click += new System.EventHandler(this.txtTenThuoc_Click);
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaThuoc.BackColor = System.Drawing.Color.White;
            this.txtMaThuoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuoc.ForeColor = System.Drawing.Color.Black;
            this.txtMaThuoc.Location = new System.Drawing.Point(907, 10);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.ReadOnly = true;
            this.txtMaThuoc.Size = new System.Drawing.Size(132, 32);
            this.txtMaThuoc.TabIndex = 168;
            this.txtMaThuoc.TabStop = false;
            this.txtMaThuoc.xCoTimMoRong = false;
            this.txtMaThuoc.xDataGrid = null;
            this.txtMaThuoc.xField_Key = "MaThuoc";
            this.txtMaThuoc.xKeep_Old_Value = false;
            this.txtMaThuoc.xTimChinhXac = false;
            this.txtMaThuoc.xTimMoRong = "";
            this.txtMaThuoc.xTimTrenField = "MaThuoc";
            this.txtMaThuoc.Enter += new System.EventHandler(this.txtMaThuoc_Enter);
            this.txtMaThuoc.Leave += new System.EventHandler(this.txtMaThuoc_Leave);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnIn.Location = new System.Drawing.Point(1134, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(85, 41);
            this.btnIn.TabIndex = 65;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnInTatCa
            // 
            this.btnInTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnInTatCa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInTatCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnInTatCa.Location = new System.Drawing.Point(1225, 6);
            this.btnInTatCa.Name = "btnInTatCa";
            this.btnInTatCa.Size = new System.Drawing.Size(113, 41);
            this.btnInTatCa.TabIndex = 64;
            this.btnInTatCa.Text = "In tất cả";
            this.btnInTatCa.UseVisualStyleBackColor = false;
            this.btnInTatCa.Click += new System.EventHandler(this.btnInTatCa_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(520, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mã - Tên thuốc";
            // 
            // dtNgay
            // 
            this.dtNgay.AllowDrop = true;
            this.dtNgay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(123, 2);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(232, 32);
            this.dtNgay.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(19, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Thời gian";
            // 
            // dgrdanhsachthuoc
            // 
            this.dgrdanhsachthuoc.AllowUserToAddRows = false;
            this.dgrdanhsachthuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrdanhsachthuoc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrdanhsachthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdanhsachthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenThuoc,
            this.cMaThuoc});
            this.dgrdanhsachthuoc.Location = new System.Drawing.Point(681, 110);
            this.dgrdanhsachthuoc.Name = "dgrdanhsachthuoc";
            this.dgrdanhsachthuoc.Size = new System.Drawing.Size(367, 150);
            this.dgrdanhsachthuoc.TabIndex = 10;
            this.dgrdanhsachthuoc.Visible = false;
            this.dgrdanhsachthuoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdanhsachthuoc_CellMouseClick);
            // 
            // cTenThuoc
            // 
            this.cTenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenThuoc.DataPropertyName = "TenThuoc";
            this.cTenThuoc.HeaderText = "Tên thuốc";
            this.cTenThuoc.Name = "cTenThuoc";
            // 
            // cMaThuoc
            // 
            this.cMaThuoc.DataPropertyName = "MaThuoc";
            this.cMaThuoc.HeaderText = "Mã Thuốc";
            this.cMaThuoc.Name = "cMaThuoc";
            this.cMaThuoc.Width = 174;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenThuoc);
            this.panel1.Controls.Add(this.txtMaThuoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.dtNgay);
            this.panel1.Controls.Add(this.btnInTatCa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 61);
            this.panel1.TabIndex = 11;
            // 
            // FrmBaoCaoThongKeNhapThuoc1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dgrdanhsachthuoc);
            this.Controls.Add(this.ReportThongKeNhapThuoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel11);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBaoCaoThongKeNhapThuoc1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdanhsachthuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportThongKeNhapThuoc;
        private System.Windows.Forms.Panel panel11;
        private ControlProject1510.XFilteg txtMaThuoc;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnInTatCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private ControlProject1510.XFilteg txtTenThuoc;
        private System.Windows.Forms.DataGridView dgrdanhsachthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaThuoc;
        private System.Windows.Forms.Panel panel1;
    }
}