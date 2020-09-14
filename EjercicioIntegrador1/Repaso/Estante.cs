using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        public Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
    
        public Estante(int capacidad, int ubicacion) :this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public string MostrarEstante(Estante e)
        {
            StringBuilder datos = new StringBuilder();

            //Producto[] aux = e.GetProductos();

            foreach(Producto p in e.GetProductos())
            {
                Producto.MostrarProducto(p);
            }

            return datos.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;

            foreach(Producto pe in e.GetProductos())
            {
                if(p == pe)
                {
                    if(!object.ReferenceEquals(p,null)) //devuelve verdadero si los dos obj se refieren a lo mismo
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            foreach()
        }


    }
}
