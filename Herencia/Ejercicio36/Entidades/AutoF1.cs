using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 :VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) :base(numero, escuderia)
        {
        
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) :this(numero, escuderia)
        {
            this.CaballosFuerza = caballosDeFuerza;
        }

        public short CaballosFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        public static bool operator ==(AutoF1 f1, AutoF1 f2)
        {       
            return ((VehiculoDeCarrera)f1 == (VehiculoDeCarrera)f2) && (f1.CaballosFuerza == f2.CaballosFuerza);
        }

        public static bool operator !=(AutoF1 f1, AutoF1 f2)
        {
            return !(f1 == f2);
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.MostrarDatos());
            datos.AppendLine($" Caballos de Fuerza: {this.CaballosFuerza}");
            
            return datos.ToString();
        }
    }
}
