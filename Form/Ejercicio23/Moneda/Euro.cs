using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static double CotizRespectoDolar;

        static Euro()
        {
            CotizRespectoDolar = 0.85;
        }

        public Euro(double cant)
        {
            this.cantidad = cant;
        }

        public Euro(double cant, double cotizacion) : this(cant) //reutilizo el constructor
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

        public static explicit operator Dolar(Euro e)
        {
            Dolar d;

            d = new Dolar(e.cantidad / CotizRespectoDolar);

            return d;
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolar d;
            Pesos p;

            d = (Dolar)e;
            p = (Pesos)d;

            return p;
        }

        public static implicit operator Euro(double ee)
        {
            Euro e;

            e = new Euro(ee);

            return e;
        }

        public static bool operator ==(Euro e, Euro e2)
        {
            return e.cantidad == e2.cantidad;
        }

        public static bool operator !=(Euro e, Euro e2)
        {
            return !(e == e2);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e == (Euro)p;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static Euro operator +(Euro e, Euro e2)
        {
            return e.cantidad + e2.cantidad;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e + (Euro)d;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return e + (Euro)p;
        }

        public static Euro operator -(Euro e, Euro e2)
        {
            return e.cantidad - e2.cantidad;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return e - (Euro)d;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return e - (Euro)p;
        }
    }
}
