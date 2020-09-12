using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) 
 * que son divisores del número. El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. 
 * Escribir una aplicación que encuentre los 4 primeros números perfectos. Nota: Utilizar estructuras repetitivas y 
 * selectivas.
*/

namespace Ejercicio4
{
    class Ejercicio_4
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";

            int numPerfect = 0;
            int suma = 0;

            //traigo todos los numeros entre el 2 y el numero ingresado
            for (int i = 1; numPerfect <= 4 ; i++)
            {
                suma = 0;

                for (int j = 1; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        suma += j;
                    }
                }

                if (suma == i)
                {
                    numPerfect++;
                    Console.Write("El numero {0:#,###.00} es perfecto", i);
                    Console.WriteLine();
                }
            }

            Console.ReadKey();

        }
    }
}
