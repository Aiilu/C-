using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class MiClase
    {

        public MiClase()
        {
            try
            {
                MiClase.MetodEstat();
            }
            catch(DivideByZeroException)
            {
                throw;
            }
        }

        public MiClase(int i)
        {
            try
            {
                new MiClase();
            }
            catch(DivideByZeroException ex)
            {
                throw new UnaExcepcion("Constructor", ex);
            }
        }


        public static void MetodEstat()
        {
            throw new DivideByZeroException("Metodo Estatico");
        }
    }
}
