using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtLong
    {
        public static int CantidadDeDigitos(this long var)
        {
            return (var.ToString()).Length;
        }
    }
}
