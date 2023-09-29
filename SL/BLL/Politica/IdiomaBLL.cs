using SL.DAL.Idioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.Politica
{
    public sealed class IdiomaBLL
    {
        #region Singleton
        private readonly static IdiomaBLL _instance = new IdiomaBLL();
        public static IdiomaBLL Instance { get { return _instance; } }
        private IdiomaBLL() { }
        #endregion
        public string Traducir(string key, string lang)
        {
            try
            {
                return IdiomaDAL.Instance.Traducir(key, lang);
            }
            catch (PalabraInexistenteException ex)
            {
                //Determinar qué hago. 
                throw;
            }
        }
    }
}
