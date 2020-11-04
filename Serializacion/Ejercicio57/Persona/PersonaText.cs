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
    public class PersonaText
    {
        private string nombre;
        private string apellido;

        public PersonaText()
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

        public PersonaText(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(PersonaText p) //Convierte el object en xml
        {
            XmlTextWriter writer = null;
            XmlSerializer serializar = null;

            try
            {
                writer = new XmlTextWriter("Persona.xml", Encoding.UTF8); //Como va a abrir el archivo para escribir
                writer.Formatting = Formatting.Indented;
                serializar = new XmlSerializer(typeof(PersonaText)); //Formato que se va a convertir
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

        public static PersonaText Leer() //Convierte el xml en object
        {
            XmlReader read = null;
            XmlSerializer deserializar = null;

            try
            {
                read = new XmlTextReader("Persona.xml");

                deserializar = new XmlSerializer(typeof(PersonaText));
                return (PersonaText)deserializar.Deserialize(read);
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
