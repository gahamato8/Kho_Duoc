using BusinessCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoDuoc
{
    public partial class FrmSuaTTHĐ : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmSuaTTHĐ(string MaPhieu, string SoHoaDon, string KhoDuoc, string KhoNhap, string Loai, string NguoiNhap, string MaNhaCungCap, string NhaCungCap, string HopDongThau, string KyHieuMauHoaDon, string KyHieuHoaDon, string GhiChu, string NgayTaoHD, string NgayTao)
        {
            InitializeComponent();
            Loadcbotheomaphieu();
            LoadNCC();


            txtSoHoaDon.Text = SoHoaDon;
            txtMaPhieu.Text = MaPhieu;
            cboKhoDuoc.Text = KhoDuoc;
            cboNguonNhap.Text = KhoNhap;
            cboLoai.Text = Loai;
            txtNguoiNhap.Text = NguoiNhap;
            txtMaNCC1.Text = MaNhaCungCap;
            txtTenNCC1.Text = NhaCungCap;
            cboHopDongThau.Text = HopDongThau;
            txtKyHieuHD.Text = KyHieuHoaDon;
            txtKyHieuMauHD.Text = KyHieuMauHoaDon;
            txtGhiChu.Text = GhiChu;
            dtNgayTaoHĐ.Text = NgayTaoHD;
            dtNgayTao.Text = NgayTao;

            
        }
        public FrmSuaTTHĐ()
        {
            InitializeComponent();
            Loadcbotheomaphieu();
            LoadNCC();
            txtMaPhieu.Text = FrmNhapThuoc.maphieunhapkho;
        }
        private void Loadcbotheomaphieu()
        {
            msql = "SELECT * FROM [DUOC_KC_DANHMUCKHODUOC]";
            DataTable KhoDuoc = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");

            cboKhoDuoc1.DataSource = KhoDuoc.Copy();
            cboKhoDuoc1.DisplayMember = "TenKhoDuoc";
            cboKhoDuoc1.ValueMember = "MaKhoDuoc";
            cboKhoDuoc1.CustomAlignment = new string[] { "l", "l" };
            cboKhoDuoc1.CustomColumnStyle = new string[] { "t", "t" };

           
            msql = "SELECT * FROM [dbo].[DUOC_K_NguonNhap]";
            DataTable NguonNhap = comm.GetDataTable(mconnectstring, msql, "DUOC_K_NguonNhap");

            cboNguonNhap.DataSource = NguonNhap.Copy();
            cboNguonNhap.DisplayMember = "TenNguonNhap";
            cboNguonNhap.ValueMember = "MaNguonNhap";
            cboNguonNhap.CustomAlignment = new string[] { "l", "l" };
            cboNguonNhap.CustomColumnStyle = new string[] { "t", "t" };


            msql = "SELECT * FROM [dbo].[tabNhomThuoc]";
            DataTable LoaiThuoc = comm.GetDataTable(mconnectstring, msql, "tabNhomThuoc");

            cboLoai.DataSource = LoaiThuoc.Copy();
            cboLoai.DisplayMember = "TenNhom";
            cboLoai.ValueMember = "TenTat";
            cboLoai.CustomAlignment = new string[] { "l", "l" };
            cboLoai.CustomColumnStyle = new string[] { "t", "t" };

            cboLoai.DataSource = LoaiThuoc.Copy();
            cboLoai.DisplayMember = "TenNhom";
            cboLoai.ValueMember = "TenTat";
            cboLoai.CustomAlignment = new string[] { "l", "l" };
            cboLoai.CustomColumnStyle = new string[] { "t", "t" };

            msql = "SELECT MaHopDongThau FROM  [KHODUOC].[dbo].[DUOC_KC_HopDongThau]";
            DataTable HDT = comm.GetDataTable(mconnectstring, msql, "DUOC_HopDongThau");

            cboHopDongThau.DataSource = HDT.Copy();
            cboHopDongThau.DisplayMember = "MaHopDongThau";
            cboHopDongThau.ValueMember = "MaHopDongThau";
            cboHopDongThau.CustomAlignment = new string[] { "l", "l" };
            cboHopDongThau.CustomColumnStyle = new string[] { "t", "t" };
        }
       
        private void LoadNCC()
        {
            msql = "SELECT * FROM [tabMANGUOIBAN]";
            DataTable ncc = comm.GetDataTable(mconnectstring, msql, "tabMANGUOIBAN");
            dgrNCCTT.AutoGenerateColumns = false;
            dgrNCCTT.DataSource = ncc;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            msql = "UPDATE [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] SET [KhoDuoc] = N'" + cboKhoDuoc1.SelectedValue + "',[NguonNhap] = N'" + cboNguonNhap.SelectedValue + "',[SoHoaDon] = '" + txtSoHoaDon.Text + "' ,[Loai] = N'" + cboLoai.SelectedValue + "' ,[NguoiNhap] = N'" + txtNguoiNhap.Text + "' ,[MANGUOIBAN] = '" + txtTenNCC1.Text + "' ,[HopDongThau] = N'" + cboHopDongThau.SelectedValue + "' ,[GhiChu] =N'" + txtGhiChu.Text + "',[KyHieuHD] = N'" + txtKyHieuHD.Text + "' ,[NgayTaoHD] = '" + Convert.ToDateTime(dtNgayTaoHĐ.Value).ToString("yyyy-MM-dd") + "' ,[NgayNhap] = '" + Convert.ToDateTime(dtNgayTao.Value).ToString("yyyy-MM-dd") + "'  ,[KyHieuMauHD] = N'" + txtKyHieuMauHD.Text + "' WHERE [MaPhieuNhapKho] = N'" + txtMaPhieu.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }

        private void xFilteg4_Enter(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Bạn có chắc muốn thay đổi Nhà Cung Cấp không?"))
                dgrNCCTT.Visible = true;
            else
                dgrNCCTT.Visible = false;
        }

        private void xFilteg4_Leave(object sender, EventArgs e)
        {
            if (txtTenNCC1.Text.Trim() != "")
            {
                txtTenNCC1.Text = dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString();
                txtTenNCC1.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();
                dgrNCCTT.Visible = false;

                msql = "SELECT MaHopDongThau FROM  [KHODUOC].[dbo].[DUOC_KC_HopDongThau] WHERE MANGUOIBAN = '" + txtTenNCC1.Text + "'";
                DataTable HDT = comm.GetDataTable(mconnectstring, msql, "DUOC_HopDongThau");
                cboHopDongThau.DataSource = HDT.Copy();
                cboHopDongThau.DisplayMember = "MaHopDongThau";
                cboHopDongThau.ValueMember = "MaHopDongThau";
                cboHopDongThau.CustomAlignment = new string[] { "l", "l" };
                cboHopDongThau.CustomColumnStyle = new string[] { "t", "t" };
            }
            else
            ev.Qtxt_Leave(sender, e);
        }

        private void xFilteg4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboHopDongThau);
        }

        private void cboKhoDuoc1_Enter(object sender, EventArgs e)
        {
            cboKhoDuoc.DroppedDown = true;
            msql = "SELECT * FROM [dbo].[DUOC_KC_DANHMUCKHODUOC]";
            DataTable KhoDuoc = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");

            cboKhoDuoc1.DataSource = KhoDuoc.Copy();
            cboKhoDuoc1.DisplayMember = "TenKhoDuoc";
            cboKhoDuoc1.ValueMember = "LoaiKhoDuoc";
            cboKhoDuoc1.CustomAlignment = new string[] { "l", "l" };
            cboKhoDuoc1.CustomColumnStyle = new string[] { "t", "t" };
        }
    }
}
