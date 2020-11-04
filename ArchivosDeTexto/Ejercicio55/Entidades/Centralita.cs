using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
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

        public string RutaDelArchivo { get ; set ; }

        private void AgregarLlamada(Llamada llamada1)
        {
            this.Llamadas.Add(llamada1);
        }

        public static Centralita operator +(Centralita c, Llamada llam)
        {
            //Try catch es para tratar errores (trata esto), el throw te dice simplemente que tenes una excepcion(la tira).


            if (c != llam)
            {
                c.AgregarLlamada(llam);
                try
                {
                    c.Guardar();
                }
                catch (Exception ex)
                {

                }
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

        public bool Guardar()
        {
            StreamWriter steam = null; //Para tenerlo declarado desde fuera y poder usarlo en el finally.

            if(!Directory.Exists("")) //Pones vacio o no lo pones cuando es el x defecto
            {
                throw new FileNotFoundException();
            }

            try
            {
                steam = new StreamWriter("Bitacora.txt", true); //Esto es abrir el archivo, open.
                steam.WriteLine(DateTime.Now.ToString("D t") + "-Se realizo una llamada"); //Escribe el archivo
                return true;
            }
            finally //Esto siempre se ejecuta
            {
                if (steam != null) //Para saber si apunta a un archivo o a null.
                {
                    steam.Close(); //Cierra el archivo
                }
            }
        }

        public string Leer()
        {
            StreamReader leer = null;

            if (!File.Exists("Bitacora.txt"))
            {
                throw new FileNotFoundException();
            }

            try
            {
                leer = new StreamReader("Bitacora.txt"); //Esto abre el archivo en modo lectura
                return leer.ReadToEnd();
            }
            finally
            {
                if (leer != null)
                {
                    leer.Close();
                }
            }
        }


    }
}