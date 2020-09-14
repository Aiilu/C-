using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesos p = 74.77;
            Dolar d = new Dolar(1,1);
            Euro e = new Euro(0.85);

            Console.Write(d != e); //distinto
            Console.WriteLine("");
            Console.Write((p + e).GetCantidad()); //suma
            Console.WriteLine("");
            Console.Write((d - p).GetCantidad()); //resta    

            Console.ReadKey();
        }
    }
}
