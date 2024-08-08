
namespace KhoDuoc
{
    partial class FrmBaoCaoTheKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoTheKho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaThuoc = new ControlProject1510.XFilteg();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new ControlProject1510.XFilteg();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgrdanhsachthuoc = new System.Windows.Forms.DataGridView();
            this.cMaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReportBaoCaoTheKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdanhsachthuoc)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 55);
            this.panel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label14.Location = new System.Drawing.Point(558, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(350, 40);
            this.label14.TabIndex = 78;
            this.label14.Text = "BÁO CÁO THẺ KHO";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtMaThuoc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTenThuoc);
            this.panel2.Controls.Add(this.btnBaoCao);
            this.panel2.Controls.Add(this.dtNgay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1357, 86);
            this.panel2.TabIndex = 1;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMaThuoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuoc.ForeColor = System.Drawing.Color.Black;
            this.txtMaThuoc.Location = new System.Drawing.Point(561, 42);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(112, 32);
            this.txtMaThuoc.TabIndex = 80;
            this.txtMaThuoc.xCoTimMoRong = false;
            this.txtMaThuoc.xDataGrid = null;
            this.txtMaThuoc.xField_Key = "MaThuoc";
            this.txtMaThuoc.xKeep_Old_Value = false;
            this.txtMaThuoc.xTimChinhXac = false;
            this.txtMaThuoc.xTimMoRong = "";
            this.txtMaThuoc.xTimTrenField = "MaThuoc";
            this.txtMaThuoc.Click += new System.EventHandler(this.txtMaThuoc_VatTu_Click);
            this.txtMaThuoc.Enter += new System.EventHandler(this.txtMaThuoc_VatTu_Enter_1);
            this.txtMaThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaThuoc_VatTu_KeyPress_1);
            this.txtMaThuoc.Leave += new System.EventHandler(this.txtMaThuoc_VatTu_Leave_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(701, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 103;
            this.label3.Text = "Tên thuốc";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuoc.ForeColor = System.Drawing.Color.Black;
            this.txtTenThuoc.Location = new System.Drawing.Point(561, 42);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(382, 32);
            this.txtTenThuoc.TabIndex = 102;
            this.txtTenThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTenThuoc.xCoTimMoRong = false;
            this.txtTenThuoc.xDataGrid = null;
            this.txtTenThuoc.xField_Key = "TenThuoc";
            this.txtTenThuoc.xKeep_Old_Value = false;
            this.txtTenThuoc.xTimChinhXac = false;
            this.txtTenThuoc.xTimMoRong = "";
            this.txtTenThuoc.xTimTrenField = "TenThuoc";
            this.txtTenThuoc.Click += new System.EventHandler(this.txtTenThuoc_VatTu_Click);
            this.txtTenThuoc.Enter += new System.EventHandler(this.txtTenThuoc_VatTu_Enter_1);
            this.txtTenThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenThuoc_VatTu_KeyPress_1);
            this.txtTenThuoc.Leave += new System.EventHandler(this.txtTenThuoc_VatTu_Leave_1);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(1197, 38);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(100, 36);
            this.btnBaoCao.TabIndex = 99;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click_2);
            // 
            // dtNgay
            // 
            this.dtNgay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay.Location = new System.Drawing.Point(31, 43);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(321, 32);
            this.dtNgay.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(557, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 79;
            this.label2.Text = "Mã thuốc";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label17.Location = new System.Drawing.Point(27, 14);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 24);
            this.label17.TabIndex = 77;
            this.label17.Text = "Thời gian";
            // 
            // dgrdanhsachthuoc
            // 
            this.dgrdanhsachthuoc.AllowUserToAddRows = false;
            this.dgrdanhsachthuoc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrdanhsachthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdanhsachthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaThuoc,
            this.cTenThuoc,
            this.cLoai,
            this.cThoiGian});
            this.dgrdanhsachthuoc.Location = new System.Drawing.Point(561, 0);
            this.dgrdanhsachthuoc.Name = "dgrdanhsachthuoc";
            this.dgrdanhsachthuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdanhsachthuoc.Size = new System.Drawing.Size(382, 150);
            this.dgrdanhsachthuoc.TabIndex = 11;
            this.dgrdanhsachthuoc.Visible = false;
            this.dgrdanhsachthuoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdanhsachthuoc_CellMouseClick);
            // 
            // cMaThuoc
            // 
            this.cMaThuoc.DataPropertyName = "MaThuoc";
            this.cMaThuoc.HeaderText = "Mã Thuốc";
            this.cMaThuoc.Name = "cMaThuoc";
            this.cMaThuoc.Width = 120;
            // 
            // cTenThuoc
            // 
            this.cTenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenThuoc.DataPropertyName = "TenThuoc";
            this.cTenThuoc.HeaderText = "Tên thuốc";
            this.cTenThuoc.Name = "cTenThuoc";
            // 
            // cLoai
            // 
            this.cLoai.DataPropertyName = "TENLOAITHUOC";
            this.cLoai.HeaderText = "Loại";
            this.cLoai.Name = "cLoai";
            this.cLoai.Visible = false;
            // 
            // cThoiGian
            // 
            this.cThoiGian.DataPropertyName = "NgayNhap";
            this.cThoiGian.HeaderText = "Thời gian";
            this.cThoiGian.Name = "cThoiGian";
            this.cThoiGian.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrdanhsachthuoc);
            this.panel3.Controls.Add(this.ReportBaoCaoTheKho);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1357, 596);
            this.panel3.TabIndex = 2;
            // 
            // ReportBaoCaoTheKho
            // 
            this.ReportBaoCaoTheKho.ActiveViewIndex = -1;
            this.ReportBaoCaoTheKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportBaoCaoTheKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportBaoCaoTheKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportBaoCaoTheKho.Location = new System.Drawing.Point(0, 0);
            this.ReportBaoCaoTheKho.Name = "ReportBaoCaoTheKho";
            this.ReportBaoCaoTheKho.Size = new System.Drawing.Size(1357, 596);
            this.ReportBaoCaoTheKho.TabIndex = 0;
            this.ReportBaoCaoTheKho.Click += new System.EventHandler(this.ReportBaoCaoTheKho_Click);
            // 
            // FrmBaoCaoTheKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1357, 737);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBaoCaoTheKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdanhsachthuoc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportBaoCaoTheKho;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private ControlProject1510.XFilteg txtMaThuoc;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btnBaoCao;
        private ControlProject1510.XFilteg txtTenThuoc;
        private System.Windows.Forms.DataGridView dgrdanhsachthuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThoiGian;
    }
}