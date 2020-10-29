using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ailen.Torrez._2C
{
    class Test
    {
        static void Main(string[] args)
        {
            Bar bar = Bar.GetBar();

            Empleado e1 = new Empleado("Ailen", 30);
            Empleado e3 = new Empleado("Ailen", 30);
            Empleado e2 = new Empleado("Leonardo", 22, 1234);

            Gente g1 = new Gente(19);
            Gente g2 = new Gente(23);
            g2.Nombre = "Leonardo";
            Gente g3 = new Gente(17);
            g3.Nombre = "Ailen";
            Gente g4 = new Gente(90);
            Gente g5 = new Gente(23);
            Gente g6 = new Gente(24);

            if (bar + e1)
            {
                Console.WriteLine("Todo gud");
                Console.WriteLine(bar.ToString());
            }
            else
            {
                Console.WriteLine(" Todo mal");
            }

            if(bar + e2)
            {
                Console.WriteLine("Todo gud");
                Console.WriteLine(bar.ToString());
            }
            else
            {
                Console.WriteLine(" Todo mal");
            }

            if (bar + e3)
            {
                Console.WriteLine("Todo gud");
                Console.WriteLine(bar.ToString());
            }
            else
            {
                Console.WriteLine(" Todo mal");
            }

            if (bar + g1)
            {
                Console.WriteLine("Todo gud");
                Console.WriteLine(bar.ToString());
            }
            else
            {
                Console.WriteLine(" Todo mal");
            }

            if (bar + g2)
            {
                Console.WriteLine("Todo gud {0}", g2.Nombre);
                Console.WriteLine(bar.ToString());
            }
            else
            {
                Console.WriteLine(" Todo mal {0}", g2.Nombre);
            }

            if (bar + g3)
            {
                Console.WriteLine("Todo gud {0}", g3.Nombre);
                Console.WriteLine(bar.ToString());
            }
            else
            {
                Console.WriteLine(" Todo mal {0}", g3.Nombre);
            }

            if (bar + g4)
            {
                Console.WriteLine("Todo gud");
                Console.WriteLine(bar.ToString());
            }
            else
            {
                Console.WriteLine(" Todo mal");
            }

            if (bar + g5)
            {
                Console.WriteLine("Todo gud");
                Console.WriteLine(bar.ToString());
            }
            else
            {
                Console.WriteLine(" Todo mal");
            }

            if (bar + g6)
            {
                Console.WriteLine("Todo gud");
                Console.WriteLine(bar.ToString());
            }
            else
            {
                Console.WriteLine(" Todo mal");
            }

            Console.ReadKey();
        }
    }
}
