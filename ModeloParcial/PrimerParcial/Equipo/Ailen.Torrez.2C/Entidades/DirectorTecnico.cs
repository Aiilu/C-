using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico :Persona
    {
        private int añosExperiencia;

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia)
            :base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {   
                this.añosExperiencia = value;
            }
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.Mostrar());
            datos.AppendLine($" Años de Experiencia: {this.AñosExperiencia}");

            return datos.ToString();
        }

        public override bool ValidarAptitud()
        {
            if(base.Edad < 65 && this.AñosExperiencia >= 2)
            {
                return true;
            }

            return false;
        }
    }
}
