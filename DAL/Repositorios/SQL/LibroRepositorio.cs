using DAL.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace DAL.Repositorios.SQL
{
    public class LibroRepositorio : IGenericRepository<LIBRO>
    {
        public void Eliminar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(LIBRO obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(LIBRO obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LIBRO> ObtenerTodo()
        {
            throw new NotImplementedException();
        }

        public LIBRO ObtenerUno(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
