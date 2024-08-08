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
using VBSQLHelper;

namespace KhoDuoc
{
    public partial class FrmNhapHangTuNhaCungCap : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        //ReportDocument BaoCao = new ReportDocument();
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        public FrmNhapHangTuNhaCungCap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }






        private void btnThem_Click(object sender, EventArgs e)
        {
            //txtMaPhieu.Text = CreateAutoID();
            if (txtMaThuoc.Text.Trim() != "" )
            {

                
                double ThanhTien = (double.Parse(txtDonGia.Text) * double.Parse(txtSoLuong.Text));


                int sc = dgvNhapHangTuNhaCungCap.Rows.Count;
                    double thanhtien = ThanhTien;
                for (int i = 0; i < sc; ++i)
                    thanhtien += double.Parse(dgvNhapHangTuNhaCungCap.Rows[i].Cells[6].Value.ToString());
                txtThanhTien.Text = thanhtien.ToString();

                DataGridViewRow row = new DataGridViewRow(); //Khai báo row
                //Thêm dữ liệu vào từng dòng trong datagridview
                dgvNhapHangTuNhaCungCap.Rows.Add(txtMaThuoc.Text, txtTenThuoc.Text, txtSoLo.Text, dtpHSD.Value.ToString("dd/MM/yyyy"),txtSoLuong,txtDonGia);

               
                if (txtThanhTien.Text.Equals("0"))
                    return;
                double temp1 = Convert.ToDouble(txtThanhTien.Text);
                txtThanhTien.Text = temp1.ToString("#,###");

                

                //var affectRow = SQLHelper.ExecQueryNonData(msql, new { MaPhieuNhapKho = txtMaPhieu.Text });
                //// fix insert sql injection
                //if (affectRow > 0)
                //{
                //    // Insert success
                //    txtMaPhieu.Text = CreateAutoID();
                //}
                //demsl();
                //System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                //decimal value = decimal.Parse(txtThanhTien.Text, System.Globalization.NumberStyles.AllowThousands);
                //txtThanhTien.Text = String.Format(culture, "{0:N0}", value);
                //txtThanhTien.Select(txtThanhTien.Text.Length, 0);

                //System.Globalization.CultureInfo culture1 = new System.Globalization.CultureInfo("en-US");
                //decimal value1 = decimal.Parse(txtTienThue.Text, System.Globalization.NumberStyles.AllowThousands);
                //txtTienThue.Text = String.Format(culture1, "{0:N0}", value1);
                //txtTienThue.Select(txtTienThue.Text.Length, 0);

                //System.Globalization.CultureInfo culture2 = new System.Globalization.CultureInfo("en-US");
                //decimal value2 = decimal.Parse(txtTTVAT.Text, System.Globalization.NumberStyles.AllowThousands);
                //txtTTVAT.Text = String.Format(culture2, "{0:N0}", value2);
                //txtTTVAT.Select(txtTTVAT.Text.Length, 0);
                txtMaThuoc.ResetText();
                txtTenThuoc.ResetText();
                //txtDVT.ResetText();
                txtThanhTien.ResetText();
                txtSoLuong.ResetText();





            }
            else
            {
                ev.QFrmThongBaoError("Vui lòng nhập thông tin đầy đủ");
            }
                 }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
            } 

