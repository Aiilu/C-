using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class MiForm : Form
    {
        DirectorTecnico director;

        public MiForm()
        {
            InitializeComponent();
        }

        private void btnCrear_OnClick(object sender, EventArgs e)
        {
            director = new DirectorTecnico(this.txtNombre.Text, this.txtApellido.Text, (int)this.nudEdad.Value, (int)this.nupDni.Value, (int)this.nupExperiencia.Value);

            MessageBox.Show(" Se ha creado el DT!");
            MessageBox.Show(director.Mostrar());
        }

        private void btnValidar_OnClick(object sender, EventArgs e)
        {
            if(object.ReferenceEquals(this.director, null))
            {
                MessageBox.Show(" Aun no se ha creado el DT del formulario");
            }
            else if(this.director.ValidarAptitud())
            {
                MessageBox.Show(" El DT es valido");
            }
            else
            {
                MessageBox.Show(" El DT no es valido");
            }
        }

        private void btnNombre_OnLeave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                this.txtNombre.Focus();
                this.btnCrear.Enabled = false;
            }
            else
            {
                this.btnCrear.Enabled = true;
            }
        }

        private void btnApellido_OnLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                this.txtApellido.Focus();
                this.btnCrear.Enabled = false;
            }
            else
            {
                this.btnCrear.Enabled = true;
            }
        }
    }
}
