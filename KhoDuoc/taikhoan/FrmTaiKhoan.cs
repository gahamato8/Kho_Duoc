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

namespace KhoDuoc
{

    public partial class FrmTaiKhoan : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public string a;
        public FrmTaiKhoan()
        {
            InitializeComponent();
            
        }
       // public static string a;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=KHODUOC;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("select * From [dbo].[DUOC_KC_tab.TAIKHOAN] where TenDangNhap = '" + txtDangNhap.Text+"' and  MatKhau='"+txtMatKhau.Text+"'",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ev.QFrmThongBao("Đăng nhập thành công");

                //Login.userName = dt.Rows[0]["TenDangNhap"].ToString();
                this.Hide();
                FrmTH f = new FrmTH(dt.Rows[0][0].ToString());
                //  string a = txtDangNhap.Text;
                this.Hide();
                f.ShowDialog();
            }
            else
            {

                ev.QFrmThongBaoError ("Đăng nhập không thành công");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtDangky.Text.Trim() != "" && txtMatKhauDangKy.Text.Trim()!=""&& txtHoTen.Text.Trim()!="")
            {
                msql = " INSERT INTO [KHODUOC].[dbo].[DUOC_KC_tab.TAIKHOAN] ([TenDangNhap],[HoTen],[MatKhau],[Nhom]) VALUES ('" + txtDangky.Text+"','"+txtHoTen.Text+"','"+txtMatKhauDangKy.Text+"','"+cboNhomPhanQuyen.SelectedValue+"')";
                comm.RunSQL(mconnectstring, msql);
                ev.QFrmThongBao("Đăng ký thành công");
                FrmTaiKhoan tk = new FrmTaiKhoan();
                tk.ShowDialog();

            }
            else
            {
                ev.QFrmThongBaoError("Đăng ký không thành công");
                txtDangky.Focus();
            }
        }
    }
}
