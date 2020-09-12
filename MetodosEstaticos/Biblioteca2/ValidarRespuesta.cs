using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            if(c == 'S' || c == 's')
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}