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
    public partial class FrmTaoPhieuYeuCauLinhThuocOQuayThuoc123 : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;


        public FrmTaoPhieuYeuCauLinhThuocOQuayThuoc123()
        {
            InitializeComponent();
            LoadData();
            //txtMaPhieuNhap.Text = CreateAutoID();
            //LoadData1();
            dgrTaoPhieuLinh.Font = new Font("Times New Roman", 15);
        }
        //public static string MaPhieuYeuCau;
        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Load Data
        private void LoadData()
        {
            msql = "SELECT DISTINCT C.TenThuoc_VatTu,C.DonVi,D.SoLuongCap,C.SoLuongYeuCau,B.Lo,B.HanDung,C.GhiChu1,A.NguoiLap,A.NgayLap,A.MaPhieuYeuCau FROM [DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]  as A, [DUOC_KC_Lo2023] as B,[dbo].[DUOC_KC_THONGTINTHUOC_PHIEUYEUCAULINHTHUOCQUAYTHUOC] as C,DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT AS D  where A.TrangThai = 4 and A.MaPhieuYeuCau=C.MaPhieuYeuCau AND B.MaThuoc=C.MaThuoc AND D.MaThuoc=B.MaThuoc and A.MaPhieuYeuCau = '" + FrmPhieuYeuCauLinhThuocVatTu.MaPhieuYeuCau + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            //msql = "SELECT * FROM [KHODUOC].[dbo].[DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT] where TrangThai = 4 ";
            //DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT");
            dgrTaoPhieuLinh.AutoGenerateColumns = false;
            dgrTaoPhieuLinh.DataSource = tb;

        }

        private void dgrTaoPhieuLinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrTaoPhieuLinh);
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
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTaoPhieuYeuCauLinh);
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void SaveThongTinPhieu()
        //{
        //    msql = "INSERT INTO [dbo].[DUYETPHIEULINHNOIBO_THONGTINPHIEUXUAT] ([MaPhieuYeuCau],[NgayLap],[NguoiLap],[TrangThai])" +
        //        "VALUES(N'" + txtMaPhieuNhap.Text + "','" + Convert.ToDateTime(dtNgayNhap.Value).ToString("yyyy-MM-dd") + "',N'" + txtNguoiLap.Text + "',4) " +
        //        "";
        //    comm.RunSQL(mconnectstring, msql);
        //}
        //private void SaveThongTinThuoc()
        //{
        //    if (txtMaPhieuNhap.Text.Trim() != "")
        //    {
        //        for (int i = 0; i < dgrTaoPhieuLinh.Rows.Count; i++)
        //        {
        //            msql = "INSERT INTO [dbo].[DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT]([TenThuoc_VatTu],[DonVi],[SoLuongYeuCau],[SoLuongCap],[Lo],[HanDung],[GhiChu])" +
        //                " VALUES(N'" + dgrTaoPhieuLinh.Rows[i].Cells["cTenThuoc"].Value + "', N'" + dgrTaoPhieuLinh.Rows[i].Cells["cDonVi"].Value + "',N'" + dgrTaoPhieuLinh.Rows[i].Cells["cSoLuongYeuCau"].Value + "','" + dgrTaoPhieuLinh.Rows[i].Cells["cSoLuongCap"].Value + "',N'" + dgrTaoPhieuLinh.Rows[i].Cells["cLo"].Value + "',N'" + Convert.ToDateTime(dgrTaoPhieuLinh.Rows[i].Cells["cHanDung"].Value).ToString("yyyy-MM-dd") + "',N'" + dgrTaoPhieuLinh.Rows[i].Cells["cGhiChu"].Value + "')";
        //            comm.RunSQL(mconnectstring, msql);
                    
        //        }
        //    }

        //    else
        //        ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
        //    txtMaPhieuNhap.Focus();

        //}

        private void TrangThai()
        {
           // msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 5 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayNhap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayNhap.Value).ToString("yyyy-MM-dd") + "'";

            msql = "UPDATE [dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] SET [TrangThai] = 5 WHERE MaPhieuYeuCau = N'" + dgrTaoPhieuLinh.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString() + "'";
            comm.RunSQL(mconnectstring, msql);

        }

        private void TrangThaiThongTinPhieuXuat_DuyetPhieuLinhNoiBo()
        {
            // msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 5 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayNhap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayNhap.Value).ToString("yyyy-MM-dd") + "'";

            msql = "UPDATE [dbo].[DUYETPHIEULINHNOIBO_THONGTINPHIEUXUAT] SET [TrangThai] = 5 WHERE MaPhieuYeuCau = N'" + dgrTaoPhieuLinh.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString() + "'";
            comm.RunSQL(mconnectstring, msql);

        }
        private void TrangThaiThongTinThuoc_DuyetPhieuLinhNoiBo()
        {
            // msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 5 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayNhap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayNhap.Value).ToString("yyyy-MM-dd") + "'";

            msql = "UPDATE [dbo].[DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT] SET [TrangThai] = 5 WHERE MaPhieuYeuCau = N'" + dgrTaoPhieuLinh.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString() + "'";
            comm.RunSQL(mconnectstring, msql);

        }
        private void btnTaoPhieuYeuCauLinh_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuNhap.Text.Trim() != "" && txtNguoiLap.Text.Trim() != "" )

            {
                if (ev.QFrmThongBao_YesNo("Hãy kiểm tra lại thật kĩ các thông tin trước khi lưu nhé!"))
                {
                    TrangThaiThongTinPhieuXuat_DuyetPhieuLinhNoiBo();
                    TrangThaiThongTinThuoc_DuyetPhieuLinhNoiBo();
                    TrangThai();
                    LoadData();
                    //MaPhieuYeuCau = dgrTaoPhieuLinh.CurrentRow.Cells[8].ToString();
                    //SaveThongTinPhieu();
                    //SaveThongTinThuoc();
                    //SaveFull();
                    ev.QFrmThongBao("Đã lưu thành công");
                }
                else
                {
                    ev.QFrmThongBao("Bạn đã chọn bỏ qua! Vui lòng hãy điền đầy đủ các thông tin và kiểm tra thật kĩ nhé!");
                }
            }
            else
                ev.QFrmThongBaoError("Thiếu thông tin");
            FrmChiTietPhieuYeuCauLinhThuocOQuayThuoc t = new FrmChiTietPhieuYeuCauLinhThuocOQuayThuoc(); //tạo Frm mới
            this.Hide();
            t.ShowDialog(); //Show Frm mới khởi tạo lên  
        }

        private void dgrTaoPhieuLinh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtMaPhieuNhap.Text = dgrTaoPhieuLinh.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString();
            dtNgayNhap.Text = dgrTaoPhieuLinh.CurrentRow.Cells["cNgayLap"].Value.ToString();
            txtNguoiLap.Text = dgrTaoPhieuLinh.CurrentRow.Cells["cNguoiLap"].Value.ToString();
        }
    }
}
