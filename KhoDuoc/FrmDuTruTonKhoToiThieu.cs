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

namespace KhoDuoc
{
    public partial class FrmDuTruTonKhoToiThieu : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        ReportDocument BaoCao = new ReportDocument();

        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        //Chưa làm btn Lấy dữ liệu
        //Chưa làm btn Lập dự trù
        //Chưa làm btn Lập dự trù mua hàng
        public FrmDuTruTonKhoToiThieu()
        {
            InitializeComponent();
            //Report();
            LoadData();

        }
      
        private void Report()
        {
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_BAOCAODUTRUTONKHOTOITHIEU] where MaThuoc= N'" + txtNhapMaThuoc.Text + "' ";
            //comm.GhiFileXmlReport(mconnecstring, msql, "d", "DSChucVu");
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_BAOCAODUTRUTONKHOTOITHIEU");
            BaoCao.Load(Application.StartupPath + @"\dutrutonkhotoithieu.rpt");
            //BaoCao.DataDefinition.FormulaFields["txtNgayThang"].Text = "'" + tieude + "'";
            BaoCao.SetDataSource(tb);

            ReportDuTruTonKhoToiThieu.ReportSource = BaoCao;
        }


        private void FrmDuTruTonKhoToiThieu_Load(object sender, EventArgs e)
        {
            dtNgay.Value = DateTime.Now;
        }
        private void LoadData()
        {
            msql = "SELECT * FROM [dbo].[DUOC_KC_BAOCAODUTRUTONKHOTOITHIEU]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_BAOCAODUTRUTONKHOTOITHIEU");

            cboTenThuoc.DataSource = tb.Copy();
            cboTenThuoc.ValueMember = "MaThuoc";
            cboTenThuoc.DisplayMember = "TenThuoc";
            cboTenThuoc.CustomAlignment = new string[] { "l", "l" };
            cboTenThuoc.CustomColumnStyle = new string[] { "t", "t" };
            cboTenThuoc.sf = setfocusTenThuoc;

            //cbo Loại
            
        }
        private int setfocusTenThuoc()
        {
            txtNhapMaThuoc.Focus();
            return 1;
        }
        private void txtNhapMaThuoc_Enter(object sender, EventArgs e)
        {
            txtNhapMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNhapMaThuoc_Leave(object sender, EventArgs e)
        {
            txtNhapMaThuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNhapMaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
           // ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNhapTenThuoc);
        }

        private void txtNhapTenThuoc_Enter(object sender, EventArgs e)
        {
           // txtNhapTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNhapTenThuoc_Leave(object sender, EventArgs e)
        {
           // txtNhapTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        //Đánh stt
        private void dgrDuTruTonKhoToiThieu_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        }
        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            Report();
        }

        private void btnLapDuTru_Click(object sender, EventArgs e)
        {

        }

        private void btnLapDuTruMuaHang_Click(object sender, EventArgs e)
        {

        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnLayDuLieu);

        }
    }
}
