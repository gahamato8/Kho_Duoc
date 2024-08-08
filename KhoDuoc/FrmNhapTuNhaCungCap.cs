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
using DocumentFormat.OpenXml;

using System.Globalization;
using System.Data.OleDb;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;

namespace KhoDuoc
{
    public partial class FrmNhapTuNhaCungCap : Form
    {
        private DataTable dataTable;
        private SqlConnection connection = new SqlConnection("server=.;database = KHODUOC ; uid=sa;pwd=123");

        private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        private DataTable dt;
        public FrmNhapTuNhaCungCap()
        {
            
        
            InitializeComponent();

            
            HopDongThau();
        
                LoadCbo();
            LoadCapNhatPhieu();
            LoadNCC();
            delete();
            //loadphieu();
            txtNguoiNhap.Text = FrmDangNhap.tendn;

            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);

            dtHanDung.Value = DateTime.Now;
            dtTuNgay.Value = startOfMonth;
            dtDenNgay.Value = DateTime.Now;

            SizeGirdView();



            dataTable = new DataTable();
            loadcombobox();
            LoadDanhSachThuoc1();
            //cboHopDongThau.SelectedIndexChanged += cboHopDongThau_SelectedIndexChanged;
        }
        public static string maphieunhapkho;
        public static string a;
        public static string R;

        public static string R1;

