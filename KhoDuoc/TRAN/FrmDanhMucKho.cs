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
using FlexCel;
namespace KhoDuoc
{
    public partial class FrmDanhMucKho : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        //Chưa làm btn Tìm
        //Chưa làm btn Thêm
        //Chưa làm chức năng sửa

        public FrmDanhMucKho()
        {
            InitializeComponent();
            LoadCbo();
            LoadData();


        }
        private void LoadData()
        {

            //msql = "SELECT *  FROM [KHODUOC].[dbo].[DUOC_KC_DANHMUCKHODUOC] WHERE TenKhoDuoc = N'" + txtTenKhoDuoc.Text + "'";
            //DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");
            //dgrDanhMucKhoDuoc.AutoGenerateColumns = false;
            //dgrDanhMucKhoDuoc.DataSource = tb;



            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_DANHMUCKHODUOC]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");
            dgrDanhMucKhoDuoc.AutoGenerateColumns = true;
            dgrDanhMucKhoDuoc.DataSource = tb;

            //cbo Kho

        }
        private void LoadCbo()
        {
            msql = "SELECT * FROM [dbo].[tabDUOC_KC_DANHMUCKHO]";
            DataTable kho = comm.GetDataTable(mconnectstring, msql, "tabDUOC_KC_DANHMUCKHO");

            cboLoaiKhoDuoc.DataSource = kho.Copy();
            cboLoaiKhoDuoc.DisplayMember = "TenKho";
            cboLoaiKhoDuoc.ValueMember = "MaKho";
            cboLoaiKhoDuoc.CustomAlignment = new string[] { "l", "l" };
            cboLoaiKhoDuoc.CustomColumnStyle = new string[] { "t", "t" };

            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_DANHMUCKHODUOC]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");
            //cbo Trạng thái 
            cboTrangThai.DataSource = tb.Copy();
            cboTrangThai.DisplayMember = "TrangThai";
            cboTrangThai.ValueMember = "TrangThai";
            cboTrangThai.CustomAlignment = new string[] { "l", "l" };
            cboTrangThai.CustomColumnStyle = new string[] { "t", "t" };
        }

        //Đánh stt
        private void dgrDanhMucKhoDuoc_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrDanhMucKhoDuoc);
        }

        private void txtTenKhoDuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTim);

        }

        private void txtTenKhoDuoc_Enter(object sender, EventArgs e)
        {
            txtTenKhoDuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenKhoDuoc_Leave(object sender, EventArgs e)
        {
            txtTenKhoDuoc.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void dgrDanhMucKhoDuoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrDanhMucKhoDuoc);
        }
        // Nut tìm hoặc nút loadata
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemSuaThuocGoc f = new FrmThemSuaThuocGoc();
            f.ShowDialog();

        }

        private void dgrDanhMucKhoDuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgrDanhMucKhoDuoc["cSua", e.RowIndex] == dgrDanhMucKhoDuoc.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn sửa " + dgrDanhMucKhoDuoc.CurrentRow.Cells["cTenKhoDuoc"].Value.ToString() + " này không ?"))
                {
                    msql = "UPDATE [dbo].[DUOC_KC_DANHMUCKHODUOC]" + "SET [LoaiHangHoa] = N '" + txtLoaiHangHoa.Text + "' WHERE TenKhoDuoc = N '" + txtTenKhoDuoc.Text + "'";
                     comm.RunSQL(mconnectstring, msql);
                    LoadData();

                }
            }
        }

        private void dgrDanhMucKhoDuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
