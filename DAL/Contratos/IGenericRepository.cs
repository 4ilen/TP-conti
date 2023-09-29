using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contratos
{
    public interface IGenericRepository <T>
    {
        void Insertar(T obj);
        void Eliminar(Guid id);
        void Modificar(T obj);
        T ObtenerUno(Guid id);
        IEnumerable<T> ObtenerTodo();
    }
}
