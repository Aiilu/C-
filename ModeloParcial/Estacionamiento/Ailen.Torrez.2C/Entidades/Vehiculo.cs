using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;
      
        public Vehiculo(string patente)
        { 
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(value.Length == 6)
                {
                    this.patente = value;
                }else
                {
                    this.patente = null;
                }
            }
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat(" Patente: {0}", this.Patente);

            return datos.ToString();
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(this.ToString()); //Poner el ToString es lo mismo que no ponerlo, no?
            datos.AppendLine($" Ingreso: Fecha y Hora {this.ingreso}");

            return datos.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.patente == v2.patente && v1.Equals(v2);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
