using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();

            Negocio negocio = new Negocio(caja1, caja2);

            ThreadStart start1 = new ThreadStart(negocio.AsignarCaja);
            Thread thread1 = new Thread(start1);

            negocio.Clientes.Add("Ailen");
            negocio.Clientes.Add("Leonardo");
            negocio.Clientes.Add("Mirta");

            ThreadStart start2 = new ThreadStart(caja1.AtenderCLientes);
            Thread thread2 = new Thread(start2);
            thread2.Name = "Caja 1";

            ThreadStart start3 = new ThreadStart(caja2.AtenderCLientes);
            Thread thread3 = new Thread(start3);
            thread3.Name = "Caja 2";

            thread1.Start();

            thread1.Join();

            thread2.Start();
            thread3.Start();

            /*Console.ReadKey();

            if (thread1.IsAlive)
            {
                thread1.Abort();
            }

            if (thread2.IsAlive)
            {
                thread2.Abort();
            }

            if (thread3.IsAlive)
            {
                thread3.Abort();
            }*/

            Console.ReadKey();
        }
    }
}
