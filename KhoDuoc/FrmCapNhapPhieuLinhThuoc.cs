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
    public partial class FrmCapNhapPhieuLinhThuoc : Form
    {

        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmCapNhapPhieuLinhThuoc(string MaPhieuYC, string MaPhieuXK, string NguoiLap, string PhanLoai, string Loai, string NoiGuiYC, string Ghichu, string NgayLap, string NgayLinh, string NoiNhanYC, string SoLo, string MaLo)
        {
            InitializeComponent();
            txtMaPhieuXuatKho.Text = MaPhieuXK;
            txtMaPhieu.Text = MaPhieuYC;
            txtNguoiLap.Text = NguoiLap;
            cboChonLoai.Text = Loai;
            cboNoiGuiYeuCau.Text = NoiGuiYC;
            txtGhiChu.Text = Ghichu;
            dtNgayLap.Text = NgayLap;
            dtNgayLinh.Text = NgayLinh;
            cboNoiNhanYeuCau.Text = NoiNhanYC;
            txtLo.Text = SoLo;
            txtMaLo.Text = MaLo;










            LoadThongTinThuoc();
            LoadDataDuyet();
            dgrThongTinThuoc.Font = new System.Drawing.Font("Times New Roman", 16);
            dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Font = new System.Drawing.Font("Times New Roman", 16);
            dgvDanhSachThuocTam.Font = new Font("Times New Roman", 16);

            LoadData();
        }
        public FrmCapNhapPhieuLinhThuoc()
        {
            InitializeComponent();
            LoadThongTinThuoc();

        }
        public void LoadDataDuyet()
        {

            msql = "SELECT * FROM [KHODUOC].[dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC]  where MaPhieuYeuCau = '" + txtMaPhieu.Text + "'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "[PHIEUYEUCAULINHTHUOCQUAYTHUOC]");
            dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.AutoGenerateColumns = false;
            dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.DataSource = tb;

        }
        private void LoadData()
        {
            //cbo Chọn Loại
            msql = "SELECT* FROM[dbo].[tabNhomThuoc]";
            DataTable loai = comm.GetDataTable(mconnectstring, msql, "tabNhomThuoc");
            cboChonLoai.DataSource = loai.Copy();
            cboChonLoai.DisplayMember = "TenNhom";
            cboChonLoai.ValueMember = "TenNhom";
            cboChonLoai.CustomAlignment = new string[] { "l", "l" };
            cboChonLoai.CustomColumnStyle = new string[] { "t", "t" };


            //cbo Phân Loại
            msql = "SELECT* FROM[dbo].[tabLoaithuoc]";
            DataTable phanloai = comm.GetDataTable(mconnectstring, msql, "tabLoaithuoc");
            cboPhanLoai.DataSource = phanloai.Copy();
            cboPhanLoai.DisplayMember = "TENLOAITHUOC";
            cboPhanLoai.ValueMember = "TENLOAITHUOC";
            cboPhanLoai.CustomAlignment = new string[] { "l", "l" };
            cboPhanLoai.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi Gửi Yêu Cầu
            msql = "SELECT * FROM [KHODUOC].[dbo].[DUOC_KC_DANHMUCKHODUOC]";
            DataTable kc = comm.GetDataTable(mconnectstring, msql, "DUOC_KC_DANHMUCKHODUOC");
            cboNoiGuiYeuCau.DataSource = kc.Copy();
            cboNoiGuiYeuCau.DisplayMember = "TenKhoDuoc";
            cboNoiGuiYeuCau.ValueMember = "TenKhoDuoc";
            cboNoiGuiYeuCau.CustomAlignment = new string[] { "l", "l" };
            cboNoiGuiYeuCau.CustomColumnStyle = new string[] { "t", "t" };

            //cbo Nơi Nhận Yêu Cầu
            cboNoiNhanYeuCau.DataSource = kc.Copy();
            cboNoiNhanYeuCau.DisplayMember = "TenKhoDuoc";
            cboNoiNhanYeuCau.ValueMember = "TenKhoDuoc";
            cboNoiNhanYeuCau.CustomAlignment = new string[] { "l", "l" };
            cboNoiNhanYeuCau.CustomColumnStyle = new string[] { "t", "t" };




        }


        private void LoadThongTinThuoc()
        {
            msql = "select * from [dbo].[DUOC_KC_Lo2023] as a, [dbo].[DUOC_KC_NHAPKHO_NHAPTHUOC] as b,[dbo].[tabDanhMucThuoc] c  where a.MaPhieuNhapKho = b.MaPhieuNhapKho and a.MaThuoc=c.MaThuoc";

            //msql = "exec thongtinthuoc '','',''";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tabDanhMucThuoc LEFT JOIN[dbo].DUOC_KC_Lo2023 ON tabDanhMucThuoc.MaThuoc = DUOC_KC_Lo2023.MaThuoc where tabDanhMucThuoc.MaThuoc = DUOC_KC_Lo2023.MaThuoc");
            dgrThongTinThuoc.AutoGenerateColumns = false;
            dgrThongTinThuoc.DataSource = tb;
        }
        private void txtTenThuoc_Enter(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
        }

        private void dgrThongTinThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenThuoc_Click(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
            dgrThongTinThuoc.Visible = true;
        }

        private void dgrThongTinThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtMaThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cMaThuocT"].Value.ToString();
            txtTenThuoc.Text = dgrThongTinThuoc.CurrentRow.Cells["cTenThuocT"].Value.ToString();
            txtDVT.Text = dgrThongTinThuoc.CurrentRow.Cells["cDVTT"].Value.ToString();
            txtLo.Text = dgrThongTinThuoc.CurrentRow.Cells["cLo"].Value.ToString();
            txtMaLo.Text = dgrThongTinThuoc.CurrentRow.Cells["cMaLo"].Value.ToString();
            dtHanDung.Text = dgrThongTinThuoc.CurrentRow.Cells["cHSD"].Value.ToString();


            //txtKyHieuHD.Text = dgrNCCTT.CurrentRow.Cells["cKyHieuHD"].Value.ToString();
            //txtKyHieuMauHD.Text = dgrNCCTT.CurrentRow.Cells["cKyHieuMauHD"].Value.ToString();
            //txtSoHoaDon.Text = dgrNCCTT.CurrentRow.Cells["cSoHD"].Value.ToString();
            dgrThongTinThuoc.Visible = false;
        }

        private void btnThemThuocMoi_Click(object sender, EventArgs e)
        {
            btnLuuThemThuoc.Visible = true;
            btnThem.Visible = true;
            txtTenThuoc.Enabled = true;
            dgrThongTinThuoc.Visible = true;

            // Kiểm tra xem có dòng nào được chọn không
            if (dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Count > 0)
            {
                // Hiển thị dgrdanhsachtam và ẩn dgrNhapThuoc
                dgvDanhSachThuocTam.Visible = true;
                dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Visible = false;

                // Xóa dữ liệu hiện tại trong dgrdanhsachtam (nếu có)
                dgvDanhSachThuocTam.Rows.Clear();

                // Duyệt qua từng dòng trong dgrNhapThuoc
                foreach (DataGridViewRow row in dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows)
                {
                    // Lấy giá trị từ cột "cLo" và "cMaThuoc"

                    string giaTriMaThuoc = row.Cells["cMaThuocThem"].Value.ToString();
                    string TenThuoc = row.Cells["cTenThuocVatTu"].Value.ToString();
                    string giaTriLo = row.Cells["cDonVi"].Value.ToString();
                    string HanDung = row.Cells["cLo1"].Value.ToString();
                    string dvt = row.Cells["cMaLo1"].Value.ToString();
                    string DonGia = row.Cells["cSLYC"].Value.ToString();
                    string PTVAT = row.Cells["cMPYC"].Value.ToString();




                    // Thêm giá trị vào dgrdanhsachtam
                    dgvDanhSachThuocTam.Rows.Add(giaTriMaThuoc, TenThuoc, giaTriLo, HanDung, dvt, DonGia, PTVAT);
                }
            }
            else
            {
                // Không có dòng nào trong dgrNhapThuoc
                dgvDanhSachThuocTam.Visible = false;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            dgvDanhSachThuocTam.Visible = false;
            dgrThongTinThuoc.Visible = false;
            txtTenThuoc.Enabled = false;

            dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Visible = true;
            if (dgvDanhSachThuocTam.Visible == true)
            {
                btnThem.Visible = true;
            }
            else if (dgvDanhSachThuocTam.Visible == false)
            {

                btnThem.Visible = false;

            }
        }

        private void btnCapNhatThuoc_Click(object sender, EventArgs e)
        {
            dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Visible = true;

            for (int i = 0; i < dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows.Count; i++)
            {
                // Ensure the cells contain valid values before parsing


                msql = "UPDATE [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC]" +
   " SET [Loai] = N'" + cboPhanLoai.SelectedValue + "'" +
  ",[NgayLinh] ='" + Convert.ToDateTime(dtNgayLinh.Value).ToString("yyyy-MM-dd") + "'" +
   ",[NgayLap] = '" + Convert.ToDateTime(dtNgayLap.Value).ToString("yyyy-MM-dd") + "'" +
  " ,[NguoiLap] = N'" + txtNguoiLap.Text + "'" +
  " ,[KhoDuocNoiGuiYeuCau] = N'" + cboNoiGuiYeuCau.SelectedValue + "'" +
   ",[KhoDuocNoiNhanYeuCau] = N'" + cboNoiNhanYeuCau + "'" +
   ",[TenThuoc_VatTu] = N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cTenThuocVatTu"].Value + "'" +
   ",[DonVi] =N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cDonVi"].Value + "'" +
  ",[SoLuongYeuCau] = N'" + dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[i].Cells["cSLYC"].Value + "' " +
  ",[GhiChu] = N'" + txtGhiChu.Text + "' " +
  ",[PhanLoai] =N'" + cboPhanLoai.SelectedValue + "' " +

"WHERE [MaPhieuYeuCau] = '" + txtMaPhieu.Text + "' and [MaPhieuXuatKho] = '" + txtMaPhieuXuatKho.Text + "'";

                comm.RunSQL(mconnectstring, msql);
            }
            ev.QFrmThongBao("Cập nhật thuốc thành công");

        }





        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            ev.Qdgr_RowPostPaint(sender, e, dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc);
        }

        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {









        }

        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                // Bắt đầu chỉnh sửa dòng được chọn
                dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.BeginEdit(true);
            }
        }

        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            object editedValue = dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgrDanhSachPhieuYeuCauLinhThuocOQuayThuoc.EndEdit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtMaThuoc.Text.Trim() != "" && txtTenThuoc.Text.Trim() != "" && txtDVT.Text.Trim() != "" && txtLo.Text.Trim() != "" && txtMaLo.Text.Trim() != "" && txtSL.Text.Trim() != "")
            {
                var b = kiemtrasl(txtMaThuoc.Text, Convert.ToInt32(txtSL.Text));
                if (!b)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    dgvDanhSachThuocTam.Rows.Add(txtMaThuoc.Text, txtTenThuoc.Text, txtDVT.Text, txtLo.Text, txtMaLo.Text, txtSL.Text, txtGhiChuChiTiet.Text);

                }
            }
            else
            {

                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            }
        }


        bool kiemtrasl(String mathuoc, int sl)
        {
            if (dgvDanhSachThuocTam.RowCount > 0)
            {
                foreach (DataGridViewRow item in dgvDanhSachThuocTam.Rows)
                {
                    String currentCode = item.Cells[0].Value.ToString();
                    if (mathuoc == currentCode)
                    {
                        //tồn tại
                        int b = Convert.ToInt32(item.Cells["cSLYCTam"].Value) + sl;
                        item.Cells["cSLYCTam"].Value = b.ToString();
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }

        }

        private void btnLuuThemThuoc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDanhSachThuocTam.Rows.Count; i++)
            {
                string maThuoc = dgvDanhSachThuocTam.Rows[i].Cells["cMaThuocTam"].Value.ToString();

                // Check if the record with the same MaThuoc already exists
                string checkDuplicateSql = "SELECT COUNT(*) FROM [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC] WHERE MaThuoc = '" + maThuoc + "'";

                // Assuming comm is a SqlCommand object
                int count = 0;

                using (SqlCommand sqlCommand = new SqlCommand(checkDuplicateSql, new SqlConnection(mconnectstring)))
                {
                    sqlCommand.Connection.Open();
                    count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }

                if (count == 0)
                {
                    // If the record does not exist, insert it
                    decimal cSLTamValue = Convert.ToDecimal(dgvDanhSachThuocTam.Rows[i].Cells["cSLYCTam"].Value);
                    ev.QFrmThongBao_YesNo("Bạn có muốn thêm loại thuốc mới?");
                    msql = "INSERT INTO [dbo].[PHIEUYEUCAULINHTHUOCQUAYTHUOC]" +
                        "([MaThuoc],[TenThuoc_VatTu],[DonVi],[Lo],[MaLo],[SoLuongYeuCau],[GhiChu1]) " +
                        "VALUES('" + dgvDanhSachThuocTam.Rows[i].Cells["cMaThuocTam"].Value + "','" + dgvDanhSachThuocTam.Rows[i].Cells["cTenThuocTam"].Value + "','" + dgvDanhSachThuocTam.Rows[i].Cells["cDonViTam"].Value + "',N'" + dgvDanhSachThuocTam.Rows[i].Cells["cLoTam"].Value + "',N'" + dgvDanhSachThuocTam.Rows[i].Cells["cMaLoTam"].Value +"','" + cSLTamValue + "'" +
                        ",'" + dgvDanhSachThuocTam.Rows[i].Cells["cGhiChuTam"].Value + "')";
                    ev.QFrmThongBao("Thêm thuốc thành công");
                    comm.RunSQL(mconnectstring, msql);

                }
            }
        }
    }
}
