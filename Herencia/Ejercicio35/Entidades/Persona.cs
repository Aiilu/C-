using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        //tengo que usar todos mis atributos, al que solo recibe nombre, deberia usar el dni?
        public Persona(string nombre) 
        {
            this.Nombre = nombre;
        }

        public Persona(long dni, string nombre) :this(nombre)
        {
            this.Dni = dni;
        }

        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
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

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Nombre de la Persona: {this.Nombre}");
            datos.AppendLine($" DNI de la Persona: {this.Dni}");

            return datos.ToString();
        }
    }
}