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
using ControlCantina;

namespace FrmCantina
{
    public partial class MiCantina : Form
    {
        public MiCantina()
        {
            InitializeComponent();
        }

        private void MiCantina_Load(object sender, EventArgs e)
        {
            this.barra.SetCantina = Cantina.GetCantina(10); //guarda la instancia de cantina en la barra
            this.cbTipoBotella.DataSource = Enum.GetValues(typeof(Botella.Tipo)); //Trae los enumerados
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella botella;

            if (rbCerveza.Checked)
            {
                Botella.Tipo tipo;
                Enum.TryParse<Botella.Tipo>(this.cbTipoBotella.SelectedValue.ToString(), out tipo);

                botella = new Cerveza((int)this.nudCapacidad.Value, this.txtMarca.Text, tipo, (int)this.nupContenido.Value);

                this.barra.AgregarBotella(botella);

                MessageBox.Show(botella.ToString(), "CERVEZA");
            }
            else
            {
                if(this.cbTipoBotella.Text == "Plastico")
                {
                    botella = new Agua((int)this.nudCapacidad.Value, this.txtMarca.Text, (int)this.nupContenido.Value);

                    this.barra.AgregarBotella(botella);

                    MessageBox.Show(botella.ToString(), "AGUA");
                }
                else
                {
                    MessageBox.Show(" No tenemos agua en envase de vidrio");
                }
            }
        }
    }
}
