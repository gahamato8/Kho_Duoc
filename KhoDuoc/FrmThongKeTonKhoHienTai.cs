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
using Excel = Microsoft.Office.Interop.Excel;

namespace KhoDuoc
{
    public partial class FrmThongKeTonKhoHienTai : Form
    {
        private string mconnectstring = "server = .;database = KHODUOC; uid = sa; pwd = 123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmThongKeTonKhoHienTai()
        {
            InitializeComponent();
            LoadData();
            dgrThongKeTonKhoHienTai.Font = new Font("Times New Roman", 16);

        }
        public static string R;

       

        private void LoadData()
        {
            msql = "SELECT * FROM  [dbo].[tabDanhMucThuoc] AS a, [dbo].[tabMANGUOIBAN] as b where a.MANGUOIBAN=b.MANGUOIBAN";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "THONGKETONKHOHIENTAI");
            dgrThongKeTonKhoHienTai.AutoGenerateColumns = false;
            dgrThongKeTonKhoHienTai.DataSource = tb;
        }

        //private void Report()
        //{
        //    msql = "SELECT* FROM [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] as A ,[dbo].[DUOC_KC_Lo2023] as B,[dbo].[tabDanhMucThuoc] as C,[dbo].[tabMANGUOIBAN] as D where A.MaPhieuNhapKho=B.MaPhieuNhapKho and B.MaThuoc=C.MaThuoc and C.MANGUOIBAN=D.MANGUOIBAN and B.MaThuoc='" + txtMaThuoc.Text + "'";
        //    //Chạy lên lần đầu sau khi có dữ liệu nhớ mở ra, sau khi ghi được thì đóng lại
        //    //comm.GhiFileXmlReport(mconnecstring, msql, "d", "rpBaoCaoTheKho");
        //    DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_BAOCAOTHONGKENHAPTHUOC");
        //    BaoCao.Load(Application.StartupPath + @"\baocaothongkenhapthuoc.rpt");
        //    BaoCao.SetDataSource(tb);
        //    ReportThongKeNhapThuoc.ReportSource = BaoCao;
        //}
        

        private void txtMa_Enter(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuocNongDoHamLuong_Enter(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }



        private void txtNuocSanXuat_Enter(object sender, EventArgs e)
        {
            txtNuocSanXuat.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHangSanXuat_Enter(object sender, EventArgs e)
        {
            txtHangSanXuat.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGia_Enter(object sender, EventArgs e)
        {
            txtGia.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDVT_Enter(object sender, EventArgs e)
        {
            txtDVT.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSL_Enter(object sender, EventArgs e)
        {
            txtSL.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuocNongDoHamLuong_Leave(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }



        private void txtNuocSanXuat_Leave(object sender, EventArgs e)
        {
            txtNuocSanXuat.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHangSanXuat_Leave(object sender, EventArgs e)
        {
            txtHangSanXuat.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGia_Leave(object sender, EventArgs e)
        {
            txtGia.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDVT_Leave(object sender, EventArgs e)
        {
            txtDVT.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSL_Leave(object sender, EventArgs e)
        {
            txtSL.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenThuoc);
        }

        //private void txtTenThuocNongDoHamLuong_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHoatChat);
        //}

        private void txtHoatChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNuocSanXuat);
        }

        private void txtNuocSanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHangSanXuat);
        }

        private void txtHangSanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGia);
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDVT);
        }

        private void txtĐVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSL);
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnThem);
        }

     

        private void btnIn_Click(object sender, EventArgs e)
        {
            R = dgrThongKeTonKhoHienTai.CurrentRow.Cells["cMaThuoc"].Value.ToString();
            FrmRPThongKeTonKhoHienTai frm = new FrmRPThongKeTonKhoHienTai();
            frm.ShowDialog();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
         
            FrmRPThongKeTonKhoHienTai frm = new FrmRPThongKeTonKhoHienTai();
            frm.ShowDialog();
        }

        private void dgrThongKeTonKhoHienTai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaThuoc.Text = dgrThongKeTonKhoHienTai.CurrentRow.Cells["cMaThuoc"].Value.ToString();
            txtTenThuoc.Text = dgrThongKeTonKhoHienTai.CurrentRow.Cells["cTenThuoc"].Value.ToString();
            txtNuocSanXuat.Text = dgrThongKeTonKhoHienTai.CurrentRow.Cells["cHangSanXuat"].Value.ToString();
            txtHangSanXuat.Text = dgrThongKeTonKhoHienTai.CurrentRow.Cells["cDonViBan"].Value.ToString();
            txtGia.Text = dgrThongKeTonKhoHienTai.CurrentRow.Cells["cGia"].Value.ToString();
            txtDVT.Text = dgrThongKeTonKhoHienTai.CurrentRow.Cells["cDVT"].Value.ToString();
            txtSL.Text = dgrThongKeTonKhoHienTai.CurrentRow.Cells["cSL"].Value.ToString();

        }

        private void btnInTatCa_Click(object sender, EventArgs e)
        {
            FrmRPThongKeTonKhoHienTai frm = new FrmRPThongKeTonKhoHienTai();
            frm.Report1();
            frm.ShowDialog();
        }
    }
}
