using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 aut1 = new AutoF1(3, "Hola");
            AutoF1 aut2 = new AutoF1(5, "Puto");
            AutoF1 aut3 = new AutoF1(9, "Ajoi Ajoi");

            Competencia comp = new Competencia(4, 2);

            Console.WriteLine("Agrego 3 autos");

            if(comp + aut1)
            {
                Console.WriteLine(aut1.MostrarDatos());
            }

            if (comp + aut2)
            {
                Console.WriteLine(aut2.MostrarDatos());
            }

            if (comp + aut3)
            {
                Console.WriteLine(aut3.MostrarDatos());
            }

            Console.WriteLine(comp.MostrarDatos());

            Console.WriteLine("Elimino un auto");

            if(comp - aut1)
            {
                Console.WriteLine("Se elimino con exito");
            }

            Console.Write("Agrego el auto que no entro");

            if(comp + aut3)
            {
                Console.WriteLine(comp.MostrarDatos());
            }

            Console.ReadKey();
        }
    }
}
