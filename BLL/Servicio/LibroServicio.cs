using DAL.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace BLL.Servicio
{
    public sealed class LibroServicio : IGenericRepository<LIBRO>
    {
        #region
        private readonly static LibroServicio _instance = new LibroServicio();
        public static LibroServicio Instance { get { return _instance; } }
        private LibroServicio()
        {
        }
        #endregion
        public void Insertar(LIBRO obj)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Modificar(LIBRO obj)
        {
            throw new NotImplementedException();
        }

        public LIBRO ObtenerUno(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LIBRO> ObtenerTodo()
        {
            throw new NotImplementedException();
        }
        

    }
}
