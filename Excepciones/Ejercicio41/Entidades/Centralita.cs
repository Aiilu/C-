using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private void AgregarLlamada(Llamada llamada1)
        {
            this.Llamadas.Add(llamada1);
        }

        public static Centralita operator +(Centralita c, Llamada llam)
        {
            //Try catch es para tratar errores (trata esto), el throw te dice simplemente que tenes una excepcion(la tira).

            if(c != llam)
            {
                c.AgregarLlamada(llam);
            }
            else
            {
                throw new CentralitaException($"Llamada: {llam}", " Centralita", " Sobrecarga en el operador +");
            }

            return c;
        }


        public static bool operator ==(Centralita c, Llamada llam)
        {
            foreach(Llamada l in c.Llamadas)
            {
                if(l == llam)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Centralita c, Llamada llam)
        {
            return !(c == llam);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acum = 0;

            foreach (Llamada llam in this.Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llam is Local)
                        {
                            acum += llam.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llam is Provincial)
                        {
                            acum += llam.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        acum += llam.CostoLlamada;
                        break;
                }
            }

            return acum;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Razon Social: {this.razonSocial}");
            datos.AppendLine($" Ganancia por Total: {this.GananciasPorTotal}");
            datos.AppendLine($" Ganancia por Local: {this.GananciasPorLocal}");
            datos.AppendLine($" Ganancia por Provincial: {this.GananciasPorProvincial}");
            datos.AppendLine();

            foreach (Llamada llam in this.Llamadas)
            {
                datos.AppendLine($"{llam}");
            }

            return datos.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
