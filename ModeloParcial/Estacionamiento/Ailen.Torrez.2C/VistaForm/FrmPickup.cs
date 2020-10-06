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
    public partial class FrmPickup : Form
    {
        public FrmPickup()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
                PickUp p = new PickUp(txtPatentee.Text, txtModelo.Text);
                MessageBox.Show(p.ConsultarDatos());
                MessageBox.Show(p.ImprimirTicket());
        }

        private void txtPatente_OnLeave(object sender, EventArgs e)
        {
            if (txtPatentee.TextLength != 6)
            {
                txtPatentee.Focus();
                btnCrear.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(txtModelo.Text))
            {
                btnCrear.Enabled = true;
            }
          
        }

        private void txtModelo_OnLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                txtModelo.Focus();
                btnCrear.Enabled = false;
            }
            else if (txtPatentee.TextLength == 6)
            {
                btnCrear.Enabled = true;
            }
        }
    }
}
