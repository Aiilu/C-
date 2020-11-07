using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class PersonaXml
    {
        private string nombre;
        private string apellido;

        public PersonaXml()
        {

        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public PersonaXml(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(PersonaXml p) //Convierte el object en xml
        {
            XmlTextWriter writer = null;
            XmlSerializer serializar = null;

            try
            {
                writer = new XmlTextWriter("Persona.xml", Encoding.UTF8); //Como va a abrir el archivo para escribir
                writer.Formatting = Formatting.Indented;
                serializar = new XmlSerializer(typeof(PersonaXml)); //Formato que se va a convertir
                serializar.Serialize(writer, p); //Aca formatea el objeto y lo deja en ese archivo
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }
        }

        public static PersonaXml Leer() //Convierte el xml en object
        {
            XmlTextReader read = null;
            XmlSerializer deserializar = null;

            try
            {
                read = new XmlTextReader("Persona.xml");

                deserializar = new XmlSerializer(typeof(PersonaXml));
                return (PersonaXml)deserializar.Deserialize(read);
            }
            finally
            {
                if(read != null)
                {
                    read.Close();
                }
            }
           
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Nombre {this.Nombre}");
            datos.AppendLine($"Apellido: {this.Apellido}");

            return datos.ToString();
        }
    }
}
