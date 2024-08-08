
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
    public partial class FrmThemSuaNhaCungCap : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public static string btn;
        public FrmThemSuaNhaCungCap(string maNhaCungCap)
        {
            InitializeComponent();
            
btnLuuSua.Visible = true;
               
                
           
            txtMaNhaCungCap.Text = maNhaCungCap;
        }
        public FrmThemSuaNhaCungCap()
        {
            InitializeComponent();
            loadmancc();
          

        }
        void loadmancc()
        {

            FrmNhaCungCap.MaNhaCungCap = txtMaNhaCungCap.Text;
        }
       

       
        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn bỏ qua?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (txtMaNhaCungCap.Text.Trim() != "")
            {
                msql = "INSERT INTO [dbo].[tabMANGUOIBAN]" +
               "([MANGUOIBAN],[TENNGUOIBAN],[DIACHI],[SODT]) " +
               "VALUES(N'" + txtMaNhaCungCap.Text + "',N'" + txtTenNhaCungCap.Text + "',N'" + txtDiaChi.Text + "','"+txtDienThoai.Text+"')";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Thêm thông tin nhà sản xuất thành công");
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            txtMaNhaCungCap.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCungCap.Text.Trim() != "")
            {
                msql = "INSERT INTO [dbo].[tabMANGUOIBAN]" +
               "([MANGUOIBAN],[TENNGUOIBAN],[DIACHI],[SODT]) " +
               "VALUES(N'" + txtMaNhaCungCap.Text + "',N'" + txtTenNhaCungCap.Text + "',N'" + txtDiaChi.Text + "','" + txtDienThoai.Text + "')";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Thêm thông tin nhà cung cấp thành công");
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            txtMaNhaCungCap.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void SetData(string maNhaCungCap)
        {
            throw new NotImplementedException();
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCungCap.Text.Trim() != "")
            {
                msql = "UPDATE[dbo].[tabMANGUOIBAN] SET [TENNGUOIBAN] = N'"+txtTenNhaCungCap.Text+"',[DIACHI] = N'"+txtDiaChi.Text+"',[SODT] ='"+txtDienThoai.Text+"' WHERE [MANGUOIBAN]=N'"+txtMaNhaCungCap.Text+"' ";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Sửa thông tin nhà cung cấp thành công");
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            txtMaNhaCungCap.Focus();


           
        }
    }


}
