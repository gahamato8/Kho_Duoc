using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCommon;

namespace KhoDuoc
{
    public partial class FrmDanhMucThuoc : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        bool on = true;
        bool toggleLight = true;
        public FrmDanhMucThuoc()
        {
            InitializeComponent();
            LoadData();
            Hide();

        }
        private void DanhMucThuoc_Load(object sender, EventArgs e)
        {
            btnThuocUngThu.Text = "Ẩn";
            btnNhomDuocLy.Text = "Ẩn";
            btnNuocSanXuat.Text = "Ẩn";
            btnHangSanXuat.Text = "Ẩn";
        }
        //Load Data
        private void LoadData()
        {
            msql = "SELECT * FROM[KHODUOC].[dbo].[DUOC_KC_DANHMUCTHUOC]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCTHUOC");
            dgrDanhMucThuoc.AutoGenerateColumns = false;
            dgrDanhMucThuoc.DataSource = tb;

            //cbo Dược Lý
            cboNhomDuocLy.DataSource = tb.Copy();
            cboNhomDuocLy.DisplayMember = "NhomDuocLy";
            cboNhomDuocLy.ValueMember = "NhomDuocLy";
            cboNhomDuocLy.CustomAlignment = new string[] { "l", "l" };
            cboNhomDuocLy.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Phân loại độc
            cboPhanLoaiDoc.DataSource = tb.Copy();
            cboPhanLoaiDoc.DisplayMember = "PhanLoaiDoc";
            cboPhanLoaiDoc.ValueMember = "PhanLoaiDoc";
            cboPhanLoaiDoc.CustomAlignment = new string[] { "l", "l" };
            cboPhanLoaiDoc.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Tham Gia BHYT
            cboThamGiaBHYT.DataSource = tb.Copy();
            cboThamGiaBHYT.DisplayMember = "ThamGiaBHYT";
            cboThamGiaBHYT.ValueMember = "ThamGiaBHYT";
            cboThamGiaBHYT.CustomAlignment = new string[] { "l", "l" };
            cboThamGiaBHYT.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nước sản xuất
            cboNuocSanXuat.DataSource = tb.Copy();
            cboNuocSanXuat.DisplayMember = "NuocSanXuat";
            cboNuocSanXuat.ValueMember = "NuocSanXuat";
            cboNuocSanXuat.CustomAlignment = new string[] { "l", "l" };
            cboNuocSanXuat.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Trạng thái
            cboTrangThai.DataSource = tb.Copy();
            cboTrangThai.DisplayMember = "TrangThai";
            cboTrangThai.ValueMember = "TrangThai";
            cboTrangThai.CustomAlignment = new string[] { "l", "l" };
            cboTrangThai.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Mã DQG
            cboMaDQG.DataSource = tb.Copy();
            cboMaDQG.DisplayMember = "MaDQG";
            cboMaDQG.ValueMember = "MaDQG";
            cboMaDQG.CustomAlignment = new string[] { "l", "l" };
            cboMaDQG.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Chọn khu điều trị
            cboKhuDieuTri.DataSource = tb.Copy();
            cboKhuDieuTri.DisplayMember = "KhuDieuTri";
            cboKhuDieuTri.ValueMember = "KhuDieuTri";
            cboKhuDieuTri.CustomAlignment = new string[] { "l", "l" };
            cboKhuDieuTri.CustomColumnStyle = new string[] { "t", "t" };
        }
        //Đánh stt
        private void dgrDanhMucThuoc_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrDanhMucThuoc);
        }
        //
        private void t_Tick(object sender, EventArgs e)
        {
            if (toggleLight)
            {
                btnThuocUngThu.BackColor = Color.LimeGreen;
                toggleLight = false;
            }
            else
            {
                btnThuocUngThu.BackColor = Color.Gray;
                toggleLight = true;
            }
        }
        //Ẩn cột DataDridView
        private void Hide()
        {
            //Ẩn cột trong DataGrid view
            this.dgrDanhMucThuoc.Columns["cThuocUngThu"].Visible = false;
            this.dgrDanhMucThuoc.Columns["cNhomDuocLy"].Visible = false;
            this.dgrDanhMucThuoc.Columns["cNuocSanXuat"].Visible = false;
            this.dgrDanhMucThuoc.Columns["cHangSanXuat"].Visible = false;
        }

        private void dgrDanhMucThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaThuoc_Enter(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaThuoc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMaThuoc_Leave(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);

        }

        private void txtMaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenThuoc);
        }

        private void txtTenThuoc_Enter(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtThanhPhan);

        }

        private void txtThanhPhan_Enter(object sender, EventArgs e)
        {
            txtThanhPhan.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtThanhPhan_Leave(object sender, EventArgs e)
        {
            txtThanhPhan.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtThanhPhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTim);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapThuoc f = new FrmNhapThuoc();
            f.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            msql = "SELECT [NhomDuocLy],[PhanLoaiDoc],[ThamGiaBHYT],[NuocSanXuat],[TrangThai],[MaDQG],[MaThuoc],[TenThuoc],[ThanhPhan],[KhuDieuTri] *  FROM [KHODUOC].[dbo].[DUOC_KC_DANHMUCTHUOC] ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCTHUOC");
            dgrDanhMucThuoc.AutoGenerateColumns = false;
            dgrDanhMucThuoc.DataSource = tb;
        }

        //    private void btnXuatExcelAll_Click(object sender, EventArgs e)
        //    {
        //        SaveFileDialog sf = new SaveFileDialog();
        //        sf.Filter = "Excel 2007 or Higher(.xlsx) | *.xlsx";
        //        if (sf.ShowDialog() == DialogResult.OK)
        //        {
        //            dgrDanhMucThuoc.ExportToXlsx(sf.FileName);
        //        }
        //    }
    }
}

