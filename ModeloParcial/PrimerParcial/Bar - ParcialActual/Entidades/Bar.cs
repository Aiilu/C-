using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton;

        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }

        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }

        private Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }

        public static Bar GetBar()
        {
            if (object.ReferenceEquals(singleton, null))
            {
                return new Bar();
            }

            return singleton;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            foreach(Empleado emp in this.Empleados)
            {
                datos.AppendLine((string)emp);
            }

            foreach(Gente gen in this.Gente)
            {
                datos.AppendLine((string)gen);
            }
            
            return datos.ToString();
        }

        public static bool operator +(Bar bar, Empleado empleado)
        {
            if(empleado.Validar())
            {
                foreach (Empleado emp in bar.Empleados)
                {
                    if (emp == empleado)
                    {
                        return false;
                    }
                }

                bar.Empleados.Add(empleado);
                return true;
            }

            return false;
        }

        public static bool operator +(Bar bar, Gente gente)
        {
            if(bar.Empleados.Count * 2 > bar.Gente.Count && gente.Validar())
            {
                bar.Gente.Add(gente);
                return true;
            }

            return false;
        }
    }
}
