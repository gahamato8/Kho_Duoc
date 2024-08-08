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
using CrystalDecisions.CrystalReports.Engine;
using FlexCel;

namespace KhoDuoc
{
    public partial class FrmBaoCaoThongKeNhapThuoc1 : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        ReportDocument BaoCao = new ReportDocument();


        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public FrmBaoCaoThongKeNhapThuoc1()
        {
            InitializeComponent();
            //Report();
            LoadData();
        }


        private void Report()
        {
            msql = "SELECT* FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] as A ,[dbo].[DUOC_KC_Lo2023] as B,[dbo].[tabDanhMucThuoc] as C,[dbo].[tabMANGUOIBAN] as D where A.MaPhieuNhapKho=B.MaPhieuNhapKho and B.MaThuoc=C.MaThuoc and C.MANGUOIBAN=D.MANGUOIBAN and B.MaThuoc='" + txtMaThuoc.Text+"'";
            //Chạy lên lần đầu sau khi có dữ liệu nhớ mở ra, sau khi ghi được thì đóng lại
            //comm.GhiFileXmlReport(mconnecstring, msql, "d", "rpBaoCaoTheKho");
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_BAOCAOTHONGKENHAPTHUOC");
            BaoCao.Load(Application.StartupPath + @"\baocaothongkenhapthuoc.rpt");
            BaoCao.SetDataSource(tb);
            ReportThongKeNhapThuoc.ReportSource = BaoCao;
        }
        private void Report1()
        {
            msql = "SELECT* FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] as A ,[dbo].[DUOC_KC_Lo2023] as B,[dbo].[tabDanhMucThuoc] as C,[dbo].[tabMANGUOIBAN] as D where A.MaPhieuNhapKho=B.MaPhieuNhapKho and B.MaThuoc=C.MaThuoc and C.MANGUOIBAN=D.MANGUOIBAN ";
            //Chạy lên lần đầu sau khi có dữ liệu nhớ mở ra, sau khi ghi được thì đóng lại
            //comm.GhiFileXmlReport(mconnecstring, msql, "d", "rpBaoCaoTheKho");
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_BAOCAOTHONGKENHAPTHUOC");
            BaoCao.Load(Application.StartupPath + @"\baocaothongkenhapthuoc.rpt");
            BaoCao.SetDataSource(tb);
            ReportThongKeNhapThuoc.ReportSource = BaoCao;
        }



        //Load Data
        private void LoadData()
        {
            msql = "SELECT* FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] as A ,[dbo].[DUOC_KC_Lo2023] as B,[dbo].[tabDanhMucThuoc] as C,[dbo].[tabMANGUOIBAN] as D where A.MaPhieuNhapKho=B.MaPhieuNhapKho and B.MaThuoc=C.MaThuoc and C.MANGUOIBAN=D.MANGUOIBAN ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_BAOCAOTHONGKENHAPTHUOC");
            dgrdanhsachthuoc.AutoGenerateColumns = false;
            dgrdanhsachthuoc.DataSource = tb;


        }

        //report
      


        // Tương tác

        private void txtMa_Enter(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

      
        private void txtMaThuoc_Enter(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaThuoc_Leave(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

    
        private void txtTenThuoc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboTrangThai);
        }

       

        private void btnIn_Click(object sender, EventArgs e)
        {
            Report();
        }

        private void btnInTatCa_Click(object sender, EventArgs e)
        {
            Report1();
        }

        private void dgrdanhsachthuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaThuoc.Text = dgrdanhsachthuoc.CurrentRow.Cells["cMaThuoc"].Value.ToString();
            txtTenThuoc.Text = dgrdanhsachthuoc.CurrentRow.Cells["cTenThuoc"].Value.ToString();
            dgrdanhsachthuoc.Visible = false;
        }

        private void txtTenThuoc_Click(object sender, EventArgs e)
        {
            dgrdanhsachthuoc.Visible = true;
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
