using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio f = new Negocio("Falabella");
            Negocio g = new Negocio("Globo");

            Cliente c1 = new Cliente(1, "Ailen");
            Cliente c2 = new Cliente(2, "Leonardo");
            Cliente c3 = new Cliente(4, "Silvia");
            Cliente c4 = new Cliente(5, "Ximena");

            f.Cliente = c1;
            f.Cliente = c2;
            f.Cliente = c3;
            f.Cliente = c4;
            f.Cliente = c3;

            Console.Write($" Clientes que faltan por atender: {f.ClientesPendientes}");
            Console.WriteLine();

            string nombre;
            
            while(f.ClientesPendientes > 0)
            {
                nombre = f.ProximoCliente;

                if (~f)
                {
                    Console.WriteLine($" Cliente atendido: {nombre}");
                }
            }

            Console.WriteLine(" No hay mas clientes");

            Console.ReadKey();
        }
    }
}
