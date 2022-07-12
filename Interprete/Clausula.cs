using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interprete
{
    public class Clausula
    {
        public string cabezaH { get; set; }
        public string[] objetosH { get; set; }

        public Clausula(string cabezaH, string[] objetosH)
        {
            this.cabezaH = cabezaH;
            this.objetosH = objetosH;
        }

    }
}
