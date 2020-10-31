using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
using IO;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            string fecha = DateTime.Now.ToString("yyyyMMdd-HHMM");

            try
            {
                ArchivoTexto.Leer("", fecha);
            }
            catch(FileNotFoundException ex)
            {
                ArchivoTexto.Guardar("", ex.ToString(), fecha);
            }

            Console.WriteLine(ArchivoTexto.Leer("", fecha));

            /*try
            {
                OtraClase a = new OtraClase();
                a.OtraClaseInstancia();
                Console.WriteLine("hoola");
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

            Console.WriteLine("hoola!!!!!!!!!!");*/

            Console.ReadKey();
        }
    }
}
