using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca4
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double n1)
        {
            double area = 0;

            area = Math.Pow(n1, 2);

            return area;
        }

        public static double CalcularTriangulo(double n1, double n2)
        {
            double area = 0;

            area = (n1 * n2) / 2;

            return area;
        }

        public static double CalcularCirculo(double n1)
        {
            double area = 0;

            area = (Math.Pow(n1, 2)) * (Math.PI);

            return area;
        }

        public static bool ValidarS_N(char c)
        {
            if (c == 'S' || c == 's')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
