using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        private Cantina(int espaciosTotales)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espaciosTotales;
        }

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        public static Cantina GetCantina(int espaciosTotales)
        {
            if(singleton == null)
            {
                singleton = new Cantina(espaciosTotales);
            }
            else
            {
                singleton.espaciosTotales = espaciosTotales;
            }

            return singleton;
        }

        public static bool operator +(Cantina c, Botella b)
        {
            if(c.espaciosTotales > c.Botellas.Count)
            {
                c.Botellas.Add(b);

                return true;
            }

            return false;
        }
    }
}
