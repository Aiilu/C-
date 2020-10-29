using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> tFutbol = new Torneo<EquipoFutbol>("Pepe");
            Torneo<EquipoBasquet> tBasquet = new Torneo<EquipoBasquet>("No Pepe");

            EquipoFutbol eFutbol1 = new EquipoFutbol("Hola", new DateTime(2000, 06, 20));
            EquipoFutbol eFutbol2 = new EquipoFutbol("Hola", new DateTime(2000, 06, 20));
            EquipoFutbol eFutbol3 = new EquipoFutbol("Chau", new DateTime(2020, 04, 03));
            EquipoFutbol eFutbol4 = new EquipoFutbol("Chau", new DateTime(2021, 04, 03));

            EquipoBasquet eBasquet1 = new EquipoBasquet("Todo Bien", new DateTime(1997, 11, 25));
            EquipoBasquet eBasquet2 = new EquipoBasquet("Todo Mal", new DateTime(2000, 06, 20));

            if(tFutbol + eFutbol1 == false)
            {
                Console.WriteLine(" Puto");
            }

            if (tFutbol + eFutbol2 == false)
            {
                Console.WriteLine(" Puto");
            }

            if (tFutbol + eFutbol3 == false)
            {
                Console.WriteLine(" Puto");
            }

            if (tFutbol + eFutbol4 == false)
            {
                Console.WriteLine(" Puto");
            }

            if (tBasquet + eBasquet1 == false)
            {
                Console.WriteLine(" Puto");
            }

            if (tBasquet + eBasquet2 == false)
            {
                Console.WriteLine(" Puto");
            }

            Console.WriteLine(" Mostrando Torneo de Futbol: ");
            Console.WriteLine(tFutbol.Mostrar());
            Console.WriteLine();

            Console.WriteLine(" Mostrando Torneo de Basquet: ");
            Console.WriteLine(tBasquet.Mostrar());

            Console.WriteLine(" A jugaaaaah: ");
            Console.WriteLine(tFutbol.JugarPartido);
            Console.WriteLine(tBasquet.JugarPartido);

            Console.ReadKey();
        }
    }
}
