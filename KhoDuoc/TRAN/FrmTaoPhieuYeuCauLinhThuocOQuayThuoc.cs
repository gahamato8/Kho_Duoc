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

        public FrmTaoPhieuYeuCauLinhThuocOQuayThuoc()
        {
            InitializeComponent();
            LoadData();
            
        }

        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTaoPhieuYeuCauLinh_Click(object sender, EventArgs e)
        {
                if (txtNguoiLap.Text.Trim() != "")
                {
                for (int i = 0; i < dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Count; i++)
                {
                    msql = "INSERT INTO [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC]" +
                  "([NguoiLap],[MaPhieuLinh],[Loai],[KhoDuocNoiGuiYeuCau])" +
                  "([GhiChu],[NgayLap],[NgayLinh],[PhanLoai],[KhoDuocNoiNhanYeuCau])" +
                  "([TrangThai],[TenThuoc_VatTu],[DonVi],[SoLuongTonKhoLinh])" +
                  "([SoLuongTonKhoPhat],[SoLuongYeuCau])" +
                  "VALUES(N'" + txtNguoiLap.Text + "',N'" + txtMaPhieu.Text + "',N'" + cboChonLoai.SelectedValue + "',N'" + cboNoiGuiYeuCau.SelectedValue + "',N'" + txtGhiChu.Text + "',N'" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "',N'" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "',N'" + cboPhanLoai.SelectedValue + "'," + "N'" + cboNoiNhanYeuCau.SelectedValue + "')" +
                  "'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells[0].Value + "', '" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells[1].Value + "','" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells[2].Value + "','" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells[3].Value + "','" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells[4].Value + "','" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells[5].Value + "'";
                    comm.RunSQL(mconnectstring, msql);
                    
                }    
                }
                else
                    ev.QFrmThongBaoError("Vui lòng nhập thông tin ");
            txtNguoiLap.Focus();

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        //Load Data
        private void LoadData()
        {
            msql = "SELECT * FROM[KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.AutoGenerateColumns = false;
            dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.DataSource = tb;
            dgrNhapPhieu.AutoGenerateColumns = false;
            dgrNhapPhieu.DataSource = tb;
            //cbo Chọn Loại
            cboChonLoai.DataSource = tb.Copy();
            cboChonLoai.DisplayMember = "Loai";
            cboChonLoai.ValueMember = "Loai";
            cboChonLoai.CustomAlignment = new string[] { "l", "l" };
            cboChonLoai.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi Gửi Yêu Cầu
            cboNoiGuiYeuCau.DataSource = tb.Copy();
            cboNoiGuiYeuCau.DisplayMember = "KhoDuocNoiGuiYeuCau";
            cboNoiGuiYeuCau.ValueMember = "KhoDuocNoiGuiYeuCau";
            cboNoiGuiYeuCau.CustomAlignment = new string[] { "l", "l" };
            cboNoiGuiYeuCau.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Phân Loại
            cboPhanLoai.DataSource = tb.Copy();
            cboPhanLoai.DisplayMember = "PhanLoai";
            cboPhanLoai.ValueMember = "PhanLoai";
            cboPhanLoai.CustomAlignment = new string[] { "l", "l" };
            cboPhanLoai.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi Nhận Yêu Cầu
            cboNoiNhanYeuCau.DataSource = tb.Copy();
            cboNoiNhanYeuCau.DisplayMember = "KhoDuocNoiNhanYeuCau";
            cboNoiNhanYeuCau.ValueMember = "KhoDuocNoiNhanYeuCau";
            cboNoiNhanYeuCau.CustomAlignment = new string[] { "l", "l" };
            cboNoiNhanYeuCau.CustomColumnStyle = new string[] { "t", "t" };
        }

        //Đánh stt
        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc);
        }
        // Tương tác
        

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
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboPhanLoai);
        }

        private void txtNguoiLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNguoiLap_Enter_1(object sender, EventArgs e)
        {
            txtGhiChu.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNguoiLap_Leave_1(object sender, EventArgs e)
        {
            txtGhiChu.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNguoiLap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGhiChu);
        }

        private void txtGhiChu_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTaoPhieuYeuCauLinh);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTaoPhieuYeuCauLinhThuocOQuayThuoc_Load(object sender, EventArgs e)
        {

        }

        private void dtNgayLap_ValueChanged(object sender, EventArgs e)
        {
            if (dtNgayLap.Value > DateTime.Now)
            {
                ev.QFrmThongBaoError("Ngày không hợp lệ. Vui lòng chọn lại ngày");
                dtNgayLap.Value = DateTime.Now;
                return;
            }
            else
                LoadData();
        }

        private void dtNgayLap_Leave(object sender, EventArgs e)
        {
            if (dtNgayLap.Value > DateTime.Now)
            {
                ev.QFrmThongBaoError("Ngày không hợp lệ. Vui lòng chọn lại ngày");
                dtNgayLap.Value = DateTime.Now;
                return;
            }
            else
                LoadData();
        }

        private void dtNgayLinh_ValueChanged(object sender, EventArgs e)
        {
            if (dtNgayLinh.Value > DateTime.Now)
            {
                ev.QFrmThongBaoError("Ngày không hợp lệ. Vui lòng chọn lại ngày");
                dtNgayLinh.Value = DateTime.Now;
                return;
            }
            else
                LoadData();
        }

        private void dtNgayLinh_Leave(object sender, EventArgs e)
        {
            if (dtNgayLinh.Value > DateTime.Now)
            {
                ev.QFrmThongBaoError("Ngày không hợp lệ. Vui lòng chọn lại ngày");
                dtNgayLinh.Value = DateTime.Now;
                return;
            }
            else
                LoadData();
        }

        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc);
        }
        

        public string CreateAutoID()
        {
            return SQLHelper.ExecQuerySacalar($@"SELECT CONCAT('PK', RIGHT(CONCAT('0000000000',ISNULL(right(max(MaPhieuLinh),10),0) + 1),10))
                                            FROM dbo.PHIEUYEUCAULINHTHUOCQUAYTHUOC where MaPhieuLinh like 'PK%'").ToString();
        }



            private void txtMaThuoc_Enter(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
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

        private void txtTenThuoc_Enter(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtĐVT);
        }

        private void txtĐVT_Enter(object sender, EventArgs e)
        {
            txtĐVT.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtĐVT_Leave(object sender, EventArgs e)
        {
            txtĐVT.xActive = false;
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
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnThem);
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

        private void dgrNhapPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTaoMaTuDong_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Text = CreateAutoID();
            if (txtMaPhieu.Text.Trim() != "")
            {
                msql = "INSERT INTO [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC]" +
              "([NguoiLap],[MaPhieuLinh],[Loai],[KhoDuocNoiGuiYeuCau],[GhiChu],[NgayLinh],[NgayLap],[PhanLoai],[KhoDuocNoiNhanYeuCau])" +
              "VALUES(N'" + txtNguoiLap.Text + "', N'" + txtMaPhieu.Text + "', N'" + cboChonLoai.SelectedValue + "', N'" + cboNoiGuiYeuCau.SelectedValue + "',N'" + txtGhiChu.Text + "','" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "', N'" + cboPhanLoai.SelectedValue + "',N'" + cboNoiNhanYeuCau.SelectedValue + "' )";
                comm.RunSQL(mconnectstring, msql);
                LoadData();


            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin ");
            txtMaPhieu.Focus();
            //, N'" + txtTenThuoc.Text + "', N'" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "', N'" + txtĐVT.Text + "', N'" + txtSL.Text + "'
            //,[NgayLap],[DonVi],[SoLuongYeuCau]
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
            if (txtTenThuoc.Text.Trim() != "")
            {

                msql = "INSERT INTO [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC]" +
              "([MaThuoc],[TenThuoc_VatTu],[PhanLoai],[NgayLap],[DonVi],[SoLuongYeuCau],[NguoiLap])" +
              "VALUES(N'" + txtMaThuoc.Text + "', N'" + txtTenThuoc.Text + "',N'" + txtPhanLoai.Text + "','" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "', N'" + txtĐVT.Text + "', N'" + txtSL.Text + "',N'" + txtNguoi_Lap.Text + "' )";
                comm.RunSQL(mconnectstring, msql);
                LoadData();


            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin ");
            txtTenThuoc.Focus();
            //, N'" + txtTenThuoc.Text + "', N'" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "', N'" + txtĐVT.Text + "', N'" + txtSL.Text + "'
            //,[NgayLap],[DonVi],[SoLuongYeuCau]

            //
        }
    }
}
