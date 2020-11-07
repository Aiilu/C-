using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    [Serializable]
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        public enum Franja { Franja_1, Franja_2, Franja_3}
        protected Franja franjaHorario;

        public Provincial(Franja miFranja, Llamada llamada) :this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
            
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHorario = miFranja;
        }

        public Provincial() : base()
        {

        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string RutaDelArchivo
        {
            get
            {
                return "Provincial";
            }
            set
            {
            }
        }

        private float CalcularCosto()
        {
            //retorna el valor de la llamada a partir de la duracion y el costo.
            //Los valores seran: Franja_1 : 0.99
            //Los valores seran: Franja_2 : 1.25
            //Los valores seran: Franja_3 : 0.66

            float costo = 0;

            switch(this.franjaHorario)
            {
                case Franja.Franja_1:
                    costo = base.Duracion * 0.99f;
                  break;
                case Franja.Franja_2:
                    costo = base.Duracion * 1.25f;
                  break;
                case Franja.Franja_3:
                    costo = base.Duracion * 0.66f;
                  break;
            }

            return costo;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType()) 
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.Mostrar());
            datos.AppendLine($" Costo de la Llamada: {this.CostoLlamada}");
            datos.AppendLine($" Franja Horaria: {this.franjaHorario}");

            return datos.ToString();
        }

        public bool Guardar()
        {
            FileStream write = null;
            BinaryFormatter serializar = null;

            if(this is Provincial)
            {
                try
                {
                    write = new FileStream(this.RutaDelArchivo, FileMode.Create);
                    serializar = new BinaryFormatter();
                    serializar.Serialize(write, this);
                    return true;
                }
                finally
                {
                    write.Close();
                }
            }
            else
            {
                throw new InvalidCastException();            
            }
        }

        public Provincial Leer()
        {
            FileStream read = null;
            BinaryFormatter serializar = null;

            if (this is Provincial)
            {
                try
                {
                    read = new FileStream(this.RutaDelArchivo, FileMode.Open);
                    serializar = new BinaryFormatter();
                    return (Provincial)serializar.Deserialize(read);
                }
                finally
                {
                    read.Close();
                }
            }
            else
            {
                throw new InvalidCastException();
            }
        }
    }
}
