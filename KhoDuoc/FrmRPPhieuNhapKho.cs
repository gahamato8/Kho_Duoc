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
    public partial class FrmRPPhieuNhapKho : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        ReportDocument BaoCao = new ReportDocument();
        public FrmRPPhieuNhapKho()
        {
            InitializeComponent();
         
            Report1();
            txtMaPhieuCNP.Text = FrmNhapThuoc.R;
            txtMaPhieuCNP.Text = FrmNhapThuoc.R1;

        }

        private void Report1()
        {
            msql = "select* from[dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC]as a ,[dbo].[DUOC_KC_Lo2023] as b,[dbo].[tabMANGUOIBAN] as c where a.MaPhieuNhapKho = b.MaPhieuNhapKho and a.MANGUOIBAN = c.MANGUOIBAN and a.MaPhieuNhapKho='" + FrmNhapThuoc.R1+ "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "[DUOC_KC_NHAPKHO_NHAPTHUOC]");
            BaoCao.Load(Application.StartupPath + @"\phieunhapkho.rpt");
            BaoCao.SetDataSource(tb);
            RpPhieuNhapKho.ReportSource = BaoCao;
        }

        private void button1_Click(object sender, EventArgs e)
        {




            msql = "select* from[dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC]as a ,[dbo].[DUOC_KC_Lo2023] as b,[dbo].[tabMANGUOIBAN] as c where a.MaPhieuNhapKho = b.MaPhieuNhapKho and a.MANGUOIBAN = c.MANGUOIBAN and a.MaPhieuNhapKho='" + txtMaPhieuCNP.Text + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "[DUOC_KC_NHAPKHO_NHAPTHUOC]");
            BaoCao.Load(Application.StartupPath + @"\phieunhapkho.rpt");
            BaoCao.SetDataSource(tb);
            RpPhieuNhapKho.ReportSource = BaoCao;
        }
        //p

        //private void Report()
        //{
        //    msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THEKHO]";
        //    //Chạy lên lần đầu sau khi có dữ liệu nhớ mở ra, sau khi ghi được thì đóng lại
        //    //comm.GhiFileXmlReport(mconnecstring, msql, "d", "rpBaoCaoTheKho");
        //    DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
        //    BaoCao.Load(Application.StartupPath + @"\baocaothekho.rpt");
        //    BaoCao.SetDataSource(tb);
        //    crystalReportViewer1.ReportSource = BaoCao;
    }
}
