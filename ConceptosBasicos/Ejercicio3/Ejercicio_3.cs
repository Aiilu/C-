using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola. 
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/

namespace Ejercicio3
{
    class Ejercicio_3
    {
        static void Main(string[] args)
        {
            string read;
            int num;
            bool primo;

            Console.Title = "Ejercicio Nro 3";

            Console.Write("Ingrese un numero: ");
            read = Console.ReadLine();
            int.TryParse(read, out num);

            Console.WriteLine();

            //traigo todos los numeros entre el 2 y el numero ingresado
            for (int i = 2; i <= num; i++) 
            {
                primo = true;

                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0 && j != i)
                    {
                        primo = false;
                        break;
                    }
                }

                if(primo)
                {
                   Console.Write("El numero {0:#,###.00} es primo", i);
                   Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
