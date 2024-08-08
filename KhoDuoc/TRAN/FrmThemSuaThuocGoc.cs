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
    public partial class FrmThemSuaThuocGoc : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
       

        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmThemSuaThuocGoc()
        {
            InitializeComponent();
            LoadCbo();
        }

        private void LoadCbo()
        {
            msql = "SELECT *  FROM [dbo].[DUOC_KC_DANHMUCHOATCHAT]";
            DataTable hoatchat = comm.GetDataTable(mconnectstring, msql, "[DUOC_KC_DANHMUCHOATCHAT");
            //cboHoatChatDacBiet
            cboHoatChatDacBiet.DataSource = hoatchat.Copy();
            cboHoatChatDacBiet.DisplayMember = "TenHoatChat";
            cboHoatChatDacBiet.ValueMember = "MaHoatChat";
            cboHoatChatDacBiet.CustomAlignment = new string[] { "l", "l" };
            cboHoatChatDacBiet.CustomColumnStyle = new string[] { "t", "t" };

            //cboKiemSoat
            cboKiemSoat.DataSource = hoatchat.Copy();
            cboKiemSoat.DisplayMember = "KiemSoat";
            cboKiemSoat.ValueMember = "KiemSoat";
            cboKiemSoat.CustomAlignment = new string[] { "l", "l" };
            cboKiemSoat.CustomColumnStyle = new string[] { "t", "t" };

            // Nhớ Thêm Cbo Này Cho Tất Cả Frm Nếu Có combobox nhé!!/// ok chưA
        }

        private void txtDuocLuc_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void txtTen_Leave(object sender, EventArgs e)
        {
            txtTen.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtChiDinh);

        }

        private void txtChiDinh_Enter(object sender, EventArgs e)
        {
            txtChiDinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtChiDinh_Leave(object sender, EventArgs e)
        {
            txtChiDinh.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtChiDinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDuocLuc);

        }

        private void txtTen_Enter(object sender, EventArgs e)
        {
            txtTen.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDuocLuc_Enter(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDuocLuc_Leave(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDuocLuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtToiDa1LanSD);
        }

        private void txtToiDa1LanSDTheoCanNang_Enter(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtToiDa1LanSDTheoCanNang_Leave(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtToiDa1LanSDTheoCanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtToiDa1NgaySDTheoCanNang);
        }

        private void txtToiDa1NgaySDTheoCanNang_Enter(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtToiDa1NgaySDTheoCanNang_Leave(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtToiDa1NgaySDTheoCanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTacDung);
        }

        private void txtTacDung_Enter(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTacDung_Leave(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTacDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtChongChiDinh);
        }

        private void txtChongChiDinh_Enter(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtChongChiDinh_Leave(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtChongChiDinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDuocDongHoc);
        }

        private void txtDuocDongHoc_Enter(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDuocDongHoc_Leave(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDuocDongHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtToiDa1NgaySD);

        }

        private void txtToiDa1NgaySD_Enter(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtToiDa1NgaySD_Leave(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtToiDa1NgaySD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtToiThieu1LanSDTheoCanNang);

        }

        private void txtToiThieu1LanSDTheoCanNang_Enter(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtToiThieu1LanSDTheoCanNang_Leave(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtToiThieu1LanSDTheoCanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtToiThieu1NgaySDTheoCanNang);

        }

        private void txtToiThieu1NgaySDTheoCanNang_Enter(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtToiThieu1NgaySDTheoCanNang_Leave(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtToiThieu1NgaySDTheoCanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnLuu);

        }

        private void txtToiDa1LanSD_Enter(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtToiDa1LanSD_Leave(object sender, EventArgs e)
        {
            txtDuocLuc.xActive = true;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtToiDa1LanSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtToiDa1LanSDTheoCanNang);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() != "")
            {
                msql = "INSERT INTO [dbo].[DUOC_KC_THEM_SUATHUOCGOC]" + 
                "([TenThuoc],[ChiDinh],[DuocLuc],[ToiDa1LanSuDung],[ToiDa1LanSuDungTheoCanNang],[ToiDa1NgaySuDungTheoCanNang],[HoatChatDacBiet],[TacDung],[ChongChiDinh],[DuocDongHoc],[ToiDa1NgaySuDung], [ToiThieu1LanSuDungTheoCanNang],[ToiThieu1NgaySuDungTheoCanNang],[KiemSoat])" +
                "VALUES (N'" + txtTen.Text + "',N'" + txtChiDinh.Text + "',N'" + txtDuocLuc.Text + "',N'" + txtToiDa1LanSD.Text + "',N'" + txtToiDa1LanSDTheoCanNang.Text + "',N'" + txtToiDa1NgaySDTheoCanNang.Text + "',N'" + cboHoatChatDacBiet.SelectedValue + "', N'" + txtTacDung.Text + "',N'" + txtChongChiDinh.Text + "',N'" + txtDuocDongHoc.Text + "',N'" + txtToiDa1NgaySD.Text + "',N'" + txtToiThieu1LanSDTheoCanNang.Text + "',N'" + txtToiThieu1NgaySDTheoCanNang.Text + "',N'" + cboKiemSoat.SelectedValue + "')";
                comm.RunSQL(mconnectstring, msql);
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin ");
            txtTen.Focus();

        }
    }
} 
