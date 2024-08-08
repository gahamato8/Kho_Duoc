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
    public partial class FrmPhieuYeuCauLinhThuocVatTu : Form
    {
        private string mconnecstring = "server = .;database = KHODUOC; uid = sa; pwd = 123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public FrmPhieuYeuCauLinhThuocVatTu()
        {
            InitializeComponent();
            LoadData();
            //loaddata3();
            //loaddata1();
            //loaddata2();
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            dtNgayLap.Value = startOfMonth;
        }
        public static string MaPhieuYeuCau; // Khai báo public cho biến A để sử trong FrmPhieuYeuCauLinhThuocVatTu

        private void dgrDanhSachPhieuYeuCauLinhThuocVatTu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 0 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
            //msql = "SELECT *   FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] where TrangThai = 0";
            DataTable tb = comm.GetDataTable(mconnecstring, msql, "DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC");
            dgrPhieuYeuCauLinhThuocVatTu.AutoGenerateColumns = false;
            dgrPhieuYeuCauLinhThuocVatTu.DataSource = tb;

            //cbo Nơi Gửi Yêu Cầu Phiếu Lĩnh Thuốc Vật Tư
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_DANHMUCKHODUOC]";
            DataTable kc = comm.GetDataTable(mconnecstring, msql, "DUOC_KC_DANHMUCKHODUOC");
            cboNoiGuiYeuCauPhieuLinhThuocVatTu.DataSource = kc.Copy();
            cboNoiGuiYeuCauPhieuLinhThuocVatTu.DisplayMember = "TenKhoDuoc";
            cboNoiGuiYeuCauPhieuLinhThuocVatTu.ValueMember = "TenKhoDuoc";
            cboNoiGuiYeuCauPhieuLinhThuocVatTu.CustomAlignment = new string[] { "l", "l" };
            cboNoiGuiYeuCauPhieuLinhThuocVatTu.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi Nhận Yêu Cầu Phiếu Lĩnh Thuốc Vật Tư
            cboNoiNhanYeuCauPhieuLinhThuocVatTu.DataSource = kc.Copy();
            cboNoiNhanYeuCauPhieuLinhThuocVatTu.DisplayMember = "TenKhoDuoc";
            cboNoiNhanYeuCauPhieuLinhThuocVatTu.ValueMember = "TenKhoDuoc";
            cboNoiNhanYeuCauPhieuLinhThuocVatTu.CustomAlignment = new string[] { "l", "l" };
            cboNoiNhanYeuCauPhieuLinhThuocVatTu.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Loại Phiếu Lĩnh Thuốc Vật Tư
            msql = "SELECT* FROM[dbo].[tabNhomThuoc]";
            DataTable loai = comm.GetDataTable(mconnecstring, msql, "tabNhomThuoc");
            cboLoaiPhieuLinhThuocVatTu.DataSource = loai.Copy();
            cboLoaiPhieuLinhThuocVatTu.DisplayMember = "TenNhom";
            cboLoaiPhieuLinhThuocVatTu.ValueMember = "TenNhom";
            cboLoaiPhieuLinhThuocVatTu.CustomAlignment = new string[] { "l", "l" };
            cboLoaiPhieuLinhThuocVatTu.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Trạng Thái
            msql = "SELECT * FROM [dbo].[DUOC_KL_TRANGTHAI]";
            DataTable tt = comm.GetDataTable(mconnecstring, msql, "DUOC_KL_TRANGTHAI");
            cboTrangThai.DataSource = tt.Copy();
            cboTrangThai.DisplayMember = "TenTrangThai";
            cboTrangThai.ValueMember = "IDTrangThai";
            cboTrangThai.CustomAlignment = new string[] { "l", "l" };
            cboTrangThai.CustomColumnStyle = new string[] { "t", "t" };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoPhieuYeuCauLinh_Click(object sender, EventArgs e)
        {
            
            FrmTaoPhieuYeuCauLinhThuocOQuayThuoc f = new FrmTaoPhieuYeuCauLinhThuocOQuayThuoc();
            this.Hide();
            f.ShowDialog();
        }

        private void txtMaPhieuLinh_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgrPhieuYeuCauLinhThuocVatTu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrPhieuYeuCauLinhThuocVatTu);
        }

        private void dgrPhieuYeuCauLinhThuocVatTu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            {
                
                if (dgrPhieuYeuCauLinhThuocVatTu["cDuyetTrangThai", e.RowIndex] == dgrPhieuYeuCauLinhThuocVatTu.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn duyệt trạng thái mã yêu cầu " + dgrPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cMaYeuCauPhieuLinh"].Value.ToString() + " này không ?"))
                    {
                        msql = "UPDATE [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] SET [TrangThai] = 1 WHERE MaPhieuYeuCau = '"+ dgrPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cMaYeuCauPhieuLinh"].Value.ToString() + "'";
                        comm.RunSQL(mconnecstring, msql);
                        loaddata1();
                    }
                }
                if (dgrPhieuYeuCauLinhThuocVatTu["cXoa", e.RowIndex] == dgrPhieuYeuCauLinhThuocVatTu.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn hủy " + dgrPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cMaYeuCauPhieuLinh"].Value.ToString() + " này không ?"))
                    {
                        msql = "UPDATE [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] SET [TrangThai] = 2 WHERE MaPhieuYeuCau = N'" + dgrPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cMaYeuCauPhieuLinh"].Value.ToString() + "'";
                        comm.RunSQL(mconnecstring, msql);
                        loaddata2();
                    }
                }
                if (dgrPhieuYeuCauLinhThuocVatTu["cDuyet", e.RowIndex] == dgrPhieuYeuCauLinhThuocVatTu.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn duyệt " + dgrPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cNguoiLapPhieuLinhThuocVatTu"].Value.ToString() + " này không ?"))
                    {
                        MaPhieuYeuCau = dgrPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells[0].Value.ToString(); // Lấy mã phiếu từ cột MaPhieuYeuCau cua dgrDaxuatkho truyền vào biến a
                        LoadData();
                        
                        FrmTaoPhieuYeuCauLinhThuocOQuayThuoc123 f = new FrmTaoPhieuYeuCauLinhThuocOQuayThuoc123();  //tạo Frm mới
                        this.Hide();
                        //Code này để đóng tất cả form
                        //add.Closed += (s, args) => this.Close();
                        f.ShowDialog(); //Show Frm mới khởi tạo lên  
                    }
                }
                if (dgrPhieuYeuCauLinhThuocVatTu["cXemChiTiet", e.RowIndex] == dgrPhieuYeuCauLinhThuocVatTu.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn xem chi tiết " + dgrPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cNguoiLapPhieuLinhThuocVatTu"].Value.ToString() + " này không ?"))
                    {
                        //msql = "UPDATE [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] SET [TrangThai] = 5 WHERE MaPhieuYeuCau = N'" + dgrPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cMaYeuCauPhieuLinh"].Value.ToString() + "'";
                        //comm.RunSQL(mconnecstring, msql);
                        MaPhieuYeuCau = dgrPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells[0].Value.ToString();
                        FrmChiTietPhieuYeuCauLinhThuocOQuayThuoc t = new FrmChiTietPhieuYeuCauLinhThuocOQuayThuoc(); //tạo Frm mới
                        t.LoadDaTaChiTietPhieuYeuCauLinhThuoc();
                        loaddatachitiet();
                        this.Hide();
                        t.ShowDialog(); //Show Frm mới khởi tạo lên  

                    }
                }
            }
        }
        public string CreateAutoID()
        {
            return SQLHelper.ExecQuerySacalar($@" ").ToString();

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(cboTrangThai.SelectedValue.ToString());
            switch (a)
            {
                case 0:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 0 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dc = comm.GetDataTable(mconnecstring, msql, "Đang chờ ");
                    dgrPhieuYeuCauLinhThuocVatTu.AutoGenerateColumns = false;
                    dgrPhieuYeuCauLinhThuocVatTu.DataSource = dc;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[10].Visible = true;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[11].Visible = true;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[12].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[13].Visible = false;
                    break;
                case 1:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 1 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable cn = comm.GetDataTable(mconnecstring, msql, "Chấp nhận ");
                    dgrPhieuYeuCauLinhThuocVatTu.AutoGenerateColumns = false;
                    dgrPhieuYeuCauLinhThuocVatTu.DataSource = cn;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[10].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[11].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[12].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[13].Visible = false;
                    break;
                case 2:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 2 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dh = comm.GetDataTable(mconnecstring, msql, "Đã hủy");
                    dgrPhieuYeuCauLinhThuocVatTu.AutoGenerateColumns = false;
                    dgrPhieuYeuCauLinhThuocVatTu.DataSource = dh;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[10].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[11].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[12].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[13].Visible = false;
                    break;
                case 5:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 5 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dlt = comm.GetDataTable(mconnecstring, msql, "Đã lưu trữ");
                    dgrPhieuYeuCauLinhThuocVatTu.AutoGenerateColumns = false;
                    dgrPhieuYeuCauLinhThuocVatTu.DataSource = dlt;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[10].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[11].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[12].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[13].Visible = true;
                    break;
                case 4:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 4 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dct = comm.GetDataTable(mconnecstring, msql, "Duyệt cấp thuốc");
                    dgrPhieuYeuCauLinhThuocVatTu.AutoGenerateColumns = false;
                    dgrPhieuYeuCauLinhThuocVatTu.DataSource = dct;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[10].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[11].Visible = false;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[12].Visible = true;
                    dgrPhieuYeuCauLinhThuocVatTu.Columns[13].Visible = true;
                    break;
            }
        }


        private void loaddata1()
        {

            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A,DUOC_KL_TRANGTHAI AS B WHERE A.TrangThai = 0 AND A.TrangThai = B.IDTrangThai";
            DataTable cn = comm.GetDataTable(mconnecstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            dgrPhieuYeuCauLinhThuocVatTu.AutoGenerateColumns = false;
            dgrPhieuYeuCauLinhThuocVatTu.DataSource = cn;
        }
        private void loaddata2()
        {

            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 2 AND A.TrangThai = B.IDTrangThai";
            DataTable dh = comm.GetDataTable(mconnecstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            dgrPhieuYeuCauLinhThuocVatTu.AutoGenerateColumns = false;
            dgrPhieuYeuCauLinhThuocVatTu.DataSource = dh;
        }

        private void loaddatachitiet()
        {

            msql = "SELECT * FROM [PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KC_Lo2023] as B where TrangThai = 5 and A.MaThuoc = B.MaThuoc ";
            comm.RunSQL(mconnecstring, msql);
            
        }

        private void dgrPhieuYeuCauLinhThuocVatTu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //private void load_data()
        //{
        //    msql = "SELECT MaPhieuYeuCau, MaPhieuXuatKho, Loai, NgayLinh, NgayLap, NguoiLap, KhoDuocNoiGuiYeuCau, KhoDuocNoiNhanYeuCau, GhiChu, CASE WHEN TrangThai = 0 Then N'Chưa duyệt' END AS TrangThai FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] WHERE MaPhieuYeuCau = '" + FrmTaoPhieuYeuCauLinhThuocOQuayThuoc.maphieuyeucau + "'  AND MaPhieuXuatKho = '" + FrmTaoPhieuYeuCauLinhThuocOQuayThuoc.maphieuxuatkho + "'";
        //    DataTable tb = comm.GetDataTable(mconnecstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
        //    dgrPhieuYeuCauLinhThuocVatTu.AutoGenerateColumns = false;
        //    dgrPhieuYeuCauLinhThuocVatTu.DataSource = tb;
        //}
    }
}
