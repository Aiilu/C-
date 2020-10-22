using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase a = new OtraClase();
                a.OtraClaseInstancia();
            }
            catch(MiExcepcion ex)
            {
                Exception excep = ex; //Puede contener todas las excepciones

                while(excep != null)
                {
                    Console.WriteLine(excep.Message);
                    excep = excep.InnerException;
                }
            }

            Console.ReadKey();
        }
    }
}
