using DAL.Contratos;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace DAL.Factory
{
    public sealed class Factory
    {
        private readonly static Factory _instance = new Factory();
        public string backend;
        public static Factory Instance { get { return _instance; } }
        private Factory()
        {
            backend = ConfigurationManager.AppSettings["backend"];
        }

        public IGenericRepository<CLIENTE> GetClienteRepositorio()
        {
            if (backend == "SQL")
            {
                return new Repositorios.SQL.ClienteRepositorio();
            }
            else
            {
                return null;
            }

        }
        public IGenericRepository<Alquiler> GetAlquilerRepositorio()
        {
            if (backend == "SQL")
            {
                return new Repositorios.SQL.AlquilerRepositorio();
            }
            else
            {
                return null;
            }

        }
        public IGenericRepository<LIBRO> GetLibroRepositorio()
        {
            if (backend == "SQL")
            {
                return new Repositorios.SQL.LibroRepositorio();
            }
            else
            {
                return null;
            }

        }
    }
}
