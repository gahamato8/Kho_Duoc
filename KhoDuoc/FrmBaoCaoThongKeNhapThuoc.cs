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
//using CrystalDecisions.CrystalReports.Engine;
using FlexCel;

namespace KhoDuoc
{
    public partial class FrmBaoCaoThongKeNhapThuoc : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        //ReportDocument BaoCao = new ReportDocument();


        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public FrmBaoCaoThongKeNhapThuoc()
        {
            InitializeComponent();
            //Report();
            LoadData();
        }


        //private void Report()
        //{
        //    msql = "SELECT * FROM [dbo].[DUOC_KC_BAOCAOTHONGKENHAPTHUOC]";
        //    //Chạy lên lần đầu sau khi có dữ liệu nhớ mở ra, sau khi ghi được thì đóng lại
        //    //comm.GhiFileXmlReport(mconnecstring, msql, "d", "rpBaoCaoTheKho");
        //    DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_BAOCAOTHONGKENHAPTHUOC");
        //    BaoCao.Load(Application.StartupPath + @"\baocaothongkennhapthuoc.rpt");
        //    BaoCao.SetDataSource(tb);
        //    ReportThongKeNhapThuoc.ReportSource = BaoCao;
        //}




        //Load Data
        private void LoadData()
        {
            msql = "SELECT *   FROM [KHODUOC].[dbo].[DUOC_KC_BAOCAOTHONGKENHAPTHUOC]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_BAOCAOTHONGKENHAPTHUOC");

            //cbo Kho Dược
            cboKhoDuoc.DataSource = tb.Copy();
            cboKhoDuoc.DisplayMember = "KhoDuoc";
            cboKhoDuoc.ValueMember = "KhoDuoc";
            cboKhoDuoc.CustomAlignment = new string[] { "l", "l" };
            cboKhoDuoc.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Trạng Thái
            cboTrangThai.DataSource = tb.Copy();
            cboTrangThai.DisplayMember = "TrangThai";
            cboTrangThai.ValueMember = "TrangThai";
            cboTrangThai.CustomAlignment = new string[] { "l", "l" };
            cboTrangThai.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Mẫu Báo Cáo
            cboMauBaoCao.DataSource = tb.Copy();
            cboMauBaoCao.DisplayMember = "MauBaoCao";
            cboMauBaoCao.ValueMember = "MauBaoCao";
            cboMauBaoCao.CustomAlignment = new string[] { "l", "l" };
            cboMauBaoCao.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Loại
            cboLoai.DataSource = tb.Copy();
            cboLoai.DisplayMember = "Loai";
            cboLoai.ValueMember = "Loai";
            cboLoai.CustomAlignment = new string[] { "l", "l" };
            cboLoai.CustomColumnStyle = new string[] { "t", "t" };
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

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenThuoc);
        }

        private void txtTenThuoc_Enter(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenThuoc);
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

        private void txtMaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenThuoc);

        }

        private void txtTenThuoc_Enter_1(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_Leave_1(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenThuoc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboTrangThai);
        }
    }

}
