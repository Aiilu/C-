using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ej33
{
   class Program
    {
        static void Main(string[] args)
        {
            Libros libro = new Libros();

            libro[0] = "Bebita";
            libro[1] = " Te amo";

            Console.WriteLine(libro[0] + libro[1] + libro[5]);

            libro[1] = "Sos el amor de mi vida";

            Console.WriteLine(libro[1]);

            Console.ReadKey();
        }
    }
}
