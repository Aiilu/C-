using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador a = new Sumador(1); //para usar
            Sumador b = new Sumador();

            long suma1 = a.Sumar(10, 20);
            string suma2 = b.Sumar("a", "l");

            int res = (int)a;
            long suma3 = a + b;

            if (a | b)
            {
                Console.WriteLine(" Son iguales");
            }
            else
            {
                Console.WriteLine(" No son iguales");
            }

            Console.WriteLine(" La suma es: {0}", suma1);
            Console.WriteLine(" El string es: {0}", suma2);
            Console.WriteLine(" Func. explicita: {0}", res);
            Console.WriteLine(" operador +: {0}", suma3);

            Console.ReadKey();
        }
    }
}
