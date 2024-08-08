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
    public partial class FrmSuaThuoc : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmSuaThuoc()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            msql = "SELECT * FROM[KHODUOC].[dbo].[SUATHUOC_THONGTINTHUOC]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "SUATHUOC_THONGTINTHUOC");
            //dgrXuatKho.AutoGenerateColumns = true;
            //dgrXuatKho.DataSource = tb;
        }







        private void txtTenThuoc_Enter(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDuocLy_Enter(object sender, EventArgs e)
        {
            txtDuocLy.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHamLuong_Enter(object sender, EventArgs e)
        {
            txtHamLuong.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtLieuDung_Enter(object sender, EventArgs e)
        {
            txtLieuDung.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSoDK_Enter(object sender, EventArgs e)
        {
            txtSoDK.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDongGoi_Enter(object sender, EventArgs e)
        {
            txtDongGoi.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtChongChiDinh_Enter(object sender, EventArgs e)
        {
            txtChongChiDinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDangBaoChe_Enter(object sender, EventArgs e)
        {
            txtDangBaoChe.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSoQuyDoiTheoLieu_Enter(object sender, EventArgs e)
        {
            txtSoQuyDoiTheoLieu.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDonViTinhLieu_Enter(object sender, EventArgs e)
        {
            txtDonViTinhLieu.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSoLieuNgay_Enter(object sender, EventArgs e)
        {
            txtSoLieuNgay.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaThuoc_Enter(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaATC_Enter(object sender, EventArgs e)
        {
            txtMaATC.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHangSanXuat_Enter(object sender, EventArgs e)
        {
            txtHangSanXuat.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTacDungPhu_Enter(object sender, EventArgs e)
        {
            txtTacDungPhu.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGiaNhap_Enter(object sender, EventArgs e)
        {
            txtGiaNhap.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGiaNoi_Enter(object sender, EventArgs e)
        {
            txtGiaNoi.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSoQuyDoi_Enter(object sender, EventArgs e)
        {
            txtSoQuyDoi.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDonViKeToa_Enter(object sender, EventArgs e)
        {
            txtDonViKeToa.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtThanhPhan_Enter(object sender, EventArgs e)
        {
            txtThanhPhan.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaDuocQuocGia_Enter(object sender, EventArgs e)
        {
            txtMaDuocQuocGia.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDonVi_Enter(object sender, EventArgs e)
        {
            txtDonVi.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtCachDung_Enter(object sender, EventArgs e)
        {
            txtCachDung.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNuocSanXuat_Enter(object sender, EventArgs e)
        {
            txtNuocSanXuat.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtChiDinh_Enter(object sender, EventArgs e)
        {
            txtChiDinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGhiChu_Enter(object sender, EventArgs e)
        {
            txtGhiChu.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGiaNhaThuoc_Enter(object sender, EventArgs e)
        {
            txtGiaNhaThuoc.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSoLanNgay_Enter(object sender, EventArgs e)
        {
            txtSoLanNgay.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTheTich_Enter(object sender, EventArgs e)
        {
            txtTheTich.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDonViSD_Enter(object sender, EventArgs e)
        {
            txtDonViSD.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            txtTenThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDuocLy_Leave(object sender, EventArgs e)
        {
            txtDuocLy.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtHamLuong_Leave(object sender, EventArgs e)
        {
            txtHamLuong.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtLieuDung_Leave(object sender, EventArgs e)
        {
            txtLieuDung.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSoDK_Leave(object sender, EventArgs e)
        {
            txtSoDK.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDongGoi_Leave(object sender, EventArgs e)
        {
            txtDongGoi.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtChongChiDinh_Leave(object sender, EventArgs e)
        {
            txtChongChiDinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDangBaoChe_Leave(object sender, EventArgs e)
        {
            txtDangBaoChe.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSoQuyDoiTheoLieu_Leave(object sender, EventArgs e)
        {
            txtSoQuyDoiTheoLieu.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDonViTinhLieu_Leave(object sender, EventArgs e)
        {
            txtDonViTinhLieu.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSoLieuNgay_Leave(object sender, EventArgs e)
        {
            txtSoLieuNgay.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaThuoc_Leave(object sender, EventArgs e)
        {
            txtMaThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaATC_Leave(object sender, EventArgs e)
        {
            txtMaATC.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtHangSanXuat_Leave(object sender, EventArgs e)
        {
            txtHangSanXuat.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTacDungPhu_Leave(object sender, EventArgs e)
        {
            txtTacDungPhu.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGiaNhap_Leave(object sender, EventArgs e)
        {
            txtGiaNhap.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGiaNoi_Leave(object sender, EventArgs e)
        {
            txtGiaNoi.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSoQuyDoi_Leave(object sender, EventArgs e)
        {
            txtSoQuyDoi.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDonViKeToa_Leave(object sender, EventArgs e)
        {
            txtDonViKeToa.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtThanhPhan_Leave(object sender, EventArgs e)
        {
            txtThanhPhan.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaDuocQuocGia_Leave(object sender, EventArgs e)
        {
            txtMaDuocQuocGia.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDonVi_Leave(object sender, EventArgs e)
        {
            txtDonVi.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void txtCachDung_Leave(object sender, EventArgs e)
        {
            txtCachDung.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }
        private void txtNuocSanXuat_Leave(object sender, EventArgs e)
        {
            txtNuocSanXuat.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtChiDinh_Leave(object sender, EventArgs e)
        {
            txtChiDinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGhiChu_Leave(object sender, EventArgs e)
        {
            txtGhiChu.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGiaNhaThuoc_Leave(object sender, EventArgs e)
        {
            txtGiaNhaThuoc.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSoLanNgay_Leave(object sender, EventArgs e)
        {
            txtSoLanNgay.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTheTich_Leave(object sender, EventArgs e)
        {
            txtTheTich.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDonViSD_Leave(object sender, EventArgs e)
        {
            txtDonViSD.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDuocLy);
        }

        private void txtDuocLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHamLuong);
        }

        private void txtHamLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtLieuDung);
        }

        private void txtLieuDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSoDK);
        }

        private void txtSoDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDongGoi);
        }

        private void txtDongGoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtChongChiDinh);
        }

        private void txtChongChiDinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDangBaoChe);
        }

        private void txtDangBaoChe_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSoQuyDoiTheoLieu);
        }

        private void txtSoQuyDoiTheoLieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDonViTinhLieu);
        }

        private void txtDonViTinhLieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSoLieuNgay);
        }

        private void txtSoLieuNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtMaThuoc);
        }

        private void txtMaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtMaATC);
        }

        private void txtMaATC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHangSanXuat);
        }

        private void txtHangSanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTacDungPhu);
        }

        private void txtTacDungPhu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGiaNhap);
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGiaNoi);
        }

        private void txtGiaNoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSoQuyDoi);
        }

        private void txtSoQuyDoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDonViKeToa);
        }

        private void txtDonViKeToa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtThanhPhan);
        }

        private void txtThanhPhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtMaDuocQuocGia);
        }

        private void txtMaDuocQuocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDonVi);
        }
        
        private void txtDonVi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtCachDung);
        }
        private void txtCachDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNuocSanXuat);
        }
        private void txtNuocSanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtChiDinh);
        }

        private void txtChiDinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGhiChu);
        }

        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGiaNhaThuoc);
        }

        private void txtGiaNhaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSoLanNgay);
        }

        private void txtSoLanNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTheTich);
        }

        private void txtTheTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDonViSD);
        }

        private void txtDonViSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnLuuThongTinThuoc);
        }

        private void btnBoQuaThongTinThuoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Thông tin thầu vs BHYT
        private void txtQuyetDinh_Enter(object sender, EventArgs e)
        {
            txtQuyetDinh.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }


        private void txtQuyetDinh_Leave(object sender, EventArgs e)
        {
            txtQuyetDinh.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }


        private void txtQuyetDinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtMaHoatChat);
        }


        private void btnBoQuaTTTBHYT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaHoatChat_Enter(object sender, EventArgs e)
        {
            txtMaHoatChat.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtHam_Luong_Enter(object sender, EventArgs e)
        {
            txtHam_Luong.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtSoLuongBHYT_Enter(object sender, EventArgs e)
        {
            txtSoLuongBHYT.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }


        private void txtMaDuongDung_Enter(object sender, EventArgs e)
        {
            txtMaDuongDung.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGiaThau_Enter(object sender, EventArgs e)
        {
            txtGiaThau.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtDKGPNK_Enter(object sender, EventArgs e)
        {
            txtDKGPNK.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGiaBaoHiem_Enter(object sender, EventArgs e)
        {
            txtGiaBaoHiem.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTiLeThanhToan_Enter(object sender, EventArgs e)
        {
            txtTiLeThanhToan.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTenThuocBaoHiem_Enter(object sender, EventArgs e)
        {
            txtTenThuocBaoHiem.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtGoiThau_Enter(object sender, EventArgs e)
        {
            txtGoiThau.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtNhaThau_Enter(object sender, EventArgs e)
        {
            txtNhaThau.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtMaHoatChat_Leave(object sender, EventArgs e)
        {
            txtMaHoatChat.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtHam_Luong_Leave(object sender, EventArgs e)
        {
            txtHam_Luong.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtSoLuongBHYT_Leave(object sender, EventArgs e)
        {
            txtSoLuongBHYT.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaDuongDung_Leave(object sender, EventArgs e)
        {
            txtMaDuongDung.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGiaThau_Leave(object sender, EventArgs e)
        {
            txtGiaThau.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtDKGPNK_Leave(object sender, EventArgs e)
        {
            txtDKGPNK.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGiaBaoHiem_Leave(object sender, EventArgs e)
        {
            txtGiaBaoHiem.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTiLeThanhToan_Leave(object sender, EventArgs e)
        {
            txtTiLeThanhToan.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTenThuocBaoHiem_Leave(object sender, EventArgs e)
        {
            txtTenThuocBaoHiem.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtGoiThau_Leave(object sender, EventArgs e)
        {
            txtGoiThau.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtNhaThau_Leave(object sender, EventArgs e)
        {
            txtNhaThau.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtMaHoatChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtHam_Luong);
        }

        private void txtHam_Luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtSoLuongBHYT);
        }

        private void txtSoLuongBHYT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtMaDuongDung);
        }


        private void txtMaDuongDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGiaThau);
        }

        private void txtGiaThau_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtDKGPNK);
        }

        private void txtDKGPNK_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGiaBaoHiem);
        }

        private void txtGiaBaoHiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTiLeThanhToan);
        }

        private void txtTiLeThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtTenThuocBaoHiem);
        }

        private void txtTenThuocBaoHiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtGoiThau);
        }

        private void txtGoiThau_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_TextBox_Focus(sender, e, txtNhaThau);
        }

        private void txtNhaThau_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnLuuTTTBHYT);
        }

        private void btnLuuThongTinThuoc_Click(object sender, EventArgs e)
        {
            if (txtTenThuoc.Text.Trim() != "")
            {
                msql = "INSERT INTO [dbo].[DUOC_KC_DANHMUCTHUOC_THEMTHUOC_THONGTINTHUOC]" +
                    ("[TenThuoc],[MaThuoc],[MaATC],[MaDuocQuocGia]" + "[MaDQG],[NhomDuocLy],[PhanLoaiDoc],[DonVi]" + "[CachDung],[HamLuong],[LieuDung],[HangSanXuat]"
                    + "[NuocSanXuat],[SoDK],[DongGoi],[KhuDieuTri]" + "[TreEm],[ThuocTriUngThu],[ChiDinh],[ChongChiDinh]" + "[TacDungPhu],[GhiChu],[DangBaoChe],[GiaNhap]"
                    + "[GiaNoiVien],[GiaNhaThuoc],[SoLan_Ngay],[SLQuyDoiTheoLieu]" + "[DonViTinhLieu],[SLQuyDoi-DonviSD],[DonViSuDung],[TheTich-DonVi]"
                    + "[DonViSuDungTheTich],[SoLuong_Ngay],[TuDongTinh],[ThanhPhan_HoatChat]" + "[HangTonKho],[ThuocBanChan],[ThuocPhatNguyen],[HanDungThuoc],[SoGioDungThuoc]") +
                "VALUES (N'" + txtTenThuoc.Text + "',N'" + txtMaThuoc.Text + "',N'" + txtMaATC.Text + "',N'" + txtMaDuocQuocGia.Text + "',N'" + txtDuocLy.Text + "',N'" + cboPhanLoaiDoc.SelectedValue + "',N'" + txtDonVi.Text + "'," +
                "N'" + txtCachDung.Text + "',N'" + txtHamLuong.Text + "',N'" + txtLieuDung.Text + "',N'" + txtHangSanXuat.Text + "',N'" + txtNuocSanXuat.Text + "',N'" + txtSoDK.Text + "',N'" + txtDongGoi.Text + "'," +
                "N'" + cboKhuDieuTri.SelectedValue + "',N'" + chkTreEm.Checked + "',N'" + chkThuocTriUngThu.Checked + "',N'" + txtChiDinh.Text + "',N'" + txtChongChiDinh.Text + "',N'" + txtTacDungPhu.Text + "',N'" + txtGhiChu.Text + "',N'" + txtDangBaoChe.Text + "',N'" + txtGiaNhap.Text + "'," +
                "N'" + txtGiaNoi.Text + "',N'" + txtGiaNhaThuoc.Text + "',N'" + txtSoLanNgay.Text + "',N'" + txtSoQuyDoiTheoLieu.Text + "',N'" + txtDonViTinhLieu.Text + "',N'" + txtSoQuyDoi.Text + "',N'" + txtDonViKeToa.Text + "'," +
                "N'" + txtTheTich.Text + "',N'" + txtDonViSD.Text + "',N'" + txtSoLieuNgay.Text + "',N'" + chkTuDongTinh.Checked + "',N'" + txtThanhPhan.Text + "',N'" + chkHangTonKho.Checked + "',N'" + chkThuocBanChan.Checked + "',N'" + chkThuocPhatNguyen.Checked + "',N'" + chkHanDungThuoc.Checked + "',N'" + cboSoGioDungThuoc.SelectedValue + "')";
                comm.RunSQL(mconnectstring, msql);
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin ");
            txtTenThuoc.Focus();
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {

            string filename = "";

            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filename = ofd.FileName;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLuuTTTBHYT_Click(object sender, EventArgs e)
        {
            if (txtTenThuoc.Text.Trim() != "")
            {
                msql = "INSERT INTO [dbo].[DUOC_KC_DANHMUCTHUOC_THEMTHUOC_THONGTINTHAUVABHYT]" +
                    ("[QuyetDinh],[NgayCongBo],[BHYTHoTro],[GiaBaoHiem]" + "[TyLeThanhToan],[MaHoatChat],[MaDuongDung],[NhomChiPhiBH]"
                    + "[TenThuocBH],[HamLuong],[GoiThau],[NhomThau]" + "[NhaThau],[SoLuongBHYT],[SoDK GPNK]") +
                "VALUES (N'" + txtQuyetDinh.Text + "',N'" + dtNgayCongBo.Value + "',N'" + chkBHYTHoTro.Checked + "',N'" + txtMaDuocQuocGia.Text + "',N'" + txtGiaBaoHiem.Text + "',N'" + txtTiLeThanhToan.Text + "',N'" + txtMaHoatChat.Text + "'," +
                "N'" + cboNhomChiPhiBaoHiem.SelectedValue + "',N'" + txtTenThuocBaoHiem.Text + "',N'" + txtHam_Luong.Text + "',N'" + txtGiaThau.Text + "',N'" + txtGoiThau.Text + "',N'" + txtNhaThau.Text + "',N'" + txtSoLuongBHYT.Text + "'," +
                "N'" + txtDKGPNK.Text + "')";
                comm.RunSQL(mconnectstring, msql);
            }
            else
                ev.QFrmThongBaoError("Vui lòng nhập thông tin ");
            txtTenThuoc.Focus();
        }
    }
}
