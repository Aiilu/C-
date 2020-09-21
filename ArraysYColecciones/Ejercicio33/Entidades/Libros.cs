using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libros
    {
        private List<string> paginas;

        public Libros()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                if(i >= 0 && i < this.paginas.Count)
                {
                    return this.paginas[i];
                }

                return string.Empty;
            }
            set
            {
                if (i < this.paginas.Count)
                {
                    this.paginas[i] = value;
                }
                else
                {
                    this.paginas.Add(value);
                }
            }
        }
    }
}
