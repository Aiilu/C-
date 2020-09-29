using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiForm
{
    public partial class FrmMostrar : Form
    {
        private Llamada.TipoLlamada tipo;
        private Centralita c;
        private Provincial p;
        private Local l;

        public FrmMostrar(Centralita c)
        {
            InitializeComponent();

            this.c = c;

            this.MostrarResultados();
        }

        public Llamada.TipoLlamada ObtTipo
        {
            set
            {
                this.tipo = value;
            }
        }

        private void MostrarResultados()
        {
            if(this.tipo == Llamada.TipoLlamada.Provincial)
            {
                this.rtb.Text = this.p.ToString();
            }
            else if(this.tipo == Llamada.TipoLlamada.Local)
            {
                this.rtb.Text = this.l.ToString();
            }
            else
            {
                this.rtb.Text = this.c.ToString();
            }
        }
    }
}
