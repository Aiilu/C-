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

        }
    }
}
