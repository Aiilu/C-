using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SobreSobreescrito :Sobreescrito
    {
        public SobreSobreescrito(string miAt) : base(miAt)
        {

        }

        public override string MiPropiedad
        {
            get
            {
                return base.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }
    }
}
