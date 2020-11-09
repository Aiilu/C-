using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public PuntoDat()
        {

        }

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        public bool Guardar(string ruta, PuntoDat objeto)
        {
            FileStream writer = null;
            BinaryFormatter serializar = null;

            try
            {
                this.ValidarArchivo(ruta, true);

                writer = new FileStream(ruta, FileMode.Create);
                serializar = new BinaryFormatter();
                serializar.Serialize(writer, objeto);
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("No paso la validacion", ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            FileStream writer = null;
            BinaryFormatter serializar = null;

            try
            {
                writer = new FileStream(ruta, FileMode.Create);
                serializar = new BinaryFormatter();
                serializar.Serialize(writer, objeto);
                return true;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public PuntoDat Leer(string ruta)
        {
            FileStream read = null;
            BinaryFormatter deserializar = null;

            try
            {
                this.ValidarArchivo(ruta, true);

                read = new FileStream(ruta, FileMode.Open);
                deserializar = new BinaryFormatter();
                return (PuntoDat)deserializar.Deserialize(read);
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("No paso la validacion", ex);
            }
            finally
            {
                if (read != null)
                {
                    read.Close();
                }
            }
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".dat")
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .dat");
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", ex.InnerException);
            }

            return true;
        }
    }
}
