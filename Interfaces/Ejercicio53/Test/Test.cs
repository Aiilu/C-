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
            Boligrafo miBoligrafo  = new Boligrafo(1, ConsoleColor.Green);
            Boligrafo miBoligrafo1 = new Boligrafo(1, ConsoleColor.Green);
            Boligrafo miBoligrafo2 = new Boligrafo(0, ConsoleColor.Green);
            Boligrafo miBoligrafo3 = new Boligrafo(3, ConsoleColor.Green);
            Lapiz miLapiz          = new Lapiz(10);
            Lapiz miLapiz2         = new Lapiz(0);

            Cartuchera1 uno = new Cartuchera1();
            Cartuchera2 dos = new Cartuchera2();

            uno = miLapiz2 + uno;
            uno = miBoligrafo + uno;
            uno = miBoligrafo3 + uno;

            Console.WriteLine(uno.ProbarElementos());
            Console.WriteLine(miBoligrafo.UnidadesDeEscritura);

            dos = miBoligrafo2 + dos;
            dos = miBoligrafo3 + dos;
            dos = miBoligrafo1 + dos;
            dos = miLapiz + dos;
            dos = miLapiz2 + dos;

            Console.WriteLine(dos.ProbarElementos());
            Console.WriteLine(miBoligrafo1.UnidadesDeEscritura);
            Console.ReadKey();
        }
    }
}
