using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil :VehiculoTerrestre
    {
        protected short cantidadMarchas;
        protected int cantidadPasajeros;

        public Automovil(short ruedas, short puertas, Colores color, short marchas, int pasajeros)
            : base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.cantidadPasajeros = pasajeros;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.Mostrar());
            datos.AppendLine($" Cantidad Marchas: {this.cantidadMarchas}");
            datos.AppendLine($" Cantidad de Pasajeros: {this.cantidadPasajeros}");

            return datos.ToString();
        }
    }
}
