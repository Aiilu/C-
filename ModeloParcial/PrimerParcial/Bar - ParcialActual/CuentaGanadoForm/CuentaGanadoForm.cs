using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CuentaGanadoForm
{
    public partial class CuentaGanadoForm : Form
    {
        private Bar bar;
        private Random edadRandom;
        
        public CuentaGanadoForm()
        {
            InitializeComponent();
            this.bar = Bar.GetBar();
            this.edadRandom = new Random();
        }

        private void btnInforme_OnClick(object sender, EventArgs e)
        {
            SalidaDeTest mr = new SalidaDeTest();

            mr.rtbSalidaDeTest.Text = this.bar.ToString();

            mr.ShowDialog();
        }

        private void nudEmpleados_ValueChanged(object sender, EventArgs e)
        {
            if(this.bar.Empleados.Count < this.nudEmpleados.Value)
            {
                short edad;
                short dni;

                Datos datos = new Datos();

                datos.ShowDialog();

                if(!short.TryParse(datos.Edad, out edad))
                {
                    edad = 0;
                }

                if (!short.TryParse(datos.Dni, out dni))
                {
                    dni = -1;
                }

                Empleado emp = new Empleado(datos.Nombre, edad, dni);

                if (!(this.bar + emp))
                {
                    this.nudEmpleados.Value--;
                }
            }
            else if (this.bar.Empleados.Count > this.nudEmpleados.Value)
            {
                this.bar.Empleados.Remove(this.bar.Empleados.Last());
            }
        }

        private void nudGente_ValueChanged(object sender, EventArgs e)
        {
            if(this.bar.Gente.Count < this.nudGente.Value)
            {
                short edad;
                
                Datos datos = new Datos();

                datos.txtDni.Enabled = false;

                datos.ShowDialog();

                if (!short.TryParse(datos.Edad, out edad))
                {
                    edad = 0;
                }

                Gente gen = new Gente(short.Parse(datos.Edad));

                if(!(this.bar + gen))
                {
                    this.nudGente.Value--;
                }
                else if(!string.IsNullOrEmpty(datos.Nombre))
                {
                    gen.Nombre = datos.Nombre;
                }
            }
            else if (this.bar.Gente.Count > this.nudGente.Value)
            {
                this.bar.Gente.Remove(this.bar.Gente.First());
            }
        }
    }
}
