using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        public enum Tipo { Terrozo, Arenozo }

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;
        
        public static Tipo TipoDeSuelo
        {
            set
            {
                suelo = value;
            }
        }

        static Jardin()
        {
            suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal) :this()
        {
            this.espacioTotal = espacioTotal;
        }

        private int EspacioOcupado()
        {
            int acum = 0;
            //Total ocupado por todas las plantas del Jardin
            foreach(Planta p in this.plantas)
            {
                acum += p.Tamanio;
            }

            return acum;
        }

        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            if(jardin.espacioTotal > jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Composicion del jardin: {suelo}");
            datos.AppendLine($" Espacio Ocupado: {this.EspacioOcupado()} de {this.espacioTotal}");
            datos.AppendLine("");
            datos.AppendLine(" LISTA DE PLANTAS ");
            datos.AppendLine(" ---------------- ");

            foreach(Planta p in this.plantas)
            {
                datos.AppendLine(p.ResumenDeDatos());
            }

            return datos.ToString();
        }
    }
}
