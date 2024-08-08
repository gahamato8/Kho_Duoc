
namespace KhoDuoc
{
    partial class FrmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhaCungCap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.txtTimTheoTen = new ControlProject1510.XFilteg();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrNhaCungCap = new System.Windows.Forms.DataGridView();
            this.cMaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.cXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 58);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(963, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 74;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLamMoi.Location = new System.Drawing.Point(839, 25);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(118, 35);
            this.btnLamMoi.TabIndex = 73;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "Tìm theo tên";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(1214, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 34);
            this.btnThem.TabIndex = 71;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label20.Location = new System.Drawing.Point(603, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(286, 40);
            this.label20.TabIndex = 70;
            this.label20.Text = "NHÀ CUNG CẤP";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXuatExcel.Location = new System.Drawing.Point(1055, 24);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(153, 35);
            this.btnXuatExcel.TabIndex = 69;
            this.btnXuatExcel.Text = "Xuất Excel All";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // txtTimTheoTen
            // 
            this.txtTimTheoTen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTheoTen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTimTheoTen.Location = new System.Drawing.Point(157, 24);
            this.txtTimTheoTen.Name = "txtTimTheoTen";
            this.txtTimTheoTen.Size = new System.Drawing.Size(354, 32);
            this.txtTimTheoTen.TabIndex = 27;
            this.txtTimTheoTen.xCoTimMoRong = false;
            this.txtTimTheoTen.xField_Key = "TENNGUOIBAN";
            this.txtTimTheoTen.xKeep_Old_Value = false;
            this.txtTimTheoTen.xTimChinhXac = false;
            this.txtTimTheoTen.xTimMoRong = "";
            this.txtTimTheoTen.xTimTrenField = "TENNGUOIBAN";
            this.txtTimTheoTen.Click += new System.EventHandler(this.txtTimTheoTen_Click);
            this.txtTimTheoTen.TextChanged += new System.EventHandler(this.txtTimTheoTen_TextChanged);
            this.txtTimTheoTen.Enter += new System.EventHandler(this.txtTimTheoTen_Enter);
            this.txtTimTheoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimTheoTen_KeyPress);
            this.txtTimTheoTen.Leave += new System.EventHandler(this.txtTimTheoTen_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Controls.Add(this.txtTimTheoTen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnXuatExcel);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 77);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrNhaCungCap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 594);
            this.panel3.TabIndex = 3;
            // 
            // dgrNhaCungCap
            // 
            this.dgrNhaCungCap.AllowUserToAddRows = false;
            this.dgrNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaNhaCungCap,
            this.cTenNhaSanXuat,
            this.cSDT,
            this.cDiaChi,
            this.cSua,
            this.cXoa});
            this.dgrNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrNhaCungCap.Location = new System.Drawing.Point(0, 0);
            this.dgrNhaCungCap.Name = "dgrNhaCungCap";
            this.dgrNhaCungCap.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrNhaCungCap.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrNhaCungCap.Size = new System.Drawing.Size(1350, 594);
            this.dgrNhaCungCap.TabIndex = 3;
            this.dgrNhaCungCap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrNhaCungCap_CellMouseClick_1);
            // 
            // cMaNhaCungCap
            // 
            this.cMaNhaCungCap.DataPropertyName = "MANGUOIBAN";
            this.cMaNhaCungCap.HeaderText = "Mã";
            this.cMaNhaCungCap.Name = "cMaNhaCungCap";
            this.cMaNhaCungCap.ReadOnly = true;
            // 
            // cTenNhaSanXuat
            // 
            this.cTenNhaSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenNhaSanXuat.DataPropertyName = "TENNGUOIBAN";
            this.cTenNhaSanXuat.HeaderText = "Tên nhà cung cấp";
            this.cTenNhaSanXuat.Name = "cTenNhaSanXuat";
            this.cTenNhaSanXuat.ReadOnly = true;
            // 
            // cSDT
            // 
            this.cSDT.DataPropertyName = "SODT";
            this.cSDT.HeaderText = "ĐT";
            this.cSDT.Name = "cSDT";
            this.cSDT.ReadOnly = true;
            this.cSDT.Width = 150;
            // 
            // cDiaChi
            // 
            this.cDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDiaChi.DataPropertyName = "DiaChi";
            this.cDiaChi.HeaderText = "Địa chỉ";
            this.cDiaChi.Name = "cDiaChi";
            this.cDiaChi.ReadOnly = true;
            // 
            // cSua
            // 
            this.cSua.HeaderText = "Sửa";
            this.cSua.Image = ((System.Drawing.Image)(resources.GetObject("cSua.Image")));
            this.cSua.Name = "cSua";
            this.cSua.ReadOnly = true;
            // 
            // cXoa
            // 
            this.cXoa.HeaderText = "Xóa";
            this.cXoa.Image = ((System.Drawing.Image)(resources.GetObject("cXoa.Image")));
            this.cXoa.Name = "cXoa";
            this.cXoa.ReadOnly = true;
            // 
            // FrmNhaCungCap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmHangSanXuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ControlProject1510.XFilteg txtTimTheoTen;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgrNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiaChi;
        private System.Windows.Forms.DataGridViewImageColumn cSua;
        private System.Windows.Forms.DataGridViewImageColumn cXoa;
    }
}