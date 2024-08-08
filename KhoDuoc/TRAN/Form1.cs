using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WaitFormFunc waitForm = new WaitFormFunc();
        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                waitForm.Show(this);
                Thread.Sleep(5000);
                Form3 frm = new Form3();
                frm.Show();
                waitForm.Close();
            }
            catch { }
        }
    }
}
