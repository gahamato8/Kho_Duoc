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
    public partial class FrmBaoCaoXuatNhapTonHanDung : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        ReportDocument BaoCao = new ReportDocument();
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        bool on = true;
        bool toggleLight = true;

        public FrmBaoCaoXuatNhapTonHanDung()
        {
            InitializeComponent();
            
            LoadData();
        }



        private void Report()
        {
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_BAOCAOXUATNHAPTONHANDUNG]  WHERE KhoDuoc = N'" + cboKhoDuoc.SelectedValue + "' OR NguonNhapHang= N'" + cboNguonNhapHang.SelectedValue + "'OR HopDongThau = N'" + cboHopDongThau.SelectedValue + "' OR NhomTheo = N'" + cboNhomTheo.SelectedValue + "' OR Loai = N'" + cboLoai.SelectedValue + "' OR  NhomDuocLy = N'" + cboNhomDuocLy.SelectedValue + "'";
            //comm.GhiFileXmlReport(mconnecstring, msql, "d", "DSChucVu");
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_BAOCAOXUATNHAPTONHANDUNG");
            BaoCao.Load(Application.StartupPath + @"\xuatnhaptonhd.rpt");
            //BaoCao.DataDefinition.FormulaFields["txtNgayThang"].Text = "'" + tieude + "'";
            BaoCao.SetDataSource(tb);
            ReportXNtonHD.ReportSource = BaoCao;
        }



        //Load Data
        private void LoadData()
        {
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_BAOCAOXUATNHAPTONHANDUNG]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_BAOCAOXUATNHAPTONHANDUNG");

            //cbo Kho Dược
            cboKhoDuoc.DataSource = tb.Copy();
            cboKhoDuoc.DisplayMember = "KhoDuoc";
            cboKhoDuoc.ValueMember = "KhoDuoc";
            cboKhoDuoc.CustomAlignment = new string[] { "l", "l" };
            cboKhoDuoc.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nguồn Nhập Hàng Xuất Nhập Tồn Hạn Dùng
            cboNguonNhapHang.DataSource = tb.Copy();
            cboNguonNhapHang.DisplayMember = "NguonNhapHang";
            cboNguonNhapHang.ValueMember = "NguonNhapHang";
            cboNguonNhapHang.CustomAlignment = new string[] { "l", "l" };
            cboNguonNhapHang.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Hợp Đồng Thầu Xuất Nhập Tồn Hạn Dùng
            cboHopDongThau.DataSource = tb.Copy();
            cboHopDongThau.DisplayMember = "HopDongThau";
            cboHopDongThau.ValueMember = "HopDongThau";
            cboHopDongThau.CustomAlignment = new string[] { "l", "l" };
            cboHopDongThau.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nhóm Theo Xuất Nhập Tồn Hạn Dùng
            cboNhomTheo.DataSource = tb.Copy();
            cboNhomTheo.DisplayMember = "NhomTheo";
            cboNhomTheo.ValueMember = "NhomTheo";
            cboNhomTheo.CustomAlignment = new string[] { "l", "l" };
            cboNhomTheo.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Loại Xuất Nhập Tồn Hạn Dùng
            cboLoai.DataSource = tb.Copy();
            cboLoai.DisplayMember = "Loai";
            cboLoai.ValueMember = "Loai";
            cboLoai.CustomAlignment = new string[] { "l", "l" };
            cboLoai.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nhóm Dược LýXuất Nhập Tồn Hạn Dùng
            cboNhomDuocLy.DataSource = tb.Copy();
            cboNhomDuocLy.DisplayMember = "Loai";
            cboNhomDuocLy.ValueMember = "Loai";
            cboNhomDuocLy.CustomAlignment = new string[] { "l", "l" };
            cboNhomDuocLy.CustomColumnStyle = new string[] { "t", "t" };
        }

        //Đánh stt
        private void dgrBaoCaoXuatNhapTonHanDung_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSearch2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboKhoDuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReportXNTHD(object sender, EventArgs e)
        {
            Report();
        }

        private void cboNhomTheo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
