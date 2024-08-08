
namespace KhoDuoc
{
    partial class FrmDanhMucKhoDuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucKhoDuoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboKho = new ControlProject1510.ComboBoxSearch();
            this.txtTenKho = new ControlProject1510.XFilteg();
            this.dgrDanhMucKhoDuoc = new System.Windows.Forms.DataGridView();
            this.cTenKhoDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoaiKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoaiHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhMucKhoDuoc)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 56);
            this.panel1.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label20.Location = new System.Drawing.Point(29, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(416, 40);
            this.label20.TabIndex = 66;
            this.label20.Text = "DANH MỤC KHO DƯỢC";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnThem.Location = new System.Drawing.Point(787, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 45);
            this.btnThem.TabIndex = 67;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.cboKho);
            this.panel2.Controls.Add(this.txtTenKho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 123);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(396, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(48, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tên Kho";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnTim.Location = new System.Drawing.Point(943, 40);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(109, 45);
            this.btnTim.TabIndex = 69;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cboKho
            // 
            this.cboKho.AllowDrop = true;
            this.cboKho.AutoComplete = true;
            this.cboKho.AutoDropdown = true;
            this.cboKho.BackColorEven = System.Drawing.Color.White;
            this.cboKho.BackColorOdd = System.Drawing.Color.White;
            this.cboKho.ColumnNames = "";
            this.cboKho.ColumnWidthDefault = 75;
            this.cboKho.ColumnWidths = "";
            this.cboKho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboKho.ForeColor = System.Drawing.Color.Black;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.LinkedColumnIndex = 0;
            this.cboKho.LinkedTextBox = null;
            this.cboKho.Location = new System.Drawing.Point(396, 48);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(291, 33);
            this.cboKho.TabIndex = 67;
            // 
            // txtTenKho
            // 
            this.txtTenKho.ForeColor = System.Drawing.Color.Black;
            this.txtTenKho.Location = new System.Drawing.Point(48, 48);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(280, 32);
            this.txtTenKho.TabIndex = 66;
            this.txtTenKho.xCoTimMoRong = false;
            this.txtTenKho.xDataGrid = this.dgrDanhMucKhoDuoc;
            this.txtTenKho.xField_Key = "TenKhoDuoc";
            this.txtTenKho.xKeep_Old_Value = false;
            this.txtTenKho.xTimChinhXac = false;
            this.txtTenKho.xTimMoRong = "";
            this.txtTenKho.xTimTrenField = "TenKhoDuoc";
            this.txtTenKho.Enter += new System.EventHandler(this.txtTenKho_Enter);
            this.txtTenKho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKho_KeyPress);
            this.txtTenKho.Leave += new System.EventHandler(this.txtTenKho_Leave);
            // 
            // dgrDanhMucKhoDuoc
            // 
            this.dgrDanhMucKhoDuoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrDanhMucKhoDuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrDanhMucKhoDuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhMucKhoDuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenKhoDuoc,
            this.cLoaiKho,
            this.cKhoa,
            this.cLoaiHangHoa,
            this.cTrangThai,
            this.cSua});
            this.dgrDanhMucKhoDuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrDanhMucKhoDuoc.Location = new System.Drawing.Point(0, 0);
            this.dgrDanhMucKhoDuoc.Name = "dgrDanhMucKhoDuoc";
            this.dgrDanhMucKhoDuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrDanhMucKhoDuoc.Size = new System.Drawing.Size(1350, 550);
            this.dgrDanhMucKhoDuoc.TabIndex = 0;
            this.dgrDanhMucKhoDuoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrDanhMucKhoDuoc_CellMouseClick);
            this.dgrDanhMucKhoDuoc.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgrDanhMucKhoDuoc_RowPostPaint);
            // 
            // cTenKhoDuoc
            // 
            this.cTenKhoDuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenKhoDuoc.DataPropertyName = "TenKhoDuoc";
            this.cTenKhoDuoc.HeaderText = "Tên kho dược";
            this.cTenKhoDuoc.Name = "cTenKhoDuoc";
            // 
            // cLoaiKho
            // 
            this.cLoaiKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cLoaiKho.DataPropertyName = "LoaiKhoDuoc";
            this.cLoaiKho.HeaderText = "Loại kho";
            this.cLoaiKho.MinimumWidth = 100;
            this.cLoaiKho.Name = "cLoaiKho";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrDanhMucKhoDuoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 550);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Sửa";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // FrmDanhMucKhoDuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDanhMucKhoDuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private ControlProject1510.ComboBoxSearch cboKho;
        private ControlProject1510.XFilteg txtTenKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrDanhMucKhoDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenKhoDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoaiKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoaiHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrangThai;
        private System.Windows.Forms.DataGridViewImageColumn cSua;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}