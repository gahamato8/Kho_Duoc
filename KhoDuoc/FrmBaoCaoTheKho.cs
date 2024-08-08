using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCommon;
using CrystalDecisions.CrystalReports.Engine;
using FlexCel;
using VBSQLHelper;

namespace KhoDuoc
{
    public partial class FrmBaoCaoTheKho : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        ReportDocument BaoCao = new ReportDocument();

        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmBaoCaoTheKho()
        {
            InitializeComponent();
            LoadData();
            dgrdanhsachthuoc.Font = new Font("Times New Roman", 16);
        }
        public void ShowInPanel(FrmTongHop parentForm)
        {
            parentForm.Load(this);
        }
  
        private void LoadData()
        {
            msql = "SELECT DISTINCT a.TenThuoc,a.MaThuoc,b.NgayNhap FROM[dbo].[DUOC_KC_Lo2023] as a, [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] as b,[dbo].[DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT] as c ,DUYETPHIEULINHNOIBO_THONGTINPHIEUXUAT AS D where a.MaPhieuNhapKho=b.MaPhieuNhapKho and a.MaThuoc=c.MaThuoc AND C.MaPhieuYeuCau=D.MaPhieuYeuCau";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
            dgrdanhsachthuoc.AutoGenerateColumns = false; // Hiển thị dững dữ liệu trên colums, cái nào null sẽ ẩn
            dgrdanhsachthuoc.DataSource = tb;

           
        }
        private void Report()
        {
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_THONGTINPHIEU_YEUCAULINHOQUAYTHUOC] as A, [DUOC_KL_TRANGTHAI] AS B,DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT as C ,[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] as D ,[dbo].[DUOC_KC_Lo2023] AS E  WHERE A.TrangThai = 5 AND A.TrangThai = B.IDTrangThai and A.MaPhieuYeuCau=C.MaPhieuYeuCau and d.MaPhieuYeuCau=c.MaPhieuYeuCau AND E.MaThuoc=D.MaThuoc and E.MaThuoc='"+txtMaThuoc.Text+"' and E.TenThuoc='"+txtTenThuoc.Text+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
            BaoCao.Load(Application.StartupPath + @"\baocaothekho.rpt");
            BaoCao.SetDataSource(tb);
            ReportBaoCaoTheKho.ReportSource = BaoCao;


        }





        //Load Data
    
        private int setfocusTenThuoc()
        {
            txtMaThuoc.Focus();
            return 1;
        }
        // Tương tác
        private void txtMaThuoc_VatTu_Enter(object sender, EventArgs e)
        {
            //txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaThuoc_VatTu_Leave(object sender, EventArgs e)
        {
            // txtMaThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaThuoc_VatTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenThuoc);
        }

        private void txtTenThuoc_VatTu_Enter(object sender, EventArgs e)
        {
            //txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_VatTu_Leave(object sender, EventArgs e)
        {
            // txtTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenThuoc_VatTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, cboTenThuoc);
        }
        private void btnBaoCao_Click_1(object sender, EventArgs e)
        {
            Report();
        }

        //report







        private void btnLuu_Click(object sender, EventArgs e)
        {


         
        }
        //Này quên mẹ rồi, để hỏi a Quyền :))))
        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void txtMaThuoc_VatTu_Click(object sender, EventArgs e)
        {
            //txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaThuoc_VatTu_Enter_1(object sender, EventArgs e)
        {
            //txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaThuoc_VatTu_Leave_1(object sender, EventArgs e)
        {
            //txtMaThuoc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaThuoc_VatTu_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenThuoc);
        }

        private void txtTenThuoc_VatTu_Click(object sender, EventArgs e)
        {
            dgrdanhsachthuoc.Visible = true;
            // txtTenThuoc.xActive = true;
            // ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_VatTu_Enter_1(object sender, EventArgs e)
        {
            // txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_VatTu_Leave_1(object sender, EventArgs e)
        {
            // txtTenThuoc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenThuoc_VatTu_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnBaoCao);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            Report();
        }



        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void txtMaThuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click_2(object sender, EventArgs e)
        {
            Report();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click_1(object sender, EventArgs e)
        {

        }

        private void dgrdanhsachthuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtNgay.Text = dgrdanhsachthuoc.CurrentRow.Cells["cThoiGian"].Value.ToString();
            txtMaThuoc.Text = dgrdanhsachthuoc.CurrentRow.Cells["cMaThuoc"].Value.ToString();
            txtTenThuoc.Text = dgrdanhsachthuoc.CurrentRow.Cells["cTenThuoc"].Value.ToString();
            dgrdanhsachthuoc.Visible = false;
           
        }

        private void ReportBaoCaoTheKho_Click(object sender, EventArgs e)
        {
            dgrdanhsachthuoc.Visible = false;
        }

        
    }
}
