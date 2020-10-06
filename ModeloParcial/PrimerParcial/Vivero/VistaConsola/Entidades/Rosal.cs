
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal :Planta
    {
        public enum Color { Roja, Blanca, Amarilla, Rosa, Azul}

        private Color florColor;

        public Rosal(string nombre, int tamanio) :this(nombre, tamanio, Color.Blanca)
        {
        }

        public Rosal(string nombre, int tamanio, Color color) :base(nombre, tamanio)
        {
            this.florColor = color;
        }

        public override bool TieneFlores
        {
            get
            {
                return true;
            }
        }

        public override bool TieneFruto
        {
            get
            {
                return false;
            }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.ResumenDeDatos());
            datos.AppendFormat(" Flores de Color: {0}", this.florColor);

            return datos.ToString();
        }
    }
}
