using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo :Figura
    {
        private double altura;
        private double bases;

        public Rectangulo(double altura, double bases) :base()
        {
            this.altura = altura;
            this.bases = bases;
        }

        public override string Dibujar()
        {
            return " Dibujando Rectangulo...";
        }

        public override double CalcularSuperficie()
        {
            return this.bases * this.altura;
        }

        public override double CalcularPerimetro()
        {
            return (2 * this.bases) + (2 * this.altura);
        }

    }
}
