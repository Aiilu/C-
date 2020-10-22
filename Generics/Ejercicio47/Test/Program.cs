using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> tFutbol = new Torneo<EquipoFutbol>("Aloha");
            Torneo<EquipoBasquet> tBasquet = new Torneo<EquipoBasquet>("No Aloha");

            EquipoFutbol eFutbol1 = new EquipoFutbol("Puto", new DateTime(2020, 05, 20));
            EquipoFutbol eFutbol2 = new EquipoFutbol("Putin", new DateTime(2015, 12, 01));
            EquipoFutbol eFutbol3 = new EquipoFutbol("Mas puto", new DateTime(1900, 06, 29));

            EquipoBasquet eBasquet1 = new EquipoBasquet("Puto", new DateTime(2020, 05, 20));
            EquipoBasquet eBasquet2 = new EquipoBasquet("Putin", new DateTime(2015, 12, 01));
            EquipoBasquet eBasquet3 = new EquipoBasquet("Mas puto", new DateTime(1900, 06, 29));

            if(tFutbol + eFutbol1 == false)
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (tFutbol + eFutbol2 == false)
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (tFutbol + eFutbol3 == false)
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (tBasquet + eBasquet1 == false)
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (tBasquet + eBasquet2 == false)
            {
                Console.WriteLine("No se pudo agregar");
            }

            if (tBasquet + eBasquet3 == false)
            {
                Console.WriteLine("No se pudo agregar");
            }

            Console.WriteLine(" Funcion mostrar del torneo de futbol");
            Console.WriteLine(tFutbol.Mostrar(tFutbol));

            Console.WriteLine(" Funcion mostrar del torneo basquet");
            Console.WriteLine(tBasquet.Mostrar(tBasquet));

            Console.WriteLine(" Resultados Futbol:");
            Console.WriteLine(tFutbol.CalcularPartido(eFutbol1, eFutbol2));

            Console.WriteLine(" Resultados Basquet:");
            Console.WriteLine(tBasquet.CalcularPartido(eBasquet1, eBasquet2));

            Console.ReadKey();
        }
    }
}
