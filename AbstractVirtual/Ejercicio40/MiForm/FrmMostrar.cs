using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiForm
{
    public partial class FrmMostrar : Form
    {
        private Centralita c;

        public FrmMostrar(Centralita c)
        {
            InitializeComponent();

            this.c = c;
        }
    }
}
