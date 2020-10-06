using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador :Persona
    {
        public enum Posicion { Arquero, Defensor, Central, Delantero }

        private float altura;
        private float peso;
        private Posicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            :base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion PosicionJugador
        {
            get
            {
                return this.posicion;
            }
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.Mostrar());
            datos.AppendLine($" Altura: {this.Altura}");
            datos.AppendLine($" Peso: {this.Peso}");
            datos.AppendLine($" Posicion: {this.PosicionJugador}");

            return datos.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            double IMC = this.Peso / Math.Pow(this.Altura, 2);

            if(IMC > 1.5 && IMC <= 25)
            {
                return true;
            }

            return false;
        }

        public override bool ValidarAptitud()
        {
            if(base.Edad < 40 && this.ValidarEstadoFisico())
            {
                return true;
            }

            return false;
        }
    }
}
