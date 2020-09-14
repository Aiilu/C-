using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Animal
    {
        private int edad;
        private string raza;
        private string nombre;

        public Animal(int edadI, string razaI, string nombreI)
        {
            this.edad = edadI;
            this.raza = razaI;
            this.nombre = nombreI;
        }

        public Animal(int edadI, string razaI)
        {
            this.edad = edadI;
            this.raza = razaI;
            this.nombre = null;
        }

        public static bool operator ==(Animal anim1, string nombre1)
        {
            return anim1.nombre == nombre1;
        }

        public static bool operator !=(Animal anim1, string nombre1)
        {
            return !(anim1 == nombre1);
        }

        public static bool operator ==(Animal anim1, int edad1)
        {
            return anim1.edad == edad1;
        }

        public static bool operator !=(Animal anim1, int edad1)
        {
            return !(anim1 == edad1);
        }
    }
}
