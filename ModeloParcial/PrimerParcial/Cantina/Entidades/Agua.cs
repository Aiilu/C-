using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua :Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoML) :base(marca, capacidadML, contenidoML)
        {

        }

        protected override string GenerarInforme()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.GenerarInforme());
            datos.AppendLine($" Tipo de botella: {Botella.Tipo.Plastico}");

            return datos.ToString();
        }

        public override int ServirMedida()
        {
            return this.ServirMedida(Agua.MEDIDA);
        }

        public int ServirMedida(int medida)
        {
            int aux = 0;

            if (medida <= base.Contenido)
            {
                aux = (base.Contenido - medida);
            }
            else
            {
                aux = base.Contenido;
                base.Contenido = 0;
            }

            return aux;
        }
    }
}
