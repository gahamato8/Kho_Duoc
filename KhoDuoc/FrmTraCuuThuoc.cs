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
    public partial class FrmTraCuuThuoc : Form
    {
        
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public FrmTraCuuThuoc()
        {
            InitializeComponent();




            LoadData();
            LoadCombobox();
            addBiding();
            dgrTraCuuThuoc.Font = new Font("Times New Roman", 16, FontStyle.Regular);
        }

        void addBiding()
        {

            


            //txtHoten.DataBindings.Add(new Binding("Text", dgrDanhSach.DataSource, "TenNV"));
            //txtEmail.DataBindings.Add(new Binding("Text", dgrDanhSach.DataSource, "Gmail"));
            //txtSDT.DataBindings.Add(new Binding("Text", dgrDanhSach.DataSource, "SDT"));
            //lab.DataBindings.Add(new Binding("Text", dgrDanhSach.DataSource, "TenTaiKhoan"));


        }



        private void LoadData()
        {
            msql = "select * from [KHODUOC].[dbo].[tabDanhMucThuoc] A ,[dbo].[tabMANGUOIBAN] B WHERE A.MANGUOIBAN=B.MANGUOIBAN";
                //"as A, [tabNuoc] AS B,[tabNhomThuoc] AS C,[DUOC_KC_Lo2023] AS D, [tabBietDuoc] AS E  Where A.MaThuoc = D.MaThuoc and B.IDNuoc =C.IDNhomThuoc and A.MaThuoc = E.MaBietDuoc";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCHOATCHAT");
            dgrTraCuuThuoc.AutoGenerateColumns = false;
            dgrTraCuuThuoc.DataSource = tb;


        }


        private void LoadCombobox()
        {


            //cbo Loại Thuốc
            msql = "select * from [dbo].[tabLoaithuoc]";
            DataTable tb1 = comm.GetDataTable(mconnectstring, msql, "tabLoaithuoc");
            cboLoaiThuoc.DataSource = tb1.Copy();
            cboLoaiThuoc.DisplayMember = "TENLOAITHUOC";
            cboLoaiThuoc.ValueMember = "TENLOAITHUOC";
            cboLoaiThuoc.CustomAlignment = new string[] { "l", "l" };
            cboLoaiThuoc.CustomColumnStyle = new string[] { "t", "t" };

            // cbo Nhóm Dược Lý
            msql = "select * from [dbo].[tabNhomThuoc]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tabNhomThuoc");
            cboNhomDuocLy.DataSource = tb.Copy();
            cboNhomDuocLy.DisplayMember = "TenNhom";
            cboNhomDuocLy.ValueMember = "TenNhom";
            cboNhomDuocLy.CustomAlignment = new string[] { "l", "l" };
            cboNhomDuocLy.CustomColumnStyle = new string[] { "t", "t" };
        }
        private void comboBoxSearch1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboChonLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenThuoc_Enter(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTim);
        }

      

        private void txtThanhPhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTim);
        }

        private void dgrTraCuuThuoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrTraCuuThuoc);
        }

        private void txtTenThuoc_TextChanged(object sender, EventArgs e)
        {
            //sử dụng thuộc tính RowFilter để tìm kiếm theo tên "Name"
            string rowFilter = string.Format("{0} like '{1}'", "TenThuoc", "*" + txtTenThuoc.Text + "*");
            (dgrTraCuuThuoc.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
        public event System.Windows.Forms.DataGridViewDataErrorEventHandler DataError;

        private void dgrTraCuuThuoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(this, e.Exception.Message, "Error");
            e.ThrowException = false;
            e.Cancel = false;
        }

        private void txtThanhPhan_TextChanged(object sender, EventArgs e)
        {
            ////sử dụng thuộc tính RowFilter để tìm kiếm theo tên "Name"
            //string rowFilter1 = string.Format("{0} like '{1}'", "ThanhPhan", "*" + txtThanhPhan.Text + "*");
            //(dgrTraCuuThuoc.DataSource as DataTable).DefaultView.RowFilter = rowFilter1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }

}
