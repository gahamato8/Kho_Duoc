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
using VBSQLHelper;

namespace KhoDuoc
{
    public partial class FrmDangKy : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=KHODUOC;Integrated Security=True");
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        //ReportDocument BaoCao = new ReportDocument();

        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        private string msql1;
        public FrmDangKy()
        {
            InitializeComponent();
            LoadData();
            
        }


        private void LoadData()
        {
            //msql = "SELECT *   FROM [KHODUOC].[dbo].[[DUOC_KC_PhanQuyen]]";
            //DataTable tb = comm.GetDataTable(mconnectstring, msql, "[DUOC_KC_PhanQuyen]");
            msql = "select *from[dbo].[DUOC_KC_PhanQuyen]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_PhanQuyen");


            //cbo Loại
            cboPhanQuyen.DataSource = tb.Copy();
            cboPhanQuyen.DisplayMember = "Quyen";
            cboPhanQuyen.ValueMember = "Quyen";
            cboPhanQuyen.CustomAlignment = new string[] { "l", "l" };
            cboPhanQuyen.CustomColumnStyle = new string[] { "t", "t" };
            cboPhanQuyen.sf = setfocusMaNhaCungCap;
        }

        private int setfocusMaNhaCungCap()
        {
            txtTenDangNhap.Focus();
            return 1;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[DUOC_KC_tab.TAIKHOAN] where TenDangNhap='" + txtTenDangNhap.Text + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {

                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                }
                else
                {
                    msql = "INSERT INTO [KHODUOC].[dbo].[DUOC_KC_tab.TAIKHOAN] " +
                       "([TenDangNhap],[MatKhau],[HoTen],[Quyen]) " +
                      "VALUES(N'" + txtTenDangNhap.Text + "', N'" + txtMatKhau.Text + "', N'" + txtHoTen.Text + "', '" + cboPhanQuyen.SelectedValue + "')";
                    ev.QFrmThongBao("Đăng ký thành công");
                    comm.RunSQL(mconnectstring, msql);
                    FrmDangNhap f = new FrmDangNhap();
                    f.ShowDialog();

                }

                // msql1 = "select * from DUOC_KC_tab.TAIKHOAN where TenDangNhap='"+txtTenDangNhap.Text+"' ";

            }
            else
            {
                ev.QFrmThongBaoError("Tên đăng nhập hoặc mặt khẩu sai");
                txtTenDangNhap.Focus();
            }
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string CreateAutoID()
        {
            //return SQLHelper.ExecQuerySacalar($@"SELECT CONCAT('PKN', RIGHT(CONCAT('0000000000',ISNULL(right(max(MaPhieuNhapKho),10),0) + 1),10))
            //                                FROM dbo.DUOC_KC_NHAPKHO_NHAPTHUOC where MaPhieuNhapKho like 'PKN%'").ToString();
            return SQLHelper.ExecQuerySacalar($@"select [dbo].[DUOC_KC_TAIKHOAN]('" + Convert.ToDateTime(dtngay.Value).ToString("yyyy-MM-dd") + "')").ToString();
        }

        
        

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            txtMaNV.Text = CreateAutoID();
            if (txtTenDangNhap.Text.Trim() != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[DUOC_KC_tab.TAIKHOAN] where TenDangNhap='" + txtTenDangNhap.Text + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {

                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                }
                else
                {
                    msql = "INSERT INTO [KHODUOC].[dbo].[DUOC_KC_tab.TAIKHOAN] " +
                     "([MaNV],[TenDangNhap],[MatKhau],[HoTen],[TenQuyen],[Ngay],[Tuoi],[SDT],[GioiTinh]) " +
                    "VALUES('" + txtMaNV.Text + "',N'" + txtTenDangNhap.Text + "', N'" + txtMatKhau.Text + "', N'" + txtHoTen.Text + "', N'" + cboPhanQuyen.SelectedValue + "','"+ Convert.ToDateTime(dtngay.Value).ToString("yyyy-MM-dd") + "','"+txtTuoi.Text+"','"+txtSDT.Text+"',N'"+cboGioiTinh.SelectedItem+"')";
                    comm.RunSQL(mconnectstring, msql);
                    ev.QFrmThongBao("Đăng ký thành công");
                  
                   

                }

                // msql1 = "select * from DUOC_KC_tab.TAIKHOAN where TenDangNhap='"+txtTenDangNhap.Text+"' ";
                txtMaNV.Clear();
            }
            else
            {
                ev.QFrmThongBaoError("Tên đăng nhập hoặc mặt khẩu sai");
                txtTenDangNhap.Focus();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = CreateAutoID();
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}