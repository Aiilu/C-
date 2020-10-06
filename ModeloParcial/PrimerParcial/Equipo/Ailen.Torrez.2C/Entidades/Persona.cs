using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public string Apellido
        {
            get
            {
                if(!string.IsNullOrEmpty(this.apellido))
                {
                    return this.apellido;
                }

                return "Este Apellido no es valido";
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public string Nombre
        {
            get
            {
                if (!string.IsNullOrEmpty(this.nombre))
                {
                    return this.nombre;
                }

                return "Este Nombre no es valido";
            }
        }

        public virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Nombre: {this.Nombre}");
            datos.AppendLine($" Apellido: {this.Apellido}");
            datos.AppendLine($" Edad: {this.Edad}");
            datos.AppendLine($" DNI: {this.Dni}");

            return datos.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
