using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto v1, Punto v3)
        {
            this.vertice1 = new Punto(v1.GetX(), v1.GetY());
            this.vertice3 = new Punto(v3.GetX(), v3.GetY());

            this.vertice2 = new Punto(v1.GetX(), v3.GetY());
            this.vertice4 = new Punto(v3.GetX(), v1.GetY());

            this.area = 0;
            this.perimetro = 0;
        }

        public float GetArea()
        {
            if(this.area == 0)
            {
                float bases = Math.Abs((this.vertice1.GetX() - this.vertice3.GetX()));
                float altura = Math.Abs((this.vertice1.GetY() - this.vertice3.GetY()));

                this.area = bases * altura;
            }

            return this.area;
        }

        public float GetPerimetro()
        {
            if (this.perimetro == 0)
            {
                float bases = Math.Abs((this.vertice1.GetX() - this.vertice3.GetX()));
                float altura = Math.Abs((this.vertice1.GetY() - this.vertice3.GetY()));

                this.perimetro = (bases + altura)*2;
            }

            return this.perimetro;
        }

        public string DevolRectang(Rectangulo rect)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(" Datos del rectangulo: ");

            datos.AppendLine($" Vertice 1: ({rect.vertice1.GetX()},{rect.vertice1.GetY()})");
            datos.AppendLine($" Vertice 2: ({rect.vertice2.GetX()},{rect.vertice2.GetY()})");
            datos.AppendLine($" Vertice 3: ({rect.vertice3.GetX()},{rect.vertice3.GetY()})");
            datos.AppendLine($" Vertice 4: ({rect.vertice4.GetX()},{rect.vertice4.GetY()})");
            datos.AppendLine($" Perimetro: {rect.GetPerimetro()}");
            datos.AppendLine($" Area: {rect.GetArea()}");

            return datos.ToString();
        }
    }
}
