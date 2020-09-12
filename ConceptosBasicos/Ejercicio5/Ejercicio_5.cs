using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, 
 * cuyas sumas son iguales. El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: 
 * (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa 
 * la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595. Se pide elaborar una 
 * aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola. 
 * Nota: Utilizar estructuras repetitivas y selectivas.
*/

namespace Ejercicio5
{
    class Ejercicio_5
    {
        static void Main(string[] args)
        {
            int num;
            string read;
            int acumJ = 0;
            int acumK = 0;

            Console.Title = "Ejercicio Nro 5";

            Console.Write(" Ingrese un numero: ");
            read = Console.ReadLine();
            int.TryParse(read, out num);

            Console.WriteLine();
            Console.Write(" Verificando centros numericos entre el 1 y el {0}", num);
            Console.WriteLine();
            Console.ReadKey();

            for(int i = 1; i <= num; i++)  // condicion se ejecuta mientras sea verdadera, hace tal cosa hasta que pase esto
            {
                acumJ = 0;
                acumK = 0;

               for(int j = 1; j < i; j++)  // j = i - 1; j > 0; j--    
               {
                    acumJ += j;
               }


               for(int k = i+1; acumK < acumJ; k++)
               {
                    acumK += k;
               }

               if(acumJ == acumK && acumJ > 0)
               {
                    Console.Write(" {0:#,###.00} es un Centro Numerico", i);
                    Console.WriteLine();
               }
            }

            Console.ReadKey();
        }
    }
}