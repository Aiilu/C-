using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto :VehiculoTerrestre
    {
        protected short cilindrada;

        public Moto(short ruedas, short puertas, Colores color, short cil)
            : base(ruedas, puertas, color)
        {
            this.cilindrada = cil;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.Mostrar());
            datos.AppendLine($" Cilindrada: {this.cilindrada}");

            return datos.ToString();
        }
    }
}
