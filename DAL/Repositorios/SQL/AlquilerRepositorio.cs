using DAL.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace DAL.Repositorios.SQL
{
    public class AlquilerRepositorio : IGenericRepository<Alquiler>
    {
        public void Eliminar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Alquiler obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Alquiler obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alquiler> ObtenerTodo()
        {
            throw new NotImplementedException();
        }

        public Alquiler ObtenerUno(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
