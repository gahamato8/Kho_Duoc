
namespace KhoDuoc
{
    partial class FrmTaoPhieuYeuCauLinhThuocOQuayThuoc123
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaoPhieuYeuCauLinhThuocOQuayThuoc123));
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new ControlProject1510.XFilteg();
            this.dgrTaoPhieuLinh = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTaoPhieuYeuCauLinh = new System.Windows.Forms.Button();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new ControlProject1510.XFilteg();
            this.cTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuongYeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuongCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaPhieuYeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTaoPhieuLinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1350, 59);
            this.panel6.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1335, 40);
            this.label3.TabIndex = 28;
            this.label3.Text = "TẠO PHIẾU LĨNH";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuNhap.ForeColor = System.Drawing.Color.Transparent;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(149, 36);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(227, 32);
            this.txtMaPhieuNhap.TabIndex = 48;
            this.txtMaPhieuNhap.xCoTimMoRong = false;
            this.txtMaPhieuNhap.xDataGrid = this.dgrTaoPhieuLinh;
            this.txtMaPhieuNhap.xField_Key = "MaPhieuYeuCau";
            this.txtMaPhieuNhap.xKeep_Old_Value = false;
            this.txtMaPhieuNhap.xTimChinhXac = false;
            this.txtMaPhieuNhap.xTimMoRong = "";
            this.txtMaPhieuNhap.xTimTrenField = "MaPhieuYeuCau";
            // 
            // dgrTaoPhieuLinh
            // 
            this.dgrTaoPhieuLinh.AllowUserToAddRows = false;
            this.dgrTaoPhieuLinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTaoPhieuLinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenThuoc,
            this.cDonVi,
            this.cSoLuongYeuCau,
            this.cSoLuongCap,
            this.cLo,
            this.cHanDung,
            this.cGhiChu,
            this.cNguoiLap,
            this.cNgayLap,
            this.cMaPhieuYeuCau});
            this.dgrTaoPhieuLinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrTaoPhieuLinh.Location = new System.Drawing.Point(0, 164);
            this.dgrTaoPhieuLinh.Name = "dgrTaoPhieuLinh";
            this.dgrTaoPhieuLinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrTaoPhieuLinh.Size = new System.Drawing.Size(1350, 565);
            this.dgrTaoPhieuLinh.TabIndex = 52;
            this.dgrTaoPhieuLinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_CellContentClick);
            this.dgrTaoPhieuLinh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrTaoPhieuLinh_CellMouseClick);
            this.dgrTaoPhieuLinh.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgrTaoPhieuLinh_RowPostPaint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnTaoPhieuYeuCauLinh);
            this.panel1.Controls.Add(this.dtNgayNhap);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNguoiLap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaPhieuNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 105);
            this.panel1.TabIndex = 51;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuayLai.Location = new System.Drawing.Point(1234, 32);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(103, 40);
            this.btnQuayLai.TabIndex = 64;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnTaoPhieuYeuCauLinh
            // 
            this.btnTaoPhieuYeuCauLinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoPhieuYeuCauLinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnTaoPhieuYeuCauLinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTaoPhieuYeuCauLinh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuYeuCauLinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTaoPhieuYeuCauLinh.Location = new System.Drawing.Point(1082, 32);
            this.btnTaoPhieuYeuCauLinh.Name = "btnTaoPhieuYeuCauLinh";
            this.btnTaoPhieuYeuCauLinh.Size = new System.Drawing.Size(137, 40);
            this.btnTaoPhieuYeuCauLinh.TabIndex = 63;
            this.btnTaoPhieuYeuCauLinh.Text = "Duyệt phiếu";
            this.btnTaoPhieuYeuCauLinh.UseVisualStyleBackColor = false;
            this.btnTaoPhieuYeuCauLinh.Click += new System.EventHandler(this.btnTaoPhieuYeuCauLinh_Click);
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.AllowDrop = true;
            this.dtNgayNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNgayNhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(494, 37);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(183, 32);
            this.dtNgayNhap.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label7.Location = new System.Drawing.Point(386, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(687, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Người lập";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNguoiLap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiLap.ForeColor = System.Drawing.Color.Black;
            this.txtNguoiLap.Location = new System.Drawing.Point(787, 36);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(281, 32);
            this.txtNguoiLap.TabIndex = 26;
            this.txtNguoiLap.xCoTimMoRong = false;
            this.txtNguoiLap.xDataGrid = this.dgrTaoPhieuLinh;
            this.txtNguoiLap.xField_Key = "NguoiLap";
            this.txtNguoiLap.xKeep_Old_Value = false;
            this.txtNguoiLap.xTimChinhXac = false;
            this.txtNguoiLap.xTimMoRong = "";
            this.txtNguoiLap.xTimTrenField = "NguoiLap";
            this.txtNguoiLap.Enter += new System.EventHandler(this.txtNguoiLap_Enter);
            this.txtNguoiLap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNguoiLap_KeyPress);
            this.txtNguoiLap.Leave += new System.EventHandler(this.txtNguoiLap_Leave);
            // 
            // cTenThuoc
            // 
            this.cTenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenThuoc.DataPropertyName = "TenThuoc_VatTu";
            this.cTenThuoc.HeaderText = "Tên thuốc/vật tư";
            this.cTenThuoc.Name = "cTenThuoc";
            // 
            // cDonVi
            // 
            this.cDonVi.DataPropertyName = "DonVi";
            this.cDonVi.HeaderText = "Đơn vị";
            this.cDonVi.Name = "cDonVi";
            this.cDonVi.Width = 150;
            // 
            // cSoLuongYeuCau
            // 
            this.cSoLuongYeuCau.DataPropertyName = "SoLuongYeuCau";
            this.cSoLuongYeuCau.HeaderText = "SLYC";
            this.cSoLuongYeuCau.Name = "cSoLuongYeuCau";
            // 
            // cSoLuongCap
            // 
            this.cSoLuongCap.DataPropertyName = "SoLuongCap";
            this.cSoLuongCap.HeaderText = "SL Cấp";
            this.cSoLuongCap.Name = "cSoLuongCap";
            // 
            // cLo
            // 
            this.cLo.DataPropertyName = "Lo";
            this.cLo.HeaderText = "Lô";
            this.cLo.Name = "cLo";
            // 
            // cHanDung
            // 
            this.cHanDung.DataPropertyName = "HanDung";
            this.cHanDung.HeaderText = "Hạn dùng";
            this.cHanDung.Name = "cHanDung";
            this.cHanDung.Width = 150;
            // 
            // cGhiChu
            // 
            this.cGhiChu.DataPropertyName = "GhiChu";
            this.cGhiChu.HeaderText = "Ghi chú";
            this.cGhiChu.Name = "cGhiChu";
            this.cGhiChu.Width = 300;
            // 
            // cNguoiLap
            // 
            this.cNguoiLap.DataPropertyName = "NguoiLap";
            this.cNguoiLap.HeaderText = "Người Lập";
            this.cNguoiLap.Name = "cNguoiLap";
            this.cNguoiLap.Width = 5;
            // 
            // cNgayLap
            // 
            this.cNgayLap.DataPropertyName = "NgayLap";
            this.cNgayLap.HeaderText = "Ngày lập";
            this.cNgayLap.Name = "cNgayLap";
            this.cNgayLap.Visible = false;
            // 
            // cMaPhieuYeuCau
            // 
            this.cMaPhieuYeuCau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cMaPhieuYeuCau.DataPropertyName = "MaPhieuYeuCau";
            this.cMaPhieuYeuCau.HeaderText = "MaPhieuYeuCau";
            this.cMaPhieuYeuCau.MinimumWidth = 150;
            this.cMaPhieuYeuCau.Name = "cMaPhieuYeuCau";
            this.cMaPhieuYeuCau.Visible = false;
            this.cMaPhieuYeuCau.Width = 150;
            // 
            // FrmTaoPhieuYeuCauLinhThuocOQuayThuoc123
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dgrTaoPhieuLinh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTaoPhieuYeuCauLinhThuocOQuayThuoc123";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrTaoPhieuLinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private ControlProject1510.XFilteg txtMaPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnTaoPhieuYeuCauLinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ControlProject1510.XFilteg txtNguoiLap;
        private System.Windows.Forms.DataGridView dgrTaoPhieuLinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuongYeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuongCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHanDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNguoiLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaPhieuYeuCau;
    }
}