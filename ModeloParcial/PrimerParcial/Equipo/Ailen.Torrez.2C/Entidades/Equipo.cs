using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public static bool ValidarEquipo(Equipo e) //podria ser static
        {
            int contArquero = 0;
            int contCentral = 0;
            int contDefensor = 0;
            int contDelantero = 0;

            if(Equipo.cantidadMaximaJugadores == e.jugadores.Count)
            {
                if(!object.ReferenceEquals(e.directorTecnico, null))
                {
                    foreach(Jugador j in e.jugadores)
                    {
                        switch(j.PosicionJugador)
                        {
                            case Jugador.Posicion.Arquero:
                                contArquero++;
                                break;
                            case Jugador.Posicion.Central:
                                contCentral++;
                                break;
                            case Jugador.Posicion.Defensor:
                                contDefensor++;
                                break;
                            case Jugador.Posicion.Delantero:
                                contDelantero++;
                                break;
                        }

                        if(contArquero == 1 && contCentral >= 1 && contDefensor >= 1 && contDelantero >=1)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Nombre del Equipo: {e.Nombre}");
            datos.AppendLine("");

            datos.AppendLine(" Director Tecnico");
            datos.AppendLine(" -----------------");

            if(object.ReferenceEquals(e.directorTecnico, null))
            {
                datos.AppendLine(" Sin DT asignado todavia");
            }
            else
            {
                datos.AppendLine(e.directorTecnico.Mostrar());
            }

            datos.AppendLine("");

            datos.AppendLine(" Jugadores");
            datos.AppendLine(" ---------");

            foreach(Jugador j in e.jugadores)
            {
                datos.AppendLine(j.Mostrar());
            }

            return datos.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            if(e.jugadores.Equals(j)) //esto o contains??
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(Equipo.cantidadMaximaJugadores > e.jugadores.Count)
            {
                if(e != j && j.ValidarAptitud()) //hace falta un foreach
                {
                    e.jugadores.Add(j);
                }
            }

            return e;
        }
    }
}
