using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessCommon;

namespace KhoDuoc
{
    public partial class FrmKhoDuoc : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;


        public FrmKhoDuoc()
        {
            InitializeComponent();
            LoadDataHanDungNhoHon6Thang();
            dgrKhoDuoc.Font = new Font("Times New Roman", 16, FontStyle.Regular);
        }

        private void LoadDataHanDungNhoHon6Thang()
        {
            msql = "SELECT A.*, B.*, IIF(DATEDIFF(DAY, GETDATE(), HSD) < 0, N'Hết Hạn', CONVERT(varchar, DATEDIFF(DAY, GETDATE(), HSD))) AS NGAYCONLAI FROM [dbo].[tabDanhMucThuoc] AS A INNER JOIN [dbo].[DUOC_KC_NHAPKHO_NHAPNHACUNGCAP] AS B ON A.MaThuoc = B.MaThuoc;";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "[dbo].[Duoc_KC_SoLuongTon]");
            dgrKhoDuoc.AutoGenerateColumns = false;
            dgrKhoDuoc.DataSource = tb;
        }

        private void dgrKhoDuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
           


            if (dgrKhoDuoc["cXoa", e.RowIndex] == dgrKhoDuoc.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn xóa " + dgrKhoDuoc.CurrentRow.Cells["cTenThuoc"].Value.ToString() + " này không ?"))
                {
                    //Xóa dòng mình chọn

                    for (int i = 0; i < dgrKhoDuoc.Rows.Count; i++)
                    {
                        string maThuocValue = dgrKhoDuoc.Rows[i].Cells["cMaThuoc"].Value.ToString();
                        msql= "DELETE FROM [dbo].[tabDanhMucThuoc] WHERE MaThuoc = '" + maThuocValue + "'";
                        comm.RunSQL(mconnectstring, msql);



                       
                    }
                }
            }
        }
    }
}