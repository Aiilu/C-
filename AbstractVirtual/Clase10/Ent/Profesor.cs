using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class Profesor :Persona
    {
        public Profesor(string nombre) :base(nombre)
        {

        }

        public override string QuienSoy()
        {
            return "Soy un profesor";  
        }

        public override int DeciUnNumero
        {
            get
            {
                return 20;
            }
        }
    }
}
