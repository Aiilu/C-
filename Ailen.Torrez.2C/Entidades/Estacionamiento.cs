using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) :this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Nombre: {e.nombre}");
            datos.AppendLine($" Espacio disponible: {e.espacioDisponible}");

            foreach(Vehiculo v in e.vehiculos)
            {
                datos.AppendLine(v.ToString());
            }

            return datos.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            foreach(Vehiculo vh in e.vehiculos)
            {
                if(vh == v)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if(e.espacioDisponible > e.vehiculos.Count)
            {
                if(e != v && !string.IsNullOrWhiteSpace(v.Patente))
                {
                    e.vehiculos.Add(v);
                }
            }

            return e;
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            if(e == v)
            {
                e.vehiculos.Remove(v);
                return v.ImprimirTicket();
            }

            return "El vehiculo no es parte del estacionamiento";
        }
    }
}
