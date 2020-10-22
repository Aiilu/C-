using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void OtraClaseInstancia()
        {     
            try
            {
                new MiClase(1);
            }
            catch(UnaExcepcion ex)
            {
                throw new MiExcepcion("Otra clase", ex);
            }
        }
    }
}
