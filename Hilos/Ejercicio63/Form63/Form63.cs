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

namespace Form63
{
    public partial class Form63 : Form
    {
        public Form63()
        {
            InitializeComponent();

            ThreadStart threadStart = new ThreadStart(this.MostrarHora);
            Thread thread = new Thread(threadStart);

            thread.Start();
        }

        delegate void CallBack();

        public void AsignarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                CallBack c = new CallBack(this.AsignarHora);

                this.Invoke(c);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString("dd/M/yyyy HH:mm:ss");
            }
        }

        public void MostrarHora()
        {
            while(true)
            {
                this.AsignarHora();
                Thread.Sleep(1000);
            }
        }

    }
}
