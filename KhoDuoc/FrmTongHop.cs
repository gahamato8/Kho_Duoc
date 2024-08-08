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
    public partial class FrmTongHop : Form
    {

        private Form currentChildForm;
        //private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";

        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        //private string msql;
        string Quyen = "";
        public static string side1;

        public static string side2;
        public Panel frm1 { get; set; } = new Panel();
 

        public FrmTongHop()
        {
            InitializeComponent();
            Show();
            //txtDangNhap.Text = FrmDangNhap.tendn;
            Load();
            label1.Text = FrmDangNhap.tendn;
            PhanQuyen.Text = FrmDangNhap.tenquyen;
            ShowPanels();

        }

        public FrmTongHop(string Quyen)
        {
            InitializeComponent();
            this.Quyen = Quyen;
            //Load();
        }
        public void OpenFrmTongHop(object formToAdd)
        {
            Load(formToAdd);
        }


        public class FormLoader
        {
            public void LoadForm(object form, Panel containerPanel)
            {
                if (containerPanel.Controls.Count > 0)
                    containerPanel.Controls.RemoveAt(0);

                Form f = form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                containerPanel.Controls.Add(f);
                containerPanel.Tag = f;
                f.Show();
            }
        }

        public void Load(object Form)
        {
            if (this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(f);
            this.pnMain.Tag = f;
            f.Show();

        }



        private void Show()
        {
            pnHeThong.Visible = false;
            pnKhoDuocNhapKho.Visible = false;
            pnKhoDuocXuatKho.Visible = false;
            pnBaoCao.Visible = false;
            pnDanhMuc.Visible = false;

        }
        private void Load()
        {
            //panel2.Visible = false;
            //btnHeThong.Visible = false;
           

        }

        public void LoadFormInPanel(Form form)
        {
            if (this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(form);
            this.pnMain.Tag = form;
            form.Show();
        }

        private void ShowPanels()
        {
            pnHeThong.Visible = false;
            pnKhoDuocNhapKho.Visible = false;
            pnKhoDuocXuatKho.Visible = false;
            pnBaoCao.Visible = false;
            pnDanhMuc.Visible = false;
        }
        public void CloseChildFormInPanel(Form form)
        {
            // Close or hide the form as needed
            form.Close(); // or form.Hide()

            // Remove the form from the panel's controls
            pnMain.Controls.Remove(form);
        }
        public void UnloadFormFromPanel(Form form)
        {
            // Remove the form from the panel's controls
            pnMain.Controls.Remove(form);

            // Optionally, dispose the form to release resources (depending on your requirements)
            form.Dispose();
        }

        

        

        public void OpenNewForm(Form newForm)
        {
            this.Close();

            // Set properties for the new form if needed
            newForm.StartPosition = FormStartPosition.CenterScreen;

            // Show the new form
            newForm.ShowDialog();
        }
        private void hideSubMenu()
        {

            if(pnHeThong.Visible==true)
            pnHeThong.Visible = false;
            if (pnKhoDuocNhapKho.Visible == true)
                pnKhoDuocNhapKho.Visible = false;
            if (pnKhoDuocXuatKho.Visible == true)
                pnKhoDuocXuatKho.Visible = false;
            if (pnBaoCao.Visible == true)
                pnBaoCao.Visible = false;
            if (pnDanhMuc.Visible == true)
                pnDanhMuc.Visible = false;
        }

        private void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;



        }
        public void AddFormToPanel(FrmPhieuYeuCauLinhThuocVatTu formToAdd)
        {
            FrmTongHop f = new FrmTongHop();
            f.Close();
            // Set TopLevel and Visible properties to false
            formToAdd.TopLevel = false;
            formToAdd.Visible = true;

            // Add the form to the panel's Controls collection
            pnMain.Controls.Add(formToAdd);

            // Dock the form to fill the panel
            formToAdd.Dock = DockStyle.Fill;
        }

        public void Load11(Form newForm)
        {
            Form existingForm = this.pnMain.Tag as Form;
            if (existingForm != null)
            {
                existingForm.Close();
                existingForm.Dispose(); // Dispose the existing form if needed
            }

            // Add the new form to pnMain
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None; // Remove border if necessary
            newForm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(newForm);
            this.pnMain.Tag = newForm;
            newForm.Show();
        }

        public void AddFormToPanel(Form formToAdd)
        {
            // Close and dispose of existing form in the panel
            Form existingForm = this.pnMain.Tag as Form;
            if (existingForm != null)
            {
                existingForm.Close();
                existingForm.Dispose();
            }

            // Set TopLevel and Visible properties to false
            formToAdd.TopLevel = false;
            formToAdd.Visible = true;

            // Add the form to the panel's Controls collection
            pnMain.Controls.Add(formToAdd);

            // Dock the form to fill the panel
            formToAdd.Dock = DockStyle.Fill;

            // Set the form as the current form in the pnMain.Tag
            this.pnMain.Tag = formToAdd;
        }


        public void OpenChildFormInPanel(Form newChildForm)
            {
                // Assuming you have a panel named "childPanel" on FrmTongHop
                Panel childPanel = this.Controls.Find("childPanel", true).FirstOrDefault() as Panel;

                if (childPanel != null)
                {
                    // Clear existing controls in the panel
                    childPanel.Controls.Clear();

                    // Set the properties of the newChildForm
                    newChildForm.TopLevel = false;
                    newChildForm.FormBorderStyle = FormBorderStyle.None;
                    newChildForm.Dock = DockStyle.Fill;

                    // Add the newChildForm to the panel
                    childPanel.Controls.Add(newChildForm);

                    // Show the newChildForm
                    newChildForm.Show();
                }
            }
        



        private void btnHeThong_Click(object sender, EventArgs e)
        {

            if (PhanQuyen.Text == "admin")
            {
                ShowSubmenu(pnHeThong);
            }
            else 
            {
                ev.QFrmThongBaoError("Bạn không có quyền truy cập vào form này");
            }
            //panel2.Visible = false;
            //ShowSubmenu(pnHeThong);
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {

            //if (Quyen == "admin")
            //{
            //    Load(new FrmThongTinNguoiDung());
            //}
            //else
            //{
            //    btnHeThong.Hide();
            //}
            //panel2.Visible = false;

            Load(new FrmThongTinNguoiDung());
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            FrmDangKy f = new FrmDangKy();
            f.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau f = new FrmDoiMatKhau();
            f.ShowDialog();
        }

        private void btnKhoDuoc_Click(object sender, EventArgs e)
        {
            if (PhanQuyen.Text == "Nhập kho")
            {
                ShowSubmenu(pnKhoDuocNhapKho);
            }
            else if (PhanQuyen.Text == "admin")
            {
                ShowSubmenu(pnKhoDuocNhapKho);
            }
            else
            {
                ev.QFrmThongBaoError("Bạn không có quyền truy cập vào form này");
            }
           
            
        }

        private void btnNhapNhaCungCap_Click(object sender, EventArgs e)
        {
            Load(new FrmNhapTuNhaCungCap());

        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            Load(new FrmNhapThuoc());

        }

        private void bnnXuatKho_Click(object sender, EventArgs e)
        {
            Load(new FrmXuatThuoc());
            //ShowSubmenu(pnKhoDuocXuatKho);

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnBaoCaoThongKeNhapThuoc_Click(object sender, EventArgs e)
        {
            Load(new FrmBaoCaoThongKeNhapThuoc1());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Load(new FrmThongKeTonKhoHienTai());
        }

        private void FrmTongHop_Load(object sender, EventArgs e)
        {

            panel2.Visible = true;



        }

       

        private void btnKhoDuocXuatKho_Click(object sender, EventArgs e)
        {
            if (PhanQuyen.Text == "Xuất kho")
            {
                ShowSubmenu(pnKhoDuocXuatKho);
            }
            else if (PhanQuyen.Text == "admin")
            {
                ShowSubmenu(pnKhoDuocXuatKho);
            }
            else
            {
                ev.QFrmThongBaoError("Bạn không có quyền truy cập vào form này");
            }
        }

        
        private void btnPhieuYeuCauLinhThuocVatTu_Click(object sender, EventArgs e)
        {
            Load(new FrmPhieuYeuCauLinhThuocVatTu());
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            Load(new FrmXuatThuoc()); 
        }

        private void btnTaoPhieuYeuCauLinhThuoc_Click(object sender, EventArgs e)
        {
                Load(new FrmTaoPhieuYeuCauLinhThuocOQuayThuoc());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            //ShowSubmenu(pnBaoCao);
        }
         
        private void FrmTongHop_Load_1(object sender, EventArgs e)
        {
            label1.Text = FrmDangNhap.tendn;
            PhanQuyen.Text = FrmDangNhap.tenquyen;

        }

        private void bnDanhMuc_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnDanhMuc);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnDanhMuc);
        }

        private void btnBaoCao_Click_1(object sender, EventArgs e)
        {
            ShowSubmenu(pnBaoCao);
        }

        private void PhanQuyen_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmTongHop t = new FrmTongHop();
            this.Close();
            t.Close();

            this.Hide();

            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();

        }
      

        private void btnTheKho_Click(object sender, EventArgs e)
        {
            
                Load(new FrmBaoCaoTheKho());
        }

        private void btnThongKeNhapThuoc_Click(object sender, EventArgs e)
        {
            Load(new FrmBaoCaoThongKeNhapThuoc1());
        }

        private void btnXuatNhapTon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThongKeTonKhoHienTai_Click(object sender, EventArgs e)
        {
            Load(new FrmThongKeTonKhoHienTai());
            
        }

        private void btnTraCuuThuoc_Click(object sender, EventArgs e)
        {
            Load(new FrmTraCuuThuoc());

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //msql = "SELECT* FROM[dbo].[DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT] as a , [dbo].[DUOC_KC_Lo2023] as b where a.MaThuoc = b.MaThuoc";
            //DataTable tb = comm.GetDataTable(mconnectstring, msql, "BaoCaoXuatNhapTon");
            //tb.WriteXmlSchema(@"D:\testreport.xsd", true);

        }

        private void btnDanhMucThuoc_Click(object sender, EventArgs e)
        {
            Load(new FrmDanhMucThuoc());
        }

        private void btnDanhMucKhoDuoc_Click(object sender, EventArgs e)
        {
            Load(new FrmDanhMucKhoDuoc());
        }

        private void btnQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            Load(new FrmNhaCungCap());
        }

        private void btnDanhMucHoatChat_Click(object sender, EventArgs e)
        {
            Load(new FrmKhoDuoc());
        }
    }
}
