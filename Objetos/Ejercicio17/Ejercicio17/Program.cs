using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boligrafos;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo bol;
            Boligrafo bol2;

            string dib;
            short tinta;

            bol = new Boligrafo(ConsoleColor.Blue, Boligrafo.cantidadTintaMaxima);
            bol2 = new Boligrafo(ConsoleColor.Red, 50);

            Console.ForegroundColor = bol.GetColor();
            tinta = bol.GetTinta();
            Console.Write(" Tinta inicial en el boligrafo azul: {0}", tinta);
            Console.WriteLine();

            if(bol.Pintar(30, out dib))
            {
                Console.WriteLine(" Se logro pintar");
                Console.WriteLine(dib);

                tinta = bol.GetTinta();
                Console.Write(" Tinta luego de pintar: {0}", tinta);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(dib);
            }
            
            
            bol.Recargar();

            tinta = bol.GetTinta();
            Console.Write(" Tinta luego de recargar: {0}", tinta);
            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = bol2.GetColor();
            tinta = bol2.GetTinta();
            Console.Write(" Tinta inicial en el boligrafo rojo: {0}", tinta);
            Console.WriteLine();

            if (bol2.Pintar(200, out dib))
            {
                Console.WriteLine(" Se logro pintar");
                Console.WriteLine(dib);

                tinta = bol2.GetTinta();
                Console.Write(" Tinta luego de pintar: {0}", tinta);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(dib);
            }


            if(bol2.Pintar(200, out dib))
            {
                Console.WriteLine(" Se logro pintar");
                Console.WriteLine(dib);
            }
            else
            {
                Console.WriteLine(dib);
            }

            bol2.Recargar();

            tinta = bol2.GetTinta();
            Console.Write(" Tinta luego de recargar: {0}", tinta);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
