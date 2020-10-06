using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

        public abstract bool TieneFlores { get; }

        public abstract bool TieneFruto { get; }

        public virtual string ResumenDeDatos()
        {
            string flores = "";
            string frutos = "";

            StringBuilder datos = new StringBuilder();

            datos.AppendFormat(" {0} tiene un tamaño de {1}\n", this.nombre, this.Tamanio);

            if(this.TieneFlores == true)
            {
                flores = "SI";
            }
            else
            {
                flores = "NO";
            }

            if (this.TieneFruto == true)
            {
                frutos = "SI";
            }
            else
            {
                frutos = "NO";
            }

            datos.AppendFormat(" Tiene Flores: {0}\n", flores);
            datos.AppendFormat(" Tiene Frutos: {0}\n", frutos);

            return datos.ToString();
        }
    }
}
