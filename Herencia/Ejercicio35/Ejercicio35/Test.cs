using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio35
{
    class Test
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3, "Los Kapos");
            Equipo equipo2 = new Equipo(1, "Solitario");

            Jugador jug1 = new Jugador(1234, "Leo", 25, 7);
            Jugador jug2 = new Jugador(2344, "Ailen");
            Jugador jug3 = new Jugador(2344, "Jejeje");

            DirectorTecnico tec = new DirectorTecnico("Fulanito", new DateTime(2020,09,25));
            DirectorTecnico tec2 = new DirectorTecnico("Fulanito", new DateTime(2020, 09, 25));

            if(tec == tec2)
            {
                Console.WriteLine(" Los directores tecnicos son iguales.");
                Console.WriteLine("Director Uno: ");
                Console.WriteLine(tec.MostrarDatos());
                Console.WriteLine();
                Console.WriteLine("Director Dos: ");
                Console.WriteLine(tec2.MostrarDatos());
            }
            else
            {
                Console.WriteLine(" Son distintos");
            }

            if (equipo + jug1)
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
