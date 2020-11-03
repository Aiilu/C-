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
            Console.WriteLine("Ingrese un numero:");
            Console.WriteLine("1) guardarlo en el escritorio");
            Console.WriteLine("Otro para guardarlo por default");

            string path = null;

            if (Console.ReadLine() == "1")
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + DateTime.Now.ToString("yyyyMMdd-HHmm") + ".txt";
            }
            else
            {
                path = DateTime.Now.ToString("yyyyMMdd-HHmm") + ".txt";
            }

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
                    ArchivoTexto.Guardar(path, excep.Message);
                    excep = excep.InnerException;
                }
            }

            try
            {
                ArchivoTexto.Leer(path);
            }
            catch (FileNotFoundException ex)
            {
                ArchivoTexto.Guardar(path, ex.ToString());
            }

            Console.WriteLine(ArchivoTexto.Leer(path));

            Console.ReadKey();
        }
    }
}
