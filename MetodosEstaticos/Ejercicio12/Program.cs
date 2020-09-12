using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca2;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int suma = 0;
            char resp = ' ';

            do
            {
                Console.WriteLine(" Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out num);

                suma += num;

                Console.WriteLine(" ¿Continuar? (S/N): ");
                char.TryParse(Console.ReadLine(), out resp);

            }while(ValidarRespuesta.ValidarS_N(resp));

            Console.WriteLine(" La suma de los numeros ingresados es: {0}", suma);

            Console.ReadKey();
        }
    }
}
