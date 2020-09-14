using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        private string CodigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigo, string marca, float precio)
        {
            this.CodigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" El codigo de barras es: {(string)p.CodigoDeBarra}");
            datos.AppendLine($" La marca es: {p.GetMarca()}");
            datos.AppendLine($" El precio es: {p.GetPrecio()}");

            return datos.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.CodigoDeBarra;
        }

        public static bool operator ==(Producto p, Producto p2)
        {
            return (p.marca == p2.marca) && ((string)p.CodigoDeBarra == (string)p2.CodigoDeBarra);
        }

        public static bool operator !=(Producto p, Producto p2)
        {
            return !(p == p2);
        }

        public static bool operator ==(Producto p, string s)
        {
            return p.marca == s;
        }

        public static bool operator !=(Producto p, string s)
        {
            return !(p == s);
        }
    }
}
