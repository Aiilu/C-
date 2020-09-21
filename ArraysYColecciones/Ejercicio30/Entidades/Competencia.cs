using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        private Random numRand;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
            this.numRand = new Random();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            //for(int i=0; i<c.competidores.Count; i++)
            foreach(AutoF1 act in c.competidores)
            {
                if(act == a)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c.competidores.Count < c.cantidadCompetidores)
            {
                if(c != a)
                {
                    c.competidores.Add(a);
                    a.SetEnCompetencia(true);
                    a.SetVueltasRestantes(c.cantidadVueltas);
                    a.SetCantidadCombustible((short)(c.numRand.Next(15, 100)));

                    return true;
                }
            }

            return false;          
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
                if(c == a)
                {
                    c.competidores.Remove(a);
                    a.SetEnCompetencia(false);
                    a.SetVueltasRestantes(0);
                    a.SetCantidadCombustible(0);

                    return true;
                }

            return false;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Cantidad Competidores: {this.cantidadCompetidores}");
            datos.AppendLine($"Cantidad Vueltas: {this.cantidadVueltas}");
            datos.AppendLine("Competidores: ");

            foreach(AutoF1 a in this.competidores)
            {
                datos.AppendLine(a.MostrarDatos());
            }

            return datos.ToString();
        }

    }
}
