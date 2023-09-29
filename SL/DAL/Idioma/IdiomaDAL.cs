using SL.BLL.Politica;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Idioma
{
    public sealed class IdiomaDAL
    {
        #region
        private readonly static IdiomaDAL _instance = new IdiomaDAL();
        public static IdiomaDAL Instance { get { return _instance; } }
        private IdiomaDAL()
        {

        }
        #endregion

        private string folderLanguage = ConfigurationManager.AppSettings["FolderLanguage"];
        private string filePathLanguage = ConfigurationManager.AppSettings["FilePathLanguage"];
        public string Traducir(string key, string lang)
        {
            string filePath = $"{folderLanguage}/{filePathLanguage}{lang}";

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string[] dataFile = sr.ReadLine().Split('=');

                    if (dataFile[0] == key)
                    {
                        return dataFile[1];
                    }

                }
            }
            throw new PalabraInexistenteException();
        }
        public List<string> GetIdiomaDisponible()
        {
            //new DirectoryInfo(folderLanguage).GetFiles(); min 38:22
            return null;
        }
    }
}
