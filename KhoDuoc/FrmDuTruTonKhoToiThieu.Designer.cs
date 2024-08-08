
namespace KhoDuoc
{
    partial class FrmDuTruTonKhoToiThieu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDuTruTonKhoToiThieu = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ReportDuTruTonKhoToiThieu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboTenThuoc = new ControlProject1510.ComboBoxSearch();
            this.txtNhapMaThuoc = new ControlProject1510.XFilteg();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.btnLapDuTruMuaHang = new System.Windows.Forms.Button();
            this.btnLapDuTru = new System.Windows.Forms.Button();
            this.btnLayDuLieu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDanhSachDuTru = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabDuTruTonKhoToiThieu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDuTruTonKhoToiThieu);
            this.tabControl1.Controls.Add(this.tabDanhSachDuTru);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDuTruTonKhoToiThieu
            // 
            this.tabDuTruTonKhoToiThieu.Controls.Add(this.panel1);
            this.tabDuTruTonKhoToiThieu.Location = new System.Drawing.Point(4, 28);
            this.tabDuTruTonKhoToiThieu.Name = "tabDuTruTonKhoToiThieu";
            this.tabDuTruTonKhoToiThieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDuTruTonKhoToiThieu.Size = new System.Drawing.Size(1342, 697);
            this.tabDuTruTonKhoToiThieu.TabIndex = 0;
            this.tabDuTruTonKhoToiThieu.Text = "Dự trù tồn kho tối thiểu";
            this.tabDuTruTonKhoToiThieu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 691);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ReportDuTruTonKhoToiThieu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1336, 521);
            this.panel4.TabIndex = 2;
            // 
            // ReportDuTruTonKhoToiThieu
            // 
            this.ReportDuTruTonKhoToiThieu.ActiveViewIndex = -1;
            this.ReportDuTruTonKhoToiThieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportDuTruTonKhoToiThieu.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportDuTruTonKhoToiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportDuTruTonKhoToiThieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDuTruTonKhoToiThieu.ForeColor = System.Drawing.Color.Black;
            this.ReportDuTruTonKhoToiThieu.Location = new System.Drawing.Point(0, 0);
            this.ReportDuTruTonKhoToiThieu.Name = "ReportDuTruTonKhoToiThieu";
            this.ReportDuTruTonKhoToiThieu.Size = new System.Drawing.Size(1336, 521);
            this.ReportDuTruTonKhoToiThieu.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cboTenThuoc);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtNhapMaThuoc);
            this.panel3.Controls.Add(this.btnThemThuoc);
            this.panel3.Controls.Add(this.btnLapDuTruMuaHang);
            this.panel3.Controls.Add(this.btnLapDuTru);
            this.panel3.Controls.Add(this.btnLayDuLieu);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1336, 88);
            this.panel3.TabIndex = 1;
            // 
            // cboTenThuoc
            // 
            this.cboTenThuoc.AllowDrop = true;
            this.cboTenThuoc.AutoComplete = true;
            this.cboTenThuoc.AutoDropdown = true;
            this.cboTenThuoc.BackColorEven = System.Drawing.Color.White;
            this.cboTenThuoc.BackColorOdd = System.Drawing.Color.White;
            this.cboTenThuoc.ColumnNames = "MaThuoc,TenThuoc";
            this.cboTenThuoc.ColumnWidthDefault = 75;
            this.cboTenThuoc.ColumnWidths = "";
            this.cboTenThuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTenThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenThuoc.ForeColor = System.Drawing.Color.Black;
            this.cboTenThuoc.FormattingEnabled = true;
            this.cboTenThuoc.LinkedColumnIndex = 0;
            this.cboTenThuoc.LinkedTextBox = this.txtNhapMaThuoc;
            this.cboTenThuoc.Location = new System.Drawing.Point(498, 31);
            this.cboTenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboTenThuoc.Name = "cboTenThuoc";
            this.cboTenThuoc.Size = new System.Drawing.Size(246, 27);
            this.cboTenThuoc.TabIndex = 103;
            // 
            // txtNhapMaThuoc
            // 
            this.txtNhapMaThuoc.ForeColor = System.Drawing.Color.Black;
            this.txtNhapMaThuoc.Location = new System.Drawing.Point(96, 29);
            this.txtNhapMaThuoc.Name = "txtNhapMaThuoc";
            this.txtNhapMaThuoc.ReadOnly = true;
            this.txtNhapMaThuoc.Size = new System.Drawing.Size(308, 26);
            this.txtNhapMaThuoc.TabIndex = 47;
            this.txtNhapMaThuoc.TabStop = false;
            this.txtNhapMaThuoc.xCoTimMoRong = false;
            this.txtNhapMaThuoc.xDataGrid = null;
            this.txtNhapMaThuoc.xField_Key = "MaThuoc";
            this.txtNhapMaThuoc.xKeep_Old_Value = false;
            this.txtNhapMaThuoc.xTimChinhXac = false;
            this.txtNhapMaThuoc.xTimMoRong = "";
            this.txtNhapMaThuoc.xTimTrenField = "MaThuoc";
            this.txtNhapMaThuoc.Enter += new System.EventHandler(this.txtNhapMaThuoc_Enter);
            this.txtNhapMaThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapMaThuoc_KeyPress);
            this.txtNhapMaThuoc.Leave += new System.EventHandler(this.txtNhapMaThuoc_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(403, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tên thuốc";
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnThemThuoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemThuoc.Location = new System.Drawing.Point(1216, 22);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(106, 38);
            this.btnThemThuoc.TabIndex = 43;
            this.btnThemThuoc.Text = "Thêm thuốc";
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // btnLapDuTruMuaHang
            // 
            this.btnLapDuTruMuaHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapDuTruMuaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnLapDuTruMuaHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLapDuTruMuaHang.Location = new System.Drawing.Point(1011, 22);
            this.btnLapDuTruMuaHang.Name = "btnLapDuTruMuaHang";
            this.btnLapDuTruMuaHang.Size = new System.Drawing.Size(177, 38);
            this.btnLapDuTruMuaHang.TabIndex = 42;
            this.btnLapDuTruMuaHang.Text = "Lập dự trù mua hàng";
            this.btnLapDuTruMuaHang.UseVisualStyleBackColor = false;
            this.btnLapDuTruMuaHang.Click += new System.EventHandler(this.btnLapDuTruMuaHang_Click);
            // 
            // btnLapDuTru
            // 
            this.btnLapDuTru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapDuTru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnLapDuTru.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLapDuTru.Location = new System.Drawing.Point(890, 22);
            this.btnLapDuTru.Name = "btnLapDuTru";
            this.btnLapDuTru.Size = new System.Drawing.Size(95, 38);
            this.btnLapDuTru.TabIndex = 41;
            this.btnLapDuTru.Text = "Lập dự trù";
            this.btnLapDuTru.UseVisualStyleBackColor = false;
            this.btnLapDuTru.Click += new System.EventHandler(this.btnLapDuTru_Click);
            // 
            // btnLayDuLieu
            // 
            this.btnLayDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLayDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnLayDuLieu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLayDuLieu.Location = new System.Drawing.Point(774, 22);
            this.btnLayDuLieu.Name = "btnLayDuLieu";
            this.btnLayDuLieu.Size = new System.Drawing.Size(85, 38);
            this.btnLayDuLieu.TabIndex = 40;
            this.btnLayDuLieu.Text = "Lấy dữ liệu";
            this.btnLayDuLieu.UseVisualStyleBackColor = false;
            this.btnLayDuLieu.Click += new System.EventHandler(this.btnLayDuLieu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã thuốc";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtNgay);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 82);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(561, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày";
            // 
            // dtNgay
            // 
            this.dtNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgay.Location = new System.Drawing.Point(618, 45);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 26);
            this.dtNgay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(532, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dự trù tồn kho tối thiểu";
            // 
            // tabDanhSachDuTru
            // 
            this.tabDanhSachDuTru.Location = new System.Drawing.Point(4, 28);
            this.tabDanhSachDuTru.Name = "tabDanhSachDuTru";
            this.tabDanhSachDuTru.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhSachDuTru.Size = new System.Drawing.Size(1342, 697);
            this.tabDanhSachDuTru.TabIndex = 1;
            this.tabDanhSachDuTru.Text = "Danh sách dự trù";
            this.tabDanhSachDuTru.UseVisualStyleBackColor = true;
            // 
            // FrmDuTruTonKhoToiThieu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDuTruTonKhoToiThieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDuTruTonKhoToiThieu";
            this.Load += new System.EventHandler(this.FrmDuTruTonKhoToiThieu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDuTruTonKhoToiThieu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDuTruTonKhoToiThieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabDanhSachDuTru;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Button btnLapDuTruMuaHang;
        private System.Windows.Forms.Button btnLapDuTru;
        private System.Windows.Forms.Button btnLayDuLieu;
        private ControlProject1510.XFilteg txtNhapMaThuoc;
        private System.Windows.Forms.Label label6;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportDuTruTonKhoToiThieu;
        private ControlProject1510.ComboBoxSearch cboTenThuoc;
    }
}