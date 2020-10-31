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
                Console.WriteLine("hoola5");
            }
            catch(DivideByZeroException)
            {
                throw;
            }
            Console.WriteLine("hoola6");
        }

        public MiClase(int i)
        {
            try
            {
                new MiClase();
                Console.WriteLine("hoola3");
            }
            catch(DivideByZeroException ex)
            {
                throw new UnaExcepcion("Constructor", ex);
            }
            Console.WriteLine("hoola4");
        }


        public static void MetodEstat()
        {
            throw new DivideByZeroException("Metodo Estatico");
            Console.WriteLine("hoola7");
        }
    }
}
