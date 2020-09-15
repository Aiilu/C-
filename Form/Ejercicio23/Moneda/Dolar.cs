using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {
        private double cantidad;
        private static double CotizRespectoDolar;

        static Dolar()
        {
            CotizRespectoDolar = 1;
        }

        public Dolar(double cant)
        {
            this.cantidad = cant;
        }

        public Dolar(double cant, double cotizacion) : this(cant) //reutilizo el constructor
        {
            CotizRespectoDolar = cotizacion; //como es de clase, no accedes con el this
        }

        public static void SetCotizacion(double cotiz)
        {
            CotizRespectoDolar = cotiz;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return CotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro e;

            e = new Euro(Euro.GetCotizacion() * d.cantidad); //tengo tantos dolares, quiero saber cuantos euros son

            return e;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos p;

            p = new Pesos(Pesos.GetCotizacion() * d.cantidad);

            return p;
        }

        public static implicit operator Dolar(double dd)
        {
            Dolar d;

            d = new Dolar(dd);

            return d;
        }

        public static bool operator ==(Dolar d, Dolar d2)
        {
            return d.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d, Dolar d2)
        {
            return !(d == d2);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            /*Dolar d2;

            d2 = (Dolar)p;

            return d.cantidad == d2.cantidad;*/

            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static Dolar operator +(Dolar d, Dolar d2)
        {
            return d.cantidad + d2.cantidad;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d + (Dolar)e;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d + (Dolar)p;
        }

        public static Dolar operator -(Dolar d, Dolar d2)
        {
            return d.cantidad - d2.cantidad;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d - (Dolar)e;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d - (Dolar)p;
        }
    }
}
