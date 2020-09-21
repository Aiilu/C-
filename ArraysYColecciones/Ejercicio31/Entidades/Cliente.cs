using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int num;

        private Cliente(int numero)
        {
            this.num = numero;
        }

        public Cliente(int numero, string nombre) :this(numero)
        {
            this.Nombre = nombre;
        }

        public string Nombre
        {
            get
            {               
                 return this.nombre;            
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
                else
                {
                    string.Format("El nombre es invalido");
                }
            }
        }

        public int Numero
        {
            get
            {
                return this.num;
            }
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.num == c2.num;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}