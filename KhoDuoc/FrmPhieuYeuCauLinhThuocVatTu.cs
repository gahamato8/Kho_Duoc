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
            dgrPhieuYCLinhThuoc.Font = new Font("Times New Roman", 16);
        }
        public static string MaPhieuYeuCau; // Khai báo public cho biến A để sử trong FrmPhieuYeuCauLinhThuocVatTu
        public static string MaPhieuXuatKho; // Khai báo public cho biến A để sử trong FrmPhieuYeuCauLinhThuocVatTu

        private void dgrDanhSachPhieuYeuCauLinhThuocVatTu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 0 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
            //msql = "SELECT *   FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] where TrangThai = 0";
            DataTable tb = comm.GetDataTable(mconnecstring, msql, "DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC");
            dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
            dgrPhieuYCLinhThuoc.DataSource = tb;

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
            ev.Qdgr_RowPostPaint(sender, e, dgrPhieuYCLinhThuoc);
        }

        private void dgrPhieuYeuCauLinhThuocVatTu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

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
                    dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
                    dgrPhieuYCLinhThuoc.DataSource = dc;
                    dgrPhieuYCLinhThuoc.Columns[10].Visible = true;
                    dgrPhieuYCLinhThuoc.Columns[11].Visible = true;
                    dgrPhieuYCLinhThuoc.Columns[12].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[13].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns["cEdit"].Visible = false;
                  
                              dgrPhieuYCLinhThuoc.Columns["cXemChiTiet"].Visible = false;

                    break;
                case 1:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 1 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable cn = comm.GetDataTable(mconnecstring, msql, "Chấp nhận ");
                    dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
                    dgrPhieuYCLinhThuoc.DataSource = cn;
                    dgrPhieuYCLinhThuoc.Columns[10].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[11].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[12].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[13].Visible = false;
                    break;
                case 2:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 2 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dh = comm.GetDataTable(mconnecstring, msql, "Đã hủy");
                    dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
                    dgrPhieuYCLinhThuoc.DataSource = dh;
                    dgrPhieuYCLinhThuoc.Columns[10].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[11].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[12].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[13].Visible = false;
                    break;
                case 5:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 5 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dlt = comm.GetDataTable(mconnecstring, msql, "Đã lưu trữ");
                    dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
                    dgrPhieuYCLinhThuoc.DataSource = dlt;
                    dgrPhieuYCLinhThuoc.Columns[10].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[11].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[12].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[13].Visible = true;
                    break;
                case 4:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 4 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dct = comm.GetDataTable(mconnecstring, msql, "Duyệt cấp thuốc");
                    dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
                    dgrPhieuYCLinhThuoc.DataSource = dct;
                    dgrPhieuYCLinhThuoc.Columns[10].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[11].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[12].Visible = true;
                    dgrPhieuYCLinhThuoc.Columns[13].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns["cDuyet"].Visible = true;

                    break;
            }
        }


        private void loaddata1()
        {

            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A,DUOC_KL_TRANGTHAI AS B WHERE A.TrangThai = 0 AND A.TrangThai = B.IDTrangThai";
            DataTable cn = comm.GetDataTable(mconnecstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
            dgrPhieuYCLinhThuoc.DataSource = cn;
        }
        private void loaddata2()
        {

            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B WHERE A.TrangThai = 2 AND A.TrangThai = B.IDTrangThai";
            DataTable dh = comm.GetDataTable(mconnecstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
            dgrPhieuYCLinhThuoc.DataSource = dh;
        }

        private void loaddatachitiet()
        {

            msql = "SELECT * FROM [PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KC_Lo2023] as B where TrangThai = 5 and A.MaThuoc = B.MaThuoc ";
            comm.RunSQL(mconnecstring, msql);
            
        }

     
        private void btnTaoPhieuYeuCauLinh_Click_1(object sender, EventArgs e)
        {
            FrmTaoPhieuYeuCauLinhThuocOQuayThuoc f = new FrmTaoPhieuYeuCauLinhThuocOQuayThuoc();
            this.Hide();
            f.ShowDialog();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(cboTrangThai.SelectedValue.ToString());
            switch (a)
            {
                case 0:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]as A, [DUOC_KL_TRANGTHAI] AS B ,[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as C WHERE A.TrangThai = 0 AND A.TrangThai = B.IDTrangThai and C.MaPhieuYeuCau=A.MaPhieuYeuCau AND A.NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dc = comm.GetDataTable(mconnecstring, msql, "Đang chờ ");
                    dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
                    dgrPhieuYCLinhThuoc.DataSource = dc;
                    dgrPhieuYCLinhThuoc.Columns[10].Visible = true;
                    dgrPhieuYCLinhThuoc.Columns[11].Visible = true;
                    dgrPhieuYCLinhThuoc.Columns[12].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[13].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns["cEdit"].Visible = true;
                    dgrPhieuYCLinhThuoc.Columns["cXemChiTiet"].Visible = false;

                    break;
                case 1:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]as A, [DUOC_KL_TRANGTHAI] AS B ,[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as C WHERE A.TrangThai = 0 AND A.TrangThai = B.IDTrangThai and C.MaPhieuYeuCau=A.MaPhieuYeuCau AND A.NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable cn = comm.GetDataTable(mconnecstring, msql, "Chấp nhận ");
                    dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
                    dgrPhieuYCLinhThuoc.DataSource = cn;
                    dgrPhieuYCLinhThuoc.Columns[10].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[11].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[12].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[13].Visible = false;
                    break;
                case 2:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]as A, [DUOC_KL_TRANGTHAI] AS B ,[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as C WHERE A.TrangThai = 2 AND A.TrangThai = B.IDTrangThai and C.MaPhieuYeuCau=A.MaPhieuYeuCau AND A.NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dh = comm.GetDataTable(mconnecstring, msql, "Đã hủy");
                    dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
                    dgrPhieuYCLinhThuoc.DataSource = dh;
                    dgrPhieuYCLinhThuoc.Columns[10].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[11].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[12].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[13].Visible = false;
                    break;
                case 5:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]as A, [DUOC_KL_TRANGTHAI] AS B ,[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as C WHERE A.TrangThai = 5 AND A.TrangThai = B.IDTrangThai and C.MaPhieuYeuCau=A.MaPhieuYeuCau AND A.NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dlt = comm.GetDataTable(mconnecstring, msql, "Đã lưu trữ");
                    dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
                    dgrPhieuYCLinhThuoc.DataSource = dlt;
                    dgrPhieuYCLinhThuoc.Columns[10].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[11].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[12].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[13].Visible = false;
                    break;
                case 4:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]as A, [DUOC_KL_TRANGTHAI] AS B ,[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as C WHERE A.TrangThai = 4 AND A.TrangThai = B.IDTrangThai and C.MaPhieuYeuCau=A.MaPhieuYeuCau AND A.NgayLap between '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dct = comm.GetDataTable(mconnecstring, msql, "Duyệt cấp thuốc");
                    dgrPhieuYCLinhThuoc.AutoGenerateColumns = false;
                    dgrPhieuYCLinhThuoc.DataSource = dct;
                    dgrPhieuYCLinhThuoc.Columns[10].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[11].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns[12].Visible = true;
                    dgrPhieuYCLinhThuoc.Columns[13].Visible = false;
                    dgrPhieuYCLinhThuoc.Columns["cDuyet"].Visible = true;
                    dgrPhieuYCLinhThuoc.Columns["cXemChiTiet"].Visible = false;

                    


                    break;
            }
        }

        private void dgrPhieuYeuCauLinhThuocVatTu_CellMouseClick_2(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaPhieuLinhThuocVatTu.Text = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cMaPL"].Value.ToString();


            if (e.RowIndex == -1)
                return;
            {

                if (dgrPhieuYCLinhThuoc["cDuyetTrangThai", e.RowIndex] == dgrPhieuYCLinhThuoc.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn duyệt trạng thái mã yêu cầu " + dgrPhieuYCLinhThuoc.CurrentRow.Cells["cMaPL"].Value.ToString() + " này không ?"))
                    {
                        msql = "UPDATE [dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] SET [TrangThai] = 1 WHERE MaPhieuYeuCau = '" + dgrPhieuYCLinhThuoc.CurrentRow.Cells["cMaPL"].Value.ToString() + "'";
                        comm.RunSQL(mconnecstring, msql);
                        loaddata1();
                    }
                }
                else if (dgrPhieuYCLinhThuoc["cXoa", e.RowIndex] == dgrPhieuYCLinhThuoc.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn hủy " + dgrPhieuYCLinhThuoc.CurrentRow.Cells["cMaYeuCauPhieuLinh"].Value.ToString() + " này không ?"))
                    {
                        msql = "UPDATE [dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] SET [TrangThai] = 2 WHERE MaPhieuYeuCau = N'" + dgrPhieuYCLinhThuoc.CurrentRow.Cells["cMaPL"].Value.ToString() + "'";
                        comm.RunSQL(mconnecstring, msql);
                        loaddata2();
                    }
                }

                else if (dgrPhieuYCLinhThuoc["cDuyet", e.RowIndex] == dgrPhieuYCLinhThuoc.CurrentCell)
                    {
                        if (ev.QFrmThongBao_YesNo("Bạn có muốn duyệt mã phiếu " + dgrPhieuYCLinhThuoc.CurrentRow.Cells["cMaPL"].Value.ToString() + " này không ?"))
                        {
                            MaPhieuYeuCau = dgrPhieuYCLinhThuoc.CurrentRow.Cells[0].Value.ToString(); // Lấy mã phiếu từ cột MaPhieuYeuCau cua dgrDaxuatkho truyền vào biến a
                            LoadData();

                            FrmTaoPhieuYeuCauLinhThuocOQuayThuoc123 f = new FrmTaoPhieuYeuCauLinhThuocOQuayThuoc123();  //tạo Frm mới
                            this.Hide();
                            //Code này để đóng tất cả form
                            //add.Closed += (s, args) => this.Close();
                            f.ShowDialog(); //Show Frm mới khởi tạo lên  
                        }
                    }



                else if(dgrPhieuYCLinhThuoc["cXemChiTiet", e.RowIndex] == dgrPhieuYCLinhThuoc.CurrentCell)
                    {
                        if (ev.QFrmThongBao_YesNo("Bạn có muốn xem chi tiết " + dgrPhieuYCLinhThuoc.CurrentRow.Cells["cMaYeuCauPhieuLinh"].Value.ToString() + " này không ?"))
                        {
                            //msql = "UPDATE [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] SET [TrangThai] = 5 WHERE MaPhieuYeuCau = N'" + dgrPhieuYeuCauLinhThuocVatTu.CurrentRow.Cells["cMaYeuCauPhieuLinh"].Value.ToString() + "'";
                            //comm.RunSQL(mconnecstring, msql);
                            MaPhieuYeuCau = dgrPhieuYCLinhThuoc.CurrentRow.Cells[0].Value.ToString();
                            FrmChiTietPhieuYeuCauLinhThuocOQuayThuoc t = new FrmChiTietPhieuYeuCauLinhThuocOQuayThuoc(); //tạo Frm mới
                            t.LoadDaTaChiTietPhieuYeuCauLinhThuoc();
                            loaddatachitiet();
                           
                            t.ShowDialog(); //Show Frm mới khởi tạo lên  

                        }
                    }

                else if (dgrPhieuYCLinhThuoc["cEdit", e.RowIndex] == dgrPhieuYCLinhThuoc.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn sửa phiếu " + dgrPhieuYCLinhThuoc.CurrentRow.Cells["cMaPL"].Value.ToString() + " này không ?"))
                    {


                       
                        string MaPhieuYC = dgrPhieuYCLinhThuoc.CurrentRow.Cells[0].Value.ToString();
                        string MaPhieuXK = dgrPhieuYCLinhThuoc.CurrentRow.Cells[1].Value.ToString();
                        string NguoiLap = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cNguoiLapPhieuLinhThuocVatTu"].Value.ToString();
                        string PhanLoai = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cPhanLoai"].Value.ToString();
                        string Loai = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cLoai"].Value.ToString();
                        string NoiGuiYC = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cNoiGuiYC"].Value.ToString();
                        string Ghichu = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cGhiChu"].Value.ToString();
                        string NgayLap = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cNgayLap"].Value.ToString();
                        string NgayLinh = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cNgayLinh"].Value.ToString();
                        string NoiNhanYC = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cNoiNhanYC"].Value.ToString();
                        string SoLo = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cLo"].Value.ToString();
                        string MaLo = dgrPhieuYCLinhThuoc.CurrentRow.Cells["cMaLo"].Value.ToString();


                        FrmCapNhapPhieuLinhThuoc f = new FrmCapNhapPhieuLinhThuoc(MaPhieuYC, MaPhieuXK, NguoiLap, PhanLoai, Loai, NoiGuiYC, Ghichu, NgayLap, NgayLinh, NoiNhanYC, SoLo, MaLo);

                        f.ShowDialog(); //Show Frm mới khởi tạo lên  

                    }
                }
            }
        }


    }
}
