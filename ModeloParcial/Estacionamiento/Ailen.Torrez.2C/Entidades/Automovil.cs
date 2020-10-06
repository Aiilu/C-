using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil :Vehiculo
    {
        private ConsoleColor color;
        private int valorHora;
        
        public Automovil(string patente, ConsoleColor color) : this(patente, color, 50)
        {
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) :base(patente)
        {
            this.color = color;
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.ToString());
            datos.AppendLine($" Color del Automovil: {this.color}");

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
