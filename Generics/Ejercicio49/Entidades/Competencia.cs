using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia<T>
        where T : VehiculoDeCarrera
    {
        public enum TipoCompetencia { F1, MotoCross }
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia tipo;
        private Random numRand;

        private Competencia()
        {
            this.competidores = new List<T>();
            this.numRand = new Random();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) :this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public T this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public List<T> DevListaComp
        {
            get
            {
                return this.competidores;
            }
        }

        public TipoCompetencia Tipo
        { 
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public static bool operator ==(Competencia<T> c, T a)
        {
            /*if(c.tipo == TipoCompetencia.F1)
            {
                if(a is MotoCross)
                {
                    return true;
                }
            }
            else if(a is AutoF1)
            {
                return true;
            }*/

            if((c.tipo == TipoCompetencia.F1 && a is MotoCross) || 
               (c.tipo == TipoCompetencia.MotoCross && a is AutoF1))
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Sobrecarga del ==");
            }

            //for(int i=0; i<c.competidores.Count; i++)
            foreach(VehiculoDeCarrera act in c.competidores)
            {
                if(act == a)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Competencia<T> c, T a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia<T> c, T a)
        {
            if(c.competidores.Count < c.cantidadCompetidores)
            {
                try
                {
                    if (c != a)
                    {
                        c.competidores.Add(a);
                        a.EnCompetencia = true;
                        a.VueltasRestantes = c.cantidadVueltas;
                        a.CantidadCombustible = (short)(c.numRand.Next(15, 100));

                        return true;
                    }
                }
                catch(CompetenciaNoDisponibleException ex)
                {
                    throw new CompetenciaNoDisponibleException("Competencia Incorrecta", "Competencia", "Sobrecarga del operador +", ex);
                }
            }

            return false;          
        }

        public static bool operator -(Competencia<T> c, T a)
        {
                if(c == a)
                {
                    c.competidores.Remove(a);
                    a.EnCompetencia = false;
                    a.VueltasRestantes = 0;
                    a.CantidadCombustible = 0;

                return true;

                }

            return false;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Cantidad Competidores: {this.CantidadCompetidores}");
            datos.AppendLine($" Cantidad Vueltas: {this.CantidadVueltas}");
            datos.AppendLine(" Competidores: ");

            //ESTO SOLO RECORRIA LA LISTA Y LA MOSTRABA
            foreach(T v in this.competidores)
            {
               datos.AppendLine(v.MostrarDatos());
            }

            return datos.ToString();
        }
    }
}
