using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Local :Llamada, IGuardar<Local>
    {
        protected float coast;

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion,destino,origen)
        {
            this.coast = costo;
        }

        public float Costo
        {
            get
            {
                return this.coast;
            }
            set
            {
                this.coast = value;
            }
        }

        public Local() : base()
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
                return "Local.xml";
            }
            set
            {
            }
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.coast;
        }

        public override bool Equals(object obj)
        {
            //Devuelve la clase.
            if(obj.GetType() == this.GetType())
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

            return datos.ToString();
        }

        public bool Guardar()
        {
            XmlTextWriter write = null;
            XmlSerializer serializacion = null;

            if(this is Local)
            {
                try
                {
                    write = new XmlTextWriter(this.RutaDelArchivo, Encoding.UTF8);
                    write.Formatting = Formatting.Indented;
                    serializacion = new XmlSerializer(typeof(Local));
                    serializacion.Serialize(write, this);
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

        public Local Leer()
        {
            XmlTextReader read = null;
            XmlSerializer deserializacion = null;

            if(this is Local)
            {
                try
                {
                    read = new XmlTextReader(this.RutaDelArchivo);
                    deserializacion = new XmlSerializer(typeof(Local));
                    return (Local)deserializacion.Deserialize(read);
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
