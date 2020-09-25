using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local :Llamada
    {
        protected float coast;

        public Local(Llamada llamada, float costo) :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.coast = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : this(new Llamada(duracion, destino, origen),costo)
        {
            
        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.coast;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.Mostrar());
            datos.AppendLine($" Costo de la Llamada: {this.CostoLlamada}");

            return datos.ToString();
        }
    }

 
}
