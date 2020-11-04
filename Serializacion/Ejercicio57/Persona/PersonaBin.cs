using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Persona
{
    public class PersonaBin
    {
        private string nombre;
        private string apellido;

        public PersonaBin()
        {

        }

        public PersonaBin(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(PersonaBin p)
        {
            FileStream writer = null;
            BinaryFormatter serializar = null;

            try
            {
                writer = new FileStream("PersonaBin", FileMode.Create);
                serializar = new BinaryFormatter();
                serializar.Serialize(writer, p);
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }
        }

        public static PersonaBin Leer()
        {
            FileStream read = null;
            BinaryFormatter deserializar = null;

            try
            {
                read = new FileStream("PersonaBin", FileMode.Open);
                deserializar = new BinaryFormatter();
                return (PersonaBin)deserializar.Deserialize(read);
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

            datos.AppendLine($"Nombre: {this.nombre}");
            datos.AppendLine($"Apellido: {this.apellido}");

            return datos.ToString();
        }
    }
}
