using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Clase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal buho = new Animal(5,"Buho","Puto");
            Animal morsita = new Animal(20,"Morsita","Ailuu");

            //tipo de datos, operador y tipo de dato
            if(buho == "Puto")
            {
                if(!(morsita != "Ailuu"))
                {
                    Console.WriteLine(" El buho es puto y mi amor es una amorcita");

                    if(5 == 3)
                    {
                        Console.WriteLine(" hola");
                    }
                    else if(morsita == 20)
                    {
                        Console.WriteLine("  Morsita tiene 20");
                    }
                }
            }

            DateTime hoy = new DateTime(2020, 09, 08);

            Console.ReadKey();
        }
    }
}
