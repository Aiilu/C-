using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Conversor
{
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double cotizEuro;

            if(double.TryParse(txtCotizacionEuro.Text, out cotizEuro))
            {
                if(cotizEuro > 0)
                {
                    Euro.SetCotizacion(cotizEuro);
                    return;
                }
            }

            txtCotizacionEuro.Focus();
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double cotizDolar;

            if (double.TryParse(txtCotizacionDolar.Text, out cotizDolar))
            {
                if (cotizDolar > 0)
                {
                    Dolar.SetCotizacion(cotizDolar);
                    return;
                }
            }

            txtCotizacionDolar.Focus();
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double cotizPeso;

            if (double.TryParse(txtCotizacionPeso.Text, out cotizPeso))
            {
                if (cotizPeso > 0)
                {
                    Pesos.SetCotizacion(cotizPeso);
                    return;
                }
            }

            txtCotizacionPeso.Focus();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if(btnLockCotizacion.ImageIndex == 0)
            {
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPeso.Enabled = false;

                btnLockCotizacion.ImageIndex = 1;
            }
            else
            {
                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPeso.Enabled = true;

                btnLockCotizacion.ImageIndex = 0;
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double cantEuro;

            if(double.TryParse(txtEuro.Text, out cantEuro))
            {
                if(cantEuro > 0)
                {
                    Euro moneda = new Euro(cantEuro);

                    txtEuroAEuro.Text = moneda.GetCantidad().ToString();
                    txtEuroADolar.Text = ((Dolar)moneda).GetCantidad().ToString();
                    txtEuroAPeso.Text = ((Pesos)moneda).GetCantidad().ToString();
                }
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double cantDolar;

            if (double.TryParse(txtDolar.Text, out cantDolar))
            {
                if (cantDolar > 0)
                {
                    Dolar moneda = new Dolar(cantDolar);

                    txtDolarAEuro.Text = ((Euro)moneda).GetCantidad().ToString();
                    txtDolarADolar.Text = moneda.GetCantidad().ToString();
                    txtDolarAPeso.Text = ((Pesos)moneda).GetCantidad().ToString();
                }
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double cantPeso;

            if (double.TryParse(txtPeso.Text, out cantPeso))
            {
                if (cantPeso > 0)
                {
                    Pesos moneda = new Pesos(cantPeso);

                    txtPesoAEuro.Text = ((Euro)moneda).GetCantidad().ToString();
                    txtPesoADolar.Text = ((Dolar)moneda).GetCantidad().ToString();
                    txtPesoAPeso.Text = moneda.GetCantidad().ToString();
                }
            }
        }
    }
}
