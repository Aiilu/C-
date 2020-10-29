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

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion,destino,origen)
        {
            this.coast = costo;
        }

        public override float CostoLlamada
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

        public override bool Equals(object obj)
        {
            //Devuelve la clase.
            if(obj.GetType() == this.GetType())
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.Mostrar());
            datos.AppendLine($" Costo de la Llamada: {this.CostoLlamada}");

            return datos.ToString();
        }
    }
}
