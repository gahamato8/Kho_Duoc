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
    public partial class FrmXuatKhoKhac : Form
    {
        private string mconnectstring = "server=.;database = quanlyphongkham; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public FrmXuatKhoKhac()
        {
            InitializeComponent();
        }

        private void txtLyDoXuat_Enter(object sender, EventArgs e)
        {
            txtLyDoXuat.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtLyDoXuat_Leave(object sender, EventArgs e)
        {
            txtLyDoXuat.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtLyDoXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNoiNhan);
        }

        private void txtNoiNhan_Enter(object sender, EventArgs e)
        {
            txtNoiNhan.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNoiNhan_Leave(object sender, EventArgs e)
        {
            txtNoiNhan.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNoiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnChonFileUpdate);
        }
    }
}
