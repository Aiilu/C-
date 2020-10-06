using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TEST
{
    class Test
    {
        static void Main(string[] args)
        {
            Cantina cantina;
            Cerveza c1 = new Cerveza(1000, "Honey", 500);
            Cerveza c2 = new Cerveza(2000, "IPA", Botella.Tipo.Plastico, 2050);
            Agua a = new Agua(500, "Los Andes", 350);
            Agua a2 = new Agua(500, "Los Andes", 350);

            cantina = Cantina.GetCantina(3);

            if(cantina + c1)
            {
                c1.ServirMedida();
                Console.WriteLine(c1.ToString());
            }

            Console.WriteLine();

            if (cantina + c2)
            {
                c2.ServirMedida();
                Console.WriteLine(c2.ToString());
            }

            Console.WriteLine();

            if (cantina + a)
            {
                a.ServirMedida(67);
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine();

            if (cantina + a2)
            {
                a2.ServirMedida();
                Console.WriteLine(a2.ToString());
            }

            Console.ReadKey();
        }
    }
}
