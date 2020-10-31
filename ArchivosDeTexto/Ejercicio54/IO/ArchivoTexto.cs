using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ArchivoTexto
    {
        public static void Guardar(string path, string info, string nombre)
        {
            StreamWriter steam = null; //Para tenerlo declarado desde fuera y poder usarlo en el finally

            if(!Directory.Exists(path))
            {
                path = "";
            }

            try
            {
                steam = new StreamWriter(path + @"\" + nombre, true); //Esto es abrir el archivo, open.
                steam.WriteLine(info); //Escribe el archivo
            }
            finally //Esto siempre se ejecuta
            {
                if(steam != null) //Para saber si apunta a un archivo o a null.
                {
                    steam.Close(); //Cierra el archivo
                }
            }
        }

        public static string Leer(string path, string nombre)
        {
            StreamReader leer = null;

            if (!File.Exists(path + @"\" + nombre))
            {
                throw new FileNotFoundException();
            }

            try
            {
                leer = new StreamReader(path); //Esto abre el archivo en modo lectura
                return leer.ReadToEnd();
            }
            finally
            {
                if(leer != null)
                {
                    leer.Close();
                }
            }
        }

    }

}
