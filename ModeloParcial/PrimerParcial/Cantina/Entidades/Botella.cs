using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public enum Tipo { Plastico, Vidrio}

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.capacidadML = capacidadML;
            this.marca = marca;

            if (capacidadML < contenidoML)
            {
                this.Contenido = capacidadML;
            }
            else
            {
                this.Contenido = contenidoML;
            }
        }

        public int CapacidadLitros
        {
            get
            {
                int aux = this.capacidadML / 1000;

                if(aux > 0)
                {
                    return aux;
                }

                return this.capacidadML;
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                if(value > 0)
                {
                    this.contenidoML = value;
                }
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return (this.Contenido * 100) / this.CapacidadLitros;
            }
        }

        public abstract int ServirMedida();

        protected virtual string GenerarInforme()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Capacidad: {this.CapacidadLitros}");
            datos.AppendLine($" Porcentaje del Contenido: {this.PorcentajeContenido}");
            datos.AppendLine($" Marca: {this.marca}");

            return datos.ToString();
        }

        public override string ToString()
        {
            return this.GenerarInforme();
        }
    }
}
