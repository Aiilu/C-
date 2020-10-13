using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        public short Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        protected Persona(string nombre, short edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public abstract bool Validar();

        public static explicit operator string(Persona persona)
        {
            return persona.Mostrar();
        }

        protected virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Edad: {this.Edad}");

            if (this is Gente && !String.IsNullOrEmpty(this.Nombre))
            {
                datos.AppendLine($" Nombre: {this.Nombre}");
            }
            else if(this is Empleado)
            {
                datos.AppendLine($" Nombre: {this.Nombre}");
            }
            
            return datos.ToString();
        }
    }
}
