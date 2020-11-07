using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            try
            {
                //Producto prod1 = new Producto(4, "A126", "Fanta", 30.45f, null);
                //Producto prod1 = new Producto(3, "A125", "Sprite", 56.00f, "Soy riquisima");

                ProductosDAO prodDao = new ProductosDAO();

                //prodDao.InsertarProductos(prod1);
                //prodDao.ModificarProductos(prod1);
                //prodDao.EliminarProducto(1);

                List<Producto> productos = prodDao.ListarProductos();
                Producto producto = prodDao.ListarProductosPorID(3);

                foreach(Producto p in productos)
                {
                    Console.WriteLine($"Producto ID {p.ID} de nombre {p.Nombre}");
                }

                Console.WriteLine("----------------------------");
                Console.WriteLine(" BUSQUEDA POR ID");

                if(producto != null)
                {
                    Console.WriteLine($"Producto ID {producto.ID} de nombre {producto.Nombre}");
                }              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
