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
                            Local l = (Local)llam;

                            acum += l.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llam is Provincial)
                        {
                            Provincial p = (Provincial)llam;

                            acum += p.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llam is Local)
                        {
                            Local l = (Local)llam;

                            acum += l.CostoLlamada;
                        }
                        else if (llam is Provincial)
                        {
                            Provincial p = (Provincial)llam;

                            acum += p.CostoLlamada;
                        }
                        break;
                }
            }

            return acum;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" Razon Social: {this.razonSocial}");
            datos.AppendLine($" Ganancia por Total: {this.GananciasPorTotal}");
            datos.AppendLine($" Ganancia por Local: {this.GananciasPorLocal}");
            datos.AppendLine($" Ganancia por Provincial: {this.GananciasPorProvincial}");

            foreach (Llamada llam in this.Llamadas)
            {
                if (llam is Local)
                {
                    Local l = (Local)llam;

                    datos.AppendLine(l.Mostrar());
                }
                else if (llam is Provincial)
                {
                    Provincial p = (Provincial)llam;

                    datos.AppendLine(p.Mostrar());
                }
            }

            return datos.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
