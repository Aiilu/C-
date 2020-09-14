using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        private static Random aleatorio;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        static Alumno()
        {
            aleatorio = new Random();
        }

        public void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = (float)aleatorio.Next(-5, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Nombre: {this.nombre}");
            datos.AppendLine($" Apellido: {this.apellido}");
            datos.AppendLine($" Legajo: {this.legajo}");

            if(this.notaFinal > -1)
            {
                datos.AppendLine($" Nota Final: {this.notaFinal}");
            }
            else
            {
                datos.AppendLine($" Nota Final: {this.notaFinal}");
                datos.AppendLine($" ¡Alumno Desaprobado! D:");
            }

            return datos.ToString();
        }
    }
}
