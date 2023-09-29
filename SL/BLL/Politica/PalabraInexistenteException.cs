using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.Politica
{
    public  class PalabraInexistenteException : Exception
    {
        public PalabraInexistenteException() : base ("No se ha encontrado la palabra para traducirla.")
        {

        }
    }
}
