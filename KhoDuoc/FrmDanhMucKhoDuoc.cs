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

namespace KhoDuoc
{
    public partial class FrmDanhMucKhoDuoc : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        //Chưa làm btn Tìm
        //Chưa làm btn Thêm
        //Chưa làm chức năng sửa

        public FrmDanhMucKhoDuoc()
        {
            InitializeComponent();
            LoadData();
            dgrDanhMucKhoDuoc.Font = new Font("Times New Roman", 16);

        }
        private void LoadData()
        {
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_DANHMUCKHODUOC]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");
            dgrDanhMucKhoDuoc.AutoGenerateColumns = false;
            dgrDanhMucKhoDuoc.DataSource = tb;





            //cbo Kho
            cboKho.DataSource = tb.Copy();
            cboKho.DisplayMember = "LoaiKhoDuoc";
            cboKho.ValueMember = "TenKhoDuoc";
            cboKho.CustomAlignment = new string[] { "l", "l" };
            cboKho.CustomColumnStyle = new string[] { "t", "t" };
            cboKho.sf = setfocusTenKhoduoc;

        }


        private int setfocusTenKhoduoc()
        {
            txtTenKho.Focus();
            return 1;
        }

        private void txtTenKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_ComboBox_Focus(sender, e, cboKho);
        }

        private void txtTenKho_Enter(object sender, EventArgs e)
        {
            txtTenKho.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenKho_Leave(object sender, EventArgs e)
        {
            txtTenKho.xActive = false;
            ev.Qtxt_Enter(sender, e);
        }

        private void dgrDanhMucKhoDuoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrDanhMucKhoDuoc);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_DANHMUCKHODUOC] WHERE TenKhoDuoc=N'" + txtTenKho.Text + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");
            dgrDanhMucKhoDuoc.AutoGenerateColumns = false;
            dgrDanhMucKhoDuoc.DataSource = tb;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dgrDanhMucKhoDuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgrDanhMucKhoDuoc["cSua", e.RowIndex] == dgrDanhMucKhoDuoc.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn sửa " + dgrDanhMucKhoDuoc.CurrentRow.Cells["cTenKhoDuoc"].Value.ToString() + " này không ?"))
                {
                    msql = "SELECT * FROM [dbo].[] where =N'" + dgrDanhMucKhoDuoc.CurrentRow.Cells["cTenKhoDuoc"].Value.ToString() + "'";
                    comm.RunSQL(mconnectstring, msql);
                    LoadData();

                }
            }
        }
    }
}
