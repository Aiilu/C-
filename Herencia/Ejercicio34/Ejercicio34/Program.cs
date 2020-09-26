using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto m = new Moto(2, 0, VehiculoTerrestre.Colores.Azul, 35);
            Automovil a = new Automovil(4, 2, VehiculoTerrestre.Colores.Negro, 45, 5);
            Camion c = new Camion(6, 4, VehiculoTerrestre.Colores.Rojo, 78, 67);

            Console.Write(m.Mostrar());
            Console.WriteLine();
            Console.Write(a.Mostrar());
            Console.WriteLine();
            Console.Write(c.Mostrar());

            Console.ReadKey();
        }
    }
}
