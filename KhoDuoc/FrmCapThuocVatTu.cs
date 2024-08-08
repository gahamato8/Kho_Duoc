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
    public partial class FrmCapThuocVatTu : Form
    {
        private string mconnectstring = "server=.; database= KHODUOC; uid= sa; pwd= 123";
        private clsCommonMethod com = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public FrmCapThuocVatTu()
        {
           
            InitializeComponent();
            SetFontForHeader();
           
        }

        private void SetFontForHeader()
        {
            Font newHeaderFont = new Font("Times New Roman", 16); 

            dgrCapThuoc_VatTu.ColumnHeadersDefaultCellStyle.Font = newHeaderFont;
        }
        public void LoadDataCapThuoc()
        {

            msql = "select DISTINCT A.MaThuoc,A.Lo,B.Ton,A.DonVi,B.HanDung,B.SoLuongThucHien,A.SoLuongYeuCau,A.MaPhieuYeuCau,A.TenThuoc_VatTu,A.MaLo from PHIEUYEUCAULINHTHUOCQUAYTHUOC as A,Duoc_KC_SoLuongTon as B where A.MaLo=B.MaLo and a.MaThuoc = b.MaThuoc and a.MaPhieuYeuCau = '" +FrmDuyetPhieuLinhNoiBo.MaPhieu+ "' ";
            DataTable tb = com.GetDataTable(mconnectstring, msql, "capthuocvattu");
            dgrCapThuoc_VatTu.AutoGenerateColumns = false;
            dgrCapThuoc_VatTu.DataSource = tb;
            btnCap.Visible = true;  
        }
        public void LoadDataCapThuoc4()
        {
            //msql = "select * from PHIEUYEUCAULINHTHUOCQUAYTHUOC as A,Duoc_KC_SoLuongTon as B where A.MaLo = '" + FrmChiTietPhieuLinh.MaLo + "' and A.MaLo=B.MaLo and a.MaThuoc = b.MaThuoc and MaPhieuYeuCau='" + FrmChiTietPhieuLinh.MaPhieuYeuCau + "' ";
            //DataTable tb = com.GetDataTable(mconnectstring, msql, "capthuocvattu");
            //dgrCapThuoc_VatTu.AutoGenerateColumns = false;
            //dgrCapThuoc_VatTu.DataSource = tb;
            //btnCap4.Visible = true;
        }
        private void txtTenThuoc_VatTu_Enter(object sender, EventArgs e)
        {
            txtTenThuoc_VatTu.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDonVi_Enter(object sender, EventArgs e)
        {
            txtDonVi.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSoLuongYeuCau_Enter(object sender, EventArgs e)
        {
            txtSoLuongYeuCau.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_VatTu_Leave(object sender, EventArgs e)
        {
            txtTenThuoc_VatTu.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDonVi_Leave(object sender, EventArgs e)
        {
            txtDonVi.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSoLuongYeuCau_Leave(object sender, EventArgs e)
        {
            txtSoLuongYeuCau.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void btnBoQuaThongTinThuoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenThuoc_VatTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDonVi);
        }

        private void txtDonVi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSoLuongYeuCau);
        }


        private void btnCap_Click(object sender, EventArgs e)
        {



            if (int.TryParse(txtCap.Text, out int SL))
            {
                string cellValue = dgrCapThuoc_VatTu.CurrentRow.Cells["cSLYC"].Value.ToString();
                int cellValueInt;

                if (int.TryParse(cellValue, out cellValueInt))
                {
                    if (SL > cellValueInt)
                    {
                        ev.QFrmThongBaoError("Số lượng cấp vượt quá số lượng yêu cầu");
                    }
                    else
                    {
                        if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn muốn cấp số lượng cấp không ?"))
                        {
                            CapNhatSoCapOQuayThuoc();
                            ThucHienXuatSLTonFIFO();
                            LoadDataCapThuoc();
                            ev.QFrmThongBao("Bạn đã cấp thuốc thành công");
                            this.Hide();


                            FrmDuyetPhieuLinhNoiBo f = new FrmDuyetPhieuLinhNoiBo();




                            f.LoadDataDuyet();
                            f.ShowDialog();
                            this.Hide();
                        }
                    }

                }
              


            }
           
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin ");
                txtCap.Focus();
        }
        private void btnCap4_Click(object sender, EventArgs e)
        {
            if (txtCap.Text.Trim() != "")
            {
                if (ev.QFrmThongBao_YesNo("Bạn có chắc chắn muốn sửa số lượng cấp không ?"))
                {
                    CapNhatSoCapOQuayThuoc();
                    CapNhatSoCapOThongTinThuocXuat();
                    ThucHienXuatSLTonFIFO();
                    LoadDataCapThuoc4();
                    ev.QFrmThongBao("Bạn đã cấp thuốc thành công");
                    this.Hide();


                    FrmChiTietPhieuLinh g = new FrmChiTietPhieuLinh();
                    g.LoadDataTrangThai4();
                    g.ShowDialog();
                    this.Hide();
                }
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin ");
            txtCap.Focus();
        }
        private void ThucHienXuatSLTonFIFO()
        {
                {
                msql = "exec FiFoKhoChan '','" + txtCap.Text + "',0,0,'" + dgrCapThuoc_VatTu.CurrentRow.Cells["cMaThuoc"].Value.ToString() + "','','','','" + dgrCapThuoc_VatTu.CurrentRow.Cells["cMaPhieuYeuCau"].Value.ToString() + "','',1";
                com.RunSQL(mconnectstring, msql);
                }
        }
        
        private void CapNhatSoCapOQuayThuoc()
        {
            msql = "UPDATE[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] SET  [SoLuongCap] = N'" + txtCap.Text + "' WHERE MaPhieuYeuCau='" + FrmXuatThuoc.MaPhieuYeuCau + "' and MaThuoc= N'" + dgrCapThuoc_VatTu.CurrentRow.Cells["cMaThuoc"].Value + "' and [TrangThai]=4 ";
            com.RunSQL(mconnectstring, msql);
        }
        private void CapNhatSoCapOThongTinThuocXuat()
        {
            msql = "UPDATE[dbo].[DUYETPHIEULINHNOIBO_THONGTINTHUOCXUAT] SET[SoLuongCap] = N'" + txtCap.Text + "' WHERE MaPhieuYeuCau='" + FrmXuatThuoc.MaPhieuYeuCau + "' and MaThuoc= N'" + dgrCapThuoc_VatTu.CurrentRow.Cells["cMaThuoc"].Value + "' ";
            com.RunSQL(mconnectstring, msql);
        }
       
        private void close()
        {
            this.Close();
        }

        private void dgrCapThuoc_VatTu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ev.Qdgr_RowPostPaint(sender, e, dgrCapThuoc_VatTu);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDuyetPhieuLinhNoiBo i = new FrmDuyetPhieuLinhNoiBo();
            i.ShowDialog();
            i = null;
            this.Show();
        }

        private void dgrCapThuoc_VatTu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtTenThuoc_VatTu.Text = dgrCapThuoc_VatTu.CurrentRow.Cells["cThuocVatTu"].Value.ToString();
            txtDonVi.Text = dgrCapThuoc_VatTu.CurrentRow.Cells["cDonVi"].Value.ToString();
            txtSoLuongYeuCau.Text = dgrCapThuoc_VatTu.CurrentRow.Cells["cSLYC"].Value.ToString();
            txtLo.Text = dgrCapThuoc_VatTu.CurrentRow.Cells["cLo"].Value.ToString();
            txtCap.Text = dgrCapThuoc_VatTu.CurrentRow.Cells["cSoLuongCap"].Value.ToString();

        }

        private void dgrCapThuoc_VatTu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
