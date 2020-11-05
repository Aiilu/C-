using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persona;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESTO ES EN XML");

            PersonaXml p1 = new PersonaXml("Ailen", "Torrez");
            
            Console.WriteLine(p1.ToString());
            PersonaXml.Guardar(p1);

            Console.WriteLine("--------------------------");

            PersonaXml p2 = null;

            p2 = PersonaXml.Leer();
            Console.WriteLine(p2.ToString());

            Console.ReadKey();

            Console.WriteLine("ESTO ES EN BINARIO");

            PersonaBin p3 = new PersonaBin("Leonardo", "Magnaghi");

            Console.WriteLine(p3.ToString());
            PersonaBin.Guardar(p3);

            Console.WriteLine("--------------------------");

            PersonaBin p4 = null;

            p4 = PersonaBin.Leer();
            Console.WriteLine(p4.ToString());

            Console.ReadKey();
        }
    }
}
