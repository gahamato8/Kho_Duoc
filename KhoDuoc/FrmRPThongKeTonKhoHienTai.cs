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
    public partial class FrmRPThongKeTonKhoHienTai : Form
    {

        private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        ReportDocument BaoCao = new ReportDocument();
        public FrmRPThongKeTonKhoHienTai()
        {
            InitializeComponent();
            Report();
            
        }

        private void Report()
        {
            msql = "select * from tabDanhMucThuoc as a ,tabMANGUOIBAN as b where a.MANGUOIBAN=b.MANGUOIBAN and a.MaThuoc ='" + FrmThongKeTonKhoHienTai.R + "'";
            //Chạy lên lần đầu sau khi có dữ liệu nhớ mở ra, sau khi ghi được thì đóng lại
            //comm.GhiFileXmlReport(mconnecstring, msql, "d", "rpBaoCaoTheKho");
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
            BaoCao.Load(Application.StartupPath + @"\thongketonkhohientai.rpt");
            BaoCao.SetDataSource(tb);
            ReportThongketonkhohientai.ReportSource = BaoCao;
        }


        public void Report1()
        {
            msql = "select * from tabDanhMucThuoc as a ,tabMANGUOIBAN as b where a.MANGUOIBAN=b.MANGUOIBAN";
            //Chạy lên lần đầu sau khi có dữ liệu nhớ mở ra, sau khi ghi được thì đóng lại
            //comm.GhiFileXmlReport(mconnecstring, msql, "d", "rpBaoCaoTheKho");
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
            BaoCao.Load(Application.StartupPath + @"\thongketonkhohientai.rpt");
            BaoCao.SetDataSource(tb);
            ReportThongketonkhohientai.ReportSource = BaoCao;
        }
    }
}
