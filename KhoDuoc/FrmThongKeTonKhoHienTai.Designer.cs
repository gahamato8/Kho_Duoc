
namespace KhoDuoc
{
    partial class FrmThongKeTonKhoHienTai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeTonKhoHienTai));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtSL = new ControlProject1510.XFilteg();
            this.dgrThongKeTonKhoHienTai = new System.Windows.Forms.DataGridView();
            this.cMaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonViBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHangSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDVT = new ControlProject1510.XFilteg();
            this.txtGia = new ControlProject1510.XFilteg();
            this.txtHangSanXuat = new ControlProject1510.XFilteg();
            this.txtNuocSanXuat = new ControlProject1510.XFilteg();
            this.txtTenThuoc = new ControlProject1510.XFilteg();
            this.txtMaThuoc = new ControlProject1510.XFilteg();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInTatCa = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKeTonKhoHienTai)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnInTatCa);
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.txtSL);
            this.panel2.Controls.Add(this.txtDVT);
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.txtHangSanXuat);
            this.panel2.Controls.Add(this.txtNuocSanXuat);
            this.panel2.Controls.Add(this.txtTenThuoc);
            this.panel2.Controls.Add(this.txtMaThuoc);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 76);
            this.panel2.TabIndex = 10;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.btnIn.Location = new System.Drawing.Point(1259, 27);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(79, 32);
            this.btnIn.TabIndex = 103;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtSL
            // 
            this.txtSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.ForeColor = System.Drawing.Color.Black;
            this.txtSL.Location = new System.Drawing.Point(1022, 27);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(72, 32);
            this.txtSL.TabIndex = 97;
            this.txtSL.xCoTimMoRong = false;
            this.txtSL.xDataGrid = this.dgrThongKeTonKhoHienTai;
            this.txtSL.xField_Key = "SoLuongKho";
            this.txtSL.xKeep_Old_Value = false;
            this.txtSL.xTimChinhXac = false;
            this.txtSL.xTimMoRong = "";
            this.txtSL.xTimTrenField = "SoLuongKho";
            this.txtSL.Enter += new System.EventHandler(this.txtSL_Enter);
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            this.txtSL.Leave += new System.EventHandler(this.txtSL_Leave);
            // 
            // dgrThongKeTonKhoHienTai
            // 
            this.dgrThongKeTonKhoHienTai.AllowUserToAddRows = false;
            this.dgrThongKeTonKhoHienTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrThongKeTonKhoHienTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaThuoc,
            this.cTenThuoc,
            this.cDonViBan,
            this.cHangSanXuat,
            this.cGia,
            this.cDVT,
            this.cSL});
            this.dgrThongKeTonKhoHienTai.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrThongKeTonKhoHienTai.Location = new System.Drawing.Point(0, 0);
            this.dgrThongKeTonKhoHienTai.Name = "dgrThongKeTonKhoHienTai";
            this.dgrThongKeTonKhoHienTai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrThongKeTonKhoHienTai.Size = new System.Drawing.Size(1350, 558);
            this.dgrThongKeTonKhoHienTai.TabIndex = 0;
            this.dgrThongKeTonKhoHienTai.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrThongKeTonKhoHienTai_CellMouseClick);
            // 
            // cMaThuoc
            // 
            this.cMaThuoc.DataPropertyName = "MaThuoc";
            this.cMaThuoc.HeaderText = "Mã";
            this.cMaThuoc.Name = "cMaThuoc";
            this.cMaThuoc.Width = 150;
            // 
            // cTenThuoc
            // 
            this.cTenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenThuoc.DataPropertyName = "TenThuoc";
            this.cTenThuoc.HeaderText = "Tên thuốc";
            this.cTenThuoc.MinimumWidth = 200;
            this.cTenThuoc.Name = "cTenThuoc";
            // 
            // cDonViBan
            // 
            this.cDonViBan.DataPropertyName = "MANGUOIBAN";
            this.cDonViBan.HeaderText = "Đơn vị bán";
            this.cDonViBan.Name = "cDonViBan";
            this.cDonViBan.Width = 200;
            // 
            // cHangSanXuat
            // 
            this.cHangSanXuat.DataPropertyName = "TENNGUOIBAN";
            this.cHangSanXuat.FillWeight = 250F;
            this.cHangSanXuat.HeaderText = "Nhà cung cấp";
            this.cHangSanXuat.Name = "cHangSanXuat";
            this.cHangSanXuat.Width = 350;
            // 
            // cGia
            // 
            this.cGia.DataPropertyName = "DonGia";
            this.cGia.HeaderText = "Giá";
            this.cGia.Name = "cGia";
            this.cGia.Width = 150;
            // 
            // cDVT
            // 
            this.cDVT.DataPropertyName = "DonViSuDung";
            this.cDVT.HeaderText = "DVT";
            this.cDVT.Name = "cDVT";
            // 
            // cSL
            // 
            this.cSL.DataPropertyName = "SoLuongKho";
            this.cSL.HeaderText = "SL";
            this.cSL.Name = "cSL";
            this.cSL.Width = 70;
            // 
            // txtDVT
            // 
            this.txtDVT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDVT.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.ForeColor = System.Drawing.Color.Black;
            this.txtDVT.Location = new System.Drawing.Point(924, 27);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(85, 32);
            this.txtDVT.TabIndex = 96;
            this.txtDVT.xCoTimMoRong = false;
            this.txtDVT.xDataGrid = this.dgrThongKeTonKhoHienTai;
            this.txtDVT.xField_Key = "DonViSuDung";
            this.txtDVT.xKeep_Old_Value = false;
            this.txtDVT.xTimChinhXac = false;
            this.txtDVT.xTimMoRong = "";
            this.txtDVT.xTimTrenField = "DonViSuDung";
            this.txtDVT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtĐVT_KeyPress);
            // 
            // txtGia
            // 
            this.txtGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.Black;
            this.txtGia.Location = new System.Drawing.Point(812, 27);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(99, 32);
            this.txtGia.TabIndex = 95;
            this.txtGia.xCoTimMoRong = false;
            this.txtGia.xDataGrid = this.dgrThongKeTonKhoHienTai;
            this.txtGia.xField_Key = "DonGia";
            this.txtGia.xKeep_Old_Value = false;
            this.txtGia.xTimChinhXac = false;
            this.txtGia.xTimMoRong = "";
            this.txtGia.xTimTrenField = "DonGia";
            this.txtGia.Enter += new System.EventHandler(this.txtGia_Enter);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            this.txtGia.Leave += new System.EventHandler(this.txtGia_Leave);
            // 
            // txtHangSanXuat
            // 
            this.txtHangSanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHangSanXuat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHangSanXuat.ForeColor = System.Drawing.Color.Black;
            this.txtHangSanXuat.Location = new System.Drawing.Point(689, 27);
            this.txtHangSanXuat.Name = "txtHangSanXuat";
            this.txtHangSanXuat.Size = new System.Drawing.Size(110, 32);
            this.txtHangSanXuat.TabIndex = 94;
            this.txtHangSanXuat.xCoTimMoRong = false;
            this.txtHangSanXuat.xDataGrid = this.dgrThongKeTonKhoHienTai;
            this.txtHangSanXuat.xField_Key = "MANGUOIBAN";
            this.txtHangSanXuat.xKeep_Old_Value = false;
            this.txtHangSanXuat.xTimChinhXac = false;
            this.txtHangSanXuat.xTimMoRong = "";
            this.txtHangSanXuat.xTimTrenField = "MANGUOIBAN";
            this.txtHangSanXuat.Enter += new System.EventHandler(this.txtHangSanXuat_Enter);
            this.txtHangSanXuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHangSanXuat_KeyPress);
            this.txtHangSanXuat.Leave += new System.EventHandler(this.txtHangSanXuat_Leave);
            // 
            // txtNuocSanXuat
            // 
            this.txtNuocSanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNuocSanXuat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuocSanXuat.ForeColor = System.Drawing.Color.Black;
            this.txtNuocSanXuat.Location = new System.Drawing.Point(400, 27);
            this.txtNuocSanXuat.Name = "txtNuocSanXuat";
            this.txtNuocSanXuat.Size = new System.Drawing.Size(274, 32);
            this.txtNuocSanXuat.TabIndex = 93;
            this.txtNuocSanXuat.xCoTimMoRong = false;
            this.txtNuocSanXuat.xDataGrid = this.dgrThongKeTonKhoHienTai;
            this.txtNuocSanXuat.xField_Key = "TENNGUOIBAN";
            this.txtNuocSanXuat.xKeep_Old_Value = false;
            this.txtNuocSanXuat.xTimChinhXac = false;
            this.txtNuocSanXuat.xTimMoRong = "";
            this.txtNuocSanXuat.xTimTrenField = "TENNGUOIBAN";
            this.txtNuocSanXuat.Enter += new System.EventHandler(this.txtNuocSanXuat_Enter);
            this.txtNuocSanXuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuocSanXuat_KeyPress);
            this.txtNuocSanXuat.Leave += new System.EventHandler(this.txtNuocSanXuat_Leave);
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuoc.ForeColor = System.Drawing.Color.Black;
            this.txtTenThuoc.Location = new System.Drawing.Point(155, 27);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(232, 32);
            this.txtTenThuoc.TabIndex = 91;
            this.txtTenThuoc.xCoTimMoRong = false;
            this.txtTenThuoc.xDataGrid = this.dgrThongKeTonKhoHienTai;
            this.txtTenThuoc.xField_Key = "TenThuoc";
            this.txtTenThuoc.xKeep_Old_Value = false;
            this.txtTenThuoc.xTimChinhXac = false;
            this.txtTenThuoc.xTimMoRong = "";
            this.txtTenThuoc.xTimTrenField = "TenThuoc";
            this.txtTenThuoc.Enter += new System.EventHandler(this.txtTenThuocNongDoHamLuong_Enter);
            this.txtTenThuoc.Leave += new System.EventHandler(this.txtTenThuocNongDoHamLuong_Leave);
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuoc.ForeColor = System.Drawing.Color.Black;
            this.txtMaThuoc.Location = new System.Drawing.Point(12, 27);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(130, 32);
            this.txtMaThuoc.TabIndex = 90;
            this.txtMaThuoc.xCoTimMoRong = false;
            this.txtMaThuoc.xDataGrid = this.dgrThongKeTonKhoHienTai;
            this.txtMaThuoc.xField_Key = "MaThuoc";
            this.txtMaThuoc.xKeep_Old_Value = false;
            this.txtMaThuoc.xTimChinhXac = false;
            this.txtMaThuoc.xTimMoRong = "";
            this.txtMaThuoc.xTimTrenField = "MaThuoc";
            this.txtMaThuoc.Enter += new System.EventHandler(this.txtMa_Enter);
            this.txtMaThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMa_KeyPress);
            this.txtMaThuoc.Leave += new System.EventHandler(this.txtMa_Leave);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label12.Location = new System.Drawing.Point(935, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "DVT";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label8.Location = new System.Drawing.Point(1026, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "SL";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label7.Location = new System.Drawing.Point(837, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label6.Location = new System.Drawing.Point(692, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đơn vị bán";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(404, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(159, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrThongKeTonKhoHienTai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 558);
            this.panel3.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label9.Location = new System.Drawing.Point(422, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(546, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "THỐNG KÊ TỒN KHO HIỆN TẠI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 86);
            this.panel1.TabIndex = 9;
            // 
            // btnInTatCa
            // 
            this.btnInTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnInTatCa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInTatCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.btnInTatCa.Location = new System.Drawing.Point(1142, 27);
            this.btnInTatCa.Name = "btnInTatCa";
            this.btnInTatCa.Size = new System.Drawing.Size(101, 32);
            this.btnInTatCa.TabIndex = 104;
            this.btnInTatCa.Text = "In tất cả";
            this.btnInTatCa.UseVisualStyleBackColor = false;
            this.btnInTatCa.Click += new System.EventHandler(this.btnInTatCa_Click);
            // 
            // FrmThongKeTonKhoHienTai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThongKeTonKhoHienTai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKeTonKhoHienTai)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ControlProject1510.XFilteg txtNuocSanXuat;
        private ControlProject1510.XFilteg txtTenThuoc;
        private ControlProject1510.XFilteg txtMaThuoc;
        private ControlProject1510.XFilteg txtGia;
        private ControlProject1510.XFilteg txtHangSanXuat;
        private System.Windows.Forms.Panel panel3;
        private ControlProject1510.XFilteg txtSL;
        private ControlProject1510.XFilteg txtDVT;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dgrThongKeTonKhoHienTai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonViBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHangSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSL;
        private System.Windows.Forms.Button btnInTatCa;
    }
}