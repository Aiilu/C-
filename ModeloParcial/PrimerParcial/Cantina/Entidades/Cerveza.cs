using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza :Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML) :this(capacidadML, marca, Tipo.Vidrio, contenidoML)
        {

        }

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) :base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        public override int ServirMedida()
        {
            int aux = 0;

            int nuevaMedida = (Cerveza.MEDIDA * 80) / 100;

            if (nuevaMedida <= base.Contenido)
            {
                aux = (base.Contenido - nuevaMedida);
            }
            else
            {
                aux = base.Contenido;
                base.Contenido = 0;
            }

            return aux;
        }

        protected override string GenerarInforme()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.GenerarInforme());
            datos.AppendLine($" Tipo de botella: {this.tipo}");

            return datos.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            if(cerveza.tipo == Tipo.Plastico)
            {
                return Tipo.Plastico;
            }

            return Tipo.Vidrio;
        }
    }
}
