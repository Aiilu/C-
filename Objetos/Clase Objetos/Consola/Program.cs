using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Consola
{
    class Program
    {
       static void Main(string[] args)
        {
            Mascota masc;
            Mascota masc2;
            Mascota masc3;
            Mascota masc4;

            string nomb;
            DateTime fN;
            string esp;

            Console.Write(" Ingresar nombre: ");
            nomb = Console.ReadLine();

            Console.Write(" Ingresar fecha (dd/MM/aaaa): ");
            DateTime.TryParse(Console.ReadLine(), out fN);

            Console.Write(" Ingresar especie: ");
            esp = Console.ReadLine();

            masc = new Mascota(nomb, fN, esp);
            masc2 = new Mascota("Wendy", new DateTime(2018, 03, 01), "Perro");
            masc3 = new Mascota("Dalila", new DateTime(2015, 03, 15), "Gato");
            masc4 = new Mascota("Rosalia", new DateTime(2000, 06, 20), "Pez");

            Console.Write(" La edad es: {0} años", masc.CalcularEdad());
            Console.WriteLine();

            Console.Write(masc.MostrarDatos());

            Console.ReadKey();
        }
    }
}
