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
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.promedioGoles = 0;
        }

        public Jugador(int dni, string nombre) :this(dni, nombre, 0, 0)
        {
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) :this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles()
        {
                if(this.partidosJugados == 0)
                {
                    return 0;
                }

                this.promedioGoles = this.totalGoles / this.partidosJugados;
                return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"El DNI es: {this.dni}");
            datos.AppendLine($"El nombre es: {this.nombre}");
            datos.AppendLine($"Partidos jugados: {this.partidosJugados}");
            datos.AppendLine($"Total de Goles: {this.totalGoles}");
            datos.AppendLine($"Promedio Goles: {this.GetPromedioGoles()}");

            return datos.ToString();
        }

        //public static bool operator
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
