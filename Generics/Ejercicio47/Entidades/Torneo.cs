using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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
            foreach(T e1 in t.equipos)
            {
                if(e1 == e)
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

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Nombre del torneo: {this.nombre}.");
            datos.AppendLine();
            datos.AppendLine(" Equipos:");

            foreach(T e in this.equipos)
            {
                datos.AppendLine(e.Ficha());
            }

            return datos.ToString();
        }

        private string CalcularPartido(T t1, T t2)
        {
            int resultado1 = this.random.Next(0, 10);
            //this.random = new Random();
            int resultado2 = this.random.Next(0, 10);

            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"{t1.Ficha()} {resultado1} - {resultado2} {t2.Ficha()}.");

            return datos.ToString();
        }

        public string JugarPartido
        {
            get
            {
                int n = this.random.Next(0, this.equipos.Count -1);
                T e = this.equipos.ElementAt(n);
                T e1 = e;

                n = this.random.Next(0, this.equipos.Count - 1);
                e1 = this.equipos.ElementAt(n);
                
                if (e == e1)
                {
                    if (n != 0)
                    {
                        e1 = this.equipos.ElementAt(n-1);
                    }
                    else
                    {
                        e1 = this.equipos.ElementAt(n+1);
                    }
                }
                
                return this.CalcularPartido(e, e1);
            }
        }
    }
}
