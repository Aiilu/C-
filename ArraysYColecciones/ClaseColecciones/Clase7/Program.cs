using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[3];

            List<string> ListaNombres = new List<string>();
            ListaNombres.Add("Ailen");
            ListaNombres.Add("Leo");
            ListaNombres.Add("Pepe");
            ListaNombres[4] = "Hola";
            ListaNombres.Sort();

            foreach (string nombre in ListaNombres)
            {
                Console.WriteLine(nombre);
            }

            ListaNombres.Remove("Ailen");

            for(int i=0; i<ListaNombres.Count; i++)
            {
                Console.WriteLine(ListaNombres[i]);
            }

            ListaNombres.RemoveAt(0);

            for (int i = 0; i < ListaNombres.Count; i++)
            {
                Console.WriteLine(ListaNombres[i]);
            }

            Dictionary<int, string> agenda = new Dictionary<int, string>();
            agenda.Add(12345678, "Ailen Torrez");
            agenda.Add(13578942, "Leonardo Magnaghi");

            foreach (KeyValuePair<int,string> contacto in agenda)
            {
                Console.WriteLine($"La clave es {contacto.Key} y el valor es {contacto.Value}");
            }

            Queue<string> colaAtencion = new Queue<string>();
            colaAtencion.Enqueue("Alo alo");
            colaAtencion.Enqueue("Bay bay");

            for (int i=0; i<colaAtencion.Count; i++)
            {
                Console.WriteLine(colaAtencion.Dequeue());
            }
      
            Console.WriteLine(colaAtencion.Peek());
            Console.WriteLine(colaAtencion.Dequeue());

            Stack<char> letras = new Stack<char>();
            letras.Push('A');
            letras.Push('L');

            foreach(char letra in letras)
            {
                Console.Write(letra);
            }

            Console.WriteLine(letras.Pop());
            Console.ReadKey();
        }
    }
}
