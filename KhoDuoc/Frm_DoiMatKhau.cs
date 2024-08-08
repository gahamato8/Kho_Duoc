using BusinessCommon;
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

namespace KhoDuoc
{
    public partial class Frm_DoiMatKhau : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=KHODUOC;Integrated Security=True");
        private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public string a;

        public Frm_DoiMatKhau()
        {
            InitializeComponent();

        }
        private void btnDoiMatKhau_Click_1(object sender, EventArgs e)
        {
            

        }


        private void chkpass1_CheckedChanged(object sender, EventArgs e)
        {

            if (chkpass1.Checked)
            {
                txtTenDangNhap.PasswordChar = (char)0;
                txtMatKhauCu.PasswordChar = (char)0;
                txtMatKhauMoi.PasswordChar = (char)0;

            }
            else
            {
                txtTenDangNhap.PasswordChar = '*';
                txtMatKhauCu.PasswordChar = '*';
                txtMatKhauMoi.PasswordChar = '*';

            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count (*) from [dbo].[DUOC_KC_tab.TAIKHOAN] where TenDangNhap=N'" + txtNhapLaiMatKhau.Text + "'and MatKhau=N'" + txtMatKhauCu.Text + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "0")
            {


                if (txtMatKhauCu.Text == txtMatKhauMoi.Text)
                {


                    SqlDataAdapter dal = new SqlDataAdapter("update [dbo].[DUOC_KC_tab.TAIKHOAN] set MatKhau=N'" + txtMatKhauCu.Text + "' where TenDangNhap=N'" + txtNhapLaiMatKhau.Text + "' and MatKhau=N'" + txtTenDangNhap.Text + "' ", con);
                    DataTable tb = new DataTable();
                    dal.Fill(tb);
                    MessageBox.Show("đổi mật khẩu thành công");

                }
                else
                {
                    errorProvider1.SetError(txtNhapLaiMatKhau, "Vui lòng điền tên đăng nhập");
                    errorProvider1.SetError(txtMatKhauCu, "Vui lòng nhập mật khẩu mới");
                    errorProvider1.SetError(txtMatKhauMoi, "Vui lòng xác nhận mật khẩu");

                }

            }
            else
            {

                errorProvider1.SetError(txtNhapLaiMatKhau, "Tên đăng nhập không đúng");
                errorProvider1.SetError(txtTenDangNhap, "Mật khẩu cũ không đúng");

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkpass1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkpass1.Checked)
            {
                txtTenDangNhap.PasswordChar = (char)0;
                txtMatKhauCu.PasswordChar = (char)0;
                txtMatKhauMoi.PasswordChar = (char)0;

            }
            else
            {
                txtTenDangNhap.PasswordChar = '*';
                txtMatKhauCu.PasswordChar = '*';
                txtMatKhauMoi.PasswordChar = '*';

            }
        }
    }
}