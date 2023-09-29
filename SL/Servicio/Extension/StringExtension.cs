using SL.BLL.Politica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SL.Servicio.Extension
{
    public static class StringExtension
    {
        public static string Traducir(this string palabra, string lang)
        {
            return IdiomaBLL.Instance.Traducir(palabra, lang);
        }
    }
}
