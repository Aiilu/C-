using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Torneo<T>
        where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        private Random random;

        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
            this.random = new Random();
        }

        public static bool operator ==(Torneo<T> t, T e)
        {
            foreach(T e2 in t.equipos)
            {
                if(e2 == e)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static bool operator +(Torneo<T> t, T e)
        {
            if(t != e)
            {
                t.equipos.Add(e);
                return true;
            }

            return false;
        }

        public string Mostrar(Torneo<T> t)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Torneo: {t.nombre}.");
            datos.AppendLine(" Equipos");
            datos.AppendLine("  -------");
            
            foreach(T e in t.equipos)
            {
                datos.AppendLine(e.Ficha());
            }

            return datos.ToString();
        }

        public string CalcularPartido(T t1, T t2)
        {
            int resultado1 = random.Next(2, 11);
            int resultado2 = random.Next(2, 11);

            return $"{t1.Ficha()} {resultado1} - {t2.Ficha()} {resultado2}";
        }
    }
}
