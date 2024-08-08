using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBSQLHelper;

namespace KhoDuoc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SQLHelper.DATABASE = "KHODUOC";
            SQLHelper.USERNAME_DB = "sa";
            SQLHelper.PASSWORD_DB = "123";
            SQLHelper.SERVER_NAME = "(local)";
            SQLHelper.ConnectString();




            //Application.Run(new FrmThemSuaThuocGoc());
            //Application.Run(new FrmPhieuYeuCauLinhThuocVatTu());
            //Application.Run(new FrmTaoPhieuYeuCauLinhThuocOQuayThuoc());
            //Application.Run(new FrmBaoCaoXuatNhapTon());
            //Application.Run(new FrmBaoCaoThongKeNhapThuoc1());
            //Application.Run(new FrmXuatThuoc());
            //Application.Run(new FrmPhieuYeuCauLinhThuocVatTu());
            //Application.Run(new FrmDanhMucThuoc());
            //Application.Run(new FrmTongHop());
            //Application.Run(new FrmPhieuYeuCauLinhThuocVatTu());
            //Application.Run(new FrmNhapThuoc());
            Application.Run(new FrmDangNhap());

        }
    }
}