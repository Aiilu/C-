using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repaso;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto("111", "hola", 20);
            Producto p2 = new Producto("123", "hola", 20);

            Console.WriteLine(Producto.MostrarProducto(p1));
            Console.WriteLine(Producto.MostrarProducto(p2));
            Console.WriteLine(p1 != p2);
            Console.WriteLine(p1 == "hola");
            Console.ReadKey();
        }
    }
}
