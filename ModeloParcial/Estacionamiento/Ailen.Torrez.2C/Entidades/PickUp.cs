using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private int valorHora;

        public PickUp(string patente, string modelo) :this(patente, modelo, 70)
        {

        }

        public PickUp(string patente, string modelo, int valorHora) :base(patente)
        {
            this.modelo = modelo;
            this.valorHora = valorHora;
        }
        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.ToString());
            datos.AppendLine($" Modelo: {this.modelo}");

            return datos.ToString();
        }

        public override string ImprimirTicket()
        {
            float costoEstadia = 0;

            costoEstadia = (DateTime.Now.Subtract(base.ingreso).Hours) * this.valorHora;

            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.ImprimirTicket());
            datos.AppendLine($" Costo de la estadia: {costoEstadia}");

            return datos.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                return true;
            }

            return false;
        }
    }
}
