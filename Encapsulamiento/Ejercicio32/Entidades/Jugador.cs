using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) : this(dni, nombre, 0, 0)
        {
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
        {
            this.PropDni = dni;
            this.PropNombre = nombre;
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public float PropPromGoles
        {
            get
            {
                if (this.PropPartJug == 0)
                {
                    return 0;
                }

                return this.PropTotGoles / this.PropPartJug;
            }
        }

        public int PropPartJug
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public int PropTotGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public string PropNombre
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

        public int PropDni
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

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"El DNI es: {this.PropDni}");
            datos.AppendLine($"El nombre es: {this.PropNombre}");
            datos.AppendLine($"Partidos jugados: {this.PropPartJug}");
            datos.AppendLine($"Total de Goles: {this.PropTotGoles}");
            datos.AppendLine($"Promedio Goles: {this.PropPromGoles}");

            return datos.ToString();
        }

        //public static bool operator
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.PropDni == j2.PropDni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);

        }
    }
}