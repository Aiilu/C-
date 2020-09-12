using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca5
{
    public class Calculadora
    {
        public static float Calcular(float n1, float n2, char op)
        {
            float resultado = 0;

            switch(op)
            {
                case '+':
                    resultado = (n1 + n2);
                    break;
                case '-':
                    resultado = (n1 - n2);
                    break;
                case '*':
                    resultado = (n1 * n2);
                    break;
                case '/':
                    if(Validar(n2))
                    {
                       resultado = (n1 / n2);
                    }
                    else
                    {
                        resultado = -999999;
                    }
                    break;
            }
            return resultado;
        }

        private static bool Validar(float n2)
        {
            if(n2 !=0)
            {
                return true;
            }
            else 
            {
                return false;
            }
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
