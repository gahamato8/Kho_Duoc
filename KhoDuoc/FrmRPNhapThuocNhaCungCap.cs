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
    public partial class FrmRPNhapThuocNhaCungCap : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private string msql;
        ReportDocument BaoCao = new ReportDocument();

        public FrmRPNhapThuocNhaCungCap()
        {
            InitializeComponent();
            Report1();
        }




        private void Report1()
        {
            msql = "select *from [dbo].[DUOC_KC_NHAPKHO_NHAPNHACUNGCAP] as a, [dbo].[tabMANGUOIBAN] as b where a.DonViBan=b.MANGUOIBAN and a.MaPhieuNhapKhoNCC='" + FrmNhapTuNhaCungCap.R+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "[DUOC_KC_NHAPKHO_NHAPTHUOC]");
            BaoCao.Load(Application.StartupPath + @"\phieunhapkhonhacungcap.rpt");
            BaoCao.SetDataSource(tb);
            RpPhieuNhapKho.ReportSource = BaoCao;
        }
    }
}
