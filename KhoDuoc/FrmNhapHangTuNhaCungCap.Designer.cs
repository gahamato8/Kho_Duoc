
namespace KhoDuoc
{
    partial class FrmNhapHangTuNhaCungCap
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvNhapHangTuNhaCungCap = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.cboKho = new ControlProject1510.ComboBoxSearch();
            this.cboVAT_HD = new ControlProject1510.ComboBoxSearch();
            this.cboLoai = new ControlProject1510.ComboBoxSearch();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpNgayLV = new System.Windows.Forms.DateTimePicker();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.txtThanhTien = new ControlProject1510.XFilteg();
            this.txtDonGia = new ControlProject1510.XFilteg();
            this.txtSoLuong = new ControlProject1510.XFilteg();
            this.txtSoLo = new ControlProject1510.XFilteg();
            this.txtTenThuoc = new ControlProject1510.XFilteg();
            this.txtMaThuoc = new ControlProject1510.XFilteg();
            this.dtpNgayHĐ = new System.Windows.Forms.DateTimePicker();
            this.txtDonViBan = new ControlProject1510.XFilteg();
            this.txtTenNCC = new ControlProject1510.XFilteg();
            this.txtSoHoaDon = new ControlProject1510.XFilteg();
            this.txtKyHieuHD = new ControlProject1510.XFilteg();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cMaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHangTuNhaCungCap)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1336, 805);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1328, 771);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập Hàng Từ Nhà Cung Cấp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvNhapHangTuNhaCungCap);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 329);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1322, 439);
            this.panel4.TabIndex = 5;
            // 
            // dgvNhapHangTuNhaCungCap
            // 
            this.dgvNhapHangTuNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHangTuNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaThuoc,
            this.cTenThuoc,
            this.cSoLo,
            this.cHSD,
            this.cSoLuong,
            this.cDonGia,
            this.cThanhTien,
            this.cXoa});
            this.dgvNhapHangTuNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapHangTuNhaCungCap.Location = new System.Drawing.Point(0, 0);
            this.dgvNhapHangTuNhaCungCap.Name = "dgvNhapHangTuNhaCungCap";
            this.dgvNhapHangTuNhaCungCap.Size = new System.Drawing.Size(1322, 439);
            this.dgvNhapHangTuNhaCungCap.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cboKho);
            this.panel2.Controls.Add(this.cboVAT_HD);
            this.panel2.Controls.Add(this.cboLoai);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.dtpNgayLV);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.dtpHSD);
            this.panel2.Controls.Add(this.btnTaoMoi);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.txtSoLo);
            this.panel2.Controls.Add(this.txtTenThuoc);
            this.panel2.Controls.Add(this.txtMaThuoc);
            this.panel2.Controls.Add(this.dtpNgayHĐ);
            this.panel2.Controls.Add(this.txtDonViBan);
            this.panel2.Controls.Add(this.txtTenNCC);
            this.panel2.Controls.Add(this.txtSoHoaDon);
            this.panel2.Controls.Add(this.txtKyHieuHD);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1322, 272);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(1213, 223);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 37);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnTaoMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTaoMoi.Location = new System.Drawing.Point(1067, 111);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(110, 47);
            this.btnTaoMoi.TabIndex = 0;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            // 
            // cboKho
            // 
            this.cboKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKho.AutoComplete = false;
            this.cboKho.AutoDropdown = false;
            this.cboKho.BackColorEven = System.Drawing.Color.White;
            this.cboKho.BackColorOdd = System.Drawing.Color.White;
            this.cboKho.ColumnNames = "";
            this.cboKho.ColumnWidthDefault = 75;
            this.cboKho.ColumnWidths = "";
            this.cboKho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.LinkedColumnIndex = 0;
            this.cboKho.LinkedTextBox = null;
            this.cboKho.Location = new System.Drawing.Point(371, 76);
            this.cboKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(456, 30);
            this.cboKho.TabIndex = 40;
            // 
            // cboVAT_HD
            // 
            this.cboVAT_HD.AutoComplete = false;
            this.cboVAT_HD.AutoDropdown = false;
            this.cboVAT_HD.BackColorEven = System.Drawing.Color.White;
            this.cboVAT_HD.BackColorOdd = System.Drawing.Color.White;
            this.cboVAT_HD.ColumnNames = "";
            this.cboVAT_HD.ColumnWidthDefault = 75;
            this.cboVAT_HD.ColumnWidths = "";
            this.cboVAT_HD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboVAT_HD.FormattingEnabled = true;
            this.cboVAT_HD.LinkedColumnIndex = 0;
            this.cboVAT_HD.LinkedTextBox = null;
            this.cboVAT_HD.Location = new System.Drawing.Point(126, 76);
            this.cboVAT_HD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboVAT_HD.Name = "cboVAT_HD";
            this.cboVAT_HD.Size = new System.Drawing.Size(134, 30);
            this.cboVAT_HD.TabIndex = 39;
            // 
            // cboLoai
            // 
            this.cboLoai.AutoComplete = false;
            this.cboLoai.AutoDropdown = false;
            this.cboLoai.BackColorEven = System.Drawing.Color.White;
            this.cboLoai.BackColorOdd = System.Drawing.Color.White;
            this.cboLoai.ColumnNames = "";
            this.cboLoai.ColumnWidthDefault = 75;
            this.cboLoai.ColumnWidths = "";
            this.cboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.LinkedColumnIndex = 0;
            this.cboLoai.LinkedTextBox = null;
            this.cboLoai.Location = new System.Drawing.Point(89, 21);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(134, 30);
            this.cboLoai.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label21.Location = new System.Drawing.Point(1015, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 22);
            this.label21.TabIndex = 37;
            this.label21.Text = "Ngày LV: ";
            // 
            // dtpNgayLV
            // 
            this.dtpNgayLV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayLV.Location = new System.Drawing.Point(1125, 19);
            this.dtpNgayLV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayLV.Name = "dtpNgayLV";
            this.dtpNgayLV.Size = new System.Drawing.Size(157, 29);
            this.dtpNgayLV.TabIndex = 36;
            // 
            // dtpHSD
            // 
            this.dtpHSD.Location = new System.Drawing.Point(829, 228);
            this.dtpHSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(129, 29);
            this.dtpHSD.TabIndex = 35;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTien.Location = new System.Drawing.Point(892, 121);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(130, 29);
            this.txtThanhTien.TabIndex = 34;
            this.txtThanhTien.xCoTimMoRong = false;
            this.txtThanhTien.xDataGrid = null;
            this.txtThanhTien.xField_Key = "";
            this.txtThanhTien.xKeep_Old_Value = false;
            this.txtThanhTien.xTimChinhXac = false;
            this.txtThanhTien.xTimMoRong = "";
            this.txtThanhTien.xTimTrenField = null;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Location = new System.Drawing.Point(1079, 228);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(127, 29);
            this.txtDonGia.TabIndex = 31;
            this.txtDonGia.xCoTimMoRong = false;
            this.txtDonGia.xDataGrid = null;
            this.txtDonGia.xField_Key = "";
            this.txtDonGia.xKeep_Old_Value = false;
            this.txtDonGia.xTimChinhXac = false;
            this.txtDonGia.xTimMoRong = "";
            this.txtDonGia.xTimTrenField = null;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Location = new System.Drawing.Point(976, 228);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(87, 29);
            this.txtSoLuong.TabIndex = 30;
            this.txtSoLuong.xCoTimMoRong = false;
            this.txtSoLuong.xDataGrid = null;
            this.txtSoLuong.xField_Key = "";
            this.txtSoLuong.xKeep_Old_Value = false;
            this.txtSoLuong.xTimChinhXac = false;
            this.txtSoLuong.xTimMoRong = "";
            this.txtSoLuong.xTimTrenField = null;
            // 
            // txtSoLo
            // 
            this.txtSoLo.Location = new System.Drawing.Point(680, 228);
            this.txtSoLo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLo.Name = "txtSoLo";
            this.txtSoLo.Size = new System.Drawing.Size(133, 29);
            this.txtSoLo.TabIndex = 29;
            this.txtSoLo.xCoTimMoRong = false;
            this.txtSoLo.xDataGrid = null;
            this.txtSoLo.xField_Key = "";
            this.txtSoLo.xKeep_Old_Value = false;
            this.txtSoLo.xTimChinhXac = false;
            this.txtSoLo.xTimMoRong = "";
            this.txtSoLo.xTimTrenField = null;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(204, 228);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(449, 29);
            this.txtTenThuoc.TabIndex = 28;
            this.txtTenThuoc.xCoTimMoRong = false;
            this.txtTenThuoc.xDataGrid = null;
            this.txtTenThuoc.xField_Key = "";
            this.txtTenThuoc.xKeep_Old_Value = false;
            this.txtTenThuoc.xTimChinhXac = false;
            this.txtTenThuoc.xTimMoRong = "";
            this.txtTenThuoc.xTimTrenField = null;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(42, 228);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(111, 29);
            this.txtMaThuoc.TabIndex = 27;
            this.txtMaThuoc.xCoTimMoRong = false;
            this.txtMaThuoc.xDataGrid = null;
            this.txtMaThuoc.xField_Key = "";
            this.txtMaThuoc.xKeep_Old_Value = false;
            this.txtMaThuoc.xTimChinhXac = false;
            this.txtMaThuoc.xTimMoRong = "";
            this.txtMaThuoc.xTimTrenField = null;
            // 
            // dtpNgayHĐ
            // 
            this.dtpNgayHĐ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayHĐ.Location = new System.Drawing.Point(824, 21);
            this.dtpNgayHĐ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayHĐ.Name = "dtpNgayHĐ";
            this.dtpNgayHĐ.Size = new System.Drawing.Size(161, 29);
            this.dtpNgayHĐ.TabIndex = 26;
            // 
            // txtDonViBan
            // 
            this.txtDonViBan.Location = new System.Drawing.Point(231, 131);
            this.txtDonViBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonViBan.Name = "txtDonViBan";
            this.txtDonViBan.Size = new System.Drawing.Size(111, 29);
            this.txtDonViBan.TabIndex = 25;
            this.txtDonViBan.xCoTimMoRong = false;
            this.txtDonViBan.xDataGrid = null;
            this.txtDonViBan.xField_Key = "";
            this.txtDonViBan.xKeep_Old_Value = false;
            this.txtDonViBan.xTimChinhXac = false;
            this.txtDonViBan.xTimMoRong = "";
            this.txtDonViBan.xTimTrenField = null;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNCC.Location = new System.Drawing.Point(486, 135);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(342, 29);
            this.txtTenNCC.TabIndex = 24;
            this.txtTenNCC.xCoTimMoRong = false;
            this.txtTenNCC.xDataGrid = null;
            this.txtTenNCC.xField_Key = "";
            this.txtTenNCC.xKeep_Old_Value = false;
            this.txtTenNCC.xTimChinhXac = false;
            this.txtTenNCC.xTimMoRong = "";
            this.txtTenNCC.xTimTrenField = null;
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoHoaDon.Location = new System.Drawing.Point(601, 21);
            this.txtSoHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(115, 29);
            this.txtSoHoaDon.TabIndex = 23;
            this.txtSoHoaDon.xCoTimMoRong = false;
            this.txtSoHoaDon.xDataGrid = null;
            this.txtSoHoaDon.xField_Key = "";
            this.txtSoHoaDon.xKeep_Old_Value = false;
            this.txtSoHoaDon.xTimChinhXac = false;
            this.txtSoHoaDon.xTimMoRong = "";
            this.txtSoHoaDon.xTimTrenField = null;
            // 
            // txtKyHieuHD
            // 
            this.txtKyHieuHD.Location = new System.Drawing.Point(371, 21);
            this.txtKyHieuHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKyHieuHD.Name = "txtKyHieuHD";
            this.txtKyHieuHD.Size = new System.Drawing.Size(111, 29);
            this.txtKyHieuHD.TabIndex = 21;
            this.txtKyHieuHD.xCoTimMoRong = false;
            this.txtKyHieuHD.xDataGrid = null;
            this.txtKyHieuHD.xField_Key = "";
            this.txtKyHieuHD.xKeep_Old_Value = false;
            this.txtKyHieuHD.xTimChinhXac = false;
            this.txtKyHieuHD.xTimMoRong = "";
            this.txtKyHieuHD.xTimTrenField = null;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label20.Location = new System.Drawing.Point(905, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 22);
            this.label20.TabIndex = 20;
            this.label20.Text = "Thành tiền";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label17.Location = new System.Drawing.Point(1096, 202);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 22);
            this.label17.TabIndex = 17;
            this.label17.Text = "Đơn giá";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label16.Location = new System.Drawing.Point(980, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 22);
            this.label16.TabIndex = 16;
            this.label16.Text = "Số lượng";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label15.Location = new System.Drawing.Point(828, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 22);
            this.label15.TabIndex = 15;
            this.label15.Text = "HSD";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label14.Location = new System.Drawing.Point(694, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 22);
            this.label14.TabIndex = 14;
            this.label14.Text = "Số lô";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label13.Location = new System.Drawing.Point(48, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 22);
            this.label13.TabIndex = 13;
            this.label13.Text = "Mã Thuốc";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label12.Location = new System.Drawing.Point(298, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tên Thuốc ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label9.Location = new System.Drawing.Point(488, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Số hóa đơn";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(582, -46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Số hóa đơn";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label8.Location = new System.Drawing.Point(722, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày HĐ: ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label6.Location = new System.Drawing.Point(297, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(24, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "VAT HĐ: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn vị bán(Mã NCC):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(236, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ký hiệu HĐ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại: ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label11.Location = new System.Drawing.Point(387, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tên NCC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 54);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(497, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Hàng Từ Nhà Cung Cấp";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1492, 771);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Tiết Phiếu Nhập Từ Nhà Cung Cấp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(1200, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 47);
            this.button1.TabIndex = 41;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cMaThuoc
            // 
            this.cMaThuoc.HeaderText = "Mã Thuốc";
            this.cMaThuoc.Name = "cMaThuoc";
            this.cMaThuoc.Width = 150;
            // 
            // cTenThuoc
            // 
            this.cTenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenThuoc.HeaderText = "Tên Thuốc";
            this.cTenThuoc.Name = "cTenThuoc";
            // 
            // cSoLo
            // 
            this.cSoLo.HeaderText = "Số Lô";
            this.cSoLo.Name = "cSoLo";
            this.cSoLo.Width = 150;
            // 
            // cHSD
            // 
            this.cHSD.HeaderText = "HSD";
            this.cHSD.Name = "cHSD";
            this.cHSD.Width = 150;
            // 
            // cSoLuong
            // 
            this.cSoLuong.HeaderText = "Số Lượng";
            this.cSoLuong.Name = "cSoLuong";
            // 
            // cDonGia
            // 
            this.cDonGia.HeaderText = "Đơn Giá";
            this.cDonGia.Name = "cDonGia";
            this.cDonGia.Width = 150;
            // 
            // cThanhTien
            // 
            this.cThanhTien.HeaderText = "Thành Tiền";
            this.cThanhTien.Name = "cThanhTien";
            this.cThanhTien.Visible = false;
            this.cThanhTien.Width = 150;
            // 
            // cXoa
            // 
            this.cXoa.HeaderText = "Xóa";
            this.cXoa.Name = "cXoa";
            // 
            // FrmNhapHangTuNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 805);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNhapHangTuNhaCungCap";
            this.Text = "FrmNhapHangNhaCungCap";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHangTuNhaCungCap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaoMoi;
        private ControlProject1510.ComboBoxSearch cboKho;
        private ControlProject1510.ComboBoxSearch cboVAT_HD;
        private ControlProject1510.ComboBoxSearch cboLoai;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpNgayLV;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private ControlProject1510.XFilteg txtThanhTien;
        private ControlProject1510.XFilteg txtDonGia;
        private ControlProject1510.XFilteg txtSoLuong;
        private ControlProject1510.XFilteg txtSoLo;
        private ControlProject1510.XFilteg txtTenThuoc;
        private ControlProject1510.XFilteg txtMaThuoc;
        private System.Windows.Forms.DateTimePicker dtpNgayHĐ;
        private ControlProject1510.XFilteg txtDonViBan;
        private ControlProject1510.XFilteg txtTenNCC;
        private ControlProject1510.XFilteg txtSoHoaDon;
        private ControlProject1510.XFilteg txtKyHieuHD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvNhapHangTuNhaCungCap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThanhTien;
        private System.Windows.Forms.DataGridViewImageColumn cXoa;
    }
}