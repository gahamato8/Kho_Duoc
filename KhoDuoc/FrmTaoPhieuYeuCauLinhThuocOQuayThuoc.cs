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
using DocumentFormat.OpenXml.Spreadsheet;
using VBSQLHelper;

namespace KhoDuoc
{
    public partial class FrmTaoPhieuYeuCauLinhThuocOQuayThuoc : Form
    {
        
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public static string maphieuyeucau;
        public static string maphieuxuatkho;
        public static bool close;

        private FrmTongHop frmTongHop;
        public FrmTaoPhieuYeuCauLinhThuocOQuayThuoc()
        {
            InitializeComponent();
            LoadData();
            LoadThongTinThuoc();
           txtNguoiLap.Text= FrmDangNhap.tendn;

            this.frmTongHop = frmTongHop;
            dgrThongTinThuoc.Font = new System.Drawing.Font("Times New Roman", 15);
            dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Font = new System.Drawing.Font("Times New Roman", 15);
        }
        //public static string MaPhieuYeuCau; // Khai báo public cho biến A để sử trong FrmTaoPhieuYeuCauLinhThuocOQuayThuoc



        //Load Data
        private void LoadData()
        {
            //cbo Chọn Loại
            msql = "SELECT* FROM[dbo].[tabNhomThuoc]";
            DataTable loai = comm.GetDataTable(mconnectstring, msql, "tabNhomThuoc");
            cboChonLoai.DataSource = loai.Copy();
            cboChonLoai.DisplayMember = "TenNhom";
            cboChonLoai.ValueMember = "TenNhom";
            cboChonLoai.CustomAlignment = new string[] { "l", "l" };
            cboChonLoai.CustomColumnStyle = new string[] { "t", "t" };


            //cbo Phân Loại
            msql = "SELECT* FROM[dbo].[tabLoaithuoc]";
            DataTable phanloai = comm.GetDataTable(mconnectstring, msql, "tabLoaithuoc");
            cboPhanLoai.DataSource = phanloai.Copy();
            cboPhanLoai.DisplayMember = "TENLOAITHUOC";
            cboPhanLoai.ValueMember = "TENLOAITHUOC";
            cboPhanLoai.CustomAlignment = new string[] { "l", "l" };
            cboPhanLoai.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi Gửi Yêu Cầu
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_DANHMUCKHODUOC]";
            DataTable kc = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");
            cboNoiGuiYeuCau.DataSource = kc.Copy();
            cboNoiGuiYeuCau.DisplayMember = "TenKhoDuoc";
            cboNoiGuiYeuCau.ValueMember = "TenKhoDuoc";
            cboNoiGuiYeuCau.CustomAlignment = new string[] { "l", "l" };
            cboNoiGuiYeuCau.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi Nhận Yêu Cầu
            cboNoiNhanYeuCau.DataSource = kc.Copy();
            cboNoiNhanYeuCau.DisplayMember = "TenKhoDuoc";
            cboNoiNhanYeuCau.ValueMember = "TenKhoDuoc";
            cboNoiNhanYeuCau.CustomAlignment = new string[] { "l", "l" };
            cboNoiNhanYeuCau.CustomColumnStyle = new string[] { "t", "t" };

            

            
        }
        private void LoadData1()
        {
            var tb = SQLHelper.ExecQueryDataAsDataTable("select [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC789]('"+Convert.ToDateTime(dtNgayLap.Value.ToString("yyyy-MM-dd"))+"')");
            dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.DataSource = tb;

            var tb1 = SQLHelper.ExecQueryDataAsDataTable("select[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC5]('"+ Convert.ToDateTime(dtNgayLap.Value.ToString("yyyy-MM-dd")) + "')");
            dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.DataSource = tb1;

            
        }

