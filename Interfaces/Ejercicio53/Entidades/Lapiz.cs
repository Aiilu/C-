using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }

        }

        ConsoleColor IAcciones.Color 
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(" Hola, soy un Lapiz");
            datos.AppendLine($" Color: {((IAcciones)this).Color}");
            datos.AppendLine($" Nivel de Tinta: {((IAcciones)this).UnidadesDeEscritura}");

            return datos.ToString();
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            for(int i=0; i<texto.Length; i++)
            {
                ((IAcciones)this).UnidadesDeEscritura = 0.1f;
            }

            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}
