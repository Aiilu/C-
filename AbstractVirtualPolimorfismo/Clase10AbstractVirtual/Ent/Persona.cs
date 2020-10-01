using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public abstract class Persona
    {
        protected string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract string QuienSoy();

        public abstract int DeciUnNumero { get; }

        public virtual string SoyVirtualDeQuien();
    }
}
