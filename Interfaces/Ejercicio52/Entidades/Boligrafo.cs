using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo :IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }

        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }

        }

        public EscrituraWrapper Escribir(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                this.UnidadesDeEscritura -= 0.3f;
            }

            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            for(int i=0; i<unidades; i++)
            {
                this.UnidadesDeEscritura += 1;
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(" Hola, soy un Boligrafo");
            datos.AppendLine($" Color: {this.Color}");
            datos.AppendLine($" Nivel de Tinta: {this.UnidadesDeEscritura}");

            return datos.ToString();
        }
    }
}
