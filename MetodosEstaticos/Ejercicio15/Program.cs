using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca5;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            char resp = ' ';
            float num1 = 0;
            float num2 = 0;
            double resultado = 0;

            do
            {
                Console.Clear();
                num1 = 0;
                num2 = 0;
                resultado = 0;
                resp = ' ';

                Console.WriteLine(" ****** INICIO ******");
                Console.Write("        Ingrese el primer numero: ");
                float.TryParse(Console.ReadLine(), out num1);

                Console.WriteLine();
                Console.Write("        Ingrese la operacion (+,-,*,/): ");
                char.TryParse(Console.ReadLine(), out opcion);

                Console.WriteLine();
                Console.Write("        Ingrese el segundo numero: ");
                float.TryParse(Console.ReadLine(), out num2);

                resultado = Calculadora.Calcular(num1, num2, opcion);

                if(resultado == -999999 && opcion == '/')
                {
                    Console.WriteLine(" No se puede dividir 0");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write(" Respuesta: {0} {1} {2} = {3}", num1, opcion, num2, resultado);
                }

                /*  while(resp == ' ')
                  {
                      Console.Write("        Ingrese el segundo numero: ");
                      float.TryParse(Console.ReadLine(), out num2);

                      if (opcion == '/' && !Calculadora.Validar(num2))
                      {
                          Console.Write(" NO SE PUEDE DIVIDIR POR 0");
                      }
                      else
                      {
                          resp = 'a';
                      }

                  } */

                //resultado = Calculadora.Calcular(num1, num2, opcion);

                Console.Write(" ¿Desea Continuar? (S/N): ");
                char.TryParse(Console.ReadLine(), out resp);

                if(resp != 'S' || resp != 's')
                {
                    Console.WriteLine(" ¡NOS VEMOS PRONTO!");
                }

            } while (Calculadora.ValidarS_N(resp));

            Console.ReadKey();
        }
    }
}
