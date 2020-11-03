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
        public static void Guardar(string path, string info)
        {
            if(path.Length == 17 || Directory.Exists(path.Substring(0,path.Length-18)))
            {
                StreamWriter steam = null; //Para tenerlo declarado desde fuera y poder usarlo en el finally.

                try
                {
                    //steam = new StreamWriter(path + @"\" + nombre, true); //Esto, si no le pasas path va a ir a C:\archivo y no tenes permisos.
                    // En realidad deberia ir al default que es el debug del bin.
                    // A vos te pasaban una ruta asi: C:\escritorio\lacarpetadejuan\estonoesporno
                    // Vos hardcodeabas el nombre asi: \blablabla
                    // Cuando te pasaban "" (vacio), querian el default.
                    // Como vos ponias \blablaba no se iba al default, se iba al C:\blablabla
                    steam = new StreamWriter(path, true); //Esto es abrir el archivo, open.
                    steam.WriteLine(info); //Escribe el archivo
                }
                finally //Esto siempre se ejecuta
                {
                    if (steam != null) //Para saber si apunta a un archivo o a null.
                    {
                        steam.Close(); //Cierra el archivo
                    }
                }
            }
        }

        public static string Leer(string path)
        {
            StreamReader leer = null;

            if (!File.Exists(path))
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
