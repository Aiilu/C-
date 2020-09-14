using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumnos;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alum1;
            Alumno alum2;
            Alumno alum3;

            alum1 = new Alumno("Ailen", "Torrez", 1235);
            alum2 = new Alumno("Leonardo", "Magnaghi", 6756);
            alum3 = new Alumno("Juan", "Carlos", 3908);

            alum1.Estudiar(7,8);
            alum2.Estudiar(9,10);
            alum3.Estudiar(6,5);

            alum1.CalcularFinal();
            alum2.CalcularFinal();
            alum3.CalcularFinal();

            Console.Write(alum1.Mostrar());
            Console.WriteLine();
            Console.Write(alum2.Mostrar());
            Console.WriteLine();
            Console.Write(alum3.Mostrar());

            Console.ReadKey();
        }
    }
}
