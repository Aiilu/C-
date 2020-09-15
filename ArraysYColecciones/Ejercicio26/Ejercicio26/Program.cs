using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int aux;
            //int[] arrayPosit = new int[20];
            //int[] arrayNegat = new int[20];

            Random numero = new Random();

            for(int i=0; i<array.Length; i++)
            {
                aux = 0;

                while (aux == 0)
                {
                    aux = numero.Next(-20, 20);

                    if (aux != 0)
                    {
                        array[i] = aux;
                    }
                }              
            }

            foreach(int guardar in array)
            { 
                Console.WriteLine(guardar);
            }

            //del mas grande al mas chico
            for(int i=0; i<array.Length-1; i++)
            {
                for(int j=i+1; j<array.Length; j++)
                {
                    if(Math.Abs(array[i]) < Math.Abs(array[j])) //+ a - (i > j), - a + (el mas alejado en el -, es el mas chico)
                    {
                        aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }

            foreach (int guardar in array)
            {
                if(guardar > 0)
                {
                    Console.WriteLine(guardar);
                }
            }

            Console.WriteLine();

            foreach (int guardar in array)
            {
                if (guardar < 0)
                {
                    Console.WriteLine(guardar);
                }
            }

            Console.ReadKey();
        } 
    }
}
