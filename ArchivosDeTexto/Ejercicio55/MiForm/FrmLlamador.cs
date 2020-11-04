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
    public partial class FrmLlamador : Form
    {
        private Centralita c;
        private Random r;

        public FrmLlamador(Centralita c)
        {
            InitializeComponent();

            this.c = c;

            r = new Random();

            // Carga 
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));

        }

        public Centralita GetCentralita
        {
            get
            {
                return this.c;
            }
        }

        private void btnSalir_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void ConcatenarResultado(Button boton)
        {
            if (this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = "";
            }

            if (this.txtNroDestino.Text.Length < 11)
            {
                this.txtNroDestino.Text += boton.Text;
            }

            if (this.txtNroDestino.Text.Length == 1 && this.txtNroDestino.Text != "#")
            {
                this.cmbFranja.Enabled = false;
            }
        }

        private void btnUno_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnUno);
        }

        private void btnDos_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnDos);
        }

        private void btnTres_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnTres);
        }

        private void btnCuatro_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnCuatro);
        }

        private void btnCinco_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnCinco);
        }

        private void btnSeis_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnSeis);
        }

        private void btnSiete_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnSiete);
        }

        private void btnOcho_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnOcho);
        }

        private void btnNueve_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnNueve);
        }

        private void btnAst_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnAsterico);
        }

        private void btnCero_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnCero);
        }

        private void btnNum_OnClick(object sender, EventArgs e)
        {
            this.ConcatenarResultado(btnNumeral);
        }

        private void btnLimpiar_OnClick(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
            this.cmbFranja.Text = "Franja";
            this.cmbFranja.Enabled = true;
        }

        private void btnLlamar_OnClick(object sender, EventArgs e)
        {
            if(this.txtNroDestino.Text != "Nro Destino" && this.txtNroOrigen.Text != "Nro Origen" && this.txtNroDestino.Text.Length > 7
               && this.txtNroOrigen.Text.Length > 7 && (this.cmbFranja.Text != "Franja" || this.cmbFranja.Enabled == false))
            {
                float d = r.Next(1, 50);

                if(d <= 49)
                {
                    d += (float)r.NextDouble();
                }

                //Provincial
                if(this.cmbFranja.Enabled == true)
                {
                    Provincial.Franja franjas; Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

                    Provincial p = new Provincial(txtNroOrigen.Text, franjas, d, txtNroDestino.Text);

                    try
                    {
                        this.c += p;
                    }
                    catch (CentralitaException ex)
                    {
                        MessageBox.Show(ex.Message + "Ya se encuentra cargada");
                    }
                }
                else //Local
                {
                    float c = r.Next(0, 5);

                    if (c <= 4)
                    {
                        c += (float)r.NextDouble();
                    }

                    Local l = new Local(txtNroOrigen.Text, d, txtNroDestino.Text, c);

                    try
                    {
                        this.c += l;
                    }
                    catch (CentralitaException ex)
                    {
                        MessageBox.Show(ex.Message + "Ya se encuentra cargada");
                    }
                }
            }
        }
    }
}
