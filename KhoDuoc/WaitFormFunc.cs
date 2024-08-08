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

namespace KhoDuoc
{
    public class WaitFormFunc
    {
        FrmTieuDe wait;
        Thread loadthread;

        public void Show()
        {
            loadthread = new Thread(new ThreadStart(LoadingProcess));
            loadthread.Start();
        }

        public void Show(Form parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadthread.Start(parent);
        }

        public void Close()
        {
            if (wait != null)
            {
                wait.BeginInvoke(new System.Threading.ThreadStart(wait.CloseWait));
                wait = null;
                loadthread = null;
            }
        }

        private void LoadingProcess()
        {
            wait = new FrmTieuDe();
            wait.ShowDialog();
        }

        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new FrmTieuDe(parent1);
            wait.ShowDialog();
        }
    }
}
