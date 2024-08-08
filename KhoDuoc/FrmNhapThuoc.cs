using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCommon;
using VBSQLHelper;
using System.Globalization;

namespace KhoDuoc
{
    public partial class FrmNhapThuoc : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;


        public FrmNhapThuoc()
        {
            InitializeComponent();
            LoadCbo();
            LoadCapNhatPhieu();
            LoadNCC();
            LoadDataThuoc();
            txtNguoiNhap.Text = FrmDangNhap.tendn;

            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);

            //dtHanDung.Value = DateTime.Now;
            dtTuNgay.Value = startOfMonth;
            dtDenNgay.Value = DateTime.Now;

            SizeGirdView();
        }
        public static string maphieunhapkho;
        public static string MaNCC;
        public static string SoLo;
        public static string TenNCC;
        public static string khoduoc;
        public static string nguonnhap;
        public static string Sohoadon;
        public static string Loai;
        public static string nguoinhap;
        public static string HDT;
        public static string ghichu;
        public static string ngaytao;
        public static string ngaytaohd;
        public static string thanhtien;
        public static string tienthue;
        public static string ttvat;
        public static string kyhieuhd;
        public static string kyhieumauhd;



        public static string a;
        public static string R;
        public static string R1;
        private void LoadCapNhatPhieu()
        {
            msql = "SELECT DISTINCT a.NgayTaoHD,a.HopDongThau,a.KyHieuMauHD,a.KyHieuHD,a.SoHoaDon,a.NgayNhap,a.MaPhieuNhapKho,a.KhoDuoc,a.NguonNhap,a.Loai,a.NguoiNhap,a.MANGUOIBAN,c.TENNGUOIBAN,d.TenTrangThai,a.GhiChu,a.Lo,a.ThanhTien,a.TienThue,a.ThanhTienVAT FROM [KHODUOC].[dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] as A , [KHODUOC].[dbo].[DUOC_K_NguonNhap] as B, [KHODUOC].[dbo].[tabMANGUOIBAN] as C,Duoc_K_TrangThai as D , [dbo].[DUOC_KC_Lo2023Tam] AS E WHERE A.NguonNhap = B.MaNguonNhap AND A.MANGUOIBAN = C.MANGUOIBAN AND A.id_trangthai=D.IDTrangThai AND E.MaPhieuNhapKho=A.MaPhieuNhapKho AND A.id_trangthai = 2";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_NHAPKHO_NHAPTHUOC");
            dgrCapNhatPhieu.AutoGenerateColumns = false;
            dgrCapNhatPhieu.DataSource = tb;
            dgrCapNhatPhieu.Columns[11].Visible = false;
            dgrCapNhatPhieu.Columns[12].Visible = false;
            dgrCapNhatPhieu.Columns[13].Visible = false;
            dgrCapNhatPhieu.Columns[14].Visible = false;
            dgrCapNhatPhieu.Columns["cTrangThai"].Visible = true;
            dgrCapNhatPhieu.Columns["cNCC"].Visible = true;
            dgrCapNhatPhieu.Columns["cGhiChu"].Visible = true;
        }
        private void LoadNCC()
        {
            msql = "SELECT DISTINCT b.SOHD,b.MaHopDongThau,b.KyHieuHD,b.KyHieuMauHD, b.NgayNhapD, a.TENNGUOIBAN , b.MANGUOIBAN FROM [dbo].[tabMANGUOIBAN] AS a, [dbo].[tabDanhMucThuoc] AS b WHERE a.MANGUOIBAN = b.MANGUOIBAN";
            DataTable ncc = comm.GetDataTable(mconnectstring, msql, "tabMANGUOIBAN");
            dgrNCCTT.AutoGenerateColumns = false;
            dgrNCCTT.DataSource = ncc;
        }
        private int focusNCC()
        {
            txtMaNCC.Focus();
            return 1;
        }

        private void LoadCbo()
        {
            msql = "SELECT * FROM [dbo].[DUOC_KC_DANHMUCKHODUOC]";
            DataTable KhoDuoc = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");

            cboKhoDuoc.DataSource = KhoDuoc.Copy();
            cboKhoDuoc.DisplayMember = "TenKhoDuoc";
            cboKhoDuoc.ValueMember = "LoaiKhoDuoc";
            cboKhoDuoc.CustomAlignment = new string[] { "l", "l" };
            cboKhoDuoc.CustomColumnStyle = new string[] { "t", "t" };

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

            cboLoaiCNP.DataSource = LoaiThuoc.Copy();
            cboLoaiCNP.DisplayMember = "TenNhom";
            cboLoaiCNP.ValueMember = "TenTat";
            cboLoaiCNP.CustomAlignment = new string[] { "l", "l" };
            cboLoaiCNP.CustomColumnStyle = new string[] { "t", "t" };

            msql = "SELECT MaHopDongThau FROM  [KHODUOC].[dbo].[DUOC_KC_HopDongThau] AS A WHERE MANGUOIBAN = '" + txtMaNCC.Text + "'";
            DataTable HDT = comm.GetDataTable(mconnectstring, msql, "DUOC_HopDongThau");

            cboHopDongThau.DataSource = HDT.Copy();
            cboHopDongThau.DisplayMember = "MaHopDongThau";
            cboHopDongThau.ValueMember = "MaHopDongThau";
            cboHopDongThau.CustomAlignment = new string[] { "l", "l" };
            cboHopDongThau.CustomColumnStyle = new string[] { "t", "t" };


            msql = "SELECT * FROM[dbo].[Duoc_K_TrangThai]";
            DataTable TrangThaiPhieu = comm.GetDataTable(mconnectstring, msql, "Duoc_K_TrangThai");
            cboTrangThaiCNP.DataSource = TrangThaiPhieu.Copy();
            cboTrangThaiCNP.DisplayMember = "TenTrangThai";
            cboTrangThaiCNP.ValueMember = "IDTrangThai";
            cboTrangThaiCNP.CustomAlignment = new string[] { "l", "l" };
            cboTrangThaiCNP.CustomColumnStyle = new string[] { "t", "t" };
        }
        public string CreateAutoID()
        {
            //return SQLHelper.ExecQuerySacalar($@"SELECT CONCAT('PKN', RIGHT(CONCAT('0000000000',ISNULL(right(max(MaPhieuNhapKho),10),0) + 1),10))
            //                                FROM dbo.DUOC_KC_NHAPKHO_NHAPTHUOC where MaPhieuNhapKho like 'PKN%'").ToString();
            return SQLHelper.ExecQuerySacalar($@"select [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC1]('" + Convert.ToDateTime(dtNgayTao.Value).ToString("yyyy-MM-dd") + "')").ToString();
        }
        public void LoadData()
        {
            var tb = SQLHelper.ExecQueryDataAsDataTable("select * from DUOC_KC_NHAPKHO_NHAPTHUOC");
            dgrNhapThuoc.DataSource = tb;
        }

        //Tăng lên số lượng nếu trùng
        private void demsl()
        {
            for (int i = 0; i < dgrNhapThuoc.RowCount - 1; i++) //compare data
            {
                var Row = dgrNhapThuoc.Rows[i];
                string abc = Row.Cells[0].Value.ToString() + Row.Cells[3].Value.ToString() + Row.Cells[4].Value.ToString() + Row.Cells[5].Value.ToString() + Row.Cells[6].Value.ToString() + Row.Cells[2].Value.ToString().ToUpper();

                for (int j = i + 1; j < dgrNhapThuoc.RowCount; j++)
                {
                    var Row8 = dgrNhapThuoc.Rows[j];
                    string def = Row8.Cells[0].Value.ToString() + Row8.Cells[3].Value.ToString() + Row8.Cells[4].Value.ToString() + Row8.Cells[5].Value.ToString() + Row8.Cells[6].Value.ToString() + Row8.Cells[2].Value.ToString().ToUpper();

                    if (abc == def)
                    {
                        Row.Cells[7].Value = (double)Row.Cells[7].Value + (double)Row8.Cells[7].Value;
                        Row.Cells[8].Value = (int)Row.Cells[8].Value + (int)Row8.Cells[8].Value;
                        Row.Cells[9].Value = (double)Row.Cells[9].Value + (double)Row8.Cells[9].Value;
                        Row.Cells[10].Value = (double)Row.Cells[10].Value + (double)Row8.Cells[10].Value;
                        dgrNhapThuoc.Rows.Remove(Row8);
                        j--;
                    }
                }
            }
        }

        private void dgrThongTinThuoc_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrThongTinThuoc);
        }

        private void dgrNhapThuoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrNhapThuoc);
        }

        private void dgrNhapThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgrNhapThuoc["cXoa", e.RowIndex] == dgrNhapThuoc.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn xóa " + dgrNhapThuoc.CurrentRow.Cells["cTenThuoc"].Value.ToString() + " này không ?"))
                {
                    //Xóa dòng mình chọnc

                    foreach (DataGridViewRow item in this.dgrNhapThuoc.SelectedRows)
                    {
                        dgrNhapThuoc.Rows.RemoveAt(item.Index);
                    }
                }
            }
        }
        //Lưu các thông tin của phiếu nhập
        private void SaveThongTinPhieu()
        {
            msql = "INSERT INTO [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC]" +
            "([MaPhieuNhapKho],[KhoDuoc],[NguonNhap],[SoHoaDon],[Loai],[NguoiNhap],[HopDongThau],[GhiChu],[KyHieuHD],[NgayTaoHD],[NgayNhap],[MANGUOIBAN],[KyHieuMauHD],[ThanhTien],[TienThue],[ThanhTienVAT],[id_TrangThai],[Lo])" +
            "VALUES(N'" + txtMaPhieu.Text + "' ,N'" + cboKhoDuoc.SelectedValue + "' ,N'" + cboNguonNhap.SelectedValue + "','" + txtSoHoaDon.Text + "' ,N'" + cboLoai.SelectedValue + "' ,N'" + txtNguoiNhap.Text + "',N'" + txtHopDongThau.Text + "',N'" + txtGhiChu.Text + "','" + txtKyHieuHD.Text + "' ,'" + Convert.ToDateTime(dtNgayTaoHĐ.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(dtNgayTao.Value).ToString("yyyy-MM-dd") + "',N'" + txtMaNCC.Text + "','" + txtKyHieuMauHD.Text + "','" + txtThanhTien.Text + "','" + txtTienThue.Text + "','" + txtTTVAT.Text + "',2,'" + txtLo.Text + "')";
            comm.RunSQL(mconnectstring, msql);
        }
        //Lưu các thông tin lô, mã thuốc, số lượng và hạn dùng
        private void SaveThongTinThuoc()
        {
            for (int i = 0; i < dgrNhapThuoc.Rows.Count; i++)
            {
                msql = "INSERT INTO [dbo].[DUOC_KC_Lo2023Tam]" +
                "([MaThuoc],[TenThuoc],[DVT],[HanDung],[Lo],[SoLuong],[MaPhieuNhapKho],[DonGia],[%VAT],[DonGiaVAT],[ThanhTien],[TTVAT]) " +
                "VALUES('"+ dgrNhapThuoc.Rows[i].Cells["cMaThuoc"].Value + "','" + dgrNhapThuoc.Rows[i].Cells["cTenThuoc"].Value + "','" + dgrNhapThuoc.Rows[i].Cells["cĐVTnhap"].Value +"','" + Convert.ToDateTime(dgrNhapThuoc.Rows[i].Cells["cHanDung"].Value).ToString("yyyy-MM-dd") + "',N'" + dgrNhapThuoc.Rows[i].Cells["cLo"].Value + "','" + dgrNhapThuoc.Rows[i].Cells["cSL"].Value + "',N'" + txtMaPhieu.Text + "'" +
                ",'" + dgrNhapThuoc.Rows[i].Cells["cDonGia"].Value + "','" + dgrNhapThuoc.Rows[i].Cells["cphantramVAT"].Value + "','" + dgrNhapThuoc.Rows[i].Cells["cDonGiaVAT"].Value + "','" + dgrNhapThuoc.Rows[i].Cells["cThanhTien"].Value + "','" + dgrNhapThuoc.Rows[i].Cells["cThanhTienVAT"].Value + "')";
                comm.RunSQL(mconnectstring, msql);
            }
        }

        private void SaveSLNhapStoredTamThoi()
        {
            for (int i = 0; i < dgrNhapThuoc.Rows.Count; i++)
            {
                //@SoLuongNhapVao, @SoLuongYeuCauXuat, @SoLuongHuBe, @SoLuongHoanTra, @MaThuoc, @LoNhapVao, @HanDungNhapVao, @MaPhieuNhap, @MaPhieuYeuCau, @TrangThai, @DieuKien 
                msql = "exec FiFoKhoChan '" + dgrNhapThuoc.Rows[i].Cells["cSL"].Value + "',0,0,0,'" + dgrNhapThuoc.Rows[i].Cells["cMaThuoc"].Value + "','" + dgrNhapThuoc.Rows[i].Cells["cLo"].Value + "','" + Convert.ToDateTime(dgrNhapThuoc.Rows[i].Cells["cHanDung"].Value).ToString("yyyy-MM-dd") + "','" + txtMaPhieu.Text + "','',0,0";
                comm.RunSQL(mconnectstring, msql);
            }
        }
        private void SaveSLNhapStoredChinhThuc()
        {
            //exec FiFoKhoChan '','','','','','','','PNK20230730','',0,2

            msql = "exec FiFoKhoChan '','','','','','','','" + txtMaPhieuCNP.Text + "','',0,2";
            comm.RunSQL(mconnectstring, msql);
        }
        private void SaveSLNhapStoredHuy()
        {
            msql = "exec FiFoKhoChan '','','','','','','','" + txtMaPhieuCNP.Text + "','',0,3";
            comm.RunSQL(mconnectstring, msql);
        }
        private void txtSoHoaDon_Enter(object sender, EventArgs e)
        {
            txtSoHoaDon.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSoHoaDon_Leave(object sender, EventArgs e)
        {
            txtSoHoaDon.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSoHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboLoai);
        }

        private void txtMaNhaCungCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboHopDongThau);
        }

        private void txtKyHieuHD_Enter(object sender, EventArgs e)
        {
            txtKyHieuHD.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtKyHieuHD_Leave(object sender, EventArgs e)
        {
            txtKyHieuHD.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtKyHieuHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGhiChu);
        }

        private void txtGhiChu_Enter(object sender, EventArgs e)
        {
            txtGhiChu.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGhiChu_Leave(object sender, EventArgs e)
        {
            txtGhiChu.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenNCC);
        }
        private void txtMaThuoc_Enter_1(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
        }

        private void txtMaThuoc_Leave_1(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);

        }

        private void txtTenThuoc_Enter_1(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
            pnBangMau.Visible = true;
        }

        private void txtTenThuoc_Leave_1(object sender, EventArgs e)
        {
           
        }

        private void txtLo_Enter(object sender, EventArgs e)
        {
            txtLo.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtLo_Leave(object sender, EventArgs e)
        {
            txtLo.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void txtDVT_Enter(object sender, EventArgs e)
        {
            txtDVT.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
        }

        private void txtDVT_Leave(object sender, EventArgs e)
        {
            txtSoHoaDon.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtThanhTienVAT);
        }
        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            txtThanhTienVAT.xActive = false;
            ev.Qtxt_Leave(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtSL_Enter(object sender, EventArgs e)
        {
            txtSL.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtSL_Leave(object sender, EventArgs e)
        {
            txtSL.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void dtNgayTaoHĐ_ValueChanged(object sender, EventArgs e)
        {
            if (dtNgayTaoHĐ.Value > DateTime.Now)
            {
                ev.QFrmThongBaoError("Ngày không hợp lệ. Vui lòng chọn lại ngày");
                dtNgayTaoHĐ.Value = DateTime.Now;
                return;
            }
            else
                LoadDataThuoc();
        }

        private void dtNgayTaoHĐ_Leave(object sender, EventArgs e)
        {
            if (dtNgayTaoHĐ.Value > DateTime.Now)
            {
                ev.QFrmThongBaoError("Ngày không hợp lệ. Vui lòng chọn lại ngày");
                dtNgayTaoHĐ.Value = DateTime.Now;
                return;
            }
            else
                LoadDataThuoc();
        }

        private void dtNgayTao_ValueChanged(object sender, EventArgs e)
        {
            if (dtNgayTao.Value > DateTime.Now)
            {
                ev.QFrmThongBaoError("Ngày không hợp lệ. Vui lòng chọn lại ngày");
                dtNgayTao.Value = DateTime.Now;
                return;
            }
            else
                LoadDataThuoc();
        }

        private void dtNgayTao_Leave(object sender, EventArgs e)
        {
            if (dtNgayTao.Value > DateTime.Now)
            {
                ev.QFrmThongBaoError("Ngày không hợp lệ. Vui lòng chọn lại ngày");
                dtNgayTao.Value = DateTime.Now;
                return;
            }
            else
                LoadDataThuoc();
        }

        private void dgrNhapThuoc_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrNhapThuoc);
        }

        private void dgrThongTinThuoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrThongTinThuoc);
        }

        private void ResetDataGridViewvaText()
        {
            txtMaThuoc.ResetText();
            txtTenThuoc.ResetText();
            txtLo.ResetText();
            dtHanDung.Value = DateTime.Now;
            txtDVT.ResetText();
            txtThanhTienVAT.ResetText();
            txtSL.ResetText();
            txtThanhTien.ResetText();
            txtTienThue.ResetText();
            txtTTVAT.ResetText();
            txtMaPhieu.ResetText();
            dgrNhapThuoc.Rows.Clear();
        }
        private void TaoMoi()
        {
            ResetDataGridViewvaText();
        }



        // Tab Cập nhật phiếu nhập 
        private void dtDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtDenNgay.Value > DateTime.Now)
            {
                ev.QFrmThongBaoError("Ngày không hợp lệ. Vui lòng chọn lại ngày");
                dtDenNgay.Value = DateTime.Now;
                return;
            }
            else
                LoadDataThuoc();
        }

        private void dgrCapNhatPhieu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrCapNhatPhieu);
        }
        // để làm sau
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadTheoTim();
        }
        private void LoadTheoTim()
        {
            int a = int.Parse(cboTrangThaiCNP.SelectedValue.ToString());
            switch (a)
            {
                case 1:
                    msql = "SELECT * FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC]  as A , [KHODUOC].[dbo].[DUOC_K_NguonNhap] as B, [KHODUOC].[dbo].[tabMANGUOIBAN] as C ,Duoc_K_TrangThai as D WHERE A.id_TrangThai=D.IDTrangThai AND A.NguonNhap = B.MaNguonNhap AND A.MANGUOIBAN = C.MANGUOIBAN AND NgayNhap between '" + Convert.ToDateTime(dtTuNgay.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtDenNgay.Value).ToString("yyyy-MM-dd") + "' ";
                    DataTable tc = comm.GetDataTable(mconnectstring, msql, "TatCa");
                    dgrCapNhatPhieu.AutoGenerateColumns = false;
                    dgrCapNhatPhieu.DataSource = tc;
                    dgrCapNhatPhieu.Columns[11].Visible = false;
                    dgrCapNhatPhieu.Columns[12].Visible = false;
                    dgrCapNhatPhieu.Columns[13].Visible = false;
                    dgrCapNhatPhieu.Columns[14].Visible = false;
                    dgrCapNhatPhieu.Columns[15].Visible = false;
                    dgrCapNhatPhieu.Columns["cTrangThai"].Visible = true;
                    dgrCapNhatPhieu.Columns["cNCC"].Visible = true;
                    dgrCapNhatPhieu.Columns["cGhiChu"].Visible = true;
                    break;
                case 2:
                    msql = "SELECT DISTINCT a.NgayTaoHD,a.HopDongThau,a.KyHieuMauHD,a.KyHieuHD,a.SoHoaDon,a.NgayNhap,a.MaPhieuNhapKho,a.KhoDuoc,a.NguonNhap,a.Loai,a.NguoiNhap,a.MANGUOIBAN,c.TENNGUOIBAN,d.TenTrangThai,a.GhiChu,a.Lo,a.ThanhTien,a.TienThue,a.ThanhTienVAT FROM [KHODUOC].[dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] as A , [KHODUOC].[dbo].[DUOC_K_NguonNhap] as B, [KHODUOC].[dbo].[tabMANGUOIBAN] as C,Duoc_K_TrangThai as D , [dbo].[DUOC_KC_Lo2023Tam] AS E WHERE A.NguonNhap = B.MaNguonNhap AND A.MANGUOIBAN = C.MANGUOIBAN AND A.id_trangthai=D.IDTrangThai AND E.MaPhieuNhapKho=A.MaPhieuNhapKho AND A.id_trangthai = 2 AND Loai = N'" + cboLoaiCNP.SelectedValue + "' AND NgayNhap between '" + Convert.ToDateTime(dtTuNgay.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtDenNgay.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable cn = comm.GetDataTable(mconnectstring, msql, "ChoNhap");
                    dgrCapNhatPhieu.AutoGenerateColumns = false;
                    dgrCapNhatPhieu.DataSource = cn;
                    dgrCapNhatPhieu.Columns[11].Visible = false;
                    dgrCapNhatPhieu.Columns[12].Visible = true;
                    dgrCapNhatPhieu.Columns[13].Visible = true;
                    dgrCapNhatPhieu.Columns[14].Visible = false;
                    dgrCapNhatPhieu.Columns["cXoaCNP"].Visible = true;
                    dgrCapNhatPhieu.Columns["cSuaCNP"].Visible = true;
                    dgrCapNhatPhieu.Columns["cKhoaPhieuCNP"].Visible = true;
                    dgrCapNhatPhieu.Columns["cSuaTTHĐ"].Visible = true;
                    dgrCapNhatPhieu.Columns["cSoLo1"].Visible = true;

                    break;
                case 3:
                    msql = "SELECT * FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC]  as A , [KHODUOC].[dbo].[DUOC_K_NguonNhap] as B, [KHODUOC].[dbo].[tabMANGUOIBAN] as C ,Duoc_K_TrangThai as D WHERE A.id_TrangThai=D.IDTrangThai AND A.NguonNhap = B.MaNguonNhap AND A.MANGUOIBAN = C.MANGUOIBAN AND A.id_TrangThai = 3 AND Loai = N'" + cboLoaiCNP.SelectedValue + "' AND NgayNhap between '" + Convert.ToDateTime(dtTuNgay.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtDenNgay.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dn = comm.GetDataTable(mconnectstring, msql, "DaNhap");
                    dgrCapNhatPhieu.AutoGenerateColumns = false;
                    dgrCapNhatPhieu.DataSource = dn;
                    dgrCapNhatPhieu.Columns[11].Visible = true;
                    dgrCapNhatPhieu.Columns[12].Visible = false;
                    dgrCapNhatPhieu.Columns[13].Visible = false;
                    dgrCapNhatPhieu.Columns[14].Visible = true;
                    dgrCapNhatPhieu.Columns[15].Visible = false;
                    dgrCapNhatPhieu.Columns[16].Visible = false;
                    dgrCapNhatPhieu.Columns["cKhoaPhieuCNP"].Visible = false;
                    dgrCapNhatPhieu.Columns["cPrint"].Visible = true;
                    dgrCapNhatPhieu.Columns["cSuaCNP"].Visible = false;

                    break;
                case 4:
                    msql = "SELECT * FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC]  as A , [KHODUOC].[dbo].[DUOC_K_NguonNhap] as B, [KHODUOC].[dbo].[tabMANGUOIBAN] as C ,Duoc_K_TrangThai as D WHERE A.id_TrangThai=D.IDTrangThai AND A.NguonNhap = B.MaNguonNhap AND A.MANGUOIBAN = C.MANGUOIBAN AND A.id_TrangThai = '4' AND NgayNhap between '" + Convert.ToDateTime(dtTuNgay.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtDenNgay.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable huy = comm.GetDataTable(mconnectstring, msql, "DaHuy");
                    dgrCapNhatPhieu.AutoGenerateColumns = false;
                    dgrCapNhatPhieu.DataSource = huy;
                    dgrCapNhatPhieu.Columns[11].Visible = false;
                    dgrCapNhatPhieu.Columns[12].Visible = false;
                    dgrCapNhatPhieu.Columns[13].Visible = false;
                    dgrCapNhatPhieu.Columns[14].Visible = false;
                    dgrCapNhatPhieu.Columns[15].Visible = false;
                    dgrCapNhatPhieu.Columns["cNCC"].Visible = true;
                    dgrCapNhatPhieu.Columns["cTrangThai"].Visible = true;
                    dgrCapNhatPhieu.Columns["cGhiChu"].Visible = true;
                    dgrCapNhatPhieu.Columns["cKhoaPhieuCNP"].Visible = false;
                    dgrCapNhatPhieu.Columns["cPrint"].Visible = false;
                    dgrCapNhatPhieu.Columns["cSuaCNP"].Visible = false;
                    break;
            }

        }

        private void SizeGirdView()
        {
            this.dgrCapNhatPhieu.DefaultCellStyle.Font = new Font("Times New Roman", 15);
            this.dgrThongTinThuoc.DefaultCellStyle.Font = new Font("Times New Roman", 15);
        }
        //khi click vào sẽ xổ ra 

        private void dgrCapNhatPhieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            txtMaSoHoaDon.Text = dgrCapNhatPhieu.CurrentRow.Cells["cMaHD"].Value.ToString();
            txtMaPhieuCNP.Text = dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString();
            txtMaPhieu_HD.Text = dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString();
            txtMaNhaCungCapCNP.Text = dgrCapNhatPhieu.CurrentRow.Cells["cNCC"].Value.ToString();
      


            if (e.RowIndex == -1)
                return;
            if (dgrCapNhatPhieu["cXoaCNP", e.RowIndex] == dgrCapNhatPhieu.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn hủy mã phiếu " + dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString() + "này không ?"))
                {
                    updatePhieuthanhDaHuy();
                    xoabangtamhuy();
                    LoadTheoTim();
                    SaveSLNhapStoredHuy();
                }
            }
            else if (dgrCapNhatPhieu["cSuaCNP", e.RowIndex] == dgrCapNhatPhieu.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có chắc muốn sửa số phiếu " + dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString() + " này không ?"))
                {


                    FrmCapNhapPhieuNhapThuoc add = new FrmCapNhapPhieuNhapThuoc(); //tạo Frm mới
                           //public static string khoduoc;
        //public static string nguonnhap;
        //public static string Sohoadon;
        //public static string Loai;
        //public static string nguoinhap;
        //public static string HDT;
        //public static string ghichu;
        //public static string ngaylinh;
        //public static string thanhtien;
        //public static string tienthue;
        //public static string ttvat;


        MaNCC = dgrCapNhatPhieu.CurrentRow.Cells["cMaNCC"].Value.ToString();
                     maphieunhapkho = dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString();
                     TenNCC = dgrCapNhatPhieu.CurrentRow.Cells["cNCC"].Value.ToString();
                     SoLo = dgrCapNhatPhieu.CurrentRow.Cells["cSoLo1"].Value.ToString();
                    khoduoc = dgrCapNhatPhieu.CurrentRow.Cells["cKhoDuoc"].Value.ToString();
                    nguonnhap = dgrCapNhatPhieu.CurrentRow.Cells["cKhoNhap"].Value.ToString();

                    Sohoadon = dgrCapNhatPhieu.CurrentRow.Cells["cMaHD"].Value.ToString();
                    Loai = dgrCapNhatPhieu.CurrentRow.Cells["cLoai"].Value.ToString();
                    nguoinhap = dgrCapNhatPhieu.CurrentRow.Cells["cNguoiNhap"].Value.ToString();
                    HDT = dgrCapNhatPhieu.CurrentRow.Cells["cHopDongThau"].Value.ToString();
                    ghichu = dgrCapNhatPhieu.CurrentRow.Cells["cGhiChu"].Value.ToString();
                    
                    ngaytao = dgrCapNhatPhieu.CurrentRow.Cells["cNgayNhap"].Value.ToString();
                    ngaytaohd = dgrCapNhatPhieu.CurrentRow.Cells["cNgayTaoHDCNP"].Value.ToString();

                    thanhtien = dgrCapNhatPhieu.CurrentRow.Cells["cThanhTienCNP"].Value.ToString();
                    tienthue = dgrCapNhatPhieu.CurrentRow.Cells["cTienThueCNP"].Value.ToString();
                    ttvat = dgrCapNhatPhieu.CurrentRow.Cells["cTTVAT"].Value.ToString();
                    kyhieuhd=dgrCapNhatPhieu.CurrentRow.Cells["cKyHieu_HD"].Value.ToString();
                    kyhieumauhd = dgrCapNhatPhieu.CurrentRow.Cells["cKyHieuMauHoaDon"].Value.ToString();

                    add.cboKhoDuoc.Text = khoduoc.ToString();
                    add.cboNguonNhap.Text = nguonnhap.ToString();
                    add.txtSoHoaDon.Text = Sohoadon.ToString();
                    add.cboLoai.Text = Loai.ToString();
                    add.txtNguoiNhap.Text = nguoinhap.ToString();
                    add.cboHopDongThau.Text = HDT.ToString();
                    add.txtGhiChu.Text = ghichu.ToString();
                    add.dtNgayTao.Text = ngaytao.ToString();
                    add.dtNgayTaoHĐ.Text = ngaytaohd.ToString();
                    add.txtThanhTien.Text = thanhtien.ToString();
                    add.txtTienThue.Text = tienthue.ToString();
                    add.txtTTVAT.Text = ttvat.ToString();
                    add.txtKyHieuHD.Text = kyhieuhd.ToString();
                    add.txtKyHieuMauHD.Text = kyhieumauhd.ToString();

                    add.txtLo.Text = SoLo.ToString();
                    add.txtTenNCC.Text = TenNCC.ToString();
                    add.txtMaNCC.Text= MaNCC.ToString();
                    add.txtMaPhieu.Text = maphieunhapkho.ToString();
                    add.LoadDataTNhaphuoc();
                    add.LoadDataThuoc();
                    FrmTongHop tonghop = new FrmTongHop();
                    add.ShowDialog();
                    tonghop.Close();


                    
                }
            }
            else if (dgrCapNhatPhieu["cSuaTTHĐ", e.RowIndex] == dgrCapNhatPhieu.CurrentCell)
            {
                //Đang bị fail mã phiếu 
                if (ev.QFrmThongBao_YesNo("Bạn có chắc muốn sửa Thông tin HĐ số phiếu " + dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString() + " này không ?"))
                {
                    //maphieunhapkho = dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString();
                    string MaPhieu = dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString();
                    string SoHoaDon = dgrCapNhatPhieu.CurrentRow.Cells["cMaHD"].Value.ToString();
                    string KhoDuoc = dgrCapNhatPhieu.CurrentRow.Cells["cKhoDuoc"].Value.ToString();
                    string KhoNhap = dgrCapNhatPhieu.CurrentRow.Cells["cKhoNhap"].Value.ToString();
                    string Loai = dgrCapNhatPhieu.CurrentRow.Cells["cLoai"].Value.ToString();
                    string NguoiNhap = dgrCapNhatPhieu.CurrentRow.Cells["cNguoiNhap"].Value.ToString();
                    string MaNhaCungCap = dgrCapNhatPhieu.CurrentRow.Cells["cMaNCC"].Value.ToString();
                    string NhaCungCap = dgrCapNhatPhieu.CurrentRow.Cells["cNCC"].Value.ToString();
                    string HopDongThau = dgrCapNhatPhieu.CurrentRow.Cells["cHopDongThau"].Value.ToString();
                    string KyHieuMauHoaDon = dgrCapNhatPhieu.CurrentRow.Cells["cKyHieuMauHoaDon"].Value.ToString();
                    string KyHieuHoaDon = dgrCapNhatPhieu.CurrentRow.Cells["cKyHieu_HD"].Value.ToString();
                    string GhiChu = dgrCapNhatPhieu.CurrentRow.Cells["cGhiChu"].Value.ToString();
                    
                     string NgayTaoHD = dgrCapNhatPhieu.CurrentRow.Cells["cNgayHoaDon"].Value.ToString();
                    string NgayTao = dgrCapNhatPhieu.CurrentRow.Cells["cNgayNhap"].Value.ToString();


                    // Pass the data to the constructor of FrmThemSuaNhaCungCap
                    FrmSuaTTHĐ f = new FrmSuaTTHĐ(MaPhieu,SoHoaDon, KhoDuoc, KhoNhap,Loai, NguoiNhap, MaNhaCungCap, NhaCungCap, HopDongThau, KyHieuMauHoaDon, KyHieuHoaDon, GhiChu, NgayTaoHD, NgayTao);

                    f.ShowDialog();
                }
            }
            else if (dgrCapNhatPhieu["cPrint", e.RowIndex] == dgrCapNhatPhieu.CurrentCell)
            {




                if (ev.QFrmThongBao_YesNo("Bạn muốn in phiếu nhập " + dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString() + " này không ?"))
                {

                    R1 = dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString();
                    FrmRPPhieuNhapKho frm = new FrmRPPhieuNhapKho();
                    frm.ShowDialog();



                }
            }
            else if (dgrCapNhatPhieu["cPrint1", e.RowIndex] == dgrCapNhatPhieu.CurrentCell)
            {




                if (ev.QFrmThongBao_YesNo("Bạn muốn in phiếu nhập " + dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString() + " này không ?"))
                {

                    R1 = dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString();
                    FrmRPPhieuNhapKho frm = new FrmRPPhieuNhapKho();
                    frm.ShowDialog();



                }
            }
            else if (dgrCapNhatPhieu["cKhoaPhieuCNP", e.RowIndex] == dgrCapNhatPhieu.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn duyệt phiếu nhập phiếu " + dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString() + " này không ?"))
                {
                    updatePhieuthanhDaNhap();
                    updatethuocvaobangchinh();
                    SaveSLNhapStoredChinhThuc();
                    SaveSLNhapStoredHuy();
                    xoabangtam();
                    LoadTheoTim();

                }
            }
        }


        private void updatePhieuthanhDaHuy()
        {
            msql = "UPDATE [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] SET [id_TrangThai] = 4 WHERE [MaPhieuNhapKho] = '" + dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString() + "' ";
            comm.RunSQL(mconnectstring, msql);
        }
        
        private void xoabangtamhuy()
        {
            msql = "DELETE FROM [dbo].[DUOC_KC_Lo2023Tam]";
            comm.RunSQL(mconnectstring, msql);
        }


        

        private void updatePhieuthanhDaNhap()
        {
            msql = "UPDATE [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] SET [id_TrangThai] = 3 WHERE [MaPhieuNhapKho] = '" + dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString() + "' ";
            comm.RunSQL(mconnectstring, msql);
        }
        private void updatethuocvaobangchinh()
        {
            msql = "insert into DUOC_KC_Lo2023(TenThuoc,MaThuoc,DVT,HanDung,Lo,SoLuong,MaPhieuNhapKho,DonGia,[%VAT],DonGiaVAT,ThanhTien,TTVAT) select TenThuoc,MaThuoc,DVT,HanDung,Lo,SoLuong,MaPhieuNhapKho,DonGia,[%VAT],DonGiaVAT,ThanhTien,TTVAT from DUOC_KC_Lo2023Tam";
            comm.RunSQL(mconnectstring, msql);
        }
        private void xoabangtam()
        {
            msql = "DELETE FROM [dbo].[DUOC_KC_Lo2023Tam]";
            comm.RunSQL(mconnectstring, msql);
        }
        private void NmPhanTramVAT_Enter(object sender, EventArgs e)
        {
            dgrThongTinThuoc.AutoGenerateColumns = false;
        }

        private void NmPhanTramVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSL);
            dgrThongTinThuoc.AutoGenerateColumns = false;
        }

        private void txtKyHieuMauHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSL);
        }

        private void txtThanhTienVAT_Enter(object sender, EventArgs e)
        {
            txtThanhTienVAT.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtSoHoaDon_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboLoai);
        }

        private void txtNguoiNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenNCC);
        }

        private void txtKyHieuMauHD_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtKyHieuHD);
        }

        private void txtKyHieuHD_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGhiChu);
        }

        private void txtThanhTienVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnThem);
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtLo);
        }

        private void txtLo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtHanDung.Focus();
            }
        }

        private void cboNguonNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSoHoaDon);
        }

        private void txtSoHoaDon_Enter_1(object sender, EventArgs e)
        {
            txtSoHoaDon.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtSoHoaDon_Leave_1(object sender, EventArgs e)
        {
            txtSoHoaDon.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void cboLoai_Enter(object sender, EventArgs e)
        {
            cboLoai.DroppedDown = true;
            dgrThongTinThuoc.Visible = false;
        }

        private void txtNguoiNhap_Enter(object sender, EventArgs e)
        {
            txtNguoiNhap.xActive = false;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtNguoiNhap_Leave(object sender, EventArgs e)
        {
            txtNguoiNhap.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }


        private void cboTenNhaCungCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboHopDongThau);
        }

        private void cboHopDongThau_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtKyHieuMauHD);
        }

        private void txtKyHieuMauHD_Enter(object sender, EventArgs e)
        {
            txtKyHieuMauHD.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtKyHieuMauHD_Leave(object sender, EventArgs e)
        {
            txtKyHieuMauHD.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtKyHieuHD_Enter_1(object sender, EventArgs e)
        {
            txtKyHieuHD.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtKyHieuHD_Leave_1(object sender, EventArgs e)
        {
            txtKyHieuHD.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGhiChu_Enter_1(object sender, EventArgs e)
        {
            txtGhiChu.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtGhiChu_Leave_1(object sender, EventArgs e)
        {
            txtGhiChu.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGhiChu_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtMaThuoc);
        }

        private void cboKhoDuoc_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void cboKhoDuoc_Enter(object sender, EventArgs e)
        {

        }
        private void cboKhoDuoc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtPhanTramVAT_Enter(object sender, EventArgs e)
        {
            txtPhanTramVAT.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtPhanTramVAT_Leave(object sender, EventArgs e)
        {
            txtPhanTramVAT.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtPhanTramVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSL);
        }

        private void dtHanDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtThanhTienVAT);
        }

        private void txtThanhTienVAT_Leave(object sender, EventArgs e)
        {
            txtThanhTienVAT.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void cboKhoDuoc_Enter_1(object sender, EventArgs e)
        {
            cboKhoDuoc.DroppedDown = true;
            dgrThongTinThuoc.Visible = false;
        }

        private void cboNguonNhap_Enter_1(object sender, EventArgs e)
        {
            cboNguonNhap.DroppedDown = true;
            dgrThongTinThuoc.Visible = false;
        }

        private void cboHopDongThau_Enter(object sender, EventArgs e)
        {
            cboHopDongThau.DroppedDown = true;
            dgrThongTinThuoc.Visible = false;
            dgrNCCTT.Visible = false;
        }
        private void txtTenThuoc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtPhanTramVAT);
        }
        private void txtTenThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int CurrentRow = dgrThongTinThuoc.CurrentCell.RowIndex;
                CurrentRow++;
                if (CurrentRow < dgrThongTinThuoc.Rows.Count)
                {
                    dgrThongTinThuoc.CurrentCell = dgrThongTinThuoc.Rows[CurrentRow].Cells["cTenThuocTTT"];
                }
                else
                {
                    dgrThongTinThuoc.CurrentCell = dgrThongTinThuoc.Rows[0].Cells["cTenThuocTTT"];
                }
            }
        }

        private void txtMaThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int CurrentRow = dgrThongTinThuoc.CurrentCell.RowIndex;
                CurrentRow++;
                if (CurrentRow < dgrThongTinThuoc.Rows.Count)
                {
                    dgrThongTinThuoc.CurrentCell = dgrThongTinThuoc.Rows[CurrentRow].Cells["cMaThuocTTT"];
                }
                else
                {
                    dgrThongTinThuoc.CurrentCell = dgrThongTinThuoc.Rows[0].Cells["cMaThuocTTT"];
                }
            }
        }

        private void txtMaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtPhanTramVAT);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn muốn tạo mới phiếu không?"))
            {
                TaoMoi();
                ev.QFrmThongBao("Đã tạo mới thành công");
            }

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text.Trim() != "" /*&& txtMaThuoc.Text.Trim() != "" && txtTenThuoc.Text.Trim() != "" && NmPhanTramVAT.Text.Trim() != "" && txtSL.Text.Trim() != "" && txtLo.Text.Trim() != "" && txtThanhTienVAT.Text.Trim() != ""*/)
            {




                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé!"))
                {
                    SaveThongTinPhieu();
                    SaveThongTinThuoc();
                    SaveSLNhapStoredTamThoi();
                    ev.QFrmThongBao("Đã lưu thành công");
                    ResetDataGridViewvaText();
                    this.dgrNhapThuoc.Rows.Clear();
                    LoadTheoTim();
                }
                else
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé!");
            }
            else
                ev.QFrmThongBaoError("Thiếu thông tin");
        }
        private void dtHanDung_Enter(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
            dgrNCCTT.Visible = false;
        }

        private void dtNgayTao_Enter(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
            dgrNCCTT.Visible = false;
        }

        private void dtNgayTaoHĐ_Enter(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
            dgrNCCTT.Visible = false;
        }

        private void txtNCC_Enter(object sender, EventArgs e)
        {
            dgrNCCTT.Visible = true;
            dgrThongTinThuoc.Visible = false;
        }
        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
            msql = "SELECT MaHopDongThau FROM  [KHODUOC].[dbo].[DUOC_KC_HopDongThau] WHERE MANGUOIBAN = '" + txtMaNCC.Text + "'";
            DataTable HDT = comm.GetDataTable(mconnectstring, msql, "DUOC_HopDongThau");

            cboHopDongThau.DataSource = HDT.Copy();
            cboHopDongThau.DisplayMember = "MaHopDongThau";
            cboHopDongThau.ValueMember = "MaHopDongThau";
            cboHopDongThau.CustomAlignment = new string[] { "l", "l" };
            cboHopDongThau.CustomColumnStyle = new string[] { "t", "t" };
            LoadDataThuoc();
            dgrNCCTT.Visible = false;
        }
        private void txtTenNCC_Leave(object sender, EventArgs e)
        {
            if (txtTenNCC.Text.Trim() != "")
            {
                txtMaNCC.Text = dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString();
                txtTenNCC.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();
                txtHopDongThau.Text = dgrNCCTT.CurrentRow.Cells["cMaHopDongThau"].Value.ToString();



                dgrNCCTT.Visible = false;

                msql = "SELECT MaHopDongThau FROM  [KHODUOC].[dbo].[DUOC_KC_HopDongThau] WHERE MANGUOIBAN = '" + txtMaNCC.Text + "'";
                DataTable HDT = comm.GetDataTable(mconnectstring, msql, "DUOC_HopDongThau");
                cboHopDongThau.DataSource = HDT.Copy();
                cboHopDongThau.DisplayMember = "MaHopDongThau";
                cboHopDongThau.ValueMember = "MaHopDongThau";
                cboHopDongThau.CustomAlignment = new string[] { "l", "l" };
                cboHopDongThau.CustomColumnStyle = new string[] { "t", "t" };
                LoadDataThuoc();
            }
            else
                txtTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

      

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboHopDongThau);
            LoadDataThuoc();

        }

        private void dgrNCCTT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            try
            {
                var currentRow = dgrNCCTT.CurrentRow;

                if (currentRow != null)
                {
                    txtMaNCC.Text = dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString();
                    txtTenNCC.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();
                    txtHopDongThau.Text = dgrNCCTT.CurrentRow.Cells["cMaHopDongThau"].Value.ToString();
                    txtKyHieuHD.Text = dgrNCCTT.CurrentRow.Cells["cKyHieuHD"].Value.ToString();
                    txtKyHieuMauHD.Text = dgrNCCTT.CurrentRow.Cells["cKyHieuMauHD"].Value.ToString();
                    txtSoHoaDon.Text = dgrNCCTT.CurrentRow.Cells["cSoHD"].Value.ToString();
                    dgrNCCTT.Visible = false;
                }
                else
                {
                    
                }
            }
            catch (NullReferenceException ex)
            {
               
            }




            //if (dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString()!= ""&& dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString()!=""&& dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString()!=""&& dgrNCCTT.CurrentRow.Cells["cMaHopDongThau"].Value.ToString()!=""&& dgrNCCTT.CurrentRow.Cells["cKyHieuHD"].Value.ToString()!=""&& dgrNCCTT.CurrentRow.Cells["cKyHieuMauHD"].Value.ToString()!=""&& dgrNCCTT.CurrentRow.Cells["cSoHD"].Value.ToString()!="")
            //{

            //txtMaNCC.Text = dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString();
            //txtTenNCC.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();
            //txtHopDongThau.Text = dgrNCCTT.CurrentRow.Cells["cMaHopDongThau"].Value.ToString();
            //txtKyHieuHD.Text = dgrNCCTT.CurrentRow.Cells["cKyHieuHD"].Value.ToString();
            //txtKyHieuMauHD.Text = dgrNCCTT.CurrentRow.Cells["cKyHieuMauHD"].Value.ToString();
            //txtSoHoaDon.Text = dgrNCCTT.CurrentRow.Cells["cSoHD"].Value.ToString();
            //    dgrNCCTT.Visible = false;
            //}
            //else
            //{

            //}



           
        }

        private void txtMaPhieuCNP_Enter(object sender, EventArgs e)
        {
            txtMaPhieuCNP.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaPhieuCNP_Leave(object sender, EventArgs e)
        {
            txtMaPhieuCNP.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaPhieu_HD_Enter(object sender, EventArgs e)
        {
            txtMaPhieu_HD.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaNhaCungCapCNP_Leave(object sender, EventArgs e)
        {
            txtMaNhaCungCapCNP.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaPhieu_HD_Leave(object sender, EventArgs e)
        {
            txtMaPhieu_HD.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaNhaCungCapCNP_Enter(object sender, EventArgs e)
        {
            txtMaNhaCungCapCNP.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaSoHoaDon_Enter(object sender, EventArgs e)
        {
            txtMaSoHoaDon.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaSoHoaDon_Leave(object sender, EventArgs e)
        {
            txtMaSoHoaDon.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void cboLoaiCNP_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }

        private void cboLoaiCNP_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }

        private void cboTrangThaiCNP_Enter(object sender, EventArgs e)
        {
            ev.Qcbo_Enter(sender, e);
        }

        private void cboTrangThaiCNP_Leave(object sender, EventArgs e)
        {
            ev.Qcbo_Leave(sender, e);
        }




        private void sl1()
        {
            if (int.TryParse(txtSL.Text, out int SL))
            {
                // Use the variable SL here (conversion successful)
                string cellValue1 = dgrNhapThuoc.CurrentRow.Cells["cSL"].Value.ToString();

                string cellValue = dgrThongTinThuoc.CurrentRow.Cells["cSoLuong"].Value.ToString();
                int cellValueInt;
                int cellValueInt1;

                if (int.TryParse(cellValue, out cellValueInt) && int.TryParse(cellValue1, out cellValueInt1))
                {
                    if (SL > cellValueInt)
                    {

                        foreach (DataGridViewRow row in dgrNhapThuoc.Rows)
                        {
                            if (row.Cells["cSL"].Value != null)
                            {
                                int rowCellValue;
                                if (int.TryParse(row.Cells["cSL"].Value.ToString(), out rowCellValue) && rowCellValue == SL)
                                {
                                    dgrNhapThuoc.Rows.Remove(row);
                                    break;
                                }
                            }
                        }
                        ev.QFrmThongBaoError("Số lượng nhập vượt quá số lượng trong kho");

                    }
                    else if (cellValueInt1 > cellValueInt)
                    {
                        ev.QFrmThongBaoError("Số lượng nhập vượt quá số lượng trong kho");

                        // Remove the current row from dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc
                        dgrNhapThuoc.Rows.Remove(dgrNhapThuoc.CurrentRow);



                    }
                }

            }



        }
        private void sl()
        {

            if (int.TryParse(txtSL.Text, out int SL))
            {
                string cellValue = dgrThongTinThuoc.CurrentRow.Cells["cSoLuong"].Value.ToString();
                int cellValueInt;

                if (int.TryParse(cellValue, out cellValueInt))
                {
                    if (cellValueInt == 0)
                    {
                        ev.QFrmThongBaoError("Số lượng thuốc trong kho đã hết vui lòng nhập thêm");

                        // Remove the current row only if the condition is met
                        foreach (DataGridViewRow row in dgrNhapThuoc.Rows)
                        {
                            if (row.Cells["cSL"].Value != null)
                            {
                                int rowCellValue;
                                if (int.TryParse(row.Cells["cSL"].Value.ToString(), out rowCellValue) && rowCellValue == 0)
                                {
                                    // Remove the row if the value in the "cSL" column is zero
                                    dgrNhapThuoc.Rows.Remove(row);
                                    break; // Exit the loop after removing the first matching row
                                }
                            }
                        }
                    }
                }
              
            }


        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMaPhieu.Text = CreateAutoID();
            if (txtMaThuoc.Text.Trim() != "" && txtTenThuoc.Text.Trim() != "" && txtLo.Text.Trim() != "" && txtDVT.Text.Trim() != "" && txtThanhTienVAT.Text.Trim() != "" && txtPhanTramVAT.Text.Trim() != "" && txtSL.Text.Trim() != "")
            {
                double ThanhTienVAT = double.Parse(txtThanhTienVAT.Text);
                double DonGiaVAT = ThanhTienVAT / double.Parse(txtSL.Text);
                double DonGia = DonGiaVAT / (1 + (double.Parse(txtPhanTramVAT.Text.ToString()) / 100));
                double ThanhTien = (DonGia * double.Parse(txtSL.Text));
                double TienThue = ThanhTienVAT - ThanhTien;

                int sc = dgrNhapThuoc.Rows.Count;
                double thanhtien = ThanhTien;
                for (int i = 0; i < sc; ++i)
                    thanhtien += double.Parse(dgrNhapThuoc.Rows[i].Cells[9].Value.ToString());
                txtThanhTien.Text = thanhtien.ToString();

                double tienthue = TienThue;
                for (int i = 0; i < sc; ++i)
                    tienthue += double.Parse(dgrNhapThuoc.Rows[i].Cells[10].Value.ToString());
                txtTienThue.Text = tienthue.ToString();

                double ttvat = ThanhTienVAT;
                for (int i = 0; i < sc; ++i)
                    ttvat += double.Parse(dgrNhapThuoc.Rows[i].Cells[11].Value.ToString());
                txtTTVAT.Text = ttvat.ToString();

                DataGridViewRow row = new DataGridViewRow(); 
                dgrNhapThuoc.Rows.Add(txtMaThuoc.Text, txtTenThuoc.Text, txtLo.Text, dtHanDung.Value.ToString("dd/MM/yyyy"), txtDVT.Text, DonGia, int.Parse(txtPhanTramVAT.Text), DonGiaVAT, int.Parse(txtSL.Text), ThanhTien, TienThue, ThanhTienVAT);

                if (txtTienThue.Text.Equals("0"))
                    return;
                double temp = Convert.ToDouble(txtTienThue.Text);
                txtTienThue.Text = temp.ToString("#,###");

                if (txtThanhTien.Text.Equals("0"))
                    return;
                double temp1 = Convert.ToDouble(txtThanhTien.Text);
                txtThanhTien.Text = temp1.ToString("#,###");

                if (txtTTVAT.Text.Equals("0"))
                    return;
                double temp2 = Convert.ToDouble(txtTTVAT.Text);
                txtTTVAT.Text = temp2.ToString("#,###");

                if (txtThanhTienVAT.Text.Equals("0"))
                    return;
                double temp3 = Convert.ToDouble(txtThanhTienVAT.Text);
                txtThanhTienVAT.Text = temp3.ToString("#,###");

                var affectRow = SQLHelper.ExecQueryNonData(msql, new { MaPhieuNhapKho = txtMaPhieu.Text });
                if (affectRow > 0)
                {
                    
                    txtMaPhieu.Text = CreateAutoID();
                 
                }
                demsl();
                //TinhSoNgayConLai();
                sl1();
                sl();
                txtMaThuoc.ResetText();
                txtTenThuoc.ResetText();
                txtDVT.ResetText();
                txtThanhTienVAT.ResetText();
                txtSL.ResetText();
                handung();
            }
          



            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            }
        }

        void handung()
        {

            DateTime now = DateTime.Now;
            foreach (DataGridViewRow row in dgrNhapThuoc.Rows)
            {
                DateTime expirationDate = Convert.ToDateTime(row.Cells["cHanDung"].Value); 

                if (expirationDate <= now)
                {
                    if (ev.QFrmThongBao_YesNo("Thuốc đã quá hạn sử dụng bạn còn muốn tiếp tục") == false)
                    {
                        dgrNhapThuoc.Rows.Remove(row);
                    }
                }
            }


        }

        private void TinhSoNgayConLai()
        {
            DateTime hanDungDate = dtHanDung.Value;

            DateTime currentDate = DateTime.Now;

            TimeSpan difference = hanDungDate - currentDate;

            if (difference.TotalDays < 0)
            {
                if (ev.QFrmThongBao_YesNo("Thuốc đã quá hạn sử dụng bạn còn muốn tiếp tục") == false)
                {
                    dgrNhapThuoc.Rows.Clear();
                }
            }
            else
            {
                int numberOfDays = (int)difference.TotalDays;
                //ev.QFrmThongBao("Số ngày còn lại: " + numberOfDays + " ngày.");
                
            }
        }
        private void dgrNCCTT_Click(object sender, EventArgs e)
        {
           
        }

        private void dgrNCCTT_MouseLeave(object sender, EventArgs e)
        {
            //dgrNCCTT.Visible = false;
            //txtTenNCC.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();
        }

        private void dgrNCCTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaNCC.Text = dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString();
            txtTenNCC.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();
            dgrNCCTT.Visible = false;
        }

        private void dgrCapNhatPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuCNP.Text = dgrCapNhatPhieu.CurrentRow.Cells["cMaPhieuCNP"].Value.ToString();
        }


        private void dgrThongTinThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {



            txtMaThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cMaThuocTTT"].Value.ToString();

            txtTenThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cTenThuocTTT"].Value.ToString();

            txtSL.Text = dgrThongTinThuoc.CurrentRow.Cells["cSoLuong"].Value.ToString();

            txtLo.Text = dgrThongTinThuoc.CurrentRow.Cells["cSoLottthuoc"].Value.ToString();

            txtDVT.Text = dgrThongTinThuoc.CurrentRow.Cells["cDVTTT"].Value.ToString();

            txtThanhTienVAT.Text = dgrThongTinThuoc.CurrentRow.Cells["cThanhTienTTthuoc"].Value.ToString();










            dtHanDung.Text = dgrThongTinThuoc.CurrentRow.Cells["cHanDungttthuoc"].Value.ToString();




            dgrThongTinThuoc.Visible = false;
            pnBangMau.Visible = false;
            txtMaPhieu.Clear();

        }

        private void txtTenNCC_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPhieu_HD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaThuoc_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataThuoc()
        {
            msql = "SELECT * FROM  [dbo].[tabDanhMucThuoc] AS a, [dbo].[DUOC_KC_NHAPKHO_NHAPNHACUNGCAP] as b , [dbo].[tabMANGUOIBAN] as c where a.MaThuoc=b.MaThuoc and a.MANGUOIBAN=c.MANGUOIBAN and c.MANGUOIBAN = '" + txtMaNCC.Text + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc");
            dgrThongTinThuoc.AutoGenerateColumns = false;
            dgrThongTinThuoc.DataSource = tb;

            // Add only the "Status" column if it doesn't exist
            if (!dgrThongTinThuoc.Columns.Contains("Trạng thái"))
            {
                DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
                statusColumn.Name = "Trạng thái";
                statusColumn.HeaderText = "Trạng thái";
                dgrThongTinThuoc.Columns.Add(statusColumn);
            }

            // Set the cell colors based on quantity status
            SetCellColors();
        }

        private void SetCellColors()
        {
            // Assuming the column index of the quantity is 4 (you need to adjust it based on your data)
            int quantityIndex = 4;

            foreach (DataGridViewRow row in dgrThongTinThuoc.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["cSoLuong"].Value);

                // Set the cell color based on quantity
                if (quantity >= 7000 && quantity < 10000)
                {
                    row.Cells["Trạng thái"].Style.BackColor = Color.Green; // Example: Green for sufficient quantity
                   
                }
                else if(quantity==0)
                {
                    row.Cells["Trạng thái"].Style.BackColor = Color.Red; // Example: Red for low quantity
                    
                }
                else if (quantity >= 3000 && quantity < 6000)
                {
                    row.Cells["Trạng thái"].Style.BackColor = Color.LightGreen; //không hiện màu

                }
                else if (quantity >= 1000 && quantity < 2000)
                {
                    row.Cells["Trạng thái"].Style.BackColor = Color.Yellow; //không hiện màu

                }

                // Set bold font for the "Status" cell
            }

            // Refresh the DataGridView to apply the changes immediately
            dgrThongTinThuoc.Refresh();
        }

        private void dgrThongTinThuoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgrThongTinThuoc.Columns["Trạng thái"].Index && e.RowIndex >= 0)
            {
                // Assuming the column index of the quantity is 4 (you need to adjust it based on your data)
                int quantityIndex = 4;
                int quantity = Convert.ToInt32(dgrThongTinThuoc.Rows[e.RowIndex].Cells["cSoLuong"].Value);

                // Set the cell color based on quantity
                if (quantity >= 10000)
                {
                    e.CellStyle.BackColor = Color.Green; // Example: Green for sufficient quantity
                }
                else if(quantity==0)
                {
                    e.CellStyle.BackColor = Color.Red; // Example: Red for low quantity
                }
                else if (quantity <=1000 )
                {
                    e.CellStyle.BackColor = Color.Yellow; // Example: Red for low quantity
                }
            }
        }

        private void dgrThongTinThuoc_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgrThongTinThuoc.Columns["Trạng thái"].Index && e.RowIndex >= 0)
            {
                // Assuming the column index of the quantity is 4 (you need to adjust it based on your data)
                int quantityIndex = 4;
                int quantity = Convert.ToInt32(dgrThongTinThuoc.Rows[e.RowIndex].Cells["cSoLuong"].Value);

                // Set the cell color based on quantity
                if (quantity >= 7000 && quantity <= 10000)
                {
                    e.CellStyle.BackColor = Color.Green; // Example: Green for sufficient quantity
                }
                else if (quantity == 0)
                {
                    e.CellStyle.BackColor = Color.Red; // Example: Red for low quantity
                }
                else if (quantity >= 3000 && quantity <= 6000)
                {
                    e.CellStyle.BackColor = Color.LightGreen; // không hiện màu
                }
                else if (quantity >= 1000 && quantity <= 2000)
                {
                    e.CellStyle.BackColor = Color.Yellow; // không hiện màu
                }
            }
        }

    }
}
    
