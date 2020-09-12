using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y 
 * calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema con DateTime.Now). 
 * Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
*/
namespace Ejercicio7
{
    class Ejercicio_7
    {
        static void Main(string[] args)
        {
            int fecha;
            DateTime fechaAct;
            int dia;
            int mes;
            int año;

            Console.Title = "Ejercicio Nro 7";

            fechaAct = DateTime.Today;

            Console.Write(" Ingrese el dia: ");
            int.TryParse(Console.ReadLine(), out dia);

            Console.Write(" Ingrese el mes: ");
            int.TryParse(Console.ReadLine(), out mes);

            Console.Write(" Ingrese el año: ");
            int.TryParse(Console.ReadLine(), out año);



            Console.ReadKey();
        }
    }
}
