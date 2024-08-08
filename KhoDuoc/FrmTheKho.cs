using BusinessCommon;
//using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FrmTheKho : Form
    {
        public static string mconnectstring = "server=.; database=KHODUOC;uid=sa;pwd=123";
        //ReportDocument BaoCao = new ReportDocument();
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;





        public FrmTheKho()
        {
            InitializeComponent();
            //Report();

        }

        //private void Report()
        //{
        //    msql = "SELECT * FROM [dbo].[DUOC_KHOCHAN_THEKHO]";
        //    //comm.GhiFileXmlReport(mconnecstring, msql, "d", "DSChucVu");
        //    DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KHOCHAN_THEKHO");
        //    BaoCao.Load(Application.StartupPath + @"\Thekho.rpt");
        //    //BaoCao.DataDefinition.FormulaFields["txtNgayThang"].Text = "'" + tieude + "'";
        //    BaoCao.SetDataSource(tb);
        //    ReportTheKho.ReportSource = BaoCao;
        //}




//        private void btnIn_Click(object sender, EventArgs e)
//        {
//Report();
//        }

        private void txtThuocVatTu_Enter(object sender, EventArgs e)
        {
            txtThuocVatTu.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtThuocVatTu_Leave(object sender, EventArgs e)
        {
            txtThuocVatTu.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtThuocVatTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTim);

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
