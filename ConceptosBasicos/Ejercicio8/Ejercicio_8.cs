using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes 
 * de N empleados de una fábrica.
 * Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la 
 * cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $ 150, y al total de 
 * todas esas operaciones restarle el 13% en concepto de descuentos. Mostrar el recibo correspondiente con el nombre, 
 * la antigüedad, el valor hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los 
 * empleados ingresados. Nota: Utilizar estructuras repetitivas y selectivas.
*/

namespace Ejercicio8
{
    class Ejercicio_8
    {
        static void Main(string[] args)
        {
            char respuesta;
            float valorHora;
            string nombre;
            int antig;
            int horas;
            float total;
            float descuento;

            Console.Title = "Ejercicio Nro 8"; 

            do
            {
                Console.Write(" Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine();

                Console.Write(" Ingrese la cantidad de horas trabajadas: ");
                int.TryParse(Console.ReadLine(), out horas);
                Console.WriteLine();

                Console.Write(" Ingrese el valor x hora: ");
                float.TryParse(Console.ReadLine(), out valorHora);
                Console.WriteLine();

                Console.Write(" Ingrese años de antiguedad: ");
                int.TryParse(Console.ReadLine(), out antig);

                Console.WriteLine(" ¿Desea seguir ingresando empleados?");
                Console.Write(" Ingrese 'S' o 'N': ");
                char.TryParse(Console.ReadLine(), out respuesta);

                total = (valorHora * horas) + (antig * 150);

                descuento = (total * 13) / 100;

                Console.WriteLine();
                Console.WriteLine(" ****** RECIBO DEL EMPLEADO ******");
                Console.WriteLine("        Nombre: {0}", nombre);
                Console.WriteLine("        Antiguedad: {0}", antig);
                Console.WriteLine("        Valor por hora: {0}", valorHora);
                Console.WriteLine("        Total Bruto: {0}", total);
                Console.WriteLine("        Total Descuentos: {0}", descuento);
                Console.WriteLine("        Total Neto: {0}", total - descuento);
            }
            while (respuesta == 'S' || respuesta == 's');

            Console.ReadKey();
        }
    }
}
