using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexCel;
using BusinessCommon;

namespace KhoDuoc
{
    public partial class FrmChiTietPhieuLinh : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmChiTietPhieuLinh()
        {
            InitializeComponent();
            dgrChiTietPhieuLinh.Font = new Font("Times New Roman", 15);
        }
        public static string MaPhieuYeuCau;
        public static string MaLo;
        public void LoadDataTrangThai3()
        {
            msql = "select * from DUYETPHIEULINHNOIBO_THONGTINPHIEUXUAT as A, DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT as B, Duoc_KC_SoLuongTon as C Where A.MaPhieuYeuCau='" + FrmXuatThuoc.MaPhieuYeuCau + "' and A.MaPhieuYeuCau=B.MaPhieuYeuCau and B.MaThuoc=C.MaThuoc and B.MaLo=C.MaLo and A.TrangThai=3 and A.TrangThai = B.TrangThai";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "CHITIETPHIEULINH");
            dgrChiTietPhieuLinh.AutoGenerateColumns = false;
            dgrChiTietPhieuLinh.DataSource = tb;
            dgrChiTietPhieuLinh.Columns["cCap"].Visible = false;
        }
        public void LoadDataTrangThai4()
        {
            msql = "select DISTINCT A.MaPhieuYeuCau,B.TenThuoc_VatTu,C.Lo,B.HanDung,B.DonVi,B.SoLuongCap,B.SoLuongYeuCau,A.GhiChu,A.MaPhieuXuatKhoChan,A.NgayXuat,A.NgayLap,B.MaLo from DUYETPHIEULINHNOIBO_THONGTINPHIEUXUAT as A, DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT as B, Duoc_KC_SoLuongTon as C Where A.MaPhieuYeuCau='"+FrmXuatThuoc.MaPhieuYeuCau+"' and A.MaPhieuYeuCau=B.MaPhieuYeuCau and B.MaThuoc=C.MaThuoc and A.TrangThai=4 and A.TrangThai = B.TrangThai";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "CHITIETPHIEULINH");
            dgrChiTietPhieuLinh.AutoGenerateColumns = false;
            dgrChiTietPhieuLinh.DataSource = tb;
        }
        public void LoadDataTrangThai5()
        {
            msql = "select DISTINCT A.MaPhieuYeuCau,B.TenThuoc_VatTu,C.Lo,B.HanDung,B.DonVi,B.SoLuongCap,B.SoLuongYeuCau,A.GhiChu,A.MaPhieuXuatKhoChan,A.NgayXuat,A.NgayLap,B.MaLo from DUYETPHIEULINHNOIBO_THONGTINPHIEUXUAT as A, DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT as B, Duoc_KC_SoLuongTon as C Where A.MaPhieuYeuCau='" + FrmXuatThuoc.MaPhieuYeuCau + "' and A.MaPhieuYeuCau=B.MaPhieuYeuCau and B.MaThuoc=C.MaThuoc and A.TrangThai=5 and A.TrangThai = B.TrangThai";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "CHITIETPHIEULINH");
            dgrChiTietPhieuLinh.AutoGenerateColumns = false;
            dgrChiTietPhieuLinh.DataSource = tb;
            dgrChiTietPhieuLinh.Columns["cCap"].Visible = false;
        }
        private void txtMaPhieuXuatPhieuLinh_Enter(object sender, EventArgs e)
        {
            txtMaPhieuXuatPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaPhieuXuatPhieuLinh_Leave(object sender, EventArgs e)
        {
            txtMaPhieuXuatPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaPhieuXuatPhieuLinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtMaYeuCauPhieuLinh);
        }

        private void txtMaYeuCauPhieuLinh_Enter(object sender, EventArgs e)
        {
            txtMaYeuCauPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaYeuCauPhieuLinh_Leave(object sender, EventArgs e)
        {
            txtMaYeuCauPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaYeuCauPhieuLinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNoiGuiYeuCauPhieuLinh);
        }

        private void txtNoiGuiYeuCauPhieuLinh_Enter(object sender, EventArgs e)
        {
            txtNoiGuiYeuCauPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNoiGuiYeuCauPhieuLinh_Leave(object sender, EventArgs e)
        {
            txtNoiGuiYeuCauPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNoiGuiYeuCauPhieuLinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNguoiXuatPhieuLinh);
        }

        private void txtNguoiXuatPhieuLinh_Enter(object sender, EventArgs e)
        {
            txtNguoiXuatPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNguoiXuatPhieuLinh_Leave(object sender, EventArgs e)
        {
            txtNguoiXuatPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNguoiXuatPhieuLinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNoiYeuCauPhieuLinh);
        }

        private void txtNoiYeuCauPhieuLinh_Enter(object sender, EventArgs e)
        {
            txtNoiYeuCauPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNoiYeuCauPhieuLinh_Leave(object sender, EventArgs e)
        {
            txtNoiYeuCauPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNoiYeuCauPhieuLinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGhiChuPhieuLinh);
        }

        private void txtGhiChuPhieuLinh_Enter(object sender, EventArgs e)
        {
            txtGhiChuPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGhiChuPhieuLinh_Leave(object sender, EventArgs e)
        {
            txtGhiChuPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void dgrChiTietPhieuLinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrChiTietPhieuLinh);
        }

        private void dgrChiTietPhieuLinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtNgayXuatPhieuLinh.Value = Convert.ToDateTime(dgrChiTietPhieuLinh.CurrentRow.Cells["cNgayXuat"].Value);
            //dtYeuCauChoNgayPhieuLinh.Value = Convert.ToDateTime(dgrChiTietPhieuLinh.CurrentRow.Cells["cYeuCauChoNgay"].Value);
            dtNgayLapPhieuLinh.Value = Convert.ToDateTime(dgrChiTietPhieuLinh.CurrentRow.Cells["cNgayLap"].Value);
        }

        private void dgrChiTietPhieuLinh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgrChiTietPhieuLinh["cCap", e.RowIndex] == dgrChiTietPhieuLinh.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn muốn cấp thuốc " + dgrChiTietPhieuLinh.CurrentRow.Cells["cTenThuoc_VatTu"].Value.ToString() + " này không ?"))
                {
                    FrmCapThuocVatTu f = new FrmCapThuocVatTu(); //tạo Frm mới
                    MaPhieuYeuCau = dgrChiTietPhieuLinh.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString();
                    MaLo = dgrChiTietPhieuLinh.CurrentRow.Cells["cMaLo"].Value.ToString();
                    f.LoadDataCapThuoc4();// LoadDataDuyet của FrmDuyetPhieuLinhNoiBo để update dữ liệu lên Frm
                    f.ShowDialog(); //Show Frm mới khởi tạo lên
                    this.Hide();
                }
            }
        }

        private void chkHoanThanh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkInDSPhatThuoc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

