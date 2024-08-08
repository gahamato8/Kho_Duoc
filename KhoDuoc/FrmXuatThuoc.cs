using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Windows.Forms;
using BusinessCommon;
using System.IO;

namespace KhoDuoc
{
    public partial class FrmXuatThuoc : Form
    {
        public static string mconnectstring = "server=.;database= KHODUOC; uid=sa;pwd=123";
        private string defaultFolderPath = @"D:\excel"; // Thư mục mặc định

        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmXuatThuoc()
        {
            InitializeComponent();
            LoadDataDSPLNBChuaXuLy();
            LoadDataDSPLNBXuatKhoGanNhat();
            Loadcbo();
            LoadNgay1ChuaXuLy();
            LoadNgay1DaXuatKho();
        }

        public static string MaPhieuYeuCau; // Khai báo public cho biến A để sử trong FrmDuyetPhieuLinhNoiBo
        public static string MaLo;
        public static string Lo;

        public static string R1;
        // chỉnh font chữ trong dữ liệu (hiện tại chưa cần)
        private void SizeGirdView()
        {
            this.dgrPhieuLinhNBChuaXuLy.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 16);
            this.dgrPhieuLinhNBDaXuatKho.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 16);
        }
   


        //LoadDataDS3
        public void LoadDataDSPLNBChuaXuLy()
        {
            //msql = "SELECT KhoDuocNoiGui, MaPhieuYeuCau, LinhCho, NgayLap, Loai, KhoDuocNoiGuiYeuCau, KhoDuocNoiNhanYeuCau, NguoiLap, GhiChu, KhoDuoc,CASE WHEN TrangThai = 0 THEN N'CHƯA DUYỆT'ELSE N'ĐÃ DUYỆT'END AS TrangThai from[dbo].[DUOC_KC_XUATKHO_PHIEULINHNOIBOTHUOC_CHUAXULY]";
            msql = "SELECT * FROM[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as a,[dbo].[DUOC_KC_Lo2023] as b , [DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as c where a.MaThuoc=b.MaThuoc AND c.MaPhieuYeuCau=a.MaPhieuYeuCau and a.NgayLap between '" + Convert.ToDateTime(dtTuNgayCXL.Value).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(dtDenNgayCXL.Value).ToString("yyyy-MM-dd") + "' and c.TrangThai = 1 ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC"); // Thực thi lấy bảng dữ liệu
            dgrPhieuLinhNBChuaXuLy.AutoGenerateColumns = false; // Hiển thị dững dữ liệu trên colums, cái nào null sẽ ẩn
            dgrPhieuLinhNBChuaXuLy.DataSource = tb;
            demsl();
            SizeGirdView();
        }
        private void LoadNgay1ChuaXuLy()
        {
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            dtTuNgayCXL.Value = startOfMonth;
        }
        private void Loadcbo()
        {
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_DANHMUCKHODUOC]";
            DataTable cbo = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");

            //cbo Nơi gửi phiếu lĩnh nội bộ chưa xử lý
            cboNoiGuiPLNBChuaXuLy.DataSource = cbo.Copy();
            cboNoiGuiPLNBChuaXuLy.DisplayMember = "TenKhoDuoc";
            cboNoiGuiPLNBChuaXuLy.ValueMember = "TenKhoDuoc";
            cboNoiGuiPLNBChuaXuLy.CustomAlignment = new string[] { "l", "l" };
            cboNoiGuiPLNBChuaXuLy.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi nhận phiếu lĩnh nội bộ chưa xử lý
            cboNoiNhanPLNBChuaXuLy.DataSource = cbo.Copy();
            cboNoiNhanPLNBChuaXuLy.DisplayMember = "TenKhoDuoc";
            cboNoiNhanPLNBChuaXuLy.ValueMember = "TenKhoDuoc";
            //code bản quyền riêng của a QUyền 
            cboNoiNhanPLNBChuaXuLy.CustomAlignment = new string[] { "l", "l" };
            cboNoiNhanPLNBChuaXuLy.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi gửi phiếu lĩnh nội bộ đã xử lý
            cboNoiGuiPLNBXuatKho.DataSource = cbo.Copy();
            cboNoiGuiPLNBXuatKho.DisplayMember = "TenKhoDuoc";
            cboNoiGuiPLNBXuatKho.ValueMember = "TenKhoDuoc";
            cboNoiGuiPLNBXuatKho.CustomAlignment = new string[] { "l", "l" };
            cboNoiGuiPLNBXuatKho.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi gửi phiếu lĩnh nội bộ đã xử lý
            cboNoiNhanPLNBXuatKho.DataSource = cbo.Copy();
            cboNoiNhanPLNBXuatKho.DisplayMember = "TenKhoDuoc";
            cboNoiNhanPLNBXuatKho.ValueMember = "TenKhoDuoc";
            cboNoiNhanPLNBXuatKho.CustomAlignment = new string[] { "l", "l" };
            cboNoiNhanPLNBXuatKho.CustomColumnStyle = new string[] { "t", "t" };


            //cbo Nơi gửi phiếu lĩnh nội bộ đã xuất kho
            cboNoiGuiPLNBXuatKho.DataSource = cbo.Copy();
            cboNoiGuiPLNBXuatKho.DisplayMember = "TenKhoDuoc";
            cboNoiGuiPLNBXuatKho.ValueMember = "TenKhoDuoc";
            cboNoiGuiPLNBXuatKho.CustomAlignment = new string[] { "l", "l" };
            cboNoiGuiPLNBXuatKho.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi nhận phiếu lĩnh nội bộ chưa xử lý đã xuất kho
            cboNoiNhanPLNBXuatKho.DataSource = cbo.Copy();
            cboNoiNhanPLNBXuatKho.DisplayMember = "TenKhoDuoc";
            cboNoiNhanPLNBXuatKho.ValueMember = "TenKhoDuoc";
            cboNoiNhanPLNBXuatKho.CustomAlignment = new string[] { "l", "l" };
            cboNoiNhanPLNBXuatKho.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Trạng Thái
            msql = "SELECT * FROM [dbo].[DUOC_KC_TRANGTHAI]";
            DataTable tt = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_TRANGTHAI");
            cboTrangThai.DataSource = tt.Copy();
            cboTrangThai.DisplayMember = "TenTrangThai";
            cboTrangThai.ValueMember = "IDTrangThai";
            cboTrangThai.CustomAlignment = new string[] { "l", "l" };
            cboTrangThai.CustomColumnStyle = new string[] { "t", "t" };
        }


        // Nút tìm chưa xứ lý
        private void btnTimPLNBChuaXuLy_Click(object sender, EventArgs e)
        {
            msql = "SELECT * FROM[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as a,[dbo].[DUOC_KC_Lo2023] as b where a.MaThuoc=b.MaThuoc and NgayLap between '" + Convert.ToDateTime(dtTuNgayCXL.Value).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(dtDenNgayCXL.Value).ToString("yyyy-MM-dd") + "' AND TrangThai = 1  ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            dgrPhieuLinhNBChuaXuLy.AutoGenerateColumns = false;
            dgrPhieuLinhNBChuaXuLy.DataSource = tb;
            demsl();
        }

        //Khai báo hàm gộp cột Mã Yêu Cầu giống nhau của bảng Chưa xử lý
        private void demsl()
        {
            for (int i = 0; i < dgrPhieuLinhNBChuaXuLy.RowCount - 1; i++) //compare data
            {
                var Row = dgrPhieuLinhNBChuaXuLy.Rows[i];
                string abc = Row.Cells[0].Value.ToString() + Row.Cells[1].Value.ToString().ToUpper();

                for (int j = i + 1; j < dgrPhieuLinhNBChuaXuLy.RowCount; j++)
                {
                    var Row8 = dgrPhieuLinhNBChuaXuLy.Rows[j];
                    string def = Row8.Cells[0].Value.ToString() + Row8.Cells[1].Value.ToString().ToUpper();
                    if (abc == def)
                    {

                        dgrPhieuLinhNBChuaXuLy.Rows.Remove(Row8);
                        j--;
                    }
                }
            }
        }
        // Khai báo hàm gộp cột Mã Yêu Cầu giống nhau của bảng Gần đây
        private void dems2()
        {
            for (int i = 0; i < dgrPhieuLinhNBDaXuatKho.RowCount - 1; i++) //compare data
            {
                var Row = dgrPhieuLinhNBDaXuatKho.Rows[i];
                string abc = Row.Cells[0].Value.ToString() + Row.Cells[1].Value.ToString().ToUpper();

                for (int j = i + 1; j < dgrPhieuLinhNBDaXuatKho.RowCount; j++)
                {
                    var Row8 = dgrPhieuLinhNBDaXuatKho.Rows[j];
                    string def = Row8.Cells[0].Value.ToString() + Row8.Cells[1].Value.ToString().ToUpper();
                    if (abc == def)
                    {

                        dgrPhieuLinhNBDaXuatKho.Rows.Remove(Row8);
                        j--;
                    }
                }
            }
        }
        private void txtMaPhieuPLNBChuaXuLy_Enter(object sender, EventArgs e)
        {
            txtMaPhieuPLNBChuaXuLy.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaPhieuPLNBChuaXuLy_Leave(object sender, EventArgs e)
        {
            txtMaPhieuPLNBChuaXuLy.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }
        //Đánh stt
        private void dgrPhieuLinhNBChuaXuLy_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrPhieuLinhNBChuaXuLy);
        }

        // Duyệt phiếu chưa xử lý
        private void dgrPhieuLinhNBChuaXuLy_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex == -1)
            //    return;
            //if (dgrPhieuLinhNBChuaXuLy["cDuyet", e.RowIndex] == dgrPhieuLinhNBChuaXuLy.CurrentCell)
            //{
            //    a = dgrPhieuLinhNBChuaXuLy.Rows[e.RowIndex].Cells[0].Value.ToString(); //Tạo biến a bằng hàm lấy dữ liệu cột O của DataGridview(gọi ở trên và truyền sang FrmXuatThuoc)
            //    FrmDuyetPhieuLinhNoiBo add = new FrmDuyetPhieuLinhNoiBo();
            //    add.ShowDialog();
            //}


            //Khi click vào sẽ hiển thị combobox theo DATAGRIDVIEW
            cboNoiGuiPLNBChuaXuLy.SelectedValue = dgrPhieuLinhNBChuaXuLy.CurrentRow.Cells[4].Value.ToString();
            cboNoiNhanPLNBChuaXuLy.SelectedValue = dgrPhieuLinhNBChuaXuLy.CurrentRow.Cells[5].Value.ToString();
            if (e.RowIndex == -1)
                return;
            if (dgrPhieuLinhNBChuaXuLy["cDuyet", e.RowIndex] == dgrPhieuLinhNBChuaXuLy.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn duyệt " + dgrPhieuLinhNBChuaXuLy.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString() + " này không ?"))
                {
                    ThucHienFiFoDK2();
                    //a = dgrPhieuLinhNBChuaXuLy.Rows[e.RowIndex].Cells[0].Value.ToString(); //Tạo biến a bằng hàm lấy dữ liệu cột O của DataGridview(gọi ở trên và truyền sang FrmXuatThuoc)
                    //a = dgrPhieuLinhNBChuaXuLy.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString(); //Tạo biến a bằng hàm lấy dữ liệu cột O của DataGridview(gọi ở trên và truyền sang FrmXuatThuoc)
                    msql = "UPDATE [dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]  SET TrangThai = 2 WHERE MaPhieuYeuCau = N'" + dgrPhieuLinhNBChuaXuLy.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString() + "'";
                    DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
                    dgrPhieuLinhNBChuaXuLy.AutoGenerateColumns = false;
                    dgrPhieuLinhNBChuaXuLy.DataSource = tb;
                    LoadDataDSPLNBChuaXuLy(); //Load lại dữ liệu khi nhấn

                    ev.QFrmThongBao("Bạn đã duyệt thành công");
                }
            }
        }
        private void ThucHienFiFoDK2()
        {
            msql = "exec FiFoKhoChan '','','','','','','','" + dgrPhieuLinhNBChuaXuLy.CurrentRow.Cells["cMaPhieuNhapKho"].Value.ToString() + "','',0,2";
            comm.RunSQL(mconnectstring, msql);
        }


        //LoadDataDS4
        public void LoadDataDSPLNBXuatKhoGanNhat()
        {
            //msql = "SELECT *, CASE WHEN TrangThai = 1 THEN N'DA DUYỆT' END AS TrangThai from [dbo].[DUOC_KC_XUATKHO_PHIEULINHNOIBOTHUOC_CHUAXULY] WHERE TrangThai = '1';";
            //msql = "SELECT * FROM [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC],[DUOC_KC_TRANGTHAI] WHERE TrangThai = 2";
            msql = "SELECT * FROM [DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC]  as A, [DUOC_KC_Lo2023] as B,[dbo].[DUOC_KC_THONGTINTHUOC_PHIEUYEUCAULINHTHUOCQUAYTHUOC] as C where TrangThai = 2 and A.MaPhieuYeuCau=C.MaPhieuYeuCau AND B.MaThuoc=C.MaThuoc ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            dgrPhieuLinhNBDaXuatKho.AutoGenerateColumns = false;
            dgrPhieuLinhNBDaXuatKho.DataSource = tb;
            //Gộp mã trùng (có thể dùng gộp cột để + SL)
            dems2();
            SizeGirdView();
        }
        //private void LoadDataXuatThuoc()
        //{
        //    Close();
        //    FrmXuatThuoc f = new FrmXuatThuoc();
        //    f.ShowDialog();
        //}

        private void LoadNgay1DaXuatKho()
        {
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            dtTuNgayXK.Value = startOfMonth;
        }

        private void txtMaPhieuPLNBXuatKho_Enter(object sender, EventArgs e)
        {
            txtMaPhieuPLNBXuatKho.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaPhieuPLNBXuatKho_Leave(object sender, EventArgs e)
        {
            txtMaPhieuPLNBXuatKho.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }
        //Đánh stt
        private void dgrPhieuLinhNBDaXuatKho_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrPhieuLinhNBDaXuatKho);
        }

   
        private void txtMaPhieuPLNBChuaXuLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTimPLNBChuaXuLy);
        }

        private void txtMaPhieuPhieuLinhNoiBoXuatKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTimPLNBDaXuatKho);
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataDSPLNBChuaXuLy();
        }

        //Hàm so sánh chẵn lẻ bên Noi Gui
        private void cboNoiGuiPLNBChuaXuLy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string c = cboNoiNhanPLNBChuaXuLy.GetItemText((cboNoiNhanPLNBChuaXuLy.SelectedItem));
            string b = cboNoiGuiPLNBChuaXuLy.GetItemText((cboNoiGuiPLNBChuaXuLy.SelectedValue));

            int resultt = 0;
            resultt = String.Compare(c, b);

            if (resultt == 0)
            {
                ev.QFrmThongBaoError("Hai kho không được trùng nhau");
                return;

            }

        }

        //Hàm so sánh chẵn lẻ bên Noi Nhan
        private void cboNoiNhanPLNBChuaXuLy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string c = cboNoiNhanPLNBChuaXuLy.GetItemText((cboNoiNhanPLNBChuaXuLy.SelectedItem));
            string b = cboNoiGuiPLNBChuaXuLy.GetItemText((cboNoiGuiPLNBChuaXuLy.SelectedItem));

            int resultt = 0;
            resultt = String.Compare(c, b);

            if (resultt == 0)
            {
                ev.QFrmThongBaoError("Hai kho không được trùng nhau");
                return;
            }

        }

        // Tìm Phiếu đã xuất kho
        private void btnTimPLNBDaXuatKho_Click(object sender, EventArgs e)
        {
            //msql = "SELECT * FROM[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] WHERE KhoDuocNoiGuiYeuCau=N'" + cboNoiGuiPLNBXuatKho.SelectedValue + "' and KhoDuocNoiNhanYeuCau=N'" + cboNoiNhanPLNBXuatKho.SelectedValue + "' AND [MaPhieuXuatKho]=N'" + txtMaPhieuPLNBXuatKho.Text + "' AND NgayLap between '" + Convert.ToDateTime(dtTuNgayXK.Value).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(dtDenNgayXK.Value).ToString("yyyy-MM-dd") + "' AND TrangThai = 2 ";
            //DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC");
            //dgrPhieuLinhNBDaXuatKho.AutoGenerateColumns = false;
            //dgrPhieuLinhNBDaXuatKho.DataSource = tb;
            LoadTrangThai();
            dems2();
        }
        //Hàm case load data TRẠNG THÁI
        private void LoadTrangThai()
        {
            int a = int.Parse(cboTrangThai.SelectedValue.ToString());
            switch (a)
            {
                case 2:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A, [DUOC_KC_TRANGTHAI] AS B WHERE A.TrangThai = 2 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtTuNgayXK.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtDenNgayXK.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable cn = comm.GetDataTable(mconnectstring, msql, "Đã duyệt ");
                    dgrPhieuLinhNBDaXuatKho.AutoGenerateColumns = false;
                    dgrPhieuLinhNBDaXuatKho.DataSource = cn;
                    dgrPhieuLinhNBDaXuatKho.Columns[11].Visible = true;
                    dgrPhieuLinhNBDaXuatKho.Columns[12].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[13].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[14].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[15].Visible = true;
                    break;
                case 3:
                    //msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as A, [DUOC_KC_TRANGTHAI] AS B WHERE A.TrangThai = 3 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtTuNgayXK.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtDenNgayXK.Value).ToString("yyyy-MM-dd") + "' and KhoDuocNoiGuiYeuCau=N'" + cboNoiGuiPLNBXuatKho.SelectedValue + "' and KhoDuocNoiNhanYeuCau=N'" + cboNoiNhanPLNBXuatKho.SelectedValue + "' AND [MaPhieuXuatKho]=N'" + txtMaPhieuPLNBXuatKho.Text + "'";
                    msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A, [DUOC_KC_TRANGTHAI] AS B WHERE A.TrangThai = 3 AND A.TrangThai = B.IDTrangThai AND NgayLap between '" + Convert.ToDateTime(dtTuNgayXK.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtDenNgayXK.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dh = comm.GetDataTable(mconnectstring, msql, "Đã hủy");
                    dgrPhieuLinhNBDaXuatKho.AutoGenerateColumns = false;
                    dgrPhieuLinhNBDaXuatKho.DataSource = dh;
                    dgrPhieuLinhNBDaXuatKho.Columns[11].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[12].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[13].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[14].Visible = true;
                    dgrPhieuLinhNBDaXuatKho.Columns[15].Visible = false;
                    break;
                case 4:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A, [DUOC_KC_TRANGTHAI] AS B ,[DUOC_KC_Lo2023] as C,[dbo].[DUOC_KC_THONGTINTHUOC_PHIEUYEUCAULINHTHUOCQUAYTHUOC] as D WHERE A.TrangThai = 4 AND A.TrangThai = B.IDTrangThai and C.MaThuoc=D.MaThuoc  AND NgayLap between '" + Convert.ToDateTime(dtTuNgayXK.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtDenNgayXK.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dct = comm.GetDataTable(mconnectstring, msql, "Đã cấp thuốc");
                    dgrPhieuLinhNBDaXuatKho.AutoGenerateColumns = false;
                    dgrPhieuLinhNBDaXuatKho.DataSource = dct;
                    dgrPhieuLinhNBDaXuatKho.Columns[11].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[12].Visible = true;
                    dgrPhieuLinhNBDaXuatKho.Columns[13].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[14].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[15].Visible = true;
                    break;
                case 5:
                    msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B,DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT as C WHERE A.TrangThai = 5 AND A.TrangThai = B.IDTrangThai and A.MaPhieuYeuCau=C.MaPhieuYeuCau AND NgayLap between '" + Convert.ToDateTime(dtTuNgayXK.Value).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dtDenNgayXK.Value).ToString("yyyy-MM-dd") + "'";
                    DataTable dlt = comm.GetDataTable(mconnectstring, msql, "Đã lưu trữ");
                    dgrPhieuLinhNBDaXuatKho.AutoGenerateColumns = false;
                    dgrPhieuLinhNBDaXuatKho.DataSource = dlt;
                    dgrPhieuLinhNBDaXuatKho.Columns[11].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[12].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[13].Visible = true;
                    dgrPhieuLinhNBDaXuatKho.Columns[14].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns[15].Visible = false;
                    dgrPhieuLinhNBDaXuatKho.Columns["cIn"].Visible = true;
                    break;
            }
        }
        // Các thao tác của đã xuất kho
        private void dgrPhieuLinhNBDaXuatKho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {



            txtMaPhieuPLNBXuatKho.Text= dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuXuatKho"].Value.ToString();
            //Khi click vào sẽ hiển thị combobox theo DATAGRIDVIEW
            cboNoiGuiPLNBXuatKho.SelectedValue = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells[5].Value.ToString();
            cboNoiNhanPLNBXuatKho.SelectedValue = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells[6].Value.ToString();
            //Tạo biến a bằng hàm lấy dữ liệu cột O của DataGridview(gọi ở trên và truyền sang FrmXuatThuoc)
            if (e.RowIndex == -1)
                return;
            {
                // msql = "UPDATE [dbo].[DUOC_KC_XUATKHO_PHIEULINHNOIBOTHUOC_DEXUATKHOGANNHAT] SET [TrangThai] = N'True' WHERE MaPhieuYeuCau= N'" + dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString() + "' ";

                if (dgrPhieuLinhNBDaXuatKho["cXem", e.RowIndex] == dgrPhieuLinhNBDaXuatKho.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn duyệt " + dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString() + " này không ?"))
                    {
                        FrmDuyetPhieuLinhNoiBo add = new FrmDuyetPhieuLinhNoiBo(); //tạo Frm mới
                        MaPhieuYeuCau = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells[1].Value.ToString(); // Lấy mã phiếu từ cột MaPhieuYeuCau cua dgrDaxuatkho truyền vào biến a
                        add.txtMaYeuCauPhieuLinh.Text = MaPhieuYeuCau.ToString(); // Truyền chuỗi biến a vào txt FrmDuyetPhieuLinhNoiBo
                        add.LoadDataDuyet();// LoadDataDuyet của FrmDuyetPhieuLinhNoiBo để update dữ liệu lên Frm
                        FrmTongHop tonghop = new FrmTongHop();                       
                        add.ShowDialog();
                        tonghop.Close();
                    }
                }

                else if (dgrPhieuLinhNBDaXuatKho["cChiTietPhieu3", e.RowIndex] == dgrPhieuLinhNBDaXuatKho.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn Xem chi tiết phiếu " + dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString() + " này không ?"))
                    {
                        //Tạo các biến này để dùng cho FRM CẤP
                        MaPhieuYeuCau = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString(); // Lấy mã phiếu từ cột MaPhieuYeuCau cua dgrDaxuatkho truyền vào biến a
                        MaLo = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaLo"].Value.ToString();
                        Lo = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cLo"].Value.ToString();
                        FrmChiTietPhieuLinh add = new FrmChiTietPhieuLinh(); //tạo Frm mới
                        add.LoadDataTrangThai3();
                        
                        add.ShowDialog(); //Show Frm mới khởi tạo lên  
                    }
                }

                else if (dgrPhieuLinhNBDaXuatKho["cChiTietPhieu4", e.RowIndex] == dgrPhieuLinhNBDaXuatKho.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn Xem chi tiết phiếu " + dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString() + " này không ?"))
                    {
                        MaPhieuYeuCau = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString(); // Lấy mã phiếu từ cột MaPhieuYeuCau cua dgrDaxuatkho truyền vào biến a
                        MaLo = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaLo"].Value.ToString();
                        Lo = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cLo"].Value.ToString();
                        FrmChiTietPhieuLinh add = new FrmChiTietPhieuLinh(); //tạo Frm mới
                        add.LoadDataTrangThai4();
                        
                        add.ShowDialog(); //Show Frm mới khởi tạo lên  
                    }
                }


                else if (dgrPhieuLinhNBDaXuatKho["cChiTietPhieu5", e.RowIndex] == dgrPhieuLinhNBDaXuatKho.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn Xem chi tiết phiếu " + dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString() + " này không ?"))
                    {
                        MaPhieuYeuCau = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString(); // Lấy mã phiếu từ cột MaPhieuYeuCau cua dgrDaxuatkho truyền vào biến a
                        MaLo = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaLo"].Value.ToString();
                        Lo = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cLo"].Value.ToString();
                        FrmChiTietPhieuLinh add = new FrmChiTietPhieuLinh(); //tạo Frm mới
                        add.LoadDataTrangThai5();
                        
                        add.ShowDialog(); //Show Frm mới khởi tạo lên  
                    }
                }


                //ĐỂ cXÓA DƯỚI CÙNG ĐỂ TRÁNH TRÀN DỮ LIỆU, SAI THÔNG SỐ
                else if (dgrPhieuLinhNBDaXuatKho["cXoa", e.RowIndex] == dgrPhieuLinhNBDaXuatKho.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn Hủy " + dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString() + " này không ?"))
                    {
                        UpdateTrangThai3_FrmPhieuYeuCauLinhThuocOQuayThuoc();
                        UpdateTrangThai3_FrmDUYETPHIEULINHNOIBO_THONGTINPHIEUXUAT();
                        UpdateTrangThai3_FrmDUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT();
                        LoadDataDSPLNBXuatKhoGanNhat();
                        ev.QFrmThongBao("Bạn đã hủy phiếu thành công");
                    }
                }
                else if (dgrPhieuLinhNBDaXuatKho["cIn", e.RowIndex] == dgrPhieuLinhNBDaXuatKho.CurrentCell)
                {
                    if (ev.QFrmThongBao_YesNo("Bạn có muốn in " + dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString() + " này không ?"))
                    {
                        R1 = dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString();
                        FrmRPPhieuLinhThuoc frm = new FrmRPPhieuLinhThuoc();
                        frm.ShowDialog();
                      
                    }
                }
            }
        }
        //Tạo hàm Update Trạng Thái 3 (Hủy)
        private void UpdateTrangThai3_FrmPhieuYeuCauLinhThuocOQuayThuoc()
        {
            msql = "UPDATE [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] SET TrangThai = 3 WHERE MaPhieuYeuCau = N'" + dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString() + "'";
            comm.RunSQL(mconnectstring, msql);
        }

        private void UpdateTrangThai3_FrmDUYETPHIEULINHNOIBO_THONGTINPHIEUXUAT()
        {
            msql = "UPDATE [dbo].[DUYETPHIEULINHNOIBO_THONGTINPHIEUXUAT] SET TrangThai = 3 WHERE MaPhieuYeuCau = N'" + dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString() + "'";
            comm.RunSQL(mconnectstring, msql);
        }
        private void UpdateTrangThai3_FrmDUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT()
        {
            msql = "UPDATE [dbo].[DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT] SET TrangThai = 3 WHERE MaPhieuYeuCau = N'" + dgrPhieuLinhNBDaXuatKho.CurrentRow.Cells["cMaPhieuYeuCau1"].Value.ToString() + "'";
            comm.RunSQL(mconnectstring, msql);
        }


        // so sánh hai nơi nhận bảng dgr xuat kho
        private void cboNoiGuiPLNBXuatKho_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string c = cboNoiNhanPLNBXuatKho.GetItemText((cboNoiNhanPLNBXuatKho.SelectedItem));
            string b = cboNoiGuiPLNBXuatKho.GetItemText((cboNoiGuiPLNBXuatKho.SelectedValue));

            int resultt = 0;
            resultt = String.Compare(c, b);

            if (resultt == 0)
            {
                ev.QFrmThongBaoError("Hai kho không được trùng nhau");
                return;
            }
        }

        private void cboNoiNhanPLNBXuatKho_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string c = cboNoiNhanPLNBXuatKho.GetItemText((cboNoiNhanPLNBXuatKho.SelectedItem));
            string b = cboNoiGuiPLNBXuatKho.GetItemText((cboNoiGuiPLNBXuatKho.SelectedItem));

            int resultt = 0;
            resultt = String.Compare(c, b);

            if (resultt == 0)
            {
                ev.QFrmThongBaoError("Hai kho không được trùng nhau");
                return;
            }
        }

        private void btnLoadXuatKho_Click(object sender, EventArgs e)
        {
            LoadDataDSPLNBXuatKhoGanNhat();
        }

        private void dgrPhieuLinhNBChuaXuLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrPhieuLinhNBChuaXuLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboNoiGuiPLNBChuaXuLy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgrPhieuLinhNBChuaXuLy_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrPhieuLinhNBChuaXuLy);
        }

        private void FrmXuatThuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void ExportToExcel(List<string> selectedColumns, string exportPath)
        {
            // Create a DataTable to store the exported data
            DataTable exportTable = new DataTable();

            // Populate DataTable with selected columns
            foreach (string columnName in selectedColumns)
            {
                // Use the header text as the column name
                string headerText = dgrPhieuLinhNBDaXuatKho.Columns[columnName].HeaderText;
                exportTable.Columns.Add(headerText);
            }

            // Populate DataTable with data from DataGridView
            foreach (DataGridViewRow row in dgrPhieuLinhNBDaXuatKho.Rows)
            {
                DataRow newRow = exportTable.NewRow();
                foreach (string columnName in selectedColumns)
                {
                    // Use the header text as the column name
                    string headerText = dgrPhieuLinhNBDaXuatKho.Columns[columnName].HeaderText;

                    // Handle DBNull and null values
                    object cellValue = row.Cells[columnName].Value;
                    newRow[headerText] = (cellValue != null && cellValue != DBNull.Value) ? cellValue : DBNull.Value;
                }
                exportTable.Rows.Add(newRow);
            }

            // Define the Excel file path
            string excelFilePath = Path.Combine(exportPath, "ExportedData.xlsx");

            // Create and save the Excel document
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(excelFilePath, SpreadsheetDocumentType.Workbook))
            {
                // Add workbook part
                spreadsheetDocument.AddWorkbookPart();
                spreadsheetDocument.WorkbookPart.Workbook = new Workbook();

                // Add worksheet part
                WorksheetPart worksheetPart = spreadsheetDocument.WorkbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                // Get the sheet data
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Add header row to the Excel sheet
                Row headerRow = new Row();
                foreach (string columnName in selectedColumns)
                {
                    string headerText = dgrPhieuLinhNBDaXuatKho.Columns[columnName].HeaderText;
                    Cell cell = new Cell(new CellValue(headerText));
                    headerRow.AppendChild(cell);
                }
                sheetData.AppendChild(headerRow);

                // Add data rows to the Excel sheet
                foreach (DataRow dataRow in exportTable.Rows)
                {
                    Row newRow = new Row();
                    foreach (string columnName in selectedColumns)
                    {
                        string headerText = dgrPhieuLinhNBDaXuatKho.Columns[columnName].HeaderText;
                        newRow.AppendChild(new Cell(new CellValue(dataRow[headerText].ToString())));
                    }
                    sheetData.AppendChild(newRow);
                }

                // Add sheet information to the workbook
                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
                sheets.Append(sheet);

                // Save the Excel document
                spreadsheetDocument.Save();
            }

            // Display success message
            MessageBox.Show($"Xuất Excel thành công! Đã lưu tại: {excelFilePath}");
        }
        private void btnExcelPLNBDaXuatKho_Click(object sender, EventArgs e)
        {
            // Create a mapping for DataGridView column names and their corresponding export names
            Dictionary<string, string> columnMapping = new Dictionary<string, string>
    {
        //{"cMaNhaCungCap", "Mã"},
        //{"cTenNhaSanXuat", "Tên nhà cung cấp"},
        //{"cSDT", "Số điện thoại"},
        //{"cDiaChi", "Địa chỉ"},
        // Add other mappings as needed
    };

            // Get the selected columns using the mapping
            List<string> selectedColumns = new List<string>(columnMapping.Keys);

            // Show the folder browser dialog to choose the export path
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = defaultFolderPath;
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    defaultFolderPath = folderBrowserDialog.SelectedPath;

                    // Call the ExportToExcel method with the selected columns and export path
                    ExportToExcel(selectedColumns, defaultFolderPath);
                }
            }
        }
    }
}
