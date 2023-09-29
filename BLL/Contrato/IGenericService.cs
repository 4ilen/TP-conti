using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contrato
{
    public interface IGenericService <T>
    {
        void Insertar(T obj);
        void Eliminar(int id);
        void Modificar(T obj);
        T ObtenerUno(int id);
        IEnumerable<T> ObtenerTodo();
    }
}
