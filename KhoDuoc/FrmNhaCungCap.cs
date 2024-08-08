using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Windows.Forms;
using FlexCel;
using BusinessCommon;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using OfficeOpenXml;
using System.Data.SqlClient;
using System.Data.OleDb;
using ExcelDataReader;

namespace KhoDuoc
{
    public partial class FrmNhaCungCap : Form
    {
        private string defaultFolderPath = @"D:\excel"; // Thư mục mặc định
        private string mconnectstring = "server=.;database = KHODUOC; uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public static string MaNhaCungCap;

        DataSet ds;


        //Chưa làm excel
        public FrmNhaCungCap()
        {
            InitializeComponent();
            LoadData();
            dgrNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 16);

        }




        private void LoadDataTimKiem()
        {


            msql = "SELECT * FROM[dbo].[tabMANGUOIBAN] where TENNGUOIBAN='"+txtTimTheoTen.Text+"'";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tabMANGUOIBAN");
            dgrNhaCungCap.AutoGenerateColumns = false;
            dgrNhaCungCap.DataSource = tb;
        }





        private void ExportToExcel(List<string> selectedColumns, string exportPath)
        {
            // Create a DataTable to store the exported data
            DataTable exportTable = new DataTable();
            try
            {
                // Populate DataTable with selected columns
                foreach (string columnName in selectedColumns)
                {
                    // Use the header text as the column name
                    string headerText = dgrNhaCungCap.Columns[columnName].HeaderText;
                    exportTable.Columns.Add(headerText);
                }

                // Populate DataTable with data from DataGridView
                foreach (DataGridViewRow row in dgrNhaCungCap.Rows)
                {
                    DataRow newRow = exportTable.NewRow();
                    foreach (string columnName in selectedColumns)
                    {
                        // Use the header text as the column name
                        string headerText = dgrNhaCungCap.Columns[columnName].HeaderText;

                        // Handle DBNull and null values
                        object cellValue = row.Cells[columnName].Value;
                        newRow[headerText] = (cellValue != null && cellValue != DBNull.Value) ? cellValue : DBNull.Value;
                    }
                    exportTable.Rows.Add(newRow);
                }

                // Define the Excel file path
                string excelFilePath = Path.Combine(exportPath, "ExportedData.xlsx");

                // Create and save the Excel document
                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(excelFilePath, SpreadsheetDocumentType.Workbook))
                {
                    // Add workbook part
                    spreadsheetDocument.AddWorkbookPart();
                    spreadsheetDocument.WorkbookPart.Workbook = new Workbook();

                    // Add worksheet part
                    WorksheetPart worksheetPart = spreadsheetDocument.WorkbookPart.AddNewPart<WorksheetPart>();
                    worksheetPart.Worksheet = new Worksheet(new SheetData());

                    // Get the sheet data
                    SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                    // Add header row to the Excel sheet
                    Row headerRow = new Row();
                    foreach (string columnName in selectedColumns)
                    {
                        string headerText = dgrNhaCungCap.Columns[columnName].HeaderText;
                        Cell cell = new Cell(new CellValue(headerText));
                        headerRow.AppendChild(cell);
                    }
                    sheetData.AppendChild(headerRow);

                    // Add data rows to the Excel sheet
                    foreach (DataRow dataRow in exportTable.Rows)
                    {
                        Row newRow = new Row();
                        foreach (string columnName in selectedColumns)
                        {
                            string headerText = dgrNhaCungCap.Columns[columnName].HeaderText;
                            newRow.AppendChild(new Cell(new CellValue(dataRow[headerText].ToString())));
                        }
                        sheetData.AppendChild(newRow);
                    }

                    // Add sheet information to the workbook
                    Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
                    Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
                    sheets.Append(sheet);

                    // Save the Excel document
                    spreadsheetDocument.Save();
                }
                ev.QFrmThongBao($"Xuất Excel thành công! Đã lưu tại: { excelFilePath }");
            }
            catch (Exception)
            {
                // Handle exceptions, log the error, or display an error message
                ev.QFrmThongBaoError("Xuất Excel thất bại Xin vui lòng tắt excel hiện đang mở");
            }

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // Create a mapping for DataGridView column names and their corresponding export names
            Dictionary<string, string> columnMapping = new Dictionary<string, string>
    {
        {"cMaNhaCungCap", "Mã"},
        {"cTenNhaSanXuat", "Tên nhà cung cấp"},
        {"cSDT", "Số điện thoại"},
        {"cDiaChi", "Địa chỉ"},
        // Add other mappings as needed
    };

            // Get the selected columns using the mapping
            List<string> selectedColumns = new List<string>(columnMapping.Keys);

            // Show the folder browser dialog to choose the export path
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = defaultFolderPath;
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    defaultFolderPath = folderBrowserDialog.SelectedPath;

