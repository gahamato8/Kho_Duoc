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
using FlexCel;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;



namespace KhoDuoc
{
    public partial class FrmDanhMucThuoc : Form
    {
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;
        
        public FrmDanhMucThuoc()
        {
            InitializeComponent();

            LoadThongTinThuoc();
            LoadTHoatChatThuoc();
            loadcbo();
            dgrThongTinThuoc.Font = new Font("Times New Roman", 16);

        }
        private void LoadThongTinThuoc()
        {
            msql = "select ThanhPhan,ChiDinh,ChongChiDinh,HoatChat from [dbo].[Duoc_ThongTinThuoc] ";
            DataTable tb1 = comm.GetDataTable(mconnectstring, msql, "Duoc_ThongTinThuoc");
            dgrThongTinThuoc.AutoGenerateColumns = true;
            dgrThongTinThuoc.DataSource = tb1;
        }
        private void LoadTHoatChatThuoc()
        {
            msql = "select NongDo,HamLuong,HoatChat from [dbo].[Duoc_ThongTinThuoc] ";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "Duoc_HoatChat");
            dgrHoatChatThuoc.AutoGenerateColumns = true;
            dgrHoatChatThuoc.DataSource = tb;
        }

        void loadcbo()
        {


            msql = "SELECT * FROM  [dbo].[Duoc_ThongTinThuoc] ";
            DataTable KhoDuoc = comm.GetDataTable(mconnectstring, msql, "Duoc_ThongTinThuoc");

            cboHCT.DataSource = KhoDuoc.Copy();
            cboHCT.DisplayMember = "HoatChat";
            cboHCT.ValueMember = "MaThuoc";
            cboHCT.CustomAlignment = new string[] { "l", "l" };
            cboHCT.CustomColumnStyle = new string[] { "t", "t" };


            msql = "SELECT * FROM  [dbo].[Duoc_ThongTinThuoc] ";
            DataTable KhoDuoc1 = comm.GetDataTable(mconnectstring, msql, "Duoc_ThongTinThuoc");

            cboTimTTT.DataSource = KhoDuoc1.Copy();
            cboTimTTT.DisplayMember = "HoatChat";
            cboTimTTT.ValueMember = "MaThuoc";
            cboTimTTT.CustomAlignment = new string[] { "l", "l" };
            cboTimTTT.CustomColumnStyle = new string[] { "t", "t" };

        }



        private void btnExcel_Click(object sender, EventArgs e)
        {
            //var saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter =
            //    "XLS (*.xls)|*.xls|" +
            //    "XLT (*.xlt)|*.xlt|" +
            //    "XLSX (*.xlsx)|*.xlsx|" +
            //    "XLSM (*.xlsm)|*.xlsm|" +
            //    "XLTX (*.xltx)|*.xltx|" +
            //    "XLTM (*.xltm)|*.xltm|" +
            //    "ODS (*.ods)|*.ods|" +
            //    "OTS (*.ots)|*.ots|" +
            //    "CSV (*.csv)|*.csv|" +
            //    "TSV (*.tsv)|*.tsv|" +
            //    "HTML (*.html)|*.html|" +
            //    "MHTML (.mhtml)|*.mhtml|" +
            //    "PDF (*.pdf)|*.pdf|" +
            //    "XPS (*.xps)|*.xps|" +
            //    "BMP (*.bmp)|*.bmp|" +
            //    "GIF (*.gif)|*.gif|" +
            //    "JPEG (*.jpg)|*.jpg|" +
            //    "PNG (*.png)|*.png|" +
            //    "TIFF (*.tif)|*.tif|" +
            //    "WMP (*.wdp)|*.wdp";

            //saveFileDialog.FilterIndex = 3;

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    var workbook = new ExcelFile();
            //    var worksheet = workbook.Worksheets.Add("Sheet1");

            //    // From DataGridView to ExcelFile.
            //    DataGridViewConverter.ImportFromDataGridView(
            //        worksheet,
            //        this.dgrDanhSachDanhMucHoatChat,
            //        new ImportFromDataGridViewOptions() { ColumnHeaders = true });

            //    workbook.Save(saveFileDialog.FileName);
            //}
        }

       
        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            //var saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter =
            //    "XLS (*.xls)|*.xls|" +
            //    "XLT (*.xlt)|*.xlt|" +
            //    "XLSX (*.xlsx)|*.xlsx|" +
            //    "XLSM (*.xlsm)|*.xlsm|" +
            //    "XLTX (*.xltx)|*.xltx|" +
            //    "XLTM (*.xltm)|*.xltm|" +
            //    "ODS (*.ods)|*.ods|" +
            //    "OTS (*.ots)|*.ots|" +
            //    "CSV (*.csv)|*.csv|" +
            //    "TSV (*.tsv)|*.tsv|" +
            //    "HTML (*.html)|*.html|" +
            //    "MHTML (.mhtml)|*.mhtml|" +
            //    "PDF (*.pdf)|*.pdf|" +
            //    "XPS (*.xps)|*.xps|" +
            //    "BMP (*.bmp)|*.bmp|" +
            //    "GIF (*.gif)|*.gif|" +
            //    "JPEG (*.jpg)|*.jpg|" +
            //    "PNG (*.png)|*.png|" +
            //    "TIFF (*.tif)|*.tif|" +
            //    "WMP (*.wdp)|*.wdp";

            //saveFileDialog.FilterIndex = 3;

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    var workbook = new ExcelFile();
            //    var worksheet = workbook.Worksheets.Add("Sheet1");

            //    From DataGridView to ExcelFile.
            //    DataGridViewConverter.ImportFromDataGridView(
            //        worksheet,
            //        this.dgrDanhSachDanhMucHoatChat,
            //        new ImportFromDataGridViewOptions() { ColumnHeaders = true });

            //    workbook.Save(saveFileDialog.FileName);
            //}
        }

       

        private void btnTimThongTinThuoc_Click(object sender, EventArgs e)
        {
            msql = "select ThanhPhan,ChiDinh,ChongChiDinh,HoatChat from [dbo].[Duoc_ThongTinThuoc] where HoatChat='"+cboTimTTT.Text+" '";
            DataTable tb1 = comm.GetDataTable(mconnectstring, msql, "Duoc_ThongTinThuoc");
            dgrThongTinThuoc.AutoGenerateColumns = true;
            dgrThongTinThuoc.DataSource = tb1;
        }

        private void btnTimHoatChat_Click(object sender, EventArgs e)
        {
            msql = "select ThanhPhan,ChiDinh,ChongChiDinh,HoatChat from [dbo].[Duoc_ThongTinThuoc] where HoatChat='" + cboHCT.Text + "'";
            DataTable tb1 = comm.GetDataTable(mconnectstring, msql, "Duoc_ThongTinThuoc");
            dgrHoatChatThuoc.AutoGenerateColumns = true;
            dgrHoatChatThuoc.DataSource = tb1;
        }

        private void cboHCT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXuatExecl_Click(object sender, EventArgs e)
        {

        }
    }

}
