using BusinessCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBSQLHelper;

namespace KhoDuoc
{
    public partial class FrmCapNhapPhieuNhapThuoc : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        private DataTable yourDataTable;
        //Đang bị fail mã phiếu 
       
        public FrmCapNhapPhieuNhapThuoc()
        {

            InitializeComponent();
            LoadData();
            Loadcbotheomaphieu();
            LoadDataThuoc();
            LoadNCC();
            LoadDataTNhaphuoc();
            LoadCbo();


            yourDataTable = new DataTable();
            yourDataTable.Columns.Add("MaThuoc", typeof(string));
            yourDataTable.Columns.Add("TenThuoc", typeof(string));
            yourDataTable.Columns.Add("Lo", typeof(string));
            // Add other columns as needed


        }
        private void LoadData()
        {
            //"+ FrmNhapThuoc.maphieunhapkho+"
            //msql = "SELECT * FROM [dbo].[tabDanhMucThuoc] as a, [dbo].[DUOC_KC_Lo2023Tam] as b,[dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] as c where b.MaPhieuNhapKho=c.MaPhieuNhapKho and a.MaThuoc=b.MaThuoc AND b.MaPhieuNhapKho =  '" + FrmNhapThuoc.maphieunhapkho + "'";
            //DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_NHAPKHO_NHAPTHUOC");
            //txtMaPhieu.Text = FrmNhapThuoc.maphieunhapkho;
            //dgrNhapThuoc.AutoGenerateColumns = false;
            //dgrNhapThuoc.DataSource = tb;
        }
        private void Loadcbotheomaphieu()
        {
            msql = "SELECT KhoDuoc FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] WHERE MaPhieuNhapKho =  '" + FrmNhapThuoc.maphieunhapkho + "'";
            DataTable KhoDuoc = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");

            cboKhoDuoc.DataSource = KhoDuoc.Copy();
            cboKhoDuoc.DisplayMember = "KhoDuoc";
            cboKhoDuoc.ValueMember = "KhoDuoc";
            cboKhoDuoc.CustomAlignment = new string[] { "l", "l" };
            cboKhoDuoc.CustomColumnStyle = new string[] { "t", "t" };

            msql = "SELECT [NguonNhap] FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] WHERE MaPhieuNhapKho =  '" + FrmNhapThuoc.maphieunhapkho + "' ";
            DataTable NguonNhap = comm.GetDataTable(mconnectstring, msql, "tabNhaSanXuat");

            cboNguonNhap.DataSource = NguonNhap.Copy();
            cboNguonNhap.DisplayMember = "NguonNhap";
            cboNguonNhap.ValueMember = "NguonNhap";
            cboNguonNhap.CustomAlignment = new string[] { "l", "l" };
            cboNguonNhap.CustomColumnStyle = new string[] { "t", "t" };


            msql = "SELECT [Loai] FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] WHERE MaPhieuNhapKho =  '" + FrmNhapThuoc.maphieunhapkho + "'";
            DataTable LoaiThuoc = comm.GetDataTable(mconnectstring, msql, "tabNhomThuoc");

            cboLoai.DataSource = LoaiThuoc.Copy();
            cboLoai.DisplayMember = "Loai";
            cboLoai.ValueMember = "Loai";
            cboLoai.CustomAlignment = new string[] { "l", "l" };
            cboLoai.CustomColumnStyle = new string[] { "t", "t" };


            msql = "SELECT [HopDongThau] FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] WHERE MaPhieuNhapKho =  '" + FrmNhapThuoc.maphieunhapkho + "'";
            DataTable HDT = comm.GetDataTable(mconnectstring, msql, "DUOC_HopDongThau");

            cboHopDongThau.DataSource = HDT.Copy();
            cboHopDongThau.DisplayMember = "HopDongThau";
            cboHopDongThau.ValueMember = "HopDongThau";
            cboHopDongThau.CustomAlignment = new string[] { "l", "l" };
            cboHopDongThau.CustomColumnStyle = new string[] { "t", "t" };
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

            msql = "SELECT * FROM  [KHODUOC].[dbo].[DUOC_KC_HopDongThau] ";
            DataTable HDT = comm.GetDataTable(mconnectstring, msql, "DUOC_HopDongThau");

            cboHopDongThau.DataSource = HDT.Copy();
            cboHopDongThau.DisplayMember = "MaHopDongThau";
            cboHopDongThau.ValueMember = "MaHopDongThau";
            cboHopDongThau.CustomAlignment = new string[] { "l", "l" };
            cboHopDongThau.CustomColumnStyle = new string[] { "t", "t" };
        }
        //Load grid theo mã phiếu để lấy các thông tin 

