using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            List<Figura> figura = new List<Figura>();

            int contador = 0;

            figura.Add(new Rectangulo(5, 7));
            figura.Add(new Circulo(6));
            figura.Add(new Cuadrado(8));

            foreach(Figura f in figura)
            {
                contador++;
                Console.WriteLine(" ============ FIGURA {0} ============", contador);
                Console.WriteLine(" Tipo: {0}", f.GetType());
                Console.WriteLine(f.Dibujar());
                Console.WriteLine(" Area: {0}", f.CalcularSuperficie());
                Console.WriteLine(" Perimetro: {0}", f.CalcularPerimetro());
                Console.WriteLine(" ====================================");
            }

            Console.ReadKey();

            /*
             * a) La clase cuadrado no esta obligada a implementar el metodo DIBUJAR ya que hereda de Rectangulo,
             * la cual ya implemento el metodo DIBUJAR. Las otras clases si estan obligadas ya que heredan de Figura
             * quien tiene el metodo abstracto.
             * b) La clase cuadrado no esta obligada a implementar Calcular Superficie y las demas si justamente
             * por lo anterior.
             * c) Los objetos del tipo Cuadrado al llamar a la implementacion Calcular Perimetro, llaman a la
             * implementacion de su base, osea, rectangulo.
            */
        }
    }
}