                    // Call the ExportToExcel method with the selected columns and export path
                    ExportToExcel(selectedColumns, defaultFolderPath);
                }
            }
        }


        private void LoadData()
        {


            msql = "SELECT * FROM[dbo].[tabMANGUOIBAN]";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "tabMANGUOIBAN");
            dgrNhaCungCap.AutoGenerateColumns = false;
            dgrNhaCungCap.DataSource = tb;
        }
        private void ToExcel(DataGridView dgrHangSanXuat, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "KHODUOC";

                // export header
                for (int i = 0; i < dgrHangSanXuat.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgrHangSanXuat.Columns[i].HeaderText;
                }

                // export content
                for (int i = 0; i < dgrHangSanXuat.RowCount; i++)
                {
                    for (int j = 0; j < dgrHangSanXuat.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgrHangSanXuat.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                ev.QFrmThongBao("Xuất file excel thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }




       

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemSuaNhaCungCap f = new FrmThemSuaNhaCungCap();
            f.ShowDialog();
        }

        private void FrmHangSanXuat_Load(object sender, EventArgs e)
        {





        }

        private void txtTimTheoTen_Click(object sender, EventArgs e)
        {

        }

        private void txtTimTheoTen_Enter(object sender, EventArgs e)
        {
            txtTimTheoTen.xActive = true;
            ev.Qtxt_Enter(sender, e);
        }

        private void txtTimTheoTen_Leave(object sender, EventArgs e)
        {
            txtTimTheoTen.xActive = false;
            ev.Qtxt_Leave(sender, e);
        }

        private void txtTimTheoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnLamMoi);
        }

        private void txtTimTheoTen_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgrHangSanXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog d = new OpenFileDialog();
            //d.Title = "Select file";
            //d.FileName = textBox1.Text;
            //d.Filter = "Excel Sheet (*.xls)|*.xls|All Files(*.*)|*.*";
            //d.FilterIndex = 1;
            //d.RestoreDirectory= true;
            //if(d.ShowDialog()== DialogResult.OK)
            //{

            //    textBox1.Text = d.FileName;

            //}    

            //OpenFileDialog op = new OpenFileDialog();
            //op.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            //if(op.ShowDialog()==DialogResult.OK)
            //{
            //    string filepath = op.FileName;
            //    string con = @"provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            //    con = string.Format(con, filepath, "yes");
            //    OleDbConnection exceconnection = new OleDbConnection(con);
            //    exceconnection.Open();
            //    DataTable dtexcel = exceconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            //    string excelsheet = dtexcel.Rows[0]["DUOC_KC_HANGSANXUAT"].ToString();
            //    OleDbCommand cm = new OleDbCommand("Select * From ["+excelsheet+"]",exceconnection);
            //    OleDbDataAdapter oda = new OleDbDataAdapter(cm);
            //    DataTable dt = new DataTable();
            //    oda.Fill(dt);
            //    exceconnection.Close();
            //    dgrHangSanXuat.DataSource = dt;

















        }








        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (OleDbConnection myConnect = new OleDbConnection(string.Format(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0;", openFileDialog1.FileName)))
                    {

                        DataTable dt = new DataTable();
                        OleDbCommand cmd = new OleDbCommand(@"SELECT * FROM [tri$]", myConnect);
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        adapter.Fill(dt);
                        dgrNhaCungCap.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDataTimKiem();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgrNhaCungCap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgrNhaCungCap["cXoa", e.RowIndex] == dgrNhaCungCap.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn xóa " + dgrNhaCungCap.CurrentRow.Cells["cMaNhaCungCap"].Value.ToString() + " này không ?"))
                {
                    
                    
                    msql = "DELETE FROM [dbo].[tabMANGUOIBAN] WHERE MANGUOIBAN='"+ dgrNhaCungCap.Rows[e.RowIndex].Cells["cMaNhaCungCap"].Value.ToString() + "'";
                    DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
                

                    ev.QFrmThongBao("Bạn đã xóa thông tin nhà cung cấp thành công");
                    LoadData();
                }
            }
            else if(dgrNhaCungCap["cSua", e.RowIndex] == dgrNhaCungCap.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn sửa " + dgrNhaCungCap.CurrentRow.Cells["cMaNhaCungCap"].Value.ToString() + " này không ?"))
                {
                    string maNhaCungCap = dgrNhaCungCap.CurrentRow.Cells["cMaNhaCungCap"].Value.ToString();

                    // Pass the data to the constructor of FrmThemSuaNhaCungCap
                    FrmThemSuaNhaCungCap f = new FrmThemSuaNhaCungCap(maNhaCungCap);

                    f.ShowDialog();
                }

            }    
        }

        private void dgrNhaCungCap_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgrNhaCungCap["cXoa", e.RowIndex] == dgrNhaCungCap.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn xóa " + dgrNhaCungCap.CurrentRow.Cells["cMaNhaCungCap"].Value.ToString() + " này không ?"))
                {


                    msql = "DELETE FROM [dbo].[tabMANGUOIBAN] WHERE MANGUOIBAN='" + dgrNhaCungCap.Rows[e.RowIndex].Cells["cMaNhaCungCap"].Value.ToString() + "'";
                    DataTable tb = comm.GetDataTable(mconnectstring, msql, "");


                    ev.QFrmThongBao("Bạn đã xóa thông tin nhà cung cấp thành công");
                    LoadData();
                }
            }
            else if (dgrNhaCungCap["cSua", e.RowIndex] == dgrNhaCungCap.CurrentCell)
            {
                if (ev.QFrmThongBao_YesNo("Bạn có muốn sửa " + dgrNhaCungCap.CurrentRow.Cells["cMaNhaCungCap"].Value.ToString() + " này không ?"))
                {
                    string maNhaCungCap = dgrNhaCungCap.CurrentRow.Cells["cMaNhaCungCap"].Value.ToString();

                    // Pass the data to the constructor of FrmThemSuaNhaCungCap
                    FrmThemSuaNhaCungCap f = new FrmThemSuaNhaCungCap(maNhaCungCap);

                    f.ShowDialog();
                }

            }
        }
    }
}