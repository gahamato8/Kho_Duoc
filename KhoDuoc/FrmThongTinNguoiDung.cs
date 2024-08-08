using BusinessCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoDuoc
{
    public partial class FrmThongTinNguoiDung : Form
    {

        public static string mconnectstring = "server=.;database= KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmThongTinNguoiDung()
        {
            InitializeComponent();
            dgrdanhsachnguoidung.Font = new Font("Times New Roman", 16, FontStyle.Regular);
            loaddata();
            cbo();
        }
     void cbo()
        {
            msql = "SELECT * FROM [dbo].[DUOC_KC_PhanQuyen]";
            DataTable tenquyen = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_PhanQuyen");

            cboTenQuyen.DataSource = tenquyen.Copy();
            cboTenQuyen.DisplayMember = "Quyen";
            cboTenQuyen.ValueMember = "Quyen";
            cboTenQuyen.CustomAlignment = new string[] { "l", "l" };
            cboTenQuyen.CustomColumnStyle = new string[] { "t", "t" };

        }

        void loaddata()
        {
            msql = "select *from[dbo].[DUOC_KC_tab.TAIKHOAN]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "PHIEUYEUCAULINHTHUOCQUAYTHUOC"); // Thực thi lấy bảng dữ liệu
            dgrdanhsachnguoidung.AutoGenerateColumns = false; // Hiển thị dững dữ liệu trên colums, cái nào null sẽ ẩn
            dgrdanhsachnguoidung.DataSource = tb;



        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmDangKy dk = new FrmDangKy();
            dk.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ev.QFrmThongBao_YesNo("Bạn có muốn xóa thông tin người dùng này không?");
            msql = "DELETE FROM [dbo].[DUOC_KC_tab.TAIKHOAN] WHERE MaNV='"+txtMaNV.Text+"'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Xóa thông tin người dùng thành công");
            loaddata();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ev.QFrmThongBao_YesNo("Bạn có muốn sửa thông tin người dùng này không?");

            msql = "UPDATE [dbo].[DUOC_KC_tab.TAIKHOAN]"+
   "SET[TenDangNhap] = '"+txtTenNguoiDung.Text+"'" +
    ",[HoTen] ='" + txtHoTen.Text + "'" +
     ",[MatKhau] ='" + txtMatKhau.Text + "'" +
      ",[TenQuyen] = N'" + cboTenQuyen.SelectedValue + "'" +
  "WHERE[MaNV] = '" + txtMaNV.Text + "'";
            comm.RunSQL(mconnectstring, msql);
            ev.QFrmThongBao("Sửa thông tin người dùng thành công");

            loaddata();

        }

        private void dgrdanhsachnguoidung_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtTenNguoiDung.Text= dgrdanhsachnguoidung.CurrentRow.Cells["cTenDangNhap"].Value.ToString();
            txtHoTen.Text = dgrdanhsachnguoidung.CurrentRow.Cells["cTenNV"].Value.ToString();
            txtMatKhau.Text = dgrdanhsachnguoidung.CurrentRow.Cells["cMK"].Value.ToString();
            txtMaNV.Text = dgrdanhsachnguoidung.CurrentRow.Cells["cMaNV"].Value.ToString();
            cboTenQuyen.Text = dgrdanhsachnguoidung.CurrentRow.Cells["cQuyen"].Value.ToString();







        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
