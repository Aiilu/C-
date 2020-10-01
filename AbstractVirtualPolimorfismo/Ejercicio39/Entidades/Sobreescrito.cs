using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito(string miAt)
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            if(obj.GetType() == this.GetType())
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
