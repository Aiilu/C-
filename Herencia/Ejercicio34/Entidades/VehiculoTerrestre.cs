using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        public enum Colores { Rojo, Blanco, Azul, Gris, Negro }

        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        public VehiculoTerrestre(short ruedas, short puertas, Colores color)
        {
            this.cantidadRuedas = ruedas;
            this.cantidadPuertas = puertas;
            this.color = color;
        }

        public short GetRuedas
        {
            get
            {
                return this.cantidadRuedas;
            }
        }

        public short GetPuertas
        {
            get
            {
                return this.cantidadPuertas;
            }
        }

        public Colores GetColor
        {
            get
            {
                return this.color;
            }
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Cantidad Ruedas: {this.GetRuedas}");
            datos.AppendLine($" Cantidad Puertas: {this.GetPuertas}");
            datos.AppendLine($" Color: {this.GetColor}");

            return datos.ToString();
        }
    }
}
