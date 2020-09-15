using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Pesos
    {
        private double cantidad;
        private static double CotizRespectoDolar;

        static Pesos()
        {
            CotizRespectoDolar = 74.77; //cuantos pesos es un dolar
        }

        public Pesos(double cant)
        {
            this.cantidad = cant;
        }

        public Pesos(double cant, double cotizacion) : this(cant) //reutilizo el constructor
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

        public static explicit operator Dolar(Pesos p)
        {
            Dolar d;

            d = new Dolar(p.cantidad / CotizRespectoDolar);

            return d;
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar d;
            Euro e;

            d = (Dolar)p;
            e = (Euro)d;

            return e;
        }

        public static implicit operator Pesos(double pp)
        {
            Pesos p;

            p = new Pesos(pp);

            return p;
        }

        public static bool operator ==(Pesos p, Pesos p2)
        {
            return p.cantidad == p2.cantidad;
        }

        public static bool operator !=(Pesos p, Pesos p2)
        {
            return !(p == p2);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == (Pesos)d;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p == (Pesos)e;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static Pesos operator +(Pesos p, Pesos p2)
        {
            return p.cantidad + p2.cantidad;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p + (Pesos)d;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return p + (Pesos)e;
        }

        public static Pesos operator -(Pesos p, Pesos p2)
        {
            return p.cantidad - p2.cantidad;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p - (Pesos)d;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return p - (Pesos)e;
        }
    }
}
