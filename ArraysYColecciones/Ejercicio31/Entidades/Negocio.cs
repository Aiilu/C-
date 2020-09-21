using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
           //Contains tal vez mira la direccion de memoria, entonces el foreach recorre el negocio guardando
           //un cliente y asi sucesivamente.
           //Recorres la lista, agarrando el cliente uno por uno.

            foreach(Cliente cli in n.clientes)
            {
                if(cli == c)
                {
                    return true;
                }
            }

            return false;
           
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }

            return false;
        }

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                if (this + value);
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        public string ProximoCliente
        {
            get
            {
                return this.clientes.Peek().Nombre;
            }
        }

        public static bool operator ~(Negocio n)
        {
            //El valor de n.Cliente va a pasar a c (c = n.Cliente) osea que llamo al get.
            //Ahora, si hago n.Cliente = c estoy asignadole a la prop el valor de c, y eso llama al set.
            return n.caja.Atender(n.Cliente);
        }
    }
}
