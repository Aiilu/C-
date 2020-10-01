using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace MiForm
{
    public partial class Menu : Form
    {
        private Centralita c;

        public Menu()
        {
            InitializeComponent();
            c = new Centralita();
        }

        private void btnGenerarLlamada_OnClick(object sender, EventArgs e)
        {
            FrmLlamador ll = new FrmLlamador(c);

            ll.ShowDialog();

            this.c.OrdenarLlamadas();

        }

        private void btnMenuSalir_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFactTotal_OnClick(object sender, EventArgs e)
        {
            FrmMostrar m = new FrmMostrar(c, Llamada.TipoLlamada.Todas);

            m.ShowDialog();
        }

        private void btnFactLoc_OnClick(object sender, EventArgs e)
        {
            FrmMostrar m = new FrmMostrar(c, Llamada.TipoLlamada.Local);

            m.ShowDialog();
        }

        private void btnFactProv_OnClick(object sender, EventArgs e)
        {
            FrmMostrar m = new FrmMostrar(c, Llamada.TipoLlamada.Provincial);
            
            m.ShowDialog(); 
        }
    }
}
