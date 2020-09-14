using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace Ejercicio18
{
    class PruebaGeometria
    {
        static void Main(string[] args)
        {
            Punto primPunt = new Punto(3, 16);
            Punto segPunt = new Punto(20, 8);

            Punto mostPunt1 = new Punto(2, 16);
            Punto mostPunt2 = new Punto(20, 4);

            Rectangulo nuevRect = new Rectangulo(primPunt, segPunt);
            Rectangulo mostRect = new Rectangulo(mostPunt1, mostPunt2);

            Console.Write(" El area es: {0}", nuevRect.GetArea());
            Console.WriteLine();
            Console.Write(" El perimetro es: {0}", nuevRect.GetPerimetro());
            Console.WriteLine();

            Console.Write(mostRect.DevolRectang(mostRect));

            Console.ReadKey();
        }
    }
}
