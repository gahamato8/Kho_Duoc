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
    public partial class FrmChiTietPhieuYeuCauLinhThuocOQuayThuoc : Form
    {

        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmChiTietPhieuYeuCauLinhThuocOQuayThuoc()
        {
            InitializeComponent();
            LoadDaTaChiTietPhieuXuatThuoc();
            LoadDaTaChiTietPhieuYeuCauLinhThuoc();      
        }

        public void LoadDaTaChiTietPhieuXuatThuoc()
        {
            msql = "SELECT DISTINCT a.MaPhieuYeuCau,a.NguoiLap,a.Loai,a.PhanLoai,a.NgayLinh,a.NgayLap,b.MaThuoc,b.TenThuoc,b.DVT,b.Lo,b.HanDung,c.SoLuongYeuCau,d.SoLuongCap,d.GhiChu,a.TrangThai FROM [DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]  as A, [DUOC_KC_Lo2023] as B,[dbo].[DUOC_KC_THONGTINTHUOC_PHIEUYEUCAULINHTHUOCQUAYTHUOC] as C ,DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT as D where A.TrangThai = 4 and A.MaPhieuYeuCau=C.MaPhieuYeuCau AND B.MaThuoc=C.MaThuoc and D.MaPhieuYeuCau=A.MaPhieuYeuCau and A.MaPhieuYeuCau = '" + FrmXuatThuoc.MaPhieuYeuCau + "' ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            dgrChiTietPhieu.AutoGenerateColumns = false;
            dgrChiTietPhieu.DataSource = tb;
            dgrChiTietPhieu.Visible = true;
            dgrChiTietPhieuYeuCauLinhThuocVatTu.Visible = false;
        }

        public void LoadDaTaChiTietPhieuYeuCauLinhThuoc()
        {
            msql = "SELECT DISTINCT a.MaPhieuYeuCau,a.NguoiLap,a.Loai,a.PhanLoai,a.NgayLinh,a.NgayLap,b.MaThuoc,b.TenThuoc,b.DVT,b.Lo,b.HanDung,c.SoLuongYeuCau,d.SoLuongCap,d.GhiChu,a.TrangThai FROM [DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]  as A, [DUOC_KC_Lo2023] as B,[dbo].[DUOC_KC_THONGTINTHUOC_PHIEUYEUCAULINHTHUOCQUAYTHUOC] as C ,DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT as D where A.TrangThai = 5 and A.MaPhieuYeuCau=C.MaPhieuYeuCau AND B.MaThuoc=C.MaThuoc and D.MaPhieuYeuCau=A.MaPhieuYeuCau and A.MaPhieuYeuCau = '" + FrmPhieuYeuCauLinhThuocVatTu.MaPhieuYeuCau + "' ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            dgrChiTietPhieuYeuCauLinhThuocVatTu.AutoGenerateColumns = false;
            dgrChiTietPhieuYeuCauLinhThuocVatTu.DataSource = tb;
            dgrChiTietPhieuYeuCauLinhThuocVatTu.Visible = true;
            dgrChiTietPhieu.Visible = false;
        }

        private void txtNguoiLap_Enter(object sender, EventArgs e)
        {
            txtNguoiLap.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrChiTietPhieu.Visible = true;
        }

        private void txtLoai_Enter(object sender, EventArgs e)
        {
            txtLoai.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrChiTietPhieu.Visible = true;
        }

        private void txtPhanLoai_Enter(object sender, EventArgs e)
        {
            txtPhanLoai.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrChiTietPhieu.Visible = true;
        }

        private void txtNguoiLap_Leave(object sender, EventArgs e)
        {
            txtNguoiLap.xActive = false;
            ev.Qtxt_Enter(sender, e);
            dgrChiTietPhieu.Visible = false;
        }

        private void txtLoai_Leave(object sender, EventArgs e)
        {
            txtLoai.xActive = false;
            ev.Qtxt_Enter(sender, e);
            dgrChiTietPhieu.Visible = false;
        }

        private void txtPhanLoai_Leave(object sender, EventArgs e)
        {
            txtPhanLoai.xActive = false;
            ev.Qtxt_Enter(sender, e);
            dgrChiTietPhieu.Visible = false;
        }

        //private void SaveThongTinPhieu ()
        //{
        //     msql = "INSERT INTO [dbo].[DUOC_KC_THONGTINPHIEU_CHITIETPHIEULINHOQUAYTHUOC] ([NguoiLap],[MaPhieuNhap],[Loai],[NgayLap],[NgayLinh],[PhanLoai])" +
        //            "VALUES(N'" + txtNguoiLap.Text + "'N'" + txtMaPhieu.Text + "',N'" + txtLoai.Text + "',N'" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "',N'" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "',N'" + txtPhanLoai.Text + "',0) " +
        //            "";
        //     comm.RunSQL(mconnectstring, msql);
            
        //}

        //private void SaveThongTinThuoc()
        //{
        //    if (txtMaPhieu.Text.Trim() != "")
        //    {
        //        for (int i = 0; i < dgrChiTietPhieu.Rows.Count; i++)
        //        {
        //            msql = "INSERT INTO SELECT*FROM [dbo].[DUOC_KC_THONGTINTHUOC_CHITIETPHIEULINHOQUAYTHUOC]([MaThuoc],[Ten],[DonVi,[Lo],[HanDung],[SLYC],[SLPhat],[GhiChu])" +
        //                " VALUES(N'" + dgrChiTietPhieu.Rows[i].Cells["cMaThuoc"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cTen"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cDonVi"].Value + "','" + dgrChiTietPhieu.Rows[i].Cells["cLo"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cHanDung"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cSLYC"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cSLP"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cGhiChu"].Value + "')";
        //            comm.RunSQL(mconnectstring, msql);
        //        }
        //    }
        //    else
        //        ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
        //    txtMaPhieu.Focus();
        //}

        //private void SaveFull()
        //{
        //    if (txtMaPhieu.Text.Trim() != "")
        //    {
        //        for (int i = 0; i < dgrChiTietPhieu.Rows.Count; i++)
        //        {
        //            msql = "INSERT INTO [dbo].[DUOC_KC_CHITIETPHIEULINHOQUAYTHUOC] ([NguoiLap],[MaPhieuNhap],[Loai],[NgayLap],[NgayLinh],[PhanLoai],[MaThuoc],[Ten],[DonVi,[Lo],[HanDung],[SLYC],[SLPhat],[GhiChu]) VALUES (N'" + txtNguoiLap.Text + "'N'" + txtMaPhieu.Text + "',N'" + txtLoai.Text + "',N'" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "',N'" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "',N'" + txtPhanLoai.Text + "',0,N'" + dgrChiTietPhieu.Rows[i].Cells["cMaThuoc"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cTen"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cDonVi"].Value + "','" + dgrChiTietPhieu.Rows[i].Cells["cLo"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cHanDung"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cSLYC"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cSLP"].Value + "',N'" + dgrChiTietPhieu.Rows[i].Cells["cGhiChu"].Value + "')";
        //            comm.RunSQL(mconnectstring, msql);
        //        }
        //    }

        //    else
        //        ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
        //    txtMaPhieu.Focus();

        //}




        private void txtNguoiLap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNguoiLap);
        }

        private void txtLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtLoai);
        }

        private void dgrChiTietPhieu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrChiTietPhieu);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNguoiLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgrChiTietPhieu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrChiTietPhieuYeuCauLinhThuocVatTu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {



            txtMaPhieu.Text = dgrChiTietPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cMaPhieu"].Value.ToString();
            txtNguoiLap.Text = dgrChiTietPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cNguoiLapPhieu"].Value.ToString();
            txtLoai.Text = dgrChiTietPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cLoaiPhieu"].Value.ToString();
            dtNgayLap.Text = dgrChiTietPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cNgayLapPhieu"].Value.ToString();
            dtNgayLinh.Text = dgrChiTietPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cNgayLinhPhieu"].Value.ToString();
            txtPhanLoai.Text = dgrChiTietPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cPhanLoaiPhieu"].Value.ToString();


        }
    }
}
