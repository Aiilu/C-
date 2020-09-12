using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Biblioteca4;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            char resp = ' ';
            int opcion = 0;
            double num1 = 0;
            double num2 = 0;
            double resultado = 0;
           
            do
            {
                num1 = 0;
                num2 = 0;
                resultado = 0;

                Console.Clear();

                Console.WriteLine(" ****** MENU DE OPCIONES ******");
                Console.WriteLine("        1) Calcular area del cuadrado");
                Console.WriteLine("        2) Calcular area del triangulo");
                Console.WriteLine("        3) Calcular area del circulo");
                Console.WriteLine("        4) Salir");
                Console.Write("            Ingrese opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write(" Ingrese un numero: ");
                        double.TryParse(Console.ReadLine(), out num1);

                        resultado = CalculoDeArea.CalcularCuadrado(num1);

                        Console.WriteLine();
                        Console.Write(" Area del cuadrado: {0}", resultado);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write(" Ingrese base: ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine();

                        Console.Write(" Ingrese altura: ");
                        double.TryParse(Console.ReadLine(), out num2);

                        resultado = CalculoDeArea.CalcularTriangulo(num1, num2);

                        Console.WriteLine();
                        Console.Write(" Area del triangulo: {0}", resultado);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write(" Ingrese un numero: ");
                        double.TryParse(Console.ReadLine(), out num1);

                        resultado = CalculoDeArea.CalcularCirculo(num1);

                        Console.WriteLine();
                        Console.Write(" Area del circulo: {0}", resultado);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine(" NOS VEMOS!");
                        break;
                    default:
                        Console.WriteLine(" OPCION INCORRECTA");
                        break;
                }

                if(opcion != 4) 
                {
                    Console.Write(" ¿Desea Continuar? (S/N): ");
                    char.TryParse(Console.ReadLine(), out resp);
                }
                else
                {
                    resp = 'n';
                }

            }while(CalculoDeArea.ValidarS_N(resp));

            Console.ReadKey();
        }
    }
}
