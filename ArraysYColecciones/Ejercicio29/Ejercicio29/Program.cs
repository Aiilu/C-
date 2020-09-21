using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jug1 = new Jugador(1234, "Leo", 25, 7);
            Jugador jug2 = new Jugador(2344, "Ailen");
            Jugador jug3 = new Jugador(2344, "Jejeje");

            Equipo equipo = new Equipo(3, "Los Kapos");
            Equipo equipo2 = new Equipo(1, "Solitario");

            if(equipo + jug1)
            {
                Console.WriteLine(jug1.MostrarDatos());
            }

            if (equipo + jug2)
            {
                Console.WriteLine(jug2.MostrarDatos());
            }

            if (equipo + jug3)
            {
                Console.WriteLine(jug3.MostrarDatos());
            }

            if (equipo2 + jug1)
            {
                Console.WriteLine(jug1.MostrarDatos());
            }

            if (equipo2 + jug2)
            {
                Console.WriteLine(jug2.MostrarDatos());
            }

            Console.ReadKey();
        }
    }
}
