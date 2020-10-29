using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado :Persona
    {
        private int dni;

        public Empleado(string nombre, short edad) :this(nombre, edad, -1)
        {
        }

        public Empleado(string nombre, short edad, int dni) :base(nombre, edad)
        {
            this.dni = dni;
        }

        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(" EMPLEADO");
            datos.AppendLine(" --------");

            datos.AppendLine(base.Mostrar());

            if(this.dni > 0)
            {
                datos.AppendLine($" Dni: {this.dni}");
            }

            return datos.ToString();
        }

        public override bool Validar()
        {
            if(base.Edad > 21 && base.Nombre.Length > 1)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return (e1.Nombre == e2.Nombre) && (e1.Edad == e2.Edad);
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
    }
}
