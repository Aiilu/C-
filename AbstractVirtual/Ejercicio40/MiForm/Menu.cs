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
        public Centralita c = new Centralita();

        public Menu()
        {
            InitializeComponent();
        }
    }
}
