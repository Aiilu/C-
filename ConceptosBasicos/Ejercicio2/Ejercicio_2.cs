using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
 * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!". 
 * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
*/

namespace Ejercicio2
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            string read;
            int num;
            double cuad;
            double cubo;
            double aux;

            Console.Title = "Ejercicio Nro 2";

            Console.Write("Ingrese un numero: ");
            read = Console.ReadLine();
            int.TryParse(read, out num);

            while(num <= 0)
            {
                Console.Write("ERROR. ¡Reingresar numero!: ");
                read = Console.ReadLine();
                int.TryParse(read, out num);
            }

            aux = num;
            
            cuad = Math.Pow(aux, 2);

            cubo = Math.Pow(aux, 3);

            Console.Write("El Cuadrado es: {0:#,###.00}", cuad);
            Console.WriteLine();
            Console.Write("El Cubo es: {0:#,###.00}", cubo);

            Console.ReadKey();
        }
    }
}
