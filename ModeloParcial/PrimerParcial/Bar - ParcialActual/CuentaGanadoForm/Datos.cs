using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaGanadoForm
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Dni
        {
            get
            {
                return this.txtDni.Text;
            }
        }

        public string Nombre
        {
            get
            {
                return this.txtNombre.Text;
            }
        }

        public string Edad
        {
            get
            {
                return this.txtEdad.Text;
            }
        }
    }
}
