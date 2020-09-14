using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5
{
    public partial class Mensaje : Form
    {
        public Mensaje(string mensaje)
        {
            InitializeComponent();

            this.LabelPru.Text = mensaje; 
            //this.LabelPru.Text = string.Empty; //inicializamos la variable para que quede vacia
        }
    }
}
