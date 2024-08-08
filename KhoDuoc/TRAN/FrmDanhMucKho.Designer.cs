
namespace KhoDuoc
{
    partial class FrmDanhMucKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucKho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLoaiHangHoa = new ControlProject1510.XFilteg();
            this.dgrDanhMucKhoDuoc = new System.Windows.Forms.DataGridView();
            this.cTenKhoDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoaiKhoDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoaiHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboTrangThai = new ControlProject1510.ComboBoxSearch();
            this.cboLoaiKhoDuoc = new ControlProject1510.ComboBoxSearch();
            this.txtTenKhoDuoc = new ControlProject1510.XFilteg();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhMucKhoDuoc)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(1196, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 29);
            this.btnThem.TabIndex = 67;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(217, 26);
            this.label20.TabIndex = 66;
            this.label20.Text = "Danh mục kho dược";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtLoaiHangHoa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.cboTrangThai);
            this.panel2.Controls.Add(this.cboLoaiKhoDuoc);
            this.panel2.Controls.Add(this.txtTenKhoDuoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 112);
            this.panel2.TabIndex = 1;
            // 
            // txtLoaiHangHoa
            // 
            this.txtLoaiHangHoa.ForeColor = System.Drawing.Color.Black;
            this.txtLoaiHangHoa.Location = new System.Drawing.Point(338, 47);
            this.txtLoaiHangHoa.Name = "txtLoaiHangHoa";
            this.txtLoaiHangHoa.Size = new System.Drawing.Size(266, 26);
            this.txtLoaiHangHoa.TabIndex = 75;
            this.txtLoaiHangHoa.xCoTimMoRong = false;
            this.txtLoaiHangHoa.xDataGrid = this.dgrDanhMucKhoDuoc;
            this.txtLoaiHangHoa.xField_Key = "LoaiHangHoa";
            this.txtLoaiHangHoa.xKeep_Old_Value = false;
            this.txtLoaiHangHoa.xTimChinhXac = false;
            this.txtLoaiHangHoa.xTimMoRong = "";
            this.txtLoaiHangHoa.xTimTrenField = "LoaiHangHoa";
            // 
            // dgrDanhMucKhoDuoc
            // 
            this.dgrDanhMucKhoDuoc.AllowUserToAddRows = false;
            this.dgrDanhMucKhoDuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhMucKhoDuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenKhoDuoc,
            this.cLoaiKhoDuoc,
            this.cKhoa,
            this.cLoaiHangHoa,
            this.cTrangThai,
            this.cSua});
            this.dgrDanhMucKhoDuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrDanhMucKhoDuoc.Location = new System.Drawing.Point(0, 0);
            this.dgrDanhMucKhoDuoc.Name = "dgrDanhMucKhoDuoc";
            this.dgrDanhMucKhoDuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrDanhMucKhoDuoc.Size = new System.Drawing.Size(1350, 570);
            this.dgrDanhMucKhoDuoc.TabIndex = 0;
            this.dgrDanhMucKhoDuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhMucKhoDuoc_CellContentClick);
            this.dgrDanhMucKhoDuoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrDanhMucKhoDuoc_CellMouseClick);
            // 
            // cTenKhoDuoc
            // 
            this.cTenKhoDuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenKhoDuoc.DataPropertyName = "TenKhoDuoc";
            this.cTenKhoDuoc.HeaderText = "Tên kho dược";
            this.cTenKhoDuoc.Name = "cTenKhoDuoc";
            // 
            // cLoaiKhoDuoc
            // 
            this.cLoaiKhoDuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cLoaiKhoDuoc.DataPropertyName = "LoaiKhoDuoc";
            this.cLoaiKhoDuoc.HeaderText = "Loại kho";
            this.cLoaiKhoDuoc.MinimumWidth = 100;
            this.cLoaiKhoDuoc.Name = "cLoaiKhoDuoc";
            // 
            // cKhoa
            // 
            this.cKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cKhoa.DataPropertyName = "Khoa";
            this.cKhoa.HeaderText = "Khoa";
            this.cKhoa.MinimumWidth = 100;
            this.cKhoa.Name = "cKhoa";
            // 
            // cLoaiHangHoa
            // 
            this.cLoaiHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cLoaiHangHoa.DataPropertyName = "LoaiHangHoa";
            this.cLoaiHangHoa.HeaderText = "Loại hàng hóa";
            this.cLoaiHangHoa.Name = "cLoaiHangHoa";
            // 
            // cTrangThai
            // 
            this.cTrangThai.DataPropertyName = "TrangThai";
            this.cTrangThai.HeaderText = "Trạng thái";
            this.cTrangThai.MinimumWidth = 100;
            this.cTrangThai.Name = "cTrangThai";
            // 
            // cSua
            // 
            this.cSua.HeaderText = "Sửa";
            this.cSua.Image = ((System.Drawing.Image)(resources.GetObject("cSua.Image")));
            this.cSua.Name = "cSua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(363, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "Loại Hàng Hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(836, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 72;
            this.label3.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(621, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 71;
            this.label1.Text = "Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(65, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tên Kho";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTim.Location = new System.Drawing.Point(1196, 48);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(109, 29);
            this.btnTim.TabIndex = 69;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.AllowDrop = true;
            this.cboTrangThai.AutoComplete = true;
            this.cboTrangThai.AutoDropdown = true;
            this.cboTrangThai.BackColorEven = System.Drawing.Color.White;
            this.cboTrangThai.BackColorOdd = System.Drawing.Color.White;
            this.cboTrangThai.ColumnNames = "TrangThai";
            this.cboTrangThai.ColumnWidthDefault = 75;
            this.cboTrangThai.ColumnWidths = "";
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.LinkedColumnIndex = 0;
            this.cboTrangThai.LinkedTextBox = null;
            this.cboTrangThai.Location = new System.Drawing.Point(820, 47);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(266, 27);
            this.cboTrangThai.TabIndex = 68;
            // 
            // cboLoaiKhoDuoc
            // 
            this.cboLoaiKhoDuoc.AllowDrop = true;
            this.cboLoaiKhoDuoc.AutoComplete = true;
            this.cboLoaiKhoDuoc.AutoDropdown = true;
            this.cboLoaiKhoDuoc.BackColorEven = System.Drawing.Color.White;
            this.cboLoaiKhoDuoc.BackColorOdd = System.Drawing.Color.White;
            this.cboLoaiKhoDuoc.ColumnNames = "LoaiKhoDuoc";
            this.cboLoaiKhoDuoc.ColumnWidthDefault = 75;
            this.cboLoaiKhoDuoc.ColumnWidths = "";
            this.cboLoaiKhoDuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboLoaiKhoDuoc.ForeColor = System.Drawing.Color.Black;
            this.cboLoaiKhoDuoc.FormattingEnabled = true;
            this.cboLoaiKhoDuoc.LinkedColumnIndex = 0;
            this.cboLoaiKhoDuoc.LinkedTextBox = null;
            this.cboLoaiKhoDuoc.Location = new System.Drawing.Point(610, 47);
            this.cboLoaiKhoDuoc.Name = "cboLoaiKhoDuoc";
            this.cboLoaiKhoDuoc.Size = new System.Drawing.Size(194, 27);
            this.cboLoaiKhoDuoc.TabIndex = 67;
            // 
            // txtTenKhoDuoc
            // 
            this.txtTenKhoDuoc.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhoDuoc.Location = new System.Drawing.Point(52, 48);
            this.txtTenKhoDuoc.Name = "txtTenKhoDuoc";
            this.txtTenKhoDuoc.Size = new System.Drawing.Size(280, 26);
            this.txtTenKhoDuoc.TabIndex = 66;
            this.txtTenKhoDuoc.xCoTimMoRong = false;
            this.txtTenKhoDuoc.xDataGrid = this.dgrDanhMucKhoDuoc;
            this.txtTenKhoDuoc.xField_Key = "TenKhoDuoc";
            this.txtTenKhoDuoc.xKeep_Old_Value = false;
            this.txtTenKhoDuoc.xTimChinhXac = false;
            this.txtTenKhoDuoc.xTimMoRong = "";
            this.txtTenKhoDuoc.xTimTrenField = "TenKhoDuoc";
            this.txtTenKhoDuoc.Enter += new System.EventHandler(this.txtTenKhoDuoc_Enter);
            this.txtTenKhoDuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKhoDuoc_KeyPress);
            this.txtTenKhoDuoc.Leave += new System.EventHandler(this.txtTenKhoDuoc_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrDanhMucKhoDuoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 570);
            this.panel3.TabIndex = 2;
            // 
            // FrmDanhMucKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmDanhMucKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhMucKho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhMucKhoDuoc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnTim;
        private ControlProject1510.ComboBoxSearch cboTrangThai;
        private ControlProject1510.ComboBoxSearch cboLoaiKhoDuoc;
        private ControlProject1510.XFilteg txtTenKhoDuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrDanhMucKhoDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenKhoDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoaiKhoDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoaiHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrangThai;
        private System.Windows.Forms.DataGridViewImageColumn cSua;
        private System.Windows.Forms.Label label4;
        private ControlProject1510.XFilteg txtLoaiHangHoa;
    }
}