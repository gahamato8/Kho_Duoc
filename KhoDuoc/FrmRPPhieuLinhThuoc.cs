using BusinessCommon;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoDuoc
{
    public partial class FrmRPPhieuLinhThuoc : Form
    {

        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
      ReportDocument BaoCao = new ReportDocument();

        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;



        public FrmRPPhieuLinhThuoc()
        {
            InitializeComponent();
            Report();
        }


        private void Report()
        {
            msql = "SELECT DISTINCT a.MaPhieuYeuCau,a.NguoiLap,a.Loai,a.PhanLoai,a.KhoDuocNoiGuiYeuCau,a.NgayLinh,a.NgayLap,a.GhiChu,a.MaPhieuXuatKho,a.TrangThai,b.MaTrangThai,b.TenTrangThai,c.MaThuoc,c.Lo,c.TenThuoc_VatTu,c.SoLuongYeuCau, c.GhiChu ,c.DonVi,c.SoLuongCap,c.DonVi,c.MaLo,c.Ton,c.HanDung FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B,DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT as C WHERE A.TrangThai = 5 AND A.TrangThai = B.IDTrangThai and A.MaPhieuYeuCau=C.MaPhieuYeuCau and A.MaPhieuYeuCau='" + FrmXuatThuoc.R1+"' ";
            //Chạy lên lần đầu sau khi có dữ liệu nhớ mở ra, sau khi ghi được thì đóng lại
            //comm.GhiFileXmlReport(mconnecstring, msql, "d", "rpBaoCaoTheKho");
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
            BaoCao.Load(Application.StartupPath + @"\phieulinhthuoc.rpt");
            BaoCao.SetDataSource(tb);
            rptPhieuLinhThuoc.ReportSource = BaoCao;
        }






    }
}
