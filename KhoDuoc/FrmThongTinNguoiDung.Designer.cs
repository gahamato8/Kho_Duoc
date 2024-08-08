
namespace KhoDuoc
{
    partial class FrmThongTinNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongTinNguoiDung));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTenQuyen = new ControlProject1510.ComboBoxSearch();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMatKhau = new ControlProject1510.XFilteg();
            this.dgrdanhsachnguoidung = new System.Windows.Forms.DataGridView();
            this.txtTenNguoiDung = new ControlProject1510.XFilteg();
            this.txtHoTen = new ControlProject1510.XFilteg();
            this.txtMaNV = new ControlProject1510.XFilteg();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdanhsachnguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboTenQuyen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtTenNguoiDung);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 658);
            this.panel1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(306, 559);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(105, 36);
            this.btnLamMoi.TabIndex = 57;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 56;
            this.label5.Text = "Phân quyền";
            // 
            // cboTenQuyen
            // 
            this.cboTenQuyen.AllowDrop = true;
            this.cboTenQuyen.AutoComplete = true;
            this.cboTenQuyen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTenQuyen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTenQuyen.AutoDropdown = true;
            this.cboTenQuyen.BackColorEven = System.Drawing.Color.White;
            this.cboTenQuyen.BackColorOdd = System.Drawing.Color.White;
            this.cboTenQuyen.ColumnNames = "Quyen";
            this.cboTenQuyen.ColumnWidthDefault = 340;
            this.cboTenQuyen.ColumnWidths = "";
            this.cboTenQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTenQuyen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenQuyen.FormattingEnabled = true;
            this.cboTenQuyen.LinkedColumnIndex = 0;
            this.cboTenQuyen.LinkedTextBox = null;
            this.cboTenQuyen.Location = new System.Drawing.Point(150, 445);
            this.cboTenQuyen.Name = "cboTenQuyen";
            this.cboTenQuyen.Size = new System.Drawing.Size(329, 33);
            this.cboTenQuyen.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tên người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Mã NV";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label26.Location = new System.Drawing.Point(17, 176);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(457, 40);
            this.label26.TabIndex = 2;
            this.label26.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(195, 559);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 36);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(84, 559);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 36);
            this.btnXoa.TabIndex = 49;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(85, 517);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(326, 36);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm người dùng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(150, 391);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(329, 32);
            this.txtMatKhau.TabIndex = 47;
            this.txtMatKhau.xCoTimMoRong = false;
            this.txtMatKhau.xDataGrid = this.dgrdanhsachnguoidung;
            this.txtMatKhau.xField_Key = "MatKhau";
            this.txtMatKhau.xKeep_Old_Value = false;
            this.txtMatKhau.xTimChinhXac = false;
            this.txtMatKhau.xTimMoRong = "";
            this.txtMatKhau.xTimTrenField = "MatKhau";
            // 
            // dgrdanhsachnguoidung
            // 
            this.dgrdanhsachnguoidung.AllowUserToAddRows = false;
            this.dgrdanhsachnguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdanhsachnguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaNV,
            this.cTenNV,
            this.cTuoi,
            this.cGioiTinh,
            this.cSDT,
            this.cTenDangNhap,
            this.cMK,
            this.cQuyen});
            this.dgrdanhsachnguoidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdanhsachnguoidung.Location = new System.Drawing.Point(0, 0);
            this.dgrdanhsachnguoidung.Name = "dgrdanhsachnguoidung";
            this.dgrdanhsachnguoidung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdanhsachnguoidung.Size = new System.Drawing.Size(1192, 658);
            this.dgrdanhsachnguoidung.TabIndex = 3;
            this.dgrdanhsachnguoidung.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdanhsachnguoidung_CellMouseClick);
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNguoiDung.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiDung.ForeColor = System.Drawing.Color.Black;
            this.txtTenNguoiDung.Location = new System.Drawing.Point(150, 336);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(329, 32);
            this.txtTenNguoiDung.TabIndex = 46;
            this.txtTenNguoiDung.xCoTimMoRong = false;
            this.txtTenNguoiDung.xDataGrid = this.dgrdanhsachnguoidung;
            this.txtTenNguoiDung.xField_Key = "TenDangNhap";
            this.txtTenNguoiDung.xKeep_Old_Value = false;
            this.txtTenNguoiDung.xTimChinhXac = false;
            this.txtTenNguoiDung.xTimMoRong = "";
            this.txtTenNguoiDung.xTimTrenField = "TenDangNhap";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(150, 281);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(329, 32);
            this.txtHoTen.TabIndex = 45;
            this.txtHoTen.xCoTimMoRong = false;
            this.txtHoTen.xDataGrid = this.dgrdanhsachnguoidung;
            this.txtHoTen.xField_Key = "HoTen";
            this.txtHoTen.xKeep_Old_Value = false;
            this.txtHoTen.xTimChinhXac = false;
            this.txtHoTen.xTimMoRong = "";
            this.txtHoTen.xTimTrenField = "HoTen";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.Location = new System.Drawing.Point(150, 226);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(329, 32);
            this.txtMaNV.TabIndex = 44;
            this.txtMaNV.xCoTimMoRong = false;
            this.txtMaNV.xDataGrid = this.dgrdanhsachnguoidung;
            this.txtMaNV.xField_Key = "MaNV";
            this.txtMaNV.xKeep_Old_Value = false;
            this.txtMaNV.xTimChinhXac = false;
            this.txtMaNV.xTimMoRong = "";
            this.txtMaNV.xTimTrenField = "MaNV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(146, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgrdanhsachnguoidung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(489, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 658);
            this.panel2.TabIndex = 1;
            // 
            // cMaNV
            // 
            this.cMaNV.DataPropertyName = "MaNV";
            this.cMaNV.HeaderText = "Mã NV";
            this.cMaNV.Name = "cMaNV";
            this.cMaNV.Width = 150;
            // 
            // cTenNV
            // 
            this.cTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenNV.DataPropertyName = "HoTen";
            this.cTenNV.HeaderText = "Họ tên";
            this.cTenNV.Name = "cTenNV";
            // 
            // cTuoi
            // 
            this.cTuoi.DataPropertyName = "Tuoi";
            this.cTuoi.HeaderText = "Tuổi";
            this.cTuoi.Name = "cTuoi";
            // 
            // cGioiTinh
            // 
            this.cGioiTinh.DataPropertyName = "GioiTinh";
            this.cGioiTinh.HeaderText = "Giới tính";
            this.cGioiTinh.Name = "cGioiTinh";
            // 
            // cSDT
            // 
            this.cSDT.DataPropertyName = "SDT";
            this.cSDT.HeaderText = "Số điện thoại";
            this.cSDT.Name = "cSDT";
            this.cSDT.Width = 160;
            // 
            // cTenDangNhap
            // 
            this.cTenDangNhap.DataPropertyName = "TenDangNhap";
            this.cTenDangNhap.HeaderText = "Tên người dùng";
            this.cTenDangNhap.Name = "cTenDangNhap";
            this.cTenDangNhap.Width = 150;
            // 
            // cMK
            // 
            this.cMK.DataPropertyName = "MatKhau";
            this.cMK.HeaderText = "Mật khẩu";
            this.cMK.Name = "cMK";
            // 
            // cQuyen
            // 
            this.cQuyen.DataPropertyName = "TenQuyen";
            this.cQuyen.HeaderText = "Quyền";
            this.cQuyen.Name = "cQuyen";
            this.cQuyen.Width = 120;
            // 
            // FrmThongTinNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThongTinNguoiDung";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdanhsachnguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgrdanhsachnguoidung;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private ControlProject1510.XFilteg txtMatKhau;
        private ControlProject1510.XFilteg txtTenNguoiDung;
        private ControlProject1510.XFilteg txtHoTen;
        private ControlProject1510.XFilteg txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private ControlProject1510.ComboBoxSearch cboTenQuyen;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuyen;
    }
}