        //Đánh stt
        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc);
        }
        // Tương tác




        private void cboPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTaoPhieuYeuCauLinhThuocOQuayThuoc_Load(object sender, EventArgs e)
        {
           
        }

        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc);
        }


        public string CreateAutoIDPhieuXuatKho()
        {
            return SQLHelper.ExecQuerySacalar($@" select [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC789]('" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "')").ToString();
            //return SQLHelper.ExecQuerySacalar($@"select [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC789]('2023-06-27')").ToString();
        }
        public string CreateAutoIDPhieuYeuCau()
        {
            return SQLHelper.ExecQuerySacalar($@" select [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC5]('" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "')").ToString();
            //return SQLHelper.ExecQuerySacalar($@"select[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC5]('2023-06-27')").ToString();
        }


        private void txtNguoiLap_Enter(object sender, EventArgs e)
        {
            txtNguoiLap.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNguoiLap_Leave(object sender, EventArgs e)
        {
            txtNguoiLap.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNguoiLap_KeyPress(object sender, KeyPressEventArgs e)
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
            ev.Qtxt_Enter(sender, e);
        }
        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTaoPhieuYeuCauLinh);
        }
        private void txtMaThuoc_Leave(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenThuoc);
        }

        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);

        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDVT);

        }
        private void txtPhanLoai_Leave(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtPhanLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDVT);
        }
        private void txtĐVT_Enter(object sender, EventArgs e)
        {
            txtDVT.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
        }

        private void txtĐVT_Leave(object sender, EventArgs e)
        {
            txtDVT.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtĐVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSL);
        }

        private void txtSL_Enter(object sender, EventArgs e)
        {
            txtSL.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSL_Leave(object sender, EventArgs e)
        {
            txtSL.xActive = false;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnThem);
        }
        private void txtNguoi_Lap_Leave(object sender, EventArgs e)
        {
            txtNguoiLap.xActive = false;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = false;
        }

        private void cboNoiNhanYeuCau_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenThuoc_TextChanged(object sender, EventArgs e)
        {

        }




       

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMaPhieu.Text = CreateAutoIDPhieuYeuCau();
            txtMaPhieuXuatKho.Text = CreateAutoIDPhieuXuatKho();

            if (txtMaThuoc.Text.Trim() != "" && txtTenThuoc.Text.Trim() != "" && txtDVT.Text.Trim() != "" && txtLo.Text.Trim() !="" && txtMaLo.Text.Trim() != "" && txtSL.Text.Trim() != "")
            {

               

                var b = kiemtrasl(txtMaThuoc.Text,Convert.ToInt32(txtSL.Text));
                if (!b)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Add(txtMaThuoc.Text, txtTenThuoc.Text, txtDVT.Text, txtLo.Text, txtMaLo.Text, txtSL.Text, txtGhiChuChiTiet.Text);

                    var affectRow = SQLHelper.ExecQueryNonData(msql, new { MaPhieuNhapKho = txtMaPhieu.Text });
                    // fix insert sql injection
                    if (affectRow > 0)
                    {
                        // Insert success
                        txtMaPhieu.Text = CreateAutoIDPhieuYeuCau();
                        txtMaPhieuXuatKho.Text = CreateAutoIDPhieuXuatKho();
                    }
                    LoadSLTonKhoChan();
                    LoadSLTonKhoLe();
                    TinhSoNgayConLai();
                }
            }


           else if (int.TryParse(txtSL.Text, out int SL))
            {
                // Use the variable SL here (conversion successful)
                string cellValue1 = dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.CurrentRow.Cells["cSLYC"].Value.ToString();

                string cellValue = dgrThongTinThuoc.CurrentRow.Cells["cSoLuong"].Value.ToString();
                int cellValueInt;
                int cellValueInt1;

                if (int.TryParse(cellValue, out cellValueInt)&& int.TryParse(cellValue1, out cellValueInt1))
                {
                    if (SL > cellValueInt)
                    {

                        foreach (DataGridViewRow row in dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows)
                        {
                            if (row.Cells["cSLYC"].Value != null)
                            {
                                int rowCellValue;
                                if (int.TryParse(row.Cells["cSLYC"].Value.ToString(), out rowCellValue) && rowCellValue == SL)
                                {
                                    dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Remove(row);
                                    break; 
                                }
                            }
                        }
                        ev.QFrmThongBaoError("Số lượng yêu cầu vượt quá số lượng trong kho");

                    }
                    else if (cellValueInt1 > cellValueInt)
                    {
                        ev.QFrmThongBaoError("Số lượng yêu cầu vượt quá số lượng trong kho");

                        // Remove the current row from dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc
                        dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Remove(dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.CurrentRow);
                    


                } 
                }
          
            }

            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
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
                    dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Clear();
                }
            }
            else
            {
                //int numberOfDays = (int)difference.TotalDays;
                //ev.QFrmThongBao("Số ngày còn lại: " + numberOfDays + " ngày.");

            }
        }
        bool kiemtrasl(String mathuoc, int sl)
        {
            if (dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.RowCount > 0)
            {
                foreach (DataGridViewRow item in dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows)
                {
                    String currentCode = item.Cells[0].Value.ToString();
                    if (mathuoc == currentCode)
                    {
                        //tồn tại
                        int b = Convert.ToInt32(item.Cells["cSLYC"].Value) + sl;
                        item.Cells["cSLYC"].Value = b.ToString();
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
      

        private void txtTenThuoc_Enter_1(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
        }

        private void txtMaThuoc_Enter_1(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
        }
        private void txtSL_Enter_1(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
        }

        private void txtDVT_Enter(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = true;
        }
        //chưa làm
        private void LoadSLTonKhoChan()
        {
            //@SoLuongNhapVao, @SoLuongYeuCauXuat, @SoLuongHuBe, @SoLuongHoanTra, @MaThuoc, @LoNhapVao, @HanDungNhapVao, @MaPhieuNhap, @MaPhieuYeuCau, @TrangThai, @DieuKien 
            //msql = "exec FiFoKhoChan '','','','','" + dgrThongTinThuoc.CurrentRow.Cells["cMaThuocT"].Value.ToString() + "','"+ txtLo.Text+ "','','','" + txtMaPhieu.Text+"',0,2";
            msql = " exec TongTonChan '" + dgrThongTinThuoc.CurrentRow.Cells["cMaThuocT"].Value.ToString() + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "TonKhoChan");
            dgrKhoChan.AutoGenerateColumns = false;
            dgrKhoChan.DataSource = tb;
            txtSLTonKhoPhat.Text = dgrKhoChan.CurrentRow.Cells["cTonKhoPhat"].Value.ToString();
           

        }
        //chưa làm 
        private void LoadSLTonKhoLe()
        {
            msql = " exec TongTon '" + dgrThongTinThuoc.CurrentRow.Cells["cMaThuocT"].Value.ToString() + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "TonKhoLe");
            dgrKhoLe.AutoGenerateColumns = false;
            dgrKhoLe.DataSource = tb;
            txtSLTonKhoLinh.Text = dgrKhoLe.CurrentRow.Cells["CTonKhoLinh"].Value.ToString();
        }

        private void txtGhiChuChiTiet_Enter(object sender, EventArgs e)
        {
            dgrThongTinThuoc.Visible = false;
        }

        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txtNguoiLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadThongTinThuoc()
        {
            msql = "select * from [dbo].[DUOC_KC_Lo2023] as a, [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] as b,[dbo].[tabDanhMucThuoc] c,[dbo].[tabLoaithuoc] as d  ,[dbo].[tabNhomThuoc] as e where a.MaPhieuNhapKho = b.MaPhieuNhapKho and a.MaThuoc=c.MaThuoc and d.IDLOAITHUOC=c.IDLOAITHUOC and e.TenTat=b.Loai";
 
            //msql = "exec thongtinthuoc '','',''";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc LEFT JOIN[dbo].DUOC_KC_Lo2023 ON tabDanhMucThuoc.MaThuoc = DUOC_KC_Lo2023.MaThuoc where tabDanhMucThuoc.MaThuoc = DUOC_KC_Lo2023.MaThuoc");
            dgrThongTinThuoc.AutoGenerateColumns = false;
            dgrThongTinThuoc.DataSource = tb;
        }
        //Lưu các thông tin của phiếu nhập
        private void SaveThongTinPhieu()
        {
                    msql = "INSERT INTO [dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] ([NguoiLap],[PhanLoai],[Loai],[KhoDuocNoiGuiYeuCau],[GhiChu],[NgayLap],[NgayLinh],[MaPhieuYeuCau],[KhoDuocNoiNhanYeuCau],[MaPhieuXuatKho],[TrangThai])" +
                        "VALUES(N'"+ txtNguoiLap.Text+ "',N'"+ cboPhanLoai.SelectedValue+ "',N'" + cboChonLoai.SelectedValue + "',N'" + cboNoiGuiYeuCau.SelectedValue + "',N'" + txtGhiChu.Text + "','" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd")+"','" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd")+"',N'" + txtMaPhieu.Text + "',N'"+ cboNoiNhanYeuCau.SelectedValue + "',N'" + txtMaPhieuXuatKho.Text + "',0) " +
                        "";
                    comm.RunSQL(mconnectstring, msql);
        }
        private void SaveThongTinThuoc()
        {
            if (txtMaThuoc.Text.Trim() != "")
            {
                for (int i = 0; i < dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Count; i++)
                {
                    msql = "INSERT INTO [dbo].[DUOC_KC_THONGTINTHUOC_PHIEUYEUCAULINHTHUOCQUAYTHUOC]([MaThuoc],[TenThuoc_VatTu],[DonVi],[SoLuongYeuCau],[GhiChu1],[MaPhieuYeuCau])" +
                        " VALUES(N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cMaThuocThem"].Value + "', N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cTenThuocVatTu"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cDonVi"].Value + "','" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cSLYC"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cGhi_Chu"].Value + "',N'" + txtMaPhieu.Text+"')";
                    comm.RunSQL(mconnectstring, msql);
                    //msql = "INSERT INTO [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] ([NguoiLap],[PhanLoai],[Loai],[KhoDuocNoiGuiYeuCau],[GhiChu],[NgayLap],[NgayLinh],[MaPhieuYeuCau],[KhoDuocNoiNhanYeuCau],[MaPhieuXuatKho],[TrangThai],[MaThuoc], [TenThuoc_VatTu], [DonVi], [SoLuongCap], [GhiChu]) VALUES (N'" + txtNguoiLap.Text + "',N'" + cboPhanLoai.SelectedValue + "',N'" + cboChonLoai.SelectedValue + "',N'" + cboNoiGuiYeuCau.SelectedValue + "',N'" + txtGhiChu.Text + "','" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "',N'" + txtMaPhieu.Text + "',N'" + cboNoiNhanYeuCau.SelectedValue + "',N'" + txtMaPhieuXuatKho.Text + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cMaThuocThem"].Value + "', N'"+ dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cTenThuocVatTu"].Value + "',N'"+ dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cDonVi"].Value + "','"+ dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cSLYC"].Value + "',N'"+ dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cGhi_Chu"].Value + "')";
                    //comm.RunSQL(mconnectstring, msql);
                }
            }

            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            txtMaThuoc.Focus();
        }
        private void SaveFull()
        {
            if (txtMaThuoc.Text.Trim() != "")
            {
                for (int i = 0; i < dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Count; i++)
                {
                    msql = "INSERT INTO [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] ([NguoiLap],[PhanLoai],[Loai],[KhoDuocNoiGuiYeuCau],[GhiChu],[NgayLap],[NgayLinh],[MaPhieuYeuCau],[KhoDuocNoiNhanYeuCau],[MaPhieuXuatKho],[TrangThai],[MaThuoc],[TenThuoc_VatTu],[DonVi],[Lo],[MaLo],[SoLuongYeuCau],[GhiChu1]) VALUES (N'" + txtNguoiLap.Text + "',N'" + cboPhanLoai.SelectedValue + "',N'" + cboChonLoai.SelectedValue + "',N'" + cboNoiGuiYeuCau.SelectedValue + "',N'" + txtGhiChu.Text + "','" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "',N'" + txtMaPhieu.Text + "',N'" + cboNoiNhanYeuCau.SelectedValue + "',N'" + txtMaPhieuXuatKho.Text + "',0,N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cMaThuocThem"].Value + "', N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cTenThuocVatTu"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cDonVi"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cLo1"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cMaLo1"].Value + "','" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cSLYC"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cGhi_Chu"].Value + "')";
                    comm.RunSQL(mconnectstring, msql);
                }
            }

            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            txtMaThuoc.Focus();
        }
        private void btnTaoPhieuYeuCauLinh_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text.Trim() != "" && txtTenThuoc.Text.Trim() != "" && txtDVT.Text.Trim() != "" && txtLo.Text.Trim() != "" && txtMaLo.Text.Trim() != "" && txtSL.Text.Trim() != "")
            {
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé!"))
                {
//tạo mã tự động cho phiếu và thuốc
                    SaveThongTinPhieu();
                    SaveThongTinThuoc();
                    LoadSLTonKhoChan();
                    LoadSLTonKhoLe();
                    SaveFull();
                    dgrThongTinThuoc.Visible = false;
                    ev.QFrmThongBao("Đã lưu thành công");
                }
                else
                {
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé!");
                }
            }
            else
                ev.QFrmThongBaoError("Thiếu thông tin");



            txtMaPhieu.Clear();
            txtMaPhieuXuatKho.Clear();
        }





        private void dgrThongTinThuoc_Click(object sender, EventArgs e)
        {
            LoadSLTonKhoChan();
            LoadSLTonKhoLe();
        }
        private void LoadFrmNhapTuNhaCungCap()
        {
            FrmTaoPhieuYeuCauLinhThuocOQuayThuoc frmNhapTuNhaCungCap = new FrmTaoPhieuYeuCauLinhThuocOQuayThuoc();
            frmTongHop.OpenChildFormInPanel(frmNhapTuNhaCungCap);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void dgrThongTinThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            txtMaThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cMaThuocT"].Value.ToString();
            txtTenThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cTenThuocT"].Value.ToString();
            txtDVT.Text = dgrThongTinThuoc.CurrentRow.Cells["cDVTT"].Value.ToString();
            txtLo.Text= dgrThongTinThuoc.CurrentRow.Cells["cLo"].Value.ToString();
            txtMaLo.Text= dgrThongTinThuoc.CurrentRow.Cells["cMaLo"].Value.ToString();
            dtHanDung.Text = dgrThongTinThuoc.CurrentRow.Cells["cHSD"].Value.ToString();
            cboPhanLoai.Text = dgrThongTinThuoc.CurrentRow.Cells["cPhanLoai"].Value.ToString();
            cboChonLoai.Text = dgrThongTinThuoc.CurrentRow.Cells["cLoaiThuoc"].Value.ToString();


            //txtKyHieuHD.Text = dgrNCCTT.CurrentRow.Cells["cKyHieuHD"].Value.ToString();
            //txtKyHieuMauHD.Text = dgrNCCTT.CurrentRow.Cells["cKyHieuMauHD"].Value.ToString();
            //txtSoHoaDon.Text = dgrNCCTT.CurrentRow.Cells["cSoHD"].Value.ToString();
            dgrThongTinThuoc.Visible = false;

           
        }
    } 
}
