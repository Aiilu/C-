using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio73
{
    public class Test
    {
        static void Main(string[] args)
        {
            string hola = "hola, como andas?";
            int cant;
            hola.CantidadDeSignos(out cant);
            Console.WriteLine(cant);

            Console.ReadKey();

        }
    }
}
