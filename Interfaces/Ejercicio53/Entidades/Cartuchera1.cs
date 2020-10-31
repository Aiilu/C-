using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        private List<IAcciones> acciones;

        public Cartuchera1()
        {
            this.acciones = new List<IAcciones>();
        }

        public static Cartuchera1 operator +(IAcciones a, Cartuchera1 b)
        {
            b.acciones.Add(a);
            return b;
        }

        public bool ProbarElementos()
        {
            foreach(IAcciones a in this.acciones)
            {
                if(a.UnidadesDeEscritura >= 1)
                {
                    a.UnidadesDeEscritura--;
                }
                else if(a is Boligrafo)
                {
                    return false;
                }
                
                if(a is Boligrafo && a.UnidadesDeEscritura == 0)
                {
                    a.Recargar(20);
                }
            }

            return true;
        }
    }
}
