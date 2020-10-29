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
            Contabilidad<Documento, Recibo> cont = new Contabilidad<Documento, Recibo>();

            Recibo recibo = new Recibo(20);
            Factura factura = new Factura(1);
            Documento documento = new Recibo();

            cont += recibo;
            cont += documento;
            cont += factura;

            Console.WriteLine(cont.ToString());

            Console.ReadKey();
        }
    }
}
