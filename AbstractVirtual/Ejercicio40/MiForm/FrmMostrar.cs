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

        public FrmMostrar(Centralita c, Llamada.TipoLlamada tipo)
        {
            InitializeComponent();

            this.ObtTipo = tipo;
            this.MostrarResultados(c);
        }

        public Llamada.TipoLlamada ObtTipo
        {
            set
            {
                this.tipo = value;
            }
        }

        private void MostrarResultados(Centralita c)
        {
            StringBuilder datos = new StringBuilder();

            if(this.tipo == Llamada.TipoLlamada.Provincial)
            {
                datos.AppendLine($" Ganancia por Provincial: {c.GananciasPorProvincial}"); 

                foreach(Llamada l in c.Llamadas)
                {
                    if (l is Provincial)
                    {
                        datos.AppendLine($"{l}");
                    }
                }
            }
            else if(this.tipo == Llamada.TipoLlamada.Local)
            {
                datos.AppendLine($" Ganancia por Local: {c.GananciasPorLocal}");

                foreach (Llamada l in c.Llamadas)
                {
                    if(l is Local)
                    {
                        datos.AppendLine($"{l}");
                    }
                }
            }
            else
            {
                datos.AppendLine($"{c}");
            }

            this.rtb.Text = datos.ToString();
        }
    }
}