        //Phiếu cũ
        //Phiếu mới
        private void InitializeDataGridView()
        {
           
            dgrNhapThuoc = new DataGridView();
            dgrNhapThuoc.Dock = DockStyle.Fill;
            Controls.Add(dgrNhapThuoc);

            // Add DataGridView columns with HeaderText
            dgrNhapThuoc.Columns.Add("cMaThuoc", "Mã");
            // Add more columns as needed
        }

       
        public string CreateAutoID1()
        {
            return SQLHelper.ExecQuerySacalar($@"SELECT CONCAT('MASV', RIGHT(CONCAT('0000000000',ISNULL(right(max(SoHD),10),0) + 1),10))
                                            FROM dbo.DUOC_KC_NHAPKHO_NHAPNHACUNGCAP where SoHD like 'SoHD%'").ToString();
        }

        private void LoadDataThuoc()
        {
            msql = "SELECT * FROM [KHODUOC].[dbo].[tabDanhMucThuoc] as a, [dbo].[DUOC_KC_NHAPKHO_NHAPNHACUNGCAP] as b where a.MaThuoc=b.MaThuoc and MANGUOIBAN = '" + txtMaNCC.Text + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc");
            dgrThongTinThuoc.AutoGenerateColumns = false;
            dgrThongTinThuoc.DataSource = tb;
        }

        private void LoadCapNhatPhieu()
        {
            //msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_Lo2023_NCC_tam]";
            //DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_NHAPKHO_NHAPTHUOC");
            //dgrCapNhatPhieu.AutoGenerateColumns = false;
            //dgrCapNhatPhieu.DataSource = tb;

        }

        private void LoadDanhSachThuoc1()
        {




            msql = "SELECT DISTINCT c.TENNGUOIBAN,c.MANGUOIBAN,b.TenThuoc,b.SOHD,b.NgayNhapD,b.MaPhieuNhapKhoNCC,b.SoLuongKho FROM [dbo].[DUOC_KC_NHAPKHO_NHAPNHACUNGCAP] as a, [dbo].[tabDanhMucThuoc]as b,[dbo].[tabMANGUOIBAN] as c where a.MaPhieuNhapKhoNCC=b.MaPhieuNhapKhoNCC and b.MANGUOIBAN=c.MANGUOIBAN";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tabMANGUOIBAN");
            dgrDSThuocNhaCungCap.AutoGenerateColumns = false;
            dgrDSThuocNhaCungCap.DataSource = tb;

        }


        private void LoadNCC()
        {
            msql = "select * from [dbo].[tabMANGUOIBAN]";
            DataTable ncc = comm.GetDataTable(mconnectstring, msql, "tabMANGUOIBAN");
            dgrNCCTT.AutoGenerateColumns = false;
            dgrNCCTT.DataSource = ncc;
        }
        private int focusNCC()
        {
            txtMaNCC.Focus();
            return 1;
        }
        void delete()
        {

            txtTenNCC.Clear();
            txtMaNCC.Clear();

        }
        
       
        private void LoadCbo()
        {






            msql = "SELECT * FROM [dbo].[tabQuyCach]";
            DataTable quycach = comm.GetDataTable(mconnectstring, msql, "tabQuyCach");

            cboQuyCach.DataSource = quycach.Copy();
            cboQuyCach.DisplayMember = "TenQuyCach";
            cboQuyCach.ValueMember = "IDQuyCach";
            cboQuyCach.CustomAlignment = new string[] { "l", "l" };
            cboQuyCach.CustomColumnStyle = new string[] { "t", "t" };

            msql = "SELECT * FROM [dbo].[tabNhomThuoc]";
            DataTable NhomThuoc = comm.GetDataTable(mconnectstring, msql, "tabNhomThuoc");

            cboNhomThuoc.DataSource = NhomThuoc.Copy();
            cboNhomThuoc.DisplayMember = "TenNhom";
            cboNhomThuoc.ValueMember = "IDNhomThuoc";
            cboNhomThuoc.CustomAlignment = new string[] { "l", "l" };
            cboNhomThuoc.CustomColumnStyle = new string[] { "t", "t" };

            msql = "SELECT * FROM [dbo].[tabNhomDanhMuc]";
            DataTable NhomDM = comm.GetDataTable(mconnectstring, msql, "tabNhomDanhMuc");

            cboDanhMuc.DataSource = NhomDM.Copy();
            cboDanhMuc.DisplayMember = "TenNhom";
            cboDanhMuc.ValueMember = "IDMaNhom";
            cboDanhMuc.CustomAlignment = new string[] { "l", "l" };
            cboDanhMuc.CustomColumnStyle = new string[] { "t", "t" };

            msql = "SELECT * FROM [dbo].[DUOC_KC_DANHMUCKHODUOC]";
            DataTable KhoDuoc = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");

            cboKhoDuoc.DataSource = KhoDuoc.Copy();
            cboKhoDuoc.DisplayMember = "TenKhoDuoc";
            cboKhoDuoc.ValueMember = "TenKhoDuoc";
            cboKhoDuoc.CustomAlignment = new string[] { "l", "l" };
            cboKhoDuoc.CustomColumnStyle = new string[] { "t", "t" };
            
           
            
            msql = "SELECT * FROM [dbo].[tabLoaithuoc]";
            DataTable LoaiThuoc = comm.GetDataTable(mconnectstring, msql, "tabLoaithuoc");

            cboLoai.DataSource = LoaiThuoc.Copy();
            cboLoai.DisplayMember = "TENLOAITHUOC";
            cboLoai.ValueMember = "IDLOAITHUOC";
            cboLoai.CustomAlignment = new string[] { "l", "l" };
            cboLoai.CustomColumnStyle = new string[] { "t", "t" };
            
           


       
            
        }



        public string CreateAutoID()
        {
          
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
                    //Xóa dòng mình chọn

                    foreach (DataGridViewRow item in this.dgrNhapThuoc.SelectedRows)
                    {
                        dgrNhapThuoc.Rows.RemoveAt(item.Index);
                    }
                }
            }
        }
        //Lưu các thông tin của phiếu nhập

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
        }

        private void txtKyHieuHD_Enter(object sender, EventArgs e)
        {
            txtKyHieuHD.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtKyHieuHD_Leave(object sender, EventArgs e)
        {
            txtKyHieuHD.xActive = false;
            ev.Qtxt_Leave(sender, e);
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
         
        }
        private void txtTenThuoc_Leave_1(object sender, EventArgs e)
        {
            

            if (txtTenThuoc.Text.Trim() != "")
            {
                txtMaThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cMaThuocTTT"].Value.ToString();
                txtTenThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cTenThuocTTT"].Value.ToString();
                txtDVT.Text = dgrThongTinThuoc.CurrentRow.Cells["cDVTTT"].Value.ToString();
                txtSL.Text = dgrThongTinThuoc.CurrentRow.Cells["cSoLuong"].Value.ToString();
            }
            else
                txtTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
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
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDonGia);
        }
        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            txtDonGia.xActive = false;
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
            txtDonGia.ResetText();
            txtSL.ResetText();

            dgrNhapThuoc.Rows.Clear();
        }
        private void TaoMoi()
        {
            ResetDataGridViewvaText();
        }



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
            ev.Qdgr_RowPostPaint(sender, e, dgrDSThuocNhaCungCap);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDanhSachThuoc1();
        }
        private void LoadTheoTim()
        {
        }

        private void SizeGirdView()
        {
            this.dgrDSThuocNhaCungCap.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 15);
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
            txtDonGia.xActive = true;
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
            
            dgrThongTinThuoc.Visible = false;
        }

        private void txtPhanTramVAT_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtPhanTramVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSL);
        }

        private void dtHanDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDonGia);
        }

        private void txtThanhTienVAT_Leave(object sender, EventArgs e)
        {
            txtDonGia.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void cboKhoDuoc_Enter_1(object sender, EventArgs e)
        {
            cboKhoDuoc.DroppedDown = true;
            dgrThongTinThuoc.Visible = false;
        }

       

        private void cboHopDongThau_Enter(object sender, EventArgs e)
        {
         
            dgrThongTinThuoc.Visible = false;
            dgrNCCTT.Visible = false;
        }
        private void txtTenThuoc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtPhanTramVAT);    
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
            //ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtPhanTramVAT);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn muốn tạo mới phiếu không?"))
            {
                TaoMoi();
                ev.QFrmThongBao("Đã tạo mới thành công");
            }

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
    

        }
        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void txtTenNCC_Leave(object sender, EventArgs e)
        {
            
        }


        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void dgrNCCTT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaNCC.Text = dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString();
            txtTenNCC.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();
            dgrNCCTT.Visible = false;

          
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
        bool kiemtrasl(String mathuoc, int sl)
        {
            if (dgrNhapThuoc.RowCount > 0)
            {
                foreach (DataGridViewRow item in dgrNhapThuoc.Rows)
                {
                    String currentCode = item.Cells[0].Value.ToString();
                    if (mathuoc == currentCode)
                    {
                        //tồn tại
                        int b = Convert.ToInt32(item.Cells["cSL"].Value) + sl;
                        item.Cells["cSL"].Value = b.ToString();
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }

        }
    
        public string CreateAutoIDNKNCC()
        {
          
            return SQLHelper.ExecQuerySacalar($@"select [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOCNHACUNGCAP]('" + Convert.ToDateTime(dtNgayTao.Value).ToString("yyyy-MM-dd") + "')").ToString();
        }


        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMaPhieu.Text = CreateAutoIDNKNCC();





            if (txtMaThuoc.Text.Trim() != "")
            {
                double ThanhTien = (double.Parse(txtDonGia.Text) * double.Parse(txtSL.Text));


                int sc = dgrNhapThuoc.Rows.Count;
                double thanhtien = ThanhTien;
                for (int i = 0; i < sc; ++i)
                    thanhtien += double.Parse(dgrNhapThuoc.Rows[i].Cells["cThanhTien"].Value.ToString());

                var b = kiemtrasl(txtMaThuoc.Text, Convert.ToInt32(txtSL.Text));
                if (!b)
                {
                    DataGridViewRow row = new DataGridViewRow(); //Khai báo row
                                                                 //Thêm dữ liệu vào từng dòng trong datagridview
                    dgrNhapThuoc.Rows.Add(txtMaThuoc.Text, txtTenThuoc.Text, txtLo.Text, dtHanDung.Value.ToString("dd/MM/yyyy"), txtSL.Text, txtDonGia.Text, thanhtien);
                }

                


                dgrThongTinThuoc.Visible = false;





            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            }
        }

        private void dgrNCCTT_Click(object sender, EventArgs e)
        {


            txtMaNCC.Text = dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString();
            txtTenNCC.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();
            dgrNCCTT.Visible = false;




        }

        private void dgrNCCTT_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void dgrNCCTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaNCC.Text = dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString();
            txtTenNCC.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();
            dgrNCCTT.Visible = false;
        }

        private void dgrCapNhatPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSoHoaDon.Text = dgrDSThuocNhaCungCap.CurrentRow.Cells["cMaHD"].Value.ToString();
            txtMaPhieuCNP.Text = dgrDSThuocNhaCungCap.CurrentRow.Cells["cMaNCC"].Value.ToString();
            txtMaPhieu_HD.Text = dgrDSThuocNhaCungCap.CurrentRow.Cells["cMaPhieuNhapKhoNCC"].Value.ToString();
            txtMaNhaCungCapCNP.Text = dgrDSThuocNhaCungCap.CurrentRow.Cells["cNCC"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgrNCCTT.Visible = false;
        }

       

        private void tabNhapThuoc_Click(object sender, EventArgs e)
        {

        }

        private void FrmNhapThuoc_Load(object sender, EventArgs e)
        {
            dgrNCCTT.Visible = false;
        }

        private void dgrThongTinThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
        }

        private void txtTenThuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaThuoc_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void xFilteg2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenThuoc_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void txtTenThuoc_Enter(object sender, EventArgs e)
        {
            //txtTenThuoc.xActive = true;
            //ev.Qtxt_Enter(sender, e);
            //dgrThongTinThuoc.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            

            if (txtMaThuoc.Text.Trim() != "")
            {
                double ThanhTien = (double.Parse(txtDonGia.Text) * double.Parse(txtSL.Text));


                int sc = dgrNhapThuoc.Rows.Count;
                double thanhtien = ThanhTien;
                for (int i = 0; i < sc; ++i)
                    thanhtien += double.Parse(dgrNhapThuoc.Rows[i].Cells["cThanhTien"].Value.ToString());

                var b = kiemtrasl(txtMaThuoc.Text, Convert.ToInt32(txtSL.Text));
                if (!b)
                {
                    DataGridViewRow row = new DataGridViewRow(); //Khai báo row
                                                                 //Thêm dữ liệu vào từng dòng trong datagridview
                    dgrNhapThuoc.Rows.Add(txtMaThuoc.Text, txtTenThuoc.Text, txtLo.Text, dtHanDung.Value.ToString("dd/MM/yyyy"), txtSL.Text, txtDonGia.Text, thanhtien);
                }

                


                dgrThongTinThuoc.Visible = false;





            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            }
        }
 

        private void save_excel()
        {


            string connectionString = "server=.;database = KHODUOC ; uid=sa;pwd=123";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                for (int i = 0; i < dgrNhapThuoc.Rows.Count; i++)
                {


                    using (SqlCommand cmd = new SqlCommand("INSERT INTO DUOC_KC_NHAPKHO_NHAPNHACUNGCAP (MaThuoc) VALUES (@MaThuoc)", connection))

                    {
                        if (dgrNhapThuoc.Rows[i].Cells["cMaThuoc"].Value.ToString() != "" && dgrNhapThuoc.Rows[i].Cells["cTenThuoc"].Value.ToString() != "")
                        {
                            cmd.Parameters.AddWithValue("@MaThuoc", dgrNhapThuoc.Rows[i].Cells[0].Value); // Assuming Column1 corresponds to the first column in your DataGridView

                            cmd.ExecuteNonQuery();
                            ev.QFrmThongBao("Đã tạo mới thành công");
                        }
                        else
                            ev.QFrmThongBaoError("Thiếu thông tin");

                    }
                }
            }

        }
        private void SaveNCC()
        {

            msql = "INSERT INTO [dbo].[tabMANGUOIBAN]" +
           "([MANGUOIBAN]" +
           ",[TENNGUOIBAN])" +
     "VALUES('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "')";


            DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
            //dgrThongTinThuoc.AutoGenerateColumns = false;
            //dgrThongTinThuoc.DataSource = tb;
        }



        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim() != "" && txtSoHoaDon.Text.Trim() != "" && txtMaThuoc.Text.Trim() != "" && txtTenThuoc.Text.Trim() != "" && txtSL.Text.Trim() != "" && txtLo.Text.Trim() != "" && txtMaNCC.Text.Trim() != "" && txtTenNCC.Text.Trim() != "")
            {
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé."))
                {
                   
                    save_excel();
                    //SaveThuoc();
                    SaveNCC();
                    ev.QFrmThongBao("Đã lưu thành công.");
                    ResetDataGridViewvaText();
                    this.dgrNhapThuoc.Rows.Clear();
                    LoadTheoTim();
                }
                else
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé.");
            }
            //else
            //    ev.QFrmThongBaoError("Vui lòng điền đủ thông tin.");
        }



        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim() != "" && txtSoHoaDon.Text.Trim() != "" && txtMaThuoc.Text.Trim() != "" && txtTenThuoc.Text.Trim() != "" && txtSL.Text.Trim() != "" && txtLo.Text.Trim() != "" && txtMaNCC.Text.Trim() != "" && txtTenNCC.Text.Trim() != "")
            {
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé."))
                {
                    //SaveThuoc();
                    save_excel();
                    ev.QFrmThongBao("Đã lưu thành công.");
                    ResetDataGridViewvaText();
                    this.dgrNhapThuoc.Rows.Clear();
                    LoadTheoTim();
                }
                else
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé.");
            }
            //    else
            //        ev.QFrmThongBaoError("Vui lòng điền đủ thông tin.");
        }


        private void btnLuuSua_Click_1(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim() != "" )
            {
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé."))
                {
                    
                    nhapthuoc();
                    NhaCungCap_hopdongthau();

                    ev.QFrmThongBao("Đã lưu thành công.");
                    ResetDataGridViewvaText();
                    this.dgrNhapThuoc.Rows.Clear();
                    LoadTheoTim();
                }
                else
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé.");
            }            //else
            //    ev.QFrmThongBaoError("Vui lòng điền đủ thông tin.");
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim()!=""&&txtTenNCC.Text.Trim()!=""&&txtHopDongThau.Text.Trim()!="")
            {
if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé."))
                {
                   
                    nhapthuoc();
                NhaCungCap_hopdongthau();

                //ev.QFrmThongBao("Đã lưu thành công.");
                //ResetDataGridViewvaText();
                //this.dgrNhapThuoc.Rows.Clear();
                //LoadTheoTim();
            }
                else
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé.");

                ev.QFrmThongBao("Đã lưu thành công");

            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng điền đủ thông tin!");


            }


        }

        private void btnTaoMoi_Click_1(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn muốn tạo mới phiếu không?"))
            {
                TaoMoi();
                ev.QFrmThongBao("Đã tạo mới thành công");
            }
        }

       

        private void btnThem_Click_2(object sender, EventArgs e)
        {
            txtMaPhieu.Text = CreateAutoIDNKNCC();
  


            if (txtMaThuoc.Text.Trim() != "")
            {


                    double ThanhTien = double.Parse(txtDonGia.Text) * double.Parse(txtDonGia.Text);


                    int sc = dgrNhapThuoc.Rows.Count;
                    double thanhtien = ThanhTien;
                    for (int i = 0; i < sc; ++i)
                        thanhtien += double.Parse(dgrNhapThuoc.Rows[i].Cells["cThanhTien"].Value.ToString());

                    var b = kiemtrasl(txtMaThuoc.Text, Convert.ToInt32(txtSL.Text));
                    if (!b)
                    {
                        DataGridViewRow row = new DataGridViewRow(); //Khai báo row
                                                                     //Thêm dữ liệu vào từng dòng trong datagridview
                        dgrNhapThuoc.Rows.Add(txtMaThuoc.Text, txtTenThuoc.Text, txtLo.Text, dtHanDung.Value.ToString("dd/MM/yyyy"), txtSL.Text, txtDonGia.Text, thanhtien);
                    }

                   

                    dgrThongTinThuoc.Visible = false;



                

            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application xlapp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
            Microsoft.Office.Interop.Excel.Range xlRange = null;
            int xlRow;
            string filename;

            try
            {
                // Set the default file path on the D drive
                string dDrivePath = @"C:\Users\Admin\Documents\DanhSachThuoc"; // Change this to the desired folder on the D drive
                string defaultFileName = "YourExcelFile.xlsx"; // Change this to the desired Excel file name
                string defaultFilePath = Path.Combine(dDrivePath, defaultFileName);

                // You can use the default file path directly or show a file dialog to choose the file
                openFile.Filter = "Excel Office|*.xls; *xlsx";
                openFile.FileName = defaultFileName; // Set the default file name in the file dialog
                openFile.InitialDirectory = dDrivePath; // Set the initial directory in the file dialog
                openFile.ShowDialog();
                filename = string.IsNullOrEmpty(openFile.FileName) ? defaultFilePath : openFile.FileName;

                if (!string.IsNullOrEmpty(filename))
                {
                    xlapp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkbook = xlapp.Workbooks.Open(filename);
                    xlWorksheet = xlWorkbook.Worksheets["sheet1"];
                    xlRange = xlWorksheet.UsedRange;

                    for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                    {
                        if (xlRange.Cells[xlRow, 1].Text != "")
                        {
                            dgrNhapThuoc.Rows.Add(
                                xlRange.Cells[xlRow, 1].Text,
                                xlRange.Cells[xlRow, 2].Text,
                                xlRange.Cells[xlRow, 3].Text,
                                xlRange.Cells[xlRow, 4].Text,
                                xlRange.Cells[xlRow, 5].Text,
                                xlRange.Cells[xlRow, 6].Text,
                                xlRange.Cells[xlRow, 7].Text,
                                xlRange.Cells[xlRow, 8].Text,
                                xlRange.Cells[xlRow, 9].Text
                            );
                        }
                    }
                }
                else
                {
                    ev.QFrmThongBao_YesNo("Lỗi");
                }
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                Console.WriteLine($"Excel Exception: {ex.Message}");
                ev.QFrmThongBao_YesNo("Lỗi khi mở tệp Excel. Vui lòng kiểm tra xem tệp có tồn tại không.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ev.QFrmThongBao_YesNo("Lỗi không xác định. Vui lòng thử lại hoặc liên hệ với người quản trị hệ thống.");
            }
            finally
            {
                if (xlWorkbook != null) xlWorkbook.Close();
                if (xlapp != null) xlapp.Quit();
            }

            txtMaPhieu.Text = CreateAutoIDNKNCC();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
              double thanhTienTotal = 0.0;

                for (int i = 0; i < dgrNhapThuoc.Rows.Count; i++)
                {
                    if (double.TryParse(dgrNhapThuoc.Rows[i].Cells["cThanhTien"].Value.ToString(), out double thanhTien))
                    {
                        thanhTienTotal += thanhTien;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing cThanhTien value at row {i}");
                    }
                }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé."))
            {
               

                NhaCungCap_hopdongthau();
                SaveNCC();
                ev.QFrmThongBao("Đã lưu thành công.");
                ResetDataGridViewvaText();
                this.dgrNhapThuoc.Rows.Clear();
                LoadTheoTim();
            }
            else
                ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé.");
        }
        void nhapthuoc()
        {

            string connectionString = "server=.;database=KHODUOC;uid=sa;pwd=123";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                for (int i = 0; i < dgrNhapThuoc.Rows.Count; i++)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO DUOC_KC_NHAPKHO_NHAPNHACUNGCAP (MaThuoc, TenThuoc,DVT,SoLo, HSD, SoLuong, DonGia, ThanhTien, MaThuocNhaCungCap, MaPhieuNhapKhoNCC,DonViBan,SOHD,NgayTao,NgayTaoHD,NgayNhap) VALUES (@MaThuoc, @TenThuoc,@DVT, @SoLo, @HSD, @SoLuong ,@DonGia, @ThanhTien, @MaThuocNhaCungCap, @MP,@DonViBan,@SoHD,@NgayTao,@NgayTaoHD,@NgayNhap)", connection))
                    {
                        using (SqlCommand cmd1 = new SqlCommand("UPDATE DUOC_KC_NHAPKHO_NHAPNHACUNGCAP SET MaThuoc = REPLACE(MaThuoc, ' ', '') WHERE MaPhieuNhapKhoNCC = @MP;)", connection))
                        
                        if (!string.IsNullOrWhiteSpace(txtMaPhieu.Text))
                        {
                            object cellValue = dgrNhapThuoc.Rows[i].Cells[0].Value;

                            if (cellValue != null)
                            {
                                string maThuocValue = cellValue.ToString().Trim().Replace(" ", "");
                                cmd.Parameters.AddWithValue("@MaThuoc", maThuocValue);                            //cmd.Parameters.AddWithValue("@MaThuoc", dgrNhapThuoc.Rows[i].Cells[0].Value.ToString().Trim());
                                cmd.Parameters.AddWithValue("@TenThuoc", dgrNhapThuoc.Rows[i].Cells[1].Value.ToString().Trim());
                                    cmd.Parameters.AddWithValue("@DVT", dgrNhapThuoc.Rows[i].Cells["cDVB"].Value.ToString().Trim());
                                    cmd.Parameters.AddWithValue("@SoLo", dgrNhapThuoc.Rows[i].Cells[2].Value.ToString().Trim());
                                cmd.Parameters.AddWithValue("@HSD", dgrNhapThuoc.Rows[i].Cells["cHanDung"].Value.ToString().Trim());
                                    cmd.Parameters.AddWithValue("@SoLuong", dgrNhapThuoc.Rows[i].Cells[4].Value.ToString().Trim());
                                cmd.Parameters.AddWithValue("@DonGia", dgrNhapThuoc.Rows[i].Cells[5].Value.ToString().Trim());
                                cmd.Parameters.AddWithValue("@ThanhTien", dgrNhapThuoc.Rows[i].Cells[6].Value.ToString().Trim());
                                cmd.Parameters.AddWithValue("@MaThuocNhaCungCap", dgrNhapThuoc.Rows[i].Cells["cMaThuocNCC"].Value.ToString().Trim());
                                    cmd.Parameters.AddWithValue("@MP", txtMaPhieu.Text.Trim());
                                    cmd.Parameters.AddWithValue("@DonViBan", txtMaNCC.Text.Trim());
                                    cmd.Parameters.AddWithValue("@SOHD", txtSoHoaDon.Text.Trim());
                                    cmd.Parameters.AddWithValue("@NgayTao", Convert.ToDateTime(dtNgayTao.Value.ToString("dd/MM/yyyy")));
                                    cmd.Parameters.AddWithValue("@NgayTaoHD", Convert.ToDateTime(dtNgayTaoHĐ.Value.ToString("dd/MM/yyyy")));
                                    cmd.Parameters.AddWithValue("@NgayNhap", Convert.ToDateTime(dtNgayTaoHĐ.Value.ToString("dd/MM/yyyy")));

                                    cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Handle the case where txtMaPhieu.Text is empty
                            ev.QFrmThongBaoError("Thiếu thông tin");
                        }
                    }
                
                }
            }
        }
        void NhaCungCap_hopdongthau()
        {




            string connectionString = "server=.;database=KHODUOC;uid=sa;pwd=123";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                for (int i = 0; i < dgrNhapThuoc.Rows.Count; i++)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[tabDanhMucThuoc]([MaThuoc],[TenThuoc],[MANGUOIBAN],[MaHopDongThau],[DonViSuDung],[KyHieuMauHD],[KyHieuHD],[SOHD],[SoLuongKho],[DonGia],[IDQuyCach],[KhoDuoc],[IDLOAITHUOC],[MaPhieuNhapKhoNCC],[NgayNhapD],[MaThuocNhaCungCap],[IDMaNhom]) VALUES(@MaThuoc,@TenThuoc,@MANGUOIBAN,@MaHopDongThau,@DonViSuDung,@KyHieuMauHD,@KyHieuHD,@SOHD,@SoLuong,@DonGia,@IDQuyCach,@KhoDuoc,@IDLOAITHUOC,@MP,@NgayNhap,@MaThuocNhapNhaCungCap,@MaNhom)", connection))
                    {
                            if (!string.IsNullOrWhiteSpace(txtMaPhieu.Text))
                            {
                                object cellValue = dgrNhapThuoc.Rows[i].Cells["cMaThuoc"].Value;

                            if (cellValue != null)
                                {
                                    string maThuocValue = cellValue.ToString().Trim().Replace(" ", "");
                                    cmd.Parameters.AddWithValue("@MaThuoc", maThuocValue);                           
                                    cmd.Parameters.AddWithValue("@TenThuoc", dgrNhapThuoc.Rows[i].Cells[1].Value.ToString().Trim());
                                    cmd.Parameters.AddWithValue("@MANGUOIBAN", txtMaNCC.Text.Trim());
                                cmd.Parameters.AddWithValue("@MaHopDongThau", txtHopDongThau.Text.Trim());
                                cmd.Parameters.AddWithValue("@DonViSuDung", dgrNhapThuoc.Rows[i].Cells["cDVB"].Value.ToString().Trim());
                                cmd.Parameters.AddWithValue("@KyHieuMauHD", txtKyHieuMauHD.Text.Trim());
                                cmd.Parameters.AddWithValue("@KyHieuHD", txtKyHieuHD.Text.Trim());
                                cmd.Parameters.AddWithValue("@SOHD", txtSoHoaDon.Text.Trim());
                                cmd.Parameters.AddWithValue("@SoLuong", dgrNhapThuoc.Rows[i].Cells[4].Value);
                                cmd.Parameters.AddWithValue("@DonGia", dgrNhapThuoc.Rows[i].Cells[5].Value.ToString().Trim());
                                cmd.Parameters.AddWithValue("@IDQuyCach", cboQuyCach.SelectedValue.ToString().Trim());
                                cmd.Parameters.AddWithValue("@KhoDuoc", cboKhoDuoc.SelectedValue.ToString().Trim());
                                cmd.Parameters.AddWithValue("@IDLOAITHUOC", cboLoai.SelectedValue.ToString().Trim());
                                cmd.Parameters.AddWithValue("@MP", txtMaPhieu.Text.Trim());
                                cmd.Parameters.AddWithValue("@MaThuocNhapNhaCungCap", dgrNhapThuoc.Rows[i].Cells["cMaThuocNCC"].Value.ToString().Trim());
                                cmd.Parameters.AddWithValue("@MaNhom", cboNhomThuoc.SelectedValue.ToString().Trim());
                                cmd.Parameters.AddWithValue("@NgayNhap", Convert.ToDateTime(dtNgayTao.Value.ToString("dd/MM/yyyy")));
                               



                                cmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                ev.QFrmThongBaoError("Thiếu thông tin");
                            }
                    }

                }
            }
        }


        private void button1_Click_3(object sender, EventArgs e)
        {
            nhapthuoc();

        }

        private void LoadDataIntoComboBox()
        {
           
            
        }
            void loadcombobox()
        {


            msql = "select * from [dbo].[DUOC_KC_HopDongThau] as a ,[dbo].[tabMANGUOIBAN] as b where a.MANGUOIBAN=b.MANGUOIBAN ";



            DataTable tb = comm.GetDataTable(mconnectstring, msql, "");

        }
        private void cboHopDongThau_SelectedIndexChanged(object sender, EventArgs e)
        {


            //if (cboHopDongThau.SelectedItem != null)
            //{
            //    txtKyHieuHD.Text = cboHopDongThau.SelectedItem?.ToString();
            //}
            //if (cboHopDongThau.SelectedItem != null)
            //{
            //    DataRowView selectedRow = (DataRowView)cboHopDongThau.SelectedItem;


            //    //txtMaNhaCungCapCNP.Text= selectedRow["MANGUOIBAN"].ToString();
            //    //txtKyHieuMauHD.Text = selectedRow["KiHieuMauHD"].ToString();
            //    //txtKyHieuHD.Text = selectedRow["KyHieuHoaDon"].ToString();
            //    //txtSoHoaDon.Text = selectedRow["SOHD"].ToString();
            //    //txtHopDongThau.Text = selectedRow["MaHopDongThau"].ToString();


            //}



            //txtKyHieuMauHD.Text = cboHopDongThau.SelectedItem?.ToString();
            //txtSoHoaDon.Text = cboHopDongThau.SelectedItem?.ToString();

        }

        private void dgrHopDongThau_Leave(object sender, EventArgs e)
        {
            //dgrNCCTT.Visible = true;
            //dgrThongTinThuoc.Visible = false;
        }
        void HopDongThau()
        {

            msql = "select *from [dbo].[DUOC_KC_HopDongThau]";
            DataTable tc = comm.GetDataTable(mconnectstring, msql, "");
            dgrHopDongThau.AutoGenerateColumns = false;
            dgrHopDongThau.DataSource = tc;
          




        }
        
        private void dgrNhapThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuu_Click_2(object sender, EventArgs e)
        {

        }

        private void txtHopDongThau_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNCC_Click(object sender, EventArgs e)
        {
            dgrNCCTT.Visible = true;
           
        }

        private void txtTenThuoc_DoubleClick(object sender, EventArgs e)
        {
            //txtTenThuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

    

        private void txtHopDongThau_DoubleClick(object sender, EventArgs e)
        {
            dgrHopDongThau.Visible = false;
        }

        private void txtHopDongThau_Enter(object sender, EventArgs e)
        {
            dgrHopDongThau.Visible = true;
        }

        private void dgrHopDongThau1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void txtTenNCC_DoubleClick(object sender, EventArgs e)
        {
            dgrNCCTT.Visible = false;
        }

        private void dgrNCCTT_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                txtMaNCC.Text = dgrNCCTT.CurrentRow.Cells["cMaNCCTT1"].Value.ToString();
                txtTenNCC.Text = dgrNCCTT.CurrentRow.Cells["cTenNhaCCTT1"].Value.ToString();
                dgrNCCTT.Visible = false;

            
        }

        private void dgrHopDongThau_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtHopDongThau.Text = dgrHopDongThau.CurrentRow.Cells["cMaHopDong1"].Value.ToString();
            txtSoHoaDon.Text = dgrHopDongThau.CurrentRow.Cells["cSoHD1"].Value.ToString();
            txtKyHieuHD.Text = dgrHopDongThau.CurrentRow.Cells["cKyHieuHD1"].Value.ToString();
            txtKyHieuMauHD.Text = dgrHopDongThau.CurrentRow.Cells["cKyHieuMauHD1"].Value.ToString();
            dgrHopDongThau.Visible = false;

        }

        private void txtHopDongThau_Click_1(object sender, EventArgs e)
        {
            dgrHopDongThau.Visible = true;
        }

        private void dgrCapNhatPhieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgrDSThuocNhaCungCap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

         
            if (e.RowIndex == -1)
                return;
            if (dgrDSThuocNhaCungCap["cPrint1", e.RowIndex] == dgrDSThuocNhaCungCap.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn muốn in phiếu nhập " + dgrDSThuocNhaCungCap.CurrentRow.Cells["cMaPhieuNhapKhoNCC"].Value.ToString() + " này không ?"))
                {

                    R = dgrDSThuocNhaCungCap.CurrentRow.Cells["cMaPhieuNhapKhoNCC"].Value.ToString();
                    FrmRPNhapThuocNhaCungCap frm = new FrmRPNhapThuocNhaCungCap();
                    frm.ShowDialog();



                }
            }


          
        }
    }
}