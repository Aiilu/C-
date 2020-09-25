using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3}
        protected Franja franjaHorario;

        public Provincial(Franja miFranja, Llamada llamada) :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHorario = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : this(miFranja, new Llamada(duracion, destino, origen))
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
            //retorna el valor de la llamada a partir de la duracion y el costo.
            //Los valores seran: Franja_1 : 0.99
            //Los valores seran: Franja_2 : 1.25
            //Los valores seran: Franja_3 : 0.66

            float costo = 0;

            switch(franjaHorario)
            {
                case Franja.Franja_1:
                    costo = base.Duracion * (float)0.99;
                  break;
                case Franja.Franja_2:
                    costo = base.Duracion * (float)1.25;
                  break;
                case Franja.Franja_3:
                    costo = base.Duracion * (float)0.66;
                  break;
            }

            return costo;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.Mostrar());
            datos.AppendLine($" Costo de la Llamada: {this.CostoLlamada}");
            datos.AppendLine($" Franja Horaria: {this.franjaHorario}");

            return datos.ToString();
        }
    }
}
