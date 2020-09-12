using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            int num;
            float suma = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            Console.Title = "Ejercicio 11";

            Console.WriteLine(" A continuacion se le pedira que ingrese 10 numeros.");
            Console.Clear();

            for(int i = 0; i < 10; i++)
            {
                Console.Write(" Ingrese un numero entre -100 y 100: ");
                int.TryParse(Console.ReadLine(), out num);

                while(!Validacion.Validar(num,-100,100))
                {
                    Console.WriteLine();
                    Console.Write(" ERROR. Ingrese un numero dentro del rango: ");
                    int.TryParse(Console.ReadLine(), out num);
                }

                if (num> max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }

                suma = (suma + num);
            }

            Console.WriteLine();
            Console.Write("El Nª Maximo es: {0:#,###.00}", max);
            Console.WriteLine();
            Console.Write("El Nª Minimo es: {0:#,###.00}", min);
            Console.WriteLine();
            Console.Write("El Promedio es: {0:#,###.00}", suma / 10);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
