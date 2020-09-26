using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador :Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) : this(dni, nombre, 0, 0)
        {
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) :base(dni, nombre)
        {
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

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.MostrarDatos());
            datos.AppendLine($"Partidos jugados: {this.PropPartJug}");
            datos.AppendLine($"Total de Goles: {this.PropTotGoles}");
            datos.AppendLine($"Promedio Goles: {this.PropPromGoles}");

            return datos.ToString();
        }

        //public static bool operator
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);

        }
    }
}