        public void LoadDataThuoc()
        {
            msql = "SELECT * FROM  [dbo].[tabDanhMucThuoc] AS a, [dbo].[DUOC_KC_NHAPKHO_NHAPNHACUNGCAP] as b , [dbo].[tabMANGUOIBAN] as c where a.MaThuoc=b.MaThuoc and a.MANGUOIBAN=c.MANGUOIBAN and c.MANGUOIBAN = '" + txtMaNCC.Text + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc");
            dgrThongTinThuoc.AutoGenerateColumns = false;
            dgrThongTinThuoc.DataSource = tb;
        }

        public void LoadDataTNhaphuoc()
        {

            msql = "SELECT * FROM  [dbo].[DUOC_KC_Lo2023Tam] where MaPhieuNhapKho='" + FrmNhapThuoc.maphieunhapkho + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc");
            dgrNhapThuoc.AutoGenerateColumns = false;
            dgrNhapThuoc.DataSource = tb;
        }

        private void LoadNCC()
        {
            msql = "SELECT * FROM [tabMANGUOIBAN]";
            DataTable ncc = comm.GetDataTable(mconnectstring, msql, "tabMANGUOIBAN");
            dgrNCCTT.AutoGenerateColumns = false;
            dgrNCCTT.DataSource = ncc;
        }


