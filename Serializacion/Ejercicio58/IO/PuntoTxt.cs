using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string objeto)
        {
            StreamWriter writer = null;

            try
            {
                this.ValidarArchivo(ruta, true);

                writer = new StreamWriter(ruta);
                writer.WriteLine(objeto);
            }
            catch(Exception ex)
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

            return true;
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(ruta);
                writer.WriteLine(objeto);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

            return true;
        }

        public string Leer(string ruta)
        {
            string datos;
            StreamReader read = null;

            try
            {
                this.ValidarArchivo(ruta, true);

                read = new StreamReader(ruta);
                return datos = read.ReadToEnd();
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
                    if (Path.GetExtension(ruta) == ".txt")
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .dat");
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", ex);
            }

            return true;
        }
    }
}
