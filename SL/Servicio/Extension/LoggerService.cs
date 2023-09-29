using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Servicio.Extension
{
    public static class LoggerService
    {
        public static void WriteLog(string message, string user)
        {
            BLL.Politica.LoggerBLL.WriteLog(message, user);
        }
    }
}
