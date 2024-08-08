
namespace KhoDuoc
{
    partial class FrmKhoDuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoDuoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.dgrKhoDuoc = new System.Windows.Forms.DataGridView();
            this.cMaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKhoDuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 100);
            this.panel1.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.label20.Location = new System.Drawing.Point(0, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1347, 40);
            this.label20.TabIndex = 1;
            this.label20.Text = "HẠN DÙNG THUỐC";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgrKhoDuoc
            // 
            this.dgrKhoDuoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrKhoDuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrKhoDuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrKhoDuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaThuoc,
            this.cTenThuoc,
            this.cLo,
            this.cSoLuong,
            this.cGia,
            this.cHanDung,
            this.cNgayHetHan,
            this.cXoa});
            this.dgrKhoDuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrKhoDuoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.dgrKhoDuoc.Location = new System.Drawing.Point(0, 100);
            this.dgrKhoDuoc.Name = "dgrKhoDuoc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrKhoDuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrKhoDuoc.Size = new System.Drawing.Size(1350, 629);
            this.dgrKhoDuoc.TabIndex = 3;
            this.dgrKhoDuoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrKhoDuoc_CellMouseClick);
            // 
            // cMaThuoc
            // 
            this.cMaThuoc.DataPropertyName = "MaThuoc";
            this.cMaThuoc.HeaderText = "Mã";
            this.cMaThuoc.MinimumWidth = 50;
            this.cMaThuoc.Name = "cMaThuoc";
            // 
            // cTenThuoc
            // 
            this.cTenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cTenThuoc.DataPropertyName = "TenThuoc";
            this.cTenThuoc.HeaderText = "Tên thuốc";
            this.cTenThuoc.MinimumWidth = 300;
            this.cTenThuoc.Name = "cTenThuoc";
            this.cTenThuoc.Width = 300;
            // 
            // cLo
            // 
            this.cLo.DataPropertyName = "SoLo";
            this.cLo.HeaderText = "Lô";
            this.cLo.MinimumWidth = 100;
            this.cLo.Name = "cLo";
            // 
            // cSoLuong
            // 
            this.cSoLuong.DataPropertyName = "SoLuongKho";
            this.cSoLuong.HeaderText = "Số lượng";
            this.cSoLuong.MinimumWidth = 100;
            this.cSoLuong.Name = "cSoLuong";
            this.cSoLuong.Width = 150;
            // 
            // cGia
            // 
            this.cGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Format = "N0";
            this.cGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.cGia.HeaderText = "Giá";
            this.cGia.MinimumWidth = 200;
            this.cGia.Name = "cGia";
            this.cGia.Width = 200;
            // 
            // cHanDung
            // 
            this.cHanDung.DataPropertyName = "HSD";
            this.cHanDung.HeaderText = "Hạn dùng";
            this.cHanDung.MinimumWidth = 200;
            this.cHanDung.Name = "cHanDung";
            this.cHanDung.Width = 200;
            // 
            // cNgayHetHan
            // 
            this.cNgayHetHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNgayHetHan.DataPropertyName = "NGAYCONLAI";
            this.cNgayHetHan.HeaderText = "Ngày còn lại";
            this.cNgayHetHan.Name = "cNgayHetHan";
            // 
            // cXoa
            // 
            this.cXoa.HeaderText = "Xóa";
            this.cXoa.Image = ((System.Drawing.Image)(resources.GetObject("cXoa.Image")));
            this.cXoa.Name = "cXoa";
            // 
            // FrmKhoDuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dgrKhoDuoc);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKhoDuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrKhoDuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrKhoDuoc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHanDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayHetHan;
        private System.Windows.Forms.DataGridViewImageColumn cXoa;
    }
}