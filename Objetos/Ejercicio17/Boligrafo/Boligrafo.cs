using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafos
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short cantTinta)
        {
            this.color = color;
            this.tinta = cantTinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            int total = 0;

            total = this.tinta + tinta;

            if ((total >= 0) && (total <= cantidadTintaMaxima))
            {
                this.tinta = (short)total;
            }
            else if(total < 0)
            {
                this.tinta = 0;
            }
            else
            {
                this.tinta = 100;
            }
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno;
            int contador = 0;
            StringBuilder datos = new StringBuilder();

            if(this.GetTinta() > 0)
            {
                //datos.AppendLine(" Se logro pintar"); 

                while(this.GetTinta() > contador && contador < gasto)
                {
                    contador++;
                    datos.Append("*");
                }

                this.SetTinta((short)-contador);

                dibujo = datos.ToString();
                retorno = true;
            }
            else
            {
                dibujo = " No se logro pintar. No hay tinta D:";
                retorno = false;
            }

            return retorno;
        }
    }
}