using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4. 
 * Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
 * Por ejemplo: el año 2000 es bisiesto pero 1900 no.
 * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango. 
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/

namespace Ejercicio6
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
            int añoI;
            int añoF;

            Console.Title = "Ejercio Nro 6";

            Console.Write(" Ingrese año de Inicio: ");
            int.TryParse(Console.ReadLine(), out añoI);

            Console.Write(" Ingrese año de Fin: ");
            int.TryParse(Console.ReadLine(), out añoF);

            for (int i = añoI; i <= añoF; i++)
            {
                if ((i % 4) == 0 && ((i % 100) != 0 || (i % 400) == 0))
                {
                    Console.WriteLine();
                    Console.Write("El año {0} es bisiesto.", i);
                }
            }

            Console.ReadKey();
        }
    }
}
