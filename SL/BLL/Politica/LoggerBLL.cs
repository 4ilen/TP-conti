using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.Politica
{
    internal static class LoggerBLL
    {
        public static void WriteLog(string message, string user)
        {
            DAL.Implementacion.LoggerRepository.Instance.WriteLog(message, user);
        }
    }
}
