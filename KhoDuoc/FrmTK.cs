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
    public partial class FrmTheKho : Form
    {
        public static string mconnectstring = "server=.; database=KHODUOC;uid=sa;pwd=123";
        ReportDocument BaoCao = new ReportDocument();
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;





        public FrmTheKho()
        {
            InitializeComponent();
            LoadData();

        }

        private void Report()
        {
            msql = "SELECT * FROM [dbo].[DUOC_KC_THEKHO] WHERE KhoDuoc= N'" + cboKhoDuoc.SelectedValue + "' OR Loai = N'" + cboLoai.SelectedValue + "'  ";
            //comm.GhiFileXmlReport(mconnecstring, msql, "d", "DSChucVu");
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_THEKHO");
            BaoCao.Load(Application.StartupPath + @"\Thekho.rpt");
            //BaoCao.DataDefinition.FormulaFields["txtNgayThang"].Text = "'" + tieude + "'";
            BaoCao.SetDataSource(tb);
            ReportTheKho.ReportSource = BaoCao;
        }


        private void LoadData()
        {
            msql = "SELECT * FROM [dbo].[DUOC_KC_THEKHO] ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_THEKHO");

            //cbo Kho Dược
            cboKhoDuoc.DataSource = tb.Copy();
            cboKhoDuoc.DisplayMember = "KhoDuoc";
            cboKhoDuoc.ValueMember = "KhoDuoc";
            cboKhoDuoc.CustomAlignment = new string[] { "l", "l" };
            cboKhoDuoc.CustomColumnStyle = new string[] { "t", "t" };
            //cbo Loại
            cboLoai.DataSource = tb.Copy();
            cboLoai.DisplayMember = "Loai";
            cboLoai.ValueMember = "Loai";
            cboLoai.CustomAlignment = new string[] { "l", "l" };
            cboLoai.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nhóm Dược Lý

        }
        private int setfocusThuoc()
        {
            cboKhoDuoc.Focus();
            return 1;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Report();
        }

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
            //ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTim);

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Report();
        }
    }
}
