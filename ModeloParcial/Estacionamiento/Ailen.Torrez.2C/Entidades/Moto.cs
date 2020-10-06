using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto :Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private int valorHora;

        public Moto(string patente, int cilindrada) :this(patente,cilindrada,2)
        {
        }

        public Moto(string patente, int cilindrada, short ruedas) :this(patente, cilindrada, ruedas, 30)
        {
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora) :base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.ToString());
            datos.AppendLine($" Cilindradra: {this.cilindrada}");
            datos.AppendLine($" Ruedas: {this.ruedas}");

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
            if(obj.GetType() == this.GetType())
            {
                return true;
            }

            return false;
        }
    }
}
