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
        

        public FrmTaoPhieuYeuCauLinhThuocOQuayThuoc()
        {
            InitializeComponent();
            LoadData();
            LoadThongTinThuoc();

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




        //private void demsl()
        //{
        //    for (int i = 0; i < dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.RowCount - 1; i++) //compare data
        //    {
        //        var Row = dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i];
        //        string abc = Row.Cells[3].Value.ToString() + Row.Cells[0].Value.ToString().ToUpper();

        //        for (int j = i + 1; j < dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.RowCount; j++)
        //        { 
        //            var Row8 = dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[j];
        //            string def = Row8.Cells[3].Value.ToString() + Row8.Cells[0].Value.ToString().ToUpper();

        //            if (abc == def)
        //            {
        //                Row.Cells[5].Value = (int)Row.Cells[5].Value + (int)Row8.Cells[5].Value;
        //                dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Remove(Row8);
        //                j--;
        //            }
        //        }
        //    }
        //}





        //    private void btnLuu_Click(object sender, EventArgs e)
        //    {
        //    if (txtMaThuoc.Text.Trim() != "")
        //    {
        //        for (int i = 0; i < dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Count; i++)
        //        {
        //            msql = "INSERT INTO [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC]" +
        //            "([MaPhieuXuatKho],[MaThuoc],[TenThuoc_VatTu],[PhanLoai],[NgayLap],[DonVi],[SoLuongYeuCau],[NguoiLap])" +
        //            " VALUES(N'"+txtMaPhieu.Text+"',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cMaThuoc"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cTenThuoc_VatTu"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cPhanLoai"].Value + "','" + Convert.ToDateTime(dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cNgayLap"].Value).ToString("yyyy-MM-dd") + "'" +
        //            ",N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cDVT"].Value + "','" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cSL"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cNguoiLap"].Value + "')";
        //            comm.RunSQL(mconnectstring, msql);
        //        }
        //    }

        //    else
        //        ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
        //    txtMaThuoc.Focus();
        //}

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMaPhieu.Text = CreateAutoIDPhieuYeuCau();
            txtMaPhieuXuatKho.Text = CreateAutoIDPhieuXuatKho();

            if (txtMaThuoc.Text.Trim() != "" && txtTenThuoc.Text.Trim() != "" && txtDVT.Text.Trim() != "" && txtLo.Text.Trim() !="" && txtMaLo.Text.Trim() != "" && txtSL.Text.Trim() != "")
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
                //    //demsl();
                //}
                LoadSLTonKhoChan();
                LoadSLTonKhoLe();
            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
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
            msql = "SELECT SUM(TTon) as Ton FROM Duoc_KC_SoLuongTon where MaThuoc = '" + dgrThongTinThuoc.CurrentRow.Cells["cMaThuocT"].Value.ToString() + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "TonKhoChan");
            dgrKhoChan.AutoGenerateColumns = false;
            dgrKhoChan.DataSource = tb;

            txtSLTonKhoPhat.Text = dgrKhoChan.CurrentRow.Cells[0].Value.ToString();
        }
        //chưa làm 
        private void LoadSLTonKhoLe()
        {
            msql = "SELECT SUM(TTon) as Ton FROM Duoc_KC_SoLuongTon where MaThuoc = 'AQUA00''" + dgrThongTinThuoc.CurrentRow.Cells["cMaThuocT"].Value.ToString() + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "TonKhoLe");
            dgrKhoChan.AutoGenerateColumns = false;
            dgrKhoChan.DataSource = tb;
            txtSLTonKhoLinh.Text = dgrKhoChan.CurrentRow.Cells[0].Value.ToString();
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
            msql = "SELECT* FROM tabDanhMucThuoc LEFT JOIN[dbo].DUOC_KC_Lo2023 ON tabDanhMucThuoc.MaThuoc = DUOC_KC_Lo2023.MaThuoc where tabDanhMucThuoc.MaThuoc = DUOC_KC_Lo2023.MaThuoc";
 
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
                    msql = "INSERT INTO [dbo].[DUOC_KC_THONGTINTHUOC_PHIEUYEUCAULINHTHUOCQUAYTHUOC]([MaThuoc],[TenThuoc_VatTu],[DonVi],[SoLuongYeuCau],[GhiChu1])" +
                        " VALUES(N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cMaThuocThem"].Value + "', N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cTenThuocVatTu"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cDonVi"].Value + "','" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cSLYC"].Value + "',N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cGhi_Chu"].Value + "')";
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
            if (txtMaThuoc.Text.Trim() != "" && txtTenThuoc.Text.Trim() != "" && txtDVT.Text.Trim() != "" && txtLo.Text.Trim() != "" && txtMaLo.Text.Trim() != "" && txtSL.Text.Trim() != "" && txtGhiChuChiTiet.Text.Trim() != "")
            {
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé! ^-^"))
                {

                    SaveThongTinPhieu();
                    SaveThongTinThuoc();
                    LoadSLTonKhoChan();
                    LoadSLTonKhoLe();
                    SaveFull();
                    ev.QFrmThongBao("Đã lưu thành công");
                }
                else
                {
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé! ^-^");
                }
            }
            else
                ev.QFrmThongBaoError("Thiếu thông tin");
            FrmPhieuYeuCauLinhThuocVatTu f = new FrmPhieuYeuCauLinhThuocVatTu();
            //MaPhieuYeuCau = dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.CurrentRow.Cells[5].Value.ToString(); // Lấy mã phiếu từ cột MaPhieuYeuCau cua dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc truyền vào biến a
            f.ShowDialog();
            this.Hide();
            //&& txtLo.Text.Trim() != ""
        }

        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrThongTinThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSLTonKhoChan();
            LoadSLTonKhoLe();
        }

        private void dgrThongTinThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    } 
}
