using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent;

namespace Clase10
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Alumno("Juan");
            Persona p2 = new Profesor("Maria");
            Persona p3 = new Alumno("Mariano");
            Persona p4 = new Profesor("Mariana");

            Console.WriteLine(p1.QuienSoy() + "" + p1.DeciUnNumero);
            Console.WriteLine(p2.QuienSoy() + "" + p2.DeciUnNumero);
            Console.WriteLine(p3.QuienSoy() + "" + p3.DeciUnNumero);
            Console.WriteLine(p4.QuienSoy() + "" + p4.DeciUnNumero);

            Console.ReadKey();
        }
    }
}
