using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class UnaExcepcion :Exception
    {
        public UnaExcepcion() :base()
        {
        }

        public UnaExcepcion(string mensaje) :base(mensaje)
        {
        }

        public UnaExcepcion(string mensaje, Exception innerException) :base(mensaje, innerException)
        {
        }
    }
}
