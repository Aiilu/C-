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
    public partial class MorsitaF : Form
    {
        public MorsitaF()
        {
            InitializeComponent();
        }

        private void Click_Nombre(object sender, EventArgs e)
        {
            string nombre = this.Escribirtxt.Text;

            if(Validar(nombre))
            {
                nombre = nombre.Trim();
                string mensaje = $"{nombre} te amo";
                Mensaje holas = new Mensaje(mensaje);
                holas.Show();

                MessageBox.Show($" Hola {nombre}!", "Saludar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = MessageBox.Show($" Desea continuar?", "Atenti", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(result == DialogResult.No)
                {
                    this.Close();
                }
            }

            
        }

        private bool Validar(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show($" Ingrese nombre correcto", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
