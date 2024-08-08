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

    public partial class FrmTieuDe : Form
   

    {
               SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=KHODUOC;Integrated Security=True");
    private string mconnectstring = "server=.;database = KHODUOC ; uid=sa;pwd=123";
    private clsCommonMethod comm = new clsCommonMethod();
    private clsEventArgs ev = new clsEventArgs("");
    private string msql;
    public string a;

        string Quyen = "";
        public FrmTieuDe()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            label3.BackColor = Color.Transparent;
            btnTiepTuc.KeyPress += btnTiepTuc_KeyPress;

        }


        public FrmTieuDe(string Quyen)
        {
            InitializeComponent();
            this.Quyen = Quyen;
            //Load();


        }


        public FrmTieuDe(Form parent)
        {
           
        }

        public void CloseWait()
        {


            this.DialogResult = DialogResult.OK;
            this.Close();
            if(label1.Image!=null)
            {
                label1.Image.Dispose();

            }


        }
        private void FrmTieuDe_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btnTiepTuc.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTongHop f = new FrmTongHop();
            this.Hide();

            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)

            {
                progressBar1.Value += 10;
                label3.Text = progressBar1.Value.ToString() + "%";
                if(progressBar1.Value==100)
                {
                    btnTiepTuc.Visible = true;

                }    

            }
            else
            {
                timer1.Stop();


            }    
        }

        private void btnTiepTuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ev.Qtxt_KeyPress_To_Button_Focus(sender, e, btnTiepTuc);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnTiepTuc_Enter(object sender, EventArgs e)
        {
            ev.Qtxt_Enter(sender, e);
        }

        private void btnTiepTuc_Leave(object sender, EventArgs e)
        {
            ev.Qtxt_Leave(sender, e);
        }
    }
}
