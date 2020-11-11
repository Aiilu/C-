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

namespace FormPersona
{
    public partial class FormPersona : Form
    {
        private int idSeleccionado;
        private int idSeleccionado2;

        public FormPersona()
        {
            InitializeComponent();
        }

        private void btnLeer_OnClick(object sender, EventArgs e)
        {
            List<Persona> listPersonas = new List<Persona>();

            PersonaDAO personaDAO = new PersonaDAO();

            listPersonas = personaDAO.LeerPersonas();

            foreach(Persona p in listPersonas)
            {
                //this.lstPersonas.Items.Add((p.ID, p.Nombre, p.Apellido).ToString());
                this.lstPersonas.Items.Add(p);
            }
        }

        private void btnGuardar_OnClick(object sender, EventArgs e)
        {
            PersonaDAO personaDAO = new PersonaDAO();

            personaDAO.GuardarPersona(new Persona(this.txtNombre.Text, this.txtApellido.Text));
        }

        private void btnlstPersona_onDoubleClick(object sender, EventArgs e)
        {
            this.txtNombre.Text = ((Persona)this.lstPersonas.SelectedItem).Nombre;
            this.txtApellido.Text = ((Persona)this.lstPersonas.SelectedItem).Apellido;
            this.idSeleccionado = ((Persona)this.lstPersonas.SelectedItem).ID;
        }

        private void btnEliminar_OnClick(object sender, EventArgs e)
        {
            PersonaDAO personaDAO = new PersonaDAO();

            personaDAO.EliminarPersona(this.idSeleccionado2);

            this.lstPersonas.Items.Clear();
        }

        private void btnModificar_OnClick(object sender, EventArgs e)
        {
            PersonaDAO personaDAO = new PersonaDAO();

            personaDAO.ModificarPersona(new Persona(this.idSeleccionado, this.txtNombre.Text, this.txtApellido.Text));

            this.lstPersonas.Items.Clear();
        }

        private void btnlstPersona_OnClick(object sender, EventArgs e)
        {
            this.idSeleccionado2 = ((Persona)this.lstPersonas.SelectedItem).ID;
        }
    }
}
