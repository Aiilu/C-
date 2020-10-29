using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente :Persona
    {
        public Gente(short edad) : base(null, edad)
        {

        }

        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(" GENTE");
            datos.AppendLine(" -----");

            datos.AppendLine(base.Mostrar());

            return datos.ToString();
        }

        public override bool Validar()
        {
            if(base.Edad > 18)
            {
                return true;
            }

            return false;
        }
    }
}
