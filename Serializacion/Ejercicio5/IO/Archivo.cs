using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    [Serializable]
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            if(validaExistencia == true)
            {
                if(File.Exists(ruta))
                {
                    return true;
                }
            }

            throw new FileNotFoundException();
        }
    }
}
