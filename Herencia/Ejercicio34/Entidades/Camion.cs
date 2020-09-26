using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion :VehiculoTerrestre
    {
        protected short cantidadMarchas;
        protected int pesoCarga;
 
        public Camion(short ruedas, short puertas, Colores color, short marchas, short carga) 
            :base(ruedas,puertas,color)
        {
            this.cantidadMarchas = marchas;
            this.pesoCarga = carga;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.Mostrar());
            datos.AppendLine($" Cantidad Marchas: {this.cantidadMarchas}");
            datos.AppendLine($" Peso Carga: {this.pesoCarga}");

            return datos.ToString();
        }
    }
}
