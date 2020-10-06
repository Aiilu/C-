using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsola
{
    public class Test
    {
        static void Main(string[] args)
        {
            Jardin jardin = new Jardin(20);

            Arbusto arbusto = new Arbusto("Pepito", 5);
            Banano b1 = new Banano("Leo", 7, "12345");
            Banano b2 = new Banano("Ailen", 6, "34567");
            Rosal r1 = new Rosal("Pepita", 10, Rosal.Color.Azul);

            if(jardin + arbusto)
            {
                Console.WriteLine(jardin.ToString());
            }
            else
            {
                Console.WriteLine(" No hay mas espacio");
            }

            if (jardin + b1)
            {
                Console.WriteLine(jardin.ToString());
            }
            else
            {
                Console.WriteLine(" No hay mas espacio");
            }

            if (jardin + b2)
            {
                Console.WriteLine(jardin.ToString());
            }
            else
            {
                Console.WriteLine(" No hay mas espacio");
            }

            if (jardin + r1)
            {
                Console.WriteLine(jardin.ToString());
            }
            else
            {
                Console.WriteLine(" No hay mas espacio");
            }

            Console.ReadKey();
        }
    }
}
