using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Excepcion
{
    public class ClienteInexistente : Exception
    {
        public ClienteInexistente() : base("El cliente con el codigo y nombre indicado no existe")
        {

        }
    }
}
