using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            AutoF1 aut1 = new AutoF1(3, "Hola", 10);
            AutoF1 aut3 = new AutoF1(9, "Ajoi Ajoi", 3);

            Competencia<AutoF1> comp = new Competencia<AutoF1>(4, 3, Competencia<AutoF1>.TipoCompetencia.F1);

            Console.WriteLine("Agrego 3 autos");

            if (comp + aut1)
            {
                Console.WriteLine(aut1.MostrarDatos());
            }

            if (comp + aut1)
            {
                Console.WriteLine(aut1.MostrarDatos());
            }

            if (comp + aut3)
            {
                Console.WriteLine(aut3.MostrarDatos());
            }

            Console.ReadKey();
        }
    }
}
