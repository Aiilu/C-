using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class Alumno :Persona
    {
        public Alumno(string nombre) :base(nombre)
        {

        }

        public override string QuienSoy()
        {
            return "Un Alumno";
        }

        public override int DeciUnNumero
        {
            get
            {
                return 10;
            }
        }
    }
}
