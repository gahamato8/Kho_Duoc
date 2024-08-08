
namespace KhoDuoc
{
    partial class FrmXuatKhoKhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXuatKhoKhac));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgrXuatKho = new System.Windows.Forms.DataGridView();
            this.cMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSLTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSLPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCap = new System.Windows.Forms.DataGridViewImageColumn();
            this.cXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnChonFileUpdate = new System.Windows.Forms.Button();
            this.txtNoiNhan = new ControlProject1510.XFilteg();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNoiXuat = new ControlProject1510.ComboBoxSearch();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoai = new ControlProject1510.ComboBoxSearch();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLyDoXuat = new ControlProject1510.XFilteg();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrXuatKho)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-7, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1364, 733);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1356, 701);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xuất kho";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 701);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 83);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgrXuatKho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 598);
            this.panel1.TabIndex = 3;
            // 
            // dgrXuatKho
            // 
            this.dgrXuatKho.AllowUserToAddRows = false;
            this.dgrXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrXuatKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMa,
            this.cTenThuoc,
            this.cSLTon,
            this.cSLPhat,
            this.cDonVi,
            this.cCap,
            this.cXoa});
            this.dgrXuatKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrXuatKho.Location = new System.Drawing.Point(0, 0);
            this.dgrXuatKho.Name = "dgrXuatKho";
            this.dgrXuatKho.Size = new System.Drawing.Size(1350, 602);
            this.dgrXuatKho.TabIndex = 2;
            // 
            // cMa
            // 
            this.cMa.HeaderText = "Mã";
            this.cMa.Name = "cMa";
            // 
            // cTenThuoc
            // 
            this.cTenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenThuoc.HeaderText = "Tên Thuốc";
            this.cTenThuoc.MinimumWidth = 100;
            this.cTenThuoc.Name = "cTenThuoc";
            // 
            // cSLTon
            // 
            this.cSLTon.HeaderText = "SL Tồn";
            this.cSLTon.Name = "cSLTon";
            // 
            // cSLPhat
            // 
            this.cSLPhat.HeaderText = "SL Phát";
            this.cSLPhat.Name = "cSLPhat";
            // 
            // cDonVi
            // 
            this.cDonVi.HeaderText = "Đơn Vị";
            this.cDonVi.Name = "cDonVi";
            // 
            // cCap
            // 
            this.cCap.HeaderText = "Cấp";
            this.cCap.Image = ((System.Drawing.Image)(resources.GetObject("cCap.Image")));
            this.cCap.Name = "cCap";
            // 
            // cXoa
            // 
            this.cXoa.HeaderText = "Xóa";
            this.cXoa.Image = ((System.Drawing.Image)(resources.GetObject("cXoa.Image")));
            this.cXoa.Name = "cXoa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnChonFileUpdate);
            this.panel2.Controls.Add(this.txtNoiNhan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboNoiXuat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboLoai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtLyDoXuat);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtNgayXuat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 100);
            this.panel2.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(1053, 61);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(275, 27);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnChonFileUpdate
            // 
            this.btnChonFileUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChonFileUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonFileUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChonFileUpdate.Location = new System.Drawing.Point(1055, 13);
            this.btnChonFileUpdate.Name = "btnChonFileUpdate";
            this.btnChonFileUpdate.Size = new System.Drawing.Size(275, 27);
            this.btnChonFileUpdate.TabIndex = 53;
            this.btnChonFileUpdate.Text = "Chọn file update";
            this.btnChonFileUpdate.UseVisualStyleBackColor = false;
            // 
            // txtNoiNhan
            // 
            this.txtNoiNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNoiNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiNhan.ForeColor = System.Drawing.Color.Black;
            this.txtNoiNhan.Location = new System.Drawing.Point(759, 61);
            this.txtNoiNhan.Name = "txtNoiNhan";
            this.txtNoiNhan.Size = new System.Drawing.Size(289, 26);
            this.txtNoiNhan.TabIndex = 52;
            this.txtNoiNhan.xCoTimMoRong = false;
            this.txtNoiNhan.xDataGrid = null;
            this.txtNoiNhan.xField_Key = "";
            this.txtNoiNhan.xKeep_Old_Value = false;
            this.txtNoiNhan.xTimChinhXac = false;
            this.txtNoiNhan.xTimMoRong = "";
            this.txtNoiNhan.xTimTrenField = null;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nơi nhận";
            // 
            // cboNoiXuat
            // 
            this.cboNoiXuat.AllowDrop = true;
            this.cboNoiXuat.AutoComplete = true;
            this.cboNoiXuat.AutoDropdown = true;
            this.cboNoiXuat.BackColorEven = System.Drawing.Color.White;
            this.cboNoiXuat.BackColorOdd = System.Drawing.Color.White;
            this.cboNoiXuat.ColumnNames = "";
            this.cboNoiXuat.ColumnWidthDefault = 75;
            this.cboNoiXuat.ColumnWidths = "";
            this.cboNoiXuat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboNoiXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNoiXuat.ForeColor = System.Drawing.Color.Black;
            this.cboNoiXuat.FormattingEnabled = true;
            this.cboNoiXuat.LinkedColumnIndex = 0;
            this.cboNoiXuat.LinkedTextBox = null;
            this.cboNoiXuat.Location = new System.Drawing.Point(760, 14);
            this.cboNoiXuat.Name = "cboNoiXuat";
            this.cboNoiXuat.Size = new System.Drawing.Size(289, 27);
            this.cboNoiXuat.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nơi xuất";
            // 
            // cboLoai
            // 
            this.cboLoai.AllowDrop = true;
            this.cboLoai.AutoComplete = true;
            this.cboLoai.AutoDropdown = true;
            this.cboLoai.BackColorEven = System.Drawing.Color.White;
            this.cboLoai.BackColorOdd = System.Drawing.Color.White;
            this.cboLoai.ColumnNames = "";
            this.cboLoai.ColumnWidthDefault = 75;
            this.cboLoai.ColumnWidths = "";
            this.cboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoai.ForeColor = System.Drawing.Color.Black;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.LinkedColumnIndex = 0;
            this.cboLoai.LinkedTextBox = null;
            this.cboLoai.Location = new System.Drawing.Point(412, 14);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(272, 27);
            this.cboLoai.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Loại";
            // 
            // txtLyDoXuat
            // 
            this.txtLyDoXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLyDoXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDoXuat.ForeColor = System.Drawing.Color.Black;
            this.txtLyDoXuat.Location = new System.Drawing.Point(110, 61);
            this.txtLyDoXuat.Name = "txtLyDoXuat";
            this.txtLyDoXuat.Size = new System.Drawing.Size(573, 26);
            this.txtLyDoXuat.TabIndex = 23;
            this.txtLyDoXuat.xCoTimMoRong = false;
            this.txtLyDoXuat.xDataGrid = null;
            this.txtLyDoXuat.xField_Key = "";
            this.txtLyDoXuat.xKeep_Old_Value = false;
            this.txtLyDoXuat.xTimChinhXac = false;
            this.txtLyDoXuat.xTimMoRong = "";
            this.txtLyDoXuat.xTimTrenField = null;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Lý do xuất";
            // 
            // dtNgayXuat
            // 
            this.dtNgayXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgayXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayXuat.Location = new System.Drawing.Point(110, 14);
            this.dtNgayXuat.Name = "dtNgayXuat";
            this.dtNgayXuat.Size = new System.Drawing.Size(253, 26);
            this.dtNgayXuat.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày xuất";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1356, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách phiếu xuất kho";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmXuatKhoKhac
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmXuatKhoKhac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Kho Khác";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrXuatKho)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrXuatKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSLTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSLPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonVi;
        private System.Windows.Forms.DataGridViewImageColumn cCap;
        private System.Windows.Forms.DataGridViewImageColumn cXoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnChonFileUpdate;
        private ControlProject1510.XFilteg txtNoiNhan;
        private System.Windows.Forms.Label label3;
        private ControlProject1510.ComboBoxSearch cboNoiXuat;
        private System.Windows.Forms.Label label2;
        private ControlProject1510.ComboBoxSearch cboLoai;
        private System.Windows.Forms.Label label1;
        private ControlProject1510.XFilteg txtLyDoXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
    }
}