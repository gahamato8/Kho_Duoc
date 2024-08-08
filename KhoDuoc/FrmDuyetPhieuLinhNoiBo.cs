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
    public partial class FrmDuyetPhieuLinhNoiBo : Form
    {
        public string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public FrmDuyetPhieuLinhNoiBo()
        {
            InitializeComponent();
            LoadDataDuyet();
            txtMaPhieuXuatPhieuLinh.Text = CreateAutoID();//Hàm load mã tự động
            SetFontForHeader();

        }

        public static string Lo;// Khai báo public cho biến Lo để  sử dụng trong FrmCapThuocVatTu
        public static string MaThuoc;
        public static string MaLo;
        public static string MaPhieu;
        private void SetFontForHeader()
        {
            // Tạo một đối tượng Font mới cho header
            Font newHeaderFont = new Font("Times New Roman", 16); // Thay đổi thông số font chữ theo ý muốn

            // Gán font mới cho ColumnHeadersDefaultCellStyle của DataGridView
            dgrChiTietDuyetPhieuLinh.ColumnHeadersDefaultCellStyle.Font = newHeaderFont;
        }
     
        public void LoadDataDuyet()
        {
          
            msql = "select DISTINCT A.MaThuoc,A.Lo,B.Ton,A.DonVi,B.HanDung,B.SoLuongThucHien,A.SoLuongYeuCau,A.MaPhieuYeuCau,A.TenThuoc_VatTu,A.MaLo from PHIEUYEUCAULINHTHUOCQUAYTHUOC as A,Duoc_KC_SoLuongTon as B where A.MaLo=B.MaLo and a.MaThuoc = b.MaThuoc and A.MaPhieuYeuCau = '" + FrmXuatThuoc.MaPhieuYeuCau + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "[PHIEUYEUCAULINHTHUOCQUAYTHUOC]");
            dgrChiTietDuyetPhieuLinh.AutoGenerateColumns = false;
            dgrChiTietDuyetPhieuLinh.DataSource = tb;
            
        }
        public string CreateAutoID()
        {
            return SQLHelper.ExecQuerySacalar($@"select [dbo].[TaoMaPhieuXuatKhoChan]('" + Convert.ToDateTime(dtNgayXuatPhieuLinh.Value).ToString("yyyy-MM-dd") + "')").ToString();
        }

        private void txtMaPhieuXuatDuyetPhieuLinhNoiBo_Enter(object sender, EventArgs e)
        {
            txtMaPhieuXuatPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaYeuCauDuyetPhieuLinhNoiBo_Enter(object sender, EventArgs e)
        {
            txtMaYeuCauPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNoiGuiYeuCauDuyetPhieuLinhNoiBo_Enter(object sender, EventArgs e)
        {
            txtNoiGuiYeuCauPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNguoiLapDuyetPhieuLinhNoiBo_Enter(object sender, EventArgs e)
        {
            txtNguoiLapPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaPhieuXuatDuyetPhieuLinhNoiBo_Leave(object sender, EventArgs e)
        {
            txtMaPhieuXuatPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaYeuCauDuyetPhieuLinhNoiBo_Leave(object sender, EventArgs e)
        {
            txtMaYeuCauPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNoiGuiYeuCauDuyetPhieuLinhNoiBo_Leave(object sender, EventArgs e)
        {
            txtNoiGuiYeuCauPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNguoiLapDuyetPhieuLinhNoiBo_Leave(object sender, EventArgs e)
        {
            txtNguoiLapPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
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
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNguoiLapPhieuLinh);
        }

        private void txtNguoiXuatPhieuLinh_Enter(object sender, EventArgs e)
        {
            txtNguoiLapPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNguoiXuatPhieuLinh_Leave(object sender, EventArgs e)
        {
            txtNguoiLapPhieuLinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNguoiXuatPhieuLinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNoiNhanYeuCauPhieuLinh);
        }

        private void txtNoiYeuCauPhieuLinh_Enter(object sender, EventArgs e)
        {
            txtNoiNhanYeuCauPhieuLinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNoiYeuCauPhieuLinh_Leave(object sender, EventArgs e)
        {
            txtNoiNhanYeuCauPhieuLinh.xActive = false;
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

        private void dgrChiTietDuyetPhieuLinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

       

        private void dgrChiTietDuyetPhieuLinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtMaPhieuXuatPhieuLinh.Text = CreateAutoID();
        }

        private void FrmDuyetPhieuLinhNoiBo_Load(object sender, EventArgs e)
        {
           
        }

        private void dgrChiTietDuyetPhieuLinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrChiTietDuyetPhieuLinh);
        }
        //NÚT ĐỒNG Ý DUYỆT PHIẾU
        private void button1_Click(object sender, EventArgs e)
        {

            //Đổi trạng thái 4(Chờ Duyệt cấp thuốc)
            LoadTrangThai();
            
            //Thêm dữ liệu vào duyệt phiếu
            SaveThongTinPhieuXuat();
            //Thêm dữ liệu vào duyệt phiếu
            SaveThongTinThuocXuat();
            ev.QFrmThongBao_YesNo("Bạn có đồng ý cấp những thuốc này");


            //FrmXuatThuoc
            this.Hide();
            FrmXuatThuoc form1 = new FrmXuatThuoc();
            form1.ShowDialog();

        }
        //private void ThucHienFiFoKhoLe()
        //{
        //    msql = "exec FifoKhoChan '','','','','','',2";
        //    comm.RunSQL(mconnectstring, msql);
        //}

        //Đổi trạng thái =4 (Chờ Duyệt cấp thuốc)
        private void LoadTrangThai()
        {
            msql = "UPDATE [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]  SET TrangThai = 4 WHERE MaPhieuYeuCau = N'" + dgrChiTietDuyetPhieuLinh.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString() + "'";
            comm.RunSQL(mconnectstring, msql);
            // Không sử dụng vì đây là code load bảng lên datagridview
            //DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            //dgrChiTietDuyetPhieuLinh.AutoGenerateColumns = false;
            //dgrChiTietDuyetPhieuLinh.DataSource = tb;
        }
        //Thêm dữ liệu vào Tbl THÔNG TIN PHIẾU XUẤT
        private void SaveThongTinPhieuXuat()
        {
            //Nếu txt khác rỗng (có nghĩa là có dữ liệu)
            if (txtMaYeuCauPhieuLinh.Text.Trim() != "") // Text.Trim bỏ khoảng trống để lấy giá trị vd :"  a  b c" thì nó sẽ bỏ khoảng cách để lấy "abc"
            {
                
                    msql = "INSERT INTO [dbo].[DUYETPHIEULINHNOIBO_THONGTINPHIEUXUAT]" +
                    "([MaPhieuXuatKhoChan],[NgayXuat],[MaPhieuYeuCau],[KhoDuocNoiGuiYeuCau],[KhoDuocNoiNhanYeuCau],[YeuCauChoNgay],[NgayLap],[NguoiLap],[GhiChu],[TrangThai]) " +
                    "VALUES(N'" + txtMaPhieuXuatPhieuLinh.Text + "' ,N'" + Convert.ToDateTime(dtNgayXuatPhieuLinh.Value).ToString("yyyy-MM-dd") + "' ,N'" + txtMaYeuCauPhieuLinh.Text + "',N'" + txtNoiGuiYeuCauPhieuLinh.Text + "' ,N'" + txtNoiNhanYeuCauPhieuLinh.Text + "' ,N'" + Convert.ToDateTime(dtYeuCauChoNgayPhieuLinh.Value).ToString("yyyy-MM-dd") + "',N'" + Convert.ToDateTime(dtNgayLapPhieuLinh.Value).ToString("yyyy-MM-dd") + "',N'" + txtNguoiLapPhieuLinh.Text + "',N'" + txtGhiChuPhieuLinh.Text + "','4')";
                    comm.RunSQL(mconnectstring, msql);
                
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            txtMaYeuCauPhieuLinh.Focus();
        }
        //Thêm dữ liệu vào Tbl THÔNG TIN THUỐC XUẤT
        private void SaveThongTinThuocXuat()
        {
            //Nếu txt khác rỗng (có nghĩa là có dữ liệu)
            if (txtMaYeuCauPhieuLinh.Text.Trim() != "")
            {
                for (int i = 0; i < dgrChiTietDuyetPhieuLinh.Rows.Count; i++)
                {
                    msql = "INSERT INTO [dbo].[DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT]" +
                    "([MaPhieuXuatKhoChan],[MaPhieuYeuCau],[MaThuoc],[Lo],[MaLo],[Ton],[TenThuoc_VatTu],[SoLuongYeuCau],[GhiChu],[DonVi],[SoLuongCap],[HanDung],[GhiChu1],[TrangThai]) " +
                    "VALUES('" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cMaPhieuXuat"].Value + "','" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cMaPhieuYeuCau"].Value + "','" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cMaThuoc"].Value + "','" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cLo"].Value + "','" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cMaLo"].Value + "','" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cTon"].Value + "','" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cTenThuoc_VatTu"].Value + "','" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cSoLuongYeuCau"].Value + "',N'" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cGhiChuYeuCau"].Value + "','" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cDonVi"].Value + "','" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cSoLuongCap"].Value + "','" + Convert.ToDateTime(dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cHanDung"].Value).ToString("yyyy-MM-dd") + "',N'" + dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cGhiChu"].Value + "','4')";
                    comm.RunSQL(mconnectstring, msql);
                }
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            txtMaYeuCauPhieuLinh.Focus();
        }
        private void SaveSL()
        {
            //Nếu txt khác rỗng (có nghĩa là có dữ liệu)
            if (txtMaYeuCauPhieuLinh.Text.Trim() != "")
            {
                for (int i = 0; i < dgrChiTietDuyetPhieuLinh.Rows.Count; i++)
                {

                    msql = "UPDATE [dbo].[tabDanhMucThuoc] SET [SoLuongKho] = '"+ dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cTon"].Value + "' WHERE [MaThuoc]='"+ dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cMaThuoc"].Value + "'";
                    comm.RunSQL(mconnectstring, msql);
                    //dgrChiTietDuyetPhieuLinh.Rows[i].Cells["cTon"].Value
                }
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            txtMaYeuCauPhieuLinh.Focus();
        }


        //CODE NÚT BACK QUAY VÈ FRM TRƯỚC NÓ 
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            //FrmXuatThuoc i = new FrmXuatThuoc();
            //i.ShowDialog();
            //i = null;
            //this.Show();
        }

        private void txtNguoiLapPhieuLinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrChiTietDuyetPhieuLinh_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaYeuCauPhieuLinh.Text = dgrChiTietDuyetPhieuLinh.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString();
            if (e.RowIndex == -1)
                return;
            if (dgrChiTietDuyetPhieuLinh["cCap", e.RowIndex] == dgrChiTietDuyetPhieuLinh.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn muốn cấp thuốc " + dgrChiTietDuyetPhieuLinh.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString() + " này không ?"))
                {


                    FrmCapThuocVatTu f = new FrmCapThuocVatTu(); //tạo Frm mới
                    MaPhieu = dgrChiTietDuyetPhieuLinh.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString();

                    f.LoadDataCapThuoc();// LoadDataDuyet của FrmDuyetPhieuLinhNoiBo để update dữ liệu lên Frm
                    this.Hide();
                    f.ShowDialog(); //Show Frm mới khởi tạo lên
                    //msql = "UPDATE [dbo].[DUOC_KC_TaoPhieuYeuCauLinhThuoc]  SET TrangThai = 1 WHERE MaPhieuYeuCau = N'" + dgrChiTietDuyetPhieuLinh.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString() + "'";
                    //comm.RunSQL(mconnectstring, msql);
                }
            }
        }
        void update()
        {


            msql = "UPDATE [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] SET [TrangThai] = 4 WHERE MaPhieuYeuCau = N'" + dgrChiTietDuyetPhieuLinh.CurrentRow.Cells["cMaPhieuXuat"].Value.ToString() + "'";
            comm.RunSQL(mconnectstring, msql);
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {

            if (txtMaPhieuXuatPhieuLinh.Text.Trim()!= ""&& txtMaYeuCauPhieuLinh.Text.Trim()!="")
            {

            LoadTrangThai();
            SaveThongTinPhieuXuat();
            SaveThongTinThuocXuat();
                SaveSL();
                if (ev.QFrmThongBao_YesNo("Bạn có đồng ý cấp những thuốc này") == true)
                {
                    ev.QFrmThongBao("Bạn đã đồng ý cấp thuốc thành công");
                }

               


            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập đủ thông tin");

            }

        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {

        }

        private void dgrChiTietDuyetPhieuLinh_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

     
    }
}
