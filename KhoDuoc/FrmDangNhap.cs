using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCommon;

namespace KhoDuoc
{

    public partial class FrmDangNhap : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=KHODUOC;Integrated Security=True");
        private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public string a;
        public FrmDangNhap()
        {
            InitializeComponent();
            Int_data();

           
            
        }
        public static string tendn1;
        public static string tendn;
        public static string tenquyen;

      void re()
        {

            
        }

        private void txtDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDangNhap);

        }

        private void txtDangNhap_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDangNhap_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        WaitFormFunc w = new WaitFormFunc();

        private void Int_data()
        {
            if (Properties.Settings.Default.Username != string.Empty )
            {
                if(Properties.Settings.Default.RememberMe == "yes")
                {

                    txtDangNhap.Text = Properties.Settings.Default.Username;
                    txtMatKhau.Text = Properties.Settings.Default.Password;
                    chkRemember.Checked = true;
                }
                else
                {

                    txtDangNhap.Text = Properties.Settings.Default.Username;

                }



            }    


        }
        private void save()
        {
            if(chkRemember.Checked)
            {
                txtDangNhap.Text = Properties.Settings.Default.Username;
                txtMatKhau.Text = Properties.Settings.Default.Password;
                Properties.Settings.Default.RememberMe = "yes";
                Properties.Settings.Default.Save();
            }    
            else
            {

                txtDangNhap.Text = Properties.Settings.Default.Username;
              Properties.Settings.Default.Password="";
                Properties.Settings.Default.RememberMe = "no";
                Properties.Settings.Default.Save();


            }    


        }



        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
         

            SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=KHODUOC;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("select * From [dbo].[DUOC_KC_tab.TAIKHOAN] where TenDangNhap = '" + txtDangNhap.Text + "' and  MatKhau='" + txtMatKhau.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)

            {

                ev.QFrmThongBao ("Đăng nhập thành công");
                tendn1 = dt.Rows[0]["TenDangNhap"].ToString();
                tendn = dt.Rows[0]["TenDangNhap"].ToString();
                tenquyen = dt.Rows[0]["TenQuyen"].ToString();
                //this.Hide();
                save();

                FrmTieuDe f = new FrmTieuDe(dt.Rows[0][0].ToString());
                //  string a = txtDangNhap.Text;
                this.Hide();
                f.ShowDialog();
            }
            else
            {

                ev.QFrmThongBaoError("Đăng nhập không thành công");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void chkpass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkpass.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;

            }
            else
            {
                txtMatKhau.PasswordChar = '*';

            }
        }

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRemember.Checked)
            {
                txtDangNhap.Text = Properties.Settings.Default.Username;
                txtMatKhau.Text = Properties.Settings.Default.Password;
                Properties.Settings.Default.RememberMe = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {

                txtDangNhap.Text = Properties.Settings.Default.Username;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = "no";
                Properties.Settings.Default.Save();


            }
        }

        private void txtDangNhap_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtMatKhau);
        }

        private void txtDangNhap_Enter_1(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDangNhap_Leave_1(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnDangNhap);
        }

        
    }
}
