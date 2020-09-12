using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ingresar 5 números por consola, guardándolos en una variable escalar. 
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
*/

namespace Ejercicio1
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            int numRead = 5;
            string read;
            int aux;
            float suma = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            Console.Title = "Ejercicio Nro 1";

            for (int i = 0; i < numRead; i++)
            {
                Console.Write("Ingrese un numero: ");
                read = Console.ReadLine();

                if(int.TryParse(read, out aux))
                {
                    if (aux > max)
                    {
                        max = aux;
                    }
                    if (aux < min)
                    {
                        min = aux;
                    }

                    suma = (suma + aux);
                }
                else
                {
                    Console.Write("Ingrese un numero valido. ");
                    i--;
                }

            }

            Console.Write("El Nª Maximo es: {0:#,###.00}", max);
            Console.WriteLine();
            Console.Write("El Nª Minimo es: {0:#,###.00}", min);
            Console.WriteLine();
            Console.Write("El Promedio es: {0:#,###.00}", suma / numRead);
            Console.ReadKey();

        }
    }
}