        //Thiếu lưu tiền 
        private void UpdateThongTinPhieu()
        {
            //msql = "UPDATE [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] SET [KhoDuoc] = N'" + cboKhoDuoc.SelectedValue + "',[NguonNhap] = N'" + cboNguonNhap.SelectedValue + "',[SoHoaDon] = '" + txtSoHoaDon.Text + "' ,[Loai] = N'" + cboLoai.SelectedValue + "' ,[NguoiNhap] = N'" + txtNguoiNhap.Text + "' ,[MANGUOIBAN] = '" + txtMaNCC.Text + "' ,[HopDongThau] = N'" + cboHopDongThau.SelectedValue + "' ,[GhiChu] =N'" + txtGhiChu.Text + "',[KyHieuHD] = N'" + txtKyHieuHD.Text + "' ,[NgayTaoHD] = '" + Convert.ToDateTime(dtNgayTaoHĐ.Value).ToString("yyyy-MM-dd") + "' ,[NgayNhap] = '" + Convert.ToDateTime(dtNgayTao.Value).ToString("yyyy-MM-dd") + "'  ,[KyHieuMauHD] = N'" + txtKyHieuMauHD.Text + "',[ThanhTien] = '" + txtThanhTien.Text + "',[TienThue] = '" + txtTienThue.Text + "' ,[ThanhTienVAT] = '" + txtTTVAT.Text + "' WHERE [MaPhieuNhapKho] = N'" + txtMaPhieu.Text + "'";
            //comm.RunSQL(mconnectstring, msql);
        }
        /// <summary>
        /// sửa 
        /// </summary>
        private void UpdateThongTinThuoc()
        {
            for (int i = 0; i < dgrNhapThuoc.Rows.Count; i++)
            {
                // Ensure the cells contain valid values before parsing
                if (double.TryParse(dgrNhapThuoc.Rows[i].Cells["cThanhTienVAT"].Value.ToString(), out double ThanhTienVAT)
                    && double.TryParse(dgrNhapThuoc.Rows[i].Cells["cSL"].Value.ToString(), out double SoLuong)
                    && double.TryParse(dgrNhapThuoc.Rows[i].Cells["cphantramVAT"].Value.ToString(), out double VATPercentage))
                {
                    double DonGiaVAT = ThanhTienVAT / SoLuong;
                    double DonGia = DonGiaVAT / (1 + (VATPercentage / 100));
                    double ThanhTien = DonGia * SoLuong;

                    msql = "UPDATE [dbo].[DUOC_KC_Lo2023Tam] " +
                           "SET [Lo] = N'" + dgrNhapThuoc.Rows[i].Cells["cLo"].Value + "'" +
                           ", [HanDung] = '" + Convert.ToDateTime(dgrNhapThuoc.Rows[i].Cells["cHanDung"].Value).ToString("yyyy-MM-dd") +
                           "', [DonGia] = '" + DonGia + "', [%VAT] = '" + VATPercentage + "', [DonGiaVAT] = '" + DonGiaVAT +
                           "', [SoLuong] = '" + SoLuong + "', [ThanhTien] = '" + ThanhTien +
                           "', [TTVAT] = '" + ThanhTienVAT + "' WHERE [MaThuoc] = N'" + dgrNhapThuoc.Rows[i].Cells["cMaThuoc"].Value +
                           "' and MaPhieuNhapKho = N'" + txtMaPhieu.Text + "'";

                    comm.RunSQL(mconnectstring, msql);
                }
                else
                {
                    // Handle invalid values or log the issue
                }
            }

        }
        private void txtSL_Enter(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
        }
        //Định dạng tiền tệ 
        private void DinhDangTienTe()
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtThanhTien.Text, System.Globalization.NumberStyles.AllowThousands);
            txtThanhTien.Text = String.Format(culture, "{0:N0}", value);
            txtThanhTien.Select(txtThanhTien.Text.Length, 0);

            System.Globalization.CultureInfo culture1 = new System.Globalization.CultureInfo("en-US");
            decimal value1 = decimal.Parse(txtTienThue.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTienThue.Text = String.Format(culture, "{0:N0}", value1);
            txtTienThue.Select(txtTienThue.Text.Length, 0);

            System.Globalization.CultureInfo culture2 = new System.Globalization.CultureInfo("en-US");
            decimal value2 = decimal.Parse(txtTTVAT.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTTVAT.Text = String.Format(culture, "{0:N0}", value2);
            txtTTVAT.Select(txtTTVAT.Text.Length, 0);
        }


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


        private void txtMaThuoc_Enter_2(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
        }

        private void txtTenThuoc_Enter_2(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
        }

        private void NmPhanTramVAT_Click(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
        }

        private void txtSL_Enter_2(object sender, EventArgs e)
        {
            txtSL.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtLo_Enter_1(object sender, EventArgs e)
        {
            txtLo.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtDVT_Enter_2(object sender, EventArgs e)
        {
            txtDVT.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
        }

        private void txtThanhTienVAT_Enter_1(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
            txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaThuoc_Leave(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSL_Leave(object sender, EventArgs e)
        {

        }

        private void txtLo_Leave(object sender, EventArgs e)
        {

        }

        private void txtDVT_Leave(object sender, EventArgs e)
        {
            txtDVT.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtThanhTienVAT_Leave(object sender, EventArgs e)
        {

            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtLo);
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgrNhapThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaThuoc.Text = dgrNhapThuoc.CurrentRow.Cells["cMaThuoc"].Value.ToString();



            if (e.RowIndex == -1)
                return;
            if (dgrNhapThuoc["cTenThuoc", e.RowIndex] == dgrNhapThuoc.CurrentCell)
            {
                dgrThongTinThuoc.Visible = true;
            }
            else if (dgrNhapThuoc["cXoa", e.RowIndex] == dgrNhapThuoc.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn xóa mã phiếu " + dgrNhapThuoc.CurrentRow.Cells["cMaThuoc"].Value.ToString() + " này không ?"))
                {
                    msql = "DELETE FROM [dbo].[DUOC_KC_Lo2023Tam] WHERE MaThuoc  = '" + dgrNhapThuoc.CurrentRow.Cells["cMaThuoc"].Value.ToString() + "' AND MaPhieuNhapKho = N'" + txtMaPhieu.Text + "'";
                    comm.RunSQL(mconnectstring, msql);
                    LoadDataThuoc();                }
            }
           


           else  if (dgrNhapThuoc.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow selectedRow = dgrNhapThuoc.SelectedRows[0];

                // Thêm dữ liệu vào dgrthuoctam
                dgrdanhsachtam.Rows.Add(selectedRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
                dgrdanhsachtam.Visible = true;
            }
        }

        private void cboKhoDuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboNguonNhap);
        }

        private void cboNguonNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSoHoaDon);
        }
        private void UpdatePhieu()
        {
            msql = "UPDATE [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] SET [KhoDuoc] = N'" + cboKhoDuoc.SelectedValue + "',[NguonNhap] = N'" + cboNguonNhap.SelectedValue + "',[SoHoaDon] = '" + txtSoHoaDon.Text + "' ,[Loai] = N'" + cboLoai.SelectedValue + "' ,[NguoiNhap] = N'" + txtNguoiNhap.Text + "' ,[HopDongThau] = N'" + cboHopDongThau.SelectedValue + "' ,[GhiChu] =N'" + txtGhiChu.Text + "',[KyHieuHD] = N'" + txtKyHieuHD.Text + "' ,[NgayTaoHD] = '" + Convert.ToDateTime(dtNgayTaoHĐ.Value).ToString("yyyy-MM-dd") + "' ,[NgayNhap] = '" + Convert.ToDateTime(dtNgayTao.Value).ToString("yyyy-MM-dd") + "'  ,[KyHieuMauHD] = N'" + txtKyHieuMauHD.Text + "' WHERE [MaPhieuNhapKho] = N'" + txtMaPhieu.Text + "'";
            comm.RunSQL(mconnectstring, msql);
        }
        private void UpdateThuoc()
        {
            msql = "UPDATE [dbo].[DUOC_KC_Lo2023Tam] SET [MaThuoc] = '" + txtMaThuoc.Text + "'WHERE  [MaPhieuNhapKho] = '" + dgrNhapThuoc.CurrentRow.Cells["cMaThuoc"].ToString() + "' ";
            comm.RunSQL(mconnectstring, msql);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdatePhieu();
        }
        private void dgrNhapThuoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrNhapThuoc);
        }

        private void txtTenNCC_Enter(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Bạn có chắc muốn thay đổi Nhà Cung Cấp không?"))
                dgrNCCTT.Visible = true;
            else
                dgrNCCTT.Visible = false;
        }

        private void txtTenNCC_Leave(object sender, EventArgs e)
        {

        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboHopDongThau);
            LoadDataThuoc();
        }

        private void cboKhoDuoc_Enter_1(object sender, EventArgs e)
        {
            //cboKhoDuoc.DroppedDown = true;
            //dgrThongTinThuoc.Visible = false;
            //LoadCbo();
        }

        private void cboNguonNhap_Enter_1(object sender, EventArgs e)
        {
            cboNguonNhap.DroppedDown = true;
            dgrThongTinThuoc.Visible = false;
        }

        private void txtSoHoaDon_Enter(object sender, EventArgs e)
        {
            txtSoHoaDon.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
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

        private void txtNguoiNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenNCC);
        }

        private void cboHopDongThau_Enter(object sender, EventArgs e)
        {
            cboHopDongThau.DroppedDown = true;
            dgrThongTinThuoc.Visible = false;
        }

        private void cboHopDongThau_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtKyHieuMauHD);
        }

        private void txtKyHieuHD_Enter(object sender, EventArgs e)
        {
            txtKyHieuMauHD.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtKyHieuHD_Leave(object sender, EventArgs e)
        {
            txtKyHieuMauHD.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtKyHieuHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtKyHieuHD);
        }

        private void txtGhiChu_Enter(object sender, EventArgs e)
        {
            txtGhiChu.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtGhiChu_Leave(object sender, EventArgs e)
        {
            txtGhiChu.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtMaThuoc);
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

        private void txtTenThuoc_Enter(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
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

        private void txtTenThuoc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtLo);
        }

        private void txtTenThuoc_Leave_1(object sender, EventArgs e)
        {
            if (txtTenThuoc.Text.Trim() != "")
            {
                txtMaThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cMaThuocTTT"].Value.ToString();
                txtTenThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cTenThuocTTT"].Value.ToString();
                txtDVT.Text = dgrThongTinThuoc.CurrentRow.Cells["cDVTTT"].Value.ToString();
            }
            else
                txtTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenThuoc_TextChanged(object sender, EventArgs e)
        {
            txtMaThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cMaThuocTTT"].Value.ToString();
            txtTenThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cTenThuocTTT"].Value.ToString();
            txtDVT.Text = dgrThongTinThuoc.CurrentRow.Cells["cDVTTT"].Value.ToString();
            dgrThongTinThuoc.Visible = false;
        }

        private void txtLo_Enter(object sender, EventArgs e)
        {
            txtLo.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtLo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtHanDung.Focus();
            }
        }

        private void txtLo_Leave_1(object sender, EventArgs e)
        {
            txtLo.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void dtHanDung_Enter(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
            dgrNCCTT.Visible = false;
        }

        private void dtHanDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtPhanTramVAT);
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

        private void txtSL_Enter_1(object sender, EventArgs e)
        {
            txtSL.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtSL_Leave_1(object sender, EventArgs e)
        {
            txtSL.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSL_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtThanhTienVAT);
        }

        private void txtThanhTienVAT_Enter(object sender, EventArgs e)
        {
            txtThanhTienVAT.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtThanhTienVAT_Leave_1(object sender, EventArgs e)
        {
            txtThanhTienVAT.xActive = false;
            ev.Qtxt_Leave(sender, e);
            if (txtThanhTienVAT.Text.Trim() != "")
            {
                if (txtThanhTienVAT.Text.Equals("0"))
                    return;
                double temp3 = Convert.ToDouble(txtThanhTienVAT.Text);
                txtThanhTienVAT.Text = temp3.ToString("#,###");
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập Số %VAT và Số lượng để có dữ liệu tính Thành Tiền Sau Thuế");
        }

        private void txtThanhTienVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnThem);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            

            if (txtMaThuoc.Text.Trim() != "" && txtTenThuoc.Text.Trim() != "" && txtLo.Text.Trim() != "" && txtDVT.Text.Trim() != "" && txtThanhTienVAT.Text.Trim() != "" && txtPhanTramVAT.Text.Trim() != "" && txtSL.Text.Trim() != "")
            {
                double ThanhTienVAT = double.Parse(txtThanhTienVAT.Text);
                double DonGiaVAT = ThanhTienVAT / double.Parse(txtSL.Text);
                double DonGia = DonGiaVAT / (1 + (double.Parse(txtPhanTramVAT.Text.ToString()) / 100));
                double ThanhTien = (DonGia * double.Parse(txtSL.Text));
                double TienThue = ThanhTienVAT - ThanhTien;

                int sc = dgrdanhsachtam.Rows.Count;
                double thanhtien = ThanhTien;
                for (int i = 0; i < sc; ++i)
                    thanhtien += double.Parse(dgrdanhsachtam.Rows[i].Cells["cTTTam"].Value.ToString());
                txtThanhTien.Text = thanhtien.ToString();

                

                DataGridViewRow row = new DataGridViewRow();
                dgrdanhsachtam.Rows.Add(txtMaThuoc.Text, txtTenThuoc.Text, txtLo.Text, dtHanDung.Value.ToString("dd/MM/yyyy"), txtDVT.Text, DonGia, int.Parse(txtPhanTramVAT.Text), DonGiaVAT, int.Parse(txtSL.Text), ThanhTien, TienThue, ThanhTienVAT);

               

                if (txtThanhTienVAT.Text.Equals("0"))
                    return;
                double temp3 = Convert.ToDouble(txtThanhTienVAT.Text);
                txtThanhTienVAT.Text = temp3.ToString("####");


                demsl();
                //TinhSoNgayConLai();

                txtMaThuoc.ResetText();
                txtTenThuoc.ResetText();
                txtDVT.ResetText();
                txtThanhTienVAT.ResetText();
                txtSL.ResetText();
            }




            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            }

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé!"))
            {
                UpdateThongTinPhieu();
                UpdateThongTinThuoc();
                ev.QFrmThongBao("Đã lưu thành công");
            }
            else
                ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé!");
        }



        private void dgrNCCTT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaNCC.Text = dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString();
            txtTenNCC.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();

            dgrNCCTT.Visible = false;
        }




        private void dgrThongTinThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cMaThuocTTT"].Value.ToString();
            txtTenThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cTenThuocTTT"].Value.ToString();
            txtDVT.Text = dgrThongTinThuoc.CurrentRow.Cells["cDVTTT"].Value.ToString();
            dtHanDung.Text = dgrThongTinThuoc.CurrentRow.Cells["cHanDungThuoc"].Value.ToString();
            txtSL.Text = dgrThongTinThuoc.CurrentRow.Cells["cSoLuong"].Value.ToString();

            dgrThongTinThuoc.Visible = false;




        }

        private void txtTenThuoc_Click(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = true;

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
        }

        private void txtTenThuoc_Click_1(object sender, EventArgs e)

        {
            if (ev.QFrmThongBao_YesNo("Bạn có chắc muốn thêm loại thuốc mới không?"))
                dgrThongTinThuoc.Visible = true;
            else
                dgrThongTinThuoc.Visible = false;
        }
        






        //private void dgrNhapThuoc_SelectionChanged(object sender, EventArgs e)
        //{
        //    // Kiểm tra xem có dòng nào được chọn không
        //    if (dgrNhapThuoc.SelectedRows.Count > 0)
        //    {
        //        // Dòng đã được chọn trong dgrthuoc
        //        dgrdanhsachtam.Visible = true;
        //        dgrNhapThuoc.Visible = false;
        //        // Xóa dữ liệu hiện tại trong dgrthuoctam (nếu có)
        //        dgrdanhsachtam.Rows.Clear();

        //        // Thêm dữ liệu mới vào dgrthuoctam
        //        DataGridViewRow selectedRow = dgrNhapThuoc.SelectedRows[0];
        //        dgrdanhsachtam.Rows.Add(selectedRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());

        //    }
        //    else
        //    {
        //        // Không có dòng nào được chọn trong dgrthuoc
        //        dgrdanhsachtam.Visible = false;
        //    }


        //}

        private void FrmCapNhapPhieuNhapThuoc_Load(object sender, EventArgs e)
        {
            btnThemThuoc.Click += btnThemThuoc_Click;

            // Ẩn dgrthuoctam ban đầu
            dgrdanhsachtam.Visible = false;
        }

        private void dgrdanhsachtam_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgrNhapThuoc.Visible = false;
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            txtTenThuoc.ReadOnly = true;
            btnThem.Visible=true;
            btnLuuLoaiThuoc.Visible = true;
            txtTenThuoc.Enabled = true;

            // Kiểm tra xem có dòng nào được chọn không
            if (dgrNhapThuoc.Rows.Count > 0)
            {
                // Hiển thị dgrdanhsachtam và ẩn dgrNhapThuoc
                dgrdanhsachtam.Visible = true;
                dgrNhapThuoc.Visible = false;

                // Xóa dữ liệu hiện tại trong dgrdanhsachtam (nếu có)
                dgrdanhsachtam.Rows.Clear();

                // Duyệt qua từng dòng trong dgrNhapThuoc
                foreach (DataGridViewRow row in dgrNhapThuoc.Rows)
                {
                    // Lấy giá trị từ cột "cLo" và "cMaThuoc"
                    
                    string giaTriMaThuoc = row.Cells["cMaThuoc"].Value.ToString();
                    string TenThuoc = row.Cells["cTenThuoc"].Value.ToString();
                    string giaTriLo = row.Cells["cLo"].Value.ToString();
                    string HanDung = row.Cells["cHanDung"].Value.ToString();
                    string dvt = row.Cells["cĐVTnhap"].Value.ToString();
                    string DonGia = row.Cells["cDonGia"].Value.ToString();
                    string PTVAT = row.Cells["cphantramVAT"].Value.ToString();
                    string DonGiaVAT = row.Cells["cDonGiaVAT"].Value.ToString();
                    string sl = row.Cells["cSL"].Value.ToString();
                    string ThanhTien = row.Cells["cThanhTien"].Value.ToString();
                    string ThanhTienVAT = row.Cells["cThanhTienVAT"].Value.ToString();
   


                    // Thêm giá trị vào dgrdanhsachtam
                    dgrdanhsachtam.Rows.Add(giaTriMaThuoc, TenThuoc, giaTriLo, HanDung, dvt, DonGia, PTVAT, DonGiaVAT, sl, ThanhTien, ThanhTienVAT);
                }
            }
            else
            {
                // Không có dòng nào trong dgrNhapThuoc
                dgrdanhsachtam.Visible = false;
            }
        }

        private void dgrNhapThuoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgrNhapThuoc.Columns["cThanhTien"].Index && e.Value != null)
            {
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {
                    // Định dạng số sang chuỗi với định dạng "#,###"
                    e.Value = cellValue.ToString("#,###");
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == dgrNhapThuoc.Columns["cDonGia"].Index && e.Value != null)
            {

                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {
                    // Định dạng số sang chuỗi với định dạng "#,###"
                    e.Value = cellValue.ToString("#,###");
                    e.FormattingApplied = true;
                }

            }
         else   if (e.ColumnIndex == dgrNhapThuoc.Columns["cSL"].Index && e.Value != null)
            {
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {
                    // Định dạng số và loại bỏ dấu phẩy và số 0 đằng sau
                    e.Value = cellValue.ToString("####").TrimEnd(',');
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgrdanhsachtam_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgrdanhsachtam.Columns["cTTTam"].Index && e.Value != null)
            {
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {
                    // Định dạng số sang chuỗi với định dạng "#,###"
                    e.Value = cellValue.ToString("####");
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == dgrdanhsachtam.Columns["cDonGiaTam"].Index && e.Value != null)
            {

                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {
                    // Định dạng số sang chuỗi với định dạng "#,###"
                    e.Value = cellValue.ToString("####");
                    e.FormattingApplied = true;
                }

            }
            else if (e.ColumnIndex == dgrdanhsachtam.Columns["cSLTam"].Index && e.Value != null)
            {
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {
                    // Định dạng số và loại bỏ dấu phẩy và số 0 đằng sau
                    e.Value = cellValue.ToString("####").TrimEnd(',');
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == dgrdanhsachtam.Columns["cTTVATTam"].Index && e.Value != null)
            {
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {
                    // Định dạng số và loại bỏ dấu phẩy và số 0 đằng sau
                    e.Value = cellValue.ToString("####").TrimEnd(',');
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == dgrdanhsachtam.Columns["cHSDTam"].Index && e.Value != null)
            {
                DateTime dateValue;
                if (DateTime.TryParse(e.Value.ToString(), out dateValue))
                {
                    // Định dạng ngày tháng năm
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == dgrdanhsachtam.Columns["cDonGiaVATTam"].Index && e.Value != null)
            {
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {
                    // Định dạng số và loại bỏ dấu phẩy và số 0 đằng sau
                    e.Value = cellValue.ToString("####").TrimEnd(',');
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnLuuLoaiThuoc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgrdanhsachtam.Rows.Count; i++)
            {
                string maThuoc = dgrdanhsachtam.Rows[i].Cells["cMaTam"].Value.ToString();

                // Check if the record with the same MaThuoc already exists
                string checkDuplicateSql = "SELECT COUNT(*) FROM [dbo].[DUOC_KC_Lo2023Tam] WHERE MaThuoc = '" + maThuoc + "'";

                // Assuming comm is a SqlCommand object
                int count = 0;

                using (SqlCommand sqlCommand = new SqlCommand(checkDuplicateSql, new SqlConnection(mconnectstring)))
                {
                    sqlCommand.Connection.Open();
                    count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }

                if (count == 0)
                {
                    // If the record does not exist, insert it
                    decimal cSLTamValue = Convert.ToDecimal(dgrdanhsachtam.Rows[i].Cells["cSLTam"].Value);
                    ev.QFrmThongBao_YesNo("Bạn có muốn thêm loại thuốc mới");
                    msql = "INSERT INTO [dbo].[DUOC_KC_Lo2023Tam]" +
                        "([MaThuoc],[TenThuoc],[DVT],[HanDung],[Lo],[SoLuong],[MaPhieuNhapKho],[DonGia],[%VAT],[DonGiaVAT],[ThanhTien],[TTVAT]) " +
                        "VALUES('" + dgrdanhsachtam.Rows[i].Cells["cMaTam"].Value + "','" + dgrdanhsachtam.Rows[i].Cells["cTenThuocTam"].Value + "','" + dgrdanhsachtam.Rows[i].Cells["cDVTTam"].Value + "','" + Convert.ToDateTime(dgrdanhsachtam.Rows[i].Cells["cHSDTam"].Value).ToString("yyyy-MM-dd") + "',N'" + dgrdanhsachtam.Rows[i].Cells["cLoTam"].Value + "','" + cSLTamValue + "',N'" + txtMaPhieu.Text + "'" +
                        ",'" + dgrdanhsachtam.Rows[i].Cells["cDonGiaTam"].Value + "','" + dgrdanhsachtam.Rows[i].Cells["cPTVATTam"].Value + "','" + dgrdanhsachtam.Rows[i].Cells["cDonGiaVATTam"].Value + "','" + dgrdanhsachtam.Rows[i].Cells["cTTTam"].Value + "','" + dgrdanhsachtam.Rows[i].Cells["cTTVATTam"].Value + "')";
                    ev.QFrmThongBao("Thêm thuốc thành công");
                    comm.RunSQL(mconnectstring, msql);
               
                }
               
            }




        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            dgrdanhsachtam.Visible = false;
            btnLuuLoaiThuoc.Visible = false;
            dgrNhapThuoc.Visible = true;
            btnThem.Visible = false;
            LoadDataTNhaphuoc();
        }

    }
}

