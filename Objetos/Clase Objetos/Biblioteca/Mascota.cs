using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    { 
        //Las cosas de la clase se usan y se llaman en la clase
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;

        public Mascota(string nombre, DateTime fechaNacimiento, string especie)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat(" Nombre: {0}\n", this.nombre);
            datos.AppendLine($" Fecha de nacimiento: {this.fechaNacimiento.ToString("yyyy/MM/dd")}");
            datos.AppendLine($" Fecha de nacimiento: {this.fechaNacimiento.ToLongDateString()}");
            datos.AppendLine($" Fecha de nacimiento: {this.fechaNacimiento.ToShortDateString()}");
            datos.AppendLine(string.Format(" Especie: {0}\n", this.especie));

            return datos.ToString();
        }

        public int CalcularEdad()
        {
            int edad;

            DateTime fechaAct = new DateTime();

            fechaAct = DateTime.Today;

            edad = (int)((fechaAct - this.fechaNacimiento).TotalDays)/365;

            return edad;
        }
    }
}