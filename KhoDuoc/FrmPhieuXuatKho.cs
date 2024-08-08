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
    public partial class FrmPhieuXuatKho : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmPhieuXuatKho()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            msql = "SELECT * FROM[KHODUOC].[dbo].[XUATKHO]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "XUATKHO");
            dgrXuatKho.AutoGenerateColumns = true;
            dgrXuatKho.DataSource = tb;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSearch9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenThuoc_Enter(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSLPhat_Enter(object sender, EventArgs e)
        {
            txtSLPhat.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSLPhat_Leave(object sender, EventArgs e)
        {
            txtSLPhat.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSLPhat);
        }

        private void txtSLPhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnLuu);
        }

        private void btnChonFileUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
