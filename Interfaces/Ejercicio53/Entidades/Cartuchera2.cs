using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2
    {
        private List<Boligrafo> listBol;
        private List<Lapiz> listLap;

        public Cartuchera2()
        {
            this.listBol = new List<Boligrafo>();
            this.listLap = new List<Lapiz>();
        }

        public static Cartuchera2 operator +(Lapiz a, Cartuchera2 b)
        {
                b.listLap.Add(a);
            return b;
        }

        public static Cartuchera2 operator +(Boligrafo a, Cartuchera2 b)
        {
            b.listBol.Add(a);
            return b;
        }

        public bool ProbarElementos()
        {
            foreach (Boligrafo b in this.listBol)
            {
                if (b.UnidadesDeEscritura >= 1)
                {
                    b.UnidadesDeEscritura--;
                }
                else
                {
                    return false;
                }

                if (b.UnidadesDeEscritura == 0)
                {
                    b.Recargar(20);
                }
            }

            foreach (Lapiz l in this.listLap)
            {
                if (((IAcciones)l).UnidadesDeEscritura >= 1)
                {
                    ((IAcciones)l).UnidadesDeEscritura--;
                }
            }

            return true;
        }
    }
}
